﻿//**********************************************************************
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
using PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.开机自动运行类;
using PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLC报警显示控件实现类;
using Sunny.UI;
using System.Text.RegularExpressions;
using static PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLC报警显示控件实现类.PLCEvent_DataList;
using Microsoft.EntityFrameworkCore;

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
            new PlclinkClass(){PLC=PLC.Fanuc5,Link="PLC通讯库.发那科机器人通讯实现.通讯实现.FANUCRobotBase",Dllplace=true,Dll="PLC通讯库"},
            new PlclinkClass(){PLC=PLC.HMI,Link="PLC通讯库.内部软元件.通讯实现.InteriorElement",Dllplace=true,Dll="PLC通讯库"}
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
            this.Interval = 2000;
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
            #region 创建数据库
            if(!PlcLoad)
            {
                try
                {
                    using (var context = new 控件类基.PLC基础接口.PLC基础实现类.PLC报警控件保存类.PoliceContext())
                    {
                        // 检查是否有新的迁移
                        if (context.Database.GetPendingMigrations().Any())
                        {
                            context.Database.Migrate(); //执行迁移
                        }
                        //清除当前报警表
                        context.UserElectricMark.RemoveRange(context.UserElectricMark.ToArray());
                        await context.SaveChangesAsync();
                    }
                }
                catch { }
            }
            #endregion
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
            if (!PlcLoad)
            {
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
                                            var constructParmse = (MitsubishiPLC)(Enum.Parse(typeof(MitsubishiPLC), i.Retain) ?? MitsubishiPLC.FX);  //构造器参数 
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
                        //添加软件开机自动启动
                        BootAutomatically.SetMeStart();
                        //--------------处理报警视图---------------------
                        //PLCEventCountLoad();//加载注册的PLC
                        //PLCEventDataListRefresh();
                        PlcLoad = true;
                    }
                }
                catch { }
            }
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
                                {
                                    基础控件.底层PLC状态监控控件.ControlDebug.Write($"正在重连:{i.IPEndPoint.Address} Port:{i.IPEndPoint.Port}");
                                    var d= i.PLC_open();
                                }
                            }
                        }
                        return 1;
                    });
                }
                catch { }
            }
            //--------------处理报警视图---------------------
            void PLCEventDataListRefresh()//定期刷新区域性数据
            {
                var PLCErrTimer = new System.Windows.Forms.Timer();
                PLCErrTimer.Tick += (async (sen, e) =>
                {
                    PLCErrTimer.Stop();
                    await Task.Run(() =>
                    {
                        var PLCEventTask = new Task[PLCEvent_DataList.PLCEvent_Data.Count];//创建一定的异步任务\
                        var TaskIndex = 0;//遍历任务指针
                        foreach (var i in PLCEvent_DataList.PLCEvent_Data)
                        {
                            PLCEventTask[TaskIndex] = Task.Run(() =>
                             {
                                 var PLCTaskIn = new Task[i.Value.Count];//创建一定的异步任务\
                                 var TaskIn = 0;//遍历任务指针
                                 IPLC_interface PLCoop = IPLCsurface.PLCDictionary.Where(p => p.Key.Trim() == i.Key.Trim()).FirstOrDefault().Value as IPLCcommunicationBase;
                                 if (PLCoop == null) return 1;
                                 var PLCHex = IPLCsurface.PLCDictionary.Where(p => p.Key.Trim() == i.Key.Trim()).FirstOrDefault().Value as IPLCcommunicationBase;
                                 string PlcAdds = string.Empty;
                                 var TypeMax = Assembly.GetExecutingAssembly().GetType("PLC通讯基础控件项目.控件类基.控件数据结构." + i.Key + "_addressMax_Bit");
                                 var ReadMax = Assembly.GetExecutingAssembly().GetType("PLC通讯基础控件项目.控件类基.控件数据结构." + i.Key + "_addressMax");
                                 if (PLCoop.PLC_ready)
                                 {
                                     //先遍历Bit位                
                                     i.Value.ForEach(s =>
                                        {
                                            PLCTaskIn[TaskIn] = Task.Run(() =>
                                            {
                                                if (s.PLC_Bit_D)//Bit位区域读取
                                                {
                                                    int TotalMax = (int)Enum.Parse(TypeMax, s.Function);
                                                    int StrokeMax = (int)Enum.Parse(ReadMax, "Max_" + s.Function);
                                                    for (int j = 0; (StrokeMax * j)< TotalMax; j++)//一共遍历
                                                    {

                                                        int StrokeIndex = (TotalMax - (StrokeMax * j)) > StrokeMax ? StrokeMax : (TotalMax - (StrokeMax * j));//笔数
                                                        int TotalIndex = TotalMax > StrokeMax ? (StrokeMax * j) : 0;//起始
                                                        if (s.Function == "X" || s.Function == "Y")
                                                            PlcAdds = PLCHex.mitsubishiPLC == MitsubishiPLC.FX ? Convert.ToString(TotalIndex, 8) : Convert.ToString(TotalIndex, 16);//16进制
                                                        else
                                                            PlcAdds = TotalIndex.ToString();
                                                        var PLCData = PLCoop.PLC_read_M_bit(s.Function, PlcAdds, (ushort)StrokeIndex);//批量获得PLC数据
                                                        if (PLCData == null) continue;

                                                        if (PLCData.Length == StrokeIndex)
                                                        {
                                                            for (int Ln = 0; Ln < PLCData.Length; Ln++)//填充数据到表中
                                                            {
                                                                s.DataList[TotalIndex + Ln].State = PLCData[Ln];
                                                            }
                                                        }
                                                    }
                                                }
                                                else
                                                {//D区域读取

                                                }
                                            });
                                            TaskIn++;
                                        });
                                     Task.WaitAll(PLCTaskIn);

                                 }
                                 return 1;
                             });

                            TaskIndex++;
                        }
                        Task.WaitAll(PLCEventTask);
                    });
                    PLCErrTimer.Start();
                });
                PLCErrTimer.Interval = 400;
                PLCErrTimer.Start();

            }

            void PLCEventCountLoad()//加载批量读取PLC区域的范围
            {
                PLCEvent_DataList.PLCEvent_Data.Clear();
                foreach (var PlcLln in IPLCsurface.PLCDictionary)
                {
                    switch (Enum.Parse(typeof(PLC), PlcLln.Key.ToString()))
                    {
                        case PLC.Siemens:
                        case PLC.Siemens1:
                        case PLC.Siemens2:
                        case PLC.Siemens3:
                        case PLC.Siemens4:
                        case PLC.Siemens5:
                            var SiemensPLC = new List<PLCEvent_DataList.PLCData>();
                            var SiemensType = Assembly.GetExecutingAssembly().GetType("PLC通讯基础控件项目.控件类基.控件数据结构." + PlcLln.Key.ToString() + "_addressMax_bit");
                            Enum.GetNames(SiemensType).ForEach(Reuq =>
                            {
                                //var SiemensMax = Assembly.GetExecutingAssembly().GetType("PLC通讯基础控件项目.控件类基.控件数据结构." + PlcLln.Key.ToString() + "_addressMax");
                                int Max = (int)Enum.Parse(SiemensType, Reuq);
                                var AddData = new PLCEvent_DataList.PLCData();
                                AddData.Function = Reuq.ToString();
                                AddData.PLC_Bit_D = true;
                                AddData.DataList = new List<DataList<dynamic>>();

                                for (int i = 0; i < Max; i++)//默认开辟区域为3W
                                {
                                    if (Reuq == "I" || Reuq == "Q")//填充输出 输入
                                    {
                                        AddData.DataList.Add(new DataList<dynamic>()
                                        {
                                            Address =(Convert.ToSingle(Convert.ToString(i,8))/10).ToString(),//8进制
                                            State = false
                                        });
                                    }
                                    else
                                    {
                                        AddData.DataList.Add(new DataList<dynamic>()//10进制
                                        {
                                            Address = i.ToString(),
                                            State = false
                                        });
                                    }
                                }
                                SiemensPLC.Add(AddData);
                            });
                            var SiemensType1 = Assembly.GetExecutingAssembly().GetType("PLC通讯基础控件项目.控件类基.控件数据结构." + PlcLln.Key.ToString() + "_addressMax_D");
                            Enum.GetNames(SiemensType1).ForEach(Reuq =>
                            {
                                //var SiemensMax = Assembly.GetExecutingAssembly().GetType("PLC通讯基础控件项目.控件类基.控件数据结构." + PlcLln.Key.ToString() + "_addressMax");
                                int Max = (int)Enum.Parse(SiemensType1,Reuq);
                                var AddData = new PLCEvent_DataList.PLCData();
                                AddData.Function = Reuq.ToString();
                                AddData.PLC_Bit_D = false;
                                AddData.DataList = new List<DataList<dynamic>>();

                                for (int i = 0; i < Max; i++)//默认开辟区域为3W
                                {
                                    AddData.DataList.Add(new DataList<dynamic>()//10进制
                                    {
                                        Address ="0",
                                        State = false
                                    });
                                }
                                SiemensPLC.Add(AddData);
                            });
                            PLCEvent_DataList.PLCEvent_Data.Add(PlcLln.Key.ToString(), SiemensPLC);
                            break;
                        case PLC.Modbus_TCP:
                        case PLC.Modbus_TCP1:
                        case PLC.Modbus_TCP2:
                        case PLC.Modbus_TCP3:
                        case PLC.Modbus_TCP4:
                        case PLC.Modbus_TCP5:
                            var Modbus_TCPPLC = new List<PLCEvent_DataList.PLCData>();
                            var Modbus_TCPType = Assembly.GetExecutingAssembly().GetType("PLC通讯基础控件项目.控件类基.控件数据结构." + PlcLln.Key.ToString() + "_addressMax_bit");
                            Enum.GetNames(Modbus_TCPType).ForEach(Reuq =>
                            {
                                //var Modbus_TCPMax = Assembly.GetExecutingAssembly().GetType("PLC通讯基础控件项目.控件类基.控件数据结构." + PlcLln.Key.ToString() + "_addressMax");
                                int Max = (int)Enum.Parse(Modbus_TCPType, Reuq);
                                var AddData = new PLCEvent_DataList.PLCData();
                                AddData.Function = Reuq.ToString();
                                AddData.PLC_Bit_D = true;
                                AddData.DataList = new List<DataList<dynamic>>();

                                for (int i = 0; i < Max; i++)//默认开辟区域为3W
                                {
                                    AddData.DataList.Add(new DataList<dynamic>()//10进制
                                    {
                                        Address = i.ToString(),
                                        State = false
                                    });

                                }
                                Modbus_TCPPLC.Add(AddData);
                            });
                            var Modbus_TCPType1 = Assembly.GetExecutingAssembly().GetType("PLC通讯基础控件项目.控件类基.控件数据结构." + PlcLln.Key.ToString() + "_addressMax_D");
                            Enum.GetNames(Modbus_TCPType1).ForEach(Reuq =>
                            {
                                //var Modbus_TCPMax = Assembly.GetExecutingAssembly().GetType("PLC通讯基础控件项目.控件类基.控件数据结构." + PlcLln.Key.ToString() + "_addressMax");
                                int Max = (int)Enum.Parse(Modbus_TCPType1,  Reuq);
                                var AddData = new PLCEvent_DataList.PLCData();
                                AddData.Function = Reuq.ToString();
                                AddData.PLC_Bit_D = false;
                                AddData.DataList = new List<DataList<dynamic>>();

                                for (int i = 0; i < Max; i++)//默认开辟区域为3W
                                {
                                    AddData.DataList.Add(new DataList<dynamic>()//10进制
                                    {
                                        Address = "0",
                                        State = false
                                    });
                                }
                                Modbus_TCPPLC.Add(AddData);
                            });
                            PLCEvent_DataList.PLCEvent_Data.Add(PlcLln.Key.ToString(), Modbus_TCPPLC);
                            break;
                        case PLC.Mitsubishi:
                        case PLC.Mitsubishi1:
                        case PLC.Mitsubishi2:
                        case PLC.Mitsubishi3:
                        case PLC.Mitsubishi4:
                        case PLC.Mitsubishi5:
                            var Mitsubishiplc = new List<PLCEvent_DataList.PLCData>();
                            var MitsubishiType = Assembly.GetExecutingAssembly().GetType("PLC通讯基础控件项目.控件类基.控件数据结构." + PlcLln.Key.ToString() + "_addressMax_Bit");
                            Enum.GetNames(MitsubishiType).ForEach(Reuq =>
                            {
                               // var MitsubishiMax = Assembly.GetExecutingAssembly().GetType("PLC通讯基础控件项目.控件类基.控件数据结构." + PlcLln.Key.ToString() + "_addressMax");
                                int Max = (int)Enum.Parse(MitsubishiType, Reuq);
                                var AddData = new PLCEvent_DataList.PLCData();
                                AddData.Function = Reuq.ToString();
                                AddData.PLC_Bit_D = true;
                                AddData.DataList = new List<DataList<dynamic>>();

                                for (int i = 0; i < Max; i++)//默认开辟区域为3W
                                {
                                    if (Reuq == "X" || Reuq == "Y")//填充输出 输入
                                    {
                                        var PLCoop = IPLCsurface.PLCDictionary.Where(p => p.Key.Trim() == PlcLln.Key.Trim()).FirstOrDefault().Value as IPLCcommunicationBase;
                                        AddData.DataList.Add(new DataList<dynamic>()
                                        {
                                            Address = PLCoop.mitsubishiPLC== MitsubishiPLC.FX? Convert.ToString(i, 8): Convert.ToString(i, 16),//16进制
                                            State = false
                                        });
                                    }
                                    else
                                    {
                                        AddData.DataList.Add(new DataList<dynamic>()//10进制
                                        {
                                            Address = i.ToString(),
                                            State = false
                                        });
                                    }
                                }
                                Mitsubishiplc.Add(AddData);
                            });
                            var MitsubishiType1 = Assembly.GetExecutingAssembly().GetType("PLC通讯基础控件项目.控件类基.控件数据结构." + PlcLln.Key.ToString() + "_addressMax_D");
                            Enum.GetNames(MitsubishiType1).ForEach(Reuq =>
                            {
                                //var MitsubishiMax = Assembly.GetExecutingAssembly().GetType("PLC通讯基础控件项目.控件类基.控件数据结构." + PlcLln.Key.ToString() + "_addressMax");
                                int Max = (int)Enum.Parse(MitsubishiType1, Reuq);
                                var AddData = new PLCEvent_DataList.PLCData();
                                AddData.Function = Reuq.ToString();
                                AddData.PLC_Bit_D = false;
                                AddData.DataList = new List<DataList<dynamic>>();

                                for (int i = 0; i < Max; i++)//默认开辟区域为3W
                                {
                                    AddData.DataList.Add(new DataList<dynamic>()//10进制
                                    {
                                        Address = "0",
                                        State = false
                                    });
                                }
                                Mitsubishiplc.Add(AddData);
                            });
                            PLCEvent_DataList.PLCEvent_Data.Add(PlcLln.Key.ToString(), Mitsubishiplc);
                            break;
                        case PLC.Fanuc:
                        case PLC.Fanuc1:
                        case PLC.Fanuc2:
                        case PLC.Fanuc3:
                        case PLC.Fanuc4:
                        case PLC.Fanuc5:

                            break;
                        case PLC.OmronCIP:
                        case PLC.OmronCIP1:
                        case PLC.OmronCIP2:
                        case PLC.OmronCIP3:
                        case PLC.OmronCIP4:
                        case PLC.OmronCIP5:
                        case PLC.OmronTCP:
                        case PLC.OmronTCP1:
                        case PLC.OmronTCP2:
                        case PLC.OmronTCP3:
                        case PLC.OmronTCP4:
                        case PLC.OmronTCP5:
                        case PLC.OmronUDP:
                        case PLC.OmronUDP1:
                        case PLC.OmronUDP2:
                        case PLC.OmronUDP3:
                        case PLC.OmronUDP4:
                        case PLC.OmronUDP5:
                        default:

                            break;
                    }
                }
            }
            this.Start();
            #endregion
            base.OnTick(e);
        }

    }
  
}
