//**********************************************************************
//
// 文件名称(File Name)：
// 功能描述(Description)：
// 作者(Author)：DAtoTA
// 日期(Create Date)： 2021/8/29 14:11:15
//
//**********************************************************************
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using PLC通讯基础控件项目.控件类基.控件数据结构;
using Sunny.UI;

namespace PLC通讯基础控件项目.控件类基.控件地址选择窗口
{
    /// <summary>
    /// 用于实现PLC属性设置菜单
    /// </summary>
    class PLCpropertyClass
    {
        /// <summary>
        /// Bit位构造函数
        /// </summary>
        /// <param name="Alamp"></param>
        /// <param name="Aswitch"></param>
        /// <param name="readwrite"></param>
        /// <param name="readwriteplc"></param>
        /// <param name="readwritePLCfunction"></param>
        /// <param name="readwriteaddress"></param>
        /// <param name="Out"></param>
        /// <param name="writePelan"></param>
        /// <param name="writeplc"></param>
        /// <param name="writePLCfunction"></param>
        /// <param name="writeaddress"></param>
        /// <param name="loosenOut"></param>
        /// <param name="propertyPelan"></param>
        /// <param name="pattern"></param>
        public PLCpropertyClass(UICheckBox Alamp,UICheckBox Aswitch,UICheckBox readwrite,UIGroupBox readwritepelan, UIComboBox readwriteplc,UIComboBox readwritePLCfunction,
            UITextBox readwriteaddress, UICheckBox Out, UIGroupBox writePelan, UIComboBox writeplc, UIComboBox writePLCfunction,
            UITextBox writeaddress, UICheckBox loosenOut, UIGroupBox propertyPelan,UIComboBox pattern)
        {
            //初始化操作--PLC下拉菜单
            PLCload(readwriteplc,readwritePLCfunction,readwriteaddress,writePelan,writeplc,writePLCfunction, writeaddress);
            //加载属性选项
            Enum.GetNames(typeof(Button_pattern)).ForEach(s =>
            {
                pattern.Items.Add(s);
            });
            pattern.SelectedIndex = 0;
            //处理UI特效部分
            //位状态指示灯特效
            Aswitch.CheckedChanged += ((sendq,s1)=> 
            {
                if (Aswitch.Checked)
                {
                    readwritepelan.Visible = false;
                    writePelan.Visible = false;
                    propertyPelan.Visible = false;
                    Alamp.Checked = false;
                }
            });
            //位状态切换特效
            Alamp.CheckedChanged += ((sendq, s1) =>
            {
                if (Alamp.Checked)
                {
                    readwritepelan.Visible = true;
                    propertyPelan.Visible = true;
                    Aswitch.Checked = false;
                }
            });
            //处理读取写入不同地址
            readwrite.CheckedChanged += ((sendq, s1) =>
             {
                 writePelan.Visible = readwrite.Checked;
             });
            //处理用户选择PLC时改变功能码
            readwriteplc.TextChanged += ((sendq, s1) =>
             {                 
                 readwritePLCfunction.Items.Clear();
                 GetPLCBitName(readwritePLCfunction, readwriteplc.Text);
             });
            writeplc.TextChanged += ((sendq, s1) =>
             {
                writePLCfunction.Items.Clear();
                 GetPLCBitName(writePLCfunction, writeplc.Text);
             });
             //处理键盘
            readwriteplc.KeyPress += KeyPress;
            readwritePLCfunction.KeyPress += KeyPress;
            writeplc.KeyPress += KeyPress;
            writePLCfunction.KeyPress += KeyPress;
            pattern.KeyPress += KeyPress;
            void KeyPress(object send, KeyPressEventArgs e) => e.Handled = true;
        }
        /// <summary>
        /// 读取指定名称PLC对应Bit类型的枚举值
        /// </summary>
        /// <param name="comboBox">需要填充下拉菜单</param>
        /// <param name="EnumName">对应PLC名称</param>
        private void GetPLCBitName(UIComboBox comboBox,string EnumName)
        {
            try
            {
                var EnumType = Assembly.GetExecutingAssembly().GetType("PLC通讯基础控件项目.控件类基.控件数据结构." + EnumName + "_bit");
                Enum.GetNames(EnumType).ForEach(Reuq =>
                {
                    comboBox.Items.Add(Reuq);
                });
                comboBox.SelectedIndex = 0;
            }
            catch { }
        }
        /// <summary>
        /// 读取指定枚举名称并且填充到下拉菜单中
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="comboBox"></param>
        private void GetPLCEnumName<T>(UIComboBox comboBox)where T :Enum
        {
            comboBox.Items.Clear();
            Enum.GetNames(typeof(T)).ForEach(Reuq => 
            {
                comboBox.Items.Add(Reuq);           
            });
            comboBox.SelectedIndex = 0;
        }
        
        /// <summary>
        /// 加载PLC选项
        /// </summary>
        /// <param name="readwriteplc"></param>
        /// <param name="readwritePLCfunction"></param>
        /// <param name="readwriteaddress"></param>
        /// <param name="readwritePelan"></param>
        /// <param name="writeplc"></param>
        /// <param name="writePLCfunction"></param>
        /// <param name="writeaddress"></param>
        private void PLCload(UIComboBox readwriteplc, UIComboBox readwritePLCfunction,
            UITextBox readwriteaddress,UIGroupBox readwritePelan, UIComboBox writeplc, UIComboBox writePLCfunction,
            UITextBox writeaddress)
        {
            readwriteplc.Items.Clear();
            writeplc.Items.Clear();
            Enum.GetNames(typeof(PLC)).ForEach(s => 
            {
                readwriteplc.Items.Add(s);
                writeplc.Items.Add(s);
            });
            readwriteplc.SelectedIndex = 0;
            writeplc.SelectedIndex = 0;
            readwritePLCfunction.Items.Clear();
            writePLCfunction.Items.Clear();
            Enum.GetNames(typeof(Mitsubishi_bit)).ForEach(s =>
            {
                readwritePLCfunction.Items.Add(s);
                writePLCfunction.Items.Add(s);
            });
            readwritePLCfunction.SelectedIndex = 0;
            writePLCfunction.SelectedIndex = 0;
            readwriteaddress.Text = "0";
            writeaddress.Text = "0";
        }

    }
}
