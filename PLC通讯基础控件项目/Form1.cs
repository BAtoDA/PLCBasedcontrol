using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Linq;

namespace PLC通讯基础控件项目
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Regex r = new Regex("PLC通讯基础控件项目.控件类基.控件文本键盘"); // 定义一个Regex对象实例         
            var TypeData = Assembly.GetExecutingAssembly().GetTypes() ;
            List<Type> types = new List<Type>();
            foreach(var i in TypeData)
            {
                if (r.Match(i.FullName).Success)
                {
                    types.Add(i);
                }
            }
            var DDW = types.Distinct();
        }
    }
}
