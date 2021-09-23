using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PLC通讯基础控件项目.控件类基.PLC基础接口.表格控件_TO_PLC;
using Sunny.UI;
using System.Linq;
using Microsoft.Data.SqlClient;
using Microsoft.Data.Sqlite;
using PLC通讯基础控件项目.控件类基.控件数据结构;

namespace PLC通讯基础控件项目.控件类基.控件地址选择窗口.表格控件参数界面
{
    public partial class PLCDataViewForm : UIForm
    {
        #region 属性字段
        PLCDataViewClassBase pLCDataView;
        Control control;
        public bool Save { get; set; } = false;
        #endregion
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="pLCDataView">传入参数的接口</param>
        /// <param name="Formcontrol">窗口控件</param>
        public PLCDataViewForm(PLCDataViewClassBase pLCDataView,Control control)
        {
            InitializeComponent();
            this.pLCDataView = pLCDataView;
            this.control = control;
        }

        private void PLCDataViewForm_Load(object sender, EventArgs e)
        {
            //读取PLC地址添加操作
            this.uiDataGridView1.Rows.Clear();
            for (int i=0;i< pLCDataView.pLCDataViewselectRealize.ReadWritePLC.Length;i++)
            {
                this.uiDataGridView1.Rows.Add(new object[]
                {
                pLCDataView.pLCDataViewselectRealize.ReadWritePLC[i],
                pLCDataView.pLCDataViewselectRealize.ReadWriteFunction[i],
                pLCDataView.pLCDataViewselectRealize.PLC_address[i]
                });
            }
            //控件触发部分
            this.uiCheckBox2.Checked = pLCDataView.pLCDataViewselectRealize.BindingOpen;
            //反射获取窗口名称
            uiTextBox1.Text = GetContrForm(control).GetType().FullName;
            //反射获取窗口控件
            this.uiComboBox1.Items.Clear();
            this.uiComboBox1.KeyPress += ((send, e1) =>
              {
                  e1.Handled = true;
              });
            foreach (Control i in GetContrForm(control).Controls)
                this.uiComboBox1.Items.Add(i.Name);
            if (this.uiComboBox1.Items.Count > 0)
                this.uiComboBox1.SelectedIndex = 0;
            if (pLCDataView.pLCDataViewselectRealize.BindingName != null)
                this.uiComboBox1.Text = pLCDataView.pLCDataViewselectRealize.BindingName;
            //SQL部分
            this.uiCheckBox1.Checked = pLCDataView.pLCDataViewselectRealize.SQLOpen;
            this.uiCheckBox3.Checked = pLCDataView.pLCDataViewselectRealize.SQLServer_SQLinte;
            if (pLCDataView.pLCDataViewselectRealize.SQLCharacter != null)
                this.uiTextBox2.Text = pLCDataView.pLCDataViewselectRealize.SQLCharacter;
        }
        private Form GetContrForm(dynamic OopContr)
        {
            //递归查找顶级窗口Form
            object Oop = OopContr;
            while (true)
            {
                if ((((dynamic)Oop).Parent as Form) != null)
                {
                    return (Form)((dynamic)Oop).Parent;
                    
                }
                else
                    Oop = ((dynamic)Oop).Parent;
            }
        }

        private void uiButton5_Click(object sender, EventArgs e)
        {
            //用户点击了确定  进行数据检查
            if (this.uiDataGridView1.Rows.Count < 1)
                throw new Exception($"读取PLC地址不能少于1 当前行数是：{this.uiDataGridView1.Rows.Count}");
            //判断是否启用控件绑定
            if(this.uiCheckBox2.Checked)
            {
                //反射获取当前控件是否存在
                if ((from Control p in GetContrForm(control).Controls where p.Name == this.uiComboBox1.Text select p).FirstOrDefault() == null)
                    throw new Exception($"反射窗口:{GetContrForm(control).Name} 获取指定控件：{this.uiComboBox1.Text} 失败！");
            }
            //SQL
            if(this.uiCheckBox1.Checked)
            {
                if (pLCDataView.pLCDataViewselectRealize.SQLServer_SQLinte)
                {
                    //测试SQLserver数据库
                    using (SqlConnection db = new SqlConnection(this.uiTextBox2.Text))
                    {
                        db.Open();
                        db.Close();
                    }
                }
                else
                {
                    //测试SQLlite数据库
                    using (SqliteConnection db = new SqliteConnection(this.uiTextBox2.Text))
                    {
                        db.Open();
                        db.Close();
                    }

                }    
            }
            //数据校验完成 进行数据保存操作

            Save = true;
            this.Close();
        }

        private void uiButton6_Click(object sender, EventArgs e)
        {
            Save = false;
            this.Close();
        }

        private void uiButton4_Click(object sender, EventArgs e)
        {
            //SQL
            if (this.uiCheckBox1.Checked)
            {
                if (pLCDataView.pLCDataViewselectRealize.SQLServer_SQLinte)
                {
                    //测试SQLserver数据库
                    using (SqlConnection db = new SqlConnection(this.uiTextBox2.Text))
                    {
                        db.Open();
                        db.Close();
                    }
                }
                else
                {
                    //测试SQLlite数据库
                    using (SqliteConnection db = new SqliteConnection(this.uiTextBox2.Text))
                    {
                        db.Open();
                        db.Close();
                    }

                }
            }
        }
        //添加操作
        private void uiButton1_Click(object sender, EventArgs e)
        {
            this.uiDataGridView1.Rows.Add(new object[]
               {
                   PLC.Mitsubishi,
                   "M",
                   "0"
               });
        }
        //修改操作
        private void uiButton2_Click(object sender, EventArgs e)
        {

            //PLCDataViewFormAdd pLCData = new PLCDataViewFormAdd();

        }
        //删除操作
        private void uiButton3_Click(object sender, EventArgs e)
        {

        }

        private void uiDataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
