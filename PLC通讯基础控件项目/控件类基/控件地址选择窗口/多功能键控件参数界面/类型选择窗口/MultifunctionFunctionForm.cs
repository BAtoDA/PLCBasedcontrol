using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLC多功能控件实现类;
using Sunny.UI;

namespace PLC通讯基础控件项目.控件类基.控件地址选择窗口.多功能键控件参数界面.类型选择窗口
{
    public partial class MultifunctionFunctionForm : UIForm
    {
        PLCmMltifunctionFunctionBase pLCmMltifunction;
        public bool Save = false;
        public MultifunctionFunctionForm(PLCmMltifunctionFunctionBase  pLCmMltifunction)
        {
            InitializeComponent();
            this.pLCmMltifunction = pLCmMltifunction;
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            //从命名空间中加载窗口模板
            Regex r = new Regex(pLCmMltifunction.FormPath ?? "PLC通讯基础控件项目.模板与控制界面");

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
            this.uiComboBox1.Items.Clear();
            foreach (var i in TypeData1)
            {
                if (r.Match(i.FullName).Success)
                {
                    this.uiComboBox1.Items.Add(i.Name);
                }
            }
            if (this.uiComboBox1.Items.Count > 0)
                this.uiComboBox1.SelectedIndex = 0;

            this.uiTextBox1.Text = pLCmMltifunction.FormPath;
            //显示之前选中的参数
            this.uiComboBox1.Text = pLCmMltifunction.FormName;

        }
        /// <summary>
        /// 用户点击保存参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton3_Click(object sender, EventArgs e)
        {
            //保存参数
            Save = true;
            pLCmMltifunction.FormPath = this.uiTextBox1.Text ?? "PLC通讯基础控件项目.模板与控制界面";
            pLCmMltifunction.FormName = this.uiComboBox1.Text ?? "主页面";

            this.Close();
        }
        /// <summary>
        /// 用户点击取消参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton2_Click(object sender, EventArgs e)
        {
            Save = false;
            this.Close();
        }

        /// <summary>
        /// 取消键盘事件
        /// </summary>
        /// <param name="send"></param>
        /// <param name="e"></param>
        public virtual void KeyPress(object send, KeyPressEventArgs e) => e.Handled = true;
    }
}
