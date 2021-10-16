using System;
using System.Collections.Generic;
using System.Text;

namespace PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLC圆形图控件实现类
{
    /// <summary>
    /// 圆形图基础接口
    /// </summary>
    public interface ControlDoughnutChartClassBase
    {
        /// <summary>
        /// 圆形图标题
        /// </summary>
        public string TitleText { get; set; }
        /// <summary>
        /// 圆形图标题
        /// </summary>
        public string TitleSubText { get; set; }
    }
}
