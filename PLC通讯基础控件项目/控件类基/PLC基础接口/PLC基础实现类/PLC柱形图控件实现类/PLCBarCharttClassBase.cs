using System;
using System.Collections.Generic;
using System.Text;

namespace PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLC柱形图控件实现类
{
    /// <summary>
    /// 柱形图基础接口
    /// </summary>
    interface PLCBarCharttClassBase
    {
        /// <summary>
        /// 柱形图标题
        /// </summary>
        public string TitleText { get; set; }
        /// <summary>
        /// 图形标题
        /// </summary>
        public string TitleSubText { get; set; }
        /// <summary>
        /// X坐标名称
        /// </summary>
        public string XAxisName { get; set; }
        /// <summary>
        /// X坐标最大值
        /// </summary>
        public long XAxisMax { get; set; }
        /// <summary>
        /// X坐标最小值
        /// </summary>
        public long XAxisMin { get; set; }
        /// <summary>
        /// Y坐标名称
        /// </summary>
        public string YAxisName { get; set; }
        /// <summary>
        /// Y坐标最大值
        /// </summary>
        public long YAxisMax { get; set; }
        /// <summary>
        /// Y坐标最小值
        /// </summary>
        public long YAxisMin { get; set; }
    }
}
