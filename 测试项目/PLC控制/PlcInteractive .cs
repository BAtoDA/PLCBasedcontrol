using HD烟灶联动项目.实现;
using NPOI.SS.Formula.Functions;
using PLC通讯库.通讯基础接口;
using PLC通讯库.通讯枚举;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HD烟灶联动项目.PLC控制
{
    /// <summary>
    /// PLC状态读取刷新
    /// </summary>
    internal class PlcInteractive : PLCInterface
    {
        public bool PlcStart { set; get; }
        public bool TaskBusy { set; get; }
        public short TaskConclusion { set; get; }

        public event EventHandler TaskEventRun;

        public event EventHandler TaskEventErr;

        /// <summary>
        /// PLC接口
        /// </summary>

        protected IPLC_interface plc { set; get; }

        /// <summary>
        /// 定时刷新读取PLC状态
        /// </summary>

        protected System.Windows.Forms.Timer timer { set; get; }
        /// <summary>
        /// 异步任务对象
        /// </summary>
        private CancellationTokenSource cts { set; get; }
        /// <summary>
        /// 异步任务令牌-用于取消任务运行
        /// </summary>
        private CancellationToken token { set; get; }
        /// <summary>
        /// 任务锁
        /// </summary>

        private object obj = new object();
        /// <summary>
        /// 任务日志
        /// </summary>
        public event EventHandler TaskMessage;
        /// <summary>
        /// 串口对象
        /// </summary>
        private PortAchieve PortOop { set; get; }

        /// <summary>
        /// 获取PLC操作接口
        /// </summary>
        /// <param name="pLC">PLC底层接口</param>
        /// <param name="Function">读写PLC的功能码</param>
        /// <param name="Address">读写PLC的地址</param>
        public PlcInteractive(IPLC_interface pLC, PortAchieve achieve)
        {
            this.plc = pLC;//获取plc接口
            this.PortOop = achieve;
            //写入消息
            TaskRunMess($"PLC_IP:{pLC.IPEndPoint.Address},PLC_Port:{pLC.IPEndPoint.Port}");
        }
        /// <summary>
        /// PLC刷新任务启动
        /// </summary>
        /// <param name="function">数组[0]:PlcStart  数组[1]:TaskBusy 数组[2]:TaskConclusion</param>
        /// <param name="address">数组[0]:PlcStart  数组[1]:TaskBusy 数组[2]:TaskConclusion</param>
        /// <returns></returns>
        public async Task TaskRun(string[] function, string[] address)
        {
            if (plc != null && plc.PLC_ready && PlcStart == false)
            {
                //生产异步任务令牌
                cts = new CancellationTokenSource();
                token = cts.Token;
                //写入消息
                TaskRunMess($"任务自动运行开始产生线程");
                //开始异步任务-读写PLC状态
                var t = Task.Run(() =>
                {
                    Thread.Sleep(300);
                    PlcStart = this.plc.PLC_read_M_bit(function[0], address[0]);
                    //写入消息
                    TaskRunMess($"当前PLC_Task启动信号：{PlcStart}");
                    //判断是否可以启动任务
                    if (TaskEventRun != null && PlcStart)
                    {
                        //写入消息
                        TaskRunMess($"开始处理PLC状态");
                        Thread.Sleep(200);
                        this.plc.PLC_write_M_bit(function[1], address[1], Button_state.ON);
                        TaskEventRun.Invoke(PlcStart, new EventArgs());
                        Thread.Sleep(200);
                        this.plc.PLC_write_M_bit(function[0], address[0], Button_state.Off);
                        Thread.Sleep(200);
                        //this.plc.PLC_write_D_register(function[1], address[1], TaskConclusion.ToString(), numerical_format.Signed_16_Bit);
                        this.plc.PLC_write_M_bit(function[1], address[1], Button_state.Off);
                        Thread.Sleep(200);
                        this.plc.PLC_write_M_bit(function[0], address[0], Button_state.ON);
                        PlcStart = false;
                        //写入消息
                        TaskRunMess($"处理任务结束结论写入完成");

                    }
                }, token);
                await t;
            }
        }
    
        /// <summary>
        /// 手动测试启动任务
        /// </summary>
        /// <param name="function"></param>
        /// <param name="address"></param>
        /// <returns></returns>
        public async Task TaskRun()
        {
            //判断是否可以启动任务
            if (TaskEventRun != null && PlcStart == false)
            {
                //生产异步任务令牌
                cts = new CancellationTokenSource();
                token = cts.Token;
                //写入消息
                TaskRunMess($"手动任务运行开始产生线程");
                //开始异步任务-读写PLC状态
                await Task.Run(() =>
                {
                    //写入消息
                    TaskRunMess($"手动任务运行中");
                    PlcStart = true;
                    TaskEventRun.Invoke(PlcStart, new EventArgs());
                    PlcStart = false;
                    //写入消息
                    TaskRunMess($"手动任务运行停止");


                }, token);
            }
        }
        /// <summary>
        /// 任务取消
        /// </summary>
        /// <returns></returns>
        public void TaskClose()
        {
            //写入消息
            TaskRunMess($"请求任务运行停止");
            if (cts != null)
            {
                cts.Cancel(); // 请求取消
            }
            if (PortOop != null)
                PortOop.PortStop = true;
        }
        /// <summary>
        /// 任务操作日志
        /// </summary>
        /// <param name="Mess">需要发布的消息内容</param>
        public virtual void TaskRunMess(string mess)
        {
            //添加
            if (TaskMessage != null)
                TaskMessage.Invoke($"\r\n{DateTime.Now}: " +
                   mess, new EventArgs());
        }
    }
}
