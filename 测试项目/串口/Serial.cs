using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Configuration;
using NPOI.POIFS.Crypt.Dsig;
using static PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLC报警显示控件实现类.PLCEvent_DataList;

namespace HD烟灶联动项目.串口
{
    /// <summary>
    /// 串口实现类
    /// </summary>

    public class Serial
    {
        /// <summary>
        /// 打开串口的名称
        /// </summary>
        protected  string ProtName { set; get; } = "COM3";
        /// <summary>
        /// 串口对象
        /// </summary>
        protected SerialPort serialPort { set; get; }=new SerialPort();
        /// <summary>
        /// 端口读写日志
        /// </summary>
        public event EventHandler ProtMessage;
        /// <summary>
        /// 检测串口是否打开成功
        /// </summary>
        public bool IsProt 
        {
            get
            {
                return serialPort.IsOpen & serialPort.BreakState != true ? true : false;
            }
        }

        public Serial()
        {
            serialPort = new SerialPort("COM1")
            {
                BaudRate = 9600,//波特率
                DataBits = 0,//停止位
                Parity = Parity.None,//奇偶校验
                StopBits = StopBits.None,//停止位
                WriteTimeout = 20000,//写入超时时间
                ReadTimeout = 20000,//读取超时时间
            };
            serialPort.ErrorReceived += ((send, e) =>
            {
                string OpenMess = $"{serialPort.PortName}端口异常";
                //发布串口消息
                ProtMess(OpenMess);
                serialPort.Close();
            });
            //发布串口消息
            ProtMess($"波特率:{serialPort.BaudRate},停止位:{serialPort.DataBits},奇偶校验:{serialPort.Parity}," +
                $"停止位:{serialPort.StopBits},写入超时时间:{serialPort.WriteTimeout},读取超时时间:{serialPort.ReadTimeout}");
            serialPort.Open();//打开串口
            string OpenMess = serialPort.IsOpen & serialPort.BreakState != true ? $"{serialPort.PortName}端口打开成功" :
    $"{serialPort.PortName}端口打开失败";
            //发布串口消息
            ProtMess(OpenMess);
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="protName">打开端口的名称</param>
        /// <param name="ReadTimer">读取超时时间</param>
        /// <param name="WriteTimer">写入超时时间</param>
        public Serial(string protName, int ReadTimer, int WriteTimer)
        {
            serialPort = new SerialPort(protName ?? "COM1")
            {
                BaudRate = 9600,//波特率
                DataBits = 8,//停止位
                Parity = Parity.None,//奇偶校验
                StopBits = StopBits.One,//停止位
                WriteTimeout = WriteTimer,//写入超时时间
                ReadTimeout = ReadTimer,//读取超时时间
            };
            //发布串口消息
            ProtMess($"波特率:{serialPort.BaudRate},停止位:{serialPort.DataBits},奇偶校验:{serialPort.Parity}," +
                $"停止位:{serialPort.StopBits},写入超时时间:{serialPort.WriteTimeout},读取超时时间:{serialPort.ReadTimeout}");
            serialPort.Open();//打开串口
            string OpenMess = serialPort.IsOpen & serialPort.BreakState != true ? $"{serialPort.PortName}端口打开成功" :
    $"{serialPort.PortName}端口打开失败";
            //发布串口消息
            ProtMess(OpenMess);

        }
        /// <summary>
        /// 读取串口的数据
        /// </summary>
        /// <returns>返回读取数据以及操作结果</returns>

        public virtual OperateResult<byte[]> ReadProt()
        {
            if (serialPort.BytesToRead > 0 & this.IsProt)
            {
                byte[] Data = new byte[serialPort.BytesToRead];
                serialPort.Read(Data, 0, Data.Length);
                serialPort.DiscardInBuffer();//清空可读取的串口报文
                string OpenMess = serialPort.IsOpen & serialPort.BreakState != true ? $"{serialPort.PortName}向端口读取成功" :
   $"{serialPort.PortName}向端口读取失败";
                //发布串口消息
                ProtMess(OpenMess + $"\r\n {BitConverter.ToString(Data)}");
                return new OperateResult<byte[]>(this.IsProt) { Result = Data };
            }
            else
            {
                return new OperateResult<byte[]>(this.IsProt);
            }
        }
        /// <summary>
        /// 向串口发送消息
        /// </summary>
        /// <param name="MessData">需要向串口发送的消息</param>
        /// <returns></returns>
        public virtual OperateResult<byte[]> WriteProt(byte[] MessData)
        {
            if (serialPort!=null & this.IsProt)
            {
                serialPort.DiscardInBuffer();//清空可读取的串口报文
                serialPort.Write(MessData, 0, MessData.Length);
                string OpenMess = serialPort.IsOpen & serialPort.BreakState != true ? $"{serialPort.PortName}向端口发送成功" :
  $"{serialPort.PortName}向端口发送失败";
                //发布串口消息
                ProtMess(OpenMess + $"\r\n {BitConverter.ToString( MessData)}");
                return new OperateResult<byte[]>(this.IsProt) { Result = MessData };
            }
            else
                return new OperateResult<byte[]>(this.IsProt);
        }

        /// <summary>
        /// 串口操作消息
        /// </summary>
        /// <param name="Mess">需要发布的消息内容</param>
        public virtual void ProtMess(string Mess)
        {
            //添加
            if (ProtMessage != null)
                ProtMessage.Invoke($"\r\n{DateTime.Now}: " +
                   Mess, new EventArgs());
        }


        ~Serial()
        {
          if (serialPort!=null)
                serialPort.Close();
        }
    }
}
