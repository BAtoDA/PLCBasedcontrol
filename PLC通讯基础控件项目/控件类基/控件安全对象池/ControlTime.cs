﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace PLC通讯基础控件项目.控件类基.控件安全对象池
{
    /// <summary>
    /// 用于处理控件传入的委托任务与需要定时的时间
    /// </summary>
    [ToolboxItem(false)]
    [Browsable(false)]
    class ControlTime:Timer,IDisposable
    {
        /// <summary>
        /// 需要处理任务的控件
        /// </summary>
        /// <param name="control">输入控件</param>
        /// <returns></returns>
        protected event EventHandler PLCEvent;
        public Control Control;

        object Timelock = new object();
        protected override void OnTick(EventArgs e)
        {
            lock (Timelock)
            {
                this.Stop();
                if(PLCEvent!=null&&Control.Capture)
                {
                    this.PLCEvent.Invoke(Control,new EventArgs());
                }
                base.OnTick(e);
            }
        }


        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

    }
}
