using System;
using System.Collections.Generic;
using System.Text;

namespace PLC通讯基础控件项目.控件类基.控件数据结构
{
    /// <summary>
    /// PLC硬件选择
    /// PLC选择枚举>
    /// </summary>

    public enum PLC
    {
        Mitsubishi = 00,
        Siemens = 01,
        Modbus_TCP = 02,
        HMI = 03,
        OmronTCP = 04,
        OmronCIP = 05,
        OmronUDP = 06,
        Fanuc = 07
    }
    /// <summary>
    /// PLC各可访问软元件  三菱-bit位
    /// </summary>
    public enum Mitsubishi_bit
    {
        /*  LCS,LCC,*/
        X, Y, M, L, F, B, TS, SM, SS, SC, CS, CC, SB, S, D_Bit, R_Bit, SW_Bit, W_Bit
    }
    /// <summary>
    /// PLC各可访问软元件 三菱 -WORD 字
    /// </summary>
    public enum Mitsubishi_D
    {
        /*LCN,LZ,*/
        D, R, W, TN, SN, CN, SW, Z
    }
    /// <summary>
    /// PLC各可访问软元件  欧姆龙 位
    /// </summary>
    public enum OmronTCP_bit
    {
        W = 36,
        A = 51,
        D = 2,
        H = 50,
        EM00 = 0x20,
        EM01 = 33,
        EM02 = 34,
        EM03 = 35,
        C = 49
    }
    /// <summary>
    /// PLC各可访问软元件  欧姆龙  字
    /// </summary>
    public enum OmronTCP_D
    {
        W = 36,
        C = 49,
        H = 50,
        A = 51,
        D = 2,
        EM00 = 0x20,
        EM01 = 33,
        EM02 = 34,
        EM03 = 35
    }
    /// <summary>
    /// PLC各可访问软元件  欧姆龙 位
    /// </summary>
    public enum OmronUDP_bit
    {
        W = 36,
        A = 51,
        D = 2,
        H = 50,
        EM00 = 0x20,
        EM01 = 33,
        EM02 = 34,
        EM03 = 35,
        C = 49
    }
    /// <summary>
    /// PLC各可访问软元件  欧姆龙  字
    /// </summary>
    public enum OmronUDP_D
    {
        W = 36,
        C = 49,
        H = 50,
        A = 51,
        D = 2,
        EM00 = 0x20,
        EM01 = 33,
        EM02 = 34,
        EM03 = 35
    }
    /// <summary>
    /// PLC各可访问软元件  欧姆龙 位
    /// </summary>
    public enum OmronCIP_bit
    {
        W = 36,
        A = 51,
        D = 2,
        H = 50,
        EM00 = 0x20,
        EM01 = 33,
        EM02 = 34,
        EM03 = 35,
        C = 49
    }
    /// <summary>
    /// PLC各可访问软元件  欧姆龙  字
    /// </summary>
    public enum OmronCIP_D
    {
        W = 36,
        C = 49,
        H = 50,
        A = 51,
        D = 2,
        EM00 = 0x20,
        EM01 = 33,
        EM02 = 34,
        EM03 = 35
    }
    /// <summary>
    /// PLC各可访问软元件  欧姆龙 位
    /// </summary>
    public enum Fanuc_bit
    {
        DI = 1,
        DO = 2,
        RI = 3,
        RO = 4,
        UI = 5,
        UO = 6
    }
    /// <summary>
    /// PLC各可访问软元件  欧姆龙  字
    /// </summary>
    public enum Fanuc_D
    {
        R = 1,
        PR = 2,
        GO = 3,
        GI = 4
    }
    /// <summary>
    ///  PLC各可访问软元件 西门子 -bit位
    /// </summary>
    public enum Siemens_bit
    {
        I, Q, M, DB
    }
    /// <summary>
    /// PLC各可访问软元件 西门子-WORD 字
    /// </summary>
    public enum Siemens_D
    {
        DB, M
    }
    /// <summary>
    ///  PLC各可访问软元件 Modbus_TCP -bit位
    /// </summary>
    public enum Modbus_TCP_bit
    {
        X, Y, M
    }
    /// <summary>
    /// PLC各可访问软元件 Modbus_TCP-WORD 字
    /// </summary>
    public enum Modbus_TCP_D
    {
        D
    }
    /// <summary>
    /// PLC各可访问软元件  三菱-bit位
    /// </summary>
    public enum HMI_bit
    {
        Data_Bit
    }
    /// <summary>
    /// PLC各可访问软元件 三菱 -WORD 字
    /// </summary>
    public enum HMI_D
    {
        Data_D
    }
    /// <summary>
    ///  PLC--按钮状态
    /// </summary>
    public enum Button_state
    {
        Off, ON
    }
    /// <summary>
    /// 数值显示类型
    /// </summary>
    public enum numerical_format
    {
        BCD_16_Bit, BCD_32_Bit, Hex_16_Bit, Hex_32_Bit, Binary_16_Bit, Binary_32_Bit, Unsigned_16_Bit, Signed_16_Bit
            , Unsigned_32_Bit, Signed_32_Bit, Float_32_Bit
    }
    /// <summary>
    /// 数值显示类型
    /// </summary>
    public enum numerical_type
    {
        数值
    }
    /// <summary>
    /// 按钮操作模式
    /// </summary>
    public enum Button_pattern//按钮模式类型枚举
    {
        /// <summary>
        /// 设置ON
        /// </summary>
        Set_as_on,
        /// <summary>
        /// 设置OFF
        /// </summary>
        Set_as_off, 
        /// <summary>
        /// 切换开关
        /// </summary>
        selector_witch, 
        /// <summary>
        /// 复归型
        /// </summary>
        Regression
    }
    /// <summary>
    /// 安全操作行为模式
    /// </summary>
    public enum Pattern
    { 
        ON,OFF
    }
    /// <summary>
    /// 用户控件操作类型等级枚举
    /// </summary>
    public enum OperatingClass
    {
        A,B,C,D
    }
}

