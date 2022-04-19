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
        Mitsubishi = 0,
        Siemens = 01,
        Modbus_TCP = 02,
        HMI = 03,
        OmronTCP = 04,
        OmronCIP = 05,
        OmronUDP = 06,
        Fanuc = 07,
        Mitsubishi1 = 10,
        Mitsubishi2 = 11,
        Mitsubishi3 = 12,
        Mitsubishi4 = 13,
        Mitsubishi5 = 14,
        Siemens1 = 15,
        Siemens2 = 16,
        Siemens3 = 17,
        Siemens4 = 18,
        Siemens5 = 19,
        OmronTCP1 = 20,
        OmronTCP2 = 21,
        OmronTCP3 = 22,
        OmronTCP4 = 23,
        OmronTCP5 = 24,
        OmronCIP1 = 25,
        OmronCIP2 = 26,
        OmronCIP3 = 27,
        OmronCIP4 = 28,
        OmronCIP5 = 29,
        OmronUDP1 = 30,
        OmronUDP2 = 31,
        OmronUDP3 = 32,
        OmronUDP4 = 33,
        OmronUDP5 = 34,
        Modbus_TCP1 = 35,
        Modbus_TCP2 = 36,
        Modbus_TCP3 = 37,
        Modbus_TCP4 = 38,
        Modbus_TCP5 = 39,
        Fanuc1 = 40,
        Fanuc2 = 41,
        Fanuc3 = 42,
        Fanuc4 = 43,
        Fanuc5 = 44,
    }
    /// <summary>
    /// PLC各可访问软元件  三菱-bit位
    /// </summary>
    public enum Mitsubishi_bit
    {
        /*  LCS,LCC,*/
        X, Y, M, L, F, B,D_Bit = 14, R_Bit = 15, SW_Bit = 16, W_Bit = 17
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
    /// PLC各可访问软元件  三菱-bit位
    /// </summary>
    public enum Mitsubishi1_bit
    {
        /*  LCS,LCC,*/
        X, Y, M, L, F, B, D_Bit=14, R_Bit=15, SW_Bit=16, W_Bit=17
    }
    /// <summary>
    /// PLC各可访问软元件 三菱 -WORD 字
    /// </summary>
    public enum Mitsubishi1_D
    {
        /*LCN,LZ,*/
        D, R, W, TN, SN, CN, SW, Z
    }
    /// <summary>
    /// PLC各可访问软元件  三菱-bit位
    /// </summary>
    public enum Mitsubishi2_bit
    {
        /*  LCS,LCC,*/
        X, Y, M, L, F, B, TS, SM, SS, SC, CS, CC, SB, D_Bit = 14, R_Bit = 15, SW_Bit = 16, W_Bit = 17
    }
    /// <summary>
    /// PLC各可访问软元件 三菱 -WORD 字
    /// </summary>
    public enum Mitsubishi2_D
    {
        /*LCN,LZ,*/
        D, R, W, TN, SN, CN, SW, Z
    }
    /// <summary>
    /// PLC各可访问软元件  三菱-bit位
    /// </summary>
    public enum Mitsubishi3_bit
    {
        /*  LCS,LCC,*/
        X, Y, M, L, F, B, TS, SM, SS, SC, CS, CC, SB,  D_Bit = 14, R_Bit = 15, SW_Bit = 16, W_Bit = 17
    }
    /// <summary>
    /// PLC各可访问软元件 三菱 -WORD 字
    /// </summary>
    public enum Mitsubishi3_D
    {
        /*LCN,LZ,*/
        D, R, W, TN, SN, CN, SW, Z
    }
    /// <summary>
    /// PLC各可访问软元件  三菱-bit位
    /// </summary>
    public enum Mitsubishi4_bit
    {
        /*  LCS,LCC,*/
        X, Y, M, L, F, B, TS, SM, SS, SC, CS, CC, SB, D_Bit = 14, R_Bit = 15, SW_Bit = 16, W_Bit = 17
    }
    /// <summary>
    /// PLC各可访问软元件 三菱 -WORD 字
    /// </summary>
    public enum Mitsubishi4_D
    {
        /*LCN,LZ,*/
        D, R, W, TN, SN, CN, SW, Z
    }
    /// <summary>
    /// PLC各可访问软元件  三菱-bit位
    /// </summary>
    public enum Mitsubishi5_bit
    {
        /*  LCS,LCC,*/
        X, Y, M, L, F, B, TS, SM, SS, SC, CS, CC, SB, D_Bit = 14, R_Bit = 15, SW_Bit = 16, W_Bit = 17
    }
    /// <summary>
    /// PLC各可访问软元件 三菱 -WORD 字
    /// </summary>
    public enum Mitsubishi5_D
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
    public enum OmronTCP1_bit
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
    public enum OmronTCP1_D
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
    public enum OmronTCP2_bit
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
    public enum OmronTCP2_D
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
    public enum OmronTCP3_bit
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
    public enum OmronTCP3_D
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
    public enum OmronTCP4_bit
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
    public enum OmronTCP4_D
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
    public enum OmronTCP5_bit
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
    public enum OmronTCP5_D
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
    public enum OmronUDP1_bit
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
    public enum OmronUDP1_D
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
    public enum OmronUDP2_bit
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
    public enum OmronUDP2_D
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
    public enum OmronUDP3_bit
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
    public enum OmronUDP3_D
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
    public enum OmronUDP4_bit
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
    public enum OmronUDP4_D
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
    public enum OmronUDP5_bit
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
    public enum OmronUDP5_D
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
    public enum OmronCIP1_bit
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
    public enum OmronCIP1_D
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
    public enum OmronCIP2_bit
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
    public enum OmronCIP2_D
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
    public enum OmronCIP3_bit
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
    public enum OmronCIP3_D
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
    public enum OmronCIP4_bit
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
    public enum OmronCIP4_D
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
    public enum OmronCIP5_bit
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
    public enum OmronCIP5_D
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
    /// PLC各可访问软元件  发那科 位
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
    /// PLC各可访问软元件  发那科  字
    /// </summary>
    public enum Fanuc_D
    {
        R = 1
    }
    /// <summary>
    /// PLC各可访问软元件  发那科  字
    /// </summary>
    public enum Fanuc1_D
    {
        R = 1
    }
    /// <summary>
    /// PLC各可访问软元件  发那科 位
    /// </summary>
    public enum Fanuc1_bit
    {
        DI = 1,
        DO = 2,
        RI = 3,
        RO = 4,
        UI = 5,
        UO = 6
    }
    /// <summary>
    /// PLC各可访问软元件  发那科 位
    /// </summary>
    public enum Fanuc2_bit
    {
        DI = 1,
        DO = 2,
        RI = 3,
        RO = 4,
        UI = 5,
        UO = 6
    }
    /// <summary>
    /// PLC各可访问软元件  发那科  字
    /// </summary>
    public enum Fanuc2_D
    {
        R = 1
    }
    /// <summary>
    /// PLC各可访问软元件  发那科 位
    /// </summary>
    public enum Fanuc3_bit
    {
        DI = 1,
        DO = 2,
        RI = 3,
        RO = 4,
        UI = 5,
        UO = 6
    }
    /// <summary>
    /// PLC各可访问软元件  发那科  字
    /// </summary>
    public enum Fanuc3_D
    {
        R = 1
    }
    /// <summary>
    /// PLC各可访问软元件  发那科 位
    /// </summary>
    public enum Fanuc4_bit
    {
        DI = 1,
        DO = 2,
        RI = 3,
        RO = 4,
        UI = 5,
        UO = 6
    }
    /// <summary>
    /// PLC各可访问软元件  发那科  字
    /// </summary>
    public enum Fanuc4_D
    {
        R = 1
    }
    /// <summary>
    /// PLC各可访问软元件  发那科 位
    /// </summary>
    public enum Fanuc5_bit
    {
        DI = 1,
        DO = 2,
        RI = 3,
        RO = 4,
        UI = 5,
        UO = 6
    }
    /// <summary>
    /// PLC各可访问软元件  发那科  字
    /// </summary>
    public enum Fanuc5_D
    {
        R = 1
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
    ///  PLC各可访问软元件 西门子 -bit位
    /// </summary>
    public enum Siemens1_bit
    {
        I, Q, M, DB
    }
    /// <summary>
    /// PLC各可访问软元件 西门子-WORD 字
    /// </summary>
    public enum Siemens1_D
    {
        DB, M
    }
    /// <summary>
    ///  PLC各可访问软元件 西门子 -bit位
    /// </summary>
    public enum Siemens2_bit
    {
        I, Q, M, DB
    }
    /// <summary>
    /// PLC各可访问软元件 西门子-WORD 字
    /// </summary>
    public enum Siemens2_D
    {
        DB, M
    }
    /// <summary>
    ///  PLC各可访问软元件 西门子 -bit位
    /// </summary>
    public enum Siemens3_bit
    {
        I, Q, M, DB
    }
    /// <summary>
    /// PLC各可访问软元件 西门子-WORD 字
    /// </summary>
    public enum Siemens3_D
    {
        DB, M
    }
    /// <summary>
    ///  PLC各可访问软元件 西门子 -bit位
    /// </summary>
    public enum Siemens4_bit
    {
        I, Q, M, DB
    }
    /// <summary>
    /// PLC各可访问软元件 西门子-WORD 字
    /// </summary>
    public enum Siemens4_D
    {
        DB, M
    }
    /// <summary>
    ///  PLC各可访问软元件 西门子 -bit位
    /// </summary>
    public enum Siemens5_bit
    {
        I, Q, M, DB
    }
    /// <summary>
    /// PLC各可访问软元件 西门子-WORD 字
    /// </summary>
    public enum Siemens5_D
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
    ///  PLC各可访问软元件 Modbus_TCP -bit位
    /// </summary>
    public enum Modbus_TCP1_bit
    {
        X, Y, M
    }
    /// <summary>
    /// PLC各可访问软元件 Modbus_TCP-WORD 字
    /// </summary>
    public enum Modbus_TCP1_D
    {
        D
    }
    /// <summary>
    ///  PLC各可访问软元件 Modbus_TCP -bit位
    /// </summary>
    public enum Modbus_TCP2_bit
    {
        X, Y, M
    }
    /// <summary>
    /// PLC各可访问软元件 Modbus_TCP-WORD 字
    /// </summary>
    public enum Modbus_TCP2_D
    {
        D
    }
    /// <summary>
    ///  PLC各可访问软元件 Modbus_TCP -bit位
    /// </summary>
    public enum Modbus_TCP3_bit
    {
        X, Y, M
    }
    /// <summary>
    /// PLC各可访问软元件 Modbus_TCP-WORD 字
    /// </summary>
    public enum Modbus_TCP3_D
    {
        D
    }
    /// <summary>
    ///  PLC各可访问软元件 Modbus_TCP -bit位
    /// </summary>
    public enum Modbus_TCP4_bit
    {
        X, Y, M
    }
    /// <summary>
    /// PLC各可访问软元件 Modbus_TCP-WORD 字
    /// </summary>
    public enum Modbus_TCP4_D
    {
        D
    }
    /// <summary>
    ///  PLC各可访问软元件 Modbus_TCP -bit位
    /// </summary>
    public enum Modbus_TCP5_bit
    {
        X, Y, M
    }
    /// <summary>
    /// PLC各可访问软元件 Modbus_TCP-WORD 字
    /// </summary>
    public enum Modbus_TCP5_D
    {
        D
    }
    /// <summary>
    /// PLC各可访问软元件  三菱-bit位
    /// </summary>
    public enum HMI_bit
    {
        LB,
        RB
    }
    /// <summary>
    /// PLC各可访问软元件 三菱 -WORD 字
    /// </summary>
    public enum HMI_D
    {
        LW,
        RW
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
        OFF,ON
    }
    /// <summary>
    /// 用户控件操作类型等级枚举
    /// </summary>
    public enum OperatingClass
    {
        A,B,C, D
    }
    public enum PLCSet
    { 
     Set1,Set0
    }
    /// <summary>
    /// 用户控件操作类型等级枚举
    /// </summary>
    public enum Safetypattern
    {
        /// <summary>
        /// 关闭
        /// </summary>
        Close,
        /// <summary>
        /// 隐藏
        /// </summary>
        Hide,
        /// <summary>
        /// 灰色文字
        /// </summary>
        Gray, 
        /// <summary>
        /// 无任何操作
        /// </summary>
        Nooperation
    }
}

