//**********************************************************************
//
// 文件名称(File Name)：
// 功能描述(Description)：
// 作者(Author)：DAtoTA
// 日期(Create Date)： 2021/9/9 21:29:04
//
//**********************************************************************
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using PLC通讯基础控件项目.控件类基.控件安全对象池;
using PLC通讯基础控件项目.控件类基.控件数据结构;
using System.Reflection;
using PLC通讯基础控件项目.控件类基.控件文本键盘;
using PLC通讯库.通讯基础接口;
using PLC通讯库.PLC通讯设备类型表;
using PLC通讯库.通讯实现类;

namespace PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLCD控件实现类
{
    /// <summary>
    /// 实现基本寄存器控件类--PLC刷新--文字事件等处理
    /// </summary>
    public sealed partial class ControlPLCDBase : BasepublicClass
    {
        #region 实现基本接口  
        //基础外部文本颜色 与 内容控制
        /// <summary>
        /// 控件保存的参数
        /// </summary>
        PLCDClassBase pLCDClassBase;
        /// <summary>
        /// 控件外部文字已经背景颜色等参数
        /// </summary>
        PLCDproperty pLCDproperty;
        /// <summary>
        /// 安全控制状态--true正确 false 异常
        /// </summary>
        bool SafetyPattern;
        /// <summary>
        /// 控件对象
        /// </summary>
        Control PlcControl;
        /// <summary>
        /// 复归型按钮标志位
        /// </summary>
        private volatile bool State = false;
        /// <summary>
        /// PLC安全操作模式
        /// </summary>
        volatile Safetypattern PLCsafetypattern = Safetypattern.Nooperation;
        #endregion
        public ControlPLCDBase(Control PlcControl)
        {
            //---------处理控件接口问题---------
            if (!(PlcControl is PLCDClassBase)) throw new Exception($"{PlcControl.GetType().Name} 不实现：PLCDClassBase接口");
            if (!(PlcControl is PLCDproperty)) throw new Exception($"{PlcControl.GetType().Name} 不实现：PLCDproperty接口");
            pLCDClassBase = PlcControl as PLCDClassBase;
            pLCDproperty = PlcControl as PLCDproperty;
            //----------处理控件PLC--自动获取PLC类型对象----------
            PLCoopErr(pLCDClassBase, pLCDproperty);
            this.PlcControl = PlcControl;
            //----------处理控件与PLC事件处理---------------------
            if (((dynamic)PlcControl).PLC_Enable)
            {
                PlcControl.MouseUp += MouseUpPLC;
                pLCDproperty.PLCTimer = new System.Threading.Timer(new TimerCallback((s) =>
                {
                    this.PLCrefresh();
                }));
                pLCDproperty.PLCTimer.Change(500, 300);
            }
            this.PlcControl.Text = "0";
            //---------安全操作模式----------
            PLCsafetypattern = pLCDClassBase.pLCDselectRealize.OperationAffirm ? Getsafetypattern(pLCDClassBase.pLCDselectRealize.SafetyBehaviorPattern) : Safetypattern.Nooperation;
        }
        /// <summary>
        /// 处理鼠标点击事件
        /// </summary>
        /// <param name="send"></param>
        /// <param name="e"></param>
        private void MouseUpPLC(object send,EventArgs e)
        {
            //语音播报系统
            if (pLCDClassBase.pLCDselectRealize.Speech && pLCDClassBase.pLCDselectRealize.OperationAffirm)
            {
                Voicebroadcast($"{this.PlcControl.Name}已触发");
            }
            //判断该控件是否启用键盘
            if (pLCDClassBase.pLCDselectRealize.Keyboard==false || pLCDClassBase.pLCDselectRealize.Dataentryfunction==false || PLCsafetypattern == Safetypattern.Close) return;
            //----------处理控件PLC--自动获取PLC类型对象----------
            PLCoopErr(pLCDClassBase, pLCDproperty);
            //----------调用对象池处理----------------------------
            //判断对象池是否为空
            if (ObjectPool<Tuple<Stopwatch, System.Windows.Forms.Timer>>._objects == null) return;
            //向对象池申请 
            var Poss = ObjectPool<Tuple<Stopwatch, System.Windows.Forms.Timer>>.GetObject();
            //开始测量定时
            Poss.Item1.Start();
            //获取控件鼠标松开事件
            PlcControl.MouseUp += SafetyClick;
            //开始定时处理委托任务
            Poss.Item2.Enabled = true;
            Poss.Item2.Interval = Convert.ToInt32(pLCDClassBase.pLCDselectRealize.keyMinTime + (pLCDClassBase.pLCDselectRealize.OperationAffirm ? pLCDClassBase.pLCDselectRealize.AwaitTime : 0)) < 1 ? 1 : Convert.ToInt32(pLCDClassBase.pLCDselectRealize.keyMinTime + (pLCDClassBase.pLCDselectRealize.OperationAffirm ? pLCDClassBase.pLCDselectRealize.AwaitTime : 0));
            Poss.Item2.Start();
            //判断是否到达安全范围
            Poss.Item2.Tick += SafetyTick;
            //---------------安全处理方法---------------
            void SafetyClick(object send, EventArgs e)
            {
                Poss.Item1.Stop();
            }
            void SafetyTick(object send, EventArgs e)
            {
                Poss.Item2.Stop();
                Poss.Item1.Stop();
                Poss.Item2.Enabled = false;
                if (Poss.Item1.Elapsed.TotalMilliseconds >= Convert.ToInt32(pLCDClassBase.pLCDselectRealize.keyMinTime + (pLCDClassBase.pLCDselectRealize.OperationAffirm ? pLCDClassBase.pLCDselectRealize.AwaitTime : 0)))
                {
                    try
                    {
                        //判断用户选择的键盘
                        var Keytype = Assembly.GetEntryAssembly().GetType("PLC通讯基础控件项目.控件类基.控件文本键盘." + pLCDClassBase.pLCDselectRealize.KeyboardStyle);
                        object[] Value = new object[] { this.PlcControl.Text, this.pLCDClassBase.pLCDselectRealize };
                        dynamic Keyoop = Activator.CreateInstance(Keytype, Value);
                        Keyoop.ShowDialog();
                        this.PlcControl.Text = Keyoop.O_Text;
                    }
                    catch
                    {
                        //异常处理键盘
                        keyboard keyboard = new keyboard(this.PlcControl.Text, this.pLCDClassBase.pLCDselectRealize);
                        keyboard.ShowDialog();
                    }
                    finally
                    {
                        //写入当前控件值
                        PLCWrite(this.pLCDClassBase.pLCDselectRealize.ReadWrite ? this.pLCDClassBase.pLCDselectRealize.WritePLC : this.pLCDClassBase.pLCDselectRealize.ReadWritePLC, this.pLCDClassBase.pLCDselectRealize.ReadWrite ? this.pLCDClassBase.pLCDselectRealize.WriteFunction : this.pLCDClassBase.pLCDselectRealize.ReadWriteFunction, this.pLCDClassBase.pLCDselectRealize.ReadWrite ? this.pLCDClassBase.pLCDselectRealize.WriteAddress : this.pLCDClassBase.pLCDselectRealize.ReadWriteAddress, this.PlcControl.Text, this.pLCDClassBase.pLCDselectRealize.ShowFormat);
                    }
                }
                //处理完成归还对象
                PlcControl.MouseUp -= SafetyClick;
                Poss.Item2.Tick -= SafetyTick;
                ObjectPool<Tuple<Stopwatch, System.Windows.Forms.Timer>>.PutObject(Poss);
            }
        }
        /// <summary>
        /// 写入PLC操作
        /// </summary>
        private void PLCWrite(PLC IPLC, string Id, string Addary, string Value,PLC通讯库.通讯枚举.numerical_format numerical_Format)
        {
            IPLC_interface PLCoop = IPLCsurface.PLCDictionary.GetValueOrDefault(IPLC.ToString()) as IPLCcommunicationBase;
            //bool OopType = (bool)PLCoop.GetType().GetField("PLC_ready", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance).GetValue(PLCoop);
            if (PLCoop.PLC_ready)
                PLCoop.PLC_write_D_register(Id, Addary, Value, numerical_Format);
        }
        /// <summary>
        /// 处理控件值--读取PLC
        /// </summary>
        private void PLCrefresh()
        {

        }
    }
}
