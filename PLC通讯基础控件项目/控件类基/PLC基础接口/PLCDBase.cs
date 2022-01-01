//**********************************************************************
//
// 文件名称(File Name)：
// 功能描述(Description)：
// 作者(Author)：DAtoTA
// 日期(Create Date)： 2021/9/9 9:38:08
//
//**********************************************************************
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using PLC通讯基础控件项目.控件类基.控件数据结构;
using PLC通讯库.通讯枚举;

namespace PLC通讯基础控件项目.控件类基.PLC基础接口
{
    /// <summary>
    /// 该接口是用于寄存器基础类型参数-比如PLC从参数通用参数
    /// </summary>
    public interface PLCDBase
    {
        /// <summary>
        /// 控件描述
        /// </summary>
        string description { get; set; }
        /// <summary>
        /// 是否启用输入功能
        /// </summary>
        bool Dataentryfunction { get; set; }
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
        /// 是否启用写入完成通知
        /// </summary>
        bool Inform { get; set; }
        /// <summary>
        /// 写入通知完成通知模式--0写入OFF 1写入ON
        /// </summary>
        int Informpattern { get; set; }
        /// <summary>
        /// 写入通知完成PLC类型
        /// </summary>
        PLC InformPLC { get; set; }
        /// <summary>
        /// 写入通知完成PLC的功能码
        /// </summary>
        string InformFunction { get; set; }
        /// <summary>
        /// 写入通知完成PLC的具体地址
        /// </summary>
        string InformAddress { get; set; }
        //------数据输入------//
        /// <summary>
        /// 是否启用键盘
        /// </summary>
        bool Keyboard { get; set; }
        /// <summary>
        /// 启用的键盘样式
        /// </summary>
        string KeyboardStyle { get; set; }
        //------数据格式------//
        /// <summary>
        /// 数据格式显示的资料格式
        /// </summary>
        numerical_format ShowFormat { get; set; }
        /// <summary>
        /// 数据格式数值的资料格式
        /// </summary>
        int NumericalFormat { get; set; }
        /// <summary>
        /// 数据格式小数点以上位数
        /// </summary>
        int NumericaldigitMax { get; set; }
        /// <summary>
        /// 数据格式小数点以下位数
        /// </summary>
        int NumericaldigitMin { get; set; }
        /// <summary>
        /// 数据格式上限最大值
        /// </summary>
        int NumericalMax { get; set; }
        /// <summary>
        /// 数据格式下限最小值
        /// </summary>
        int NumericalMin { get; set; }

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
        //--------------标签控制------------
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
