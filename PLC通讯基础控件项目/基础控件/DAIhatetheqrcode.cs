using PLC通讯基础控件项目.控件类基.PLC基础接口;
using PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLC二维码控件实现类;
using PLC通讯基础控件项目.控件类基.控件地址选择窗口.二维码控件参数界面;
using PLC通讯基础控件项目.控件类基.控件数据结构;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace PLC通讯基础控件项目.基础控件
{
    public partial class DAIhatetheqrcode : PictureBox, PLCQRcodeBaseRealize
    {
        PLCQRCodecreation pLCQRCodecreation;
        public DAIhatetheqrcode()
        {
            this.BackgroundImageLayout = ImageLayout.Stretch;//显示方式铺满
            //判断用户选择显示的类型
            if (this.pLCQRcodeRealize.Select != true)
                this.BackgroundImage = new IhatetheqrcodeCreate().Generate1("123456789", this.Size.Width, this.Size.Height);//加载二维码
            else
                this.BackgroundImage = new IhatetheqrcodeCreate().Generate2("123456789", this.Size.Width, this.Size.Height);//加载条形码
            Timerconfiguration.Tick += ((send, e) =>
              {
                  Timerconfiguration.Stop();
                  //处理PLC通讯部分
                  if (!this.PLC_Enable || this.IsDisposed || this.Created == false || DesignMode) return;//用户不开启PLC功能
                  else
                      pLCQRCodecreation = new PLCQRCodecreation(this);

              });
        }
    }
    /// <summary>
    /// 实现从PLC侧读取自定类型数据 产生二维码或者条形码
    /// </summary>
    [ToolboxItem(true)]
    [Browsable(true)]
    public partial class DAIhatetheqrcode : PictureBox, PLCQRcodeBaseRealize
    {
        /// <summary>
        /// 扫描完成进行下一条数据读取
        /// </summary>
        [Browsable(false)]
        public bool Command 
        { 
            set
            {
                if (pLCQRCodecreation != null)
                {
                    GetPLC();
                    async void GetPLC()
                    {
                        await pLCQRCodecreation.PLCWrite(this.pLCQRcodeRealize.WritePLC, this.pLCQRcodeRealize.WriteFunction, this.pLCQRcodeRealize.WriteAddress, true);
                        await pLCQRCodecreation.PLCrefresh();
                    }
                }
            }
        }
        [Browsable(false)]
        [Description("PLC保存参数"), Category("PLC类型")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PLCQRcodeRealize pLCQRcodeRealize
        {
            get => pLCQRcodeRealizeq;
            set => pLCQRcodeRealizeq = value;
        }
        /// <summary>
        /// 私有保存参数 自动添加
        /// </summary>
        private PLCQRcodeRealize pLCQRcodeRealizeq { get; set; } = new PLCQRcodeRealize();
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
        public System.Windows.Forms.Timer Timerconfiguration { get; set; } = new System.Windows.Forms.Timer() { Enabled = true, Interval = 100 };

        public event EventHandler Modification;

        public void Modifications_Eeve(object send, EventArgs e)
        {
            this.Modification -= new EventHandler(Modifications_Eeve);
            new PLCQRcodeForm(this, this).ShowDialog();
        }


    }
}
