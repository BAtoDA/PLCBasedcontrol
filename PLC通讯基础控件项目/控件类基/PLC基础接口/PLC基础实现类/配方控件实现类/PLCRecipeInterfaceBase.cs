using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using PLC通讯基础控件项目.控件类基.控件数据结构;
using PLC通讯库.通讯枚举;

namespace PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.配方控件实现类
{
    /// <summary>
    /// PLC配方控件基础接口
    /// </summary>
    public interface PLCRecipeInterfaceBase
    {
        /// <summary>
        /// 保存PLC配方基础类
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        PLCRecipeClassBase[] PLCRecipeClass { get; set; }
        /// <summary>
        /// 从PLC读取值
        /// </summary>
        bool PLCRead { get; set; }
        /// <summary>
        /// 下载值到PLC中
        /// </summary>
        bool PlCWrite { get; set; }
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
        /// 用于加载配置使用
        /// </summary>
        Timer Timerconfiguration { get; set; }

    }
}
