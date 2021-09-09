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
    class PLCDselectRealize : PLCDBase, PLCDproperty
    {
        #region 实现基本接口
        public string description { get; set; }
        public bool Dataentryfunction { get; set; }
        public bool ReadWrite { get; set; }
        public PLC ReadWritePLC { get; set; }
        public string ReadWriteFunction { get; set; }
        public string ReadWriteAddress { get; set; }
        public PLC WritePLC { get; set; }
        public string WriteFunction { get; set; }
        public string WriteAddress { get; set; }
        public bool Inform { get; set; }
        public int Informpattern { get; set; }
        public PLC InformPLC { get; set; }
        public string InformFunction { get; set; }
        public string InformAddress { get; set; }
        public bool Keyboard { get; set; }
        public int KeyboardStyle { get; set; }
        public numerical_format ShowFormat { get; set; }
        public int NumericalFormat { get; set; }
        public int NumericaldigitMax { get; set; }
        public int NumericaldigitMin { get; set; }
        public int NumericalMax { get; set; }
        public int NumericalMin { get; set; }
        public int keyMinTime { get; set; }
        public bool OperationAffirm { get; set; }
        public int AwaitTime { get; set; }
        public PLC SafetyPLC { get; set; }
        public string SafetyFunction { get; set; }
        public string WrSafetyAddress { get; set; }
        public int SafetyPattern { get; set; }
        public int SafetyBehaviorPattern { get; set; }
        public int SafetyCategory { get; set; }
        public bool NoAccessConceal { get; set; }
        public bool NoAccessForm { get; set; }
        public bool Speech { get; set; }
        public string Textalign_0 { get; set; }
        public Font TextFont_0 { get; set; }
        public int Textflicker_0 { get; set; }
        public bool TextItalic_0 { get; set; }
        public bool TextUnderline_0 { get; set; }
        public string Textalign_1 { get; set; }
        public Font TextFont_1 { get; set; }
        public int Textflicker_1 { get; set; }
        public bool TextItalic_1 { get; set; }
        public bool TextUnderline_1 { get; set; }
        public Color TextColor_0 { get; set; }
        public string TextContent_0 { get; set; }
        public Color TextColor_1 { get; set; }
        public string TextContent_1 { get; set; }
        public Timer PLCTimer { get; set; }
        #endregion
    }
}
