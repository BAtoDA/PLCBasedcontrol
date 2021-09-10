//**********************************************************************
//
// 文件名称(File Name)：
// 功能描述(Description)：
// 作者(Author)：DAtoTA
// 日期(Create Date)： 2021/9/9 18:50:59
//
//**********************************************************************
using System;
using System.Collections.Generic;
using System.Text;
using PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLCD控件实现类;
using PLC通讯库.通讯枚举;
using Sunny.UI;

namespace PLC通讯基础控件项目.控件类基.控件地址选择窗口
{
    /// <summary>
    /// 处理格式页面
    /// </summary>
    class PLCpropertyformat : PLCpublic
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="Showformat">显示的资料格式</param>
        /// <param name="format">格式</param>
        /// <param name="decimalsMax">小数点以上位数</param>
        /// <param name="decimalsMin">小数点一下位数</param>
        /// <param name="DataMax">设备上限数值</param>
        /// <param name="DataMin">设备下限数值</param>
        /// <param name="pLCDselect">保存数据</param>
        /// <param name="SetPlcButton">保存按钮</param>
        public PLCpropertyformat(UIComboBox Showformat,UIComboBox format, UIDoubleUpDown decimalsMax, 
            UIDoubleUpDown decimalsMin, UITextBox DataMax,UITextBox DataMin, PLCDselectRealize pLCDselect, UIButton SetPlcButton)
        {
            //--------处理显示格式------------
            foreach (var i in Enum.GetNames(typeof(numerical_format)))
                Showformat.Items.Add(i);
            Showformat.SelectedIndex = 0;
            //--------处理资料格式-------------
            decimalsMax.Value = 7;
            decimalsMin.Value = 2;
            DataMax.Text = int.MaxValue.ToString();
            DataMin.Text = int.MinValue.ToString();
            //--------读取数据-----------------
            Showformat.Text = pLCDselect.ShowFormat.ToString();
            decimalsMax.Value = pLCDselect.NumericaldigitMax;
            decimalsMin.Value = pLCDselect.NumericaldigitMin;
            DataMax.Text = pLCDselect.NumericalMax.ToString();
            DataMin.Text = pLCDselect.NumericalMin.ToString();

            SetPlcButton.Click += ((send, s1) =>
              {
                  pLCDselect.ShowFormat = (numerical_format)Enum.Parse(typeof(numerical_format), Showformat.Text);
                  pLCDselect.NumericaldigitMax = (int)decimalsMax.Value;
                  pLCDselect.NumericaldigitMin = (int)decimalsMin.Value;
                  pLCDselect.NumericalMax = Convert.ToInt32(DataMax.Text);
                  pLCDselect.NumericalMin = Convert.ToInt32(DataMin.Text);
              });
        }
    }
}
