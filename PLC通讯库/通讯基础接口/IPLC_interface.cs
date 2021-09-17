﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using PLC通讯库.通讯枚举;

namespace PLC通讯库.通讯基础接口
{
    /// <summary>
    /// PLC实现接口--规范定义的方法名称
    /// </summary>
    public interface IPLC_interface//规范定义的方法名称
    {
        /// <summary>
        /// 写入PLC次数
        /// </summary>
        long WriteContn { get; }
        /// <summary>
        /// 读取PLC次数
        /// </summary>
        long ReadContn { get; }
        /// <summary>
        /// PLC IP与端口
        /// </summary>
        IPEndPoint IPEndPoint { get; set; }
        /// <summary>
        /// PLC准备好
        /// </summary>
        bool PLC_ready { get; }//PLC准备好
        /// <summary>
        /// PLC报警代码
        /// </summary>
        int PLCerr_code { get; }//PLC报警代码
        /// <summary>
        /// PLC报警内容
        /// </summary>
        string PLCerr_content { get; }//PLC报警内容
        /// <summary>
        /// 打开PLC
        /// </summary>
        /// <returns></returns>
        string PLC_open();//打开PLC
        /// <summary>
        /// 读取--位
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        bool PLC_read_M_bit(string Name, string id);//读取--位
        /// <summary>
        /// /写入--位
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="id"></param>
        /// <param name="button_State"></param>
        /// <returns></returns>
        bool PLC_write_M_bit(string Name, string id, Button_state button_State);//写入--位
        /// <summary>
        /// /读取--字
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="id"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        string PLC_read_D_register(string Name, string id, numerical_format format);//读取--字
        /// <summary>
        /// 读写--字
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="id"></param>
        /// <param name="content"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        string PLC_write_D_register(string Name, string id, string content, numerical_format format);//读写--字
        /// <summary>
        /// 读取--字--多个读取-自动判断类型改变地址索引
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Array PLC_read_D_register_bit(string Name, string id, numerical_format format, ushort Index);//读取--字--多个读取
        /// <summary>
        /// 读写--字
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        List<int> PLC_write_D_register_bit(string id);//读写--字
    }
}
