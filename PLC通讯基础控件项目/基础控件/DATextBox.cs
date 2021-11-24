//**********************************************************************
//
// 文件名称(File Name)：
// 功能描述(Description)：
// 作者(Author)：DAtoTA
// 日期(Create Date)： 2021/9/9 21:10:21
//
//**********************************************************************
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.ComponentModel;
using PLC通讯基础控件项目.控件类基.PLC基础接口;
using PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLCD控件实现类;
using PLC通讯基础控件项目.控件类基.控件数据结构;
using System.Drawing;
using PLC通讯基础控件项目.控件类基.控件地址选择窗口;
using PLC通讯基础控件项目.基础控件.底层PLC状态监控控件;

namespace PLC通讯基础控件项目.基础控件
{
    /// <summary>
    /// 实现上位机底层控件 普通文本类 -不再公共运行时
    /// </summary>
    public partial class DATextBox
    {
        public DATextBox()
        {
            Timerconfiguration.Tick += ((send, e) =>
              {
                  Timerconfiguration.Stop();
                  //处理PLC通讯部分
                  if (!this.PLC_Enable || this.IsDisposed || this.Created == false|| DesignMode) return;//用户不开启PLC功能
                  {
                      //ControlDebug.Write($"开始加载：{this.Name}控件 归属PLC是：{this.pLCDselectRealize.ReadWritePLC}");
                      ControlPLCDBase controlPLCDBase = new ControlPLCDBase(this);
                      //ControlDebug.Write($"加载完成：{this.Name}控件 归属PLC是：{this.pLCDselectRealize.ReadWritePLC}");
                  }
                  //立马刷新状态
                  this.SuspendLayout();
                  this.TextContent_0 = this.pLCDselectRealize.TextContent_0;
                  this.TextColor_0 = this.pLCDselectRealize.TextColor_0;
                  this.Refresh();
                  this.ResumeLayout(false);
              });
            this.TextContent_0 = "0";
        }
    }
    [ToolboxItem(true)]
    [Browsable(true)]
    [Description("实现上位机底层控件 普通文本类 -不再公共运行时 ")]
    public partial class DATextBox:TextBox, PLCDClassBase, PLCDproperty, ICloneable
    {
        #region 实现接口参数
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
        public Timer Timerconfiguration { get; set; } = new Timer() { Enabled = true, Interval = 300 };

        /// <summary>
        /// 修改参数界面窗口事件方法
        /// </summary>
        /// <param name="send"></param>
        /// <param name="e"></param>

        public void Modifications_Eeve(object send, EventArgs e)
        {
            this.Modification -= new EventHandler(Modifications_Eeve);
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
                PLCpropertyD pLCpropertyBit = new PLCpropertyD(PlcBitselectCopy)
                {
                    StartPosition = FormStartPosition.CenterParent
                };

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
                this.Invoke((MethodInvoker)delegate
                {
                //立马刷新状态
                this.SuspendLayout();
                    this.TextContent_0 = this.pLCDselectRealize.TextContent_0;
                    this.TextColor_0 = this.pLCDselectRealize.TextColor_0;
                    this.Refresh();
                    this.ResumeLayout(false);
                });
            });
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
        #region 编辑模式刷新状态
        protected override void OnLayout(LayoutEventArgs levent)
        {
            if (DesignMode)
            {
                //立马刷新状态
                this.SuspendLayout();
                this.TextContent_0 = this.pLCDselectRealize.TextContent_0;
                this.TextColor_0 = this.pLCDselectRealize.TextColor_0;
                this.Text = "0";
                this.Refresh();
                this.ResumeLayout(false);
            }
            base.OnLayout(levent);
        }
        #endregion
    }

}
