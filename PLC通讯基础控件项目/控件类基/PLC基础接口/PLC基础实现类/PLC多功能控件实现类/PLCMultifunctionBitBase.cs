using PLC通讯基础控件项目.控件类基.控件数据结构;
using System;
using System.Collections.Generic;
using System.Text;

namespace PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLC多功能控件实现类
{
    /// <summary>
    /// 功能键位操作基础接口
    /// </summary>
    public interface PLCMultifunctionBitBase
    {
        /// <summary>
        /// 按钮操作模式
        /// </summary>
        string ValueBit { get; set; }
        /// <summary>
        /// 读取或者写入PLC类型
        /// </summary>
        PLC ReadWriteBitPLC { get; set; }
        /// <summary>
        /// 读取或者写入PLC的功能码
        /// </summary>
        string ReadWriteBitFunction { get; set; }
        /// <summary>
        /// 读取或者写入PLC的具体地址
        /// </summary>
        string ReadWriteBitAddress { get; set; }
        /// <summary>
        /// 输出模式-输出反向
        /// </summary>
        bool OutReverse { get; set; }
    }
}
