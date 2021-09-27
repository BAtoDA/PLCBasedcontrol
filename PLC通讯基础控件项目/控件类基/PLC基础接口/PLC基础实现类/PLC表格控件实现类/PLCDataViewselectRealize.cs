//**********************************************************************
//
// 文件名称(File Name)：
// 功能描述(Description)：
// 作者(Author)：DAtoTA
// 日期(Create Date)： 2021/9/21 15:38:12
//
//**********************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using PLC通讯基础控件项目.控件类基.控件数据结构;
using PLC通讯库.通讯枚举;

namespace PLC通讯基础控件项目.控件类基.PLC基础接口.表格控件_TO_PLC
{
    /// <summary>
    /// 主要用于处理位控件保存参数使用
    /// </summary>
    [Serializable]
    public sealed class PLCDataViewselectRealize : DataGridViewPLC_base
    {
        public PLC[] ReadWritePLC { get; set; } = new PLC[] { PLC.Mitsubishi, PLC.Mitsubishi, PLC.Mitsubishi, PLC.Mitsubishi };
        public string[] ReadWriteFunction { get; set; } = new string[] { "D", "D", "D", "D" };
        public string[] PLC_address { get; set; } = new string[] { "0", "0", "0" ,"0"};
        public string[] DataGridView_Name { get; set; } = new string[] { "Name", "Valeu1", "Valeu2", "Valeu3" };
        public numerical_format[] DataGridView_numerical { get; set; } = new numerical_format[] { numerical_format.Signed_32_Bit, numerical_format.Signed_32_Bit, numerical_format.Signed_32_Bit, numerical_format.Signed_32_Bit };
        public string[] SQLsurfaceType { get; set; } = new string[] { "String", "String", "String", "String" };
        public bool DataGridViewPLC_Time { get; set; } = false;
        public bool ReadCommand { get; set; } = false;
        public bool BindingOpen { get; set; } = false;
        public string BindingName { get; set; }
        public bool SQLOpen { get; set; } = false;
        public bool SQLServer_SQLinte { get; set; } = false;
        public string SQLCharacter { get; set; }
        public string SQLsurface { get; set; }
    }
}
