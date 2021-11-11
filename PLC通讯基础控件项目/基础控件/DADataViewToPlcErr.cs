using PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLC报警显示控件实现类;
using PLC通讯基础控件项目.控件类基.控件地址选择窗口.设备报警控件参数界面;
using PLC通讯基础控件项目.控件类基.控件数据结构;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace PLC通讯基础控件项目.基础控件
{
    /// <summary>
    /// 显示PLC设备报警内容表
    /// </summary>
    [Browsable(true)]
    [ToolboxItem(true)]
    public sealed partial class DADataViewToPlcErr : UIDataGridView, PLCEvent_messageBase
    {
        IContainer container;
        public DADataViewToPlcErr(IContainer container)
        {
            if (container != null)
            {
                this.container = container;
                foreach (var i in container.Components)
                {
                    if (i is DADataViewToPlcErr) throw new Exception("该控件已经存在无需重复添加");
                }
            }
            container.Add(this);
            Timerconfiguration.Tick += ((send, e) =>
            {
                Timerconfiguration.Stop();
                //处理PLC通讯部分
                if (!this.PLC_Enable || this.IsDisposed || this.Created == false || DesignMode) return;//用户不开启PLC功能
                {
                    new PLCEvent_messageReadlize(this);
                }
                //刷新表格列
                DataLoad();
            });
        }
        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            if (DesignMode)
                DataLoad();
        }
        private void DataLoad()
        {
            this.Columns.Clear();
            DataGridViewTextBoxColumn[] dataGridView = new DataGridViewTextBoxColumn[4];
            dataGridView[0] = new DataGridViewTextBoxColumn();
            dataGridView[0].HeaderText = "发生时间";
            dataGridView[0].Name = "发生时间";
            dataGridView[0].ReadOnly = true;
            dataGridView[0].Visible = true;
            dataGridView[0].Width = TableSize[0];

            dataGridView[1] = new DataGridViewTextBoxColumn();
            dataGridView[1].HeaderText = "报警设备";
            dataGridView[1].Name = "报警设备";
            dataGridView[1].ReadOnly = true;
            dataGridView[1].Visible = true;
            dataGridView[1].Width = TableSize[1];

            dataGridView[2] = new DataGridViewTextBoxColumn();
            dataGridView[2].HeaderText = "报警地址";
            dataGridView[2].Name = "报警地址";
            dataGridView[2].ReadOnly = true;
            dataGridView[2].Visible = true;
            dataGridView[2].Width = TableSize[2];

            dataGridView[3] = new DataGridViewTextBoxColumn();
            dataGridView[3].HeaderText = "报警内容";
            dataGridView[3].Name = "报警内容";
            dataGridView[3].ReadOnly = true;
            dataGridView[3].Visible = true;
            dataGridView[3].Width = TableSize[3];

            this.Columns.AddRange(dataGridView);
        }
    }
    public sealed partial class DADataViewToPlcErr : UIDataGridView, PLCEvent_messageBase
    {
        #region 实现控件宽度
        [Browsable(true)]
        [Description("报警表格控件内容显示的宽度"), Category("PLC类型")]
        public int[] TableSize 
        { 
            get => tableSize;
            set
            {
                if (value.Length < 5)
                {
                    tableSize = value;
                    DataLoad();
                }
            }
        } 
        private int[] tableSize = new int[4] { 100, 130, 100, 300 };
        #endregion
        #region 实现接口参数
        /// <summary>
        /// 读取报警内容
        /// </summary>
        [Browsable(false)]
        [Description("读取报警内容"), Category("PLC类型")]
        public bool ReadCommand { get; set; }
        /// <summary>
        /// 是否启用PLC功能
        /// </summary>
        [Browsable(true)]
        [Description("是否启用PLC功能"), Category("PLC类型")]
        public bool PLC_Enable
        {
            get => plc_Enable;
            set
            {
                plc_Enable = value;
                DataLoad();
            }
        }
        private bool plc_Enable = false;
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
        /// 读取PLC报警参数地址
        /// </summary>
        [Browsable(true)]
        [Description("读取PLC报警参数地址"), Category("PLC类型")]
        [ToolboxItem(true)]
        [DefaultValue(typeof(string), "PLCEventErr")]
        public string EventAddress 
        { 
            get => eventAddress;
            set 
            {
                if (DesignMode)
                    //eventAddress = System.IO.Directory.GetCurrentDirectory();
                    eventAddress = @"C:";
                else
                    eventAddress = value;
            } 
        }
        private string eventAddress = @"C:";
        [Browsable(true)]
        [Description("是否开启自动保存报警历史"), Category("PLC类型")]
        public bool Save { get => save; set => save=value; }
        private bool save=false;
        [Browsable(true)]
        [Description("自动保存报警历史路径"), Category("PLC类型")]
        [ToolboxItem(true)]
        public PLCSet AaveAddressz
        {
            get => saveAddressz;
            set
            {
                if (plc_Enable)
                {
                    this.BeginInvoke((MethodInvoker)delegate
                    {
                        FolderBrowserDialog dialog = new FolderBrowserDialog();
                        dialog.Description = "请选择文件路径";
                        dialog.SelectedPath = System.IO.Directory.GetCurrentDirectory();
                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
                            saveAddress = dialog.SelectedPath;
                        }
                    });
                }
            }
        }
        private PLCSet saveAddressz;

        [Browsable(true)]
        [Description("自动保存报警历史路径"), Category("PLC类型")]
        [ToolboxItem(true)]
        [DefaultValue(typeof(string), "PLCEventErr")]
        public string SaveAddress 
        {
            get => saveAddress;
            set
            {
                if (Directory.Exists(@value))
                {
                    saveAddress = value;
                }
            }
        }
        private string saveAddress= System.IO.Directory.GetCurrentDirectory() + "\\PLCEventErr";

        [Browsable(false)]
        public event EventHandler Modification;
        public System.Windows.Forms.Timer Timerconfiguration { get; set; } = new System.Windows.Forms.Timer() { Enabled = true, Interval = 100 };
        /// <summary>
        /// 修改参数界面窗口事件方法
        /// </summary>
        /// <param name="send"></param>
        /// <param name="e"></param>

        public void Modifications_Eeve(object send, EventArgs e)
        {
            this.Modification -= new EventHandler(Modifications_Eeve);
            new PLCErrDataViewForm(this).Show();
            this.Modification -= new EventHandler(Modifications_Eeve);
        }
        #endregion
    }
}
