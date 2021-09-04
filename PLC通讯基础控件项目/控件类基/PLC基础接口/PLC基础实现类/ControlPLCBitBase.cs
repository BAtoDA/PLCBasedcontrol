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
    public partial class ControlPLCBitBase : Control
    {
        #region 实现基本接口  
        //基础外部文本颜色 与 内容控制
        /// <summary>
        /// 控件保存的参数
        /// </summary>
        PLCBitClassBase pLCBitClassBase;
        /// <summary>
        /// 控件外部文字已经背景颜色等参数
        /// </summary>
        PLCBitproperty pLCBitproperty;
        #endregion
        /// <summary>
        /// 构造函数
        /// </summary>
        public ControlPLCBitBase(Control PlcControl)
        {
            if (!(PlcControl is PLCBitClassBase)) throw new Exception($"{PlcControl.GetType().Name} 不实现：PLCBitBase接口");
            if (!(PlcControl is PLCBitproperty)) throw new Exception($"{PlcControl.GetType().Name} 不实现：PLCBitproperty接口");
            pLCBitClassBase = PlcControl as PLCBitClassBase;
            pLCBitproperty = PlcControl as PLCBitproperty;
        }

        public event EventHandler Modification;

        public void Modifications_Eeve(object send, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
