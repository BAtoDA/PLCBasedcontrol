//**********************************************************************
//
// 文件名称(File Name)：
// 功能描述(Description)：
// 作者(Author)：DAtoTA
// 日期(Create Date)： 2021/8/29 10:55:47
//
//**********************************************************************
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using PLC通讯基础控件项目.控件类基.控件安全对象池;
using PLC通讯基础控件项目.控件类基.控件数据结构;
using PLC通讯库.PLC通讯设备类型表;
using PLC通讯库.通讯实现类;
using PLC通讯库.通讯枚举;

namespace PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类
{
    /// <summary>
    /// 实现基本控件类--PLC刷新--文字事件等处理
    /// </summary>
    public sealed partial class ControlPLCBitBase 
    {
        #region 实现基本接口  
        //基础外部文本颜色 与 内容控制
        /// <summary>
        /// 控件保存的参数
        /// </summary>
        PLCBitClassBase pLCBitClassBase;
        /// <summary>
        /// 控件外部文字已经背景颜色等参数
        /// </summary>
        PLCBitproperty pLCBitproperty;
        /// <summary>
        /// 安全控制状态--true正确 false 异常
        /// </summary>
        bool SafetyPattern;
        /// <summary>
        /// 控件对象
        /// </summary>
        Control PlcControl;
        #endregion
        /// <summary>
        /// 构造函数
        /// </summary>
        public ControlPLCBitBase(Control PlcControl)
        {
            if (!(PlcControl is PLCBitClassBase)) throw new Exception($"{PlcControl.GetType().Name} 不实现：PLCBitBase接口");
            if (!(PlcControl is PLCBitproperty)) throw new Exception($"{PlcControl.GetType().Name} 不实现：PLCBitproperty接口");
            pLCBitClassBase = PlcControl as PLCBitClassBase;
            pLCBitproperty = PlcControl as PLCBitproperty;
            //读取PLC--自动获取对象的PLC类型对象
            PLCoopErr();
            //---------处理控件与PLC通讯事件---------
            if (((dynamic)PlcControl).PLC_Enable)
            {
                PlcControl.Click += ClickPLC;
                PlcControl.MouseUp += MouseUpPLC;
                pLCBitproperty.PLCTimer = new System.Threading.Timer(new TimerCallback((s) =>
                {
                    this.PLCrefresh();
                }));
                pLCBitproperty.PLCTimer.Change(500, 300);
            }
        }
        /// <summary>
        /// 处理点击事件
        /// </summary>
        /// <param name="send"></param>
        /// <param name="e"></param>
        private void ClickPLC(object send,EventArgs e)
        {
            //判断改控件是否只读
            if (pLCBitClassBase.pLCBitselectRealize.BitPattern||pLCBitClassBase.pLCBitselectRealize.LoosenOut) return;
            PLCoopErr();
            //根据设定的模式进行写入PLC操作
            //向对象池申请 
            var Poss = ObjectPool<Tuple<Stopwatch, System.Windows.Forms.Timer>>.GetObject();
            //开始测量定时
            Poss.Item1.Start();
            //获取控件鼠标松开事件
            PlcControl.MouseUp += SafetyClick;
            //开始定时处理委托任务
            Poss.Item2.Enabled = true;
            Poss.Item2.Interval = Convert.ToInt32(pLCBitClassBase.pLCBitselectRealize.keyMinTime+ (pLCBitClassBase.pLCBitselectRealize.OperationAffirm ? pLCBitClassBase.pLCBitselectRealize.AwaitTime : 0));
            Poss.Item2.Start();
            //判断是否到达安全范围
            Poss.Item2.Tick += SafetyTick;
            //---------------安全处理方法---------------
            void SafetyClick(object send,EventArgs e)
            {
                Poss.Item1.Stop();
            }
            void SafetyTick(object send, EventArgs e)
            {
                Poss.Item2.Stop();
                Poss.Item1.Stop();
                Poss.Item2.Enabled = false;
                if (Poss.Item1.Elapsed.TotalMilliseconds >= Convert.ToInt32(pLCBitClassBase.pLCBitselectRealize.keyMinTime + (pLCBitClassBase.pLCBitselectRealize.OperationAffirm ? pLCBitClassBase.pLCBitselectRealize.AwaitTime : 0)))
                {
                    PLCSwitch(pLCBitClassBase.pLCBitselectRealize.Pattern);
                }
                //处理完成归还对象
                PlcControl.MouseUp -= SafetyClick;
                Poss.Item2.Tick -= SafetyTick;
                ObjectPool<Tuple<Stopwatch, System.Windows.Forms.Timer>>.PutObject(Poss);
            }
        }
        private void MouseUpPLC(object send,EventArgs e)
        {
            //判断改控件是否只读
            if (pLCBitClassBase.pLCBitselectRealize.BitPattern) return;
            PLCoopErr();
            //根据设定的模式进行写入PLC操作
            if (pLCBitClassBase.pLCBitselectRealize.LoosenOut)
            {
                PLCSwitch(pLCBitClassBase.pLCBitselectRealize.Pattern);
            }
            else
            {
                if(pLCBitClassBase.pLCBitselectRealize.Pattern==Button_pattern.Regression)
                    PLCSwitch(Button_pattern.Set_as_off);
            }
        }
        private void PLCSwitch(Button_pattern _Pattern)
        {
            switch (_Pattern)
            {
                case Button_pattern.Set_as_off:
                    PLCWrite(pLCBitClassBase.pLCBitselectRealize.ReadWrite ? pLCBitClassBase.pLCBitselectRealize.WritePLC : pLCBitClassBase.pLCBitselectRealize.ReadWritePLC,
               pLCBitClassBase.pLCBitselectRealize.ReadWrite ? pLCBitClassBase.pLCBitselectRealize.WriteFunction : pLCBitClassBase.pLCBitselectRealize.ReadWriteFunction,
               pLCBitClassBase.pLCBitselectRealize.ReadWrite ? pLCBitClassBase.pLCBitselectRealize.WriteAddress : pLCBitClassBase.pLCBitselectRealize.ReadWriteAddress,
               pLCBitClassBase.pLCBitselectRealize.OutReverse ? true : false);
                    return;
                case Button_pattern.Set_as_on:
                    PLCWrite(pLCBitClassBase.pLCBitselectRealize.ReadWrite ? pLCBitClassBase.pLCBitselectRealize.WritePLC : pLCBitClassBase.pLCBitselectRealize.ReadWritePLC,
               pLCBitClassBase.pLCBitselectRealize.ReadWrite ? pLCBitClassBase.pLCBitselectRealize.WriteFunction : pLCBitClassBase.pLCBitselectRealize.ReadWriteFunction,
               pLCBitClassBase.pLCBitselectRealize.ReadWrite ? pLCBitClassBase.pLCBitselectRealize.WriteAddress : pLCBitClassBase.pLCBitselectRealize.ReadWriteAddress,
               pLCBitClassBase.pLCBitselectRealize.OutReverse ? false : true);
                    return;
                case Button_pattern.selector_witch:
                    IPLCcommunicationBase PLCoop = IPLCsurface.PLCDictionary.GetValueOrDefault(pLCBitClassBase.pLCBitselectRealize.ReadWritePLC.ToString()) as IPLCcommunicationBase;
                    var State = PLCoop.PLC_read_M_bit(pLCBitClassBase.pLCBitselectRealize.ReadWriteFunction, pLCBitClassBase.pLCBitselectRealize.ReadWriteAddress);
                    PLCWrite(pLCBitClassBase.pLCBitselectRealize.ReadWrite ? pLCBitClassBase.pLCBitselectRealize.WritePLC : pLCBitClassBase.pLCBitselectRealize.ReadWritePLC,
               pLCBitClassBase.pLCBitselectRealize.ReadWrite ? pLCBitClassBase.pLCBitselectRealize.WriteFunction : pLCBitClassBase.pLCBitselectRealize.ReadWriteFunction,
               pLCBitClassBase.pLCBitselectRealize.ReadWrite ? pLCBitClassBase.pLCBitselectRealize.WriteAddress : pLCBitClassBase.pLCBitselectRealize.ReadWriteAddress,
               pLCBitClassBase.pLCBitselectRealize.OutReverse ? State ? true : false : State ? false : true);
                    return;
                case Button_pattern.Regression:
                    PLCWrite(pLCBitClassBase.pLCBitselectRealize.ReadWrite ? pLCBitClassBase.pLCBitselectRealize.WritePLC : pLCBitClassBase.pLCBitselectRealize.ReadWritePLC,
               pLCBitClassBase.pLCBitselectRealize.ReadWrite ? pLCBitClassBase.pLCBitselectRealize.WriteFunction : pLCBitClassBase.pLCBitselectRealize.ReadWriteFunction,
               pLCBitClassBase.pLCBitselectRealize.ReadWrite ? pLCBitClassBase.pLCBitselectRealize.WriteAddress : pLCBitClassBase.pLCBitselectRealize.ReadWriteAddress,
               pLCBitClassBase.pLCBitselectRealize.OutReverse ? false : true);
                    return;
            }
        }
        /// <summary>
        /// 写入PLC操作
        /// </summary>
        private void PLCWrite(PLC IPLC,string Id,string Addary,bool Value)
        {
            IPLCcommunicationBase PLCoop = IPLCsurface.PLCDictionary.GetValueOrDefault(IPLC.ToString()) as IPLCcommunicationBase;
            PLCoop.PLC_write_M_bit(Id,Addary,(Button_state)Enum.Parse(typeof(Button_state),Value?"ON":"OFF"));
        }
        /// <summary>
        /// 校验PLC对象
        /// </summary>
        private void PLCoopErr()
        {
            if (pLCBitClassBase == null) throw new Exception($" 不实现：PLCBitBase接口");
            if (pLCBitproperty == null) throw new Exception($" 不实现：PLCBitproperty接口");
            if (IPLCsurface.PLCDictionary.Count < 1 || !IPLCsurface.PLCDictionary.ContainsKey(pLCBitClassBase.pLCBitselectRealize.ReadWritePLC.ToString())) throw new Exception("PLC通讯表为空");
        }
        /// <summary>
        /// PLC刷新处理
        /// </summary>
        public  void PLCrefresh()
        {
            if (PlcControl.IsDisposed|| PlcControl.Created == false) return;
            PLCoopErr();
            IPLCcommunicationBase PLCoop = IPLCsurface.PLCDictionary.GetValueOrDefault(pLCBitClassBase.pLCBitselectRealize.ReadWritePLC.ToString()) as IPLCcommunicationBase;
            var State= PLCoop.PLC_read_M_bit(pLCBitClassBase.pLCBitselectRealize.ReadWriteFunction, pLCBitClassBase.pLCBitselectRealize.ReadWriteAddress);
            //处理状态颜色
            if (State)
            {
                pLCBitproperty.backgroundColor_0 = pLCBitClassBase.pLCBitselectRealize.backgroundColor_0;
                pLCBitproperty.TextContent_0 = pLCBitClassBase.pLCBitselectRealize.TextContent_0;
                pLCBitproperty.TextColor_0 = pLCBitClassBase.pLCBitselectRealize.TextColor_0;
            }
            else
            {
                pLCBitproperty.backgroundColor_1 = pLCBitClassBase.pLCBitselectRealize.backgroundColor_1;
                pLCBitproperty.TextContent_1 = pLCBitClassBase.pLCBitselectRealize.TextContent_1;
                pLCBitproperty.TextColor_1 = pLCBitClassBase.pLCBitselectRealize.TextColor_1;
            }
        }
    }
}
