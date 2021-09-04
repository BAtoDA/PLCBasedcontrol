//**********************************************************************
//
// 文件名称(File Name)：
// 功能描述(Description)：
// 作者(Author)：DAtoTA
// 日期(Create Date)： 2021/8/29 10:55:47
//
//**********************************************************************
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PLC通讯基础控件项目.控件类基.控件数据结构;

namespace PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类
{
    /// <summary>
    /// 实现基本控件类--PLC刷新--文字事件等处理
    /// </summary>
    public partial class ControlPLCBitBase : Control, PLCBitClassBase, PLCBitproperty
    {
        #region 实现基本接口  
        //基础外部文本颜色 与 内容控制
        public Color backgroundColor_0 { get; set; }
        public Color TextColor_0 { get; set; }
        public string TextContent_0 { get; set; }
        public Color backgroundColor_1 { get; set; }
        public Color TextColor_1 { get; set; }
        public string TextContent_1 { get; set; }
        public System.Threading.Timer PLCTimer { get; set; }
        public PLCBitselectRealize pLCBitselectRealize { get; set; } = new PLCBitselectRealize();
        public PLCSet APLC { get; set; }
        #endregion
        /// <summary>
        /// 构造函数
        /// </summary>
        public ControlPLCBitBase()
        {

        }

        public event EventHandler Modification;

        public void Modifications_Eeve(object send, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
