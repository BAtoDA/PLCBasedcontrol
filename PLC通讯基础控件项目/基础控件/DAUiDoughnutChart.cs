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
                if (!this.PLC_Enable || this.IsDisposed || this.Created == false || DesignMode) return;//用户不开启PLC功能
                else
                {
                    uiRefresh();
                    ControlPLCDoughnutChartBase controlPLCDataViewBase = new ControlPLCDoughnutChartBase(this);
                }
            });
        }  
    }
   [ToolboxItem(true)]
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
            uiRefresh();
        }
        /// <summary>
        /// 刷新UI
        /// </summary>
        private void uiRefresh()
        {
            this.SuspendLayout();
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
            this.SetOption(option);
            this.Refresh();
            this.ResumeLayout();
        }
        #endregion
        private class Angle
        {
            public float Start
            {
                get;
                set;
            }

            public float Sweep
            {
                get;
                set;
            }

            public float Inner
            {
                get;
                set;
            }

            public float Outer
            {
                get;
                set;
            }

            public PointF Center
            {
                get;
                set;
            }

            public string Text
            {
                get;
                set;
            }

            public SizeF TextSize
            {
                get;
                set;
            }

            public Angle(float start, float sweep, string text)
            {
                Start = start;
                Sweep = sweep;
                Text = text;
            }
        }

        private readonly ConcurrentDictionary<int, ConcurrentDictionary<int, Angle>> Angles = new ConcurrentDictionary<int, ConcurrentDictionary<int, Angle>>();

        private int ActiveAzIndex = -1;

        private int ActivePieIndex = -1;

        [Browsable(false)]
        [DefaultValue(null)]
        public UIDoughnutOption Option => (UIDoughnutOption)(base.BaseOption ?? base.EmptyOption);

        protected override void CreateEmptyOption()
        {
            if (emptyOption == null)
            {
                UIDoughnutOption uIDoughnutOption = new UIDoughnutOption();
                uIDoughnutOption.Title = new UITitle();
                uIDoughnutOption.Title.Text = "SunnyUI";
                uIDoughnutOption.Title.SubText = "DoughnutChart";
                UIDoughnutSeries uIDoughnutSeries = new UIDoughnutSeries();
                uIDoughnutSeries.Name = "饼状图";
                uIDoughnutSeries.Center = new UICenter(50, 55);
                uIDoughnutSeries.Radius.Inner = 40;
                uIDoughnutSeries.Radius.Outer = 70;
                for (int i = 0; i < 5; i++)
                {
                    uIDoughnutSeries.AddData("Data" + i, (i + 1) * 20);
                }

                uIDoughnutOption.Series.Add(uIDoughnutSeries);
                emptyOption = uIDoughnutOption;
            }
        }

        public void Update(string seriesName, string name, double value)
        {
            Option[seriesName]?.Update(name, value);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            CalcData();
        }

        public override void Refresh()
        {
            base.Refresh();
            if (Option != null)
            {
                SetOption(Option);
            }

            CalcData();
        }

        protected override void DrawOption(Graphics g)
        {
            if (Option != null)
            {
                DrawTitle(g, Option.Title);
                DrawSeries(g, Option.Series);
                DrawLegend(g, Option.Legend);
            }
        }

        protected override void CalcData()
        {
            Angles.Clear();
            if (Option == null || Option.Series == null || Option.Series.Count == 0)
            {
                return;
            }

            for (int i = 0; i < Option.Series.Count; i++)
            {
                UIDoughnutSeries uIDoughnutSeries = Option.Series[i];
                Angles.TryAdd(i, new ConcurrentDictionary<int, Angle>());
                double num = 0.0;
                foreach (UIPieSeriesData datum in uIDoughnutSeries.Data)
                {
                    num += datum.Value;
                }

                if (num.IsZero())
                {
                    break;
                }

                float num2 = 0f;
                for (int j = 0; j < uIDoughnutSeries.Data.Count; j++)
                {
                    float num3 = (float)(uIDoughnutSeries.Data[j].Value * 360.0 / num);
                    float num4 = (float)(uIDoughnutSeries.Data[j].Value * 100.0 / num);
                    string text = "";
                    if (Option.ToolTip != null)
                    {
                        try
                        {
                            UITemplate uITemplate = new UITemplate(Option.ToolTip.Formatter);
                            uITemplate.Set("a", uIDoughnutSeries.Name);
                            uITemplate.Set("b", uIDoughnutSeries.Data[j].Name);
                            uITemplate.Set("c", uIDoughnutSeries.Data[j].Value.ToString(Option.ToolTip.ValueFormat));
                            uITemplate.Set("d", num4.ToString("F2"));
                            text = uITemplate.Render();
                        }
                        catch
                        {
                            text = uIDoughnutSeries.Data[j].Name + " : " + uIDoughnutSeries.Data[j].Value.ToString("F2") + "(" + num4.ToString("F2") + "%)";
                            if (uIDoughnutSeries.Name.IsValid())
                            {
                                text = uIDoughnutSeries.Name + "\n" + text;
                            }
                        }
                    }

                    Angle angle = new Angle(num2, num3, text);
                    GetSeriesRect(uIDoughnutSeries, ref angle);
                    Angles[i].TryAddOrUpdate(j, angle);
                    num2 += num3;
                }
            }
        }

        private void DrawSeries(Graphics g, List<UIDoughnutSeries> series)
        {
            if (series == null || series.Count == 0)
            {
                return;
            }

            for (int i = 0; i < series.Count; i++)
            {
                UIDoughnutSeries uIDoughnutSeries = series[i];
                for (int j = 0; j < uIDoughnutSeries.Data.Count; j++)
                {
                    Angle angle = Angles[i][j];
                    Color color = base.ChartStyle.GetColor(j);
                    UIPieSeriesData uIPieSeriesData = uIDoughnutSeries.Data[j];
                    if (uIPieSeriesData.StyleCustomMode)
                    {
                        color = uIPieSeriesData.Color;
                    }

                    if (ActiveAzIndex == j)
                    {
                        g.FillFan(color, angle.Center, angle.Inner, angle.Outer + 5f, angle.Start - 90f, angle.Sweep);
                    }
                    else
                    {
                        g.FillFan(color, angle.Center, angle.Inner, angle.Outer, angle.Start - 90f, angle.Sweep);
                    }

                    Angles[i][j].TextSize = g.MeasureString(Angles[i][j].Text, base.LegendFont);
                    if (uIDoughnutSeries.Label.Show && ActiveAzIndex == j && uIDoughnutSeries.Label.Position == UIPieSeriesLabelPosition.Center)
                    {
                        SizeF sizeF = g.MeasureString(uIDoughnutSeries.Data[j].Name, Font);
                        g.DrawString(uIDoughnutSeries.Data[j].Name, Font, color, angle.Center.X - sizeF.Width / 2f, angle.Center.Y - sizeF.Height / 2f);
                    }
                }
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (Option.SeriesCount == 0)
            {
                SetPieAndAzIndex(-1, -1);
                return;
            }

            for (int i = 0; i < Option.SeriesCount; i++)
            {
                for (int j = 0; j < Option.Series[i].Data.Count; j++)
                {
                    Angle angle = Angles[i][j];
                    PointF center = angle.Center;
                    if (MathEx.CalcDistance(e.Location, center) > (double)angle.Outer || MathEx.CalcDistance(e.Location, center) < (double)angle.Inner)
                    {
                        continue;
                    }

                    double num = MathEx.CalcAngle(e.Location, center);
                    if (num >= (double)angle.Start && num <= (double)(angle.Start + angle.Sweep))
                    {
                        SetPieAndAzIndex(i, j);
                        if (tip.Text != angle.Text)
                        {
                            tip.Text = angle.Text;
                            tip.Size = new Size((int)angle.TextSize.Width + 4, (int)angle.TextSize.Height + 4);
                        }

                        if (num >= 0.0 && num < 90.0)
                        {
                            tip.Top = e.Location.Y + 20;
                            tip.Left = e.Location.X - tip.Width;
                        }
                        else if (num >= 90.0 && num < 180.0)
                        {
                            tip.Left = e.Location.X - tip.Width;
                            tip.Top = e.Location.Y - tip.Height - 2;
                        }
                        else if (num >= 180.0 && num < 270.0)
                        {
                            tip.Left = e.Location.X;
                            tip.Top = e.Location.Y - tip.Height - 2;
                        }
                        else if (num >= 270.0 && num < 360.0)
                        {
                            tip.Left = e.Location.X + 15;
                            tip.Top = e.Location.Y + 20;
                        }

                        if (Option.ToolTip.Visible && !tip.Visible)
                        {
                            tip.Visible = angle.Text.IsValid();
                        }

                        return;
                    }
                }
            }

            SetPieAndAzIndex(-1, -1);
            tip.Visible = false;
        }

        private void SetPieAndAzIndex(int pieIndex, int azIndex)
        {
            if (ActivePieIndex != pieIndex || ActiveAzIndex != azIndex)
            {
                ActivePieIndex = pieIndex;
                ActiveAzIndex = azIndex;
                Invalidate();
            }
        }

        private void GetSeriesRect(UIDoughnutSeries series, ref Angle angle)
        {
            int left = series.Center.Left;
            int top = series.Center.Top;
            left = base.Width * left / 100;
            top = base.Height * top / 100;
            angle.Center = new PointF(left, top);
            angle.Inner = (float)(Math.Min(base.Width, base.Height) * series.Radius.Inner) / 200f;
            angle.Outer = (float)(Math.Min(base.Width, base.Height) * series.Radius.Outer) / 200f;
        }
    }
}
