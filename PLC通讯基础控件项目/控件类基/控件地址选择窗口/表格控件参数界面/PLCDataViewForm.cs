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
using PLC通讯库.通讯枚举;
using System.Data.SqlClient;
using SqlConnection = System.Data.SqlClient.SqlConnection;
using SqlCommand = System.Data.SqlClient.SqlCommand;
using SqlDataAdapter = System.Data.SqlClient.SqlDataAdapter;
using System.Data.SQLite;
using System.Threading.Tasks;

namespace PLC通讯基础控件项目.控件类基.控件地址选择窗口.表格控件参数界面
{
    public partial class PLCDataViewForm : UIForm
    {
        #region 属性字段
        PLCDataViewClassBase pLCDataView;
        Control control;
        int Index = 0;
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
            for (int i = 0; i < pLCDataView.pLCDataViewselectRealize.ReadWritePLC.Length; i++)
            {
                this.uiDataGridView1.Rows.Add(new object[]
                {
                pLCDataView.pLCDataViewselectRealize.ReadWritePLC[i],
                pLCDataView.pLCDataViewselectRealize.ReadWriteFunction[i],
                pLCDataView.pLCDataViewselectRealize.PLC_address[i],
                pLCDataView.pLCDataViewselectRealize.DataGridView_numerical[i],
                pLCDataView.pLCDataViewselectRealize.DataGridView_Name[i],
                pLCDataView.pLCDataViewselectRealize.SQLsurfaceType[i]
                });
            }
            this.uiDataGridView1.CellMouseClick += ((send, e) =>
              {
                  Index = e.RowIndex;
              });
            this.uiCheckBox4.Checked = pLCDataView.pLCDataViewselectRealize.DataGridViewPLC_Time;
            //控件触发部分
            this.uiCheckBox2.Checked = pLCDataView.pLCDataViewselectRealize.BindingOpen;
            //反射获取窗口名称
            uiTextBox1.Text = GetContrForm(control).Name ;
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
            this.uiTextBox3.Text = string.Empty;
            if (pLCDataView.pLCDataViewselectRealize.SQLsurface != null)
                this.uiTextBox3.Text = this.pLCDataView.pLCDataViewselectRealize.SQLsurface;

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
            try
            {
                //用户点击了确定  进行数据检查
                if (this.uiDataGridView1.Rows.Count < 1)
                    throw new Exception($"读取PLC地址不能少于1 当前行数是：{this.uiDataGridView1.Rows.Count}");
                //判断是否启用控件绑定
                if (this.uiCheckBox2.Checked)
                {
                    //反射获取当前控件是否存在
                    if ((from Control p in GetContrForm(control).Controls where p.Name == this.uiComboBox1.Text select p).FirstOrDefault() == null)
                        throw new Exception($"反射窗口:{GetContrForm(control).Name} 获取指定控件：{this.uiComboBox1.Text} 失败！");
                }
                goto TOinde;
                //SQL--放弃代码--由于CLR未运行 无法校验SQL数据参数是否正确
                //if (this.uiCheckBox1.Checked)
                //{
                //    if (!this.uiCheckBox3.Checked)
                //    {
                //        //测试SQLserver数据库
                //        using (SqlConnection db = new SqlConnection(this.uiTextBox2.Text))
                //        {
                //            db.Open();
                //            //测试名以及数据类型
                //            SqlCommand sqlCommand = new SqlCommand($"select * from {this.uiTextBox3.Text}", db);
                //            var SqlDataAdapter = new SqlDataAdapter(sqlCommand);
                //            DataSet ds = new DataSet();
                //            SqlDataAdapter.FillSchema(ds, System.Data.SchemaType.Mapped);
                //            for (int i = 0; i < this.uiDataGridView1.Rows.Count; i++)
                //            {
                //                if (this.uiDataGridView1.Rows[i].Cells[4].Value == null) continue;
                //                if (!ds.Tables[0].Columns.Contains(this.uiDataGridView1.Rows[i].Cells[4].Value?.ToString()))
                //                    throw new Exception($"找不到指定的表名：{this.uiDataGridView1.Rows[i].Cells[4].Value?.ToString()}");
                //                {
                //                    //查找到表名---进行数据类型匹配
                //                    if (ds.Tables[0].Columns[this.uiDataGridView1.Rows[i].Cells[4].Value?.ToString()].DataType.Name != this.uiDataGridView1.Rows[i].Cells[5].Value?.ToString())
                //                        throw new Exception($"{this.uiDataGridView1.Rows[i].Cells[4].Value?.ToString()}设置的列数据类型应该为：{ds.Tables[0].Columns[pLCDataView.pLCDataViewselectRealize.DataGridView_Name[i]].DataType.Name} 设置成：{this.uiDataGridView1.Rows[i].Cells[5].Value?.ToString()}是错误的！");
                //                }
                //            }
                //            MessageBox.Show("测试成功");
                //            db.Close();
                //        }
                //    }
                //    else
                //    {
                //        //测试SQLlite数据库
                //        using (SQLiteConnection db = new SQLiteConnection(this.uiTextBox2.Text))
                //        {
                //            db.Open();
                //            //测试名以及数据类型
                //            SQLiteCommand sqlCommand = new SQLiteCommand($"select * from {this.uiTextBox3.Text}", db);
                //            var SqlDataAdapter = new SQLiteDataAdapter(sqlCommand);
                //            DataSet ds = new DataSet();
                //            SqlDataAdapter.FillSchema(ds, System.Data.SchemaType.Mapped);
                //            for (int i = 0; i < this.uiDataGridView1.Rows.Count; i++)
                //            {
                //                if (this.uiDataGridView1.Rows[i].Cells[4].Value == null) continue;
                //                if (!ds.Tables[0].Columns.Contains(this.uiDataGridView1.Rows[i].Cells[4].Value?.ToString()))
                //                    throw new Exception($"找不到指定的表名：{this.uiDataGridView1.Rows[i].Cells[4].Value?.ToString()}");
                //                {
                //                    //查找到表名---进行数据类型匹配
                //                    if (ds.Tables[0].Columns[this.uiDataGridView1.Rows[i].Cells[4].Value?.ToString()].DataType.Name != this.uiDataGridView1.Rows[i].Cells[5].Value?.ToString())
                //                        throw new Exception($"{this.uiDataGridView1.Rows[i].Cells[4].Value?.ToString()}设置的列数据类型应该为：{ds.Tables[0].Columns[pLCDataView.pLCDataViewselectRealize.DataGridView_Name[i]].DataType.Name} 设置成：{this.uiDataGridView1.Rows[i].Cells[5].Value?.ToString()}是错误的！");
                //                }
                //            }
                //            db.Close();
                //        }

                //    }
                //}
            }
            catch(Exception E)
            {
                MessageBox.Show("错误：" + E.Message);
                return;
            }
            TOinde:
            //数据校验完成 进行数据保存操作
            List<PLC> ReadWritePLC = new List<PLC>();
            List<string> Name1 = new List<string>();
            List<string> Name2 = new List<string>();
            List<string> Name3 = new List<string>();
            List<string> Name4 = new List<string>();
            List<numerical_format> DataGridView_numerical = new List<numerical_format>();
            for (int i = 0; i < this.uiDataGridView1.Rows.Count-1; i++)
            {
                if (this.uiDataGridView1.Rows[i].Cells[0].Value?.ToString() != "" || this.uiDataGridView1.Rows[i].Cells[0].Value != null)
                    ReadWritePLC.Add((PLC)Enum.Parse(typeof(PLC), this.uiDataGridView1.Rows[i].Cells[0].Value.ToString()));

                if (this.uiDataGridView1.Rows[i].Cells[1].Value?.ToString() != "" || this.uiDataGridView1.Rows[i].Cells[1].Value != null)
                    Name1.Add(this.uiDataGridView1.Rows[i].Cells[1].Value?.ToString());

                if (this.uiDataGridView1.Rows[i].Cells[2].Value?.ToString() != "" || this.uiDataGridView1.Rows[i].Cells[2].Value != null)
                    Name2.Add(this.uiDataGridView1.Rows[i].Cells[2].Value?.ToString());

                if (this.uiDataGridView1.Rows[i].Cells[4].Value?.ToString() != "" || this.uiDataGridView1.Rows[i].Cells[4].Value != null)
                    Name3.Add(this.uiDataGridView1.Rows[i].Cells[4].Value?.ToString());

                if (this.uiDataGridView1.Rows[i].Cells[3].Value?.ToString() != "" || this.uiDataGridView1.Rows[i].Cells[3].Value != null)
                    DataGridView_numerical.Add((numerical_format)Enum.Parse(typeof(numerical_format), this.uiDataGridView1.Rows[i].Cells[3].Value?.ToString()));
                if (this.uiDataGridView1.Rows[i].Cells[5].Value?.ToString() != "" || this.uiDataGridView1.Rows[i].Cells[5].Value != null)
                    Name4.Add(this.uiDataGridView1.Rows[i].Cells[5].Value.ToString());
            }
            //赋值
            pLCDataView.pLCDataViewselectRealize.ReadWritePLC = ReadWritePLC.ToArray();
            pLCDataView.pLCDataViewselectRealize.ReadWriteFunction = Name1.ToArray();
            pLCDataView.pLCDataViewselectRealize.PLC_address = Name2.ToArray();
            pLCDataView.pLCDataViewselectRealize.DataGridView_numerical = DataGridView_numerical.ToArray();
            pLCDataView.pLCDataViewselectRealize.DataGridView_Name = Name3.ToArray();
            pLCDataView.pLCDataViewselectRealize.SQLsurfaceType = Name4.ToArray();

            pLCDataView.pLCDataViewselectRealize.DataGridViewPLC_Time = this.uiCheckBox4.Checked;

            pLCDataView.pLCDataViewselectRealize.BindingOpen = this.uiCheckBox2.Checked;
            pLCDataView.pLCDataViewselectRealize.BindingName = this.uiComboBox1.Text;

            pLCDataView.pLCDataViewselectRealize.SQLOpen=this.uiCheckBox1.Checked;
            pLCDataView.pLCDataViewselectRealize.SQLServer_SQLinte=this.uiCheckBox3.Checked;
            pLCDataView.pLCDataViewselectRealize.SQLCharacter = this.uiTextBox2.Text;
            this.pLCDataView.pLCDataViewselectRealize.SQLsurface = this.uiTextBox3.Text;

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
            return;
            //try
            //{
            //    //SQL--放弃代码---
            //    if (this.uiCheckBox1.Checked)
            //    {
            //        if (!this.uiCheckBox3.Checked)
            //        {
            //            //测试SQLserver数据库
            //            using (SqlConnection db = new SqlConnection(this.uiTextBox2.Text))
            //            {
            //                db.Open();
            //                //测试名以及数据类型
            //                SqlCommand sqlCommand = new SqlCommand($"select * from {this.uiTextBox3.Text}", db);
            //                var SqlDataAdapter = new SqlDataAdapter(sqlCommand);
            //                DataSet ds = new DataSet();
            //                SqlDataAdapter.FillSchema(ds, System.Data.SchemaType.Mapped);
            //                for (int i = 0; i < this.uiDataGridView1.Rows.Count; i++)
            //                {
            //                    if (this.uiDataGridView1.Rows[i].Cells[4].Value == null) continue;
            //                    if (!ds.Tables[0].Columns.Contains(this.uiDataGridView1.Rows[i].Cells[4].Value?.ToString()))
            //                        throw new Exception($"找不到指定的表名：{this.uiDataGridView1.Rows[i].Cells[4].Value?.ToString()}");
            //                    {
            //                        //查找到表名---进行数据类型匹配
            //                        if (ds.Tables[0].Columns[this.uiDataGridView1.Rows[i].Cells[4].Value?.ToString()].DataType != this.uiDataGridView1.Rows[i].Cells[5].Value?.GetType())
            //                            throw new Exception($"{this.uiDataGridView1.Rows[i].Cells[4].Value?.ToString()}设置的列数据类型应该为：{ds.Tables[0].Columns[pLCDataView.pLCDataViewselectRealize.DataGridView_Name[i]].DataType.Name} 设置成：{this.uiDataGridView1.Rows[i].Cells[5].Value?.ToString()}是错误的！");
            //                    }
            //                }
            //                MessageBox.Show("测试成功");

            //                db.Close();
            //            }
            //        }
            //        else
            //        {
            //            //测试SQLlite数据库
            //            using (SQLiteConnection db = new SQLiteConnection(this.uiTextBox2.Text))
            //            {
            //                db.Open();
            //                //测试名以及数据类型
            //                SQLiteCommand sqlCommand = new SQLiteCommand($"select * from {this.uiTextBox3.Text}", db);
            //                var SqlDataAdapter = new SQLiteDataAdapter(sqlCommand);
            //                DataSet ds = new DataSet();
            //                SqlDataAdapter.FillSchema(ds, System.Data.SchemaType.Mapped);
            //                for (int i = 0; i < this.uiDataGridView1.Rows.Count; i++)
            //                {
            //                    if (this.uiDataGridView1.Rows[i].Cells[4].Value == null) continue;
            //                    if (!ds.Tables[0].Columns.Contains(this.uiDataGridView1.Rows[i].Cells[4].Value?.ToString()))
            //                        throw new Exception($"找不到指定的表名：{this.uiDataGridView1.Rows[i].Cells[4].Value?.ToString()}");
            //                    {
            //                        //查找到表名---进行数据类型匹配
            //                        if (ds.Tables[0].Columns[this.uiDataGridView1.Rows[i].Cells[4].Value?.ToString()].DataType.Name != this.uiDataGridView1.Rows[i].Cells[5].Value?.ToString())
            //                            throw new Exception($"{this.uiDataGridView1.Rows[i].Cells[4].Value?.ToString()}设置的列数据类型应该为：{ds.Tables[0].Columns[pLCDataView.pLCDataViewselectRealize.DataGridView_Name[i]].DataType.Name} 设置成：{this.uiDataGridView1.Rows[i].Cells[5].Value?.ToString()}是错误的！");
            //                    }
            //                }
            //                db.Close();
            //            }

            //        }
            //    }           
            //}
            //catch(Exception E)
            //{
            //    MessageBox.Show("错误："+E.Message);
            //}
        }
        //添加操作
        private void uiButton1_Click(object sender, EventArgs e)
        {
            this.uiDataGridView1.Rows.Add(new object[]
               {
                   "Mitsubishi",
                   "D",
                   "0",
                   "Signed_32_Bit",
                   "Name"+this.uiDataGridView1.Rows.Count,
                   "varchar"
               });

            this.uiDataGridView1.SelectedIndex = this.uiDataGridView1.Rows.Count-1;
        }
        //修改操作
        private void uiButton2_Click(object sender, EventArgs e)
        {
            try
            {
                Index = this.uiDataGridView1.SelectedIndex;
                if (this.uiDataGridView1.Rows[Index].Cells[0].Value?.ToString().Trim() != ""& this.uiDataGridView1.Rows[Index].Cells[0].Value!=null)//用户是否选中了空行
                {
                    PLCDataViewFormAdd pLCData = new PLCDataViewFormAdd(this.uiDataGridView1.Rows[Index].Cells[0].Value.ToString(), this.uiDataGridView1.Rows[Index].Cells[1].Value.ToString(), this.uiDataGridView1.Rows[Index].Cells[2].Value.ToString(), this.uiDataGridView1.Rows[Index].Cells[3].Value.ToString(), this.uiDataGridView1.Rows[Index].Cells[4].Value.ToString(), this.uiDataGridView1.Rows[Index].Cells[5].Value.ToString());
                    pLCData.ShowDialog();
                    if (pLCData.Save)
                    {
                        this.uiDataGridView1.Rows[Index].Cells[0].Value = pLCData.PLCs;
                        this.uiDataGridView1.Rows[Index].Cells[1].Value = pLCData.PLCName;
                        this.uiDataGridView1.Rows[Index].Cells[2].Value = pLCData.PLCaddress;
                        this.uiDataGridView1.Rows[Index].Cells[3].Value = pLCData.PLCType;
                        this.uiDataGridView1.Rows[Index].Cells[4].Value = pLCData.DataViweName;
                        this.uiDataGridView1.Rows[Index].Cells[5].Value = pLCData.SQLType;
                    }

                }
                this.uiDataGridView1.SelectedIndex = Index;
            }
            catch { }
        }
        //删除操作
        private void uiButton3_Click(object sender, EventArgs e)
        {
            try
            {
                Index = this.uiDataGridView1.SelectedIndex;
                if (this.uiDataGridView1.Rows[Index].Cells[0].Value?.ToString().Trim() != ""& this.uiDataGridView1.Rows[Index].Cells[0].Value!=null)//用户是否选中了空行
                {
                    uiDataGridView1.Rows.RemoveAt(Index);
                }

                this.uiDataGridView1.SelectedIndex = Index-1;
            }
            catch { }
        }

        private void uiDataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
