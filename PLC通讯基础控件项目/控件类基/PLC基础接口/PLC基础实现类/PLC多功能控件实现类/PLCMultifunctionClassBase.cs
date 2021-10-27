using PLC通讯基础控件项目.控件类基.控件数据结构;
using PLC通讯库.通讯枚举;
using System;
using System.Collections.Generic;
using System.Text;

namespace PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLC多功能控件实现类
{
    /// <summary>
    /// 多功能控件类基
    /// </summary>
    public class PLCMultifunctionClassBase : PLCmMltifunctionFunctionBase, PLCMultifunctionBitBase, PLCMultifunctionDBase
    {
        #region 实现功能键接口
        public string FormPath { get; set; }= "PLC通讯基础控件项目.模板与控制界面";
        public string FormName { get; set; } = "TemplateForm";
        #endregion
        #region 实现Bit位接口
        public string ValueBit { get; set; } = "ON";
        public PLC ReadWriteBitPLC { get; set; } = PLC.Mitsubishi;
        public string ReadWriteBitFunction { get; set; } = "M";
        public string ReadWriteBitAddress { get; set; }= "0";
        public bool OutReverse { get; set; } = false;
        #endregion
        #region 实现D寄存器接口
        public PLC ReadWriteDPLC { get; set; } = PLC.Mitsubishi;
        public string ReadWriteDFunction { get; set; } = "D";
        public string ReadWriteDAddress { get; set; } = "0";
        public int Value { get; set; } = 0;
        public numerical_format ShowFormat { get; set; } = numerical_format.Signed_16_Bit;
        #endregion
        /// <summary>
        /// 默认实现的接口
        /// </summary>
        public string ClassInterface { get; set; } = "PLCMultifunctionBitBase";
    }
}
