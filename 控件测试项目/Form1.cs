using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Nancy.Json;
using PLC通讯基础控件项目.宏脚本.接口类基;
using PLC通讯基础控件项目.控件类基.控件地址选择窗口;

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
            //----------测试代码--------------
            Timer PLCtimer = new Timer()
            {
                Interval = 100,
               // Enabled = true
            };
           // PLCtimer.Start();

            //------添加任务------
            PLCtimer.Tick += PLCtimer_Tick;

        }
        Random Rand= new Random();
        private void PLCtimer_Tick(object sender, EventArgs e)
        {
            //处理PLC任务
            var PLCTimer = (dynamic)sender;
            PLCTimer.Stop();
            //产生数据
            this.daUiTextBox1.Text = Rand.Next(0,10000).ToString();
            this.daUiTextBox1.WrietCommand = true;

            //模拟按钮触发

            var da = this.daButton1.ReadCommand;
            this.uiTextBox1.Text=da.ToString();

            //写
            bool Boolean = da==false?true:false;
            this.daButton1.WrietCommand = Boolean;

            //更新柱形图
            this.dAuiBarChart1.ReadCommand = true;

            PLCTimer.Start();
        }

        private   void uiButton1_Click(object sender, EventArgs e)
        {
         




        }
    }
}
