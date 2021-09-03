//**********************************************************************
//
// 文件名称(File Name)：
// 功能描述(Description)：
// 作者(Author)：DAtoTA
// 日期(Create Date)： 2021/9/2 22:15:37
//
//**********************************************************************
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PLC通讯基础控件项目.控件类基.控件数据结构;
using Sunny.UI;

namespace PLC通讯基础控件项目.控件类基.控件地址选择窗口
{
    /// <summary>
    /// 用于处理控件属性安全选择页
    /// </summary>
    class PLCpropertysafety:PLCpublic
    {
        public PLCpropertysafety(UIComboBox MinCombobox,UICheckBox SafetyCheck,UIComboBox MaxCombobox, UIComboBox readwriteplc, UIComboBox readwritePLCfunction,
            UITextBox readwriteaddress,UIComboBox PLCEnable,UIComboBox PlcBehavior,UIComboBox Operation,UIGroupBox[] groupBoxes)
        {
            //填充安全操作时间
            RandomTime(MinCombobox);
            RandomTime(MaxCombobox);
            //填充PLC类型
            readwriteplc.Items.Clear();
            Enum.GetNames(typeof(PLC)).ForEach(s =>
            {
                readwriteplc.Items.Add(s);
            });
            readwriteplc.SelectedIndex = 0;
            //处理用户选择PLC时改变功能码
            readwriteplc.TextChanged += ((sendq, s1) =>
            {
                readwritePLCfunction.Items.Clear();
                GetPLCBitName(readwritePLCfunction, readwriteplc.Text);
                readwriteaddress.Text = "0";
            });
            readwriteaddress.Text = "0";
            readwriteplc.KeyPress += KeyPress;           
            //处理启用状态
            foreach (var i in Enum.GetNames(typeof(Pattern)))
                PLCEnable.Items.Add(i);
            PLCEnable.SelectedIndex = 0;
            //填充行为模式--固定关闭时隐藏
            PlcBehavior.Items.Add("关闭时隐藏");
            PlcBehavior.SelectedIndex = 0;
            //操作类别
            foreach (var i in Enum.GetNames(typeof(OperatingClass)))
                Operation.Items.Add(i);
            Operation.SelectedIndex = 0;
            //处理是否开启安全事件
            SafetyCheck.CheckedChanged += ((send, e) =>
              {
                  groupBoxes.ForEach(contr =>
                  {
                      contr.Visible = SafetyCheck.Checked;
                  });
              });
            //锁定事件
            readwritePLCfunction.KeyPress += KeyPress;
            PLCEnable.KeyPress += KeyPress;
            PlcBehavior.KeyPress += KeyPress;
            Operation.KeyPress += KeyPress;
            
        }
        /// <summary>
        /// 自动产生时间间隔
        /// </summary>
        /// <returns></returns>
        public void RandomTime(UIComboBox comboBox)
        {        
            for (int i = 0; i < 100; i++)
            {
                comboBox.Items.Add((i * 100).ToString());
            }
            comboBox.KeyPress += KeyPress;
            comboBox.SelectedIndex = 0;
        }
    }
}
