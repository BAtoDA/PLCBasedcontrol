using PLC通讯基础控件项目.控件类基.控件数据结构;
using PLC通讯库.通讯枚举;
using System;
using System.Collections.Generic;
using System.Text;

namespace PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLC多功能控件实现类
{
    /// <summary>
    /// 功能键寄存器操作基础接口
    /// </summary>
    public interface PLCMultifunctionDBase
    {
        /// <summary>
        /// 读取或者写入PLC类型
        /// </summary>
        PLC ReadWriteDPLC { get; set; }
        /// <summary>
        /// 读取或者写入PLC的功能码
        /// </summary>
        string ReadWriteDFunction { get; set; }
        /// <summary>
        /// 读取或者写入PLC的具体地址
        /// </summary>
        string ReadWriteDAddress { get; set; }
        /// <summary>
        /// 写入值
        /// </summary>
        int Value { get; set; }
        //------数据格式------//
        /// <summary>
        /// 数据格式显示的资料格式
        /// </summary>
        numerical_format ShowFormat { get; set; }
    }
}
