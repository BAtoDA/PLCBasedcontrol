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
    public interface PLCDproperty
    {
        /// <summary>
        /// 文字状态--0-字体对齐方式
        /// </summary>
        string Textalign_0 { get; set; }
        [Browsable(false)]
        /// <summary>
        /// 文字属性--字体-尺寸-
        /// </summary>
        Font TextFont_0 { get; set; }
        [Browsable(false)]
        /// <summary>
        /// 文字状态--0-字体对齐方式
        /// </summary>
        string Textalign_1 { get; set; }
        [Browsable(false)]
        /// <summary>
        /// 文字属性--字体-尺寸-
        /// </summary>
        Font TextFont_1 { get; set; }
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
        /// <summary>
        /// 写入值 格式由设置好的格式 可更改
        /// 格式由最初设置
        /// </summary>
        [Browsable(true)]
         bool WrietCommand { set; }
    }
}
