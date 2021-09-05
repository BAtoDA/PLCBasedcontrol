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
using PLC通讯库.PLC通讯设备类型表;
using PLC通讯库.通讯实现类;

namespace PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类
{
    /// <summary>
    /// 实现基本控件类--PLC刷新--文字事件等处理
    /// </summary>
    public sealed partial class ControlPLCBitBase 
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

        /// <summary>
        /// PLC刷新处理
        /// </summary>
        public  void PLCrefresh()
        {
            if (pLCBitClassBase==null) throw new Exception($" 不实现：PLCBitBase接口");
            if (pLCBitproperty==null) throw new Exception($" 不实现：PLCBitproperty接口");
            if (IPLCsurface.PLCDictionary.Count < 1 ||! IPLCsurface.PLCDictionary.ContainsKey(pLCBitClassBase.pLCBitselectRealize.ReadWritePLC.ToString())) throw new Exception("PLC通讯表为空");
            //读取PLC--自动获取对象的PLC类型对象
            IPLCcommunicationBase PLCoop = IPLCsurface.PLCDictionary.GetValueOrDefault(pLCBitClassBase.pLCBitselectRealize.ReadWritePLC.ToString()) as IPLCcommunicationBase;
            var State= PLCoop.PLC_read_M_bit(pLCBitClassBase.pLCBitselectRealize.ReadWriteFunction, pLCBitClassBase.pLCBitselectRealize.ReadWriteAddress);
            //处理状态颜色
            if (State)
            {
                pLCBitproperty.backgroundColor_0 = pLCBitClassBase.pLCBitselectRealize.backgroundColor_0;
                pLCBitproperty.TextContent_0 = pLCBitClassBase.pLCBitselectRealize.TextContent_0;
                pLCBitproperty.TextColor_0 = pLCBitClassBase.pLCBitselectRealize.TextColor_0;
            }
            else
            {
                pLCBitproperty.backgroundColor_1 = pLCBitClassBase.pLCBitselectRealize.backgroundColor_1;
                pLCBitproperty.TextContent_1 = pLCBitClassBase.pLCBitselectRealize.TextContent_1;
                pLCBitproperty.TextColor_1 = pLCBitClassBase.pLCBitselectRealize.TextColor_1;
            }
        }
    }
}
