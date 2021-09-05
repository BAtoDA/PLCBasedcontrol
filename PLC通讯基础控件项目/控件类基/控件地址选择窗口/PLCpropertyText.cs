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
using PLC通讯基础控件项目.控件类基.PLC基础接口;
using PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类;
using PLC通讯基础控件项目.控件类基.控件数据结构;
using Sunny.UI;

namespace PLC通讯基础控件项目.控件类基.控件地址选择窗口
{
    /// <summary>
    /// 用于处理控件文字选择页面加载类
    /// </summary>
    sealed class PLCpropertyText : PLCpublic
    {
        /// <summary>
        /// 状态0字体背景颜色参数
        /// </summary>
        public PLCBitselectRealize TextBase { get; set; } = new PLCBitselectRealize();
        /// <summary>
        /// 状态暂时保存
        /// </summary>
        private bool PLCselectTexte{ get; set; }
        /// <summary>
        /// 需要预加载文字
        /// </summary>
        /// <param name="Textstate"></param>
        /// <param name="Text0"></param>
        /// <param name="Text1"></param>
        /// <param name="FontText"></param>
        /// <param name="FontSize"></param>
        /// <param name="Fontalign"></param>
        /// <param name="Fontflicker"></param>
        /// <param name="TextrichTextBox"></param>
        /// <param name="TextBase"></param>
        public PLCpropertyText(UIComboBox Textstate, UIButton Text0, UIButton Text1, UIComboBox FontText, UIComboBox FontSize, UIComboBox Fontalign
            , UIComboBox Fontflicker, UIRichTextBox TextrichTextBox, UIColorPicker TextColor, UIColorPicker BackColor, UICheckBox TextFont1, UICheckBox TextFont2
            , PLCBitselectRealize TextBase,UIButton SetplcButton)
        {
            //填充标签状态
            for (int i = 0; i < 2; i++)
                Textstate.Items.Add(i);
            Textstate.SelectedIndex = 0;
            //默认加载字体类型
            GetWindosFont(FontText);
            GetFontSize(FontSize);
            GetTextdirection(Fontalign);
            //加载闪烁
            for (int i = 0; i < 2; i++)
                Fontflicker.Items.Add(i);
            Fontflicker.SelectedIndex = 0;
            //初步文本
            TextrichTextBox.Text = this.GetType().Name;
            //-------------------处理事件----------------
            Textstate.KeyPress += KeyPress;
            FontText.KeyPress += KeyPress;
            FontSize.KeyPress += KeyPress;
            Fontalign.KeyPress += KeyPress;
            Fontflicker.KeyPress += KeyPress;
            //----------------处理保存文档---------------
            this.TextBase = TextBase;
            TextSwitch(false, FontText, FontSize, Fontalign, Fontflicker, TextrichTextBox, TextColor, BackColor, TextFont1, TextFont2);
            //----------------处理保存文档事件---------------
            Textstate.TextChanged += ((send, e) => { PLCselectBasee(Textstate, FontText, FontSize, Fontalign, Fontflicker, TextrichTextBox, TextColor, BackColor, TextFont1, TextFont2); });
            Text0.Click+= ((send, e) => { Textstate.Text = "0"; PLCselectBasee(Textstate, FontText, FontSize, Fontalign, Fontflicker, TextrichTextBox, TextColor, BackColor, TextFont1, TextFont2);  });
            Text1.Click += ((send, e) => { Textstate.Text = "1"; PLCselectBasee(Textstate, FontText, FontSize, Fontalign, Fontflicker, TextrichTextBox, TextColor, BackColor, TextFont1, TextFont2);});
            SetplcButton.Click += ((send, e) =>
              {
                  PLCselectBasee(Textstate, FontText, FontSize, Fontalign, Fontflicker, TextrichTextBox, TextColor, BackColor, TextFont1, TextFont2);
              });
        }
        /// <summary>
        /// 用户切换时切换以及保存数据
        /// </summary>
        /// <param name="Base"></param>
        /// <param name="FontText"></param>
        /// <param name="FontSize"></param>
        /// <param name="Fontalign"></param>
        /// <param name="Fontflicker"></param>
        /// <param name="TextrichTextBox"></param>
        /// <param name="TextColor"></param>
        /// <param name="BackColor"></param>
        /// <param name="TextFont1"></param>
        /// <param name="TextFont2"></param>
        /// <param name="TextBase"></param>
        private  void TextSwitch(bool Base, UIComboBox FontText, UIComboBox FontSize, UIComboBox Fontalign, UIComboBox Fontflicker, UIRichTextBox TextrichTextBox, UIColorPicker TextColor, UIColorPicker BackColor, UICheckBox TextFont1, UICheckBox TextFont2)
        {
            if (!Base)
            {
                //处理0--状态--
                FontText.Text = TextBase.TextFont_0 != null ? TextBase.TextFont_0.FontFamily.Name : FontText.Items[0].ToString();
                FontSize.Text = TextBase.TextFont_0 != null ? TextBase.TextFont_0.Size.ToString() : FontSize.Items[0].ToString();
                BackColor.Value= TextBase.backgroundColor_0 != null ? TextBase.backgroundColor_0 : Color.FromArgb(80, 160, 255);
                Fontflicker.Text = TextBase.Textflicker_0 != null ? TextBase.Textflicker_0.ToString() : Fontflicker.Items[0].ToString();
                Fontalign.Text = TextBase.Textalign_0 != null ? TextBase.Textalign_0 : Fontalign.Items[0].ToString();
                TextColor.Value = TextBase.TextColor_0 != null ? TextBase.TextColor_0 : Color.FromName("LightGray");
                TextFont2.Checked = TextBase.TextItalic_0;
                TextFont1.Checked = TextBase.TextUnderline_0;
                TextrichTextBox.Text = TextBase.TextContent_0 != null ? TextBase.TextContent_0 : GetType().Name;
            }
            else
            {
                //处理1--状态--
                FontText.Text = TextBase.TextFont_1 != null ? TextBase.TextFont_1.FontFamily.Name : FontText.Items[0].ToString();
                FontSize.Text = TextBase.TextFont_1 != null ? TextBase.TextFont_1.Size.ToString() : FontSize.Items[0].ToString();
                BackColor.Value = TextBase.backgroundColor_1 != null ? TextBase.backgroundColor_1 : Color.FromArgb(80, 160, 255);
                Fontflicker.Text = TextBase.Textflicker_1 != null ? TextBase.Textflicker_1.ToString() : Fontflicker.Items[0].ToString();
                Fontalign.Text = TextBase.Textalign_1 != null ? TextBase.Textalign_1 : Fontalign.Items[0].ToString();
                TextColor.Value = TextBase.TextColor_1 != null ? TextBase.TextColor_1 : Color.FromName("LightGray");
                TextFont2.Checked = TextBase.TextItalic_1;
                TextFont1.Checked = TextBase.TextUnderline_1;
                TextrichTextBox.Text = TextBase.TextContent_1 != null ? TextBase.TextContent_1 : this.GetType().Name;
            }
        }
        /// <summary>
        /// 处理0-1-状态切换时保存数据
        /// </summary>
        /// <param name="Textstate"></param>
        /// <param name="FontText"></param>
        /// <param name="FontSize"></param>
        /// <param name="Fontalign"></param>
        /// <param name="Fontflicker"></param>
        /// <param name="TextrichTextBox"></param>
        /// <param name="TextColor"></param>
        /// <param name="BackColor"></param>
        /// <param name="TextFont1"></param>
        /// <param name="TextFont2"></param>
        /// <param name="TextBase"></param>
        private void PLCselectBasee(UIComboBox Textstate, UIComboBox FontText, UIComboBox FontSize, UIComboBox Fontalign, UIComboBox Fontflicker, UIRichTextBox TextrichTextBox, UIColorPicker TextColor, UIColorPicker BackColor, UICheckBox TextFont1, UICheckBox TextFont2)
        {
            if (!PLCselectTexte)
            {
                //处理0--状态--
                TextBase.TextFont_0 = new Font(FontText.Text, Convert.ToInt32(FontSize.Text), TextFont1.Checked & TextFont2.Checked ? FontStyle.Underline | FontStyle.Italic : TextFont1.Checked ? FontStyle.Italic : TextFont2.Checked ? FontStyle.Italic : FontStyle.Underline);
                TextBase.backgroundColor_0 = BackColor.Value;
                TextBase.Textflicker_0 = Convert.ToInt32(Fontflicker.Text);
                TextBase.Textalign_0 = Fontalign.Text;
                TextBase.TextColor_0 =TextColor.Value;
                TextBase.TextItalic_0 = TextFont2.Checked;
                TextBase.TextUnderline_0 = TextFont1.Checked;
                TextBase.TextContent_0 = TextrichTextBox.Text;
            }
            else
            {
                //处理1--状态--
                TextBase.TextFont_1 = new Font(FontText.Text, Convert.ToInt32(FontSize.Text), TextFont1.Checked & TextFont2.Checked ? FontStyle.Underline | FontStyle.Italic : TextFont1.Checked ? FontStyle.Italic : TextFont2.Checked ? FontStyle.Italic : FontStyle.Underline);
                TextBase.backgroundColor_1 =BackColor.Value;
                TextBase.Textflicker_1 = Convert.ToInt32(Fontflicker.Text);
                TextBase.Textalign_1 = Fontalign.Text;
                TextBase.TextColor_1 = TextColor.Value;
                TextBase.TextItalic_1 = TextFont2.Checked;
                TextBase.TextUnderline_1 = TextFont1.Checked;
                TextBase.TextContent_1 = TextrichTextBox.Text;
            }
            PLCselectTexte = Convert.ToBoolean(Convert.ToInt16(Textstate.Text));
            TextSwitch(PLCselectTexte, FontText, FontSize, Fontalign, Fontflicker, TextrichTextBox, TextColor, BackColor, TextFont1, TextFont2);

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
