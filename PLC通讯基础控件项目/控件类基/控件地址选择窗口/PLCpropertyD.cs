using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLCD控件实现类;

namespace PLC通讯基础控件项目.控件类基.控件地址选择窗口
{
    public partial class PLCpropertyD : Sunny.UI.UIForm
    {
        /// <summary>
        /// 传入的控件参数
        /// </summary>
        private PLCDselectRealize PlcDselect;
        /// <summary>
        /// 标识是否保存数据
        /// </summary>
        public bool Save;
        public PLCpropertyD(PLCDselectRealize PlcDselect)
        {
            InitializeComponent();
            this.PlcDselect = PlcDselect;
        }

        private void uiGroupBox4_Click(object sender, EventArgs e)
        {

        }

        private void PLCpropertyD_Load(object sender, EventArgs e)
        {
            //填充PLC选型页面
            PLCpropertyClass pLCpropertyClass = new PLCpropertyClass(uiTextBox10, uiCheckBox10, uiCheckBox12, uiGroupBox11, uiComboBox10
                , uiComboBox11, uiTextBox12, uiGroupBox13, uiComboBox13, uiComboBox14, uiTextBox15, uiGroupBox14
                , uiCheckBox1, uiGroupBox1, uiCheckBox2, uiCheckBox3, uiComboBox16, uiComboBox17, uiTextBox18, PlcDselect, this.uiButton1);
            //填充键盘样式
            PLCpropertyKey pLCpropertyKey = new PLCpropertyKey(uiCheckBox4, uiComboBox40, uiLabel21, PlcDselect, this.uiButton1);
            //填充资料格式
            PLCpropertyformat pLCpropertyformat = new PLCpropertyformat(uiComboBox50, uiComboBox51, uiDoubleUpDown50, uiDoubleUpDown51, uiTextBox52, uiTextBox53, PlcDselect, this.uiButton1);
            ////填充安全页面
            PLCpropertysafety pLCpropertysafety = new PLCpropertysafety(uiComboBox20, uiCheckBox20, uiComboBox21, uiComboBox22, uiComboBox23, uiTextBox20, uiComboBox24
                , uiComboBox25, uiComboBox26, new Sunny.UI.UIGroupBox[] { uiGroupBox21, uiGroupBox22, uiGroupBox23 }, new Sunny.UI.UICheckBox[] { uiCheckBox21, uiCheckBox22 },
                this.uiCheckBox23, this.uiButton1, PlcDselect);
            ////填充处理文字选择页面
            PLCpropertyText pLCpropertyText = new PLCpropertyText(uiComboBox30, uiButton30, uiButton31, uiComboBox31, uiComboBox32, uiComboBox33, uiComboBox34, uiRichTextBox30
                , uiColorPicker30, uiCheckBox30, uiCheckBox31, PlcDselect, uiButton1);
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            Save = true;
            this.Close();
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            Save = false;
            this.Close();
        }
    }
}
