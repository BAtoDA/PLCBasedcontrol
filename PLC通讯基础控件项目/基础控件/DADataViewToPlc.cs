//**********************************************************************
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
using PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLC表格控件实现类;
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
                  //处理PLC通讯部分
                  if (!this.PLC_Enable || this.IsDisposed || this.Created == false|| DesignMode) return;//用户不开启PLC功能
                  else
                  {
                       controlPLCDataViewBase = new ControlPLCDataViewBase(this);
                      //PLCDataViewForm pLCpropertyBit = new PLCDataViewForm(this, this);
                      //pLCpropertyBit.StartPosition = FormStartPosition.CenterParent;
                      //pLCpropertyBit.ShowDialog();
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
        #region 实现接口参数
        ControlPLCDataViewBase controlPLCDataViewBase;
        object oj=new object();
        /// <summary>
        /// 读取控制
        /// </summary>
        public bool ReadCommand
        {
            get => readCommand;
            set
            {
                //代码底层触发事件
                lock (oj)
                {
                    if (controlPLCDataViewBase != null)
                        controlPLCDataViewBase.GetPLC();
                }
            }
        }
        bool readCommand;
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
        System.Threading.Timer PLCTimer { get; set; }
        [Browsable(false)]
        public event EventHandler Modification;
        #endregion
        public void Modifications_Eeve(object send, EventArgs e)
        {
            this.Modification -= new EventHandler(Modifications_Eeve);
            //var Copy = this.pLCDataViewselectRealize.GetType().GetProperties();
            //PLCDataViewselectRealize bitselectRealize = new PLCDataViewselectRealize();
            //var CopyTo = bitselectRealize.GetType().GetProperties();
            //for (int i = 0; i < Copy.Length; i++)
            //{
            //    CopyTo[i] = Copy[i];
            //}
            //----------------复制该对象的属性---------------
            var Copy = pLCDataViewselectRealize.GetType().GetProperties();
            PLCDataViewClassBase PlcBitselectCopy = new DADataViewToPlc
            {
                pLCDataViewselectRealize = (PLCDataViewselectRealize)Activator.CreateInstance(pLCDataViewselectRealize.GetType())
            };

            for (int i = 0; i < Copy.Length; i++)
            {
                PlcBitselectCopy.pLCDataViewselectRealize.GetType().GetProperties()[i].SetValue(PlcBitselectCopy.pLCDataViewselectRealize, Copy[i].GetValue(pLCDataViewselectRealize));
            }
            this.BeginInvoke((MethodInvoker)delegate
            {
                PLCDataViewForm pLCpropertyBit = new PLCDataViewForm(PlcBitselectCopy, this)
                {
                    StartPosition = FormStartPosition.CenterParent
                };
                pLCpropertyBit.ShowDialog();
                if (pLCpropertyBit.Save)
                {
                    //-------------放回对象属性----------------
                    var Copy = PlcBitselectCopy.pLCDataViewselectRealize.GetType().GetProperties();
                    for (int i = 0; i < Copy.Length; i++)
                    {
                        pLCDataViewselectRealize.GetType().GetProperties()[i].SetValue(pLCDataViewselectRealize, Copy[i].GetValue(PlcBitselectCopy.pLCDataViewselectRealize));
                    }
                }

                this.Invoke((MethodInvoker)delegate
                {
                //参数修改完成--行列进行显示更新--
                this.Rows.Clear();
                    this.Columns.Clear();
                    for (int i = 0; i < this.pLCDataViewselectRealize.DataGridView_Name.Length; i++)
                    {
                        DataGridViewTextBoxColumn textboxcell = new DataGridViewTextBoxColumn
                        {
                            HeaderText = this.pLCDataViewselectRealize.DataGridView_Name[i],
                            ToolTipText = this.pLCDataViewselectRealize.DataGridView_Name[i],
                            ReadOnly = true
                        };
                        this.Columns.Add(textboxcell);
                    }
                    if (this.pLCDataViewselectRealize.DataGridViewPLC_Time)
                    {
                        //用户开启了 时间显示
                        DataGridViewTextBoxColumn textboxcell = new DataGridViewTextBoxColumn
                        {
                            HeaderText = "更新时间",
                            ToolTipText = "更新时间",
                            ReadOnly = true
                        };
                        this.Columns.Add(textboxcell);
                    }
                });
            });
        }
    }
}
