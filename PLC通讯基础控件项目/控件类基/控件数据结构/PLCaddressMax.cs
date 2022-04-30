using System;
using System.Collections.Generic;
using System.Text;

namespace PLC通讯基础控件项目.控件类基.控件数据结构
{
    /// <summary>
    /// 三菱PLC对应功能码最大地址
    /// 当前枚举适用于批量访问PLC的内存区域
    /// </summary>
     public enum Mitsubishi_addressMax_Bit
    {
        X=8000, 
        Y= 8000,
        M=20000,
        L=4000,
        F=2000,
        B=16000
    }
    /// <summary>
    /// 三菱PLC对应功能码最大地址
    /// 当前枚举适用于批量访问PLC的内存区域
    /// </summary>
    public enum Mitsubishi_addressMax_D
    {
        D = 50000,
        R = 30000,
        W = 10000,
        TN = 2000,
        SN = 1000,
        CN = 2000,
        SW = 2000,
        Z = 20
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

}
