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
using System.Linq;
using System.Reflection;
using System.ComponentModel;
using PLC通讯基础控件项目.控件类基.控件安全对象池;
using PLC通讯基础控件项目.控件类基.控件数据结构;
using PLC通讯基础控件项目.控件类基.控件文本键盘;
using PLC通讯库.通讯基础接口;
using PLC通讯库.PLC通讯设备类型表;
using PLC通讯库.通讯实现类;
using System.Text.RegularExpressions;
using PLC通讯库.通讯枚举;

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
        /// <summary>
        /// 用于判断用户是否停止输入文本
        /// </summary>
        private System.Windows.Forms.Timer KeyTime = new System.Windows.Forms.Timer() { Interval = 800};
        private bool Focused
        {
            get
            {
                PlcControl.BeginInvoke((MethodInvoker)delegate
                {
                    focused= PlcControl.Focused;
                });
                return focused;
            }
        }
        private volatile bool focused;
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
            //----------处理控件焦点问题--------------------------
            KeyTime.Enabled = true;
            KeyTime.Stop();
            KeyTime.Tick += ((send, e) =>
              {
                  KeyTime.Stop();
                  //遍历该控件的顶级窗口--查找可以获得焦点的控件
                  if(PlcControl.Parent!=null)
                  {
                      ContIndex:
                      foreach (Control i in PlcControl.Controls)
                      {
                          if(i is Button || i is TextBox || i is CheckBox || i is DataGridView)
                          {
                              i.Focus();
                              return;
                          }
                      }
                      //如果找不到对应控件默认添加控件
                      PlcControl.Controls.Add(new Button() { Visible = false });
                      goto ContIndex;
                  }
              });
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
            ((dynamic)this.PlcControl).ReadOnly = pLCDClassBase.pLCDselectRealize.Keyboard;
            //---------安全操作模式----------
            PLCsafetypattern = pLCDClassBase.pLCDselectRealize.OperationAffirm ? Getsafetypattern(pLCDClassBase.pLCDselectRealize.SafetyBehaviorPattern) : Safetypattern.Nooperation;
            //---------是否锁死物理键盘-----
            this.PlcControl.KeyPress += ((send, e) =>
              {
                  //语音播报系统
                  if (pLCDClassBase.pLCDselectRealize.Speech && pLCDClassBase.pLCDselectRealize.OperationAffirm)
                  {
                      Voicebroadcast($"{this.PlcControl.Name}已触发");
                  }
                  //判断该控件是否启用键盘
                  if (pLCDClassBase.pLCDselectRealize.Dataentryfunction == false || PLCsafetypattern != Safetypattern.Nooperation) return;
                  //判断
                  if (pLCDClassBase.pLCDselectRealize.Keyboard)
                  {
                      e.Handled = true;
                  }
                  else
                  {
                      //判断用户是否输入中--停止焦点定时器
                      KeyTime.Stop();
                      ((Control)send).Text = ((Control)send).Text.Length < 1 ? "0" : ((Control)send).Text == "" ? "0" : ((Control)send).Text;
                      //不允许输入特殊字符
                      if (e.KeyChar != '\b')//这是允许输入退格键  
                      {
                          if ((e.KeyChar < '0') || (e.KeyChar > 'F')& (e.KeyChar != '.'))
                          {
                              e.Handled = true;
                          }
                      }
                      return;
                    
                  }
              });
            this.PlcControl.KeyUp += ((send, e) =>
            {
                //判断该控件是否启用键盘
                if (pLCDClassBase.pLCDselectRealize.Dataentryfunction == false || PLCsafetypattern != Safetypattern.Nooperation) return;
                if (!pLCDClassBase.pLCDselectRealize.Keyboard)
                {
                    ((Control)send).Text = ((Control)send).Text.Length < 1 ? "0" : ((Control)send).Text == "" ? "0" : ((Control)send).Text;
                    //----------处理控件PLC--自动获取PLC类型对象----------
                    PLCoopErr(pLCDClassBase, pLCDproperty);
                    //写入当前控件值
                    PLCWrite(this.pLCDClassBase.pLCDselectRealize.ReadWrite ? this.pLCDClassBase.pLCDselectRealize.WritePLC : this.pLCDClassBase.pLCDselectRealize.ReadWritePLC, this.pLCDClassBase.pLCDselectRealize.ReadWrite ? this.pLCDClassBase.pLCDselectRealize.WriteFunction : this.pLCDClassBase.pLCDselectRealize.ReadWriteFunction, this.pLCDClassBase.pLCDselectRealize.ReadWrite ? this.pLCDClassBase.pLCDselectRealize.WriteAddress : this.pLCDClassBase.pLCDselectRealize.ReadWriteAddress, this.PlcControl.Text, this.pLCDClassBase.pLCDselectRealize.ShowFormat);
                    //判断用户是否输入完成启动定时器--焦点定时器
                    KeyTime.Start();
                }
            });
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
                string safet = PLCsafetypattern != Safetypattern.Nooperation ? "无权限触发" : "以触发";
                Voicebroadcast($"{this.PlcControl.Name}{safet}");
            }
            //判断该控件是否启用键盘
            if (pLCDClassBase.pLCDselectRealize.Keyboard==false || pLCDClassBase.pLCDselectRealize.Dataentryfunction==false || PLCsafetypattern != Safetypattern.Nooperation) return;
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
                    catch(Exception e1)
                    {
                        //异常处理键盘
                        keyboard keyboard = new keyboard(this.PlcControl.Text, this.pLCDClassBase.pLCDselectRealize);
                        keyboard.ShowDialog();
                    }
                    finally
                    {
                        Debug.WriteLine($"安全控制当前值是：{Poss.Item1.Elapsed.TotalMilliseconds} 设置值是：{Convert.ToInt32(pLCDClassBase.pLCDselectRealize.keyMinTime + (pLCDClassBase.pLCDselectRealize.OperationAffirm ? pLCDClassBase.pLCDselectRealize.AwaitTime : 0))}");
                        //写入当前控件值
                        PLCWrite(this.pLCDClassBase.pLCDselectRealize.ReadWrite ? this.pLCDClassBase.pLCDselectRealize.WritePLC : this.pLCDClassBase.pLCDselectRealize.ReadWritePLC, this.pLCDClassBase.pLCDselectRealize.ReadWrite ? this.pLCDClassBase.pLCDselectRealize.WriteFunction : this.pLCDClassBase.pLCDselectRealize.ReadWriteFunction, this.pLCDClassBase.pLCDselectRealize.ReadWrite ? this.pLCDClassBase.pLCDselectRealize.WriteAddress : this.pLCDClassBase.pLCDselectRealize.ReadWriteAddress, this.PlcControl.Text, this.pLCDClassBase.pLCDselectRealize.ShowFormat);
                    }
                }
                //处理完成归还对象
                PlcControl.MouseUp -= SafetyClick;
                Poss.Item2.Tick -= SafetyTick;
                Poss.Item1.Reset();
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
            {
                PLCoop.PLC_write_D_register(Id, Addary, Value, numerical_Format);
                PLCinform();
            }
        }
        /// <summary>
        /// 处理控件值--读取PLC
        /// </summary>
        private void PLCrefresh()
        {
            lock(this)
            {
                if (PlcControl.IsDisposed || PlcControl.Created == false|| Focused) return;
                PLCoopErr(pLCDClassBase, pLCDproperty);
                PLCsafety();
                IPLC_interface PLCoop = IPLCsurface.PLCDictionary.Where(p => p.Key.Trim() == pLCDClassBase.pLCDselectRealize.ReadWritePLC.ToString().Trim()).FirstOrDefault().Value as IPLCcommunicationBase;
                if (PLCoop == null) return;
                if (!PLCoop.PLC_ready) return;
                var State = PLCoop.PLC_read_D_register(pLCDClassBase.pLCDselectRealize.ReadWriteFunction, pLCDClassBase.pLCDselectRealize.ReadWriteAddress,pLCDClassBase.pLCDselectRealize.ShowFormat);
                //---委托控件----处理状态颜色
                PlcControl.BeginInvoke((MethodInvoker)delegate
                {
                    //处理安全控制---是否要隐藏控件
                    this.PlcControl.Visible = PLCsafetypattern == Safetypattern.Hide ? false : true;
                    this.PlcControl.Text = complement(State ?? "0");
                });
            }
        }
        /// <summary>
        /// PLC安全控制
        /// </summary>
        private void PLCsafety()
        {
            if (pLCDClassBase.pLCDselectRealize.OperationAffirm)
            {
                IPLC_interface PLCoop = IPLCsurface.PLCDictionary.Where(p => p.Key.Trim() == pLCDClassBase.pLCDselectRealize.SafetyPLC.ToString().Trim()).FirstOrDefault().Value as IPLCcommunicationBase;
                if (PLCoop == null) return;
                if (!PLCoop.PLC_ready) return;
                var State = PLCoop.PLC_read_M_bit(pLCDClassBase.pLCDselectRealize.SafetyFunction, pLCDClassBase.pLCDselectRealize.WrSafetyAddress);
                switch (pLCDClassBase.pLCDselectRealize.SafetyPattern)
                {
                    case 0:
                        if (State)
                            PLCsafetypattern = Getsafetypattern(pLCDClassBase.pLCDselectRealize.SafetyBehaviorPattern);
                        else
                            PLCsafetypattern = Safetypattern.Nooperation;
                        break;
                    case 1:
                        if (!State)
                            PLCsafetypattern = Getsafetypattern(pLCDClassBase.pLCDselectRealize.SafetyBehaviorPattern);
                        else
                            PLCsafetypattern = Safetypattern.Nooperation;
                        break;
                }
            }
            else
                PLCsafetypattern = Safetypattern.Nooperation;
        }
        /// <summary>
        /// 实现PLC写入完成通知功能
        /// </summary>
        private void PLCinform()
        {
            if(pLCDClassBase.pLCDselectRealize.Inform)
            {
                IPLC_interface PLCoop = IPLCsurface.PLCDictionary.Where(p => p.Key.Trim() == pLCDClassBase.pLCDselectRealize.InformPLC.ToString().Trim()).FirstOrDefault().Value as IPLCcommunicationBase;
                if (PLCoop == null) return;
                if (!PLCoop.PLC_ready) return;
                var State = PLCoop.PLC_write_M_bit(pLCDClassBase.pLCDselectRealize.InformFunction, pLCDClassBase.pLCDselectRealize.InformAddress, pLCDClassBase.pLCDselectRealize.Informpattern>0? Button_state .ON: Button_state.Off);
            }
        }
        private string complement(string Name)//实现浮点小数自动补码
        {
            string d = string.Empty;
            int minusInde = Name.IndexOf('-');//搜索数据是否有小数点
            int Inde = Name.IndexOf('.');//搜索数据是否有小数点
            //如果有小数点 先移除
            if (Inde > -1)
                Name=Name.Remove(Inde, 1);
            //如果是否负数 先移除符号位
            if (minusInde > -1)
                Name = Name.Remove(minusInde, 1);
            if (pLCDClassBase.pLCDselectRealize.NumericaldigitMin > (Inde>-1?Name.Length: Name.Length-1))
            {
                int forindex = (pLCDClassBase.pLCDselectRealize.NumericaldigitMin - Name.Length) + 1;
                for (int i=0;i< forindex; i++)
                  Name = Name.Insert(0, "0");//填充数据
            }
            if (Inde == -1)
            {
                if (pLCDClassBase.pLCDselectRealize.NumericaldigitMin < Name.Length)
                {
                    Name = Name.Insert(Name.Length-pLCDClassBase.pLCDselectRealize.NumericaldigitMin, ".");//填充数据
                }
            }
            //补码
            if (minusInde > -1)
                Name=Name = Name.Insert(0, "-");//填充数据
            return Name;//返回数据
        }
    }
}
