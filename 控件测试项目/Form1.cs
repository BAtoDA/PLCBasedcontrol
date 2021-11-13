using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 控件测试项目
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var 女朋友 = new 女朋友()
            {
                性别 = "女",
                财富 = 9223372036854775807L,
                身材 = "完美"
            };

        }
    }
    class 女朋友
    {
        public Int64 财富 { get; set; }
        public string 身材 { get; set; }
        public string 性别 { get; set; }
    }
}
