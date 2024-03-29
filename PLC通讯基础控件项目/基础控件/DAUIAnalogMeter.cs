﻿//**********************************************************************
//
// 文件名称(File Name)：
// 功能描述(Description)：
// 作者(Author)：DAtoTA
// 日期(Create Date)： 2021/9/18 14:35:07
//
//**********************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using PLC通讯基础控件项目.基础控件.底层PLC状态监控控件;
using PLC通讯基础控件项目.控件类基.PLC基础接口;
using PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLCD只读控件实现类;
using PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLCD控件实现类;
using PLC通讯基础控件项目.控件类基.控件地址选择窗口;
using PLC通讯基础控件项目.控件类基.控件数据结构;
using Sunny.UI;

namespace PLC通讯基础控件项目.基础控件
{
    /// <summary>
    /// 表盘控件
    /// </summary>
    public partial  class DAUIAnalogMeter
    {
        public DAUIAnalogMeter()
        {
            Timerconfiguration.Tick += ((send, e) =>
            {
                Timerconfiguration.Stop();
                //处理PLC通讯部分
                //if (!this.PLC_Enable || this.IsDisposed || this.Created == false|| DesignMode) return;//用户不开启PLC功能
                if (!this.PLC_Enable || this.IsDisposed || DesignMode) return;//用户不开启PLC功能
                {
                    //ControlDebug.Write($"开始加载：{this.Name}控件 归属PLC是：{this.pLCDselectRealize.ReadWritePLC}");
                    ControlPLCDonlyBase controlPLCD = new ControlPLCDonlyBase(this);
                    //ControlDebug.Write($"加载完成：{this.Name}控件 归属PLC是：{this.pLCDselectRealize.ReadWritePLC}");
                }
                //立马刷新状态
                this.SuspendLayout();
                this.TextContent_0 = this.pLCDselectRealize.TextContent_0;
                this.TextColor_0 = this.pLCDselectRealize.TextColor_0;
                this.Refresh();
                this.ResumeLayout(false);
            });
        }

    }
    [ToolboxItem(true)]
    [Browsable(true)]
    public partial class DAUIAnalogMeter : UIAnalogMeter, PLCDClassBase, PLCDproperty, ICloneable
    {
        #region 实现接口参数
        [Browsable(false)]
        public event EventHandler Modification;
        [Browsable(false)]
        [Description("PLC保存参数"), Category("PLC类型")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PLCDselectRealize pLCDselectRealize
        {
            get => pLCBitselectsq;
            set => pLCBitselectsq = value;
        }
        /// <summary>
        /// 私有保存参数 自动添加
        /// </summary>
        private PLCDselectRealize pLCBitselectsq { get; set; } = new PLCDselectRealize();
        [Description("选择PLC类型\r\n默认三菱PLC"), Category("PLC类型")]
        [Browsable(true)]
        public PLCSet APLC
        {
            get => PLCsz;
            set
            {
                if (plc_Enable)
                {
                    this.Modification += new EventHandler(Modifications_Eeve);
                    this.Modification(this, new EventArgs());
                    this.Modification -= new EventHandler(Modifications_Eeve);
                    return;
                }
                this.Modification -= new EventHandler(Modifications_Eeve);
            }

        }
        /// <summary>
        /// 私有设置PLC参数
        /// </summary>
        private PLCSet PLCsz = 0;
        /// <summary>
        /// 是否启用PLC功能
        /// </summary>
        [Browsable(true)]
        [Description("是否启用PLC功能"), Category("PLC类型")]
        public bool PLC_Enable
        {
            get => plc_Enable;
            set => plc_Enable = value;
        }
        private bool plc_Enable = false;
        [Browsable(false)]
        public bool ReadOnly { get; set; }
        [Browsable(false)]
        public string Textalign_0 { get; set; }
        [Browsable(false)]
        public Font TextFont_0 { get => pLCDselectRealize.TextFont_0; set => this.Font = value; }
        [Browsable(false)]
        public string Textalign_1 { get; set; }
        [Browsable(false)]
        public Font TextFont_1 { get => pLCDselectRealize.TextFont_0; set => this.Font = value; }
        [Browsable(false)]
        public Color TextColor_0 { get; set; }
        [Browsable(false)]
        public string TextContent_0 
        { 
            get => pLCDselectRealize.TextContent_0;
            set
            {
                int Data = 0;
                if (int.TryParse(value, out Data))
                    this.Value = Data;
            }
        }
        [Browsable(false)]
        public Color TextColor_1 { get; set; }
        [Browsable(false)]
        public string TextContent_1 
        {
            get => pLCDselectRealize.TextContent_1;
            set
            {
                int Data = 0;
                if (int.TryParse(value, out Data))
                    this.Value = Data;
            }
        }
        [Browsable(false)]
        public System.Threading.Timer PLCTimer { get; set; }
        public System.Windows.Forms.Timer Timerconfiguration { get; set; } = new System.Windows.Forms.Timer() { Enabled = true, Interval = 300 };

        /// <summary>
        /// 修改参数界面窗口事件方法
        /// </summary>
        /// <param name="send"></param>
        /// <param name="e"></param>

        public void Modifications_Eeve(object send, EventArgs e)
        {
            this.Modification -= new EventHandler(Modifications_Eeve);
            //----------------复制该对象的属性---------------
            var Copy = pLCDselectRealize.GetType().GetProperties();

            PLCDselectRealize PlcBitselectCopy = (PLCDselectRealize)Activator.CreateInstance(pLCDselectRealize.GetType());

            for (int i = 0; i < Copy.Length; i++)
            {
                PlcBitselectCopy.GetType().GetProperties()[i].SetValue(PlcBitselectCopy, Copy[i].GetValue(pLCDselectRealize));
            }
            this.BeginInvoke((MethodInvoker)delegate
            {
                PLCpropertyD pLCpropertyBit = new PLCpropertyD(PlcBitselectCopy)
                {
                    StartPosition = FormStartPosition.CenterParent
                };

                pLCpropertyBit.ShowDialog();
                if (pLCpropertyBit.Save)
                {
                    //-------------放回对象属性----------------
                    var Copy = PlcBitselectCopy.GetType().GetProperties();
                    for (int i = 0; i < Copy.Length; i++)
                    {
                        pLCDselectRealize.GetType().GetProperties()[i].SetValue(pLCDselectRealize, Copy[i].GetValue(PlcBitselectCopy));
                    }
                }
                this.Invoke((MethodInvoker)delegate
                {
                //立马刷新状态
                this.SuspendLayout();
                    this.TextContent_0 = this.pLCDselectRealize.TextContent_0;
                    this.TextColor_0 = this.pLCDselectRealize.TextColor_0;
                    this.Refresh();
                    this.ResumeLayout(false);
                });
            });
        }
        /// <summary>
        /// 复制控件方法
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return this;
        }
        #endregion
        #region 新增代码层写入值
        /// <summary>
        /// PLC写入底层对象
        /// </summary>
        ControlPLCDBase controlPLCDBase;
        /// <summary>
        /// 代码层写入
        /// </summary>
        object PLClock = new object();
        /// <summary>
        /// 写入值 格式由设置好的格式 可更改
        /// </summary>
        [Browsable(false)]
        [ToolboxItem(false)]
        public virtual bool WrietCommand
        {
            set
            {
                //进行写入操作
                lock (PLClock)
                {
                    if (controlPLCDBase != null)
                    {
                        //触发写入事件---这里的操作相当点击
                        var DataValue = pLCDselectRealize.Keyboard;//获取以前值
                        this.Text = this.Text.Length < 1 ? "0" : this.Text == "" ? "0" : this.Text;
                        //写入当前控件值
                        controlPLCDBase.PLCWrite(this.pLCDselectRealize.ReadWrite ? this.pLCDselectRealize.WritePLC : this.pLCDselectRealize.ReadWritePLC, this.pLCDselectRealize.ReadWrite ?
                            this.pLCDselectRealize.WriteFunction : this.pLCDselectRealize.ReadWriteFunction, this.pLCDselectRealize.ReadWrite ? this.pLCDselectRealize.WriteAddress : this.pLCDselectRealize.ReadWriteAddress, this.Text, this.pLCDselectRealize.ShowFormat);
                    }

                }
            }
        }
        #endregion

    }
}
