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
using PLC通讯基础控件项目.控件类基.PLC基础接口;
using PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类;
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
        protected override void OnEnter(EventArgs e)
        {
            //处理PLC通讯部分
            if (!this.PLC_Enable || this.IsDisposed || this.Created == false) return;//用户不开启PLC功能
            {
                ControlPLCBitBase controlPLCBitBase = new ControlPLCBitBase(this);
            }
            base.OnEnter(e);
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
        /// <summary>
        /// 修改参数界面窗口事件方法
        /// </summary>
        /// <param name="send"></param>
        /// <param name="e"></param>

        public void Modifications_Eeve(object send, EventArgs e)
        {
            var Copy = this.pLCBitselectRealize.GetType().GetProperties();
            PLCBitselectRealize bitselectRealize = new PLCBitselectRealize();
            var CopyTo = bitselectRealize.GetType().GetProperties();
            for (int i = 0; i < Copy.Length; i++)
            {
                //if (Copy[i].Name == CopyTo[i].Name)
                    CopyTo[i] = Copy[i];
            }
            PLCpropertyBit pLCpropertyBit = new PLCpropertyBit(this.pLCBitselectRealize);
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
