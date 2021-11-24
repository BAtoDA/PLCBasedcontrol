using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.配方控件实现类;
using Sunny.UI;

namespace PLC通讯基础控件项目.控件类基.控件地址选择窗口.配方控件参数设置界面
{
    public partial class PLCRecipeModification : UIForm
    {
        /// <summary>
        /// 传入配方对象
        /// </summary>
        PLCRecipeClassBase recipeClassBas;
        public PLCRecipeModification(PLCRecipeClassBase recipeClassBase)
        {
            InitializeComponent();
            this.recipeClassBas=recipeClassBase;
        }

    }
}
