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
        public PLCRecipeForm(PLCRecipeClassBase[] pLCRecipeClass)
        {
            InitializeComponent();
            this.pLCRecipeClass = pLCRecipeClass; 
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (pLCRecipeClass != null)
            {
                foreach (PLCRecipeClassBase p in pLCRecipeClass)
                {
                    if (p != null)
                        this.uiListBox1.Items.Add(p.RecipeName);
                }
            }
        }
        /// <summary>
        /// 用户双击项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiListBox1_ItemDoubleClick(object sender, EventArgs e)
        {
            var Data = pLCRecipeClass.Where(p => p.RecipeName == this.uiListBox1.Items[this.uiListBox1.SelectedIndex].ToString()).FirstOrDefault();
            if (Data != null)
            {

            }
        }

        private void uiListBox1_ItemClick(object sender, EventArgs e)
        {

        }
    }
}
