using System;
using System.Collections.Generic;
using System.Text;
using PLC通讯基础控件项目.宏脚本;
using PLC通讯基础控件项目.宏脚本.接口类基;
using Sunny.UI;

namespace PLC通讯基础控件项目.控件类基.控件地址选择窗口
{
    /// <summary>
    /// 该类主要用于加载宏指令
    /// 编辑窗口的属性 以及内容 不进行保持操作
    /// </summary>
    internal class PLCmacrosClass
    {
        /// <summary>
        /// 宏接口
        /// </summary>
        private MacroinstructionInterface macroinstructionInterface;
        /// <summary>
        /// 构造函数
        /// 加载窗口数据
        /// </summary>
        /// <param name="macroinstructionInterfac"></param>
        public PLCmacrosClass(UITextBox NumberingTextBox,UITextBox NameTextBox,UIRichTextBox MacrocodeRichTextBox,UIButton macrosShowButton, MacroinstructionInterface macroinstructionInterfac)
        {
            //获取接口参数
            this.macroinstructionInterface = macroinstructionInterfac;
            //-------------------加载参数-----------------------------
            NumberingTextBox.Text = macroinstructionInterfac.Numbering.ToString();
            NameTextBox.Text= macroinstructionInterfac.Name??this.GetType().Name;
            MacrocodeRichTextBox.Text = macroinstructionInterfac.Macrocode ?? "using CSScriptLib; \r\n" +
            "using Microsoft.CSharp;using System; \r\n" +
            "using System.CodeDom.Compiler; \r\n" +
            "using System.Collections.Generic; \r\n" +
            "using System.ComponentModel; \r\n" +
            "using System.Data; \r\n" +
            "using System.Drawing; \r\n" +
            "using System.IO; \r\n" +
            "using System.Linq; \r\n" +
            "using System.Net.Sockets; \r\n" +
            "using System.Reflection; \r\n" +
            "using System.Text; \r\n" +
            "using System.Threading.Tasks; \r\n" +
            "using System.Windows.Forms; \r\n" +
            "using System.Net; \r\n" +
            "using System.Threading; \r\n" +
            "public static class ScriptCCStatic \r\n" +
            "{ \r\n" +
                  "//主方法不可更改和删除否则编译报错 \r\n" +
              "   public static void Main(string greeting) \r\n" +
            "      { \r\n " +
                     "//编写代码行： \r\n" +
            "      } \r\n" +
            "} \r\n";
            //-------------------用户是否点击了打开宏指令编辑器--------------
            macrosShowButton.Click += ((sender, e) =>
              {
                  new MacroinstructionForm(this.macroinstructionInterface).ShowDialog();
              });
        }

    }
}
