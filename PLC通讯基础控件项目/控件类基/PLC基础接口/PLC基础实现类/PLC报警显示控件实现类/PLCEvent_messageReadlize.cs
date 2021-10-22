using PLC通讯基础控件项目.控件类基.控件数据结构;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Linq;
using PLC通讯基础控件项目.控件类基.PLC基础接口.报警表_TO_Json;
using Nancy.Json;
using System.Threading.Tasks;
using PLC通讯库.通讯基础接口;
using PLC通讯库.PLC通讯设备类型表;
using PLC通讯库.通讯实现类;
using System.Collections.Concurrent;
using Sunny.UI;
using PLC通讯基础控件项目.控件类基.控件地址选择窗口.设备报警历史查看界面;

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
        private List<Event_message> register_Event { get; set; } = new List<Event_message>();
        /// <summary>
        /// 定义安全集合
        /// </summary>
        private ConcurrentBag<Event_message> event_Messages;//定义安全集合
        /// <summary>
        /// 指示上次遍历已经登录的事件
        /// </summary>
        private ConcurrentBag<Event_message> Event_quantity = new ConcurrentBag<Event_message>();//指示上次遍历已经登录的事件
        /// <summary>
        /// 锁
        /// </summary>
        object obj = new object();
        #endregion
        public PLCEvent_messageReadlize(DataGridView PlcControl)
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
                PLCErrTimer.Tick+=((sen,e)=>
                {
                    lock (obj)
                    {
                        PLCErrTimer.Stop();
                        _ = PLCrefresh();
                        PLCErrTimer.Start();
                    }
                });
                PLCErrTimer.Interval = 1000;
                PLCErrTimer.Start();
            }
            //-------自动填充报警历史--------
            if (pLCViewClassBase.Save)
                pLCEventAutoContent.TextCreate();
            //-------添加右键报警监控窗口----
            UIContextMenuStrip uIContextMenuStrip = new UIContextMenuStrip();
            uIContextMenuStrip.Name = "contextMenuStrip1";
            uIContextMenuStrip.Size = new System.Drawing.Size(193, 48);

            ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem.Name = "toolStripMenuItem1";
            toolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            toolStripMenuItem.Text = "报警历史监控窗口";

            //-------添加导出报警历史功能----


            //-------注册事件打开报警历史监控窗口-------
            toolStripMenuItem.Click += ((Send, e1) =>
              {
                  new PLCErrhistoryForm(pLCViewClassBase).Show();
              });

            uIContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            toolStripMenuItem});

            this.PlcControl.ContextMenuStrip = uIContextMenuStrip;
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
        private async Task PLCrefresh()
        {
            await Task.Run(() =>
            {
                EventLink.PLCEventLink.ForEach(async s1 =>
                    {
                        await ReadPLC(s1);
                    });
                return 1;
            });
        }
        private async Task ReadPLC(Event_message event_Message)
        {
            //try
            //{
                if (PlcControl.IsDisposed || PlcControl.Created == false) return;
                IPLC_interface PLCoop = IPLCsurface.PLCDictionary.Where(p => p.Key.Trim() == event_Message.设备.Trim()).FirstOrDefault().Value as IPLCcommunicationBase;
                if (PLCoop == null) return;
                if (!PLCoop.PLC_ready) return;
                if (event_Message.类型 > 0)
                {
                    var State = PLCoop.PLC_read_D_register(event_Message.设备_地址, event_Message.设备_具体地址, PLC通讯库.通讯枚举.numerical_format.Signed_16_Bit);
                    trigger_word(State, event_Message);
                }
                else
                {
                    var State = PLCoop.PLC_read_M_bit(event_Message.设备_地址, event_Message.设备_具体地址);
                    trigger_Bit(State, event_Message);
                }
                //找出不同的元素 
                event_Messages = new ConcurrentBag<Event_message>();
                //找出不同的元素(即交集的补集)
                var diffArr = register_Event.Where(c => !Event_quantity.Contains(c)).ToList();
                var diffArr1 = Event_quantity.Where(c => !register_Event.Contains(c)).ToList();
                //开始把事件显示到表中
                if ((diffArr.Count == 0 && diffArr1.Count == 0) || (register_Event.Count == 0 && Event_quantity.Count == 0)) return;

                foreach (var i in register_Event) event_Messages.Add(i);
                Event_quantity = new ConcurrentBag<Event_message>();
                this.PlcControl.BeginInvoke((EventHandler)delegate { this.PlcControl.Rows.Clear(); });
                register_Event.ForEach(s1 =>
                {
                    s1.报警发生时间= DateTime.Now;
                    Event_quantity.Add(s1);                
                    //遍历完成开始填充数据
                    this.PlcControl.BeginInvoke((EventHandler)delegate
                    {
                        this.PlcControl.Rows.Add(new object[] { DateTime.Now.ToString("T"), s1.设备, s1.设备_地址 + s1.设备_具体地址, s1.报警内容 ?? "000" });
                    });
                });//记录保持

                if (!pLCViewClassBase.Save) return;
                if (pLCEventAutoContent.IsText())
                {
                foreach (var i in diffArr1)
                {
                    i.报警处理时间 = DateTime.Now;
                    await pLCEventAutoContent.TextWrite(new JavaScriptSerializer().Serialize(i));
                }
                }
            //}
            //catch { }
        }
        /// <summary>
        /// 位触发条件
        /// </summary>
        /// <param name="In"></param>
        /// <param name="event_Message"></param>
        private void trigger_Bit(bool In,Event_message event_Message)//位触发条件
        {
            switch (event_Message.位触发条件)
            {
                case true:
                    if (In & register_Event.Where(pi => pi.ID == event_Message.ID).FirstOrDefault()==null)
                        register_Event.Add(event_Message);//登录到事件表
                    if (In != true & register_Event.Where(pi => pi.ID == event_Message.ID).FirstOrDefault() != null)
                    {
                        register_Event.Remove(event_Message);//移除对象
                    }
                    break;
                case false:
                    if (In != true & register_Event.Where(pi => pi.ID == event_Message.ID).FirstOrDefault()==null)
                        register_Event.Add(event_Message);//登录到事件表
                    if (In == true & register_Event.Where(pi => pi.ID == event_Message.ID).FirstOrDefault() != null)
                    {
                        register_Event.Remove(event_Message);//移除对象
                    }
                    break;
            }
        }
        /// <summary>
        /// 字触发条件
        /// </summary>
        /// <param name="data"></param>
        /// <param name="event_Message"></param>
        private void trigger_word(string data, Event_message event_Message)//字触发条件
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
            if (condition & register_Event.Where(pi => pi.ID == event_Message.ID).FirstOrDefault()==null)
                register_Event.Add(event_Message);//登录到事件表
            if (condition != true & register_Event.Where(pi => pi.ID == event_Message.ID).FirstOrDefault() != null)
            {
                register_Event.Remove(event_Message);//移除对象
            }
        }
    }
}
