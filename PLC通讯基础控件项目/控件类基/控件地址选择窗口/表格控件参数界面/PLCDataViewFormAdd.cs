using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using PLC通讯基础控件项目.控件类基.控件数据结构;
using PLC通讯库.通讯枚举;
using Sunny.UI;


namespace PLC通讯基础控件项目.控件类基.控件地址选择窗口.表格控件参数界面
{
    public partial class PLCDataViewFormAdd : UIForm
    {
        #region 属性 字段
        public string PLCs, PLCName, PLCaddress, PLCType, DataViweName, SQLType;
        public bool Save { get; set; } = false;
        #endregion
        public PLCDataViewFormAdd(string PLCs,string PLCName,string PLCaddress,string PLCType,string DataViweName,string SQLType)
        {
            InitializeComponent();
            this.PLCs = PLCs;
            this.PLCName = PLCName;
            this.PLCaddress = PLCaddress;
            this.PLCType = PLCType;
            this.DataViweName = DataViweName;
            this.SQLType = SQLType;
            PLCLoad();
        }

        private void PLCLoad()
        {
            object PLCOop;
            GetEnumName(typeof(PLC), this.uiComboBox2);
            if (Enum.TryParse(typeof(PLC), this.PLCs, out PLCOop))
            {
                this.uiComboBox2.Text = PLCOop.ToString();
                var EnumType = Assembly.GetExecutingAssembly().GetType("PLC通讯基础控件项目.控件类基.控件数据结构." + PLCOop + "_D");
                GetEnumName(EnumType==null?typeof(Mitsubishi_D): EnumType, this.uiComboBox1);
                uiTextBox3.Text = "0";
                this.uiComboBox1.Text = PLCName == null ? "D" : PLCName;
            }
            //注册对应事件
            this.uiComboBox2.SelectedIndexChanged+=((send, e) =>
            {
                var EnumType = Assembly.GetExecutingAssembly().GetType("PLC通讯基础控件项目.控件类基.控件数据结构." + this.uiComboBox2.Text + "_D");
                GetEnumName(EnumType == null ? typeof(Mitsubishi_D) : EnumType, this.uiComboBox1);
                uiTextBox3.Text = PLCaddress==null? "0": PLCaddress;
                //this.uiComboBox1.Text = PLCName == null ? "D" : PLCName;


            });
            this.uiComboBox1.Text = PLCName == null ? "D" : PLCName;
            this.uiTextBox3.KeyPress += ((send, e) =>
            {
                //不允许输入特殊字符
                if (e.KeyChar != '\b')//这是允许输入退格键  
                {
                    if (e.KeyChar == '.') return;
                    if ((e.KeyChar < '0') || (e.KeyChar > 'F') & (e.KeyChar != '.'))
                    {
                        e.Handled = true;
                    }
                }
            });
            GetEnumName(typeof(numerical_format), this.uiComboBox3);
            this.uiComboBox3.Text = PLCType == "" | PLCType == null ? numerical_format.Signed_32_Bit.ToString() : PLCType;
            uiTextBox3.Text = PLCaddress == null ? "0" : PLCaddress;
            this.uiTextBox1.Text = DataViweName == "" | DataViweName == null ? "Name1" : DataViweName;

        }
        private void GetEnumName(Type type,UIComboBox comboBox)
        {
            comboBox.Items.Clear();
            foreach (var i in Enum.GetNames(type))
                comboBox.Items.Add(i);
            comboBox.SelectedIndex = 0;
        }
        //保存数据
        private void uiButton1_Click(object sender, EventArgs e)
        {
            Save = true;
            PLCName= this.uiComboBox1.Text;
            PLCs = this.uiComboBox2.Text;
            PLCaddress = this.uiTextBox3.Text;
            PLCType = this.uiComboBox3.Text;
            DataViweName = this.uiTextBox1.Text==""| this.uiTextBox1.Text==null?"Name1": this.uiTextBox1.Text;
            SQLType = this.uiComboBox4.Text;

            this.Close();
        }
        //取消数据
        private void uiButton2_Click(object sender, EventArgs e)
        {
            Save = false;
            this.Close();
        }
    }
}
