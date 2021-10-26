using PLC通讯基础控件项目.控件类基.控件数据结构;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;

namespace PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLC多功能控件实现类
{
    /// <summary>
    /// 多功能控件基础接口
    /// </summary>
    public interface PLCMultifunctionBase
    {
        /// <summary>
        /// 功能键保存的参数
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PLCMultifunctionClassBase[] pLCMultifunctions { get; set; }
        /// <summary>
        /// 背景颜色保存参数
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        PLCBitselectRealize pLCBitselectRealizeq { get; set; }
        /// <summary>
        /// 读取或者写入PLC类型
        /// </summary>
        PLC ReadPLC { get; set; }
        /// <summary>
        /// 读取或者写入PLC的功能码
        /// </summary>
        string ReadFunction { get; set; }
        /// <summary>
        /// 读取或者写入PLC的具体地址
        /// </summary>
        string ReadAddress { get; set; }
        //------控件安全------//
        /// <summary>
        /// 安全控制--最少按键时间
        /// </summary>
        int keyMinTime { get; set; }
        /// <summary>
        /// 安全控制--操作前确认
        /// </summary>
        bool OperationAffirm { get; set; }
        /// <summary>
        /// 安全控制--确定等待时间
        /// </summary>
        int AwaitTime { get; set; }
        /// <summary>
        /// 安全控制--PLC类型
        /// </summary>
        PLC SafetyPLC { get; set; }
        /// <summary>
        /// 安全控制--PLC的功能码
        /// </summary>
        string SafetyFunction { get; set; }
        /// <summary>
        /// 安全控制--PLC的具体地址
        /// </summary>
        string WrSafetyAddress { get; set; }
        /// <summary>
        /// 安全控制--启用状态-设ON还是OFF
        /// </summary>
        int SafetyPattern { get; set; }
        /// <summary>
        /// 安全控制--行为模式
        /// </summary>
        int SafetyBehaviorPattern { get; set; }
        /// <summary>
        /// 安全控制--操作类别
        /// </summary>
        int SafetyCategory { get; set; }
        /// <summary>
        /// 安全控制--无权限该控件隐藏
        /// </summary>
        bool NoAccessConceal { get; set; }
        /// <summary>
        /// 安全控制--无权限该控件弹窗
        /// </summary>
        bool NoAccessForm { get; set; }
        /// <summary>
        /// 安全控制--启用系统语音播放
        /// </summary>
        bool Speech { get; set; }
        //标签控制-----
        /// <summary>
        /// 文字状态--0-字体对齐方式
        /// </summary>
        string Textalign_0 { get; set; }
        /// <summary>
        /// 文字属性--字体-尺寸-
        /// </summary>
        Font TextFont_0 { get; set; }
        /// <summary>
        /// 文本是否闪烁
        /// </summary>
        int Textflicker_0 { get; set; }
        /// <summary>
        /// 文字是否是斜体
        /// </summary>
        bool TextItalic_0 { get; set; }
        /// <summary>
        /// 文本文字是否有下划线
        /// </summary>
        bool TextUnderline_0 { get; set; }
        /// <summary>
        /// 文字状态--0-字体对齐方式
        /// </summary>
        string Textalign_1 { get; set; }
        /// <summary>
        /// 文字属性--字体-尺寸-
        /// </summary>
        Font TextFont_1 { get; set; }
        /// <summary>
        /// 文本是否闪烁
        /// </summary>
        int Textflicker_1 { get; set; }
        /// <summary>
        /// 文字是否是斜体
        /// </summary>
        bool TextItalic_1 { get; set; }
        /// <summary>
        /// 文本文字是否有下划线
        /// </summary>
        bool TextUnderline_1 { get; set; }
    }
}
