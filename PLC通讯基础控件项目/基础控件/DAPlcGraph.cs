using PLC通讯基础控件项目.控件类基.PLC基础接口;
using PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLCD控件实现类;
using PLC通讯基础控件项目.控件类基.控件地址选择窗口;
using PLC通讯基础控件项目.控件类基.控件数据结构;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using PLC通讯基础控件项目.控件类基.控件地址选择窗口.顺控视图参数设置界面;
using System.Threading;

namespace PLC通讯基础控件项目.基础控件
{
    /// <summary>
    /// 显示预设好的顺控视图
    /// </summary>
    [ToolboxItem(true)]
    [Browsable(true)]
    public partial class DAPlcGraph : UserControl, PLCDClassBase, PLCDproperty, ICloneable
    {
        #region 实现接口参数
        [Browsable(true)]
        [Description("控件显示标题"), Category("PLC类型")]
        public string Title { get => this.uiLabel2.Text; set => this.uiLabel2.Text = value; }
        [Browsable(false)]
        public event EventHandler Modification;
        [Browsable(false)]
        [Description("PLC保存参数"), Category("PLC类型")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PLCDselectRealize pLCDselectRealize
        {
            get => pLCBitselectsq;
            set => pLCBitselectsq = value;
        }
        /// <summary>
        /// 私有保存参数 自动添加
        /// </summary>
        private PLCDselectRealize pLCBitselectsq { get; set; } = new PLCDselectRealize();
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
        public string Textalign_0 { get; set; }
        [Browsable(false)]
        public Font TextFont_0 { get => pLCDselectRealize.TextFont_0; set => this.Font = value; }
        [Browsable(false)]
        public string Textalign_1 { get; set; }
        [Browsable(false)]
        public Font TextFont_1 { get => pLCDselectRealize.TextFont_0; set => this.Font = value; }
        [Browsable(false)]
        public Color TextColor_0 { get => pLCDselectRealize.TextColor_0; set => this.ForeColor = value; }
        [Browsable(false)]
        public string TextContent_0 { get => pLCDselectRealize.TextContent_0; set => this.Text = value; }
        [Browsable(false)]
        public Color TextColor_1 { get => pLCDselectRealize.TextColor_1; set => this.ForeColor = value; }
        [Browsable(false)]
        public string TextContent_1 { get => pLCDselectRealize.TextContent_1; set => this.Text = value; }
        [Browsable(false)]
        public System.Threading.Timer PLCTimer { get; set; }
        public System.Windows.Forms.Timer Timerconfiguration { get; set; } = new System.Windows.Forms.Timer() { Enabled = true, Interval = 300 };

        /// <summary>
        /// 修改参数界面窗口事件方法
        /// </summary>
        /// <param name="send"></param>
        /// <param name="e"></param>

        public  void Modifications_Eeve(object send, EventArgs e)
        {
            this.Modification -= new EventHandler(Modifications_Eeve);
            //----------------复制该对象的属性---------------
            var Copy = pLCDselectRealize.GetType().GetProperties();

            PLCDselectRealize PlcBitselectCopy = (PLCDselectRealize)Activator.CreateInstance(pLCDselectRealize.GetType());

            for (int i = 0; i < Copy.Length; i++)
            {
                PlcBitselectCopy.GetType().GetProperties()[i].SetValue(PlcBitselectCopy, Copy[i].GetValue(pLCDselectRealize));
            }
            this.BeginInvoke((MethodInvoker)delegate
            {
                 PLCpropertyD pLCpropertyBit = new PLCpropertyD(PlcBitselectCopy);
                 pLCpropertyBit.StartPosition = FormStartPosition.CenterParent;

                 pLCpropertyBit.ShowDialog();
                if (pLCpropertyBit.Save)
                {
                    //-------------放回对象属性----------------
                    var Copy = PlcBitselectCopy.GetType().GetProperties();
                    for (int i = 0; i < Copy.Length; i++)
                    {
                        pLCDselectRealize.GetType().GetProperties()[i].SetValue(pLCDselectRealize, Copy[i].GetValue(PlcBitselectCopy));
                    }
                }
            });
            //立马刷新状态
            this.SuspendLayout();
            this.TextContent_0 = this.pLCDselectRealize.TextContent_0;
            this.TextColor_0 = this.pLCDselectRealize.TextColor_0;
            this.Refresh();
            this.ResumeLayout(false);
        }
        /// <summary>
        /// 复制控件方法
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return this;
        }
        #endregion
        #region 实现顺控视图
        [Description("设置顺控视图参数"), Category("PLC类型")]
        public PLCSet APLCGraph
        {
            get => PLCsz;
            set
            {
                if (plc_Enable)
                {
                    this.Modification += new EventHandler(GraphModifications_Eeve);
                    this.Modification(this, new EventArgs());
                    this.Modification -= new EventHandler(GraphModifications_Eeve);
                    return;
                }
                this.Modification -= new EventHandler(GraphModifications_Eeve);
            }
        }
        public void GraphModifications_Eeve(object send, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                FormGraph graph = new FormGraph(this.GraphList);
                graph.ShowDialog();
                if (graph.Save)
                {
                    GraphList = graph.GraphList;
                }
            });
        }
        /// <summary>
        /// 视图步参数设置
        /// </summary>
        [Browsable(false)]
        [Description("PLC保存参数"), Category("PLC类型")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public R[] GraphList
        { 
            get => graphList; 
            set => graphList=value;
        }
        private R[] graphList = new R[] { new R()};
        #endregion
        public DAPlcGraph()
        {
            InitializeComponent();
            Timerconfiguration.Tick += ((send, e) =>
            {
                Timerconfiguration.Stop();
                this.TextContent_0 = "0";
                //处理PLC通讯部分
                if (!this.PLC_Enable || this.IsDisposed || this.Created == false || DesignMode) return;//用户不开启PLC功能
                {
                    //处理控件部分
                    ControlPLCDBase controlPLCDBase = new ControlPLCDBase(this);
                    //处理顺控视图部分
                    this.uiButton1.Click += ((send, e) =>
                      {
                          if (this.uiDataGridView1.Visible)
                          {
                              this.uiDataGridView1.Visible = false;
                              this.uiDataGridView1.SendToBack();
                          }
                          else
                          {
                              this.uiDataGridView1.Visible = true;
                              this.uiDataGridView1.BringToFront();
                          }
                      });
                    //填充数据集到表格视图中
                    this.uiDataGridView1.DataSource = this.GraphList.ToList();
                    //处理循环任务
                    System.Threading.Timer GraphTimer = new System.Threading.Timer(new TimerCallback((s) =>
                    {
                        lock (this)//锁
                        {
                            //判断是否读取到数据
                            int Data;
                            if (int.TryParse(Text, out Data))
                            {
                                this.BeginInvoke((MethodInvoker) delegate
                                {
                                    //填充上一步
                                    //int Index = Data > 0 ? Data - 1 : GraphList.Length - 1;
                                    //this.uiTextBox1.Text = GraphList.Where(p => p.Step == Index).FirstOrDefault() != null ? GraphList.Where(p => p.Step == Index).FirstOrDefault().Step.ToString() : "***";
                                    //this.uiTextBox2.Text = GraphList.Where(p => p.Step == Index).FirstOrDefault() != null ? GraphList.Where(p => p.Step == Index).FirstOrDefault().Content.ToString() : "***";
                                    var LastStepData = GraphList.Where(p => p.Step == Data).FirstOrDefault();
                                    if (LastStepData != null)
                                    {
                                        //填充上一步
                                        this.uiTextBox1.Text = GraphList.Where(p => p.Step == LastStepData.LastStep).FirstOrDefault()!=null ? GraphList.Where(p => p.Step == LastStepData.LastStep).FirstOrDefault().Step.ToString(): "***";
                                        this.uiTextBox2.Text = GraphList.Where(p => p.Step == LastStepData.LastStep).FirstOrDefault() != null ? GraphList.Where(p => p.Step == LastStepData.LastStep).FirstOrDefault().Content.ToString() : "***";
                                        //填充当前步
                                        this.uiTextBox4.Text = LastStepData.Step.ToString();
                                        this.uiTextBox3.Text = LastStepData.Content;
                                        //填充下一步
                                        this.uiTextBox6.Text = GraphList.Where(p => p.Step == LastStepData.NextStep).FirstOrDefault() != null ? GraphList.Where(p => p.Step == LastStepData.NextStep).FirstOrDefault().Step.ToString() : "***";
                                        this.uiTextBox5.Text= GraphList.Where(p => p.Step == LastStepData.NextStep).FirstOrDefault() != null ? GraphList.Where(p => p.Step == LastStepData.NextStep).FirstOrDefault().Content.ToString() : "***";
                                    }
                                    else
                                    {
                                        this.uiTextBox1.Text = "***";
                                        this.uiTextBox2.Text = "***";
                                        this.uiTextBox3.Text = "***";
                                        this.uiTextBox4.Text = "***";
                                        this.uiTextBox5.Text = "***";
                                        this.uiTextBox6.Text = "***";
                                    }
                                    ////填充当前步
                                    //Index = Data > GraphList.Length ? GraphList.Length : Data;
                                    //this.uiTextBox4.Text = GraphList.Where(p => p.Step == Index).FirstOrDefault() != null ? GraphList.Where(p => p.Step == Index).FirstOrDefault().Step.ToString() : "***";
                                    //this.uiTextBox3.Text = GraphList.Where(p => p.Step == Index).FirstOrDefault() != null ? GraphList.Where(p => p.Step == Index).FirstOrDefault().Content.ToString() : "***";
                                    ////填充下一步
                                    //Index = Data + 1 < GraphList.Length ? Data + 1 : GraphList.Length;
                                    //this.uiTextBox6.Text = GraphList.Where(p => p.Step == Index).FirstOrDefault() != null ? GraphList.Where(p => p.Step == Index).FirstOrDefault().Step.ToString() : "***";
                                    //this.uiTextBox5.Text = GraphList.Where(p => p.Step == Index).FirstOrDefault() != null ? GraphList.Where(p => p.Step == Index).FirstOrDefault().Content.ToString() : "***";
                                    //显示当前视图活动索引
                                    var ListData = ((List<R>)this.uiDataGridView1.DataSource);
                                    for (int i = 0; i < ListData.Count; i++)
                                    {
                                        if(ListData[i].Step==Data)
                                        {
                                            this.uiDataGridView1.SuspendLayout();
                                            this.uiDataGridView1.SelectedIndex = i;
                                            this.uiDataGridView1.ResumeLayout();
                                            return;
                                        }
                                    }
                                    
                                }); 
                            }
                        }
                      }));
                    //启动处理任务
                    GraphTimer.Change(500, 300);
                }
            });
            this.TextContent_0 = "0";
        }
    }
    ///顺控视图参数基础类
    public class R
    {
        /// <summary>
        /// ID
        /// </summary>
        public int ID { get; set; } = 0;
        /// <summary>
        /// 当前步号
        /// </summary>
        public int Step { get; set; } = 1;
        /// <summary>
        /// 当前步内容
        /// </summary>
        public string Content { get; set; } = "Null";
        /// <summary>
        /// 关联的上一步
        /// </summary>
        public int LastStep { get; set; } = 0;
        /// <summary>
        /// 关联的下一般
        /// </summary>
        public int NextStep { get; set; } = 0;
    }
}
