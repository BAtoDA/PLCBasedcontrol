﻿//**********************************************************************
//
// 文件名称(File Name)：
// 功能描述(Description)：
// 作者(Author)：DAtoTA
// 日期(Create Date)： 2021/9/23 16:54:10
//
//**********************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using PLC通讯基础控件项目.控件类基.PLC基础接口.表格控件_TO_PLC;
using PLC通讯基础控件项目.控件类基.控件地址选择窗口.表格控件参数界面;
using PLC通讯基础控件项目.控件类基.控件数据结构;
using Sunny.UI;

namespace PLC通讯基础控件项目.基础控件
{
    /// <summary>
    /// 表格视图控件 
    /// </summary>
    public partial class DADataViewToPlc : UIDataGridView, PLCDataViewClassBase
    {
        public DADataViewToPlc()
        {
            Timerconfiguration.Tick += ((send, e) =>
              {
                  Timerconfiguration.Stop();
                  //PLC_Enable = true;
                  //处理PLC通讯部分
                  if (!this.PLC_Enable || this.IsDisposed || this.Created == false) return;//用户不开启PLC功能
                  {
                      PLCDataViewForm pLCpropertyBit = new PLCDataViewForm(this, this);
                      pLCpropertyBit.StartPosition = FormStartPosition.CenterParent;
                      pLCpropertyBit.ShowDialog();
                  }
              });
        }
    }
    /// <summary>
    /// 表格视图控件 
    /// </summary>
    [ToolboxItem(true)]
    public partial class DADataViewToPlc : UIDataGridView, PLCDataViewClassBase
    {
        [Browsable(false)]
        [Description("PLC保存参数"), Category("PLC类型")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public PLCDataViewselectRealize pLCDataViewselectRealize 
        {
            get => pLCDataViewselec;
            set => pLCDataViewselec=value;
        }
        private PLCDataViewselectRealize pLCDataViewselec { get; set; } = new PLCDataViewselectRealize();
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
        public Timer Timerconfiguration { get; set; } = new Timer() { Enabled = true, Interval = 300 };
        [Browsable(false)]
        public event EventHandler Modification;

        public void Modifications_Eeve(object send, EventArgs e)
        {
            this.Modification -= new EventHandler(Modifications_Eeve);
            var Copy = this.pLCDataViewselectRealize.GetType().GetProperties();
            PLCDataViewselectRealize bitselectRealize = new PLCDataViewselectRealize();
            var CopyTo = bitselectRealize.GetType().GetProperties();
            for (int i = 0; i < Copy.Length; i++)
            {
                CopyTo[i] = Copy[i];
            }
            PLCDataViewForm pLCpropertyBit = new PLCDataViewForm(this,this);
            pLCpropertyBit.StartPosition = FormStartPosition.CenterParent;
            pLCpropertyBit.ShowDialog();
            if (!pLCpropertyBit.Save)
            {
                for (int i = 0; i < Copy.Length; i++)
                {
                    Copy[i] = CopyTo[i];
                }
            }

        }
    }
}
