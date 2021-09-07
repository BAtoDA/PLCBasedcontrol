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
    [Serializable]
    public  class PLCPreferences: IComponent
    {
        /// <summary>
        /// PLC类型
        /// 默认三菱
        /// </summary>
        public  PLC PLCDevice { get; set; } = PLC.Mitsubishi;
        /// <summary>
        /// PLCIP
        /// </summary>

        public string IPEnd { get; set; } = "127.0.0.1";
        /// <summary>
        /// PLC 端口
        /// </summary>
        public int Point { get; set; } = 2000;
        /// <summary>
        /// 发送报文超时时间
        /// </summary>
        public int Sendovertime { get; set; } = 1000;
        /// <summary>
        /// 接收报文超时时间
        /// </summary>
        public int Receptionovertime { get; set; } = 1000;
        /// <summary>
        /// 预留属性
        /// </summary>
        public object Retain { get; set; } = " ";
        #region 实现接口
        public ISite Site { get; set; }

        public event EventHandler Disposed;

        public void Dispose()
        {
           
        }
        #endregion
    }
}
