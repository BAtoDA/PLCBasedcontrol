﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;
using Sunny.UI;
using PLC通讯基础控件项目.控件类基.PLC基础接口;

namespace PLC通讯基础控件项目.控件类基.控件文本键盘
{
    public sealed partial class keyboard :Sunny.UI.UIForm
    {
#pragma warning disable CS0108 // 成员隐藏继承的成员；缺少关键字 new
        string Name="";//用户输入的文本
#pragma warning restore CS0108 // 成员隐藏继承的成员；缺少关键字 new
        PLCDBase textBox;//获取该控件的参数
        public string O_Text { get => this.skinTextBox3.Text; }//文本
        public keyboard(string Name, PLCDBase textBox) 
        {
            InitializeComponent();
            this.Name = Name;//获取控件本身值
            this.textBox = textBox;// 获取该控件的参数            
        }
        private void keyboard_Shown(object sender, EventArgs e)//加载控件状态
        {
            this.skinTextBox3.Text = this.Name.Trim();//写入上次值
            var skinButton_list = (from  Control pi in this.Controls where pi is UIButton select pi).ToList();//获取窗口控件集合
            foreach ( UIButton textBox in skinButton_list) textBox.Click += Button_KeyPress;//注册事件
            if (textBox.ShowFormat.ToString() == "Float_32_Bit") this.skinButton4.Enabled = true;//允许输入小数点
            if (textBox.ShowFormat.ToString() == "Unsigned_16_Bit" || textBox.ShowFormat.ToString() == "Unsigned_16_Bit") this.skinButton9.Enabled = false;//不允许输入符号
            string[] data= Constraints_data(textBox.ShowFormat.ToString());//获取最大值-最小值
            this.skinTextBox1.Text = textBox.NumericalMax.ToString();//填充最大值
            this.skinTextBox2.Text = textBox.NumericalMin.ToString();//填充最小值
        }
        private void Button_KeyPress(object sender, EventArgs e)//获取用户输入
        {
            UIButton button =((UIButton)sender);//获取输入控件对象
            if ((this.skinTextBox3.Text.IndexOf('.') > 0) & (button.Text == ".")) return;//如果已有小数点返回方法不录入字符
            if(this.skinTextBox3.Text.Length>=1&button.Text=="-") return;//如果已有符号返回方法不录入字符
            if (button.Text == "Clr") { if (this.skinTextBox3.Text.Trim() == "") return; this.skinTextBox3.Text = backspace(this.skinTextBox3.Text); }//实现移除最后一个字符
            if (button.Text == "Esc") { this.skinTextBox3.Text = Name; this.Close(); }//退回修改前数据
            if (button.Text == "Enter") 
            {
                if(textBox.ShowFormat.ToString() == "Float_32_Bit") this.skinTextBox3.Text = complement(this.skinTextBox3.Text);//自动补码小数点
                this.Close();//关闭窗口
            }
            if ((button.Text != "Clr") & (button.Text != "Esc") & (button.Text != "Bs") & (button.Text != "Del") & (button.Text != "<") & (button.Text != ">") & (button.Text != "Enter"))//判断是否功能键不录入
            {
                if ((textBox.ShowFormat.ToString() == "Binary_16_Bit" || textBox.ShowFormat.ToString() == "Binary_32_Bit"))
                {
                    if((Convert.ToInt32(button.Text) > 1))
                      return;//返回方法不录入字体
                }
                this.skinTextBox3.Text=Button_text_add(sender);//添加字符
            }
            if (button.Text == "Bs" || button.Text == "Del") this.skinTextBox3.Text = "0";//清空字符
            if (this.skinTextBox3.Text.Length > 2) this.skinTextBox3.Text.Trim('0');
        }

        private string Button_text_add(object send)//实现刻录字符
        {
            string data= this.skinTextBox3.Text + ((UIButton)send).Text.Trim();//在最后一个添加字符
            if(numerical_KeyPress_import(data, textBox.ShowFormat.ToString()))//判断数据是否溢出
            {
                return backspace(data);//移除最后一位 返回数据 
            }
            else
            {
                return data;//返回修改后数据
            }
        }
        private string backspace(string Name)//实现字符串移除最一个字符
        {            
            return Name.Remove(Name.Length - 1, 1); //移除掉
        }
        private string complement(string Name)//实现浮点小数自动补码
        {
            string d = string.Empty;
            try
            {
                return Convert.ToSingle(Name).ToString($"F{textBox.NumericaldigitMin}");
            }
            catch { }
           
            return Name;//返回数据
        }
        /// <方法重写实现获取用户输入的文本-与参数中的格式-判断输入是否正确-控件文本写入与约束>
        private bool numerical_KeyPress_import(string Text, string Name)//获取用户输入的文本-与参数中的格式-判断输入是否正确
        {
            bool Handled = false;//初始化键盘输入状态、
            long data;
            int constraint_16_0 = Convert.ToInt32(skinTextBox2.Text), constraint_16_1 = Convert.ToInt32(skinTextBox1.Text);//short类型最大约束-与int 约束
            if ((textBox.ShowFormat.ToString() != "Float_32_Bit") & (Text.IndexOf('.') > 0))//如果不浮点小数 就移除小数点
            {
                int index = Text.IndexOf('.');
                Text = Text.Remove(index, 1);
                Text.Trim('.');
            }
            if ((textBox.ShowFormat.ToString() == "Unsigned_16_Bit" || textBox.ShowFormat.ToString() == "Unsigned_32_Bit") & (Text.IndexOf('-') > 0)) Text.Trim('-');//如果不是有符号就移除符号
            if (Text.Length < 4) return Handled;//字符数小于一定数量--不做判断
            switch (Name.Trim())//判断数据
            {
                case "BCD_16_Bit":
                    data = Convert.ToInt64(Text??"0");//把数据转换成--int
                    if ((data > 0) & (data > constraint_16_1)) Handled = true;//取消修改
                    if ((data < 0) & (data < constraint_16_0)) Handled = true;//取消修改
                    break;
                case "BCD_32_Bit":
                    data = Convert.ToInt64(Text??"0");//把数据转换成--int
                    if ((data > 0) & (data > constraint_16_1)) Handled = true;//取消修改
                    if ((data < 0) & (data < constraint_16_0)) Handled = true;//取消修改
                    break;
                case "Binary_16_Bit":
                    int data_1 = Convert.ToInt32(Text??"0", 2);//转换成10进制
                    if ((data_1 > 0) & (data_1 > constraint_16_1)) Handled = true;//取消修改
                    if ((data_1 < 0) & (data_1 < constraint_16_0)) Handled = true;//取消修改
                    break;
                    case "Binary_32_Bit":
                    int data_2 = Convert.ToInt32(Text??"0", 2);//转换成10进制
                    if ((data_2 > 0) & (data_2 > constraint_16_1)) Handled = true;//取消修改
                    if ((data_2 < 0) & (data_2 < constraint_16_0)) Handled = true;//取消修改
                    break;
                case "Float_32_Bit":
                    float data_3 = Convert.ToSingle(Text ?? "0");//转换成浮点小数
                    if ((data_3 > 0) & (data_3 > constraint_16_1)) Handled = true;//取消修改
                    if ((data_3 < 0)) Handled = true;//取消修改
                    int Inde = this.skinTextBox3.Text.IndexOf('.');//搜索数据是否有小数点
                    if (Inde < 0) break;
                    int In = this.skinTextBox3.Text.Length  - Inde;
                    Handled =  In> textBox.NumericaldigitMin ? true:false;//取消修改
                    break;
                case "Unsigned_16_Bit":
                    data = Convert.ToInt64(Text ?? "0");//把数据转换成--int
                    if ((data > 0) & (data > constraint_16_1)) Handled = true;//取消修改
                    if ((data < 0)) Handled = true;//取消修改
                    break;
                case "Unsigned_32_Bit":
                    data = Convert.ToInt64(Text ?? "0");//把数据转换成--int
                    if ((data > 0) & (data > constraint_16_1)) Handled = true;//取消修改
                    if ((data < 0)) Handled = true;//取消修改
                    break;
                case "Signed_16_Bit":
                    data = Convert.ToInt64(Text ?? "0");//把数据转换成--int
                    if ((data > 0) & (data > constraint_16_1)) Handled = true;//取消修改
                    if ((data < 0) & (data < constraint_16_0)) Handled = true;//取消修改
                    break;
                case "Signed_32_Bit":
                    data = Convert.ToInt64(Text ?? "0");//把数据转换成--int
                    if ((data > 0) & (data > constraint_16_1)) Handled = true;//取消修改
                    if ((data < 0) & (data < constraint_16_0)) Handled = true;//取消修改
                    break;
            }
            return Handled;//返回数据
        }
        private string[] Constraints_data(string Name)//实现约束最小值--最大值
        {
            string[] data = new string[2];//初始化最大值--最小值
            switch(Name)
            {
                case "BCD_16_Bit":
                case "Signed_16_Bit":
                    //最大值
                    if (textBox.NumericaldigitMax>= 5)
                        data[0] = "32766";//大于限制默认填充最大值
                    else
                        for(int i=0;i< textBox.NumericaldigitMax; i++)//先填充最大值
                        {
                            data[0] += "9";
                        }
                    //最小值
                    data[1] = "-";//先填充符号
                    if(textBox.NumericaldigitMin >= 5)
                        data[1] = "-32766";//大于限制默认填充最大值
                    else
                        for (int i = 0; i < textBox.NumericaldigitMin; i++)//先填充最大值
                        {
                            data[1] += "9";
                        }
                    break;
                case "BCD_32_Bit":
                case "Signed_32_Bit":
                    //最大值
                    if (textBox.NumericaldigitMax >= 10)
                        data[0] = "2147483647";//大于限制默认填充最大值
                    else
                        for (int i = 0; i < textBox.NumericaldigitMax; i++)//先填充最大值
                        {
                            data[0] += "9";
                        }
                    //最小值
                    data[1] = "-";//先填充符号
                    if (textBox.NumericaldigitMin >= 10)
                        data[1] = "-2147483647";//大于限制默认填充最大值
                    else
                        for (int i = 0; i < textBox.NumericaldigitMin; i++)//先填充最大值
                        {
                            data[1] += "9";
                        }
                    break;
                case "Binary_16_Bit":
                    //最大值
                    if (textBox.NumericaldigitMax >= 14)
                        data[0] = Convert.ToString(32766, 2);//大于限制默认填充最大值
                    else
                        for (int i = 0; i < textBox.NumericaldigitMax; i++)//先填充最大值
                        {
                            data[0] += "1";
                        }
                    //最小值
                    data[1] = "0";//二进制最小值必须0                  
                    break;
                case "Binary_32_Bit":
                    //最大值
                    if (textBox.NumericaldigitMax >= 28)
                        data[0] = Convert.ToString(2147483647,2);//大于限制默认填充最大值
                    else
                        for (int i = 0; i < textBox.NumericaldigitMax; i++)//先填充最大值
                        {
                            data[0] += "1";
                        }
                    //最小值
                    data[1] = "0";//二进制最小值必须0   
                    break;
                case "Float_32_Bit":
                    //最大值
                    for (int i = 0; i < textBox.NumericaldigitMax; i++)//先填充最大值
                    {
                        data[0] += "9";//填充数据
                    }
                    //最小值
                    data[1] = "0.";//填充小数点
                    for (int i = 0; i < textBox.NumericaldigitMin; i++)//先填充最大值
                    {
                        data[1] += "0";//填充数据
                    }
                    break;
                case "Unsigned_16_Bit":
                    //最大值
                    if (textBox.NumericaldigitMax >= 5)
                        data[0] = "32766";//大于限制默认填充最大值
                    else
                        for (int i = 0; i < textBox.NumericaldigitMax; i++)//先填充最大值
                        {
                            data[0] += "9";
                        }
                    //最小值
                    data[1] = "0";//无符号必须为0
                    break;
                case "Unsigned_32_Bit":
                    //最大值
                    if (textBox.NumericaldigitMax >= 10)
                        data[0] = "2147483647";//大于限制默认填充最大值
                    else
                        for (int i = 0; i < textBox.NumericaldigitMax; i++)//先填充最大值
                        {
                            data[0] += "9";
                        }
                    //最小值
                    data[1] = "0";//无符号必须为0
                    break;              

            }
            return data;//返回数据
        }       
        ~keyboard()//析构函数
        {
            var skinButton_list = (from Control pi in this.Controls where pi is UIButton select pi).ToList();//获取窗口控件集合
            foreach (UIButton textBox in skinButton_list) textBox.Click -= Button_KeyPress;//移除事件
        }
    }
}
