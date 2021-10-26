using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sunny.UI;
using System.Reflection;
using System.Text.RegularExpressions;

namespace PLC通讯基础控件项目.基础控件.底层PLC状态监控控件.功能键参数设置窗口
{
    public partial class FunctionForm :UIForm
    {
        public string Formpthan;
        public string FormName;
        public bool Save;
        public FunctionForm(string Formpthan,string FormName)
        {
            InitializeComponent();
            this.Formpthan = Formpthan;
            this.FormName = FormName;
        }

        private void FunctionForm_Load(object sender, EventArgs e)
        {
            //从命名空间中加载窗口模板
            Regex r = new Regex(Formpthan ?? "PLC通讯基础控件项目.模板与控制界面");

            var TypeData = Assembly.GetEntryAssembly().GetTypes();
            this.uiComboBox1.Items.Clear();
            foreach (var i in TypeData)
            {
                if (r.Match(i.FullName).Success)
                {
                    this.uiComboBox1.Items.Add(i.Name);
                }
            }
            if (this.uiComboBox1.Items.Count > 0)
                this.uiComboBox1.SelectedIndex = 0;

            var TypeData1 = Assembly.GetExecutingAssembly().GetTypes();
            //this.uiComboBox1.Items.Clear();
            foreach (var i in TypeData1)
            {
                if (r.Match(i.FullName).Success)
                {
                    this.uiComboBox1.Items.Add(i.Name);
                }
            }
            if (this.uiComboBox1.Items.Count > 0)
                this.uiComboBox1.SelectedIndex = 0;

            this.uiTextBox1.Text = Formpthan;
            //显示之前选中的参数
            this.uiComboBox1.Text = FormName;

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            //保存参数
            Save = true;
            Formpthan = this.uiTextBox1.Text?? "PLC通讯基础控件项目.模板与控制界面";
            FormName = this.uiComboBox1.Text??"主页面";

            this.Close();
        }

        private void uiComboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = true;
        }
    }
}
