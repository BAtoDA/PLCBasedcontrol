using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLC柱形图控件实现类;
using PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLC表格控件实现类;
using PLC通讯基础控件项目.控件类基.PLC基础接口.表格控件_TO_PLC;
using PLC通讯基础控件项目.控件类基.控件地址选择窗口.表格控件参数界面;
using PLC通讯基础控件项目.控件类基.控件数据结构;
using Sunny.UI;

namespace PLC通讯基础控件项目.基础控件
{
    /// <summary>
    /// 柱形图控件
    /// </summary>
    public partial class DAuiBarChart : PLCDataViewClassBase
    {
       public DAuiBarChart()
        {
            Timerconfiguration.Tick += ((send, e) =>
            {
                Timerconfiguration.Stop();
                //处理PLC通讯部分
                if (!this.PLC_Enable || this.IsDisposed || this.Created == false|| DesignMode) return;//用户不开启PLC功能
                else
                {
                    uiRefresh();
                    ControlPLCBarChartBase controlPLCDataViewBase = new ControlPLCBarChartBase(this);
                }
            });
        }
    }
    [ToolboxItem(true)]
    public partial class DAuiBarChart:UIBarChart, PLCDataViewClassBase, PLCBarCharttClassBase
    {
        #region 新增属性
        /// <summary>
        /// 标题
        /// </summary>
        [Browsable(true)]
        [ToolboxItem(true)]
        [Description("柱形图属性"), Category("标题")]
        [DefaultValue(typeof(string), "标题")]
        public string TitleText 
        {
            get => titleText;
            set
            {
                titleText = value;
                uiRefresh();
            }

        }
        private string titleText = "标题";
        /// <summary>
        /// 柱形图标题
        /// </summary>
        [Browsable(true)]
        [ToolboxItem(true)]
        [Description("柱形图属性"), Category("标题")]
        [DefaultValue(typeof(string), "标题")]
        public string TitleSubText
        {
            get => titleSubText;
            set
            {
                titleSubText = value;
                uiRefresh();
            }

        }
        private string titleSubText = "标题";
        /// <summary>
        /// 柱形图X坐标标题
        /// </summary>
        [Browsable(true)]
        [ToolboxItem(true)]
        [Description("柱形图属性"), Category("X坐标标题")]
        [DefaultValue(typeof(string), "X坐标标题")]
        public string XAxisName
        {
            get => xAxisName;
            set
            {
                xAxisName = value;
                uiRefresh();
            }

        }
        private string xAxisName = "标题";
        /// <summary>
        /// 柱形图X坐标最大值
        /// </summary>
        [Browsable(true)]
        [ToolboxItem(true)]
        [Description("柱形图属性"), Category("X坐标最大值")]
        [DefaultValue(typeof(long), "9999999")]
        public long XAxisMax
        {
            get => xAxisMax;
            set
            {
                xAxisMax = value;
                uiRefresh();
            }

        }
        private long xAxisMax =9999999;
        /// <summary>
        /// 柱形图X坐标最小值
        /// </summary>
        [Browsable(true)]
        [ToolboxItem(true)]
        [Description("柱形图属性"), Category("X坐标最小值")]
        [DefaultValue(typeof(long), "0")]
        public long XAxisMin
        {
            get => xAxisMin;
            set
            {
                xAxisMin = value;
                uiRefresh();
            }

        }
        private long xAxisMin = 0;
        /// <summary>
        /// 柱形图Y坐标标题
        /// </summary>
        [Browsable(true)]
        [ToolboxItem(true)]
        [Description("柱形图属性"), Category("Y坐标标题")]
        [DefaultValue(typeof(string), "Y坐标标题")]
        public string YAxisName
        {
            get => yAxisName;
            set
            {
                yAxisName = value;
                uiRefresh();
            }

        }
        private string yAxisName = "标题";
        /// <summary>
        /// 柱形图Y坐标最大值
        /// </summary>
        [Browsable(true)]
        [ToolboxItem(true)]
        [Description("柱形图属性"), Category("Y坐标最大值")]
        [DefaultValue(typeof(long), "9999999")]
        public long YAxisMax
        {
            get => yAxisMax;
            set
            {
                yAxisMax = value;
                uiRefresh();
            }

        }
        private long yAxisMax = 9999999;
        /// <summary>
        /// 柱形图Y坐标最小值
        /// </summary>
        [Browsable(true)]
        [ToolboxItem(true)]
        [Description("柱形图属性"), Category("Y坐标最小值")]
        [DefaultValue(typeof(long), "0")]
        public long YAxisMin
        {
            get => yAxisMin;
            set
            {
                yAxisMin = value;
                uiRefresh();
            }

        }
        private long yAxisMin = 0;

        #endregion
        #region 实现接口参数
        /// <summary>
        /// 读取控制
        /// </summary>
        public bool ReadCommand { get; set; }
        [Browsable(false)]
        [Description("PLC保存参数"), Category("PLC类型")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PLCDataViewselectRealize pLCDataViewselectRealize
        {
            get => pLCDataViewselec;
            set => pLCDataViewselec = value;
        }
        private PLCDataViewselectRealize pLCDataViewselec { get; set; } = new PLCDataViewselectRealize();
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
        private bool plc_Enable = false;
        [Browsable(false)]
        public Timer Timerconfiguration { get; set; } = new Timer() { Enabled = true, Interval = 300 };
        System.Threading.Timer PLCTimer { get; set; }
        [Browsable(false)]
        public event EventHandler Modification;
        #endregion
        public  void Modifications_Eeve(object send, EventArgs e)
        {
            this.Modification -= new EventHandler(Modifications_Eeve);
            var Copy = this.pLCDataViewselectRealize.GetType().GetProperties();
            PLCDataViewselectRealize bitselectRealize = new PLCDataViewselectRealize();
            var CopyTo = bitselectRealize.GetType().GetProperties();
            for (int i = 0; i < Copy.Length; i++)
            {
                CopyTo[i] = Copy[i];
            }
            this.BeginInvoke((MethodInvoker)delegate
            {
                PLCDataViewForm pLCpropertyBit = new PLCDataViewForm(this, this)
                {
                    StartPosition = FormStartPosition.CenterParent
                };
                pLCpropertyBit.ShowDialog();
                if (!pLCpropertyBit.Save)
                {
                    for (int i = 0; i < Copy.Length; i++)
                    {
                        Copy[i] = CopyTo[i];
                    }
                }
                this.Invoke((MethodInvoker)delegate
                {
                    //参数修改完成--行列进行显示更新--
                    uiRefresh();
                });
            });
        }
        /// <summary>
        /// 刷新UI
        /// </summary>
        private void uiRefresh()
        {
            UIBarOption option = new UIBarOption
            {
                Title = new UITitle
                {
                    Text = this.TitleText,
                    SubText = this.TitleSubText
                },

                //设置Legend
                Legend = new UILegend()
            };
            option.Legend.Orient = UIOrient.Horizontal;
            option.Legend.Top = UITopAlignment.Top;
            option.Legend.Left = UILeftAlignment.Left;


            option.Legend.AddData("Bar1");

            var series = new UIBarSeries
            {
                Name = "Bar1"
            };

            for (int i = 0; i < this.pLCDataViewselectRealize.DataGridView_Name.Length; i++)
            {
                option.XAxis.Data.Add(this.pLCDataViewselectRealize.DataGridView_Name[i]);
                series.AddData(0);
            }
            option.Series.Add(series);


            option.ToolTip.Visible = true;
            option.YAxis.Scale = true;

            option.XAxis.Name = this.XAxisName;
            option.YAxis.Name = this.YAxisName;

            option.YAxisScaleLines.Add(new UIScaleLine() { Color = Color.Red, Name = "上限", Value =this.YAxisMax });
            option.YAxisScaleLines.Add(new UIScaleLine() { Color = Color.Gold, Name = "下限", Value =this.YAxisMin });

            option.XAxisScaleLines.Add(new UIScaleLine() { Color = Color.Red, Name = "上限", Value = this.XAxisMax });
            option.XAxisScaleLines.Add(new UIScaleLine() { Color = Color.Gold, Name = "下限", Value = this.XAxisMin });


            this.SetOption(option);
        }

    }
}
