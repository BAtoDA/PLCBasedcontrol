//**********************************************************************
//
// 文件名称(File Name)：
// 功能描述(Description)：
// 作者(Author)：DAtoTA
// 日期(Create Date)： 2021/9/5 21:28:54
//
//**********************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Drawing.Design;
using System.Windows.Forms.Design;
using System.ComponentModel.Design;
using System.Collections;
using System.Net;
using System.Drawing;
using PLC通讯基础控件项目.PLC参数设置控件;
using PLC通讯库.PLC通讯设备类型表;
using PLC通讯基础控件项目.控件类基.控件数据结构;
using System.Reflection;
using PLC通讯库.通讯实现类;
using PLC通讯库.通讯基础接口;
using System.Threading.Tasks;
using System.Diagnostics;
using PLC通讯基础控件项目.控件类基.控件安全对象池;
using System.Speech.Synthesis;
using HslCommunication.Profinet.Siemens;
using PLC通讯基础控件项目.第三方通信互交底层;
using PLC通讯库.通讯枚举;

namespace PLC通讯基础控件项目
{
    /// <summary>
    /// PLC通讯参数控件设置
    /// 继承Timer定时器 
    /// </summary>
    [ToolboxItem(true)]
    [ToolboxBitmap(typeof(PLCControlsPreferences), "ComponentTest.bmp")]
    [DesignTimeVisible(true)]
    [Designer(typeof(FrameworkComponentDesigner))]
    [Description("PLC通讯参数控件设置")]
    public partial class PLCControlsPreferences
    {
        [Serializable]
        private sealed class PlclinkClass
        {
            public PLC PLC { get; set; }
            public string Link { get; set; }
            public string Dll { get; set; }
            public bool Dllplace { get; set; }
        }
        //PLC名称对应的命名空间---
        private List<PlclinkClass> plclinkClasses = new List<PlclinkClass>()
        {
            //new PlclinkClass(){PLC=PLC.HMI,Link="PLC通讯库.内部软元件.通讯实现.HmiInteriorElementBase",Dllplace=true,Dll="PLC通讯库"},
            new PlclinkClass(){ PLC=PLC.Mitsubishi, Link="HslCommunication.Profinet.Melsec.MelsecMcNet",Dllplace=true,Dll="HslCommunication"},
            new PlclinkClass(){ PLC=PLC.Modbus_TCP, Link="HslCommunication.ModBus.ModbusTcpNet",Dllplace=true,Dll="HslCommunication"},
            new PlclinkClass(){ PLC=PLC.OmronCIP, Link="HslCommunication.Profinet.Omron.OmronCipNet",Dllplace=true,Dll="HslCommunication"},
            new PlclinkClass(){ PLC=PLC.OmronTCP, Link="HslCommunication.Profinet.Omron.OmronFinsNet",Dllplace=true,Dll="HslCommunication"},
            new PlclinkClass(){ PLC=PLC.OmronUDP, Link="HslCommunication.Profinet.Omron.OmronFinsUdp",Dllplace=true,Dll="HslCommunication"},
            new PlclinkClass(){ PLC=PLC.Siemens, Link="HslCommunication.Profinet.Siemens.SiemensS7Net",Dllplace=true,Dll="HslCommunication"},
            new PlclinkClass(){PLC=PLC.Fanuc,Link="PLC通讯库.发那科机器人通讯实现.通讯实现.FANUCRobotBase",Dllplace=true,Dll="PLC通讯库"},
            new PlclinkClass(){ PLC=PLC.Mitsubishi1, Link="HslCommunication.Profinet.Melsec.MelsecMcNet",Dllplace=true,Dll="HslCommunication"},
            new PlclinkClass(){ PLC=PLC.Mitsubishi2, Link="HslCommunication.Profinet.Melsec.MelsecMcNet",Dllplace=true,Dll="HslCommunication"},
            new PlclinkClass(){ PLC=PLC.Mitsubishi3, Link="HslCommunication.Profinet.Melsec.MelsecMcNet",Dllplace=true,Dll="HslCommunication"},
            new PlclinkClass(){ PLC=PLC.Mitsubishi4, Link="HslCommunication.Profinet.Melsec.MelsecMcNet",Dllplace=true,Dll="HslCommunication"},
            new PlclinkClass(){ PLC=PLC.Mitsubishi5, Link="HslCommunication.Profinet.Melsec.MelsecMcNet",Dllplace=true,Dll="HslCommunication"},
            new PlclinkClass(){ PLC=PLC.Modbus_TCP1, Link="HslCommunication.ModBus.ModbusTcpNet",Dllplace=true,Dll="HslCommunication"},
            new PlclinkClass(){ PLC=PLC.Modbus_TCP2, Link="HslCommunication.ModBus.ModbusTcpNet",Dllplace=true,Dll="HslCommunication"},
            new PlclinkClass(){ PLC=PLC.Modbus_TCP3, Link="HslCommunication.ModBus.ModbusTcpNet",Dllplace=true,Dll="HslCommunication"},
            new PlclinkClass(){ PLC=PLC.Modbus_TCP4, Link="HslCommunication.ModBus.ModbusTcpNet",Dllplace=true,Dll="HslCommunication"},
            new PlclinkClass(){ PLC=PLC.Modbus_TCP5, Link="HslCommunication.ModBus.ModbusTcpNet",Dllplace=true,Dll="HslCommunication"},
            new PlclinkClass(){ PLC=PLC.OmronCIP1, Link="HslCommunication.Profinet.Omron.OmronCipNet",Dllplace=true,Dll="HslCommunication"},
            new PlclinkClass(){ PLC=PLC.OmronCIP2, Link="HslCommunication.Profinet.Omron.OmronCipNet",Dllplace=true,Dll="HslCommunication"},
            new PlclinkClass(){ PLC=PLC.OmronCIP3, Link="HslCommunication.Profinet.Omron.OmronCipNet",Dllplace=true,Dll="HslCommunication"},
            new PlclinkClass(){ PLC=PLC.OmronCIP4, Link="HslCommunication.Profinet.Omron.OmronCipNet",Dllplace=true,Dll="HslCommunication"},
            new PlclinkClass(){ PLC=PLC.OmronCIP5, Link="HslCommunication.Profinet.Omron.OmronCipNet",Dllplace=true,Dll="HslCommunication"},
            new PlclinkClass(){ PLC=PLC.OmronTCP1, Link="HslCommunication.Profinet.Omron.OmronFinsNet",Dllplace=true,Dll="HslCommunication"},
            new PlclinkClass(){ PLC=PLC.OmronTCP2, Link="HslCommunication.Profinet.Omron.OmronFinsNet",Dllplace=true,Dll="HslCommunication"},
            new PlclinkClass(){ PLC=PLC.OmronTCP3, Link="HslCommunication.Profinet.Omron.OmronFinsNet",Dllplace=true,Dll="HslCommunication"},
            new PlclinkClass(){ PLC=PLC.OmronTCP4, Link="HslCommunication.Profinet.Omron.OmronFinsNet",Dllplace=true,Dll="HslCommunication"},
            new PlclinkClass(){ PLC=PLC.OmronTCP5, Link="HslCommunication.Profinet.Omron.OmronFinsNet",Dllplace=true,Dll="HslCommunication"},
            new PlclinkClass(){ PLC=PLC.OmronUDP1, Link="HslCommunication.Profinet.Omron.OmronFinsUdp",Dllplace=true,Dll="HslCommunication"},
            new PlclinkClass(){ PLC=PLC.OmronUDP2, Link="HslCommunication.Profinet.Omron.OmronFinsUdp",Dllplace=true,Dll="HslCommunication"},
            new PlclinkClass(){ PLC=PLC.OmronUDP3, Link="HslCommunication.Profinet.Omron.OmronFinsUdp",Dllplace=true,Dll="HslCommunication"},
            new PlclinkClass(){ PLC=PLC.OmronUDP4, Link="HslCommunication.Profinet.Omron.OmronFinsUdp",Dllplace=true,Dll="HslCommunication"},
            new PlclinkClass(){ PLC=PLC.OmronUDP5, Link="HslCommunication.Profinet.Omron.OmronFinsUdp",Dllplace=true,Dll="HslCommunication"},
            new PlclinkClass(){ PLC=PLC.Siemens1, Link="HslCommunication.Profinet.Siemens.SiemensS7Net",Dllplace=true,Dll="HslCommunication"},
            new PlclinkClass(){ PLC=PLC.Siemens2, Link="HslCommunication.Profinet.Siemens.SiemensS7Net",Dllplace=true,Dll="HslCommunication"},
            new PlclinkClass(){ PLC=PLC.Siemens3, Link="HslCommunication.Profinet.Siemens.SiemensS7Net",Dllplace=true,Dll="HslCommunication"},
            new PlclinkClass(){ PLC=PLC.Siemens4, Link="HslCommunication.Profinet.Siemens.SiemensS7Net",Dllplace=true,Dll="HslCommunication"},
            new PlclinkClass(){ PLC=PLC.Siemens5, Link="HslCommunication.Profinet.Siemens.SiemensS7Net",Dllplace=true,Dll="HslCommunication"},
            new PlclinkClass(){PLC=PLC.Fanuc1,Link="PLC通讯库.发那科机器人通讯实现.通讯实现.FANUCRobotBase",Dllplace=true,Dll="PLC通讯库"},
            new PlclinkClass(){PLC=PLC.Fanuc2,Link="PLC通讯库.发那科机器人通讯实现.通讯实现.FANUCRobotBase",Dllplace=true,Dll="PLC通讯库"},
            new PlclinkClass(){PLC=PLC.Fanuc3,Link="PLC通讯库.发那科机器人通讯实现.通讯实现.FANUCRobotBase",Dllplace=true,Dll="PLC通讯库"},
            new PlclinkClass(){PLC=PLC.Fanuc4,Link="PLC通讯库.发那科机器人通讯实现.通讯实现.FANUCRobotBase",Dllplace=true,Dll="PLC通讯库"},
            new PlclinkClass(){PLC=PLC.Fanuc5,Link="PLC通讯库.发那科机器人通讯实现.通讯实现.FANUCRobotBase",Dllplace=true,Dll="PLC通讯库"}
        };
    }
    public partial class PLCControlsPreferences : Timer
    {
        //窗体设计器的接口引用，当拖拉组件到窗体上，值由构造器传入．
        [Browsable(true)]
        [Description("设置PLC参数"), Category("PLC参数")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public BindingList<PLCPreferences> PLCPreferences 
        {
            get => PLCPreference;
            set
            {
                var DisVlaue = value.Distinct().Select((Contr, Sle) => new
                {
                    Sle,
                    Value = value.Count(p => p.PLCDevice == Contr.PLCDevice) > 1 ? (PLCPreferences.Count(p => Contr.PLCDevice == p.PLCDevice) > 0 ? null : value.Where(p => Contr.PLCDevice == p.PLCDevice).First()) : value.Where(p => Contr.PLCDevice == p.PLCDevice).FirstOrDefault()
                });

                PLCPreference = ((dynamic)DisVlaue).Value;
            }
        }
        private BindingList<PLCPreferences> PLCPreference = new BindingList<PLCPreferences>();

        private IContainer _Designer;
        public PLCControlsPreferences(IContainer container)
        {
            this.Enabled = true;
            this.Interval = 1000;
            _Designer = container;
            foreach(var i in container.Components)
            {
                if (i is PLCControlsPreferences) throw new Exception("该控件已经存在无需重复添加");
            }
            container.Add(this);
        }
        private bool PlcLoad = false;
        private bool SocketLoad = false;
        protected async override void OnTick(EventArgs e)
        {
            //判定改控件是否在窗口设计期
            if (DesignMode) return;
            this.Stop();
            #region 处理第三方通信互交
            if (!SocketLoad)
            {
                SocketServer socketServer = new SocketServer();
                socketServer.SocketLoad();
                SocketLoad = true;
            }
            #endregion
            #region 分配对象池
            if (!PlcLoad)
            {
                try
                {
                    //------------设置安全对象池大小--------------
                    Func<Tuple<Stopwatch, System.Windows.Forms.Timer>> func = new Func<Tuple<Stopwatch, System.Windows.Forms.Timer>>(() =>
                    {
                        return new Tuple<Stopwatch, System.Windows.Forms.Timer>(new Stopwatch(), new System.Windows.Forms.Timer());
                    });
                    ObjectPool<Tuple<Stopwatch, System.Windows.Forms.Timer>> objectPool = new ObjectPool<Tuple<Stopwatch, System.Windows.Forms.Timer>>(
             10, func);
                    //------------设置语音播报对象池大小--------------
                    Func<Tuple<SpeechSynthesizer>> Voice = new Func<Tuple<SpeechSynthesizer>>(() =>
                    {
                        return new Tuple<SpeechSynthesizer>(new SpeechSynthesizer());
                    });
                    VoiceObjectPool<Tuple<SpeechSynthesizer>> VoiceobjectPool = new VoiceObjectPool<Tuple<SpeechSynthesizer>>(
             10, Voice);
                }
                catch { }
            }
            #endregion
            #region 添加数据到--PLC通讯表中
            //添加数据到--PLC通讯表中
            try
            {
                if (IPLCsurface.PLCDictionary.Count < 2 && !PlcLoad)
                {
                    IPLCsurface IPLCsurface = new IPLCsurface();
                    foreach (var i in this.PLCPreference)
                    {
                        //联查数据
                        var PLClink = this.plclinkClasses.Where(p => p.PLC == i.PLCDevice).FirstOrDefault();
                        if (PLClink != null)
                        {
                            //-----查找指定dll并且按照路径进行反射获取Type命名空间-----
                            Type PLCoop;
                            if (PLClink.Dllplace)
                                PLCoop = Assembly.LoadFrom(PLClink.Dll).GetType(PLClink.Link);
                            else
                                PLCoop = Assembly.GetExecutingAssembly().GetType(PLClink.Link);
                            if (PLCoop != null && !IPLCsurface.PLCDictionary.ContainsKey(PLClink.PLC.ToString()))
                            {
                                Object[] constructParms = new object[] { i.IPEnd, i.Point };  //构造器参数
                                Object obj = new object();
                                switch (i.PLCDevice)
                                {
                                    case PLC.Siemens:
                                    case PLC.Siemens1:
                                    case PLC.Siemens2:
                                    case PLC.Siemens3:
                                    case PLC.Siemens4:
                                    case PLC.Siemens5:
                                        constructParms = new object[] { (SiemensPLCS)(Enum.Parse(typeof(HslCommunication.Profinet.Siemens.SiemensPLCS), i.Retain) ?? HslCommunication.Profinet.Siemens.SiemensPLCS.S1500) };  //构造器参数 
                                        SiemensS7Net obj1 = (SiemensS7Net)Activator.CreateInstance(PLCoop, constructParms);
                                        IPLCsurface.PLCDictionaryAdd(PLClink.PLC.ToString(), new IPLCcommunicationBase(new System.Net.IPEndPoint(IPAddress.Parse(i.IPEnd), i.Point), obj1, i.Sendovertime, i.Receptionovertime));
                                        break;
                                    case PLC.Modbus_TCP:
                                    case PLC.Modbus_TCP1:
                                    case PLC.Modbus_TCP2:
                                    case PLC.Modbus_TCP3:
                                    case PLC.Modbus_TCP4:
                                    case PLC.Modbus_TCP5:
                                        constructParms = new object[] { };  //构造器参数
                                        obj = Activator.CreateInstance(PLCoop, constructParms);
                                        IPLCsurface.PLCDictionaryAdd(PLClink.PLC.ToString(), new IPLCcommunicationBase(new System.Net.IPEndPoint(IPAddress.Parse(i.IPEnd), i.Point), obj, i.Sendovertime, i.Receptionovertime));
                                        break;
                                    case PLC.Mitsubishi:
                                    case PLC.Mitsubishi1:
                                    case PLC.Mitsubishi2:
                                    case PLC.Mitsubishi3:
                                    case PLC.Mitsubishi4:
                                    case PLC.Mitsubishi5:
                                        //三菱协议
                                        var constructParmse = (MitsubishiPLC)(Enum.Parse(typeof(MitsubishiPLC), i.Retain) ?? MitsubishiPLC.FX) ;  //构造器参数 
                                        constructParms = new object[] { i.IPEnd, i.Point };  //构造器参数
                                        obj = Activator.CreateInstance(PLCoop, constructParms);
                                        IPLCsurface.PLCDictionaryAdd(PLClink.PLC.ToString(), new IPLCcommunicationBase(new System.Net.IPEndPoint(IPAddress.Parse(i.IPEnd), i.Point), obj, i.Sendovertime, i.Receptionovertime, constructParmse));
                                        break;
                                    default:
                                        //欧姆龙协议
                                        constructParms = new object[] { i.IPEnd, i.Point };  //构造器参数
                                        obj = Activator.CreateInstance(PLCoop, constructParms);
                                        IPLCsurface.PLCDictionaryAdd(PLClink.PLC.ToString(), new IPLCcommunicationBase(new System.Net.IPEndPoint(IPAddress.Parse(i.IPEnd), i.Point), obj, i.Sendovertime, i.Receptionovertime));
                                        break;
                                }
                            }
                        }
                    }
                    PlcLoad = true;
                }
            }
            catch { }
            #endregion
            #region 处理链接PLC部分
            //--------------处理链接PLC部分---------------------
            await PLCopen();
            async Task PLCopen()
            {
                try
                {
                    await Task.Run(() =>
                   {
                       lock (this)
                       {
                           foreach (IPLC_interface i in IPLCsurface.PLCDictionary.Values)
                           {
                               if (!i.PLC_ready)
                                   i.PLC_open();
                           }
                       }
                       return 1;
                   });
                }
                catch { }
            }
            this.Start();
            #endregion
            base.OnTick(e);
        }

    }
  
}
