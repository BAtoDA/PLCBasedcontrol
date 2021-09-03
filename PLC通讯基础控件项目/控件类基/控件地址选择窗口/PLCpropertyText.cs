//**********************************************************************
//
// 文件名称(File Name)：
// 功能描述(Description)：
// 作者(Author)：DAtoTA
// 日期(Create Date)： 2021/9/3 8:35:39
//
//**********************************************************************
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using Sunny.UI;

namespace PLC通讯基础控件项目.控件类基.控件地址选择窗口
{
    /// <summary>
    /// 用于处理控件文字选择页面加载类
    /// </summary>
    class PLCpropertyText:PLCpublic
    {
        /// <summary>
        /// 需要预加载文字
        /// </summary>
        public PLCpropertyText(UIComboBox Textstate,UIButton Text0,UIButton Text1,UIComboBox FontText,UIComboBox FontSize,UIComboBox Fontalign
            ,UIComboBox Fontflicker,UIRichTextBox TextrichTextBox)
        {

        }
        /// <summary>
        /// 获取系统全部字体
        /// </summary>
        private void GetWindosFont(UIComboBox FontcomboBox)
        {
            InstalledFontCollection fonts = new InstalledFontCollection();
            foreach (FontFamily family in fonts.Families)
                FontcomboBox.Items.Add(family.Name);
            FontcomboBox.SelectedIndex = 0;
            FontcomboBox.KeyPress += KeyPress;
        }
        /// <summary>
        /// 获取文字字体对齐方向
        /// </summary>
        /// <param name="comboBox"></param>
        private void GetTextdirection(UIComboBox comboBox)
        {
            foreach (var i in Enum.GetNames(typeof(ContentAlignment)))
                comboBox.Items.Add(i);
            comboBox.KeyPress += KeyPress;
            comboBox.SelectedIndex = 0;
        }
    }
}
