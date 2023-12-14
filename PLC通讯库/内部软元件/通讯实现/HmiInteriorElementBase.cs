using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using HslCommunication;
using Nancy.Json;
using PLC通讯库.内部软元件.底层数据保存;
using PLC通讯库.通讯基础接口;

namespace PLC通讯库.内部软元件.通讯实现
{
    /// <summary>
    /// 用于处理内部软元件
    /// 读取 清空 等操作
    /// </summary>
    internal class HmiInteriorElementBase
    {
        /// <summary>
        /// 内部软元件Bit位数组
        /// 不掉电保持
        /// </summary>
        public static volatile bool[] HmiLB = new bool[1000];
        /// <summary>
        /// 内部软元件寄存器数组
        /// 不掉电保持
        /// </summary>
        public static volatile object[] HmiLW = new object[1000];
        /// <summary>
        /// 内部软元件Bit位数组
        /// 掉电保持
        /// </summary>
        public static volatile bool[] HmiRB = new bool[500];
        /// <summary>
        /// 内部软元件寄存器数组
        /// 掉电保持
        /// </summary>
        public static volatile object[] HmiRW = new object[500];

        public string IpAddress { get; set; } = "127.0.0.0";
        public int Port { get; set; } = 2000;
        private int Ports;
        public int ConnectTimeOut { get; set; } = 1000;
        public int ReceiveTimeOut { get; set; } = 1000;
        public bool PLC_ready { get; set; } = true;
        object obj=new object();

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="ip"></param>
        public HmiInteriorElementBase(string ip, int Port)
        {
            IpAddress = ip;
            //------------设置对象池大小--------------
            Func<Tuple<InteriorElement>> Voice = new Func<Tuple<InteriorElement>>(() =>
            {
                return new Tuple<InteriorElement>(new InteriorElement(@"C:\", "LB"));
            });
            InteriorObjectPool<Tuple<InteriorElement>> InteriorObjectPool = new InteriorObjectPool<Tuple<InteriorElement>>(
     1, Voice);
            System.Threading.Timer InformationTimer = new System.Threading.Timer(new TimerCallback((s) =>
            {
                Change(s);
            }));
            InformationTimer.Change(TimeSpan.FromSeconds(2), TimeSpan.FromSeconds(3));
            //System.Timers.Timer InformationTimer = new System.Timers.Timer()
            //{
            //    Interval = 100,
            //    Enabled = true
            //};
            //InformationTimer.Elapsed += ((send, e) =>
            //{
            //    Change(send);
            //});
            //InformationTimer.Start();
            void Change(object a)
            {
                //InformationTimer.Stop();
                lock (obj)
                {
                    //Debug.WriteLine(DateTime.Now.ToString("F"));
                    var Data = TextRead("RB0");
                    if (Data.Result != null && Data.Result != "")
                    {
                        HmiRB = new JavaScriptSerializer().Deserialize<bool[]>(Data.Result);
                    }
                    if (Data.Result == "")
                    {
                        //写入数据
                        JavaScriptSerializer javaScript = new JavaScriptSerializer();
                        TextWrite("RB0", javaScript.Serialize(HmiRB)).Wait();
                    }

                    var DataV = TextRead("RW0");
                    if (DataV.Result != null && Data.Result != "")
                    {
                        HmiRW = new JavaScriptSerializer().Deserialize<object[]>(DataV.Result);
                    }
                    if (DataV.Result == "")
                    {
                        //写入数据
                        JavaScriptSerializer javaScript = new JavaScriptSerializer();
                        TextWrite("RW0", javaScript.Serialize(HmiRW)).Wait();
                    }

                }
                //InformationTimer.Start();
            }
        }

        private void InformationTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 切断通讯
        /// </summary>
        /// <returns></returns>
        public OperateResult ConnectClose()
        {
            PLC_ready=false;
            return new OperateResult() { ErrorCode = 0, IsSuccess = true, Message = "0" };
        }
        /// <summary>
        /// 打开通讯链接
        /// </summary>
        /// <returns></returns>
        public OperateResult ConnectServer()
        {
            PLC_ready = true;
            return new OperateResult() { Message = "****", IsSuccess = true, ErrorCode = 0 };
        }
        /// <summary>
        /// 读取Hmi内部Bit位线圈操作
        /// </summary>
        /// <param name="address">传入功能码以及地址</param>
        /// <returns></returns>
        public OperateResult<bool> ReadBool(string address)
        {
            //预定义bool数组
            bool[] Boolarray = new bool[1];
            //获取功能判断用户需要读取的功能码
            switch (Getfunction(address))
            {
                case "LB":
                    if (Convert.ToInt32(Getaddress(address)) < HmiLB.Length)
                        Boolarray[0] = HmiLB[Convert.ToInt32(Getaddress(address))];
                    break;
                case "RB":
                    if (Convert.ToInt32(Getaddress(address)) < HmiRB.Length)
                    {
                        Boolarray[0] = HmiRB[Convert.ToInt32(Getaddress(address))];
                    }
                    break;
                default:
                    return new OperateResult<bool>() { Content = Boolarray[0], ErrorCode = 0, IsSuccess = false, Message = $"当前输入的{address}无法解析" };
            }
            return new OperateResult<bool>() { Content = Boolarray[0], ErrorCode = 0, IsSuccess = true, Message = "0" };
        }
        /// <summary>
        /// 批量读取Hmi内部Bit位线圈操作ReadBool
        /// </summary>
        /// <param name="address">传入功能码以及地址</param>
        /// <returns></returns>
        public OperateResult<bool[]> ReadBool(string address,ushort Count)
        {
            //预定义bool数组
            bool[] Boolarray = new bool[Count];
            //获取功能判断用户需要读取的功能码
            switch (Getfunction(address))
            {
                case "LB":
                    if (Convert.ToInt32(Getaddress(address)) < HmiLB.Length)
                        Boolarray[0] = HmiLB[Convert.ToInt32(Getaddress(address))];
                    break;
                case "RB":
                    if (Convert.ToInt32(Getaddress(address)) < HmiRB.Length)
                    {
                        Boolarray[0] = HmiRB[Convert.ToInt32(Getaddress(address))];
                    }
                    break;
                default:
                    return new OperateResult<bool[]>() { Content = Boolarray, ErrorCode = 0, IsSuccess = false, Message = $"当前输入的{address}无法解析" };
            }
            return new OperateResult<bool[]>() { Content = Boolarray, ErrorCode = 0, IsSuccess = true, Message = "0" };
        }
        private async Task<string> TextRead(string address)
        {
            //向对象池申请 
            var Poss = InteriorObjectPool<Tuple<InteriorElement>>.GetObject();
            Poss.Item1.Textaddress = @"C:\" + "InteriorElement\\" + $"{Getfunction(address)}.txt";
            if (Poss.Item1.IsText())
            {
                var Data = await Poss.Item1.TextRead();
                InteriorObjectPool<Tuple<InteriorElement>>.PutObject(Poss);
                return Data;
            }
            else
            {
                Poss.Item1.TextCreate();
                //写入数据
                JavaScriptSerializer javaScript = new JavaScriptSerializer();
                TextWrite(address, javaScript.Serialize(HmiRB)).Wait();
                InteriorObjectPool<Tuple<InteriorElement>>.PutObject(Poss);
                return null;
            }
        }
        private async Task TextWrite(string address, string Content)
        {
            //向对象池申请 
            var Poss = InteriorObjectPool<Tuple<InteriorElement>>.GetObject();
            Poss.Item1.Textaddress = @"C:\" + "InteriorElement\\" + $"{Getfunction(address)}.txt";
            if (Poss.Item1.IsText())
            {
                await Poss.Item1.TextWrite(Content);
            }
            else
            {
                Poss.Item1.TextCreate();
            }
            InteriorObjectPool<Tuple<InteriorElement>>.PutObject(Poss);

        }
        /// <summary>
        /// 写入Hmi内部对应线圈
        /// </summary>
        /// <param name="address">功能码以及地址</param>
        /// <param name="value">写入值</param>
        /// <returns></returns>
        public OperateResult Write(string address, bool value)
        {
            //预定义bool数组
            bool[] Boolarray = new bool[1] { value };
            //获取功能判断用户需要读取的功能码
            switch (Getfunction(address))
            {
                case "LB":
                    if (Convert.ToInt32(Getaddress(address)) < HmiLB.Length)
                        HmiLB[Convert.ToInt32(Getaddress(address))]=Boolarray[0];
                    break;
                case "RB":
                    if (Convert.ToInt32(Getaddress(address)) < HmiRB.Length)
                    {
                        var Data = TextRead(address);
                        if (Data.Result != null)
                        {
                            JavaScriptSerializer javaScript=new JavaScriptSerializer();
                            HmiRB = javaScript.Deserialize<bool[]>(Data.Result);
                            HmiRB[Convert.ToInt32(Getaddress(address))]=Boolarray[0];
                            TextWrite(address, javaScript.Serialize(HmiRB)).Wait();
                        }
                    }
                    break;
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
                case "LW":
                    if (Convert.ToInt32(Getaddress(address)) < HmiLW.Length)                       
                            return new OperateResult<short>() { Content = Convert.ToInt16(HmiLW[Convert.ToInt32(Getaddress(address))]), ErrorCode = 0, IsSuccess = true, Message = $"Null" };
                    break;
                case "RW":
                    if (Convert.ToInt32(Getaddress(address)) < HmiRW.Length)
                    {
                        return new OperateResult<short>() { Content = Convert.ToInt16(HmiRW[Convert.ToInt32(Getaddress(address))]), ErrorCode = 0, IsSuccess = true, Message = $"Null" };
                    }
                    break;
                default:
                    return new OperateResult<short>() { Content = 0, ErrorCode = 0, IsSuccess = false, Message = $"当前输入的{address}无法解析" };
            }
            return new OperateResult<short>() { Content = 0, ErrorCode = 0, IsSuccess = false, Message = $"当前输入的{address}无法解析" };
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
                case "LW":
                    if (Convert.ToInt32(Getaddress(address)) < HmiLW.Length)
                        return new OperateResult<int>() { Content = Convert.ToInt32(HmiLW[Convert.ToInt32(Getaddress(address))]), ErrorCode = 0, IsSuccess = true, Message = $"Null" };
                    break;
                case "RW":
                    if (Convert.ToInt32(Getaddress(address)) < HmiRW.Length)
                    {
                        return new OperateResult<int>() { Content = Convert.ToInt16(HmiRW[Convert.ToInt32(Getaddress(address))]), ErrorCode = 0, IsSuccess = true, Message = $"Null" };
                    }
                    break;
                default:
                    return new OperateResult<int>() { Content = 0, ErrorCode = 0, IsSuccess = false, Message = $"当前输入的{address}无法解析" };
            }
            return new OperateResult<int>() { Content = 0, ErrorCode = 0, IsSuccess = false, Message = $"当前输入的{address}无法解析" };
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
                case "LW":
                    if (Convert.ToInt32(Getaddress(address)) < HmiLW.Length)
                        return new OperateResult<ushort>() { Content = Convert.ToUInt16(HmiLW[Convert.ToInt32(Getaddress(address))]), ErrorCode = 0, IsSuccess = true, Message = $"Null" };
                    break;
                case "RW":
                    if (Convert.ToInt32(Getaddress(address)) < HmiRW.Length)
                    {
                        return new OperateResult<ushort>() { Content = Convert.ToUInt16(HmiRW[Convert.ToInt32(Getaddress(address))]), ErrorCode = 0, IsSuccess = true, Message = $"Null" };
                    }
                    break;
                default:
                    return new OperateResult<ushort>() { Content = 0, ErrorCode = 0, IsSuccess = false, Message = $"当前输入的{address}无法解析" };
            }
            return new OperateResult<ushort>() { Content = 0, ErrorCode = 0, IsSuccess = false, Message = $"当前输入的{address}无法解析" };
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
                case "LW":
                    if (Convert.ToInt32(Getaddress(address)) < HmiLW.Length)
                        return new OperateResult<uint>() { Content = Convert.ToUInt32(HmiLW[Convert.ToInt32(Getaddress(address))]), ErrorCode = 0, IsSuccess = true, Message = $"Null" };
                    break;
                case "RW":
                    if (Convert.ToInt32(Getaddress(address)) < HmiRW.Length)
                    {
                        return new OperateResult<uint>() { Content = Convert.ToUInt32(HmiRW[Convert.ToInt32(Getaddress(address))]), ErrorCode = 0, IsSuccess = true, Message = $"Null" };
                    }
                    break;
                default:
                    return new OperateResult<uint>() { Content = 0, ErrorCode = 0, IsSuccess = false, Message = $"当前输入的{address}无法解析" };
            }
            return new OperateResult<uint>() { Content = 0, ErrorCode = 0, IsSuccess = false, Message = $"当前输入的{address}无法解析" };
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
                case "LW":
                    if (Convert.ToInt32(Getaddress(address)) < HmiLW.Length)
                        return new OperateResult<float>() { Content = Convert.ToSingle(HmiLW[Convert.ToInt32(Getaddress(address))]), ErrorCode = 0, IsSuccess = true, Message = $"Null" };
                    break;
                case "RW":
                    if (Convert.ToInt32(Getaddress(address)) < HmiRW.Length)
                    {
                        return new OperateResult<float>() { Content = Convert.ToSingle(HmiRW[Convert.ToInt32(Getaddress(address))]), ErrorCode = 0, IsSuccess = true, Message = $"Null" };
                    }
                    break;
                default:
                    return new OperateResult<float>() { Content = 0, ErrorCode = 0, IsSuccess = false, Message = $"当前输入的{address}无法解析" };
            }
            return new OperateResult<float>() { Content = 0, ErrorCode = 0, IsSuccess = false, Message = $"当前输入的{address}无法解析" };
        }

        /// <summary>
        /// 批量读取无符号字
        /// </summary>
        /// <param name="address"></param>
        /// <param name="Index"></param>
        /// <returns></returns>
        public OperateResult<ushort[]> ReadUInt16(string address, int Index)
        {
            try
            {
                ushort[] result = new ushort[Index];
                for (int i = 0; i < Index; i++)
                {
                    result[i] = this.ReadUInt16(address).Content;
                }
                return new OperateResult<ushort[]>() { Content = result, IsSuccess = true };
            }
            catch
            {
                return new OperateResult<ushort[]>() { Content = null, ErrorCode = 0, IsSuccess = false, Message = $"当前输入的{address}无法解析" };
            }
        }

        /// <summary>
        /// 批量读取无符号双字
        /// </summary>
        /// <param name="address"></param>
        /// <param name="Index"></param>
        /// <returns></returns>
        public OperateResult<uint[]> ReadUInt32(string address, int Index)
        {
            try
            {
                uint[] result = new uint[Index];
                for (int i = 0; i < Index; i++)
                {
                    result[i] = this.ReadUInt32(address).Content;
                }
                return new OperateResult<uint[]>() { Content = result, IsSuccess = true };
            }
            catch
            {
                return new OperateResult<uint[]>() { Content = null, ErrorCode = 0, IsSuccess = false, Message = $"当前输入的{address}无法解析" };
            }
        }

        /// <summary>
        /// 批量读取有符号字
        /// </summary>
        /// <param name="address"></param>
        /// <param name="Index"></param>
        /// <returns></returns>
        public OperateResult<short[]> ReadInt16(string address, int Index)
        {
            try
            {
                short[] result = new short[Index];
                for (int i = 0; i < Index; i++)
                {
                    result[i] = this.ReadInt16(address).Content;
                }
                return new OperateResult<short[]>() { Content = result, IsSuccess = true };
            }
            catch
            {
                return new OperateResult<short[]>() { Content = null, ErrorCode = 0, IsSuccess = false, Message = $"当前输入的{address}无法解析" };
            }
        }

        /// <summary>
        /// 批量读取有符号双字
        /// </summary>
        /// <param name="address"></param>
        /// <param name="Index"></param>
        /// <returns></returns>
        public OperateResult<int[]> ReadInt32(string address, int Index)
        {
            try
            {
                int[] result = new int[Index];
                for (int i = 0; i < Index; i++)
                {
                    result[i] = this.ReadInt32(address).Content;
                }
                return new OperateResult<int[]>() { Content = result, IsSuccess = true };
            }
            catch
            {
                return new OperateResult<int[]>() { Content = null, ErrorCode = 0, IsSuccess = false, Message = $"当前输入的{address}无法解析" };
            }

        }
        /// <summary>
        /// 批量读取浮点小数
        /// </summary>
        /// <param name="address"></param>
        /// <param name="Index"></param>
        /// <returns></returns>
        public OperateResult<float[]> ReadFloat(string address, int Index)
        {
            try
            {
                float[] result = new float[Index];
                for (int i = 0; i < Index; i++)
                {
                    result[i] = this.ReadFloat(address).Content;
                }
                return new OperateResult<float[]>() { Content = result, IsSuccess = true };
            }
            catch
            {
                return new OperateResult<float[]>() { Content = null, ErrorCode = 0, IsSuccess = false, Message = $"当前输入的{address}无法解析" };
            }
        }

        public OperateResult<short> Write(string address, short Value)
        {
            switch (Getfunction(address))
            {
                case "LW":
                    if (Convert.ToInt32(Getaddress(address)) < HmiLW.Length)
                    {
                        HmiLW[Convert.ToInt32(Getaddress(address))]=Value;
                        return new OperateResult<short>() { Content = Convert.ToInt16(HmiLW[Convert.ToInt32(Getaddress(address))]), ErrorCode = 0, IsSuccess = true, Message = $"Null" };
                    }
                    break;
                case "RW":
                    if (Convert.ToInt32(Getaddress(address)) < HmiRW.Length)
                    {
                        var Data = TextRead(address);
                        if (Data.Result != null)
                        {
                            JavaScriptSerializer javaScript = new JavaScriptSerializer();
                            HmiRW = javaScript.Deserialize<object[]>(Data.Result);
                            HmiRW[Convert.ToInt32(Getaddress(address))] = Value;
                            TextWrite(address, javaScript.Serialize(HmiRW)).Wait();
                            return new OperateResult<short>() { Content = Convert.ToInt16(HmiRW[Convert.ToInt32(Getaddress(address))]), ErrorCode = 0, IsSuccess = true, Message = $"Null" };
                        }
                    }
                    break;
                default:
                    return new OperateResult<short>() { Content = 0, ErrorCode = 0, IsSuccess = false, Message = $"当前输入的{address}无法解析" };
            }
            return new OperateResult<short>() { Content = 0, ErrorCode = 0, IsSuccess = false, Message = $"当前输入的{address}无法解析" };
        }
        public OperateResult<int> Write(string address, int Value)
        {
            switch (Getfunction(address))
            {
                case "LW":
                    if (Convert.ToInt32(Getaddress(address)) < HmiLW.Length)
                    {
                        HmiLW[Convert.ToInt32(Getaddress(address))] = Value;
                        return new OperateResult<int>() { Content = Convert.ToInt16(HmiLW[Convert.ToInt32(Getaddress(address))]), ErrorCode = 0, IsSuccess = true, Message = $"Null" };
                    }
                    break;
                case "RW":
                    if (Convert.ToInt32(Getaddress(address)) < HmiRW.Length)
                    {
                        var Data = TextRead(address);
                        if (Data.Result != null)
                        {
                            JavaScriptSerializer javaScript = new JavaScriptSerializer();
                            HmiRW = javaScript.Deserialize<object[]>(Data.Result);
                            HmiRW[Convert.ToInt32(Getaddress(address))] = Value;
                            TextWrite(address, javaScript.Serialize(HmiRW)).Wait();
                            return new OperateResult<int>() { Content = Convert.ToInt16(HmiRW[Convert.ToInt32(Getaddress(address))]), ErrorCode = 0, IsSuccess = true, Message = $"Null" };
                        }
                    }
                    break;
                default:
                    return new OperateResult<int>() { Content = 0, ErrorCode = 0, IsSuccess = false, Message = $"当前输入的{address}无法解析" };
            }
            return new OperateResult<int>() { Content = 0, ErrorCode = 0, IsSuccess = false, Message = $"当前输入的{address}无法解析" };
        }
        public OperateResult<ushort> Write(string address, ushort Value)
        {
            switch (Getfunction(address))
            {
                case "LW":
                    if (Convert.ToInt32(Getaddress(address)) < HmiLW.Length)
                    {
                        HmiLW[Convert.ToInt32(Getaddress(address))] = Value;
                        return new OperateResult<ushort>() { Content = Convert.ToUInt16(HmiLW[Convert.ToInt32(Getaddress(address))]), ErrorCode = 0, IsSuccess = true, Message = $"Null" };
                    }
                    break;
                case "RW":
                    if (Convert.ToInt32(Getaddress(address)) < HmiRW.Length)
                    {
                        var Data = TextRead(address);
                        if (Data.Result != null)
                        {
                            JavaScriptSerializer javaScript = new JavaScriptSerializer();
                            HmiRW = javaScript.Deserialize<object[]>(Data.Result);
                            HmiRW[Convert.ToInt32(Getaddress(address))] = Value;
                            TextWrite(address, javaScript.Serialize(HmiRW)).Wait();
                            return new OperateResult<ushort>() { Content = Convert.ToUInt16(HmiRW[Convert.ToInt32(Getaddress(address))]), ErrorCode = 0, IsSuccess = true, Message = $"Null" };
                        }
                    }
                    break;
                default:
                    return new OperateResult<ushort>() { Content = 0, ErrorCode = 0, IsSuccess = false, Message = $"当前输入的{address}无法解析" };
            }
            return new OperateResult<ushort>() { Content = 0, ErrorCode = 0, IsSuccess = false, Message = $"当前输入的{address}无法解析" };
        }
        public OperateResult<uint> Write(string address, uint Value)
        {
            switch (Getfunction(address))
            {
                case "LW":
                    if (Convert.ToInt32(Getaddress(address)) < HmiLW.Length)
                    {
                        HmiLW[Convert.ToInt32(Getaddress(address))] = Value;
                        return new OperateResult<uint>() { Content = Convert.ToUInt32(HmiLW[Convert.ToInt32(Getaddress(address))]), ErrorCode = 0, IsSuccess = true, Message = $"Null" };
                    }
                    break;
                case "RW":
                    if (Convert.ToInt32(Getaddress(address)) < HmiRW.Length)
                    {
                        var Data = TextRead(address);
                        if (Data.Result != null)
                        {
                            JavaScriptSerializer javaScript = new JavaScriptSerializer();
                            HmiRW = javaScript.Deserialize<object[]>(Data.Result);
                            HmiRW[Convert.ToInt32(Getaddress(address))] = Value;
                            TextWrite(address, javaScript.Serialize(HmiRW)).Wait();
                            return new OperateResult<uint>() { Content = Convert.ToUInt32(HmiRW[Convert.ToInt32(Getaddress(address))]), ErrorCode = 0, IsSuccess = true, Message = $"Null" };
                        }
                    }
                    break;
                default:
                    return new OperateResult<uint>() { Content = 0, ErrorCode = 0, IsSuccess = false, Message = $"当前输入的{address}无法解析" };
            }
            return new OperateResult<uint>() { Content = 0, ErrorCode = 0, IsSuccess = false, Message = $"当前输入的{address}无法解析" };
        }
        public OperateResult<float> Write(string address, float Value)
        {
            switch (Getfunction(address))
            {
                case "LW":
                    if (Convert.ToInt32(Getaddress(address)) < HmiLW.Length)
                    {
                        HmiLW[Convert.ToInt32(Getaddress(address))] = Value;
                        return new OperateResult<float>() { Content = Convert.ToInt16(HmiLW[Convert.ToInt32(Getaddress(address))]), ErrorCode = 0, IsSuccess = true, Message = $"Null" };
                    }
                    break;
                case "RW":
                    if (Convert.ToInt32(Getaddress(address)) < HmiRW.Length)
                    {
                        var Data = TextRead(address);
                        if (Data.Result != null)
                        {
                            JavaScriptSerializer javaScript = new JavaScriptSerializer();
                            HmiRW = javaScript.Deserialize<object[]>(Data.Result);
                            HmiRW[Convert.ToInt32(Getaddress(address))] = Value;
                            TextWrite(address, javaScript.Serialize(HmiRW)).Wait();
                            return new OperateResult<float>() { Content = Convert.ToInt16(HmiRW[Convert.ToInt32(Getaddress(address))]), ErrorCode = 0, IsSuccess = true, Message = $"Null" };
                        }
                    }
                    break;
                default:
                    return new OperateResult<float>() { Content = 0, ErrorCode = 0, IsSuccess = false, Message = $"当前输入的{address}无法解析" };
            }
            return new OperateResult<float>() { Content = 0, ErrorCode = 0, IsSuccess = false, Message = $"当前输入的{address}无法解析" };
        }
        /// <summary>
        /// 获取功能码
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        private string Getfunction(string Name)
        {
            return System.Text.RegularExpressions.Regex.Replace(Name ?? "00".ToUpper(), @"[^A-Z]+", "");
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
