using PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLC圆形图控件实现类;
using PLC通讯基础控件项目.控件类基.PLC基础接口.表格控件_TO_PLC;
using PLC通讯基础控件项目.控件类基.控件地址选择窗口.表格控件参数界面;
using PLC通讯基础控件项目.控件类基.控件数据结构;
using Sunny.UI;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PLC通讯基础控件项目.基础控件
{
    /// <summary>
    /// 圆形图控件
    /// </summary>
    public partial class DAUiDoughnutChart : UIChart, PLCDataViewClassBase
    {
        public DAUiDoughnutChart()
        {
            Timerconfiguration.Tick += ((send, e) =>
            {
                Timerconfiguration.Stop();
                //处理PLC通讯部分
                //if (!this.PLC_Enable || this.IsDisposed || this.Created == false || DesignMode) return;//用户不开启PLC功能
                if (!this.PLC_Enable || this.IsDisposed || DesignMode) return;//用户不开启PLC功能
                else
                {
                    uiRefresh();
                    ControlPLCDoughnutChartBase controlPLCDataViewBase = new ControlPLCDoughnutChartBase(this);
                }
            });
        }
    }
   [ToolboxItem(false)]
    public partial class DAUiDoughnutChart: UIChart, PLCDataViewClassBase, ControlDoughnutChartClassBase
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

        public void Modifications_Eeve(object send, EventArgs e)
        {
            this.Modification -= new EventHandler(Modifications_Eeve);
            var Copy = this.pLCDataViewselectRealize.GetType().GetProperties();
            PLCDataViewselectRealize bitselectRealize = new PLCDataViewselectRealize();
            var CopyTo = bitselectRealize.GetType().GetProperties();
            for (int i = 0; i < Copy.Length; i++)
            {
                CopyTo[i] = Copy[i];
            }
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
            //参数修改完成--行列进行显示更新--
            uiRefresh();
        }
        /// <summary>
        /// 刷新UI
        /// </summary>
        private void uiRefresh()
        {
            if(DesignMode)return;
            var option = new UIDoughnutOption();
            //设置Title
            option.Title = new UITitle();
            option.Title.Text = this.TitleText??"NULL";
            option.Title.SubText = this.TitleSubText ?? "NULL";
            option.Title.Left = UILeftAlignment.Center;

            //设置ToolTip
            option.ToolTip.Visible = true;

            //设置Legend
            option.Legend = new UILegend();
            option.Legend.Orient = UIOrient.Vertical;
            option.Legend.Top = UITopAlignment.Top;
            option.Legend.Left = UILeftAlignment.Left;
            foreach (var i in this.pLCDataViewselectRealize.DataGridView_Name)
                option.Legend.AddData(i);

            //设置Series
            var series = new UIDoughnutSeries();
            series.Name = "Star count";
            series.Center = new UICenter(50, 55);
            series.Radius.Inner = 40;
            series.Radius.Outer = 70;
            series.Label.Show = true;
            series.Label.Position = UIPieSeriesLabelPosition.Center;

            //增加数据
            foreach (var i in this.pLCDataViewselectRealize.DataGridView_Name)
                series.AddData(i, 0);

            //增加Series
            option.Series.Add(series);

            //设置Option
            BaseOption = option;
            this.SetOption(option);
            CalcData();
        }
        #endregion
        
    }
}
