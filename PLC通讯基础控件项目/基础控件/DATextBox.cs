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
                  if (!this.PLC_Enable || this.IsDisposed || this.Created == false) return;//用户不开启PLC功能
                  {
                      ControlPLCDBase controlPLCBitBase = new ControlPLCDBase(this);
                  }
              });
        }
        //protected override void InitLayout()
        //{
        //    //处理PLC通讯部分
        //    if (!this.PLC_Enable || this.IsDisposed) return;//用户不开启PLC功能
        //    {
        //        ControlPLCDBase controlPLCBitBase = new ControlPLCDBase(this);
        //    }
        //    base.InitLayout();
        //}
        //protected override void OnEnter(EventArgs e)
        //{
        //    //处理PLC通讯部分
        //    if (!this.PLC_Enable || this.IsDisposed || this.Created == false) return;//用户不开启PLC功能
        //    {
        //        ControlPLCDBase controlPLCBitBase = new ControlPLCDBase(this);
        //    }
        //    base.OnEnter(e);
        //}
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
            var Copy = this.pLCDselectRealize.GetType().GetProperties();
            PLCDselectRealize bitselectRealize = new PLCDselectRealize();
            var CopyTo = bitselectRealize.GetType().GetProperties();
            for (int i = 0; i < Copy.Length; i++)
            {
                //if (Copy[i].Name == CopyTo[i].Name)
                CopyTo[i] = Copy[i];
            }
            PLCpropertyD pLCpropertyBit = new PLCpropertyD(this.pLCDselectRealize);
            pLCpropertyBit.StartPosition = FormStartPosition.CenterParent;

            pLCpropertyBit.ShowDialog();
            if (!pLCpropertyBit.Save)
            {
                for (int i = 0; i < Copy.Length; i++)
                {
                    //if (Copy[i].Name == CopyTo[i].Name)
                    Copy[i] = CopyTo[i];
                }
                //this.pLCBitselectRealize = bitselectRealize;
            }
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
    }

}
