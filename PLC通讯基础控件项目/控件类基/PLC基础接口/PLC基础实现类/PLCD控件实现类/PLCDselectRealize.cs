//**********************************************************************
//
// 文件名称(File Name)：
// 功能描述(Description)：
// 作者(Author)：DAtoTA
// 日期(Create Date)： 2021/9/9 14:23:01
//
//**********************************************************************
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading;
using PLC通讯基础控件项目.控件类基.控件数据结构;
using PLC通讯库.通讯枚举;

namespace PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLCD控件实现类
{
    /// <summary>
    /// 用于保存D寄存器类型控件参数
    /// </summary>
    [Serializable]
    public sealed class PLCDselectRealize : PLCDBase, PLCDproperty
    {
        #region 实现基本接口
        public string description { get; set; } = "PLCDselectRealize";
        public bool Dataentryfunction { get; set; } = true;
        public bool ReadWrite { get; set; } = false;
        public PLC ReadWritePLC { get; set; } = PLC.Mitsubishi;
        public string ReadWriteFunction { get; set; } = "D";
        public string ReadWriteAddress { get; set; } = "0";
        public PLC WritePLC { get; set; } = PLC.Mitsubishi;
        public string WriteFunction { get; set; } = "D";
        public string WriteAddress { get; set; } = "0";
        public bool Inform { get; set; } = false;
        public int Informpattern { get; set; } = 0;
        public PLC InformPLC { get; set; } = PLC.Mitsubishi;
        public string InformFunction { get; set; } = "M";
        public string InformAddress { get; set; } = "0";
        public bool Keyboard { get; set; } = true;
        public string KeyboardStyle { get; set; } = "keyboard";
        public numerical_format ShowFormat { get; set; } = numerical_format.Signed_32_Bit;
        public int NumericalFormat { get; set; } = 0;
        public int NumericaldigitMax { get; set; } = 7;
        public int NumericaldigitMin { get; set; } = 0;
        public int NumericalMax { get; set; } = 9999999;
        public int NumericalMin { get; set; } = -999999;
        public int keyMinTime { get; set; } = 0;
        public bool OperationAffirm { get; set; } = false;
        public int AwaitTime { get; set; } = 0;
        public PLC SafetyPLC { get; set; } = PLC.Mitsubishi;
        public string SafetyFunction { get; set; } = "M";
        public string WrSafetyAddress { get; set; } = "0";
        public int SafetyPattern { get; set; } = 1;
        public int SafetyBehaviorPattern { get; set; } = 1;
        public int SafetyCategory { get; set; } = 0;
        public bool NoAccessConceal { get; set; } = false;
        public bool NoAccessForm { get; set; } = false;
        public bool Speech { get; set; } = false;
        public string Textalign_0 { get; set; }= ContentAlignment.BottomCenter.ToString();
        public Font TextFont_0 { get; set; } = new Font("黑体", 9);
        public int Textflicker_0 { get; set; } = 0;
        public bool TextItalic_0 { get; set; } = false;
        public bool TextUnderline_0 { get; set; } = false;
        public string Textalign_1 { get; set; }= ContentAlignment.BottomCenter.ToString();
        public Font TextFont_1 { get; set; } = new Font("黑体", 9);
        public int Textflicker_1 { get; set; } = 0;
        public bool TextItalic_1 { get; set; } = false;
        public bool TextUnderline_1 { get; set; } = false;
        public Color TextColor_0 { get; set; } = Color.Black;
        public string TextContent_0 { get; set; }
        public Color TextColor_1 { get; set; } = Color.Black;
        public string TextContent_1 { get; set; }
        public Timer PLCTimer { get; set; }
        #endregion
        #region 宏脚本实现
        /// <summary>
        /// 宏指令程序ID
        /// </summary>
        public int macroID { get; set; } = 1;
        /// <summary>
        /// 宏指令编译状态
        /// </summary>
        public bool Compilestate { get; set; } = false;
        /// <summary>
        /// 宏指令名称
        /// </summary>
        public string MacroName { get; set; } = "MacroList";
        /// <summary>
        /// 宏指令绑定事件
        /// </summary>
        public string MacroEvent { get; set; } = "不使用";
        /// <summary>
        /// 宏指令代码
        /// </summary>
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
        #endregion
    }
}
