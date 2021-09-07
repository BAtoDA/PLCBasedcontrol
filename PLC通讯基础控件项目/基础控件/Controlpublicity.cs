//**********************************************************************
//
// 文件名称(File Name)：
// 功能描述(Description)：
// 作者(Author)：DAtoTA
// 日期(Create Date)： 2021/9/5 17:49:51
//
//**********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PLC通讯基础控件项目.基础控件
{
    /// <summary>
    /// 用于处理一些控件的共有方法
    /// </summary>
    class Controlpublicity
    {
        /// <summary>
        /// 判断程序是否在运行
        /// true 该程序在电脑进程运行中  false 表示不在进程运行
        /// 该方法主要用于避免继承过程中CLR 进入SQL数据库 查询数据从而卡死软件
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public static bool GetPidByProcess(string Name = "PLC通讯基础控件项目")
        {
            return System.Diagnostics.Process.GetProcessesByName(Name).ToList().Count > 0 ? true : false;
        }

    }
}
