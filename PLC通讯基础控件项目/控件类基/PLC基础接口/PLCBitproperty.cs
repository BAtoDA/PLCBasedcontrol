using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;

namespace PLC通讯基础控件项目.控件类基.PLC基础接口
{
    /// <summary>
    /// 该接口是用于位基础类型参数-比如字体背景颜色-内容等
    /// </summary>
    public interface PLCBitproperty
    {
        [Browsable(false)]
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
        /// 背景颜色
        /// </summary>
        [Browsable(false)]
        Color backgroundColor_0 { get; set; }
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
        /// 背景颜色
        /// </summary>
        [Browsable(false)]
        Color backgroundColor_1 { get; set; }
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
