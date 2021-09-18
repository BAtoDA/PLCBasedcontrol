//**********************************************************************
//
// 文件名称(File Name)：
// 功能描述(Description)：
// 作者(Author)：DAtoTA
// 日期(Create Date)： 2021/9/18 23:13:12
//
//**********************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using PLC通讯基础控件项目.控件类基.控件数据结构;
using PLC通讯库.PLC通讯设备类型表;
using PLC通讯库.通讯基础接口;
using PLC通讯库.通讯实现类;

namespace PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLCD只读控件实现类
{
    /// <summary>
    /// 实现基本寄存器控件类--PLC刷新--只读
    /// </summary>
    public sealed partial class ControlPLCDonlyBase : BasepublicClass
    {
        #region 实现基本接口  
        //基础外部文本颜色 与 内容控制
        /// <summary>
        /// 控件保存的参数
        /// </summary>
        PLCDClassBase pLCDClassBase;
        /// <summary>
        /// 控件外部文字已经背景颜色等参数
        /// </summary>
        PLCDproperty pLCDproperty;
        /// <summary>
        /// 安全控制状态--true正确 false 异常
        /// </summary>
        bool SafetyPattern;
        /// <summary>
        /// 控件对象
        /// </summary>
        Control PlcControl;
        /// <summary>
        /// 复归型按钮标志位
        /// </summary>
        private volatile bool State = false;
        /// <summary>
        /// PLC安全操作模式
        /// </summary>
        volatile Safetypattern PLCsafetypattern = Safetypattern.Nooperation;
        /// <summary>
        /// 用于判断用户是否停止输入文本
        /// </summary>
        private System.Windows.Forms.Timer KeyTime = new System.Windows.Forms.Timer() { Interval = 800 };
        private bool Focused
        {
            get
            {
                PlcControl.BeginInvoke((MethodInvoker)delegate
                {
                    focused = PlcControl.Focused;
                });
                return focused;
            }
        }
        private volatile bool focused;
        #endregion
        public ControlPLCDonlyBase(Control PlcControl)
        {
            //---------处理控件接口问题---------
            if (!(PlcControl is PLCDClassBase)) throw new Exception($"{PlcControl.GetType().Name} 不实现：PLCDClassBase接口");
            if (!(PlcControl is PLCDproperty)) throw new Exception($"{PlcControl.GetType().Name} 不实现：PLCDproperty接口");
            pLCDClassBase = PlcControl as PLCDClassBase;
            pLCDproperty = PlcControl as PLCDproperty;
            //----------处理控件PLC--自动获取PLC类型对象----------
            PLCoopErr(pLCDClassBase, pLCDproperty);
            this.PlcControl = PlcControl;
           
            //----------处理控件与PLC事件处理---------------------
            if (((dynamic)PlcControl).PLC_Enable)
            {
                pLCDproperty.PLCTimer = new System.Threading.Timer(new TimerCallback((s) =>
                {
                    this.PLCrefresh();
                }));
                pLCDproperty.PLCTimer.Change(500, 300);
            }
            this.PlcControl.Text = "0";
        }
        /// <summary>
        /// 处理控件值--读取PLC
        /// </summary>
        private void PLCrefresh()
        {
            //lock(this)
            //{
            try
            {
                if (PlcControl.IsDisposed || PlcControl.Created == false || Focused) return;
                PLCoopErr(pLCDClassBase, pLCDproperty);
                IPLC_interface PLCoop = IPLCsurface.PLCDictionary.Where(p => p.Key.Trim() == pLCDClassBase.pLCDselectRealize.ReadWritePLC.ToString().Trim()).FirstOrDefault().Value as IPLCcommunicationBase;
                if (PLCoop == null) return;
                if (!PLCoop.PLC_ready)
                {
                    return;
                }
                var State = PLCoop.PLC_read_D_register(pLCDClassBase.pLCDselectRealize.ReadWriteFunction, pLCDClassBase.pLCDselectRealize.ReadWriteAddress, pLCDClassBase.pLCDselectRealize.ShowFormat);
                //---委托控件----处理状态颜色
                PlcControl.BeginInvoke((MethodInvoker)delegate
                {
                    //处理安全控制---是否要隐藏控件
                    if (!PlcControl.IsHandleCreated || PlcControl.IsDisposed || PlcControl.Created == false) return;
                    this.PlcControl.Visible = PLCsafetypattern == Safetypattern.Hide ? false : true;
                    pLCDproperty.TextContent_0 = complement(State ?? "0");
                });
            }
            catch { }
            //}
        }
        private string complement(string Name)//实现浮点小数自动补码
        {
            if (pLCDClassBase.pLCDselectRealize.NumericaldigitMin < 1) return Name;//返回数据
            string d = string.Empty;
            int minusInde = Name.IndexOf('-');//搜索数据是否有小数点
            int Inde = Name.IndexOf('.');//搜索数据是否有小数点
            //如果有小数点 先移除
            if (Inde > -1)
                Name = Name.Remove(Inde, 1);
            //如果是否负数 先移除符号位
            if (minusInde > -1)
                Name = Name.Remove(minusInde, 1);
            if (pLCDClassBase.pLCDselectRealize.NumericaldigitMin > (Inde > -1 ? Name.Length : Name.Length - 1))
            {
                int forindex = (pLCDClassBase.pLCDselectRealize.NumericaldigitMin - Name.Length) + 1;
                for (int i = 0; i < forindex; i++)
                    Name = Name.Insert(0, "0");//填充数据
            }
            if (Inde == -1)
            {
                if (pLCDClassBase.pLCDselectRealize.NumericaldigitMin < Name.Length)
                {
                    Name = Name.Insert(Name.Length - pLCDClassBase.pLCDselectRealize.NumericaldigitMin, ".");//填充数据
                }
            }
            //补码
            if (minusInde > -1)
                Name = Name = Name.Insert(0, "-");//填充数据
            return Name;//返回数据
        }
    }
}
