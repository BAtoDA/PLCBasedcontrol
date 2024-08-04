using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using HD烟灶联动项目.串口;
using System.Windows.Forms;
using ZXing;
using NPOI.HPSF;
using System.Diagnostics;
using HslCommunication.Robot.EFORT;

namespace HD烟灶联动项目.实现
{
    public class PortAchieve : Serial
    {
        
        /// <summary>
        /// 刷新定时器
        /// </summary>
       private System.Windows.Forms.Timer RefreshTime { get;set; }=new System.Windows.Forms.Timer() 
       { Interval=500, Enabled=false };
        /// <summary>
        /// 超时定时器
        /// </summary>
       private System.Timers.Timer timeout { get; set; } = new System.Timers.Timer() 
       { Enabled=false };
        /// <summary>
        /// 最大超时定时器
        /// </summary>
        public int timeoutMax { set; get; } =10000;
        /// <summary>
        /// 指示着串口是否忙
        /// </summary>
        public bool PortBusy { set; get; }
        /// <summary>
        /// 指示着程序需要停止--超时
        /// </summary>
        public bool PortStop { set; get; }
        /// <summary>
        /// 从端口读取超时标志
        /// </summary>
        public bool Timeout { set; get; }
        /// <summary>
        /// 读取到检测模块的数据
        /// </summary>
        public int PortData { set; get; }
        /// <summary>
        /// 读取到检测模块的地址数据
        /// </summary>
        public byte[] PortAddress { set; get; } = new byte[2];
        /// <summary>
        /// 读取到检测模块的信号强度
        /// </summary>
        public byte PortRssi { set; get;  }
        /// <summary>
        /// 读取到检测模块的报文存储地址
        /// </summary>
        public List<byte[]> PortMessageArray { set; get; }=new List<byte[]>();
        /// <summary>
        /// 从检测模块读取到多少次报文就停止读取
        /// </summary>
        public int MessageArrayMax { set; get; } = 6;
        /// <summary>
        /// 报文一帧必须是==16
        /// </summary>
        public int MessageMax { set; get; } = 15;
        /// <summary>
        /// 报文CRC标准报文
        /// </summary>
        private  byte[] MessageCrc=new byte[6] { 165,177,178,179 ,180,181 };
        /// <summary>
        /// 端口读写消息
        /// </summary>
        public event EventHandler MessageShow;
        /// <summary>
        /// 报告当前消息的进度
        /// </summary>
        public event EventHandler MessageProcessBar;
        /// <summary>
        /// 任务锁
        /// </summary>

        private object obj = new object();

        public PortAchieve()
        {

        }
        public PortAchieve(string protName, int ReadTimer, int WriteTimer) : base(protName, ReadTimer, WriteTimer)
        {

        }

        public void TaskStart()
        {
            lock (obj)
            {
                //判断串口是否忙
                if (PortBusy) return;
                PortStop = false;
                Timeout = false;
                PortBusy = true;
                //清空状态数据
                PortData = 0;
                PortAddress[0] = 0;
                PortAddress[1] = 0;
                PortRssi = 0;
                ProcessBarShow(0);//写入当前进度
                PortMessageArray.Clear();//清空泛型列表
                                         //启动定时器
                this.timeout.Enabled = true;
                this.timeout.Interval = timeoutMax;
                this.timeout.Elapsed += ((send, e) =>
                {
                    PortStop = true;
                    Timeout = true;
                    EventShow($"\r\n读取报文超时。");//写入消息
                    this.timeout.Stop();
                });
                this.timeout.Start();

                ////调用异步任务取处理
                //await Task.Run(() =>
                //{
                int le = 0;
                while (!PortStop)
                {
                    if (le < MessageArrayMax)
                    {
                        //判断串口是否有数据读取
                        if (this.serialPort.BytesToRead > 0)
                        {
                            OperateResult<byte[]> result = ReadProt();
                            if (result.isResult)
                            {
                                if (result.Result.Length == MessageMax)
                                {
                                    //进行CRC校验
                                    if (PortCrc(result.Result))
                                    {
                                        PortMessageArray.Add(result.Result);
                                        EventShow(BitConverter.ToString(result.Result));//写入消息
                                        ProcessBarShow((100 / MessageArrayMax) * (le + 1));//写入当前进度
                                        le++;
                                    }
                                    else
                                        EventShow("CRC校验错误：" + BitConverter.ToString(result.Result));//写入消息

                                }
                                else
                                    EventShow($"报文错误：当前报文数量{result.Result.Length} 不等于 ：{MessageMax} 报文如下：\r\n" + BitConverter.ToString(result.Result));//写入消息
                            }
                        }
                        if (PortMessageArray.Count >= MessageArrayMax)
                        {
                            PortStop = true;
                            break;
                        }
                    }
                }
                //读取完成
                PortStop = true;
                if (PortMessageArray != null && PortMessageArray != null && PortMessageArray.Count >= MessageArrayMax)
                {
                    List<int> Data = new List<int>();
                    List<byte> RssiData = new List<byte>();
                    //读取表中的地址
                    System.Array.Copy(PortMessageArray[0], 3, PortAddress, 0, 2);
                    foreach (var i in PortMessageArray)
                    {
                        Data.Add(BitConverter.ToInt16(new byte[] { i[7], i[6] }, 0));
                        RssiData.Add(i[14]);
                    }
                    //输出平均值
                    PortData = Convert.ToInt32(Data.Average());
                    PortRssi = Convert.ToByte(RssiData.Select(p => (double)p).Average());
                }
                //});
                this.timeout.Stop();
                ProcessBarShow(100);//写入当前进度
                PortBusy = false;
            }
        }

        /// <summary>
        /// 停止任务
        /// </summary>
        /// <param name="Close"></param>
        public void TaskClose(bool Close)
        {
            PortStop = Close;
        }
        /// <summary>
        /// 报文CRC校验
        /// </summary>
        /// <param name="Data"></param>
        /// <returns></returns>
        private bool PortCrc(byte[] Data)
        {
            if (Data.Length == MessageMax)
            {
                byte[] CrcData = new byte[6];
                System.Array.Copy(Data, 8, CrcData, 0, 6);
                return CrcData.SequenceEqual(MessageCrc);
            }
            return false;
        }
        /// <summary>
        /// 显示报文消息
        /// </summary>
        /// <param name="Mess">需要写入的消息</param>
        private void EventShow(string Mess)
        {
            if(MessageShow!=null)
            {
                MessageShow.Invoke($"\r\n{DateTime.Now}"+Mess, new EventArgs());
            }
        }
        /// <summary>
        /// 显示当前任务的进度
        /// </summary>
        /// <param name="Bar"></param>
        private void ProcessBarShow(int  Bar)
        {
            if (MessageProcessBar != null)
            {
                MessageProcessBar.Invoke( Bar, new EventArgs());
            }
        }
    }
}
