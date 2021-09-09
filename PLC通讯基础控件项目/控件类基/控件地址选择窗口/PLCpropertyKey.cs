//**********************************************************************
//
// 文件名称(File Name)：
// 功能描述(Description)：
// 作者(Author)：DAtoTA
// 日期(Create Date)： 2021/9/9 15:36:25
//
//**********************************************************************
using System;
using System.Collections.Generic;
using System.Text;
using PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLCD控件实现类;
using Sunny.UI;
using System.Reflection;
using System.Text.RegularExpressions;

namespace PLC通讯基础控件项目.控件类基.控件地址选择窗口
{
    /// <summary>
    /// 用于处理控件参数数值键盘输入界面
    /// </summary>
    class PLCpropertyKey
    {
        /// <summary>
        /// 构造函数处理
        /// </summary>
        /// <param name="Key"></param>
        /// <param name="KeyStey"></param>
        /// <param name="pLCDselect">保存参数</param>
        /// <param name="KeyLabel">文本显示</param>
        /// <param name="SetPlcButton">参数保存</param>
        public PLCpropertyKey(UICheckBox Key,UIComboBox KeyStey,UILabel KeyLabel, PLCDselectRealize pLCDselect, UIButton SetPlcButton)
        {
            //从命名空间中加载键盘样式
            Regex r = new Regex("PLC通讯基础控件项目.控件类基.控件文本键盘");         
            var TypeData = Assembly.GetExecutingAssembly().GetTypes();
            KeyStey.Items.Clear();
            foreach (var i in TypeData)
            {
                if (r.Match(i.FullName).Success)
                {
                    KeyStey.Items.Add(i.Name);
                }
            }
            KeyStey.SelectedIndex = 0;
            //是否启用键盘样式
            Key.CheckedChanged += ((send, e) =>
              {
                  KeyStey.Visible = Key.Checked;
                  KeyLabel.Visible = Key.Checked;
              });
            //--------处理数据---------
            Key.Checked = pLCDselect.Keyboard;
            KeyStey.SelectedIndex = pLCDselect.KeyboardStyle;

            SetPlcButton.Click += ((send, s1) =>
              {
                  pLCDselect.Keyboard = Key.Checked;
                  pLCDselect.KeyboardStyle = KeyStey.SelectedIndex;
              });
        }
    }
}
