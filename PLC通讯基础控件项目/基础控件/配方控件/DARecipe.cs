using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.配方控件实现类;
using PLC通讯基础控件项目.控件类基.控件数据结构;

namespace PLC通讯基础控件项目.基础控件.配方控件
{
    public partial class DARecipe : UserControl, PLCRecipeInterfaceBase
    {
        #region 控件属性
        [Browsable(false)]
        [Description("PLC保存参数"), Category("PLC类型")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PLCRecipeClassBase[] PLCRecipeClass 
        { 
            get => pLCRecipeClass;
            set => pLCRecipeClass=value;
        }
        /// <summary>
        /// 私有的配方保存参数
        /// </summary>
        private PLCRecipeClassBase[] pLCRecipeClass=new PLCRecipeClassBase[] {new PLCRecipeClassBase() };
        /// <summary>
        /// 从PLC中读取当前配方数据
        /// 当前属性适用于代码触发
        /// </summary>
        [Browsable(false)]
        public bool PLCRead 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException();
        }
        /// <summary>
        /// 从当前配方中下载数据到PLC
        /// 当前属性适用于代码触发
        /// </summary>
        [Browsable(false)]
        public bool PlCWrite 
        { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public Timer Timerconfiguration { get; set; }=new Timer() { Interval=1000, Enabled=true };
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
        #endregion

        public DARecipe()
        {
            InitializeComponent();
        }

        public event EventHandler Modification;

        public void Modifications_Eeve(object send, EventArgs e)
        {
            this.Modification -= new EventHandler(Modifications_Eeve);

        }
    }

}
