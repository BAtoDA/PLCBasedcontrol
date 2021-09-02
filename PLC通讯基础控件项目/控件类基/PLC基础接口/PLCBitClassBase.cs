using System;
using System.Collections.Generic;
using System.Text;
using PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类;

namespace PLC通讯基础控件项目.控件类基.PLC基础接口
{
    /// <summary>
    /// 控件修改参数界面
    /// </summary>
    interface PLCBitClassBase
    {
        /// <summary>
        /// 修改参数界面启动事件
        /// </summary>
        event EventHandler Modification;
        /// <summary>
        /// 修改参数界面方法
        /// </summary>
        /// <param name="send"></param>
        /// <param name="e"></param>
        void Modifications_Eeve(object send, EventArgs e);
        /// <summary>
        /// 用于处理控件参数
        /// </summary>
        PLCBitselectRealize pLCBitselectRealize { get; set; }
        /// <summary>
        /// 用于给用户选择PLC使用
        /// </summary>
        int PLCs { get; set; }
    }
}
