using PLC通讯基础控件项目.控件类基.控件数据结构;
using PLC通讯库.PLC通讯设备类型表;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using PLC通讯库.通讯基础接口;

namespace PLC通讯基础控件项目.基础控件.底层PLC状态监控控件
{
    [ToolboxItem(true)]
    public partial class PLCStatusView : UserControl
    {
        #region 属性参数
        [Browsable(true)]
        [Description("需要设置的PLC"), Category("PLC类型")]
        public PLC APLC
        {
            get => PLCsz;
            set
            {
                PLCsz = value;
            }

        }
        /// <summary>
        /// 私有设置PLC参数
        /// </summary>
        private PLC PLCsz = 0;
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
        public PLCStatusView()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.pictureBox1.Image =this.imageList1.Images[0];
            if (this.DesignMode) return;
            //读取PLC状态
            GetPLC();
        }
        private void GetPLC()
        {
            if(PLC_Enable)
            {
                var PLCoop = IPLCsurface.PLCDictionary.Where(P => P.Key == APLC.ToString()).FirstOrDefault();
                if (PLCoop.Value != null)
                {
                    this.pictureBox1.Image = ((IPLC_interface)PLCoop.Value).PLC_ready ? this.imageList1.Images[1] : this.imageList1.Images[0];
                    this.uiLabel1.Text = ((IPLC_interface)PLCoop.Value).PLC_ready ? "在线：" : "离线：";
                    this.uiLedBulb1.On = ((IPLC_interface)PLCoop.Value).PLC_ready;
                }
                else
                {
                    this.pictureBox1.Image = this.imageList1.Images[0];
                    this.uiLabel1.Text = "未添加";
                    this.uiLedBulb1.On = false;
                }
            }
            else
            {
                this.pictureBox1.Image = this.imageList1.Images[0];
                this.uiLabel1.Text = "未启用";
                this.uiLedBulb1.On = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //读取PLC状态
            GetPLC();
        }
    }
}
