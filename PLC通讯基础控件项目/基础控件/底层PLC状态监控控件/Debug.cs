//**********************************************************************
//
// 文件名称(File Name)：
// 功能描述(Description)：
// 作者(Author)：DAtoTA
// 日期(Create Date)： 2021/9/14 21:05:39
//
//**********************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PLC通讯基础控件项目.基础控件.底层PLC状态监控控件
{
    /// <summary>
    /// 用于输出消息
    /// </summary>
    public class ControlDebug
    {
        /// <summary>
        /// 消息触发事件
        /// </summary>
        public static event EventHandler EventMessage;
        /// <summary>
        /// 把消息输出到控制台以及底层订阅者
        /// </summary>
        /// <param name="Value"></param>
        public static void Write(string Value)
        {
            //优先输出到订阅者
            if (EventMessage != null)
                //EventMessage.BeginInvoke(Value, new EventArgs(), Call_back, Value);
                EventMessage.Invoke(Value, new EventArgs());
            Debug.WriteLine(Value);
        }
        /// <summary>
        /// 输出完毕进行回调
        /// </summary>
        /// <param name="async"></param>
        private static void Call_back(IAsyncResult async)
        {
            
        }
    }
}
