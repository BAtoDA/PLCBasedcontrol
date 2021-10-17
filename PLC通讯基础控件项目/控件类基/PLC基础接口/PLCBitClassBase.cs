using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类;
using PLC通讯基础控件项目.控件类基.控件数据结构;

namespace PLC通讯基础控件项目.控件类基.PLC基础接口
{
    /// <summary>
    /// 控件修改参数界面
    /// </summary>
    public interface PLCBitClassBase
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
        PLCBitselectRealize pLCBitselectRealize { get; set; }
        /// <summary>
        /// 用于给用户选择PLC使用
        /// </summary>
        PLCSet APLC { get; set; }
        /// <summary>
        /// 用于加载配置使用
        /// </summary>
        Timer Timerconfiguration { get; set; }
        /// <summary>
        /// 切换控件状态方法
        /// 该方法必须实现
        /// </summary>
        void ControlSwitch(bool switchover);
    }
}
