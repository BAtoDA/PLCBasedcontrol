//**********************************************************************
//
// 文件名称(File Name)：
// 功能描述(Description)：用于选择PLC地址已经类型基础类
// 作者(Author)：DAtoTA
// 日期(Create Date)： 2021/8/24 21:35:10
//
//**********************************************************************
using System;
using System.Collections.Generic;
using System.Text;

namespace PLC通讯基础控件项目.控件类基.控件数据结构
{
    /// <summary>
    /// 控件选择PLC地址与类型的基类-必须实现所有属性
    /// </summary>
    public abstract class PLCselectBase
    {
        /// <summary>
        /// 需要读写PLC的类型
        /// </summary>
        public abstract PLC PLCRW { get; set; }
        /// <summary>
        /// 读写PLC访问功能码类型
        /// </summary>
        public abstract Enum PLCRWType { get; set; }
        /// <summary>
        /// 读取PLC的具体地址
        /// </summary>
        public abstract string PLCRWAddresses { get; set; }
        /// <summary>
        /// 是否开启读写模式
        /// </summary>
        public abstract bool Read_write { get; set; }
        /// <summary>
        /// 需要写PLC的类型
        /// </summary>
        public abstract PLC PLCW { get; set; }
        /// <summary>
        /// 写PLC访问功能码类型
        /// </summary>
        public abstract Enum PLCWType { get; set; }
        /// <summary>
        /// 取PLC的具体地址
        /// </summary>
        public abstract string PLCWAddresses { get; set; }
        /// <summary>
        /// 指示着当前控件是寄存器还是位模式
        /// </summary>
        public abstract bool D_Bit { get; set; }
    }
}
