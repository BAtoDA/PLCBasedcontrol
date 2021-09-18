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
using System.Threading;

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
            //plcBasement1.Size = new Size(499, 283);
            //plcBasement1.Location = new Point(173, 33);
            plcBasement1.BringToFront();
            plcBasement1.Visible = false;
            //处理事件注册部分
            this.toolStripMenuItem1.MouseDown += ((send, es) =>
              {
                  //显示底层日志控件
                  if (plcBasement1.Visible)
                  {
                      plcBasement1.Visible = false;
                      plcBasement1.SendToBack();
                  }
                  else
                  {
                      plcBasement1.Visible = true;
                      plcBasement1.BringToFront();
                  }
              });
            //
        }

        private void plcBasement1_Load(object sender, EventArgs e)
        {

        }

        private void TemplateForm_ExtendBoxClick(object sender, EventArgs e)
        {
            MessageBox.Show("d");
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
