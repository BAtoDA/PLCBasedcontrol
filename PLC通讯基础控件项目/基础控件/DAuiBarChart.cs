using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PLC通讯基础控件项目.控件类基.PLC基础接口.表格控件_TO_PLC;
using PLC通讯基础控件项目.控件类基.控件地址选择窗口.表格控件参数界面;
using PLC通讯基础控件项目.控件类基.控件数据结构;
using Sunny.UI;

namespace PLC通讯基础控件项目.基础控件
{
    /// <summary>
    /// 柱形图控件
    /// </summary>
    public partial class DAuiBarChart
    {
    }
    public partial class DAuiBarChart:UIBarChart, PLCDataViewClassBase
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
                Refresh();
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
                Refresh();
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
                Refresh();
            }

        }
        private string xAxisName = "标题";
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
                Refresh();
            }

        }
        private string yAxisName = "标题";
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
            PLCDataViewForm pLCpropertyBit = new PLCDataViewForm(this, this);
            pLCpropertyBit.StartPosition = FormStartPosition.CenterParent;
            pLCpropertyBit.ShowDialog();
            if (!pLCpropertyBit.Save)
            {
                for (int i = 0; i < Copy.Length; i++)
                {
                    Copy[i] = CopyTo[i];
                }
            }
            //参数修改完成--行列进行显示更新--

        }
        /// <summary>
        /// 刷新UI
        /// </summary>
        private void Refresh()
        {
            UIBarOption option = new UIBarOption();
            option.Title = new UITitle();
            option.Title.Text =this.TitleText;
            option.Title.SubText = this.TitleSubText;

            //设置Legend
            option.Legend = new UILegend();
            option.Legend.Orient = UIOrient.Horizontal;
            option.Legend.Top = UITopAlignment.Top;
            option.Legend.Left = UILeftAlignment.Left;


            option.Legend.AddData("Bar1");

            var series = new UIBarSeries();
            series.Name = "Bar1";

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

            option.YAxisScaleLines.Add(new UIScaleLine() { Color = Color.Red, Name = "上限", Value = 9999 });
            option.YAxisScaleLines.Add(new UIScaleLine() { Color = Color.Gold, Name = "下限", Value = 0 });

            this.SetOption(option);
        }

    }
}
