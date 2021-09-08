

using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2.测试组件特性
{
    public class CSFrameworkComponentDesigner : ComponentDesigner
    {
        private CSFrameworkComponent _CurrentComponent;
        private dynamic _CurrentComponent1;
        public CSFrameworkComponentDesigner()
        : base()
        {
            MessageBox.Show("dd");
            // 添加菜单到右键菜单和智能标记中。
            DesignerVerb V1 = new DesignerVerb("生成MyNodeComponent的设计时代码", new EventHandler(OnGenerateMyNodeComponentCode));
            DesignerVerb V2 = new DesignerVerb("生成Button的设计时代码", new EventHandler(OnGenerateButtonCode));
            DesignerVerb V3 = new DesignerVerb("www.CSFramework.com C/S框架网", new EventHandler(OnAbout));

            this.Verbs.Add(V1);
            this.Verbs.Add(V2);
            this.Verbs.Add(V3);
        }

        private void OnAbout(object sender, EventArgs e)
        {
            MessageBox.Show("程序：Jonny Sun \r\n版权：www.CSFramework.com C/S框架网");
        }

        private void OnGenerateMyNodeComponentCode(object sender, EventArgs e)
        {
            //
            //在窗体设计器代码中生成自定义MyNodeComponent组件的代码
            //
            //取出窗体设计器
            IDesignerHost host = (IDesignerHost)this.Component.Site.GetService(typeof(IDesignerHost));
            foreach(var i in host.Container.Components)
            {
                if (i is MyNodeComponent)
                {
                    MessageBox.Show("该属性存在");
                    return;
                }
            }
            //创建一个组件
            MyNodeComponent node = (MyNodeComponent)host.CreateComponent(typeof(MyNodeComponent));
            node.NodeName = "www.CSFramework.com";
            node.ID = DateTime.Now.Millisecond;
            host.Container.Add(node);//在窗体设计器代码中生成代码

            MessageBox.Show("已生成"+ node.NodeName+ "的代码！请打开frmTester.Designer.cs文件查看．");
        }

        public override void Initialize(IComponent component)
        {
            base.Initialize(component);
            MessageBox.Show("dd");
            _CurrentComponent =component as CSFrameworkComponent;
            _CurrentComponent1 = component;
        }

        private void OnGenerateButtonCode(object sender, EventArgs e)
        {
            //
            //在窗体上加入一个Button组件,host.RootComponent=Form
            //
            //取出窗体设计器
            IDesignerHost host = (IDesignerHost)this.GetService(typeof(IDesignerHost));
            IComponentChangeService c = (IComponentChangeService)this.GetService(typeof(IComponentChangeService));

            Form form = (Form)host.RootComponent;//RootComponent: 根组件，指Form
            DesignerTransaction tran = host.CreateTransaction();//创建事务

            //创建按钮组件
            Button button = (Button)host.CreateComponent(typeof(Button));
            button.Text = "www.CSFramework.com";
            button.Location = new Point(50, 50);
            button.Size = new Size(150, 30);

            c.OnComponentChanging(form, null);//通知窗体正在新增控件服务
            form.Controls.Add(button);//Form.Controls.Add, 生成持久化代码
            c.OnComponentChanged(form, null, null, null);//通知窗体修改服务已完成

            tran.Commit();//提交事务

            MessageBox.Show("已生成"+ button.Name +"的代码！请打开frmTester.Designer.cs文件查看．");
        }

    }
    [ToolboxItem(false)]
    [Browsable(false)]
    [Serializable]
    class MyNodeComponent: IComponent
    {
        public string NodeName { get; set; }
        public int ID { get; set; }
        public ISite Site { get; set; }

        public event EventHandler Disposed;

        public void Dispose()
        {
           
        }
    }

}