using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PLC通讯基础控件项目.宏脚本;
using PLC通讯基础控件项目.宏脚本.接口类基;

namespace 控件测试项目
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           

        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            new  MacroinstructionForm(new MacroinstructionClass()).Show();
        }
    }
    class 女朋友
    {
        public Int64 财富 { get; set; }
        public string 身材 { get; set; }
        public string 性别 { get; set; }
    }
}
