using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.配方控件实现类;
using Sunny.UI;
using System.Linq;

namespace PLC通讯基础控件项目.控件类基.控件地址选择窗口.配方控件参数设置界面
{
    public partial class PLCRecipeForm : UIForm
    {
        /// <summary>
        /// PLC配方保存参数
        /// </summary>
        PLCRecipeClassBase[] pLCRecipeClass;
        /// <summary>
        /// PLC配方参数列表
        /// </summary>
        List<PLCRecipeClassBase> pLCRecipes=new List<PLCRecipeClassBase> ();
        public PLCRecipeForm(PLCRecipeClassBase[] pLCRecipeClass)
        {
            InitializeComponent();
            this.pLCRecipeClass = pLCRecipeClass;
            this.pLCRecipes = pLCRecipeClass.ToList();
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            //加载项
            UiListComboboxLoad();
        }
        /// <summary>
        /// 用户双击项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiListBox1_ItemDoubleClick(object sender, EventArgs e)
        {
            var Data = pLCRecipes.Where(p => p.RecipeName == this.uiListBox1.Items[this.uiListBox1.SelectedIndex].ToString()).FirstOrDefault();
            if (Data != null)
            {
                new PLCRecipeModification(Data).ShowDialog();
            }
        }
        /// <summary>
        /// 添加项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton1_Click(object sender, EventArgs e)
        {
            int Id = pLCRecipes.Count > 0 ? pLCRecipes.Max(p => p.RecipeID) + 1 : 1;
            pLCRecipes.Add(new PLCRecipeClassBase()
            {
                RecipeName = $"Recipe{Id}",
                RecipeID = Id,
                DataGridView_Name = new string[] { "Name" },
                DataGridView_numerical = new PLC通讯库.通讯枚举.numerical_format[] { PLC通讯库.通讯枚举.numerical_format.Signed_16_Bit },
                ReadWritePLC = new 控件数据结构.PLC[] { 控件数据结构.PLC.Mitsubishi },
                ReadWriteFunction = new string[] { "M" },
                PLC_address = new string[] { "0" }

            });
            //重新加载项
            UiListComboboxLoad();
            this.uiListBox1.SelectedIndex = pLCRecipes.Count-1;
        }
        /// <summary>
        /// 删除项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton2_Click(object sender, EventArgs e)
        {
            int Index = this.uiListBox1.SelectedIndex;
            if (this.uiListBox1.SelectedIndex>-1&this.uiListBox1.SelectedIndex<pLCRecipes.Count)
            {
                pLCRecipes.RemoveAt(this.uiListBox1.SelectedIndex);
            }
            UiListComboboxLoad();
            if(this.uiListBox1.Items.Count>0)
            this.uiListBox1.SelectedIndex = Index > 0 ? Index - 1 : 0;
        }
        /// <summary>
        /// 加载显示列表
        /// </summary>
        private void UiListComboboxLoad()
        {
            this.uiListBox1.Items.Clear();
            if (pLCRecipeClass != null)
            {
                foreach (PLCRecipeClassBase p in pLCRecipes)
                {
                    if (p != null)
                        this.uiListBox1.Items.Add(p.RecipeName);
                }
            }

        }
    }
}
