using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HD烟灶联动项目.PLC控制
{
    /// <summary>
    /// 与PLC互交标准接口
    /// </summary>
    public interface PLCInterface
    {

        /// <summary>
        /// PLC调度任务启动
        /// </summary>
        [Browsable(false)]
         bool PlcStart { set; get; }

        /// <summary>
        /// 任务运行中
        /// </summary>
        [Browsable(false)]        
         bool TaskBusy { set; get; }
        /// <summary>
        /// 任务结论
        /// </summary>
        [Browsable(false)]
        Int16 TaskConclusion { set; get; }
        /// <summary>
        /// 任务运行事件
        /// </summary>

        event EventHandler TaskEventRun;
        /// <summary>
        /// 任务运行异常
        /// </summary>

        event EventHandler TaskEventErr;

    }
}
