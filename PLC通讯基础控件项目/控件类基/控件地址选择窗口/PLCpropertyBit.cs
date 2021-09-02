using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PLC通讯基础控件项目.控件类基.控件数据结构;
using Sunny;
namespace PLC通讯基础控件项目.控件类基.控件地址选择窗口
{
    public partial class PLCpropertyBit : Sunny.UI.UIForm
    {
        public PLCpropertyBit()
        {
            InitializeComponent();
        }

        private void PLCproperty_Load(object sender, EventArgs e)
        {
            PLCpropertyClass pLCpropertyClass = new PLCpropertyClass(uiCheckBox11, uiCheckBox10, uiCheckBox12, uiGroupBox11, uiComboBox10
                , uiComboBox11, uiTextBox12, uiCheckBox13, uiGroupBox13, uiComboBox13, uiComboBox14, uiTextBox15, uiCheckBox14, uiGroupBox14
                , uiComboBox16);
        }
    }
}
