using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using PLC通讯基础控件项目.控件类基.PLC基础接口;
using PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类;
using PLC通讯基础控件项目.控件类基.控件地址选择窗口;
using PLC通讯基础控件项目.控件类基.控件地址选择窗口.配方控件参数设置界面;

namespace 控件测试项目
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            new PLCRecipeForm(this.daRecipe1.PLCRecipeClass).Show();






            // new PLCpropertyBit( new PLCBitselectRealize()).Show();
            var dw = new EventCreateClass();

           


        }

        private void uiRichTextBox1_TextChanged(object sender, EventArgs e)
        {
         

        }
        bool w1e=false;
        private void uiRichTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                w1e = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new 控件测试项目.dddddd.Form1().Show();
            this.Hide();
        }

        private void daUiButton4_Click(object sender, EventArgs e)
        {

        }
    }
}
