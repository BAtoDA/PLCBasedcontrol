using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;

namespace PLC通讯基础控件项目.控件类基.PLC基础接口
{  
    /// <summary>
   /// 该接口是用于寄存器基础类型参数-比如字体颜色-内容等
   /// </summary>
    interface PLCDproperty
    {
        /// <summary>
        /// 文本颜色
        /// </summary>
        [Browsable(false)]
        Color TextColor_0 { get; set; }
        /// <summary>
        /// 文字内容
        /// </summary>
        [Browsable(false)]
        string TextContent_0 { get; set; }
        /// <summary>
        /// 文本颜色
        /// </summary>
        [Browsable(false)]
        Color TextColor_1 { get; set; }
        /// <summary>
        /// 文字内容
        /// </summary>
        [Browsable(false)]
        string TextContent_1 { get; set; }
        /// <summary>
        /// 控件刷新定时器
        /// </summary>
        [Browsable(false)]
        System.Threading.Timer PLCTimer { get; set; }
    }
}
