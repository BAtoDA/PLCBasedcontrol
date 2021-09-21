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
using System.Runtime.InteropServices;

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
            AnimateWindow(this.Handle, 500, AW_SLIDE | AW_ACTIVE | AW_BLEND);
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
        #region 窗体关闭效果
        /// <param name="hwnd">指定产生动画的窗口的句柄</param>
        /// <param name="dwTime">指定动画持续的时间</param>
        /// <param name="dwFlags">指定动画类型，可以是一个或多个标志的组合。</param>
        [DllImport("user32")]
        private static extern bool AnimateWindow(IntPtr hwnd, int dwTime, int dwFlags);
        private const int AW_HOR_POSITIVE = 0x0001;//自左向右显示窗口，该标志可以在滚动动画和滑动动画中使用。使用AW_CENTER标志时忽略该标志
        private const int AW_HOR_NEGATIVE = 0x0002;//自右向左显示窗口，该标志可以在滚动动画和滑动动画中使用。使用AW_CENTER标志时忽略该标志
        private const int AW_VER_POSITIVE = 0x0004;//自顶向下显示窗口，该标志可以在滚动动画和滑动动画中使用。使用AW_CENTER标志时忽略该标志
        private const int AW_VER_NEGATIVE = 0x0008;//自下向上显示窗口，该标志可以在滚动动画和滑动动画中使用。使用AW_CENTER标志时忽略该标志该标志
        private const int AW_CENTER = 0x0010;//若使用了AW_HIDE标志，则使窗口向内重叠；否则向外扩展
        private const int AW_HIDE = 0x10000;//隐藏窗口
        private const int AW_ACTIVE = 0x20000;//激活窗口，在使用了AW_HIDE标志后不要使用这个标志
        private const int AW_SLIDE = 0x40000;//使用滑动类型动画效果，默认为滚动动画类型，当使用AW_CENTER标志时，这个标志就被忽略
        private const int AW_BLEND = 0x80000;//使用淡入淡出效果
        #endregion

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
