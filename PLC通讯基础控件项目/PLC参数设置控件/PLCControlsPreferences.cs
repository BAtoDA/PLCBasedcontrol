//**********************************************************************
//
// 文件名称(File Name)：
// 功能描述(Description)：
// 作者(Author)：DAtoTA
// 日期(Create Date)： 2021/9/5 21:28:54
//
//**********************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Drawing.Design;
using System.Windows.Forms.Design;
using System.ComponentModel.Design;
using System.Collections;
using System.Drawing;
using PLC通讯基础控件项目.PLC参数设置控件;

namespace PLC通讯基础控件项目
{
    /// <summary>
    /// PLC通讯参数控件设置
    /// 继承Timer定时器 
    /// </summary>
    [ToolboxBitmap(typeof(PLCControlsPreferences), "ComponentTest.bmp")]
    [DesignTimeVisible(true)]
    [Designer(typeof(FrameworkComponentDesigner))]
    public partial class PLCControlsPreferences : Button
    {
        //窗体设计器的接口引用，当拖拉组件到窗体上，值由构造器传入．
        [Browsable(true)]
        [Description("设置PLC参数"), Category("PLC参数")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public BindingList<PLCPreferences> PLCPreferences { get => PLCPreference; set => PLCPreference = value; }
        private BindingList<PLCPreferences> PLCPreference = new BindingList<PLCPreferences>();

        private IContainer _Designer;
        public PLCControlsPreferences(IContainer container)
        {
            _Designer = container;
            foreach(var i in container.Components)
            {
                if (i is PLCControlsPreferences) throw new Exception("该控件已经存在无需重复添加");
            }
            container.Add(this);
        }
      

    }


}
