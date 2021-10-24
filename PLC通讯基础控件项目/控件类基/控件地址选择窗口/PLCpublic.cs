//**********************************************************************
//
// 文件名称(File Name)：
// 功能描述(Description)：
// 作者(Author)：DAtoTA
// 日期(Create Date)： 2021/9/2 22:44:53
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
    /// PLC控件选择页面公用类
    /// </summary>
    public class PLCpublic
    {
        /// <summary>
        /// 读取指定名称PLC对应Bit类型的枚举值
        /// </summary>
        /// <param name="comboBox">需要填充下拉菜单</param>
        /// <param name="EnumName">对应PLC名称</param>
        public virtual void GetPLCBitName(UIComboBox comboBox, string EnumName)
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
        /// 读取指定名称PLC对应Bit类型的枚举值
        /// </summary>
        /// <param name="comboBox">需要填充下拉菜单</param>
        /// <param name="EnumName">对应PLC名称</param>
        public virtual void GetPLCDName(UIComboBox comboBox, string EnumName)
        {
            try
            {
                var EnumType = Assembly.GetExecutingAssembly().GetType("PLC通讯基础控件项目.控件类基.控件数据结构." + EnumName + "_D");
                Enum.GetNames(EnumType).ForEach(Reuq =>
                {
                    comboBox.Items.Add(Reuq);
                });
                comboBox.SelectedIndex = 0;
            }
            catch { }
        }
        /// <summary>
        /// 读取指定名称PLC对应Bit类型的枚举值
        /// </summary>
        /// <param name="comboBox">需要填充下拉菜单</param>
        /// <param name="EnumName">对应PLC名称</param>
        public virtual void GetPLCBitName(UIComboboxEx comboBox, string EnumName)
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
        /// 读取指定名称PLC对应Bit类型的枚举值
        /// </summary>
        /// <param name="comboBox">需要填充下拉菜单</param>
        /// <param name="EnumName">对应PLC名称</param>
        public virtual void GetPLCDName(UIComboboxEx comboBox, string EnumName)
        {
            try
            {
                var EnumType = Assembly.GetExecutingAssembly().GetType("PLC通讯基础控件项目.控件类基.控件数据结构." + EnumName + "_D");
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
        public virtual void GetPLCEnumName<T>(UIComboBox comboBox) where T : Enum
        {
            comboBox.Items.Clear();
            Enum.GetNames(typeof(T)).ForEach(Reuq =>
            {
                comboBox.Items.Add(Reuq);
            });
            comboBox.SelectedIndex = 0;
        }
        /// <summary>
        /// 读取指定枚举名称并且填充到下拉菜单中
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="comboBox"></param>
        public virtual void GetPLCEnumName<T>(UIComboboxEx comboBox) where T : Enum
        {
            comboBox.Items.Clear();
            Enum.GetNames(typeof(T)).ForEach(Reuq =>
            {
                comboBox.Items.Add(Reuq);
            });
            comboBox.SelectedIndex = 0;
        }
        /// <summary>
        /// 根据标志位索引指定PLC报警条件
        /// </summary>
        /// <param name="condition"></param>
        /// <param name="comboBox"></param>
        public virtual void GetPLCErrBase(bool condition, UIComboboxEx comboBox)
        {
            comboBox.Items.Clear();
            if (condition)
            {
                PLCErrBase.condition_Bit.ForEach(s1 => 
                {
                    comboBox.Items.Add(s1);
                });
            }
            else
            {
                PLCErrBase.condition_word.ForEach(s1 =>
                {
                    comboBox.Items.Add(s1);
                });
            }
            comboBox.SelectedIndex = 0;
        }
        /// <summary>
        /// 取消键盘事件
        /// </summary>
        /// <param name="send"></param>
        /// <param name="e"></param>
        public virtual void  KeyPress(object send, KeyPressEventArgs e) => e.Handled = true;
        /// <summary>
        /// 加载字体
        /// </summary>
        /// <param name="comboBox"></param>
        public virtual void GetFontSize(UIComboBox comboBox)
        {
            for (int i = 1; i < 50; i++)
                comboBox.Items.Add(i);
            comboBox.SelectedIndex = 12;
        }
        public Form GetContrForm(dynamic OopContr)
        {
            //递归查找顶级窗口Form
            object Oop = OopContr;
            while (true)
            {
                if ((((dynamic)Oop).Parent as Form) != null)
                {
                    return (Form)((dynamic)Oop).Parent;

                }
                else
                    Oop = ((dynamic)Oop).Parent;
            }
        }
    }
}
