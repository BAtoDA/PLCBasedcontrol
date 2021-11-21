//**********************************************************************
//
// 文件名称(File Name)：
// 功能描述(Description)：
// 作者(Author)：DAtoTA
// 日期(Create Date)： 2021/8/29 11:19:07
//
//**********************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using PLC通讯基础控件项目.宏脚本.接口类基;
using PLC通讯基础控件项目.控件类基.控件数据结构;

namespace PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类
{
    /// <summary>
    /// 主要用于处理位控件保存参数使用
    /// </summary>
    [Serializable]
    public sealed class PLCBitselectRealize : PLCBitBase, PLCBitproperty
    {
        #region 实现基本接口
        //--基础PLC参数部分
        public string description { get; set; } = "PLCBitselectRealize";
        public bool BitPattern { get; set; } = false;
        public bool ReadWrite { get; set; } = false;
        public PLC ReadWritePLC { get; set; } = PLC.Mitsubishi;
        public string ReadWriteFunction { get; set; } = "M";
        public string ReadWriteAddress { get; set; } = "0";
        public bool OutReverse { get; set; } = false;
        public PLC WritePLC { get; set; } = PLC.Mitsubishi;
        public string WriteFunction { get; set; } = "M";
        public string WriteAddress { get; set; } = "0";
        public bool LoosenOut { get; set; } = false;
        public Button_pattern Pattern { get; set; } = Button_pattern.selector_witch;
        //基础控件--安全控制---
        public int keyMinTime { get; set; } = 0;
        public bool OperationAffirm { get; set; } = false;
        public int AwaitTime { get; set; } = 0;
        public PLC SafetyPLC { get; set; } = PLC.Mitsubishi;
        public string SafetyFunction { get; set; } = "M";
        public string WrSafetyAddress { get; set; } = "0";
        public int SafetyPattern { get; set; } = 0;
        public int SafetyBehaviorPattern { get; set; } = 0;
        public int SafetyCategory { get; set; } = 0;
        public bool NoAccessConceal { get; set; } = false;
        public bool NoAccessForm { get; set; } = false;
        public bool Speech { get; set; } = false;
        //基础文本控制---
        public int TextState { get; set; } = 0;
        public Font TextFont_0 { get; set; } = new Font("微软雅黑", 12);
        public int Textflicker_0 { get; set; } = 0;
        public bool TextItalic_0 { get; set; } = false;
        public bool TextUnderline_0 { get; set; } = false;
        public Font TextFont_1 { get; set; } = new Font("微软雅黑", 12);
        public int Textflicker_1 { get; set; } = 0;
        public bool TextItalic_1 { get; set; } = false;
        public bool TextUnderline_1 { get; set; } = false;
        //基础外部文本颜色 与 内容控制
        public Color backgroundColor_0 { get; set; } = Color.Silver;
        public Color TextColor_0 { get; set; } = Color.White;
        public string TextContent_0 { get; set; } = "OFF";
        public Color backgroundColor_1 { get; set; } = Color.FromArgb(128, 255, 128);
        public Color TextColor_1 { get; set; } = Color.White;
        public string TextContent_1 { get; set; } = "ON";
        public System.Threading.Timer PLCTimer { get; set; }
        public string Textalign_0 { get; set; }= ContentAlignment.MiddleCenter.ToString();
        public string Textalign_1 { get; set; }= ContentAlignment.MiddleCenter.ToString();
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
        public string Macrocode { get; set; }= "using CSScriptLib; \r\n" +
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
