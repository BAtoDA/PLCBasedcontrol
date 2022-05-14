using PLC通讯基础控件项目.控件类基.控件数据结构;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Linq;
using Nancy.Json;
using System.Threading.Tasks;
using PLC通讯库.通讯基础接口;
using PLC通讯库.PLC通讯设备类型表;
using PLC通讯库.通讯实现类;
using System.Collections.Concurrent;
using Sunny.UI;
using PLC通讯基础控件项目.控件类基.控件地址选择窗口.设备报警历史查看界面;
using PLC通讯基础控件项目.控件类基.控件地址选择窗口.设备报警历史导出界面;
using System.Text.RegularExpressions;
using PLC通讯基础控件项目.控件类基.报警表_TO_Json;
using PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLC报警控件保存类;
using PLC通讯基础控件项目.控件类基.PLC基础接口.PLC报警控件保存类;

namespace PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLC报警显示控件实现类
{
    /// <summary>
    /// 主要实现PLC报警表显示 刷新 以及 导出
    /// </summary>
    public sealed class PLCEvent_messageReadlize : BasepublicClass
    {
        #region 实现基本接口  
        //基础外部文本颜色 与 内容控制
        /// <summary>
        /// 控件保存的参数
        /// </summary>
        PLCEvent_messageBase pLCViewClassBase;
        /// <summary>
        /// 安全控制状态--true正确 false 异常
        /// </summary>
        bool SafetyPattern;
        /// <summary>
        /// 控件对象
        /// </summary>
        DataGridView PlcControl;
        /// <summary>
        /// SQL事务表
        /// </summary>
        volatile List<string> SQLoperation = new List<string>();
        /// <summary>
        /// PLC当前值表
        /// </summary>
        volatile List<string> PLCValue = new List<string>();
        /// <summary>
        /// PLC报警表读取写入对象
        /// </summary>
        volatile PLCEventContent PLCEventContent;
        /// <summary>
        /// PLC报警历史自动填充
        /// </summary>
        volatile PLCEventAutoContent pLCEventAutoContent;
        /// <summary>
        /// 报警刷新定时器
        /// </summary>
        System.Windows.Forms.Timer PLCErrTimer;
        /// <summary>
        /// PLC安全操作模式
        /// </summary>
        volatile Safetypattern PLCsafetypattern = Safetypattern.Nooperation;
        /// <summary>
        /// 指示着已经登录的事件--已经注册的不再显示到表格中--等待事件变不成立移除事件
        /// </summary>
        //private  List<Event_message> register_Event 
        //{ 
        //    get
        //    {
        //        lock(this)
        //        {
        //            return Qegister_Event;
        //        }
        //    }
        //    set
        //    {
        //        lock (this)
        //        {
        //            Qegister_Event = value;
        //        }
        //    }
        //}
        private List<Event_message> Qegister_Event = new List<Event_message>();
        /// <summary>
        /// 定义安全集合
        /// </summary>
        private ConcurrentBag<EventMessage> event_Messages;//定义安全集合
        /// <summary>
        /// 指示上次遍历已经登录的事件
        /// </summary>
        private ConcurrentBag<EventMessage> Event_quantity = new ConcurrentBag<EventMessage>();//指示上次遍历已经登录的事件
        /// <summary>
        /// 锁
        /// </summary>
        object obj = new object();
        /// <summary>
        /// 同步锁
        /// </summary>
        Mutex mutex = new Mutex();
        /// <summary>
        /// 异步线程取消令牌
        /// </summary>
        CancellationTokenSource tokenSource = new CancellationTokenSource();
        CancellationToken token;
        ManualResetEvent resetEvent = new ManualResetEvent(true);
        #endregion
        public  PLCEvent_messageReadlize(DataGridView PlcControl)
        {
            //---------处理控件接口问题---------
            if (!(PlcControl is PLCEvent_messageBase)) throw new Exception($"{PlcControl.GetType().Name} 不实现：PLCEvent_messageBase接口");
            pLCViewClassBase = PlcControl as PLCEvent_messageBase;
            this.PlcControl = PlcControl;
            //----------获取用户设定的报警参数--------------------
            PLCEventContent = new PLCEventContent(@pLCViewClassBase.EventAddress);
            TextRead();
            pLCEventAutoContent = new PLCEventAutoContent(pLCViewClassBase.SaveAddress);
            //----------处理控件与PLC事件处理---------------------
            if (((dynamic)PlcControl).PLC_Enable)
            {
                PLCErrTimer = new System.Windows.Forms.Timer();
                PLCErrTimer.Tick += (async (sen, e) =>
                  {
                      if (mutex.WaitOne(10))
                      {
                          PLCErrTimer.Stop();
                          //测试代码
                          //ReadPLC(EventLink.PLCEventLink[0]);
                          _ = await PLCrefresh();
                          //从SQL中取出当前报警数据
                          using (var db = new PoliceContext())
                          {
                              this.PlcControl.BeginInvoke((EventHandler)delegate { this.PlcControl.Rows.Clear(); });
                              db.UserElectricMark.ToList().ForEach(s1 =>
                              {
                                  //开始填充数据
                                  this.PlcControl.BeginInvoke((EventHandler)delegate
                                  {
                                      this.PlcControl.Rows.Add(new object[] { s1.报警发生时间.Trim(), s1.设备, s1.设备_地址 + s1.设备_具体地址, s1.报警内容 ?? "000" });
                                  });
                              });
                          }                      
                          PLCErrTimer.Start();
                          mutex.ReleaseMutex();
                      }
                  });
                PLCErrTimer.Interval = 10;
                PLCErrTimer.Start();
            }

            token = tokenSource.Token;

            PLCErrTimer.Disposed += PLCErrTimer_Disposed;
            //-------自动填充报警历史--------
            if (pLCViewClassBase.Save)
                pLCEventAutoContent.TextCreate();
            //-------添加右键报警监控窗口----
            UIContextMenuStrip uIContextMenuStrip = new UIContextMenuStrip()
            {
                Name = "contextMenuStrip1",
                Size = new System.Drawing.Size(193, 48)
            };

            ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem()
            {
                Name = "toolStripMenuItem1",
                Size = new System.Drawing.Size(192, 22),
                Text = "报警历史监控窗口"
            };

            //-------添加导出报警历史功能----
            ToolStripMenuItem toolStripMenuItem1 = new ToolStripMenuItem()
            {
                Name = "toolStripMenuItem2",
                Size = new System.Drawing.Size(192, 22),
                Text = "报警记录导出"
            };

            //-------注册事件打开报警历史监控窗口-------
            toolStripMenuItem.Click += ((Send, e1) =>
              {
                  new PLCErrhistoryForm(pLCViewClassBase).Show();
              });

            //-------注册事件导出报警历史窗口-------
            toolStripMenuItem1.Click += ((Send, e1) =>
            {
                new PLCErrderiveForm(pLCViewClassBase).ShowDialog();
            });

            uIContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                toolStripMenuItem,
                toolStripMenuItem1}
            );

            this.PlcControl.ContextMenuStrip = uIContextMenuStrip;
        }

        private void PLCErrTimer_Disposed(object sender, EventArgs e)
        {
            tokenSource.Cancel();
        }
        
        /// <summary>
        /// 异步读取用户设定内容
        /// </summary>
        private async void TextRead()
        {
            if (!PLCEventContent.IsText()) return;
            //读取PLC设置报警内容表
            var Content = await PLCEventContent.TextRead();
            //反序列化
            var ContentOop = new JavaScriptSerializer().Deserialize<List<Event_message>>(Content);
            if (ContentOop != null)
            {
                EventLink.PLCEventLink = ContentOop;
            }
        }
        /// <summary>
        /// 处理控件报警表
        /// </summary>
        private async Task<int> PLCrefresh()
        {
            var T = Task.Run( () =>
              {
                  EventLink.PLCEventLink.ForEach(S =>
                  {
                      ReadPLC(S);
                  });
                  return 1;
              });
            return await T;
        }
        /// <summary>
        /// 处理控件报警表
        /// </summary>
        private async Task<int> PLCrefresh1()
        {
            int TotalMax = EventLink.PLCEventLink.Count-1;
            int StrokeMax = 200;
            int EventCount = (EventLink.PLCEventLink.Count / StrokeMax) > 0 ? (EventLink.PLCEventLink.Count / StrokeMax) : 0;
            int AwaitIndex = 0;
            if (EventCount > 0)
            {
                for (int i = 0;(StrokeMax * i)< EventLink.PLCEventLink.Count; i++)
                {
                    int StrokeIndex = (TotalMax - (StrokeMax * i))> StrokeMax ? StrokeMax : (TotalMax - (StrokeMax * i));//笔数
                    int TotalIndex = TotalMax > StrokeMax ? (StrokeMax * i) : 0;//起始
                    var TaskRefresh = new Task[StrokeIndex];//创建一定的异步线程池
                    for (int j = 0; j < StrokeIndex; j++)
                    {
                        TaskRefresh[j] = new Task(() =>
                             {
                                 ReadPLC(EventLink.PLCEventLink[TotalIndex+j]);
                             }, token);
                        TaskRefresh[j].Start();
                    }
                    await Task.WhenAll(TaskRefresh);//4.等待处理完全
                }
            }
            else
            {
                var TaskRefresh = new Task[EventLink.PLCEventLink.Count];//创建一定的异步线程池
                for (int j = 0; j < EventLink.PLCEventLink.Count; j++)
                {
                    int Len = j;
                    AwaitIndex = j;
                    if (Len >= EventLink.PLCEventLink.Count) continue;
                    TaskRefresh[j] = new Task(() =>
                    {
                        ReadPLC(EventLink.PLCEventLink[Len]);
                    }, token);
                    TaskRefresh[j].Start();
                }
                await Task.WhenAll(TaskRefresh);//4.等待处理完全
            }
            return 1;
        }
        private void ReadPLC(Event_message event_Message)
        {

            if (PlcControl.IsDisposed || PlcControl.Created == false) return;
            IPLC_interface PLCoop = IPLCsurface.PLCDictionary.Where(p => p.Key.Trim() == event_Message.设备.Trim()).FirstOrDefault().Value as IPLCcommunicationBase;
            if (PLCoop == null) return;
            if (!PLCoop.PLC_ready) return;
            //创建临时对象
            event_Messages = new ConcurrentBag<EventMessage>();
            List<EventMessage> register_Event = new List<EventMessage>();
            //从SQL中取出当前报警数据
            using (var db = new PoliceContext())
            {
                register_Event = db.UserElectricMark.ToList();//获取表中所有数据
            }
            if (event_Message.类型 > 0)
            {
                var State = PLCoop.PLC_read_D_register(event_Message.设备_地址, event_Message.设备_具体地址, PLC通讯库.通讯枚举.numerical_format.Signed_16_Bit);
                trigger_word(State, event_Message, register_Event);
            }
            else
            {
                //判断是否带 _Bit 寄存器中判断某个Bit位
                Regex rq = new Regex("_Bit".ToLower());
                MatchCollection mc = Regex.Matches(event_Message.设备_地址.ToLower(), "_Bit".ToLower());
                dynamic State = false;
                if (mc.Count < 1)//暂时不支持D_Bit类型
                {
                    var PLCData = PLCEvent_DataList.PLCEvent_Data.Where(p => p.Key.Trim() == event_Message.设备.Trim()).FirstOrDefault().Value?.Where(pi => pi.Function == event_Message.设备_地址.Trim()).FirstOrDefault();
                    if (PLCData == null) return;
                    var PlcRead = PLCData.DataList.Where(pi => pi.Address == event_Message.设备_具体地址.Trim()).FirstOrDefault();
                    State = PlcRead != null ? PlcRead.State : false;
                }
                else
                {
                    State = PLCoop.PLC_read_M_bit(event_Message.设备_地址, event_Message.设备_具体地址);
                }
                //处理数据
                trigger_Bit(State, event_Message, register_Event);
            }
        }
        /// <summary>
        /// 位触发条件
        /// </summary>
        /// <param name="In"></param>
        /// <param name="event_Message"></param>
        private void trigger_Bit(bool In, Event_message event_Message, List<EventMessage> register_Event)//位触发条件
        {

            switch (event_Message.位触发条件)
            {
                case true:
                    if (In & register_Event.Where(pi => pi.MessageID == event_Message.ID).FirstOrDefault() == null)
                    {
                        //register_Event.Add(event_Message);//登录到事件表
                        SqlAdd(event_Message);
                    }
                    if (In != true & register_Event.Where(pi => pi.MessageID == event_Message.ID).FirstOrDefault() != null)
                    {
                        //register_Event.Remove(event_Message);//移除对象
                        //从SQL中移除指定对象
                        SqlRemove(event_Message);
                    }
                    break;
                case false:
                    if (In != true & register_Event.Where(pi => pi.MessageID == event_Message.ID).FirstOrDefault() == null)
                        SqlAdd(event_Message);//登录到事件表
                    if (In == true & register_Event.Where(pi => pi.MessageID == event_Message.ID).FirstOrDefault() != null)
                    {
                        //register_Event.Remove(event_Message);//移除对象
                        SqlRemove(event_Message);
                    }
                    break;
            }
            
        }
        /// <summary>
        /// 字触发条件
        /// </summary>
        /// <param name="data"></param>
        /// <param name="event_Message"></param>
        private void trigger_word(string data, Event_message event_Message, List<EventMessage> register_Event)//字触发条件
        {
            bool condition = false;//指示是否加入已登录
            switch (event_Message.字触发条件.Trim())
            {
                case "<"://小于设定数据
                    if (Convert.ToInt32(data) < Convert.ToInt32(event_Message.字触发条件_具体)) condition = true;//条件成立添加
                    if (Convert.ToInt32(data) >= Convert.ToInt32(event_Message.字触发条件_具体)) condition = false;//条件不成立异常
                    break;
                case ">":
                    if (Convert.ToInt32(data) > Convert.ToInt32(event_Message.字触发条件_具体)) condition = true;//条件成立添加
                    if (Convert.ToInt32(data) <= Convert.ToInt32(event_Message.字触发条件_具体)) condition = false;//条件不成立异常
                    break;
                case "==":
                    if (Convert.ToInt32(data) == Convert.ToInt32(event_Message.字触发条件_具体)) condition = true;//条件成立添加
                    if (Convert.ToInt32(data) != Convert.ToInt32(event_Message.字触发条件_具体)) condition = false;//条件不成立异常
                    break;
                case "<>":
                    if (Convert.ToInt32(data) != Convert.ToInt32(event_Message.字触发条件_具体)) condition = true;//条件成立添加
                    if (Convert.ToInt32(data) == Convert.ToInt32(event_Message.字触发条件_具体)) condition = false;//条件不成立异常
                    break;
                case ">=":
                    if (Convert.ToInt32(data) >= Convert.ToInt32(event_Message.字触发条件_具体)) condition = true;//条件成立添加
                    if (Convert.ToInt32(data) < Convert.ToInt32(event_Message.字触发条件_具体)) condition = false;//条件不成立异常
                    break;
                case "<=":
                    if (Convert.ToInt32(data) <= Convert.ToInt32(event_Message.字触发条件_具体)) condition = true;//条件成立添加
                    if (Convert.ToInt32(data) > Convert.ToInt32(event_Message.字触发条件_具体)) condition = false;//条件不成立异常
                    break;
            }
            //这里开始注册或者异常事件
            if (condition & register_Event.Where(pi => pi.MessageID == event_Message.ID).FirstOrDefault() == null)
            {
                //register_Event.Add(event_Message);//登录到事件表
                SqlAdd(event_Message);
            }
            if (condition != true & register_Event.Where(pi => pi.MessageID == event_Message.ID).FirstOrDefault() != null)
            {
                //register_Event.Remove(event_Message);//移除对象
                SqlRemove(event_Message);
            }
        }
        /// <summary>
        /// 向数据添加报警数据
        /// </summary>
        /// <param name="event_Message"></param>
        private async void SqlAdd(Event_message event_Message)
        {
            var AddTime = DateTime.Now;
            event_Message.报警发生时间 = AddTime.ToString("f");
            using (var db = new PoliceContext())
            {
                //先查询表中是否有改ID报警条目
                if (db.UserElectricMark.Where(p => p.MessageID == event_Message.ID).FirstOrDefault() == null)
                {
                    //添加当前报警表
                    db.UserElectricMark.Add(new EventMessage()
                    {
                        MessageID = event_Message.ID,
                        位触发条件 = event_Message.位触发条件,
                        字触发条件 = event_Message.字触发条件,
                        字触发条件_具体 = event_Message.字触发条件_具体,
                        报警内容 = event_Message.报警内容,
                        报警发生时间 = AddTime.ToString("f"),
                        报警处理时间 = DateTime.Now.ToString("D"),
                        类型 = event_Message.类型,
                        设备 = event_Message.设备,
                        设备_具体地址 = event_Message.设备_具体地址,
                        设备_地址 = event_Message.设备_地址
                    });
                   await db.SaveChangesAsync();
                }
            }
        }
        
        private async void SqlRemove(Event_message event_Message)
        {
            using (var db = new PoliceContext())
            {
                var message= db.UserElectricMark.Where(p => p.MessageID == event_Message.ID).FirstOrDefault();
                if (message != null)
                {
                    db.UserElectricMark.Remove(message);
                    //添加历史报警表
                    if (pLCViewClassBase.Save)
                    {
                        db.UserEventHistory.Add(new EventHistory()
                        {
                            MessageID = event_Message.ID,
                            位触发条件 = event_Message.位触发条件,
                            字触发条件 = event_Message.字触发条件,
                            字触发条件_具体 = event_Message.字触发条件_具体,
                            报警内容 = event_Message.报警内容,
                            报警发生时间 =DateTime.Parse(message.报警发生时间),
                            报警处理时间 = DateTime.Now,
                            类型 = event_Message.类型,
                            设备 = event_Message.设备,
                            设备_具体地址 = event_Message.设备_具体地址,
                            设备_地址 = event_Message.设备_地址

                        });
                    }
                }
               await db.SaveChangesAsync();
            }
        }
    }
}
