using PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLC二维码控件实现类;
using PLC通讯基础控件项目.控件类基.控件数据结构;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace PLC通讯基础控件项目.控件类基.PLC基础接口
{
    /// <summary>
    /// 二维码以及条形码
    /// 基础控件接口
    /// </summary>
    public interface PLCQRcodeBaseRealize
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
        PLCQRcodeRealize pLCQRcodeRealize { get; set; }
        /// <summary>
        /// 用于给用户选择PLC使用
        /// </summary>
        PLCSet APLC { get; set; }
        /// <summary>
        /// 用于加载配置使用
        /// </summary>
        Timer Timerconfiguration { get; set; }
    }
}
