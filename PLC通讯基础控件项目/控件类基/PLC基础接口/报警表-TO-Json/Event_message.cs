using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace PLC通讯基础控件项目.控件类基.PLC基础接口.报警表_TO_Json
{
    /// <summary>
    /// 报警参数表
    /// </summary>
    [Serializable]
    public class Event_message
    {
        public int ID { get; set; }
        public int 类型 { get; set; }
        public string 设备 { get; set; }
        public string 设备_地址 { get; set; }
        public string 设备_具体地址 { get; set; }
        public bool 位触发条件 { get; set; }
        public string 字触发条件 { get; set; }
        public string 字触发条件_具体 { get; set; }
        public string 报警内容 { get; set; }

    }
    /// <summary>
    /// 报警表统一存放类
    /// </summary>
    public class EventLink
    {
        /// <summary>
        /// 报警表
        /// </summary>
       public static volatile List<Event_message> PLCEventLink = new List<Event_message>();
    }
}
