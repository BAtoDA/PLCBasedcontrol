using PLC通讯基础控件项目.控件类基.控件数据结构;
using PLC通讯库.通讯枚举;
using System;
using System.Collections.Generic;
using System.Text;

namespace PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLC二维码控件实现类
{
    /// <summary>
    /// 条形码以及二维码
    /// 基础接口
    /// </summary>
    public interface PLCQRcodeBase
    {
        /// <summary>
        /// 选择条形码以及二维码
        /// </summary>
        public bool Select { get; set; }
        /// <summary>
        /// 控件绑定开启
        /// 开启后需要选中目标窗口的一个Button类型控件作为触发点
        /// </summary>
        bool BindingOpen { get; set; }
        /// <summary>
        /// 判断控件的Name名称
        /// </summary>
        string BindingName { get; set; }

        /// <summary>
        /// 读取或者写入PLC类型
        /// </summary>
        PLC ReadWritePLC { get; set; }
        /// <summary>
        /// 读取或者写入PLC的功能码
        /// </summary>
        string ReadWriteFunction { get; set; }
        /// <summary>
        /// 读取或者写入PLC的具体地址
        /// </summary>
        string ReadWriteAddress { get; set; }
        /// <summary>
        /// 读取数据的资料格式
        /// </summary>
        numerical_format ShowFormat { get; set; }

        /// <summary>
        /// 写入PLC类型
        /// </summary>
        PLC WritePLC { get; set; }
        /// <summary>
        /// 写入PLC的功能码
        /// </summary>
        string WriteFunction { get; set; }
        /// <summary>
        /// 写入PLC的具体地址
        /// </summary>
        string WriteAddress { get; set; }


    }
}
