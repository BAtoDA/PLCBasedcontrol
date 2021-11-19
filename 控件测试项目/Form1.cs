using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PLC通讯基础控件项目.控件类基.PLC基础接口;
using PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类;
using PLC通讯基础控件项目.控件类基.控件地址选择窗口;

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
           // new PLCpropertyBit( new PLCBitselectRealize()).Show();
            var dw = new EventCreateClass();

            foreach(var i in dw.EventName(this.uiButton1))
                this.uiComboBox1.Items.Add(i.Name);
            this.uiComboBox1.SelectedIndex = 22;
            dw.GainHandler(this.uiButton1, this.uiComboBox1.Text);
            dw.ControlEvent += ((sender, e) =>
              {
                  MessageBox.Show(sender.ToString());
              });
        }
    }
}
