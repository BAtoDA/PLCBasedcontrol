using System;
using System.Collections.Generic;
using System.Text;
using PLC通讯基础控件项目.控件类基.控件数据结构;
using PLC通讯库.通讯枚举;
using System.ComponentModel;

namespace PLC通讯基础控件项目.控件类基.PLC基础接口.表格控件_TO_PLC
{
    interface DataGridViewPLC_base
    {
        /// <summary>
        /// 读取或者写入PLC类型
        /// </summary>
        PLC[] ReadWritePLC { get; set; }
        /// <summary>
        /// 读取或者写入PLC的功能码
        /// </summary>
        string[] ReadWriteFunction { get; set; }
        /// <summary>
        /// 需要访问的PLC地址
        /// </summary>
        string[] PLC_address { get; set; }
        /// <summary>
        /// 显示表格的名称
        /// </summary>
        string[] DataGridView_Name { get; set; }
        /// <summary>
        /// 表格对应的数据类型
        /// </summary>
        numerical_format[] DataGridView_numerical { get; set; }
        /// <summary>
        /// 是否显示读取时间
        /// </summary>
        bool DataGridViewPLC_Time { get; set; }
        /// <summary>
        /// 读取控制
        /// </summary>
        bool ReadCommand { get; set; }
        /// <summary>
        /// 控件绑定开启
        /// 开启后需要选中目标窗口的一个Button类型控件作为触发点
        /// </summary>
        bool BindingOpen { get; set; }
        /// <summary>
        /// 判断控件的Name名称
        /// </summary>
        string BindingName { get; set; }
        /// <summary>
        /// 是否开启SQL数据库
        /// </summary>
        bool SQLOpen { get; set; }
        /// <summary>
        /// 选择数据库类型
        /// true是SQLServer  
        /// false是SQLLite  
        /// </summary>
        bool SQLServer_SQLinte { get; set; }
        /// <summary>
        /// SQL链接字符串
        /// </summary>
        string SQLCharacter { get; set; }

    }
}
