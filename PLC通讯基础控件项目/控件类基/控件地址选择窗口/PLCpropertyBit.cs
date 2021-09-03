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
            //填充PLC选型页面
            PLCpropertyClass pLCpropertyClass = new PLCpropertyClass(uiCheckBox11, uiCheckBox10, uiCheckBox12, uiGroupBox11, uiComboBox10
                , uiComboBox11, uiTextBox12, uiCheckBox13, uiGroupBox13, uiComboBox13, uiComboBox14, uiTextBox15, uiCheckBox14, uiGroupBox14
                , uiComboBox16);
            //填充安全页面
            PLCpropertysafety pLCpropertysafety = new PLCpropertysafety(uiComboBox20, uiCheckBox20, uiComboBox21, uiComboBox22, uiComboBox23, uiTextBox20, uiComboBox24
                , uiComboBox25, uiComboBox26,new Sunny.UI.UIGroupBox[] { uiGroupBox21, uiGroupBox22, uiGroupBox23 });
            //填充处理文字选择页面
            PLCpropertyText pLCpropertyText = new PLCpropertyText(uiComboBox30, uiButton30, uiButton31, uiComboBox31, uiComboBox32, uiComboBox33, uiComboBox34, uiRichTextBox30
                , uiColorPicker30, uiColorPicker31, uiCheckBox30, uiCheckBox31, new PLCselectTextBase());
        }
    }
}
