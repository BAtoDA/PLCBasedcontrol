//**********************************************************************
//
// 文件名称(File Name)：
// 功能描述(Description)：
// 作者(Author)：DAtoTA
// 日期(Create Date)： 2021/9/5 17:36:00
//
//**********************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PLC通讯基础控件项目.基础控件.底层PLC状态监控控件;
using PLC通讯基础控件项目.控件类基.PLC基础接口;
using PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类;
using PLC通讯基础控件项目.控件类基.PLC基础接口.判定控件是否在设计期;
using PLC通讯基础控件项目.控件类基.控件地址选择窗口;
using PLC通讯基础控件项目.控件类基.控件数据结构;

namespace PLC通讯基础控件项目.基础控件
{
    /// <summary>
    /// 实现上位机底层控件 普通按钮类 -不再公共运行时
    /// 继承接口PLCBitClassBase,PLCBitproperty, ICloneable
    /// </summary>
    public partial class DAButton
    {
        public DAButton()
        {
            Timerconfiguration.Tick += ((send, e) =>
             {
                 //立马刷新状态
                 this.SuspendLayout();
                 this.backgroundColor_0 = this.pLCBitselectRealize.backgroundColor_0;
                 this.TextContent_0 = this.pLCBitselectRealize.TextContent_0;
                 this.TextColor_0 = this.pLCBitselectRealize.TextColor_0;
                 this.Refresh();
                 this.ResumeLayout(false);
                 Timerconfiguration.Stop();
                 //处理PLC通讯部分
                 //if (!this.PLC_Enable || this.IsDisposed || this.Created == false|| DesignMode) return;//用户不开启PLC功能
                 if (!this.PLC_Enable || this.IsDisposed || DesignMode) return;//用户不开启PLC功能
                 {
                     //ControlDebug.Write($"开始加载：{this.Name}控件 归属PLC是：{this.pLCBitselectRealize.ReadWritePLC}");
                       controlPLCBitBase = new ControlPLCBitBase(this);
                     //ControlDebug.Write($"加载完成：{this.Name}控件 归属PLC是：{this.pLCBitselectRealize.ReadWritePLC}");
                 }
             });
        }
    }
    [ToolboxItem(true)]
    [Browsable(true)]
    [Description("实现上位机底层控件 普通按钮类 -不再公共运行时 ")]
    public partial class DAButton:Button, PLCBitClassBase, PLCBitproperty, ICloneable
    {
        #region 实现接口参数
        [Browsable(false)]
        public event EventHandler Modification;
        [Browsable(false)]
        [Description("PLC保存参数"), Category("PLC类型")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PLCBitselectRealize pLCBitselectRealize
        {
            get => pLCBitselectsq;
            set => pLCBitselectsq = value;
        }
        /// <summary>
        /// 私有保存参数 自动添加
        /// </summary>
        private PLCBitselectRealize pLCBitselectsq { get; set; } = new PLCBitselectRealize();

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
        public string Textalign_0
        {
            get
            {
                if (pLCBitselectRealize.Textalign_0 != null)
                    return pLCBitselectRealize.Textalign_0;
                else
                    return ContentAlignment.BottomCenter.ToString();
            }
            set => this.TextAlign = (ContentAlignment)Enum.Parse(typeof(ContentAlignment), value);
        }
        [Browsable(false)]
        public Font TextFont_0 { get => pLCBitselectRealize.TextFont_0; set => this.Font = value; }
        [Browsable(false)]
        public string Textalign_1
        {
            get
            {
                if (pLCBitselectRealize.Textalign_0 != null)
                    return pLCBitselectRealize.Textalign_0;
                else
                    return ContentAlignment.BottomCenter.ToString();
            }
            set => this.TextAlign = (ContentAlignment)Enum.Parse(typeof(ContentAlignment), value);
        }
        [Browsable(false)]
        public Font TextFont_1 { get => pLCBitselectRealize.TextFont_0; set => this.Font = value; }
        [Browsable(false)]
        public Color backgroundColor_0 { get => pLCBitselectRealize.backgroundColor_0; set => this.BackColor = value; }
        [Browsable(false)]
        public Color TextColor_0 { get => pLCBitselectRealize.TextColor_0; set => this.ForeColor = value; }
        [Browsable(false)]
        public string TextContent_0 { get => pLCBitselectRealize.TextContent_0; set => this.Text = value; }
        [Browsable(false)]
        public Color backgroundColor_1 { get => pLCBitselectRealize.backgroundColor_1; set => this.BackColor = value; }
        [Browsable(false)]
        public Color TextColor_1 { get => pLCBitselectRealize.TextColor_1; set => this.ForeColor = value; }
        [Browsable(false)]
        public string TextContent_1 { get => pLCBitselectRealize.TextContent_1; set => this.Text = value; }
        [Browsable(false)]
        public System.Threading.Timer PLCTimer { get; set; }
        public System.Windows.Forms.Timer Timerconfiguration { get; set; } = new System.Windows.Forms.Timer() { Enabled=true, Interval=100};

        /// <summary>
        /// 修改参数界面窗口事件方法
        /// </summary>
        /// <param name="send"></param>
        /// <param name="e"></param>

        public  void Modifications_Eeve(object send, EventArgs e)
        {
            this.Modification -= new EventHandler(Modifications_Eeve);
            //----------------复制该对象的属性---------------
            var Copy = pLCBitselectRealize.GetType().GetProperties();

            PLCBitselectRealize PlcBitselectCopy = (PLCBitselectRealize)Activator.CreateInstance(pLCBitselectRealize.GetType());

            for (int i = 0; i < Copy.Length; i++)
            {
                PlcBitselectCopy.GetType().GetProperties()[i].SetValue(PlcBitselectCopy, Copy[i].GetValue(pLCBitselectRealize));
            }
            this.BeginInvoke((MethodInvoker)delegate
            {
                PLCpropertyBit pLCpropertyBit = new PLCpropertyBit(PlcBitselectCopy);
                pLCpropertyBit.StartPosition = FormStartPosition.CenterParent;
                pLCpropertyBit.ShowDialog();
                if (pLCpropertyBit.Save)
                {
                    //-------------放回对象属性----------------
                    var Copy = PlcBitselectCopy.GetType().GetProperties();
                    for (int i = 0; i < Copy.Length; i++)
                    {
                        pLCBitselectRealize.GetType().GetProperties()[i].SetValue(pLCBitselectRealize, Copy[i].GetValue(PlcBitselectCopy));
                    }
                }
                this.Invoke((MethodInvoker)delegate
                {
                    //立马刷新状态
                    this.SuspendLayout();
                    this.backgroundColor_0 = this.pLCBitselectRealize.backgroundColor_0;
                    this.TextContent_0 = this.pLCBitselectRealize.TextContent_0;
                    this.TextColor_0 = this.pLCBitselectRealize.TextColor_0;
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
        public void ControlSwitch(bool switchover)
        {
            if (switchover)
            {
                //立马刷新状态
                this.SuspendLayout();
                this.backgroundColor_0 = this.pLCBitselectRealize.backgroundColor_1;
                this.TextContent_0 = this.pLCBitselectRealize.TextContent_1;
                this.TextColor_0 = this.pLCBitselectRealize.TextColor_1;
                this.Refresh();
                this.ResumeLayout(false);
            }
            else
            {
                //立马刷新状态
                this.SuspendLayout();
                this.backgroundColor_0 = this.pLCBitselectRealize.backgroundColor_0;
                this.TextContent_0 = this.pLCBitselectRealize.TextContent_0;
                this.TextColor_0 = this.pLCBitselectRealize.TextColor_0;
                this.Refresh();
                this.ResumeLayout(false);
            }
        }
        #endregion
        #region 编辑模式刷新状态
        protected override void OnLayout(LayoutEventArgs levent)
        {
            if (DesignMode)
            {
                //立马刷新状态
                this.SuspendLayout();
                this.backgroundColor_0 = this.pLCBitselectRealize.backgroundColor_0;
                this.TextContent_0 = this.pLCBitselectRealize.TextContent_0;
                this.TextColor_0 = this.pLCBitselectRealize.TextColor_0;
                this.Refresh();
                this.ResumeLayout(false);
            }
            base.OnLayout(levent);
        }

        #endregion
        #region 新增代码层写入值
        /// <summary>
        /// PLC写入底层对象
        /// </summary>
        ControlPLCBitBase controlPLCBitBase;
        /// <summary>
        /// 代码层写入
        /// </summary>
        object PLClock = new object();
        /// <summary>
        /// 写入值 格式由设置好的格式 可更改
        /// </summary>
        [Browsable(false)]
        [ToolboxItem(false)]
        public virtual bool WrietCommand
        {
            set
            {
                //进行写入操作
                lock (PLClock)
                {
                    if (controlPLCBitBase != null)
                    {
                        //写入当前控件值
                        controlPLCBitBase.PLCWrite(this.pLCBitselectRealize.ReadWrite ? this.pLCBitselectRealize.WritePLC : this.pLCBitselectRealize.ReadWritePLC, this.pLCBitselectRealize.ReadWrite ?
                            this.pLCBitselectRealize.WriteFunction : this.pLCBitselectRealize.ReadWriteFunction, this.pLCBitselectRealize.ReadWrite ? this.pLCBitselectRealize.WriteAddress : this.pLCBitselectRealize.ReadWriteAddress,value);
                    }

                }
            }
        }
        /// <summary>
        /// 读取当前状态值
        /// </summary>
        [Browsable(false)]
        [ToolboxItem(false)]
        public virtual bool ReadCommand { get; set; }
        #endregion
    }
}
