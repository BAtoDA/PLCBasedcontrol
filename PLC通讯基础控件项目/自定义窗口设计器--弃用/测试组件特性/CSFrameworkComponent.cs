using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2.测试组件特性
{
    [ToolboxBitmap(typeof(CSFrameworkComponent), "ComponentTest.bmp")]
    [DesignTimeVisible(true)]
    [Designer(typeof(CSFrameworkComponentDesigner), typeof(IDesigner))]
    public partial class CSFrameworkComponent : Component
    {
        //窗体设计器的接口引用，当拖拉组件到窗体上，值由构造器传入．
        private IContainer _Designer;

        //public CSFrameworkComponent()
        //{

        //}

        public CSFrameworkComponent(IContainer container)
        {
            MessageBox.Show("dd");
            _Designer = container;
            container.Add(this);
        }
    }
    [ToolboxBitmap(typeof(CSFrameworkComponent), "ComponentTest.bmp")]
    [DesignTimeVisible(true)]
    [Designer(typeof(CSFrameworkComponentDesigner), typeof(IDesigner))]
    class DAbutton1:Button
    {
        //窗体设计器的接口引用，当拖拉组件到窗体上，值由构造器传入．
        private IContainer _Designer;

        public DAbutton1()
        {

        }

        public DAbutton1(IContainer container)
        {
            _Designer = container;
            container.Add(this);
        }
    }

}