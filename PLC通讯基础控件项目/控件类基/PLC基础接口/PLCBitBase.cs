using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using PLC通讯基础控件项目.控件类基.控件数据结构;
namespace PLC通讯基础控件项目.控件类基
{
    /// <summary>
    /// 该接口是用于位基础类型参数-比如PLC从参数通用参数
    /// </summary>
    interface PLCBitBase
    {
        /// <summary>
        /// 控件描述
        /// </summary>
        string description { get; set; }
        /// <summary>
        /// 选择控件模式-位指示灯还是位状态切换开关
        /// </summary>
        bool BitPattern { get; set; }
        /// <summary>
        /// 读取PLC模式-读取/写入地址不同
        /// </summary>
        bool ReadWrite { get; set; }
        /// <summary>
        /// 读取或者写入PLC类型
        /// </summary>

        PLC ReadWritePLC { get; set; }
        /// <summary>
        /// 读取或者写入PLC的功能码
        /// </summary>
        string ReadWriteFunction { get; set; }
        /// <summary>
        /// 读取或者写入PLC的具体地址
        /// </summary>
        string ReadWriteAddress { get; set; }
        /// <summary>
        /// 输出模式-输出反向
        /// </summary>
        bool OutReverse { get; set; }
        /// <summary>
        /// 写入PLC类型
        /// </summary>

        PLC WritePLC { get; set; }
        /// <summary>
        /// 写入PLC的功能码
        /// </summary>
        string WriteFunction { get; set; }
        /// <summary>
        /// 写入PLC的具体地址
        /// </summary>
        string WriteAddress { get; set; }
        /// <summary>
        /// 输出模式-当按钮松开后发出指令
        /// </summary>
        bool LoosenOut { get; set; }
        /// <summary>
        /// 按钮操作模式
        /// </summary>
        Button_pattern Pattern { get; set; }
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
