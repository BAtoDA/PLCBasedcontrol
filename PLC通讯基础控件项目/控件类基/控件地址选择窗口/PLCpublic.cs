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
using Sunny.UI;

namespace PLC通讯基础控件项目.控件类基.控件地址选择窗口
{
    /// <summary>
    /// PLC控件选择页面公用类
    /// </summary>
    class PLCpublic
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
    }
}
