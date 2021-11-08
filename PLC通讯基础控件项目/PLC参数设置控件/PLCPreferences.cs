//**********************************************************************
//
// 文件名称(File Name)：
// 功能描述(Description)：
// 作者(Author)：DAtoTA
// 日期(Create Date)： 2021/9/5 21:12:07
//
//**********************************************************************
using System;
using System.Collections.Generic;
using System.Text;
using PLC通讯基础控件项目.控件类基.控件数据结构;
using System.Net;
using System.ComponentModel;

namespace PLC通讯基础控件项目.PLC参数设置控件
{
    /// <summary>
    /// PLC参数设置类
    /// 不可以继承重写 可序列化
    /// </summary>
    [ToolboxItem(false)]
    [Browsable(false)]
    [Serializable]
    public sealed class PLCPreferences: IComponent
    {
        /// <summary>
        /// PLC类型
        /// 默认三菱
        /// </summary>
        [Description("PLC类型\r\n 默认选择三菱PLC目前可以选择三菱 西门子 \r\nModbusTCP 欧姆龙 发那科等"), Category("PLC参数")]
        public  PLC PLCDevice { get; set; } = PLC.Mitsubishi;
        /// <summary>
        /// PLCIP
        /// </summary>
        [Description("连接PLC的IP地址\r\n输入注意格 默认：127.0.0.1"), Category("PLC参数")]
        public string IPEnd { get; set; } = "127.0.0.1";
        /// <summary>
        /// PLC 端口
        /// </summary>
        [Description("连接PLC的IP地址端口\r\n西门子默认 102端口 \r\n三菱默认4999 ModbusTCP默认502"), Category("PLC参数")]
        public int Point { get; set; } = 2000;
        /// <summary>
        /// 发送报文超时时间
        /// </summary>
        [Description("对PLC发送报文超时时间\r\n默认1000不得低于1000"), Category("PLC参数")]
        public int Sendovertime { get; set; } = 1000;
        /// <summary>
        /// 接收报文超时时间
        /// </summary>
        [Description("对PLC接收报文超时时间\r\n默认1000不得低于1000"), Category("PLC参数")]
        public int Receptionovertime { get; set; } = 1000;
        /// <summary>
        /// 预留属性
        /// </summary>
        [Description("对PLC进行标识属性\r\n 假设选择西门子S1500PLC 那么就填写S1500 \r\nS1200 就是S1200 \r\n选择了三菱PLC填写PLC系列 假设 FX "), Category("PLC参数")]
        public string Retain { get; set; } = "S1500";
        #region 实现接口
        public ISite Site { get; set; }

        public event EventHandler Disposed;

        public void Dispose()
        {
           
        }
        #endregion
    }
}
