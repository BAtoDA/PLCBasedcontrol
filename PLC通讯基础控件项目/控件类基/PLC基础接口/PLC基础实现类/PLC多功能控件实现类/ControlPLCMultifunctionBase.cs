using PLC通讯基础控件项目.控件类基.控件数据结构;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Threading;
using PLC通讯基础控件项目.基础控件.底层PLC状态监控控件;
using PLC通讯基础控件项目.控件类基.控件安全对象池;
using System.Diagnostics;
using PLC通讯库.通讯基础接口;
using PLC通讯库.PLC通讯设备类型表;
using PLC通讯库.通讯实现类;
using PLC通讯库.通讯枚举;
using Sunny.UI;
using System.Drawing;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Reflection;

namespace PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLC多功能控件实现类
{
    /// <summary>
    /// 功能键实现类
    /// </summary>
    class ControlPLCMultifunctionBase: BasepublicClass
    {
        #region 实现基本接口  
        //基础外部文本颜色 与 内容控制
        /// <summary>
        /// 控件保存的参数
        /// </summary>
        PLCMultifunctionBase pLCMultifunctionBase;
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
        volatile Safetypattern PLCsafetypattern = Safetypattern.Nooperation;
        #endregion
        public ControlPLCMultifunctionBase(Control PlcControl)
        {
            //---------处理控件接口问题---------
            if (!(PlcControl is PLCMultifunctionBase)) throw new Exception($"{PlcControl.GetType().Name} 不实现：PLCMultifunctionBase接口");
            if (!(PlcControl is PLCBitproperty)) throw new Exception($"{PlcControl.GetType().Name} 不实现：PLCBitproperty接口");
            pLCMultifunctionBase = PlcControl as PLCMultifunctionBase;
            pLCBitproperty = PlcControl as PLCBitproperty;
            //读取PLC--自动获取对象的PLC类型对象
            //PLCoopErr(pLCBitClassBase, pLCBitproperty);
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
                pLCBitproperty.PLCTimer.Change(500, 300);
            }
            //---------安全操作模式----------
            PLCsafetypattern = pLCMultifunctionBase.pLCBitselectRealizeq.OperationAffirm ? Getsafetypattern(pLCMultifunctionBase.pLCBitselectRealizeq.SafetyBehaviorPattern) : Safetypattern.Nooperation;

        }
        /// <summary>
        /// 处理点击事件
        /// </summary>
        /// <param name="send"></param>
        /// <param name="e"></param>
        private  void ClickPLC(object send, EventArgs e)
        {
            lock (this)
            {
                //语音播报系统
                if (pLCMultifunctionBase.pLCBitselectRealizeq.Speech && pLCMultifunctionBase.pLCBitselectRealizeq.OperationAffirm)
                {
                    string safet = PLCsafetypattern != Safetypattern.Nooperation ? "无权限触发" : "以触发";
                    ControlDebug.Write($"开始加载：{this.PlcControl.Name}控件 归属PLC是：{this.pLCMultifunctionBase.pLCBitselectRealizeq.ReadWritePLC} 控件{safet}");
                    Voicebroadcast($"{this.PlcControl.Name}{safet}");
                }
                //判断改控件是否只读
                if (pLCMultifunctionBase.pLCBitselectRealizeq.BitPattern || pLCMultifunctionBase.pLCBitselectRealizeq.LoosenOut || PLCsafetypattern != Safetypattern.Nooperation) return;

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
                int Timeinc = Convert.ToInt32(pLCMultifunctionBase.pLCBitselectRealizeq.keyMinTime + (pLCMultifunctionBase.pLCBitselectRealizeq.OperationAffirm ? pLCMultifunctionBase.pLCBitselectRealizeq.AwaitTime : 0)) < 1 ? 1 : Convert.ToInt32(pLCMultifunctionBase.pLCBitselectRealizeq.keyMinTime + (pLCMultifunctionBase.pLCBitselectRealizeq.OperationAffirm ? pLCMultifunctionBase.pLCBitselectRealizeq.AwaitTime : 0));
                if (Timeinc > 100)
                {
                    Poss.Item2.Enabled = true;
                    Poss.Item2.Interval = Convert.ToInt32(pLCMultifunctionBase.pLCBitselectRealizeq.keyMinTime + (pLCMultifunctionBase.pLCBitselectRealizeq.OperationAffirm ? pLCMultifunctionBase.pLCBitselectRealizeq.AwaitTime : 0)) < 1 ? 1 : Convert.ToInt32(pLCMultifunctionBase.pLCBitselectRealizeq.keyMinTime + (pLCMultifunctionBase.pLCBitselectRealizeq.OperationAffirm ? pLCMultifunctionBase.pLCBitselectRealizeq.AwaitTime : 0));

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
                async void SafetyTick(object send, EventArgs e)
                {
                    //处理完成归还对象
                    PlcControl.MouseUp -= SafetyClick;
                    Poss.Item2.Tick -= SafetyTick;
                    Poss.Item2.Stop();
                    Poss.Item1.Stop();
                    Poss.Item2.Enabled = false;
                    ControlDebug.Write($"开始加载：{this.PlcControl.Name}控件 归属PLC是：{this.pLCMultifunctionBase.pLCBitselectRealizeq.ReadWritePLC} 安全控制当前值是：{Poss.Item1.Elapsed.TotalMilliseconds} 设置值是：{Convert.ToInt32(pLCMultifunctionBase.pLCBitselectRealizeq.keyMinTime + (pLCMultifunctionBase.pLCBitselectRealizeq.OperationAffirm ? pLCMultifunctionBase.pLCBitselectRealizeq.AwaitTime : 0))}");
                    Debug.WriteLine($"安全控制当前值是：{Poss.Item1.Elapsed.TotalMilliseconds} 设置值是：{Convert.ToInt32(pLCMultifunctionBase.pLCBitselectRealizeq.keyMinTime + (pLCMultifunctionBase.pLCBitselectRealizeq.OperationAffirm ? pLCMultifunctionBase.pLCBitselectRealizeq.AwaitTime : 0))}");

                    //开始处理功能键注册的事件
                    if (Poss.Item1.Elapsed.TotalMilliseconds >= Convert.ToInt32(pLCMultifunctionBase.pLCBitselectRealizeq.keyMinTime + (pLCMultifunctionBase.pLCBitselectRealizeq.OperationAffirm ? pLCMultifunctionBase.pLCBitselectRealizeq.AwaitTime : 0)))
                    {
                        foreach(var i in pLCMultifunctionBase.pLCMultifunctions)
                        {
                           await Task.Run(() =>
                            {
                                //判断用户选择
                                switch (i.ClassInterface)
                                {
                                    case "PLCmMltifunctionFunctionBase":
                                        //处理功能键任务
                                        LoadFunction(i.FormPath, i.FormName);
                                        break;
                                    case "PLCMultifunctionBitBase":
                                        //处理bit位任务
                                        PLCWriteBit(i.ReadWriteBitPLC, i.ReadWriteBitFunction, i.ReadWriteBitAddress, i.ValueBit == "ON" ? true : false);
                                        break;
                                    case "PLCMultifunctionDBase":
                                        //处理D寄存器任务
                                        PLCWriteD(i.ReadWriteDPLC, i.ReadWriteDFunction, i.ReadWriteDAddress, i.Value.ToString(), i.ShowFormat);
                                        break;
                                }
                            });
                        }

                    }
                    //处理完成归还对象
                    PlcControl.MouseUp -= SafetyClick;
                    Poss.Item2.Tick -= SafetyTick;
                    Poss.Item1.Reset();
                    ObjectPool<Tuple<Stopwatch, System.Windows.Forms.Timer>>.PutObject(Poss);
                }
            }
        }
        private void MouseUpPLC(object send, EventArgs e)
        {
         
        }
        private void PLCSwitch(Button_pattern _Pattern)
        {
            //判断改控件是否只读
            if (pLCMultifunctionBase.pLCBitselectRealizeq.BitPattern || pLCMultifunctionBase.pLCBitselectRealizeq.LoosenOut || PLCsafetypattern != Safetypattern.Nooperation) return;
        
        }
        private void LoadFunction(string FormPath,string FormName)
        {
            //获取所有运行中的窗口
            foreach (Form i in Application.OpenForms)
            {
                if (i.GetType().FullName == FormPath + "." + FormName)
                {
                    i.Activate();
                    return;
                }
            }
            //找不到窗口--窗口新的窗口
            //var Formoop = Assembly.GetExecutingAssembly().GetTypes(this.FormPath + "." + this.FormName);
            //获取所有运行中的窗口
            Regex rq = new Regex(FormPath ?? "PLC通讯基础控件项目.模板与控制界面");
            var Formoop = Assembly.GetExecutingAssembly().GetTypes().Where(p => rq.IsMatch(p.FullName)).ToList();
            if (Formoop != null)
            {
                Regex regex = new Regex(FormName);
                var Form = Formoop.Where(p => regex.IsMatch(p.FullName)).FirstOrDefault();
                if (Form != null)
                {
                    Form FormShow = Activator.CreateInstance(Form) as Form;
                    FormShow.StartPosition = FormStartPosition.CenterScreen;
                    FormShow.Show();
                }
            }
            else
            {
                var Formoop1 = Assembly.GetEntryAssembly().GetTypes().Where(p => rq.IsMatch(p.FullName)).ToList();
                if (Formoop1 != null)
                {
                    Regex regex = new Regex(FormName);
                    var Form = Formoop1.Where(p => regex.IsMatch(p.FullName)).FirstOrDefault();
                    if (Form != null)
                    {
                        Form FormShow = Activator.CreateInstance(Form) as Form;
                        FormShow.StartPosition = FormStartPosition.CenterScreen;
                        FormShow.Show();
                    }
                }
            }


            //关闭当前窗口
            //获取所有运行中的窗口
            Regex r = new Regex(FormPath ?? "PLC通讯基础控件项目.模板与控制界面");
            //递归查找顶级窗口Form
            object Oop = this.PlcControl;
            while (true)
            {
                if ((((dynamic)Oop).Parent as Form) != null)
                {
                    Oop = ((dynamic)Oop).Parent;
                    break;
                }
                else
                    Oop = ((dynamic)Oop).Parent;
            }
            if (Application.OpenForms.Count <= 2)
            {
                if (MessageBox.Show("代码检测到你窗口数量少于2 \r\n 这表示会导致关闭主窗口 \r\n 这在C#主窗口是不允许关闭的\r\n 这样会导致整个程序都进行关闭", "Err", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
            }
            foreach (Form i in Application.OpenForms)
            {
                if (i == (Form)Oop)
                {
                    i.BeginInvoke((MethodInvoker)delegate
                    {
                        i.Close();
                        return;
                    });
                }
            }

        }
        /// <summary>
        /// 写入PLC操作
        /// </summary>
        private void PLCWriteBit(PLC IPLC, string Id, string Addary, bool Value)
        {
            //判断改控件是否只读
            if (pLCMultifunctionBase.pLCBitselectRealizeq.BitPattern || pLCMultifunctionBase.pLCBitselectRealizeq.LoosenOut || PLCsafetypattern != Safetypattern.Nooperation) return;
            System.Threading.Tasks.Task.Run(() =>
            {
                IPLC_interface PLCoop = IPLCsurface.PLCDictionary.GetValueOrDefault(IPLC.ToString()) as IPLCcommunicationBase;
                if (PLCoop.PLC_ready)
                    PLCoop.PLC_write_M_bit(Id, Addary, (Button_state)Enum.Parse(typeof(Button_state), Value ? "ON" : "Off"));
            });
        }
        /// <summary>
        /// 写入PLC操作
        /// </summary>
        private void PLCWriteD(PLC IPLC, string Id, string Addary, string Value, PLC通讯库.通讯枚举.numerical_format numerical_Format)
        {
            IPLC_interface PLCoop = IPLCsurface.PLCDictionary.GetValueOrDefault(IPLC.ToString()) as IPLCcommunicationBase;
            if (PLCoop.PLC_ready)
            {
                Task.Run(() =>
                {
                    PLCoop.PLC_write_D_register(Id, Addary, Value, numerical_Format);
                });
            }
        }
        /// <summary>
        /// 互斥锁(Mutex)，用于多线程中防止两条线程同时对一个公共资源进行读写的机制
        /// </summary>
        Mutex mutex = new Mutex();//实例化互斥锁(Mutex);//定义互斥锁名称
        /// <summary>
        /// PLC刷新处理
        /// </summary>
        public void PLCrefresh()
        {
            //mutex.WaitOne(50);
            //{
            try
            {
                if (!PlcControl.IsHandleCreated || PlcControl.IsDisposed || PlcControl.Created == false) return;
                PLCsafety();
                IPLC_interface PLCoop = IPLCsurface.PLCDictionary.Where(p => p.Key.Trim() == pLCMultifunctionBase.ReadPLC.ToString().Trim()).FirstOrDefault().Value as IPLCcommunicationBase;
                if (PLCoop == null) return;
                if (!PLCoop.PLC_ready)
                {
                    //推出日志
                    //ControlDebug.Write(this.PlcControl.Name + $"{pLCBitClassBase.pLCBitselectRealize.ReadWrite}PLC未准备好");
                    //PLC未准备好 控件自动归零状态
                    PlcControl.BeginInvoke((MethodInvoker)delegate
                    {
                        PlcControl.SuspendLayout();
                        pLCBitproperty.backgroundColor_0 = pLCMultifunctionBase.pLCBitselectRealizeq.backgroundColor_0;
                        pLCBitproperty.TextContent_0 = pLCMultifunctionBase.pLCBitselectRealizeq.TextContent_0;
                        pLCBitproperty.TextColor_0 = PLCsafetypattern == Safetypattern.Gray ? Color.FromName("DarkGray") : pLCMultifunctionBase.pLCBitselectRealizeq.TextColor_0;
                        PlcControl.Refresh();
                        PlcControl.ResumeLayout(false);
                    });
                    return;
                }
                var State = PLCoop.PLC_read_M_bit(pLCMultifunctionBase.ReadFunction, pLCMultifunctionBase.ReadAddress);
                //---委托控件----处理状态颜色
                PlcControl.BeginInvoke((MethodInvoker)delegate
                {
                    //处理安全控制---是否要隐藏控件
                    this.PlcControl.Visible = PLCsafetypattern == Safetypattern.Hide ? false : true;
                    if (!PlcControl.IsHandleCreated || PlcControl.IsDisposed || PlcControl.Created == false) return;
                    PlcControl.SuspendLayout();
                    if (!State)
                    {
                        pLCBitproperty.backgroundColor_0 = pLCMultifunctionBase.pLCBitselectRealizeq.backgroundColor_0;
                        pLCBitproperty.TextContent_0 = pLCMultifunctionBase.pLCBitselectRealizeq.TextContent_0;
                        pLCBitproperty.TextColor_0 = PLCsafetypattern == Safetypattern.Gray ? Color.FromName("DarkGray") : pLCMultifunctionBase.pLCBitselectRealizeq.TextColor_0;
                    }
                    else
                    {
                        pLCBitproperty.backgroundColor_1 = pLCMultifunctionBase.pLCBitselectRealizeq.backgroundColor_1;
                        pLCBitproperty.TextContent_1 = pLCMultifunctionBase.pLCBitselectRealizeq.TextContent_1;
                        pLCBitproperty.TextColor_1 = PLCsafetypattern == Safetypattern.Gray ? Color.FromName("DarkGray") : pLCMultifunctionBase.pLCBitselectRealizeq.TextColor_1;
                    }
                    PlcControl.Refresh();
                    PlcControl.ResumeLayout(false);
                });
                //ControlDebug.Write(this.PlcControl.Name + $"刷新值为：{State}");
            }
            catch (Exception e)
            { //ControlDebug.Write(this.PlcControl.Name + e.Message);
            }
            //mutex.ReleaseMutex();
        }
        /// <summary>
        /// PLC安全控制
        /// </summary>
        private void PLCsafety()
        {
            if (pLCMultifunctionBase.pLCBitselectRealizeq.OperationAffirm)
            {
                IPLC_interface PLCoop = IPLCsurface.PLCDictionary.Where(p => p.Key.Trim() == pLCMultifunctionBase.pLCBitselectRealizeq.SafetyPLC.ToString().Trim()).FirstOrDefault().Value as IPLCcommunicationBase;
                if (PLCoop == null) return;
                if (!PLCoop.PLC_ready) return;
                var State = PLCoop.PLC_read_M_bit(pLCMultifunctionBase.pLCBitselectRealizeq.SafetyFunction, pLCMultifunctionBase.pLCBitselectRealizeq.WrSafetyAddress);
                switch (pLCMultifunctionBase.pLCBitselectRealizeq.SafetyPattern)
                {
                    case 0:
                        if (State)
                            PLCsafetypattern = Getsafetypattern(pLCMultifunctionBase.pLCBitselectRealizeq.SafetyBehaviorPattern);
                        else
                            PLCsafetypattern = Safetypattern.Nooperation;
                        break;
                    case 1:
                        if (!State)
                            PLCsafetypattern = Getsafetypattern(pLCMultifunctionBase.pLCBitselectRealizeq.SafetyBehaviorPattern);
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
