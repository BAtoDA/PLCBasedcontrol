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
using PLC通讯基础控件项目.控件类基.PLC基础接口;
using PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类;

namespace PLC通讯基础控件项目
{
    [ToolboxItem(true)]
    [Browsable(true)]
    class Class1 : Button, PLCBitClassBase, PLCBitproperty
    {
        [Description("选择PLC类型\r\n默认三菱PLC"), Category("PLC类型")]
        [Browsable(false)]
        public PLCBitselectRealize pLCBitselectRealize 
        {
            get;set;
        }
        public int PLCs 
        {
            get => PLCs1;
            set
            {
                this.Modification += new EventHandler(Modifications_Eeve);
                this.Modification(this, new EventArgs());
                this.Modification -= new EventHandler(Modifications_Eeve);
            }

        }
        private int PLCs1 = 0;
        [Browsable(false)]
        public Color backgroundColor_0 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [Browsable(false)]
        public Color TextColor_0 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [Browsable(false)]
        public string TextContent_0 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [Browsable(false)]
        public Color backgroundColor_1 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [Browsable(false)]
        public Color TextColor_1 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [Browsable(false)]
        public string TextContent_1 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [Browsable(false)]
        public System.Threading.Timer PLCTimer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [Browsable(false)]
        public event EventHandler Modification;

        public void Modifications_Eeve(object send, EventArgs e)
        {
            MessageBox.Show("运行了");
        }
    }
}
