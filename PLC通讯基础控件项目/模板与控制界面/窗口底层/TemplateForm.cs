using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PLC通讯基础控件项目.基础控件.底层PLC状态监控控件;
using Sunny.UI;
using System.Linq;

namespace PLC通讯基础控件项目.模板与控制界面.窗口底层
{
    public partial class TemplateForm : UIForm
    {
        public TemplateForm()
        {
            InitializeComponent();
        }

        private void TemplateForm_Load(object sender, EventArgs e)
        {
            //处理事件注册部分
            this.toolStripMenuItem1.MouseDown += ((send, es) =>
              {
                  //显示底层日志控件
                  var cont = (from Control P in this.Controls where P is PlcBasement select P ).FirstOrDefault();
                  if (cont == null)
                  {
                      PlcBasement plcBasement = new PlcBasement();
                      plcBasement.Location = new Point((this.Size.Width / 2) - (plcBasement.Size.Width / 2), (this.Size.Height / 2) - (plcBasement.Size.Height / 2));
                      this.Controls.Add(plcBasement);
                  }
                  else
                      this.Controls.Remove(cont);
              });
            //
        }
    }
}
