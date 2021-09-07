using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PLC通讯基础控件项目.PLC参数设置控件;
using PLC通讯基础控件项目.控件类基.控件数据结构;
using Sunny.UI;
using System.Net;
namespace PLC通讯基础控件项目.自定义窗口设计器
{
    public partial class DesignerAddForm : UIForm
    {
        PLCPreferences preferences;
        public DesignerAddForm(PLCPreferences pLCPreferences)
        {
            InitializeComponent();
            this.preferences = pLCPreferences;
        }

        private void DesignerAddForm_Load(object sender, EventArgs e)
        {
            foreach (var i in Enum.GetNames(typeof(PLC)))
                this.uiComboboxEx1.Items.Add(i);
  
            this.uiTextBox3.Text = this.preferences.Sendovertime.ToString();
            this.uiTextBox4.Text = this.preferences.Receptionovertime.ToString();
            this.uiComboboxEx1.Text = this.preferences.PLCDevice.ToString();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            this.preferences.PLCDevice = Enum.Parse(typeof(PLC), this.uiComboBox1.Text) != null ? (PLC)Enum.Parse(typeof(PLC), this.uiComboBox1.Text) : throw new Exception("选择PLC错误");
            this.preferences.Sendovertime = Convert.ToInt32(this.uiTextBox3.Text) > 999 ? Convert.ToInt32(this.uiTextBox3.Text) : 1000;
            this.preferences.Receptionovertime = Convert.ToInt32(this.uiTextBox4.Text) > 999 ? Convert.ToInt32(this.uiTextBox4.Text) : 1000;
          
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
