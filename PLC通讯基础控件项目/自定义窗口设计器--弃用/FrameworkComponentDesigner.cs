using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Windows.Forms;
using PLC通讯基础控件项目.PLC参数设置控件;
using PLC通讯基础控件项目.自定义窗口设计器;

namespace PLC通讯基础控件项目
{
    /// <summary>
    /// 自定义窗口设计器
    /// 用于设置PLC参数以及处理
    /// </summary>
    public class FrameworkComponentDesigner : ComponentDesigner
    {
        private dynamic _CurrentComponent1;
        public FrameworkComponentDesigner(): base()
        {
            // 添加菜单到右键菜单和智能标记中。
            //DesignerVerb Add = new DesignerVerb("添加PLC参数", new EventHandler(OnGenerateMyNodeComponentCode));
            ///DesignerVerb Amend = new DesignerVerb("修改PLC参数", new EventHandler(OnGenerateButtonCode));
            //DesignerVerb Delete = new DesignerVerb("移出PLC参数", new EventHandler(OnAbout));

            //this.Verbs.Add(Add);
            // this.Verbs.Add(Amend);
            //this.Verbs.Add(Delete);
            // 添加菜单到右键菜单和智能标记中。
            MessageBox.Show("dd");
            DesignerVerb V1 = new DesignerVerb("生成MyNodeComponent的设计时代码", new EventHandler(OnGenerateMyNodeComponentCode));
            DesignerVerb V2 = new DesignerVerb("生成Button的设计时代码", new EventHandler(OnGenerateButtonCode));
            DesignerVerb V3 = new DesignerVerb("www.CSFramework.com C/S框架网", new EventHandler(OnAbout));

            this.Verbs.Add(V1);
            this.Verbs.Add(V2);
            this.Verbs.Add(V3);
        }
        public override void Initialize(IComponent component)
        {
            MessageBox.Show("dd");
            base.Initialize(component);
            _CurrentComponent1 = component;
        }
        /// <summary>
        /// 移出PLC参数事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAbout(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 添加PLC参数事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void OnGenerateMyNodeComponentCode(object sender, EventArgs e)
        {
            //
            //在窗体设计器代码中生成自定义MyNodeComponent组件的代码
            //
            //取出窗体设计器
            IDesignerHost host = (IDesignerHost)this.Component.Site.GetService(typeof(IDesignerHost));
            //启动窗口设计器
            PLCPreferences preferences = new PLCPreferences();
            new DesignerAddForm(preferences).ShowDialog(); 
            //遍历当前窗口是否添加过改PLC类型
            foreach (var i in host.Container.Components)
            {
                if (i is PLCPreferences)
                {
                   if(((PLCPreferences)i).PLCDevice== preferences.PLCDevice)
                    {
                        MessageBox.Show($"{((PLCPreferences)i).PLCDevice}该PLC已经添加过了");
                        return;
                    }
                }
            }
            //创建一个组件
            PLCPreferences node = (PLCPreferences)host.CreateComponent(typeof(PLCPreferences));
            var Copy= node.GetType().GetProperties();
            var CopyTo = preferences.GetType().GetProperties();
            for(int i=0;i<Copy.Length;i++)
            {
                Copy[i] = CopyTo[i];
            }

            host.Container.Add(node);//在窗体设计器代码中生成代码

            MessageBox.Show("已生成"+ node.PLCDevice+ "的代码！请打开Designer.cs文件查看．");
        }
        /// <summary>
        /// 修改PLC参数事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

}