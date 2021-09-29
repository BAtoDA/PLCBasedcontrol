using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Reflection;
using System.ComponentModel;
using System.Linq;
using FanucRobot;
using HslCommunication;

namespace PLC通讯库.发那科机器人通讯实现.通讯实现
{
    /// <summary>
    /// 实现发那科机器人通讯  
    /// 继承FanucRobIntelface 自动产生报文
    /// </summary>
    public sealed class FANUCRobotBase: FanucRobIntelface
    {
        public string IpAddress { get => this.ipAddr; set => this.ipAddr = value; }
        public int Port { get => this.port; set => Ports = value; }
        private int Ports;
        public int ConnectTimeOut { get; set; }
        public int ReceiveTimeOut { get; set; }
        //{ get => this._sc.ReceiveTimeout; set { this._sc.ReceiveTimeout = value; this._sc.SendTimeout = value; } }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="ip">机器人IP地址端口固定</param>
        public FANUCRobotBase(string ip,int Port):base(ip)
        {
            IpAddress = ip;
        }
        /// <summary>
        /// 切断通讯
        /// </summary>
        /// <returns></returns>
        public OperateResult ConnectClose()
        {
            this.Disconnect();
            return new OperateResult() { ErrorCode = 0, IsSuccess = true, Message = "0" };
        }
        /// <summary>
        /// 打开通讯链接
        /// </summary>
        /// <returns></returns>
        public OperateResult ConnectServer()
        {
            var Serveroop= this.Connect();
            return new OperateResult() { Message = Serveroop.message, IsSuccess = this.isConnected, ErrorCode = 0 };
        }
        /// <summary>
        /// 读取机器人Bit位线圈操作
        /// </summary>
        /// <param name="address">传入功能码以及地址</param>
        /// <returns></returns>
        public OperateResult<bool> ReadBool(string address)
        {
            //预定义bool数组
            bool[] Boolarray = new bool[1];
            //获取功能判断用户需要读取的功能码
            switch(Getfunction(address))
            {
                case "DI":
                    this.ReadSdI(Convert.ToInt32(Getaddress(address)), Boolarray.Length, ref Boolarray);
                    break;
                case "DO":
                    this.ReadSdo(Convert.ToInt32(Getaddress(address)), Boolarray.Length, ref Boolarray);
                    break;
                case "RI":
                    this.ReadRdi(Convert.ToInt32(Getaddress(address)), Boolarray.Length, ref Boolarray);
                    break;
                case "RO":
                    this.ReadRdo(Convert.ToInt32(Getaddress(address)), Boolarray.Length, ref Boolarray);
                    break;
                case "UI":
                    this.ReadRui(Convert.ToInt32(Getaddress(address)), Boolarray.Length, ref Boolarray);
                    break;
                case "UO":
                    this.ReadRuo(Convert.ToInt32(Getaddress(address)), Boolarray.Length, ref Boolarray);
                    break;
                default:
                    return new OperateResult<bool>() { Content = Boolarray[0], ErrorCode = 0, IsSuccess = false, Message = $"当前输入的{address}无法解析" };
            }
            return new OperateResult<bool>() { Content = Boolarray[0], ErrorCode = 0, IsSuccess = true, Message = "0" };
        }
        /// <summary>
        /// 写入机器人对应线圈
        /// </summary>
        /// <param name="address">功能码以及地址</param>
        /// <param name="value">写入值</param>
        /// <returns></returns>
        public OperateResult Write(string address,bool value)
        {
            //预定义bool数组
            bool[] Boolarray = new bool[1] { value};
            //获取功能判断用户需要读取的功能码
            switch (Getfunction(address))
            { 
                case "DO":
                    this.WriteSdo(Boolarray, Convert.ToInt32(Getaddress(address)));
                    break;
                case "RO":
                    this.WriteRdo(Boolarray, Convert.ToInt32(Getaddress(address)));
                    break;
                case "UO":
                    this.WriteUo(Boolarray, Convert.ToInt32(Getaddress(address)));
                    break;
                case "RI":
                case "DI":
                case "UI":
                default:
                    return new OperateResult<bool>() { Content = Boolarray[0], ErrorCode = 0, IsSuccess = false, Message = $"当前输入的{address}无法解析" };
            }
            return new OperateResult<bool>() { Content = Boolarray[0], ErrorCode = 0, IsSuccess = true, Message = "0" };
        }
        /// <summary>
        /// 读取有符号单个个字
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public OperateResult<short> ReadInt16(string address)
        {
            switch (Getfunction(address))
            {
                case "R":
                    int addre = Convert.ToInt32(Getaddress(address));
                    if(addre>99)
                        return new OperateResult<short>() { Content = 0, ErrorCode = 0, IsSuccess = false, Message = $"当前输入的{address}无法解析" };
                    return new OperateResult<short>() { Content =Convert.ToInt16(this.intRegs[addre]), ErrorCode = 0, IsSuccess = false, Message = $"当前输入的{address}无法解析" };
                default:
                    return new OperateResult<short>() { Content = 0, ErrorCode = 0, IsSuccess = false, Message = $"当前输入的{address}无法解析" };
            }
        }
        /// <summary>
        /// 读取有符号双字
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public OperateResult<int> ReadInt32(string address)
        {
            switch (Getfunction(address))
            {
                case "R":
                    int addre = Convert.ToInt32(Getaddress(address));
                    if (addre > 99)
                        return new OperateResult<int>() { Content = 0, ErrorCode = 0, IsSuccess = false, Message = $"当前输入的{address}无法解析" };
                    return new OperateResult<int>() { Content = Convert.ToInt32(this.intRegs[addre]), ErrorCode = 0, IsSuccess = false, Message = $"当前输入的{address}无法解析" };
                default:
                    return new OperateResult<int>() { Content = 0, ErrorCode = 0, IsSuccess = false, Message = $"当前输入的{address}无法解析" };
            }
        }
        /// <summary>
        /// 读取无符号单个字
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public OperateResult<ushort> ReadUInt16(string address)
        {
            switch (Getfunction(address))
            {
                case "R":
                    int addre = Convert.ToInt32(Getaddress(address));
                    if (addre > 99)
                        return new OperateResult<ushort>() { Content = 0, ErrorCode = 0, IsSuccess = false, Message = $"当前输入的{address}无法解析" };
                    return new OperateResult<ushort>() { Content = Convert.ToUInt16(this.intRegs[addre]), ErrorCode = 0, IsSuccess = false, Message = $"当前输入的{address}无法解析" };
                default:
                    return new OperateResult<ushort>() { Content = 0, ErrorCode = 0, IsSuccess = false, Message = $"当前输入的{address}无法解析" };
            }
        }
        /// <summary>
        /// 读取无符号双字
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public OperateResult<uint> ReadUInt32(string address)
        {
            switch (Getfunction(address))
            {
                case "R":
                    int addre = Convert.ToInt32(Getaddress(address));
                    if (addre > 99)
                        return new OperateResult<uint>() { Content = 0, ErrorCode = 0, IsSuccess = false, Message = $"当前输入的{address}无法解析" };
                    return new OperateResult<uint>() { Content = Convert.ToUInt32(this.intRegs[addre]), ErrorCode = 0, IsSuccess = false, Message = $"当前输入的{address}无法解析" };
                default:
                    return new OperateResult<uint>() { Content = 0, ErrorCode = 0, IsSuccess = false, Message = $"当前输入的{address}无法解析" };
            }
        }

        /// <summary>
        /// 读取浮点小数
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public OperateResult<float> ReadFloat(string address)
        {
            switch (Getfunction(address))
            {
                case "R":
                    int addre = Convert.ToInt32(Getaddress(address));
                    if (addre > 99)
                        return new OperateResult<float>() { Content = 0, ErrorCode = 0, IsSuccess = false, Message = $"当前输入的{address}无法解析" };
                    return new OperateResult<float>() { Content = Convert.ToSingle(this.intRegs[addre]), ErrorCode = 0, IsSuccess = false, Message = $"当前输入的{address}无法解析" };
                default:
                    return new OperateResult<float>() { Content = 0, ErrorCode = 0, IsSuccess = false, Message = $"当前输入的{address}无法解析" };
            }
        }
        public OperateResult<short> Write(string address,short Value)
        {
            switch (Getfunction(address))
            {
                case "R":
                    int addre = Convert.ToInt32(Getaddress(address));
                    if (addre > 99)
                        return new OperateResult<short>() { Content = 0, ErrorCode = 0, IsSuccess = false, Message = $"当前输入的{address}无法解析" };
                    this.WriteR(new int[] { Value }, addre);
                    return new OperateResult<short>() { Content = 0, ErrorCode = 0, IsSuccess = false, Message = $"当前输入的{address}无法解析" };
                default:
                    return new OperateResult<short>() { Content = 0, ErrorCode = 0, IsSuccess = false, Message = $"当前输入的{address}无法解析" };
            }
        }
        public OperateResult<int> Write(string address, int Value)
        {
            switch (Getfunction(address))
            {
                case "R":
                    int addre = Convert.ToInt32(Getaddress(address));
                    if (addre > 99)
                        return new OperateResult<int>() { Content = 0, ErrorCode = 0, IsSuccess = false, Message = $"当前输入的{address}无法解析" };
                    this.WriteR(new int[] { Value }, addre);
                    return new OperateResult<int>() { Content = 0, ErrorCode = 0, IsSuccess = false, Message = $"当前输入的{address}无法解析" };
                default:
                    return new OperateResult<int>() { Content = 0, ErrorCode = 0, IsSuccess = false, Message = $"当前输入的{address}无法解析" };
            }
        }
        public OperateResult<ushort> Write(string address, ushort Value)
        {
            switch (Getfunction(address))
            {
                case "R":
                    int addre = Convert.ToInt32(Getaddress(address));
                    if (addre > 99)
                        return new OperateResult<ushort>() { Content = 0, ErrorCode = 0, IsSuccess = false, Message = $"当前输入的{address}无法解析" };
                    this.WriteR(new int[] { Value }, addre);
                    return new OperateResult<ushort>() { Content = 0, ErrorCode = 0, IsSuccess = false, Message = $"当前输入的{address}无法解析" };
                default:
                    return new OperateResult<ushort>() { Content = 0, ErrorCode = 0, IsSuccess = false, Message = $"当前输入的{address}无法解析" };
            }
        }
        public OperateResult<uint> Write(string address, uint Value)
        {
            switch (Getfunction(address))
            {
                case "R":
                    int addre = Convert.ToInt32(Getaddress(address));
                    if (addre > 99)
                        return new OperateResult<uint>() { Content = 0, ErrorCode = 0, IsSuccess = false, Message = $"当前输入的{address}无法解析" };
                    this.WriteR(new int[] { Convert.ToInt32(Value) }, addre);
                    return new OperateResult<uint>() { Content = 0, ErrorCode = 0, IsSuccess = false, Message = $"当前输入的{address}无法解析" };
                default:
                    return new OperateResult<uint>() { Content = 0, ErrorCode = 0, IsSuccess = false, Message = $"当前输入的{address}无法解析" };
            }
        }
        public OperateResult<float> Write(string address, float Value)
        {
            switch (Getfunction(address))
            {
                case "R":
                    int addre = Convert.ToInt32(Getaddress(address));
                    if (addre > 99)
                        return new OperateResult<float>() { Content = 0, ErrorCode = 0, IsSuccess = false, Message = $"当前输入的{address}无法解析" };
                    this.WriteR(new int[] { Convert.ToInt32(Value) }, addre);
                    return new OperateResult<float>() { Content = 0, ErrorCode = 0, IsSuccess = false, Message = $"当前输入的{address}无法解析" };
                default:
                    return new OperateResult<float>() { Content = 0, ErrorCode = 0, IsSuccess = false, Message = $"当前输入的{address}无法解析" };
            }
        }
        /// <summary>
        /// 获取功能码
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        private string Getfunction(string Name)
        {
            return System.Text.RegularExpressions.Regex.Replace(Name??"00".ToUpper(), @"[^A-Z]+", "");
        }
        /// <summary>
        /// 获取地址
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        private string Getaddress(string Name)
        {
            return System.Text.RegularExpressions.Regex.Replace(Name ?? "00".ToUpper(), @"[^0-9]+", "");
        }
    }
}