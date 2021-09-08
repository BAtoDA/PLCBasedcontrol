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

namespace PLC通讯基础控件项目
{
    /// <summary>
    /// PLC通讯参数控件设置
    /// 继承Timer定时器 
    /// </summary>
    [ToolboxBitmap(typeof(PLCControlsPreferences), "ComponentTest.bmp")]
    [DesignTimeVisible(true)]
    [Designer(typeof(FrameworkComponentDesigner))]
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
        protected async override void OnTick(EventArgs e)
        {
            #region 分配对象池
            if(!PlcLoad)
            {
                //设置对象池大小
                Func<Tuple<Stopwatch, System.Windows.Forms.Timer>> func = new Func<Tuple<Stopwatch, System.Windows.Forms.Timer>>(() =>
                {
                    return new Tuple<Stopwatch, System.Windows.Forms.Timer>(new Stopwatch(), new System.Windows.Forms.Timer());
                });
                ObjectPool<Tuple<Stopwatch, System.Windows.Forms.Timer>> objectPool = new ObjectPool<Tuple<Stopwatch, System.Windows.Forms.Timer>>(
         5, func);
            }
            #endregion
            #region 添加数据到--PLC通讯表中
            //添加数据到--PLC通讯表中
            try
            {
                if (IPLCsurface.PLCDictionary.Count < 1 && !PlcLoad)
                {
                    IPLCsurface IPLCsurface = new IPLCsurface();
                    foreach (var i in this.PLCPreference)
                    {
                        //联查数据
                        var PLClink = this.plclinkClasses.Where(p => p.PLC == i.PLCDevice).FirstOrDefault();
                        if (PLClink != null)
                        {
                            var PLCoop = Assembly.LoadFrom("HslCommunication").GetType(PLClink.Link);
                            if (PLCoop != null && !IPLCsurface.PLCDictionary.ContainsKey(PLClink.PLC.ToString()))
                            {
                                Object[] constructParms = new object[] { i.IPEnd, i.Point };  //构造器参数
                                switch (i.PLCDevice)
                                {
                                    case PLC.Siemens:
                                        constructParms = new object[] { Enum.Parse(typeof(HslCommunication.Profinet.Siemens.SiemensPLCS), i.Retain) ?? HslCommunication.Profinet.Siemens.SiemensPLCS.S1500, i.IPEnd };  //构造器参数 
                                        break;
                                    case PLC.Modbus_TCP:
                                        constructParms = new object[] { };  //构造器参数
                                        break;
                                    default:
                                        constructParms = new object[] { i.IPEnd, i.Point };  //构造器参数
                                        break;
                                }
                                var obj = Activator.CreateInstance(PLCoop, constructParms);
                                IPLCsurface.PLCDictionaryAdd(PLClink.PLC.ToString(), new IPLCcommunicationBase(new System.Net.IPEndPoint(IPAddress.Parse(i.IPEnd), i.Point), obj));
                            }
                        }
                    }
                    PlcLoad = true;
                }
            }
            catch (Exception ex) { }
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
                catch (Exception ex) { }
            }
            #endregion
            base.OnTick(e);
        }

    }
    public partial class PLCControlsPreferences
    {
        [Serializable]
        private sealed class PlclinkClass
        {
            public PLC PLC { get; set; }
            public string Link { get; set; }
        }
        //PLC名称对应的命名空间---
        private List<PlclinkClass> plclinkClasses = new List<PlclinkClass>()
        {
            new PlclinkClass(){ PLC=PLC.Mitsubishi, Link="HslCommunication.Profinet.Melsec.MelsecMcNet"},
              new PlclinkClass(){ PLC=PLC.Modbus_TCP, Link="HslCommunication.ModBus.ModbusTcpNet"},
                 new PlclinkClass(){ PLC=PLC.OmronCIP, Link="HslCommunication.Profinet.Omron.OmronCipNet"},
                 new PlclinkClass(){ PLC=PLC.OmronTCP, Link="HslCommunication.Profinet.Omron.OmronFinsNet"},
                 new PlclinkClass(){ PLC=PLC.OmronUDP, Link="HslCommunication.Profinet.Omron.OmronFinsUdp"},
                      new PlclinkClass(){ PLC=PLC.Siemens, Link="HslCommunication.Profinet.Siemens.SiemensS7Net"}
        };
    }
  
}
