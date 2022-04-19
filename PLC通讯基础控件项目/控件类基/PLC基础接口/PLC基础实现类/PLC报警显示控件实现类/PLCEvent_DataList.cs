using System;
using System.Collections.Generic;
using System.Text;
using PLC通讯基础控件项目.控件类基.控件数据结构;

namespace PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLC报警显示控件实现类
{
    /// <summary>
    /// 报警视图控件批量访问PLC数据类
    /// 可以根据指定地址查询 目前仅支持Bit位
    /// </summary>
    public class PLCEvent_DataList
    {
        /// <summary>
        /// 存取PLC批量读取后的数据
        /// 唯一不可重复
        /// </summary>
        public static volatile Dictionary<string,List<PLCData>> PLCEvent_Data = new Dictionary<string, List<PLCData>>();
        [Serializable]
        public class PLCData
        {
            /// <summary>
            /// 访问的PLC功能码
            /// </summary>
            public string Function { get; set; }
            /// <summary>
            /// 临时存放的PLC数据区域 
            /// </summary>
            public List<DataList<dynamic>> DataList { get; set; }
        }
        /// <summary>
        /// 存取PLC数据类
        /// </summary>
        /// <typeparam name="T">T根据约束类型决定</typeparam>
        [Serializable]
        public class DataList<T>
        {
            /// <summary>
            /// 访问的PLC地址
            /// </summary>
            public string Address { get; set; }
            /// <summary>
            /// 地址的状态/数据
            /// </summary>
            public T State { get; set; }

        }
    }
}
