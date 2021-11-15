using System;
using System.Collections.Generic;
using System.Text;
using PLC通讯基础控件项目.控件类基.控件数据结构;

namespace PLC通讯基础控件项目.宏脚本.接口类基
{
    /// <summary>
    /// 宏指令实现类
    /// 实现宏指令的封装
    /// </summary>
    public class MacroinstructionClass : MacroinstructionInterface
    {
        public int Numbering { get; set; } = 1;
        public string Name { get; set; } = "MacroinstructionClass1";
        public bool Period { get; set; } = false;
        public bool Condition { get; set; } = false;
        public bool FormShowLoad { get; set; } = false;
        public bool ConditionOFF { get; set; } = true;
        public bool ConditionON { get; set; } = false;
        public PLC ReadWritePLC { get; set; } = PLC.Mitsubishi;
        public string ReadWriteFunction { get; set; } = "M";
        public string ReadWriteAddress { get; set; } = "0";
        public string Macrocode { get; set; } = "using CSScriptLib; \r\n" +
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
    }
}
