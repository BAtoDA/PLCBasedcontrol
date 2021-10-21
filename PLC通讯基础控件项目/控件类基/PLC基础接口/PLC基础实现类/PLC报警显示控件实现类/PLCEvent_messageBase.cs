using PLC通讯基础控件项目.控件类基.PLC基础接口.报警表_TO_Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLC报警显示控件实现类
{
    /// <summary>
    /// 报警表控件基础接口
    /// </summary>
    public interface PLCEvent_messageBase
    {
        /// <summary>
        /// 读取控制
        /// </summary>
        public bool ReadCommand { get; set; }
        /// <summary>
        /// 是否启用控件
        /// </summary>
        public bool PLC_Enable { get; set; }
        /// <summary>
        /// 注册事件保存路径
        /// </summary>
        public string EventAddress { get; set; }
        /// <summary>
        /// 是否自动保存历史
        /// </summary>
        public bool Save { get; set; }
        /// <summary>
        /// 自动保存报警历史的路径
        /// </summary>
        public string SaveAddress { get; set; }
    }
}
