using Nancy.Json;
using PLC通讯基础控件项目.基础控件;
using PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLC多功能控件实现类;
using PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLC报警显示控件实现类;
using PLC通讯基础控件项目.控件类基.PLC基础接口.报警表_TO_Json;
using PLC通讯基础控件项目.控件类基.控件地址选择窗口.多功能键控件参数界面;
using PLC通讯基础控件项目.控件类基.控件地址选择窗口.设备报警控件参数界面;
using PLC通讯基础控件项目.模板与控制界面.窗口底层;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 控件测试项目
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void daUiTextBox1_Click(object sender, EventArgs e)
        {


        }
        protected  override void OnShown(EventArgs e)
        {
            var DD = DateTime.Now;
            base.OnShown(e);
            PLCMultifunctionBitBase pLCMultifunctionClassBase = new PLCMultifunctionClassBase();
            new PLCMultifunctionForm(new DAMultifunction()).ShowDialog();

        }
    }
}
