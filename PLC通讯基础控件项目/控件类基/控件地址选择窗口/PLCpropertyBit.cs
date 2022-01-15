using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;
using PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类;
using PLC通讯基础控件项目.控件类基.控件数据结构;
using Sunny;
namespace PLC通讯基础控件项目.控件类基.控件地址选择窗口
{
    public partial class PLCpropertyBit : Sunny.UI.UIForm
    {
        /// <summary>
        /// 传入的控件参数
        /// </summary>
        private PLCBitselectRealize PlcBitselect;
        /// <summary>
        /// 标识是否保存数据
        /// </summary>
        public bool Save;
        public PLCpropertyBit(PLCBitselectRealize ControlPlcBit)
        {
            InitializeComponent();
            PlcBitselect = ControlPlcBit;
            this.BringToFront();
            this.TopMost = true;
        }

        private async void PLCproperty_Load(object sender, EventArgs e)
        {
            //填充PLC选型页面
            new PLCpropertyClass(uiTextBox10, uiCheckBox11, uiCheckBox10, uiCheckBox12, uiGroupBox11, uiComboBox10
                , uiComboBox11, uiTextBox12, uiCheckBox13, uiGroupBox13, uiComboBox13, uiComboBox14, uiTextBox15, uiCheckBox14, uiGroupBox14
                , uiComboBox16,PlcBitselect,this.uiButton1);
            //填充安全页面
            new PLCpropertysafety(uiComboBox20, uiCheckBox20, uiComboBox21, uiComboBox22, uiComboBox23, uiTextBox20, uiComboBox24
                , uiComboBox25, uiComboBox26,new Sunny.UI.UIGroupBox[] { uiGroupBox21, uiGroupBox22, uiGroupBox23 },new Sunny.UI.UICheckBox[] { uiCheckBox21 , uiCheckBox22},
                this.uiCheckBox23,this.uiButton1,PlcBitselect);
            //填充处理文字选择页面
            new PLCpropertyText(uiComboBox30, uiButton30, uiButton31, uiComboBox31, uiComboBox32, uiComboBox33, uiComboBox34, uiRichTextBox30
                , uiColorPicker30, uiColorPicker31, uiCheckBox30, uiCheckBox31, PlcBitselect,uiButton1);
            //加载宏指令窗口页面
          await new PLCmacrosClass(uiTextBox1, uiTextBox2, uiRichTextBox1, this.uiComboboxEx1, PlcBitselect)
                   .MacroLoad(uiTextBox1, uiTextBox2, uiRichTextBox1, this.uiComboboxEx1, this.uiComboboxEx2, uiButton1, PlcBitselect);
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            Save = false;
            this.Close();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            Save = true;
            this.Close();
        }
    }
}
