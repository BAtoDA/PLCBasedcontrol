using System;
using System.Collections.Generic;
using System.Text;

namespace PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLC多功能控件实现类
{
    /// <summary>
    /// 多功能键 
    /// 窗口切换接口
    /// </summary>
    public interface PLCmMltifunctionFunctionBase
    {
        /// <summary>
        /// 需要反射窗口的路径
        /// </summary>
        public string FormPath { get; set; }
        /// <summary>
        /// 需要反射窗口的名称
        /// </summary>
        public string FormName{ get; set; }
    }
}
