using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.配方控件实现类;
using PLC通讯基础控件项目.控件类基.控件数据结构;
using PLC通讯库.通讯枚举;
using Sunny.UI;

namespace PLC通讯基础控件项目.控件类基.控件地址选择窗口.配方控件参数设置界面
{
    public partial class PLCRecipeModification : UIForm
    {
        #region 字段属性
        /// <summary>
        /// 传入配方对象
        /// </summary>
        PLCRecipeClassBase recipeClassBas;
        List<Tuple<PLC, string, string, string, numerical_format>> RecipeTuple = new List<Tuple<PLC, string, string, string, numerical_format>>();
        #endregion

        public PLCRecipeModification(PLCRecipeClassBase recipeClassBase)
        {
            InitializeComponent();
            this.recipeClassBas = recipeClassBase;
            for (int i = 0; i < recipeClassBas.DataGridView_Name.Length; i++)
            {
                RecipeTuple.Add(new Tuple<PLC, string, string, string, numerical_format>(recipeClassBas.ReadWritePLC[i],
                    recipeClassBas.ReadWriteFunction[i], recipeClassBas.PLC_address[i], recipeClassBas.DataGridView_Name[i]
                    , recipeClassBas.DataGridView_numerical[i]));
            }
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            DataLoad();
        }
        /// <summary>
        /// 数据加载
        /// </summary>
        private void DataLoad()
        {
            this.uiDataGridView1.Rows.Clear();
            RecipeTuple.ForEach((s1 =>
            {
                this.uiDataGridView1.Rows.Add(s1.Item4, s1.Item1, s1.Item2, s1.Item3, s1.Item5);
            }));
        }
        /// <summary>
        /// 添加项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RecipeTuple.Add(new Tuple<PLC, string, string, string, numerical_format>(PLC.Mitsubishi,"M","0", "Name1",
                numerical_format.Signed_16_Bit));
            DataLoad();
        }
        /// <summary>
        /// 删除项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (this.uiDataGridView1.SelectedIndex > -1)
            {
                if (this.uiDataGridView1.Rows[this.uiDataGridView1.SelectedIndex].Cells[0].Value !=null&& this.uiDataGridView1.Rows[this.uiDataGridView1.SelectedIndex].Cells[0].Value?.ToString() != "" )
                    RecipeTuple.RemoveAt(this.uiDataGridView1.SelectedIndex);
            }
            DataLoad();
        }
    }
}
