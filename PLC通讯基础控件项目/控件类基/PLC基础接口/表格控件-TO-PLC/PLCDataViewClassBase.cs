using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using PLC通讯基础控件项目.控件类基.控件数据结构;

namespace PLC通讯基础控件项目.控件类基.PLC基础接口.表格控件_TO_PLC
{
    /// <summary>
    /// 用于表格控件对PLC以及SQL
    /// 操作读取 写入 更新等基础接口
    /// </summary>
    public interface PLCDataViewClassBase
    {
        /// <summary>
        /// 修改参数界面启动事件
        /// </summary>
        event EventHandler Modification;
        /// <summary>
        /// 修改参数界面方法
        /// </summary>
        /// <param name="send"></param>
        /// <param name="e"></param>
        void Modifications_Eeve(object send, EventArgs e);
        /// <summary>
        /// 用于处理控件参数
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        PLCDataViewselectRealize pLCDataViewselectRealize { get; set; }
        /// <summary>
        /// 用于给用户选择PLC使用
        /// </summary>
        PLCSet APLC { get; set; }
        /// <summary>
        /// 用于加载配置使用
        /// </summary>
        Timer Timerconfiguration { get; set; }
        /// <summary>
        /// 读取控制
        /// </summary>
        bool ReadCommand { get; set; }
    }
}
