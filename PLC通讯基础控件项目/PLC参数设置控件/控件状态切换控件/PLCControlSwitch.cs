using PLC通讯基础控件项目.控件类基.PLC基础接口;
using PLC通讯基础控件项目.控件类基.控件数据结构;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PLC通讯基础控件项目.PLC参数设置控件.控件状态切换控件
{
    /// <summary>
    /// 状态切换枚举
    /// </summary>
    public enum Switch
    {
        Bit0 = 0, Bit1 = 1
    }

    /// <summary>
    /// 切换PLC所有Bit控件的状态
    /// 改模式方便用户调试
    /// </summary>
    [ToolboxItem(true)]
    [Browsable(true)]
    [ToolboxBitmap(typeof(PLCControlSwitch), "ComponentTest.bmp")]
    [DesignTimeVisible(true)]
    [Description("切换PLC所有Bit控件的状态")]
    public partial class PLCControlSwitch: Timer
    {
        private IContainer _Designer;
        public PLCControlSwitch(IContainer container)
        {
            this._Designer = container;
            foreach (var i in container.Components)
            {
                if (i is PLCControlSwitch) throw new Exception("该控件已经存在无需重复添加");
            }
            container.Add(this);
        }

        [Browsable(false)]
        public event EventHandler Modification;

        [Description("切换Bit位控件的状态"), Category("控件")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Switch ControlSwitch
        {
            get => PLCsz;
            set
            {
                PLCsz = value;
                this.Modification += new EventHandler(Modifications_Eeve);
                this.Modification(this, new EventArgs());
                this.Modification -= new EventHandler(Modifications_Eeve);
            }
        }
        /// <summary>
        /// 私有设置PLC参数
        /// </summary>
        private Switch PLCsz = 0;
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="send"></param>
        /// <param name="e"></param>
        public void Modifications_Eeve(object send, EventArgs e)
        {
            foreach (var i in this._Designer.Components)
            {
                if((i as PLCBitClassBase)!=null)
                {
                    ((PLCBitClassBase)i).ControlSwitch(Convert.ToBoolean(ControlSwitch));
                }
            }
        }
    }
}
