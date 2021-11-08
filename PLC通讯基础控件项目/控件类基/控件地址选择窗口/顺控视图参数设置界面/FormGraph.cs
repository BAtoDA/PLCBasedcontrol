using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PLC通讯基础控件项目.基础控件;
using Sunny.UI;
using System.Linq;

namespace PLC通讯基础控件项目.控件类基.控件地址选择窗口.顺控视图参数设置界面
{
    public partial class FormGraph : UIForm
    {
        /// <summary>
        /// 顺控视图步参数设置
        /// </summary>
        public R[] GraphList;
        /// <summary>
        /// 顺控视图绑定的数据
        /// </summary>
        public List<R> GraphListqeu;
        /// <summary>
        /// 是否保存参数
        /// </summary>
        public bool Save = false;
        public FormGraph(R[] GraphList)
        {
            InitializeComponent();
            this.GraphListqeu = GraphList.ToList();
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            List<R> Datars = new List<R>() { new R() { Content = "0", ID = 0, Step = 0 } };
            //绑定参数
            DataView(GraphListqeu == null ? Datars : GraphListqeu);
        }
        /// <summary>
        /// 用户点击保存参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton1_Click(object sender, EventArgs e)
        {
            if (GraphListqeu != null)
            {
                for(int i=0;i< this.uiDataGridView1.Rows.Count;i++)
                {
                    if (this.uiDataGridView1.Rows[i].Cells[0].Value != null)
                    {
                        if (GraphListqeu[i].ID != Convert.ToInt32(this.uiDataGridView1.Rows[i].Cells[0].Value.ToString())) continue;
                        GraphListqeu[i].Step = Convert.ToInt32(this.uiDataGridView1.Rows[i].Cells[1].Value.ToString());
                        GraphListqeu[i].Content = this.uiDataGridView1.Rows[i].Cells[2].Value.ToString();
                        GraphListqeu[i].LastStep = Convert.ToInt32(this.uiDataGridView1.Rows[i].Cells[3].Value.ToString());
                        GraphListqeu[i].NextStep = Convert.ToInt32(this.uiDataGridView1.Rows[i].Cells[4].Value.ToString());
                    }
                }
                GraphList = GraphListqeu.ToArray();
            }
            Save = true;
            this.Close();
        }
        /// <summary>
        /// 用户取消保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton2_Click(object sender, EventArgs e)
        {
            Save = false;
            this.Close();
        }
        /// <summary>
        /// 添加条目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var Data = new R()
            {
                ID = GraphListqeu.Max(p => p.ID) + 1,
                Content = "Null",
                Step = GraphListqeu.Max(p => p.Step) + 1
            };
            this.GraphListqeu.Add(Data);
            this.uiDataGridView1.Rows.Add(Data.ID, Data.Step, Data.Content,Data.LastStep,Data.NextStep);

        }
        /// <summary>
        /// 删除条目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (this.uiDataGridView1.SelectedIndex > -1)//判断用户是否选中行
            {
                if (this.uiDataGridView1.Rows[this.uiDataGridView1.SelectedIndex].Cells[0].Value?.ToString().Trim() == "")//用户是否选中了空行
                {
                    MessageBox.Show("你选中了空行", "Err");//提示异常
                    return; //返回方法
                }
                else
                {
                    //移除数据
                    var GraphListRemov= GraphListqeu.Where(p => p.ID.ToString() == this.uiDataGridView1.Rows[this.uiDataGridView1.SelectedIndex].Cells[0].Value?.ToString()).FirstOrDefault();
                    if (GraphListRemov != null)
                        GraphListqeu.Remove(GraphListRemov);
                    DataView(GraphListqeu);
                }
            }
        }
        /// <summary>
        /// 加载顺控视图参数
        /// </summary>
        /// <param name="Data"></param>
        private void DataView(List<R> Data)
        {
            this.uiDataGridView1.Rows.Clear();
            Data.ForEach(s => { this.uiDataGridView1.Rows.Add(s.ID,s.Step,s.Content,s.LastStep,s.NextStep); });
        }
    }
}
