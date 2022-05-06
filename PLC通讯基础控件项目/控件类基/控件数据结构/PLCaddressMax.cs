using System;
using System.Collections.Generic;
using System.Text;

namespace PLC通讯基础控件项目.控件类基.控件数据结构
{
    public enum HMI_addressMax
    {
        Max_LB = 1000,
        Max_RB = 1000,
        Max_LW = 500,
        Max_RW = 500
    }
    public enum HMI_addressMax_Bit
    {
        LB=1000,
        RB=1000
    }
    public enum HMI_addressMax_D
    {
        LW=500,
        RW=500
    }
    public enum Mitsubishi_addressMax
    {
        Max_X = 1000,
        Max_Y = 1000,
        Max_M = 7000,
        Max_L = 3000,
        Max_F = 3000,
        Max_B = 3000,
        Max_D = 7000,
        Max_R = 7000,
        Max_W = 7000,
        Max_TN = 1000,
        Max_SN = 1000,
        Max_CN = 1000,
        Max_SW = 1000,
        Max_Z = 20
    }
    /// <summary>
    /// 三菱PLC对应功能码最大地址
    /// 当前枚举适用于批量访问PLC的内存区域
    /// </summary>
    public enum Mitsubishi_addressMax_Bit
    {
        X = 1024,
        Y = 1024,
        M = 20000,
        L = 4000,
        F = 2000,
        B = 16000
    }
    /// <summary>
    /// 三菱PLC对应功能码最大地址
    /// 当前枚举适用于批量访问PLC的内存区域
    /// </summary>
    public enum Mitsubishi_addressMax_D
    {
        D = 30000,
        R = 30000,
        W = 10000,
        TN = 2000,
        SN = 1000,
        CN = 2000,
        SW = 2000,
        Z = 20
    }
    public enum Mitsubishi1_addressMax
    {
        Max_X = 1000,
        Max_Y = 1000,
        Max_M = 3000,
        Max_L = 3000,
        Max_F = 3000,
        Max_B = 3000,
        Max_D = 7000,
        Max_R = 7000,
        Max_W = 7000,
        Max_TN = 1000,
        Max_SN = 1000,
        Max_CN = 1000,
        Max_SW = 1000,
        Max_Z = 20
    }
    /// <summary>
    /// 三菱PLC对应功能码最大地址
    /// 当前枚举适用于批量访问PLC的内存区域
    /// </summary>
    public enum Mitsubishi1_addressMax_Bit
    {
        X = 1024,
        Y = 1024,
        M = 20000,
        L = 4000,
        F = 2000,
        B = 16000
    }
    /// <summary>
    /// 三菱PLC对应功能码最大地址
    /// 当前枚举适用于批量访问PLC的内存区域
    /// </summary>
    public enum Mitsubishi1_addressMax_D
    {
        D = 30000,
        R = 30000,
        W = 10000,
        TN = 2000,
        SN = 1000,
        CN = 2000,
        SW = 2000,
        Z = 20
    }
    public enum Siemens_addressMax
    {
        Max_I = 1000,
        Max_Q = 1000,
        Max_M = 7000
    }
    /// <summary>
    /// 西门子PLC对应功能码最大地址
    /// 当前枚举适用于批量访问PLC的内存区域
    /// </summary>
    public enum Siemens_addressMax_Bit
    {
        I=8000,
        Q=8000, 
        M=32000
    }
    /// <summary>
    /// 西门子PLC对应功能码最大地址
    /// 当前枚举适用于批量访问PLC的内存区域
    /// </summary>
    public enum Siemens_addressMax_D
    {
        /// <summary>
        /// 字方式
        /// </summary>
        M = 2000
    }
    public enum Modbus_TCP_addressMax
    {
        Max_X = 1000,
        Max_Y = 1000,
        Max_D = 1000
    }
    /// <summary>
    /// ModbusPLC对应功能码最大地址
    /// 当前枚举适用于批量访问PLC的内存区域
    /// </summary>
    public enum Modbus_TCP_addressMax_Bit
    {
        X=1000,
        Y=1000,
        M=7000
    }
    /// <summary>
    /// ModbusPLC对应功能码最大地址
    /// 当前枚举适用于批量访问PLC的内存区域
    /// </summary>
    public enum Modbus_TCP_addressMax_D
    {
        D = 8000
    }
    public enum OmronTCP_addressMax
    {
        Max_W = 1000,
        Max_A = 1000,
        Max_H = 1000,
        Max_C = 1000
    }
    /// <summary>
    /// 欧姆龙PLC对应功能码最大地址
    /// 当前枚举适用于批量访问PLC的内存区域
    /// </summary>
    public enum OmronTCP_addressMax_Bit
    {
        W = 8000,
        A = 14400,
        H = 8000,
        /// <summary>
        /// 输入区域 CI00-CI99 I0.0-I0.F
        /// 输出区域 CI100-199
        /// CPU区域  CI1500-1899
        /// </summary>
        C = 30380
    }
    /// <summary>
    /// 欧姆龙PLC对应功能码最大地址
    /// 当前枚举适用于批量访问PLC的内存区域
    /// </summary>
    public enum OmronTCP_addressMax_D
    {
        W = 512,
        A = 960,
        D = 32767,
        H = 512,
        C = 4096
    }
    public enum OmronCIP_addressMax
    {
        Max_W = 1000,
        Max_A = 1000,
        Max_H = 1000,
        Max_C = 1000
    }
    /// <summary>
    /// 欧姆龙PLC对应功能码最大地址
    /// 当前枚举适用于批量访问PLC的内存区域
    /// </summary>
    public enum OmronCIP_addressMax_Bit
    {
        W = 8000,
        A = 14400,
        H = 8000,
        /// <summary>
        /// 输入区域 CI00-CI99 I0.0-I0.F
        /// 输出区域 CI100-199
        /// CPU区域  CI1500-1899
        /// </summary>
        C = 30380
    }
    /// <summary>
    /// 欧姆龙PLC对应功能码最大地址
    /// 当前枚举适用于批量访问PLC的内存区域
    /// </summary>
    public enum OmronCIP_addressMax_D
    {
        W = 512,
        A = 960,
        D = 32767,
        H = 512,
        C = 4096
    }
    public enum OmronUDP_addressMax
    {
        Max_W = 1000,
        Max_A = 1000,
        Max_H = 1000,
        Max_C = 1000
    }
    /// <summary>
    /// 欧姆龙PLC对应功能码最大地址
    /// 当前枚举适用于批量访问PLC的内存区域
    /// </summary>
    public enum OmronUDP_addressMax_Bit
    {
        W = 8000,
        A = 14400,
        H = 8000,
        /// <summary>
        /// 输入区域 CI00-CI99 I0.0-I0.F
        /// 输出区域 CI100-199
        /// CPU区域  CI1500-1899
        /// </summary>
        C = 30380
    }
    /// <summary>
    /// 欧姆龙PLC对应功能码最大地址
    /// 当前枚举适用于批量访问PLC的内存区域
    /// </summary>
    public enum OmronUDP_addressMax_D
    {
        W = 512,
        A = 960,
        D = 32767,
        H = 512,
        C = 4096
    }

}
