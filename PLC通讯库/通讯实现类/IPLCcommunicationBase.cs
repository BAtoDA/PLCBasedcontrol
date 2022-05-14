using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using HslCommunication;
using HslCommunication.Profinet;
using HslCommunication.Profinet.Melsec;
using PLC通讯库.通讯基础接口;
using PLC通讯库.通讯枚举;

namespace PLC通讯库.通讯实现类
{
    /// <summary>
    /// 继承接口IPLC_interface 
    /// PLC通讯类基实现类
    /// </summary>
    public class IPLCcommunicationBase : PLC_public_Class, IPLC_interface
    {
        /// <summary>
        /// IP地址
        /// </summary>
        public IPEndPoint IPEndPoint { get; set; }//IP地址
        private bool PLC_ready;//内部PLC状态
        private int PLCerr_code;//内部报警代码
        private string PLCerr_content;//内部报警内容
        private long WriteContn;//内部写入次数
        private long ReadContn;//内部读取次数
        /// <summary>
        /// PLC通讯类
        /// </summary>
        private dynamic melsec_net;//实例化对象;
        /// <summary>
        /// 互斥锁(Mutex)，用于多线程中防止两条线程同时对一个公共资源进行读写的机制
        /// </summary>
        Mutex mutex= new Mutex();//实例化互斥锁(Mutex);//定义互斥锁名称
        //实现接口的属性
        /// <summary>
        /// 写入PLC次数
        /// </summary>
        long IPLC_interface.WriteContn { get => WriteContn; }
        /// <summary>
        /// 读取PLC次数
        /// </summary>
        long IPLC_interface.ReadContn { get => ReadContn; }
        /// <summary>
        /// PLC状态
        /// </summary>
        bool  IPLC_interface.PLC_ready
        {
            get 
            {
                return (bool)this.GetType().GetField("PLC_ready", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance).GetValue(this);
            }
        } //PLC状态
        /// <summary>
        /// PLC报警代码
        /// </summary>
        int IPLC_interface.PLCerr_code { get => PLCerr_code; }//PLC报警代码
        /// <summary>
        /// PLC报警内容
        /// </summary>
        string IPLC_interface.PLCerr_content { get => PLCerr_content; }//PLC报警内容
        /// <summary>
        /// 三菱PLC枚举
        /// </summary>
        public MitsubishiPLC mitsubishiPLC= MitsubishiPLC.FX;
        /// <summary>
        /// 初始化PLC需要传入类型
        /// </summary>
        /// <param name="iPEndPoint">端口与地址</param>
        ///  <param name="melsec_net">需要进行通讯的PLC对象</param>
        public IPLCcommunicationBase(IPEndPoint iPEndPoint, object melsec_net,int ConnectTimeOut,int ReceiveTimeOut)//构造函数---初始化---open
        {
            this.IPEndPoint = iPEndPoint;//获取IP地址
            this.melsec_net = melsec_net;//实例化对象
            this.melsec_net.ConnectTimeOut = ConnectTimeOut>1000?ConnectTimeOut:1000;
            this.melsec_net.ReceiveTimeOut = ReceiveTimeOut>1000? ReceiveTimeOut:1000;
        }
        /// <summary>
        /// 初始化PLC需要传入类型--三菱PLC
        /// </summary>
        /// <param name="iPEndPoint">端口与地址</param>
        ///  <param name="melsec_net">需要进行通讯的PLC对象</param>
        public IPLCcommunicationBase(IPEndPoint iPEndPoint, object melsec_net, int ConnectTimeOut, int ReceiveTimeOut, MitsubishiPLC mitsubishiPLC)//构造函数---初始化---open
        {
            this.IPEndPoint = iPEndPoint;//获取IP地址
            this.melsec_net = melsec_net;//实例化对象
            this.melsec_net.ConnectTimeOut = ConnectTimeOut > 1000 ? ConnectTimeOut : 1000;
            this.melsec_net.ReceiveTimeOut = ReceiveTimeOut > 1000 ? ReceiveTimeOut : 1000;
            this.mitsubishiPLC = mitsubishiPLC;
        }
        /// <summary>
        /// 初始构造函数
        /// 默认三菱PLC
        /// </summary>
        public IPLCcommunicationBase()
        {
            this.IPEndPoint =new IPEndPoint(IPAddress.Parse("127.0.0.1"),2000);//获取IP地址
            this.melsec_net =new MelsecMcNet();//实例化对象
            //HslCommunication.Profinet.Omron.OmronFinsUdp
        }
        /// <summary>
        /// 链接PLC
        /// </summary>
        /// <returns></returns>
        public string PLC_open()
        {
            if (melsec_net == null) return "链接PLC异常";
            lock (this)
            {
                try
                {
                    PLCerr_content = null;
                    melsec_net.IpAddress = IPEndPoint.Address.ToString();//获取设置的IP
                    melsec_net.Port = IPEndPoint.Port;//获取设置的端口
                    melsec_net.ConnectClose();//切换通讯模式
                    OperateResult connect = melsec_net.ConnectServer();//获取操作结果
                    retry = 0;
                    if (connect.IsSuccess)//判断是否连接成功
                    {
                        PLC_ready = true;//PLC开放正常
                        return "已成功链接到" + this.IPEndPoint.Address;
                    }
                    else
                    {
                        PLC_ready = false;//PLC开放异常
                                          // 切断连接
                        melsec_net.ConnectClose();
                        return "链接PLC异常";//尝试连接PLC，如果连接成功则返回值为0
                    }
                }
                catch (Exception e)
                {
                    err(e);//异常处理
                    return "链接PLC异常";//尝试连接PLC，如果连接成功则返回值为0
                }
            }
        }
        /// <summary>
        /// 读取PLC 位状态 --D_bit这类需要自己在表流获取当前位状态--M这类不需要
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public  bool PLC_read_M_bit(string Name, string id)
        {
            string result = "false";//定义获取数据变量
            try
            {
                dynamic PLCData = "";
                //三菱PLC处理
                if (this.melsec_net.GetType().Name == "MelsecMcNet")
                {
                    PLCData = MelsecMcNet();
                    readResultRender(PLCData, Name.Trim() + id.Trim(), ref result);
                    return PLCData.Content != null ? PLCData.Content[0] : false;
                }
                if (this.melsec_net.GetType().Name == "ModbusTcpNet")
                {
                    PLCData = ModbusTcpNet();
                    readResultRender(PLCData, Name.Trim() + id.Trim(), ref result);
                    return PLCData.Content != null ? PLCData.Content : false;
                }
                if(this.melsec_net.GetType().Name== "OmronFinsNet" || this.melsec_net.GetType().Name == "OmronFinsUdp")
                {
                    //欧姆龙处理UDP TCP
                    PLCData = melsec_net.ReadBool(Name + id);
                    readResultRender(PLCData, Name.Trim() + id.Trim(), ref result);
                    return PLCData.Content != null ? PLCData.Content[0] : false;
                }
                //西门子//欧姆龙处理CIP//内部HMI处理
                PLCData = melsec_net.ReadBool(Name + id);
                readResultRender(PLCData, Name.Trim() + id.Trim(), ref result);
                return PLCData.Content != null ? PLCData.Content: false;

            }
            catch { }
            return result.ToLower() == "true" ? true : false;//返回数据

            dynamic MelsecMcNet()
            {
                dynamic PLCData = "";
                //判断当前PLC类型--8进制
                switch (mitsubishiPLC)
                {
                    case MitsubishiPLC.FX:
                        if ((Name != "X") & (Name != "Y"))
                        {
                            //判断是否读取寄存器的Bit位操作
                            Regex rq = new Regex("Bit");
                            //不是读取输入输出点
                            return PLCData = rq.IsMatch(Name) ? MelsecMcNetBit() : melsec_net.ReadBool(Name + id, 1);
                        }
                        else
                        {
                            //读取输入输出点位
                            var Idto8 = Convert.ToInt16(id, 8).ToString("X");
                            return PLCData = melsec_net.ReadBool(Name + Idto8, 1);
                        }
                    case MitsubishiPLC.L:
                    case MitsubishiPLC.R:
                    case MitsubishiPLC.Q:
                        if ((Name != "X") & (Name != "Y"))
                        {
                            //判断是否读取寄存器的Bit位操作
                            Regex rq = new Regex("Bit");
                            //不是读取输入输出点
                            return PLCData = rq.IsMatch(Name) ? MelsecMcNetBit() : melsec_net.ReadBool(Name + id, 1);
                        }
                        else
                            return PLCData = melsec_net.ReadBool(Name + id,1);
                }
                return null;
            }
            dynamic ModbusTcpNet()
            {
                dynamic PLCData = "";
                return PLCData = melsec_net.ReadCoil(id);
            }
            dynamic MelsecMcNetBit()//三菱寄存器Bit位处理
            {
                if (id.IndexOf('.') > -1)
                {
                    var IdArray = id.Split('.');
                    var Data = this.PLC_read_D_register(Name[0].ToString(),  IdArray[0], numerical_format.Signed_32_Bit);
                    var DataBitArray = this.ConvertIntToBoolArray(Convert.ToInt32(Data), 32).Reverse().ToArray();
                    //返回数据
                    return new OperateResult<bool[]>() { Content = new bool[] { DataBitArray[Convert.ToInt32(TryStringTOint(IdArray[1]))] }, ErrorCode = 0, IsSuccess = true, Message = "0" };
                }
                return new OperateResult<bool[]>();
            }
        }
        /// <summary>
        /// 批量读取位
        /// </summary>
        /// <param name="Name">PLC功能码</param>
        /// <param name="id">PLC地址</param>
        /// <param name="Count">批量读取个数 三菱最大7千 西门子待测试 欧姆龙待测试</param>
        /// <returns>返回泛型列表</returns>
        public bool[] PLC_read_M_bit(string Name, string id,ushort Count)
        {
            bool[] result = new bool[Count];//定义获取数据变量
            dynamic PLCData;
            try
            {
                //三菱PLC处理
                if (this.melsec_net.GetType().Name == "MelsecMcNet")
                {
                    PLCData = MelsecMcNet();
                    //readResultRender(PLCData, Name.Trim() + id.Trim());
                    if (PLCData is OperateResult<bool[]>)
                        return PLCData.Content;
                    else
                        return result;
                    //return PLCData != null ? PLCData.Content : result;
                }
                if (this.melsec_net.GetType().Name == "ModbusTcpNet")
                {
                    PLCData = ModbusTcpNet();
                    //readResultRender(PLCData, Name.Trim() + id.Trim());
                    return PLCData.Content != null ? PLCData.Content : result;
                }
                if (this.melsec_net.GetType().Name == "OmronFinsNet" || this.melsec_net.GetType().Name == "OmronFinsUdp")
                {
                    //欧姆龙处理UDP TCP
                    PLCData = melsec_net.ReadBool(Name + id, Count);
                    //readResultRender(PLCData, Name.Trim() + id.Trim());
                    return PLCData.Content != null ? PLCData.Content : result;
                }
                //西门子//欧姆龙处理CIP//内部HMI处理
                PLCData = melsec_net.ReadBool(Name + id, Count);
                //readResultRender(PLCData, Name.Trim() + id.Trim());
                if (PLCData is OperateResult<bool[]>)
                    return PLCData.Content;
                else
                    return result;
                //return PLCData != null ? PLCData.Content : result;

            }
            catch
            {
            
            }
            return result;//返回数据

            dynamic MelsecMcNet()
            {
                dynamic PLCData;
                //判断当前PLC类型--8进制
                switch (mitsubishiPLC)
                {
                    case MitsubishiPLC.FX:
                        if ((Name != "X") & (Name != "Y"))
                        {
                            //判断是否读取寄存器的Bit位操作
                            Regex rq = new Regex("Bit");
                            //不是读取输入输出点
                            return PLCData = rq.IsMatch(Name) ? MelsecMcNetBit() : melsec_net.ReadBool(Name + id, Count);
                        }
                        else
                        {
                            //读取输入输出点位
                            var Idto8 = Convert.ToInt16(id, 8);
                            var IdtoD= melsec_net.ReadBool(Name + Idto8, Count);
                            return IdtoD;
                        }
                    case MitsubishiPLC.L:
                    case MitsubishiPLC.R:
                    case MitsubishiPLC.Q:
                        if ((Name != "X") & (Name != "Y"))
                        {
                            //判断是否读取寄存器的Bit位操作
                            Regex rq = new Regex("Bit");
                            //不是读取输入输出点
                            return PLCData = rq.IsMatch(Name) ? MelsecMcNetBit() : melsec_net.ReadBool(Name + id, Count);

                        }
                        else
                        {
                            return PLCData = melsec_net.ReadBool(Name + id, Count);
                        }



                }
                return null;
            }
            dynamic ModbusTcpNet()
            {
                dynamic PLCData = "";
                return PLCData = melsec_net.ReadCoil(id, Count);
            }
            dynamic MelsecMcNetBit()//三菱寄存器Bit位处理
            {
                if (id.IndexOf('.') > -1)
                {
                    var IdArray = id.Split('.');
                    var Data = this.PLC_read_D_register(Name[0].ToString(), IdArray[0], numerical_format.Signed_32_Bit);
                    var DataBitArray = this.ConvertIntToBoolArray(Convert.ToInt32(Data), 32).Reverse().ToArray();
                    //返回数据
                    return new OperateResult<bool[]>() { Content = new bool[] { DataBitArray[Convert.ToInt32(TryStringTOint(IdArray[1]))] }, ErrorCode = 0, IsSuccess = true, Message = "0" };
                }
                return new OperateResult<bool[]>();
            }
        }
        /// <summary>
        /// 写入PLC 位状态 --D_bit这类需要自己在表流获取当前位状态--M这类不需要
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="id"></param>
        /// <param name="button_State"></param>
        /// <returns></returns>
        public bool PLC_write_M_bit(string Name, string id, Button_state button_State)
        {
            try
            {
                dynamic PLCData = "";
                if (this.melsec_net.GetType().Name == "MelsecMcNet")
                {
                    PLCData = MelsecMcNet();
                    goto Resul;
                }

                if (this.melsec_net.GetType().Name == "ModbusTcpNet")
                {
                    PLCData = ModbusTcpNet();
                    goto Resul;
                }
                //欧姆龙 西门子PLC处理
                PLCData = melsec_net.Write(Name + id, button_State == Button_state.ON ? true : false);

            Resul:
                writeResultRender(PLCData, Name.Trim() + id.Trim());
                return PLCData.IsSuccess;//返回数据
            }
            catch { }

            return false;//返回数据
            dynamic ModbusTcpNet()
            {
                dynamic PLCData = "";
                return PLCData = melsec_net.WriteCoil(id, button_State == Button_state.ON ? true : false);
            }
            dynamic MelsecMcNet()
            {
                dynamic PLCData = "";
                //判断当前PLC类型--8进制
                switch (mitsubishiPLC)
                {
                    case MitsubishiPLC.FX:
                        if ((Name != "X") & (Name != "Y"))
                        {
                            //判断是否读取寄存器的Bit位操作
                            Regex rq = new Regex("Bit");

                            //不是写入输入输出点
                            return PLCData = rq.IsMatch(Name)? MelsecMcNetBit(): melsec_net.Write(Name + id, button_State == Button_state.ON ? true : false);
                        }
                        else
                        {
                            //写入输入输出点位
                            var Idto8 = Convert.ToInt16(id, 8).ToString("X");
                            return PLCData = melsec_net.Write(Name + Idto8, button_State == Button_state.ON ? true : false);
                        }
                    case MitsubishiPLC.L:
                    case MitsubishiPLC.R:
                    case MitsubishiPLC.Q:
                        return PLCData = melsec_net.Write(Name + id, button_State == Button_state.ON ? true : false);
                }
                return new OperateResult<bool[]>();
            }
            dynamic MelsecMcNetBit()//写入寄存器Bit位处理
            {
                if (id.IndexOf('.') > -1)
                {
                    var IdArray = id.Split('.');

                    var Data = this.PLC_read_D_register(Name[0].ToString(), IdArray[0], numerical_format.Signed_16_Bit);
                    var DataBitArray = this.ConvertIntToBoolArray(Convert.ToInt32(Data), 16).Reverse().ToArray();
                    DataBitArray[Convert.ToInt32(TryStringTOint(IdArray[1]))] = button_State == Button_state.ON ? true : false;
                    //回写数据值
                    this.PLC_write_D_register(Name[0].ToString(), IdArray[0], ConvertBoolArrayToInt(DataBitArray.Reverse().ToArray(), 16).ToString(), numerical_format.Signed_16_Bit);
                    //返回数据
                    return new OperateResult<bool[]>() { Content = new bool[] { DataBitArray[Convert.ToInt32(TryStringTOint(IdArray[1]))] }, ErrorCode = 0, IsSuccess = true, Message = "0" };
                }
                return new OperateResult<bool[]>();
            }
        }
        /// <summary>
        ///  读寄存器--转换相应类型
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="id"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public string PLC_read_D_register(string Name, string id, numerical_format format)
        {
            string result = "0";//定义获取数据变量        

            try
            {
                switch (format)
                {
                    case numerical_format.Signed_16_Bit:
                    case numerical_format.BCD_16_Bit:
                        // 读取short变量
                        readResultRender(ReadInt16(), Name.Trim() + id.Trim(), ref result);
                        break;
                    case numerical_format.Signed_32_Bit:
                    case numerical_format.BCD_32_Bit:
                        // 读取int变量
                        readResultRender(ReadInt32(), Name.Trim() + id.Trim(), ref result);
                        break;
                    case numerical_format.Binary_16_Bit:
                        // 读取16位二进制数                      
                        readResultRender(ReadInt16(), Name.Trim() + id.Trim(), ref result);
                        return Convert.ToString(Convert.ToInt32(result), 2);
                    case numerical_format.Binary_32_Bit:
                        // 读取32位二进制数
                        readResultRender(ReadInt32(), Name.Trim() + id.Trim(), ref result);
                        return Convert.ToString(Convert.ToInt32(result), 2);
                    case numerical_format.Float_32_Bit:
                        // 读取float变量
                        readResultRender(ReadFloat(), Name.Trim() + id.Trim(), ref result);
                        break;
                    case numerical_format.Hex_16_Bit:
                        // 读取short变量
                        readResultRender(ReadInt16(), Name.Trim() + id.Trim(), ref result);
                        result = Convert.ToInt32(result).ToString("X");
                        break;
                    case numerical_format.Hex_32_Bit:
                        // 读取int变量
                        readResultRender(ReadInt32(), Name.Trim() + id.Trim(), ref result);
                        result = Convert.ToInt32(result).ToString("X");
                        break;
                    case numerical_format.Unsigned_16_Bit:
                        // 读取ushort变量
                        readResultRender(ReadUInt16(), Name.Trim() + id.Trim(), ref result);
                        break;
                    case numerical_format.Unsigned_32_Bit:
                        // 读取uint变量
                        readResultRender(ReadUInt32(), Name.Trim() + id.Trim(), ref result);
                        break;
                    case numerical_format.String:
                        // 读取uint变量
                        var ResData = ReadString();
                        result = ResData != null? ResData.Content:"Null";
                        //readResultRender(ReadString(), Name.Trim() + id.Trim(), ref result);
                        break;
                }
            }
            catch { }

            OperateResult<short> ReadInt16() => melsec_net.ReadInt16(this.melsec_net.GetType().Name != "ModbusTcpNet" ? Name.Trim() + id.Trim() : id.Trim());
            OperateResult<int> ReadInt32() => melsec_net.ReadInt32(this.melsec_net.GetType().Name != "ModbusTcpNet" ? Name.Trim() + id.Trim() : id.Trim());
            OperateResult<ushort> ReadUInt16() => melsec_net.ReadUInt16(this.melsec_net.GetType().Name != "ModbusTcpNet" ? Name.Trim() + id.Trim() : id.Trim());
            OperateResult<uint> ReadUInt32() => melsec_net.ReadUInt32(this.melsec_net.GetType().Name != "ModbusTcpNet" ? Name.Trim() + id.Trim() : id.Trim());
            OperateResult<float> ReadFloat() => melsec_net.ReadFloat(this.melsec_net.GetType().Name != "ModbusTcpNet" ? Name.Trim() + id.Trim() : id.Trim());
            OperateResult<string> ReadString() => melsec_net.ReadString(this.melsec_net.GetType().Name != "ModbusTcpNet" ? Name.Trim() + id.Trim() : id.Trim(),16,Encoding.UTF8);
            return result;//返回数据
        }
        /// <summary>
        /// 写寄存器--转换类型--并且写入
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="id"></param>
        /// <param name="content"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public string PLC_write_D_register(string Name, string id, string content, numerical_format format)
        {
            string result = "0";//定义获取数据变量           

            try
            {
                switch (format)
                {
                    case numerical_format.Signed_16_Bit:
                    case numerical_format.BCD_16_Bit:
                        writeResultRender(WriteInt16(this.melsec_net.GetType().Name != "ModbusTcpNet" ? Name.Trim() + id.Trim() : id.Trim(), short.Parse(content)), Name.Trim() + id.Trim());
                        break;
                    case numerical_format.Signed_32_Bit:
                    case numerical_format.BCD_32_Bit:
                        writeResultRender(WriteInt32(this.melsec_net.GetType().Name != "ModbusTcpNet" ? Name.Trim() + id.Trim() : id.Trim(), int.Parse(content)), Name.Trim() + id.Trim());
                        break;
                    case numerical_format.Binary_16_Bit:
                        writeResultRender(WriteInt16(this.melsec_net.GetType().Name != "ModbusTcpNet" ? Name.Trim() + id.Trim() : id.Trim(), short.Parse(Convert.ToInt32(content, 2).ToString())), Name.Trim() + id.Trim());
                        break;
                    case numerical_format.Binary_32_Bit:
                        writeResultRender(WriteInt32(this.melsec_net.GetType().Name != "ModbusTcpNet" ? Name.Trim() + id.Trim() : id.Trim(), int.Parse(Convert.ToInt32(content, 2).ToString())), Name.Trim() + id.Trim());
                        break;
                    case numerical_format.Float_32_Bit:
                        writeResultRender(WriteFloat(this.melsec_net.GetType().Name != "ModbusTcpNet" ? Name.Trim() + id.Trim() : id.Trim(), float.Parse(content)), Name.Trim() + id.Trim());
                        break;
                    case numerical_format.Hex_16_Bit:
                        writeResultRender(WriteInt16(this.melsec_net.GetType().Name != "ModbusTcpNet" ? Name.Trim() + id.Trim() : id.Trim(), short.Parse(Convert.ToInt32(content, 16).ToString())), Name.Trim() + id.Trim());
                        break;
                    case numerical_format.Hex_32_Bit:
                        writeResultRender(WriteInt32(this.melsec_net.GetType().Name != "ModbusTcpNet" ? Name.Trim() + id.Trim() : id.Trim(), int.Parse(Convert.ToInt32(content, 16).ToString())), Name.Trim() + id.Trim());
                        break;
                    case numerical_format.Unsigned_16_Bit:
                        writeResultRender(WriteUInt16(this.melsec_net.GetType().Name != "ModbusTcpNet" ? Name.Trim() + id.Trim() : id.Trim(), ushort.Parse(content)), Name.Trim() + id.Trim());
                        break;
                    case numerical_format.Unsigned_32_Bit:
                        writeResultRender(WriteUInt32(this.melsec_net.GetType().Name != "ModbusTcpNet" ? Name.Trim() + id.Trim() : id.Trim(), uint.Parse(content)), Name.Trim() + id.Trim());
                        break;
                }
            }
            catch { }

            OperateResult WriteInt16(string Address, short Data) => melsec_net.Write(Address, Data);
            OperateResult WriteInt32(string Address, int Data) => melsec_net.Write(Address, Data);
            OperateResult WriteUInt16(string Address, ushort Data) => melsec_net.Write(Address, Data);
            OperateResult WriteUInt32(string Address, uint Data) => melsec_net.Write(Address, Data);
            OperateResult WriteFloat(string Address, float Data) => melsec_net.Write(Address, Data);
            return result;//返回数据
        }
        /// <summary>
        /// 批量读取寄存器
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="id"></param>
        /// <param name="format"></param>
        /// <param name="Index"></param>
        /// <returns></returns>
        public Array PLC_read_D_register_bit(string Name, string id, numerical_format format, ushort Index)
        {

            try
            {
                switch (format)
                {
                    case numerical_format.Signed_16_Bit:
                    case numerical_format.BCD_16_Bit:
                        // 读取short变量
                        return ReadInt16().Content;
                    case numerical_format.Signed_32_Bit:
                    case numerical_format.BCD_32_Bit:
                        // 读取int变量
                        return ReadInt32().Content;
                    case numerical_format.Binary_16_Bit:
                        // 读取16位二进制数
                        var Data = ReadInt16().Content.ToList();
                        string[] PLCBinary = new string[Data.Count];
                        for (int i = 0; i < Data.Count; i++)
                            PLCBinary[i] = Convert.ToString(Convert.ToInt32(Data[i]), 2);
                        return PLCBinary;
                    case numerical_format.Binary_32_Bit:
                        // 读取32位二进制数
                        var Data1 = ReadInt32().Content.ToList();
                        string[] PLCBinaryq = new string[Data1.Count];
                        for (int i = 0; i < Data1.Count; i++)
                            PLCBinaryq[i] = Convert.ToString(Convert.ToInt32(Data1[i]), 2);
                        return PLCBinaryq;
                    case numerical_format.Float_32_Bit:
                        // 读取float变量
                        return ReadFloat().Content;
                    case numerical_format.Hex_16_Bit:
                        // 读取short变量
                        var Data2 = ReadInt16().Content.ToList();
                        string[] PLCBinarya = new string[Data2.Count];
                        for (int i = 0; i < Data2.Count; i++)
                            PLCBinarya[i] = Convert.ToInt32(Data2[i]).ToString("X");
                        return PLCBinarya;
                    case numerical_format.Hex_32_Bit:
                        // 读取int变量
                        var Data3 = ReadInt32().Content.ToList();
                        string[] PLCBinarya1 = new string[Data3.Count];
                        for (int i = 0; i < Data3.Count; i++)
                            PLCBinarya1[i] = Convert.ToInt32(Data3[i]).ToString("X");
                        return PLCBinarya1;
                    case numerical_format.Unsigned_16_Bit:
                        // 读取ushort变量
                        return ReadUInt16().Content;
                    case numerical_format.Unsigned_32_Bit:
                        // 读取uint变量
                        return ReadUInt32().Content;
                    case numerical_format.String:
                        // 读取String变量
                        string[] PLCBinarya3 = new string[Index];
                        for (int i = 0; i < PLCBinarya3.Length; i++)
                            PLCBinarya3[i] = ReadString().Content;
                        return PLCBinarya3;

                }
            }
            catch { }

            string Err = string.Empty;
            readResultRender(new OperateResult<bool>() { ErrorCode = 88, IsSuccess = false, Message = "错误" }, Name, ref Err);
            OperateResult<short[]> ReadInt16() => melsec_net.ReadInt16(this.melsec_net.GetType().Name != "ModbusTcpNet" ? Name.Trim() + id.Trim() : id.Trim(), Index);
            OperateResult<int[]> ReadInt32() => melsec_net.ReadInt32(this.melsec_net.GetType().Name != "ModbusTcpNet" ? Name.Trim() + id.Trim() : id.Trim(), Index);
            OperateResult<ushort[]> ReadUInt16() => melsec_net.ReadUInt16(this.melsec_net.GetType().Name != "ModbusTcpNet" ? Name.Trim() + id.Trim() : id.Trim(), Index);
            OperateResult<uint[]> ReadUInt32() => melsec_net.ReadUInt32(this.melsec_net.GetType().Name != "ModbusTcpNet" ? Name.Trim() + id.Trim() : id.Trim(), Index);
            OperateResult<float[]> ReadFloat() => melsec_net.ReadFloat(this.melsec_net.GetType().Name != "ModbusTcpNet" ? Name.Trim() + id.Trim() : id.Trim(), Index);
            OperateResult<string> ReadString() => melsec_net.ReadString(this.melsec_net.GetType().Name != "ModbusTcpNet" ? Name.Trim() + id.Trim() : id.Trim(), 1, Encoding.UTF8);
            //async Task<OperateResult<short[]>> ReadInt16() => await melsec_net.ReadInt16A(this.melsec_net.GetType().Name != "ModbusTcpNet" ? Name.Trim() + id.Trim() : id.Trim(), Index);
            // async Task<OperateResult<int[]>> ReadInt32() => await melsec_net.ReadInt32(this.melsec_net.GetType().Name != "ModbusTcpNet" ? Name.Trim() + id.Trim() : id.Trim(), Index);
            //async Task<OperateResult<ushort[]>> ReadUInt16() => await melsec_net.ReadUInt16(this.melsec_net.GetType().Name != "ModbusTcpNet" ? Name.Trim() + id.Trim() : id.Trim(), Index);
            // async Task<OperateResult<uint[]>> ReadUInt32() => await melsec_net.ReadUInt32(this.melsec_net.GetType().Name != "ModbusTcpNet" ? Name.Trim() + id.Trim() : id.Trim(), Index);
            // async Task<OperateResult<float[]>> ReadFloat() => await melsec_net.ReadFloat(this.melsec_net.GetType().Name != "ModbusTcpNet" ? Name.Trim() + id.Trim() : id.Trim(), Index);
            return new int[] { 0 };
        }
        /// <summary>
        /// 批量写入寄存器
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        List<int> IPLC_interface.PLC_write_D_register_bit(string id)
        {
            return new List<int>() { 1 };
        }
        /// <summary>
        /// 定义消息以弹出不在弹窗
        /// </summary>
        static bool Message_run = false;
        static int retry;
        /// <summary>
        /// 统一的读取结果的数据解析，显示
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="result"></param>
        /// <param name="address"></param>
        /// <param name="textBox"></param>
        private void readResultRender<T>(OperateResult<T> result, string address, ref string data)
        {
            if (result.IsSuccess)
            {
               data=result.Content.ToString();//获取回传的数据
               retry = 0;
            }
            else
            {

            }
            ReadContn += 1;
        }
        /// <summary>
        /// 统一的读取结果的数据解析，显示
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="result"></param>
        /// <param name="address"></param>
        /// <param name="textBox"></param>
        private void readResultRender<T>(OperateResult<T> result, string address)
        {
            if (result.IsSuccess)
            {
                retry = 0;
            }
            else
            {

            }
            ReadContn += 1;
        }
        /// <summary>
        /// 统一的数据写入的结果显示
        /// </summary>
        /// <param name="result"></param>
        /// <param name="address"></param>
        private void writeResultRender(OperateResult result, string address)
        {
            if (result.IsSuccess!=true)
            {
                PLC_ready = false;//读取异常
                PLCerr_content = DateTime.Now.ToString("[HH:mm:ss] ") + $"[{address}] 写入失败{Environment.NewLine}原因：{result.ToMessageShowString()}";
            }
            WriteContn += 1;
        }
        /// <summary>
        /// Err处理
        /// </summary>
        /// <param name="e"></param>
        private void err(Exception e)
        {
            PLC_ready = false;//PLC开放异常
            PLCerr_code = e.HResult;
            PLCerr_content = e.Message;
            Message_run = true;
        }
    }
}
