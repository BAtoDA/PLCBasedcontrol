//**********************************************************************
//
// 文件名称(File Name)：
// 功能描述(Description)：
// 作者(Author)：DAtoTA
// 日期(Create Date)： 2021/9/3 15:20:18
//
//**********************************************************************
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading;
using PLC通讯基础控件项目.控件类基.PLC基础接口;

namespace PLC通讯基础控件项目.控件类基.控件数据结构
{
    /// <summary>
    /// 主要实现PLCBitproperty接口
    /// 用于处理控件选择保存0 1 控件文本背景颜色等参数
    /// </summary>
    class PLCselectTextBase : PLCBitproperty
    {
        public Color backgroundColor_0 { get; set; } = Color.FromArgb(80, 160, 255);
        public Color TextColor_0 { get; set; } = Color.FromName("LightGray");
        public string TextContent_0 { get; set; }
        public Color backgroundColor_1 { get; set; } = Color.FromArgb(80, 160, 255);
        public Color TextColor_1 { get; set; } = Color.FromName("LightGray");
        public string TextContent_1 { get; set; }
        //标签控制-----
        /// <summary>
        /// 文字状态--0-字体对齐方式
        /// </summary>
        public string Textalign_0 { get; set; }
        /// <summary>
        /// 文字属性--字体-尺寸-
        /// </summary>  
        public Font TextFont_0 { get; set; }
        /// <summary>
        /// 文本是否闪烁
        /// </summary>
        public int Textflicker_0 { get; set; }
        /// <summary>
        /// 文字是否是斜体
        /// </summary>
        public bool TextItalic_0 { get; set; }
        /// <summary>
        /// 文本文字是否有下划线
        /// </summary>
        public bool TextUnderline_0 { get; set; }
        /// <summary>
        /// 文字状态--1-字体对齐方式
        /// </summary>
        public string Textalign_1 { get; set; }
        /// <summary>
        /// 文字属性--字体-尺寸-
        /// </summary>
        public Font TextFont_1 { get; set; }
        /// <summary>
        /// 文本是否闪烁
        /// </summary>
        public int Textflicker_1 { get; set; }
        /// <summary>
        /// 文字是否是斜体
        /// </summary>
        public bool TextItalic_1 { get; set; }
        /// <summary>
        /// 文本文字是否有下划线
        /// </summary>
        public bool TextUnderline_1 { get; set; }
        public Timer PLCTimer { get; set; }
    }
}
