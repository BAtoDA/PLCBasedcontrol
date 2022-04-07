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
using PLC通讯基础控件项目.控件类基.控件地址选择窗口.设备报警历史导出界面.导出表格类;

namespace 控件测试项目
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //声明一个变量用于保存按钮状态
        static bool State = false;
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            //----------测试代码----------

            //openFileDialog1.InitialDirectory = "c:\\";
            //openFileDialog1.Filter = "Excel Files (*.xlsx)|*.xlsx|Excel Files (*.xls)|*.xls";
            //openFileDialog1.FilterIndex = 2;
            //openFileDialog1.RestoreDirectory = true;

            //openFileDialog1.ShowDialog();

          //  new  PLCErrExportData().ExportImportData();
        }
        Random Rand= new Random();
        private void PLCtimer_Tick(object sender, EventArgs e)
        {
        }

        private   void uiButton1_Click(object sender, EventArgs e)
        {

            dynamic d = 55;
            PLC通讯基础控件项目.宏脚本.脚本函数类.PLC.SetPLCD("HMI", "LW", "0", ref d);



        }
    }
}
