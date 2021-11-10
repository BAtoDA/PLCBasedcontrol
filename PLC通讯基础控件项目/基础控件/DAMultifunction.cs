using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using PLC通讯基础控件项目.控件类基.PLC基础接口;
using PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类;
using PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLC多功能控件实现类;
using PLC通讯基础控件项目.控件类基.控件地址选择窗口.多功能键控件参数界面;
using PLC通讯基础控件项目.控件类基.控件数据结构;
using Sunny.UI;

namespace PLC通讯基础控件项目.基础控件
{
    /// <summary>
    /// 多功能键
    /// </summary>
    [ToolboxItem(true)]
    [Browsable(true)]
    public sealed partial class DAMultifunction : UIButton, PLCMultifunctionBase, PLCBitproperty
    {
        public DAMultifunction()
        {
            Timerconfiguration.Tick += ((send, e) =>
            {
                //立马刷新状态
                this.SuspendLayout();
                this.backgroundColor_0 = this.pLCBitselectRealizeq.backgroundColor_0;
                this.TextContent_0 = this.pLCBitselectRealizeq.TextContent_0;
                this.TextColor_0 = this.pLCBitselectRealizeq.TextColor_0;
                this.Refresh();
                this.ResumeLayout(false);
                Timerconfiguration.Stop();

               // Modifications_Eeve(1, new EventArgs());
                //处理PLC通讯部分
                if (!this.PLC_Enable || this.IsDisposed || this.Created == false || DesignMode) return;//用户不开启PLC功能
                {
                    new ControlPLCMultifunctionBase(this);
                }
            });
        }
        #region 实现接口
        [Browsable(false)]
        [Description("PLC保存参数"), Category("PLC类型")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PLCMultifunctionClassBase[] pLCMultifunctions { get => pLCMultifunctionsq; set => pLCMultifunctionsq = value; }
        /// <summary>
        /// 私有保存参数 自动添加
        /// </summary>
        private PLCMultifunctionClassBase[] pLCMultifunctionsq { get; set; } = new PLCMultifunctionClassBase[]{ new PLCMultifunctionClassBase()};

        [Browsable(false)]
        [Description("PLC保存参数"), Category("PLC类型")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PLCBitselectRealize pLCBitselectRealizeq
        {
            get => pLCBitselectsq;
            set => pLCBitselectsq = value;
        }
        /// <summary>
        /// 私有保存参数 自动添加
        /// </summary>
        private PLCBitselectRealize pLCBitselectsq { get; set; } = new PLCBitselectRealize();
        [Browsable(false)]
        public PLC ReadPLC { get; set; } = PLC.Mitsubishi;
        [Browsable(false)]
        public string ReadFunction { get; set; } = "M";
        [Browsable(false)]
        public string ReadAddress { get; set; } = "0";
        [Browsable(false)]
        public int keyMinTime { get; set; } = 100;
        [Browsable(false)]
        public bool OperationAffirm { get; set; } = false;
        [Browsable(false)]
        public int AwaitTime { get; set; } = 100;
        [Browsable(false)]
        public PLC SafetyPLC { get; set; } = PLC.Mitsubishi;
        [Browsable(false)]
        public string SafetyFunction { get; set; } = "M";
        [Browsable(false)]
        public string WrSafetyAddress { get; set; } = "0";
        [Browsable(false)]
        public int SafetyPattern { get; set; }
        [Browsable(false)]
        public int SafetyBehaviorPattern { get; set; }
        [Browsable(false)]
        public int SafetyCategory { get; set; }
        [Browsable(false)]
        public bool NoAccessConceal { get; set; }
        [Browsable(false)]
        public bool NoAccessForm { get; set; }
        [Browsable(false)]
        public bool Speech { get; set; }
        [Browsable(false)]
        public int Textflicker_0 { get; set; }
        [Browsable(false)]
        public bool TextItalic_0 { get; set; }
        [Browsable(false)]
        public bool TextUnderline_0 { get; set; }

        [Browsable(false)]
        public int Textflicker_1 { get; set; }
        [Browsable(false)]
        public bool TextItalic_1 { get; set; }
        [Browsable(false)]
        public bool TextUnderline_1 { get; set; }

        [Browsable(false)]
        public string Textalign_0
        {
            get
            {
                if (pLCBitselectRealizeq.Textalign_0 != null)
                    return pLCBitselectRealizeq.Textalign_0;
                else
                    return ContentAlignment.BottomCenter.ToString();
            }
            set => this.TextAlign = (ContentAlignment)Enum.Parse(typeof(ContentAlignment), value);
        }
        [Browsable(false)]
        public Font TextFont_0 { get => pLCBitselectRealizeq.TextFont_0; set => this.Font = value; }
        [Browsable(false)]
        public string Textalign_1
        {
            get
            {
                if (pLCBitselectRealizeq.Textalign_0 != null)
                    return pLCBitselectRealizeq.Textalign_0;
                else
                    return ContentAlignment.BottomCenter.ToString();
            }
            set => this.TextAlign = (ContentAlignment)Enum.Parse(typeof(ContentAlignment), value);
        }
        [Browsable(false)]
        public Font TextFont_1 { get => pLCBitselectRealizeq.TextFont_0; set => this.Font = value; }
        [Browsable(false)]
        public Color backgroundColor_0 { get => pLCBitselectRealizeq.backgroundColor_0; set { this.fillColor = value; this.fillHoverColor = value; } }
        [Browsable(false)]
        public Color TextColor_0 { get => pLCBitselectRealizeq.TextColor_0; set => this.ForeColor = value; }
        [Browsable(false)]
        public string TextContent_0 { get => pLCBitselectRealizeq.TextContent_0; set => this.Text = value; }
        [Browsable(false)]
        public Color backgroundColor_1 { get => pLCBitselectRealizeq.backgroundColor_1; set { this.fillColor = value; this.fillHoverColor = value; } }
        [Browsable(false)]
        public Color TextColor_1 { get => pLCBitselectRealizeq.TextColor_1; set => this.ForeColor = value; }
        [Browsable(false)]
        public string TextContent_1 { get => pLCBitselectRealizeq.TextContent_1; set => this.Text = value; }
        #endregion
        #region 实现参数接口
        [Browsable(false)]
        public event EventHandler Modification;
        [Description("选择PLC类型\r\n默认三菱PLC"), Category("PLC类型")]
        [Browsable(true)]
        public PLCSet APLC
        {
            get => PLCsz;
            set
            {
                if (plc_Enable)
                {
                    this.Modification += new EventHandler(Modifications_Eeve);
                    this.Modification(this, new EventArgs());
                    this.Modification -= new EventHandler(Modifications_Eeve);
                    return;
                }
                this.Modification -= new EventHandler(Modifications_Eeve);
            }
        }
        /// <summary>
        /// 私有设置PLC参数
        /// </summary>
        private PLCSet PLCsz = 0;
        /// <summary>
        /// 是否启用PLC功能
        /// </summary>
        [Browsable(true)]
        [Description("是否启用PLC功能"), Category("PLC类型")]
        public bool PLC_Enable
        {
            get => plc_Enable;
            set => plc_Enable = value;
        }
        public System.Threading.Timer PLCTimer { get; set; }
        public System.Windows.Forms.Timer Timerconfiguration { get; set; } = new System.Windows.Forms.Timer() { Enabled = true, Interval = 100 };

        private bool plc_Enable = false;

        public  void Modifications_Eeve(object send, EventArgs e)
        {
            this.Modification -= new EventHandler(Modifications_Eeve);

            PLCMultifunctionBase pLCMultifunctionBase=new DAMultifunction();
            pLCMultifunctionBase.pLCMultifunctions = pLCMultifunctions;

            //----------------复制该对象的属性---------------
            var Copyz = pLCBitselectRealizeq.GetType().GetProperties();

            PLCBitselectRealize PlcBitselectCopy = (PLCBitselectRealize)Activator.CreateInstance(pLCBitselectRealizeq.GetType());

            for (int i = 0; i < Copyz.Length; i++)
            {
                PlcBitselectCopy.GetType().GetProperties()[i].SetValue(PlcBitselectCopy, Copyz[i].GetValue(pLCBitselectRealizeq));
            }
            pLCMultifunctionBase.pLCBitselectRealizeq = PlcBitselectCopy;




            PLCMultifunctionClassBase[] pLCMultifunctionClassBases = new PLCMultifunctionClassBase[pLCMultifunctions.Length];
            for (int i = 0; i < pLCMultifunctionClassBases.Length; i++)
            {
                pLCMultifunctionClassBases[i] = new PLCMultifunctionClassBase();
                var w1 = pLCMultifunctionClassBases[i].GetType().GetProperties();
                var w2 = pLCMultifunctions[i].GetType().GetProperties();
                for (int ix = 0; ix < w2.Length; ix++)
                    w1[ix] = w2[ix];
            }


            this.BeginInvoke((MethodInvoker)delegate
            {
                PLCMultifunctionForm pLCpropertyBit = new PLCMultifunctionForm(pLCMultifunctionBase);
                pLCpropertyBit.StartPosition = FormStartPosition.CenterParent;
                pLCpropertyBit.ShowDialog();
                if (!pLCpropertyBit.Save)
                {
                    for (int i = 0; i < pLCMultifunctionClassBases.Length; i++)
                    {
                        var w1 = pLCMultifunctionClassBases[i].GetType().GetProperties();
                        var w2 = pLCMultifunctions[i].GetType().GetProperties();
                        for (int ix = 0; ix < w2.Length; ix++)
                            w2[ix] = w1[ix];
                    }
                    pLCMultifunctions = pLCMultifunctionClassBases;
                }
                else
                {
                    var DD = (PLCMultifunctionBase)this;
                    DD = pLCpropertyBit.pLCMultifunctionBase;
                    pLCMultifunctions = pLCpropertyBit.pLCMultifunction.ToArray();
                }
                if (pLCpropertyBit.Save)
                {
                    //-------------放回对象属性----------------
                    var Copyz = PlcBitselectCopy.GetType().GetProperties();
                    for (int i = 0; i < Copyz.Length; i++)
                    {
                        pLCBitselectRealizeq.GetType().GetProperties()[i].SetValue(pLCBitselectRealizeq, Copyz[i].GetValue(PlcBitselectCopy));
                    }
                }
                ControlSwitch(false);
            });
            this.Modification -= new EventHandler(Modifications_Eeve);
        }

        public void ControlSwitch(bool switchover)
        {
            this.Invoke((MethodInvoker)delegate
            {
                if (switchover)
                {
                    //立马刷新状态
                    this.SuspendLayout();
                    this.backgroundColor_0 = this.pLCBitselectRealizeq.backgroundColor_1;
                    this.TextContent_0 = this.pLCBitselectRealizeq.TextContent_1;
                    this.TextColor_0 = this.pLCBitselectRealizeq.TextColor_1;
                    this.Refresh();
                    this.ResumeLayout(false);
                }
                else
                {
                    //立马刷新状态
                    this.SuspendLayout();
                    this.backgroundColor_0 = this.pLCBitselectRealizeq.backgroundColor_0;
                    this.TextContent_0 = this.pLCBitselectRealizeq.TextContent_0;
                    this.TextColor_0 = this.pLCBitselectRealizeq.TextColor_0;
                    this.Refresh();
                    this.ResumeLayout(false);
                }
            });
        }
        #endregion
    }

}
