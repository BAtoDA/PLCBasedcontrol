//**********************************************************************
//
// 文件名称(File Name)：
// 功能描述(Description)：
// 作者(Author)：DAtoTA
// 日期(Create Date)： 2021/9/5 9:15:11
//
//**********************************************************************
using System;
using System.Collections.Generic;
using System.Text;
using PLC通讯库.内部软元件.通讯实现;
using PLC通讯库.通讯实现类;
using System.Net;

namespace PLC通讯库.PLC通讯设备类型表
{
    /// <summary>
    /// PLC可以通讯类型表
    /// 后面方便切换通讯类型
    /// Key：是PLC设备名称 Value：是对应的PLC通讯对象
    /// 但是必须设置对应的IP地址 默认127.0.0.1 Port 2000
    /// </summary>
    public class IPLCsurface
    {
        /// <summary>
        /// PLC通讯表
        /// </summary>
        public volatile static Dictionary<string, object> PLCDictionary = new Dictionary<string, object>()
        {
           // {"HMI",new IPLCcommunicationBase(new System.Net.IPEndPoint(IPAddress.Parse("127.0.0.0"),2000),new HmiInteriorElementBase("127.0.0.0",2000),1000,1000)}
        };
        /// <summary>
        /// 添加PLC通讯表对象
        /// </summary>
        /// <param name="Key">PLC类型名称</param>
        /// <param name="Value">PLC通讯对象</param>
        public void PLCDictionaryAdd(string Key,object Value)
        {
            _=Key == null ? throw new Exception("传入Key数据为空") : Value == null ? throw new Exception("传入Value数据为空") : Value;
            _=PLCDictionary.ContainsKey(Key) ? throw new Exception("该Key数据已经存在") : false;
            PLCDictionary.Add(Key, Value);
        }
    }
}
