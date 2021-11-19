using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Linq;
using System.Diagnostics;

namespace PLC通讯基础控件项目.控件类基.PLC基础接口
{
    /// <summary>
    /// 动态绑定控件事件
    /// 以及传入方法触发类
    /// 用于动态绑定控件事件触发宏指令
    /// </summary>
    public class EventCreateClass
    {
        /// <summary>
        /// 用于处理控件触发后启动的事件
        /// 该事件可以用于处理宏任务
        /// </summary>
        public event EventHandler ControlEvent;
        /// <summary>
        /// 搜索支持EventHandler委托的事件
        /// </summary>
        /// <typeparam name="T">约束类型</typeparam>
        /// <param name="Contr">传入控件</param>
        /// <returns></returns>
        public List<EventInfo> EventName<T>(T Contr)
        {
           return Contr.GetType().GetEvents().Where(p => p.EventHandlerType == typeof(EventHandler)).ToList();
        }
        /// <summary>
        /// 反射控件支持绑定的事件
        /// 支持绑定类型根据ShowEvent方法去匹配
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="instance"></param>
        /// <param name="eventName"></param>
        public void GainHandler<T>(T instance, string eventName)
        {
            var eventInfo = instance.GetType().GetEvent(eventName);//获取指定事件
            var method = this.GetType().GetMethod("ShowEvent",BindingFlags.NonPublic|BindingFlags.Instance);//获取触发的方法
            if (method == null || eventInfo == null) return;//如果查找事件和方法失败 结束方法
            var @handler = Delegate.CreateDelegate(eventInfo.EventHandlerType, this, method);//绑定委托
            eventInfo.AddEventHandler(instance, @handler);//添加到事件
        }
        /// <summary>
        /// 启动事件的方法
        /// </summary>
        /// <param name="sender"></param>
        /// 
        /// <param name="e"></param>
        private void ShowEvent(object sender, EventArgs e)
        {
            if (ControlEvent != null)
            {
                ControlEvent.Invoke(sender, e);
                Debug.WriteLine(sender.ToString());
            }
        }
        /// <summary>
        /// 处理任务完成 
        /// 进行回调
        /// </summary>
        /// <param name="result"></param>
        private void ShowEventresult(IAsyncResult result)
        {
            Debug.WriteLine(result.AsyncState.ToString());
        }
    }
}
