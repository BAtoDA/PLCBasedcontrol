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
using System.Linq;
using PLC通讯基础控件项目.控件类基.控件安全对象池;
using PLC通讯基础控件项目.控件类基.控件数据结构;
using PLC通讯库.PLC通讯设备类型表;
using PLC通讯库.通讯实现类;
using PLC通讯库.通讯枚举;
using PLC通讯库.通讯基础接口;
using PLC通讯基础控件项目.基础控件.底层PLC状态监控控件;
using Sunny.UI;
using System.Threading.Tasks;
using System.Reflection;
using CSScriptLib;

namespace PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类
{
    /// <summary>
    /// 实现基本位控件类--PLC刷新--文字事件等处理
    /// </summary>
    public sealed partial class ControlPLCBitBase : BasepublicClass
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
        /// <summary>
        /// 复归型按钮标志位
        /// </summary>
       // private volatile bool State = false;
        /// <summary>
        /// PLC安全操作模式
        /// </summary>
        volatile Safetypattern PLCsafetypattern=Safetypattern.Nooperation;
        #endregion
        /// <summary>
        /// 构造函数
        /// </summary>
        public ControlPLCBitBase(Control PlcControl)
        {
            //---------处理控件接口问题---------
            if (!(PlcControl is PLCBitClassBase)) throw new Exception($"{PlcControl.GetType().Name} 不实现：PLCBitBase接口");
            if (!(PlcControl is PLCBitproperty)) throw new Exception($"{PlcControl.GetType().Name} 不实现：PLCBitproperty接口");
            pLCBitClassBase = PlcControl as PLCBitClassBase;
            pLCBitproperty = PlcControl as PLCBitproperty;
            //读取PLC--自动获取对象的PLC类型对象
            PLCoopErr(pLCBitClassBase, pLCBitproperty);
            this.PlcControl = PlcControl;
            //---------处理控件与PLC通讯事件---------
            if (((dynamic)PlcControl).PLC_Enable)
            {
                PlcControl.MouseDown += ClickPLC;
                PlcControl.MouseUp += MouseUpPLC;
                pLCBitproperty.PLCTimer = new System.Threading.Timer(new TimerCallback((s) =>
                {
                    this.PLCrefresh();
                }));
                pLCBitproperty.PLCTimer.Change(TimeSpan.FromMilliseconds(300), TimeSpan.FromMilliseconds(200));
            }
            //---------安全操作模式----------
            PLCsafetypattern = pLCBitClassBase.pLCBitselectRealize.OperationAffirm ? Getsafetypattern(pLCBitClassBase.pLCBitselectRealize.SafetyBehaviorPattern) : Safetypattern.Nooperation;
            //---------宏指令处理----------
            if (pLCBitClassBase.pLCBitselectRealize.MacroEvent != "不使用")
            {
                var ContrEvent = new EventCreateClass();
                ContrEvent.GainHandler(this.PlcControl, pLCBitClassBase.pLCBitselectRealize.MacroEvent ?? "Click");//注册控件事件
                ContrEvent.ControlEvent += ( async(send,e) =>//控件触发后处理事件
                  {
                      if (@pLCBitClassBase.pLCBitselectRealize.Macrocode == null || @pLCBitClassBase.pLCBitselectRealize.Macrocode == "") return;
                      await Task.Run(() =>
                      {
                          Assembly compilemethod = CSScript.RoslynEvaluator.CompileMethod(@pLCBitClassBase.pLCBitselectRealize.Macrocode);
                          var Macroinstructiontype = compilemethod.GetType("css_root+DynamicClass+ScriptCCStatic");
                          var MacroinstructionMethod = Macroinstructiontype.GetMethod("Main");
                          Debug.WriteLine($"正在执行：{pLCBitClassBase.pLCBitselectRealize.MacroName}");
                          MacroinstructionMethod.Invoke(null, new object[] { "1" });
                          Debug.WriteLine($"执行完成：{pLCBitClassBase.pLCBitselectRealize.MacroName}");
                      });
                  });
            }
        }
        /// <summary>
        /// 处理点击事件
        /// </summary>
        /// <param name="send"></param>
        /// <param name="e"></param>
        private void ClickPLC(object send,EventArgs e)
        {          
            lock (this)
            {
                //语音播报系统
                if (pLCBitClassBase.pLCBitselectRealize.Speech && pLCBitClassBase.pLCBitselectRealize.OperationAffirm)
                {
                    string safet = PLCsafetypattern != Safetypattern.Nooperation ? "无权限触发" : "以触发";
                    ControlDebug.Write($"开始加载：{this.PlcControl.Name}控件 归属PLC是：{this.pLCBitClassBase.pLCBitselectRealize.ReadWritePLC} 控件{safet}");
                    Voicebroadcast($"{this.PlcControl.Name}{safet}");
                }
                //判断改控件是否只读
                if (pLCBitClassBase.pLCBitselectRealize.BitPattern || pLCBitClassBase.pLCBitselectRealize.LoosenOut || PLCsafetypattern != Safetypattern.Nooperation) return;
                PLCoopErr(pLCBitClassBase, pLCBitproperty);
                //根据设定的模式进行写入PLC操作
                //判断对象池是否为空
                if (ObjectPool<Tuple<Stopwatch, System.Windows.Forms.Timer>>._objects == null) return;
                //向对象池申请 
                var Poss = ObjectPool<Tuple<Stopwatch, System.Windows.Forms.Timer>>.GetObject();
                //开始测量定时
                Poss.Item1.Start();
                //获取控件鼠标松开事件
                PlcControl.MouseUp += SafetyClick;
                //开始定时处理委托任务
                int Timeinc = Convert.ToInt32(pLCBitClassBase.pLCBitselectRealize.keyMinTime + (pLCBitClassBase.pLCBitselectRealize.OperationAffirm ? pLCBitClassBase.pLCBitselectRealize.AwaitTime : 0)) < 1 ? 1 : Convert.ToInt32(pLCBitClassBase.pLCBitselectRealize.keyMinTime + (pLCBitClassBase.pLCBitselectRealize.OperationAffirm ? pLCBitClassBase.pLCBitselectRealize.AwaitTime : 0));
                if (Timeinc > 100)
                {
                    Poss.Item2.Enabled = true;
                    Poss.Item2.Interval = Convert.ToInt32(pLCBitClassBase.pLCBitselectRealize.keyMinTime + (pLCBitClassBase.pLCBitselectRealize.OperationAffirm ? pLCBitClassBase.pLCBitselectRealize.AwaitTime : 0)) < 1 ? 1 : Convert.ToInt32(pLCBitClassBase.pLCBitselectRealize.keyMinTime + (pLCBitClassBase.pLCBitselectRealize.OperationAffirm ? pLCBitClassBase.pLCBitselectRealize.AwaitTime : 0));

                    Poss.Item2.Start();
                }
                else
                    SafetyTick(1, new EventArgs());
                //判断是否到达安全范围
                Poss.Item2.Tick += SafetyTick;
                //---------------安全处理方法---------------
                void SafetyClick(object send, EventArgs e)
                {
                    Poss.Item1.Stop();
                }
                void SafetyTick(object send, EventArgs e)
                {
                    //处理完成归还对象
                    PlcControl.MouseUp -= SafetyClick;
                    Poss.Item2.Tick -= SafetyTick;
                    Poss.Item2.Stop();
                    Poss.Item1.Stop();
                    Poss.Item2.Enabled = false;
                    ControlDebug.Write($"开始加载：{this.PlcControl.Name}控件 归属PLC是：{this.pLCBitClassBase.pLCBitselectRealize.ReadWritePLC} 安全控制当前值是：{Poss.Item1.Elapsed.TotalMilliseconds} 设置值是：{Convert.ToInt32(pLCBitClassBase.pLCBitselectRealize.keyMinTime + (pLCBitClassBase.pLCBitselectRealize.OperationAffirm ? pLCBitClassBase.pLCBitselectRealize.AwaitTime : 0))}");
                    Debug.WriteLine($"安全控制当前值是：{Poss.Item1.Elapsed.TotalMilliseconds} 设置值是：{Convert.ToInt32(pLCBitClassBase.pLCBitselectRealize.keyMinTime + (pLCBitClassBase.pLCBitselectRealize.OperationAffirm ? pLCBitClassBase.pLCBitselectRealize.AwaitTime : 0))}");
                    if (Poss.Item1.Elapsed.TotalMilliseconds >= Convert.ToInt32(pLCBitClassBase.pLCBitselectRealize.keyMinTime + (pLCBitClassBase.pLCBitselectRealize.OperationAffirm ? pLCBitClassBase.pLCBitselectRealize.AwaitTime : 0)))
                    {
                        PLCSwitch(pLCBitClassBase.pLCBitselectRealize.Pattern);
                    }
                    //处理完成归还对象
                    PlcControl.MouseUp -= SafetyClick;
                    Poss.Item2.Tick -= SafetyTick;
                    Poss.Item1.Reset();
                    ObjectPool<Tuple<Stopwatch, System.Windows.Forms.Timer>>.PutObject(Poss);
                }
            }
        }
        private void MouseUpPLC(object send,EventArgs e)
        {
            //判断改控件是否只读
            if (pLCBitClassBase.pLCBitselectRealize.BitPattern|| PLCsafetypattern != Safetypattern.Nooperation) return;
            PLCoopErr(pLCBitClassBase, pLCBitproperty);
            //根据设定的模式进行写入PLC操作
            if (pLCBitClassBase.pLCBitselectRealize.LoosenOut)
            {
                if (pLCBitClassBase.pLCBitselectRealize.Pattern == Button_pattern.Regression)
                {
                    PLCSwitch(pLCBitClassBase.pLCBitselectRealize.Pattern);
                    //向对象池申请 
                    var Poss = ObjectPool<Tuple<Stopwatch, System.Windows.Forms.Timer>>.GetObject();
                    //判断对象池是否为空
                    if (ObjectPool<Tuple<Stopwatch, System.Windows.Forms.Timer>>._objects == null) return;
                    //开始测量定时
                    Poss.Item2.Enabled = true;
                    Poss.Item2.Interval = 200;
                    Poss.Item2.Start();
                    //判断是否到达安全范围
                    Poss.Item2.Tick += SafetyTick;
                    void SafetyTick(object send, EventArgs e)
                    {
                        Poss.Item2.Tick -= SafetyTick;
                        //判断改控件是否只读
                        if (pLCBitClassBase.pLCBitselectRealize.BitPattern || pLCBitClassBase.pLCBitselectRealize.LoosenOut || PLCsafetypattern != Safetypattern.Nooperation) return;
                        PLCSwitch(Button_pattern.Set_as_off);
                        Poss.Item2.Stop();
                        //处理完成归还对象
                        Poss.Item2.Tick -= SafetyTick;
                        Poss.Item1.Reset();
                        ObjectPool<Tuple<Stopwatch, System.Windows.Forms.Timer>>.PutObject(Poss);
                    }                
                }
                else
                    PLCSwitch(pLCBitClassBase.pLCBitselectRealize.Pattern);
            }
            else
            {
                if (pLCBitClassBase.pLCBitselectRealize.Pattern == Button_pattern.Regression)
                    PLCSwitch(Button_pattern.Set_as_off);
            }
        }
        private void PLCSwitch(Button_pattern _Pattern)
        {
            //判断改控件是否只读
            if (pLCBitClassBase.pLCBitselectRealize.BitPattern || pLCBitClassBase.pLCBitselectRealize.LoosenOut || PLCsafetypattern != Safetypattern.Nooperation) return;
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
                    IPLC_interface PLCoop = IPLCsurface.PLCDictionary.GetValueOrDefault(pLCBitClassBase.pLCBitselectRealize.ReadWrite ? pLCBitClassBase.pLCBitselectRealize.WritePLC.ToString() : pLCBitClassBase.pLCBitselectRealize.ReadWritePLC.ToString()) as IPLCcommunicationBase;
                    if (!PLCoop.PLC_ready)
                    {
                        //UINotifierHelper.ShowNotifier("未连接设备：" + (pLCBitClassBase.pLCBitselectRealize.ReadWrite ? pLCBitClassBase.pLCBitselectRealize.WritePLC.ToString() : pLCBitClassBase.pLCBitselectRealize.ReadWritePLC.ToString()) + "Err", UINotifierType.WARNING, UILocalize.WarningTitle, false, 1000);//推出异常提示用户
                        return;
                    }
                    var State = PLCoop.PLC_read_M_bit(pLCBitClassBase.pLCBitselectRealize.ReadWrite ? pLCBitClassBase.pLCBitselectRealize.WriteFunction : pLCBitClassBase.pLCBitselectRealize.ReadWriteFunction,
               pLCBitClassBase.pLCBitselectRealize.ReadWrite ? pLCBitClassBase.pLCBitselectRealize.WriteAddress : pLCBitClassBase.pLCBitselectRealize.ReadWriteAddress);

                    PLCWrite(pLCBitClassBase.pLCBitselectRealize.ReadWrite ? pLCBitClassBase.pLCBitselectRealize.WritePLC : pLCBitClassBase.pLCBitselectRealize.ReadWritePLC,
               pLCBitClassBase.pLCBitselectRealize.ReadWrite ? pLCBitClassBase.pLCBitselectRealize.WriteFunction : pLCBitClassBase.pLCBitselectRealize.ReadWriteFunction,
               pLCBitClassBase.pLCBitselectRealize.ReadWrite ? pLCBitClassBase.pLCBitselectRealize.WriteAddress : pLCBitClassBase.pLCBitselectRealize.ReadWriteAddress,
               pLCBitClassBase.pLCBitselectRealize.OutReverse ? State ? true : false : State ? false : true);
                    //State =State?false:true;
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
        public void PLCWrite(PLC IPLC, string Id, string Addary, bool Value)
        {
            System.Threading.Tasks.Task.Run(() =>
            {
                IPLC_interface PLCoop = IPLCsurface.PLCDictionary.GetValueOrDefault(IPLC.ToString()) as IPLCcommunicationBase;
                if (PLCoop == null) return;
                if (PLCoop.PLC_ready)
                {

                    PLCoop.PLC_write_M_bit(Id, Addary, (Button_state)Enum.Parse(typeof(Button_state), Value ? "ON" : "Off"));
                }
                else
                {
                    PlcControl.BeginInvoke((MethodInvoker)delegate
                    {
                        UINotifierHelper.ShowNotifier("未连接设备：" + IPLC + "Err", UINotifierType.WARNING, UILocalize.WarningTitle, false, 1000);//推出异常提示用户
                    });
                    Thread.Sleep(1000);
                }
            });
        }
        /// <summary>
        /// 互斥锁(Mutex)，用于多线程中防止两条线程同时对一个公共资源进行读写的机制
        /// </summary>
        Mutex mutex = new Mutex();//实例化互斥锁(Mutex);//定义互斥锁名称
        /// <summary>
        /// PLC刷新处理
        /// </summary>
        public  void PLCrefresh()
        {
            if (mutex.WaitOne(20))
            {
                try
                {
                    lock (this)
                    {
                        if (!PlcControl.IsHandleCreated || PlcControl.IsDisposed || PlcControl.Created == false) { mutex.ReleaseMutex(); return; }
                        PLCoopErr(pLCBitClassBase, pLCBitproperty);
                        PLCsafety();
                        IPLC_interface PLCoop = IPLCsurface.PLCDictionary.Where(p => p.Key.Trim() == pLCBitClassBase.pLCBitselectRealize.ReadWritePLC.ToString().Trim()).FirstOrDefault().Value as IPLCcommunicationBase;
                        if (PLCoop == null) { mutex.ReleaseMutex(); return; }
                        if (!PLCoop.PLC_ready)
                        {
                            //推出日志
                            //ControlDebug.Write(this.PlcControl.Name + $"{pLCBitClassBase.pLCBitselectRealize.ReadWrite}PLC未准备好");
                            //PLC未准备好 控件自动归零状态
                            PlcControl.BeginInvoke((MethodInvoker)delegate
                            {
                                PlcControl.SuspendLayout();
                                pLCBitproperty.backgroundColor_0 = pLCBitClassBase.pLCBitselectRealize.backgroundColor_0;
                                pLCBitproperty.TextContent_0 = pLCBitClassBase.pLCBitselectRealize.TextContent_0;
                                pLCBitproperty.TextColor_0 = PLCsafetypattern == Safetypattern.Gray ? Color.FromName("DarkGray") : pLCBitClassBase.pLCBitselectRealize.TextColor_0;
                                PlcControl.Refresh();
                                PlcControl.ResumeLayout(false);
                            });
                            mutex.ReleaseMutex();
                            return;
                        }
                        var State = PLCoop.PLC_read_M_bit(pLCBitClassBase.pLCBitselectRealize.ReadWriteFunction, pLCBitClassBase.pLCBitselectRealize.ReadWriteAddress);
                        //把状态反馈到外部
                        pLCBitproperty.ReadCommand = State;
                        //---委托控件----处理状态颜色
                        PlcControl.BeginInvoke((MethodInvoker)delegate
                        {
                            //处理安全控制---是否要隐藏控件
                            this.PlcControl.Visible = PLCsafetypattern == Safetypattern.Hide ? false : true;
                            if (!PlcControl.IsHandleCreated || PlcControl.IsDisposed || PlcControl.Created == false) return;
                            PlcControl.SuspendLayout();
                            if (!State)
                            {
                                pLCBitproperty.backgroundColor_0 = pLCBitClassBase.pLCBitselectRealize.backgroundColor_0;
                                pLCBitproperty.TextContent_0 = pLCBitClassBase.pLCBitselectRealize.TextContent_0;
                                pLCBitproperty.TextColor_0 = PLCsafetypattern == Safetypattern.Gray ? Color.FromName("DarkGray") : pLCBitClassBase.pLCBitselectRealize.TextColor_0;
                            }
                            else
                            {
                                pLCBitproperty.backgroundColor_1 = pLCBitClassBase.pLCBitselectRealize.backgroundColor_1;
                                pLCBitproperty.TextContent_1 = pLCBitClassBase.pLCBitselectRealize.TextContent_1;
                                pLCBitproperty.TextColor_1 = PLCsafetypattern == Safetypattern.Gray ? Color.FromName("DarkGray") : pLCBitClassBase.pLCBitselectRealize.TextColor_1;
                            }
                            PlcControl.Refresh();
                            PlcControl.ResumeLayout(false);
                        });
                        //ControlDebug.Write(this.PlcControl.Name + $"刷新值为：{State}");
                        mutex.ReleaseMutex();
                    }
                }
                catch
                {
                    mutex.ReleaseMutex();
                    //ControlDebug.Write(this.PlcControl.Name + e.Message);
                }
            }
        }
        /// <summary>
        /// PLC安全控制
        /// </summary>
        private void PLCsafety()
        {
            if (pLCBitClassBase.pLCBitselectRealize.OperationAffirm)
            {
                IPLC_interface PLCoop = IPLCsurface.PLCDictionary.Where(p => p.Key.Trim() == pLCBitClassBase.pLCBitselectRealize.SafetyPLC.ToString().Trim()).FirstOrDefault().Value as IPLCcommunicationBase;
                if (PLCoop == null) return;
                if (!PLCoop.PLC_ready) return;
                var State = PLCoop.PLC_read_M_bit(pLCBitClassBase.pLCBitselectRealize.SafetyFunction, pLCBitClassBase.pLCBitselectRealize.WrSafetyAddress);
                switch (pLCBitClassBase.pLCBitselectRealize.SafetyPattern)
                {
                    case 0:
                        if (State)
                            PLCsafetypattern = Getsafetypattern(pLCBitClassBase.pLCBitselectRealize.SafetyBehaviorPattern);
                        else
                            PLCsafetypattern = Safetypattern.Nooperation;
                        break;
                    case 1:
                        if (!State)
                            PLCsafetypattern = Getsafetypattern(pLCBitClassBase.pLCBitselectRealize.SafetyBehaviorPattern);
                        else
                            PLCsafetypattern = Safetypattern.Nooperation;
                        break;
                }
            }
            else
                PLCsafetypattern = Safetypattern.Nooperation;
        }
  
    }
}
