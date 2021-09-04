//**********************************************************************
//
// 文件名称(File Name)：
// 功能描述(Description)：
// 作者(Author)：DAtoTA
// 日期(Create Date)： 2021/8/29 11:35:30
//
//**********************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using PLC通讯基础控件项目.控件类基.PLC基础接口;
using PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类;
using PLC通讯基础控件项目.控件类基.控件地址选择窗口;
using PLC通讯基础控件项目.控件类基.控件数据结构;

namespace PLC通讯基础控件项目
{
    [ToolboxItem(true)]
    [Browsable(true)]

    class Class1 : Button, PLCBitClassBase, PLCBitproperty, ICloneable
    {
        [Browsable(false)]
        public event EventHandler Modification;
        [Browsable(false)]
        [Description("是否启用PLC功能"), Category("PLC类型")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PLCBitselectRealize pLCBitselectRealize
        {
            get => pLCBitselects1;
            set => pLCBitselects1 = value;
        }
        private PLCBitselectRealize pLCBitselects1 { get; set; } = new PLCBitselectRealize();
        [Description("选择PLC类型\r\n默认三菱PLC"), Category("PLC类型")]
        [Browsable(true)]
        public PLCSet APLC
        {
            get => PLCs1;
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
        private PLCSet PLCs1 = 0;
        [Description("是否启用PLC功能"), Category("PLC类型")]
        public bool PLC_Enable
        {
            get => plc_Enable;
            set => plc_Enable = value;
        }
        private bool plc_Enable = false;
        [Browsable(false)]
        public Color backgroundColor_0 { get; set; }
        [Browsable(false)]
        public Color TextColor_0 { get; set; }
        [Browsable(false)]
        public string TextContent_0 { get; set; }
        [Browsable(false)]
        public Color backgroundColor_1 { get; set; }
        [Browsable(false)]
        public Color TextColor_1 { get; set; }
        [Browsable(false)]
        public string TextContent_1 { get; set; }
        [Browsable(false)]
        public System.Threading.Timer PLCTimer { get; set; }

        public void Modifications_Eeve(object send, EventArgs e)
        {
            var Copy = this.pLCBitselectRealize.GetType().GetProperties();
            PLCBitselectRealize bitselectRealize = new PLCBitselectRealize();
            var CopyTo = bitselectRealize.GetType().GetProperties();
            for(int i=0;i<Copy.Length;i++)
            {
                if (Copy[i].Name == CopyTo[i].Name)
                    CopyTo[i] = Copy[i];
            }
            PLCpropertyBit pLCpropertyBit = new PLCpropertyBit(this.pLCBitselectRealize) ;
            pLCpropertyBit.StartPosition = FormStartPosition.CenterParent;
            pLCpropertyBit.ShowDialog();
            if(!pLCpropertyBit.Save)
            {
                this.pLCBitselectRealize = bitselectRealize;
            }
        }

        public object Clone()
        {
            return this;
        }
    }
}
