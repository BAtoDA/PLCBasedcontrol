using System;
using System.Collections.Generic;
using System.Text;
using PLC通讯基础控件项目.控件类基.控件数据结构;

namespace PLC通讯基础控件项目.宏脚本.接口类基
{
    /// <summary>
    /// 用于宏指令基本接口
    /// </summary>
    public interface MacroinstructionInterface
    {
        /// <summary>
        /// 宏指令ID
        /// 不可更改
        /// </summary>
        int MacroID { get; set; }
        /// <summary>
        /// 宏指令编号
        /// </summary>
        int Numbering { get; set; }
        /// <summary>
        /// 宏指令编译状态
        /// </summary>
        bool Compilestate { get; set; }
        /// <summary>
        /// 宏指令名称
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// 是否周期执行宏指令
        /// 这表示循环执行
        /// </summary>
        bool Period { get; set; }
        /// <summary>
        /// 宏指令执行条件
        /// 这表示启用了安全条件
        /// </summary>
        bool Condition { get; set; }
        /// <summary>
        /// 宏指令当Form窗口打开时执行一次
        /// </summary>
        bool FormShowLoad { get; set; }
        /// <summary>
        /// 宏指令执行条件off
        /// 这表示在OFF状态下允许执行
        /// </summary>
        bool ConditionOFF { get; set; }
        /// <summary>
        /// 宏指令执行条件ON
        /// 这表示在ON状态下允许执行
        /// </summary>
        bool ConditionON { get; set; }
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
        /// 宏指令代码
        /// </summary>
        string Macrocode { get; set; }
    }
}
