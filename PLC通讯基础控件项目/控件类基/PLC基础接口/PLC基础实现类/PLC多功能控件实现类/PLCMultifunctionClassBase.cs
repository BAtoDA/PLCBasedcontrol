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
        string PLCmMltifunctionFunctionBase.FormPath { get; set; }= "PLC通讯基础控件项目.模板与控制界面";
        string PLCmMltifunctionFunctionBase.FormName { get; set; } = "TemplateForm";
        #endregion
        #region 实现Bit位接口
        Button_pattern PLCMultifunctionBitBase.Pattern { get; set; } = Button_pattern.Set_as_on;
        PLC PLCMultifunctionBitBase.ReadWritePLC { get; set; } = PLC.Mitsubishi;
        string PLCMultifunctionBitBase.ReadWriteFunction { get; set; } = "M";
        string PLCMultifunctionBitBase.ReadWriteAddress { get; set; } = "0";
        bool PLCMultifunctionBitBase.OutReverse { get; set; } = false;
        #endregion
        #region 实现D寄存器接口
        PLC PLCMultifunctionDBase.ReadWritePLC { get; set; } = PLC.Mitsubishi;
        string PLCMultifunctionDBase.ReadWriteFunction { get; set; } = "D";
        string PLCMultifunctionDBase.ReadWriteAddress { get; set; } = "0";
        int PLCMultifunctionDBase.Value { get; set; } = 0;
        numerical_format PLCMultifunctionDBase.ShowFormat { get; set; } = numerical_format.Signed_16_Bit;
        #endregion
        /// <summary>
        /// 默认实现的接口
        /// </summary>
        public string ClassInterface { get; set; } = "PLCMultifunctionBitBase";
    }
}
