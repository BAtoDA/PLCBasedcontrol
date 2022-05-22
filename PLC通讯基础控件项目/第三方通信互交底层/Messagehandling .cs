using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Nancy.Json;
using PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLC报警控件保存类;
using PLC通讯基础控件项目.控件类基.控件地址选择窗口;
using PLC通讯基础控件项目.控件类基.控件数据结构;
using PLC通讯库.PLC通讯设备类型表;
using PLC通讯库.通讯基础接口;
using PLC通讯库.通讯实现类;
using PLC通讯库.通讯枚举;
using static PLC通讯基础控件项目.第三方通信互交底层.Request;

namespace PLC通讯基础控件项目.第三方通信互交底层
{
    /// <summary>
    /// 处理进程间通讯消息报文
    /// </summary>
    public class Messagehandling: PLCpublic
    {
        public Messagehandling()
        {
        }
        /// <summary>
        /// 读取PLC数据
        /// </summary>
        /// <param name="oPYDATASTRUCT"></param>
        /// <returns></returns>
        public COPYDATASTRUCTresult Manageanalysis(COPYDATASTRUCT oPYDATASTRUCT)
        {
            //先强转对应的PLC枚举值
            //string pLC = Enum.GetName(typeof(PLC), oPYDATASTRUCT.facility);
            string pLC = oPYDATASTRUCT.facility;
            //自动判定对方需要读取的类型Bit/D 
            var BitEnumType = Assembly.GetExecutingAssembly().GetType("PLC通讯基础控件项目.控件类基.控件数据结构." + pLC + "_bit");
            bool Bit = Enum.GetNames(BitEnumType).Where(p => p == oPYDATASTRUCT.Equipmenttype.Trim()).FirstOrDefault() != null ? true:false;
            //索引D是否存在
            var DEnumType = Assembly.GetExecutingAssembly().GetType("PLC通讯基础控件项目.控件类基.控件数据结构." + pLC + "_D");
            bool D = Enum.GetNames(DEnumType).Where(p => p == oPYDATASTRUCT.Equipmenttype.Trim()).FirstOrDefault() != null ? true : false;
            //序列化对象
            JavaScriptSerializer jss = new JavaScriptSerializer();
            //判定用户类型Bit
            if (Bit&& oPYDATASTRUCT.Type == "Boolean")
            {
                //检查输入数据是否正确
                Regex RegMitsubit = new Regex(@"^[A-Fa-z0-9]+([0-9]+)?$");
                string Address = RegMitsubit.IsMatch(oPYDATASTRUCT.Address) ? oPYDATASTRUCT.Address : throw new Exception($"输入{oPYDATASTRUCT.Address}地址错误 正常应为：1");
                int len = IsInt(oPYDATASTRUCT.length) ? Convert.ToInt32(oPYDATASTRUCT.length) : throw new Exception($"输入{oPYDATASTRUCT.length}长度错误 正确类型应为： 1");
                bool[] Data = new bool[len];
                IPLC_interface PLCoop = IPLCsurface.PLCDictionary.GetValueOrDefault(pLC) as IPLCcommunicationBase;
                //判断用户是否添加了指定PLC以及PLC是否准备好
                if (PLCoop == null) goto indexPLCNull;
                if (PLCoop.PLC_ready)
                {
                    for (int i = 0; i < len; i++)
                    {
                        if (IsInt(Address))
                        {
                            Data[i] = PLCoop.PLC_read_M_bit(oPYDATASTRUCT.Equipmenttype.Trim(), (Convert.ToInt32(Address) + i).ToString());
                        }
                        else
                        {
                            string addres = (Convert.ToInt32(Address, 16) + i).ToString("X");
                            Data[i] = PLCoop.PLC_read_M_bit(oPYDATASTRUCT.Equipmenttype.Trim(), addres);
                        }
                    }
                }
                else
                    throw new Exception($"{pLC}PLC未准备好 异常代码为：{PLCoop.PLCerr_content ?? "0"}");
                string jsonStr = jss.Serialize(Data);
                return Replymessage(oPYDATASTRUCT, jsonStr, true, oPYDATASTRUCT.facility);
            }
            //判定用户类型D
            if (D)
            {
                int Address = IsInt(oPYDATASTRUCT.Address) ? Convert.ToInt32(oPYDATASTRUCT.Address) : throw new Exception($"输入{oPYDATASTRUCT.Address}地址错误 正常应为：1");
                _ = IsInt(oPYDATASTRUCT.length) ? Convert.ToInt32(oPYDATASTRUCT.length) : throw new Exception($"输入{oPYDATASTRUCT.length}长度错误 正确类型应为： 1");
                _ = IsPLCType<numerical_format>(oPYDATASTRUCT.Type.Trim()) ? true : throw new Exception($"输入类型：{oPYDATASTRUCT.Type} 错误 正确应为：{EnumValue<numerical_format>()}");
                IPLC_interface PLCoop = IPLCsurface.PLCDictionary.GetValueOrDefault(pLC) as IPLCcommunicationBase;
                //判断用户是否添加了指定PLC以及PLC是否准备好
                if (PLCoop == null) goto indexPLCNull;
                if (PLCoop.PLC_ready)
                {
                    string jsonStr = jss.Serialize(PLCoop.PLC_read_D_register_bit(oPYDATASTRUCT.Equipmenttype, (Address).ToString(), (numerical_format)Enum.Parse(typeof(numerical_format), oPYDATASTRUCT.Type.Trim()), Convert.ToUInt16(oPYDATASTRUCT.length)));
                    return Replymessage(oPYDATASTRUCT, jsonStr, true, oPYDATASTRUCT.facility);
                }
                else
                    throw new Exception($"三菱PLC未准备好 异常代码为：{PLCoop.PLCerr_content ?? "0"}");
            }
            //不存在的功能码
            _ = oPYDATASTRUCT.Type == typeof(bool).Name ? true : throw new Exception($"输入类型:{oPYDATASTRUCT.Type}无法识别 正确类型应为：" + typeof(bool).Name+$"或者是：{jss.Serialize(Enum.GetNames(BitEnumType))}  或者是：{jss.Serialize(Enum.GetNames(DEnumType))}");
            return Replymessage(oPYDATASTRUCT, $"Err报警内容:未找到功能码为：{oPYDATASTRUCT.function} 请确定一下功能码是否正确", false, oPYDATASTRUCT.facility);
        indexPLCNull:
            throw new Exception($"{pLC}PLC未实例化 PLC通信表中不存在改PLC");
        }
        /// <summary>
        /// 写入PLC数据
        /// </summary>
        /// <param name="oPYDATASTRUCT"></param>
        /// <param name="Write"></param>
        /// <returns></returns>
        public COPYDATASTRUCTresult Manageanalysis(COPYDATASTRUCT oPYDATASTRUCT,bool Write)
        {
            //先强转对应的PLC枚举值
            //string pLC = Enum.GetNames(typeof(PLC))[oPYDATASTRUCT.function];
            string pLC = oPYDATASTRUCT.facility;
            //自动判定对方需要读取的类型Bit/D 依靠枚举实现
            var BitEnumType = Assembly.GetExecutingAssembly().GetType("PLC通讯基础控件项目.控件类基.控件数据结构." + pLC + "_bit");
            bool Bit = Enum.GetNames(BitEnumType).Where(p => p == oPYDATASTRUCT.Equipmenttype.Trim()).FirstOrDefault() != null ? true : false;
            //索引D是否存在
            var DEnumType = Assembly.GetExecutingAssembly().GetType("PLC通讯基础控件项目.控件类基.控件数据结构." + pLC + "_D");
            bool D = Enum.GetNames(DEnumType).Where(p => p == oPYDATASTRUCT.Equipmenttype.Trim()).FirstOrDefault() != null ? true : false;
            //序列化对象
            JavaScriptSerializer jss = new JavaScriptSerializer();
            //判定用户类型Bit
            if (Bit)
            {
                //检查输入数据是否正确
                Regex RegMitsubit = new Regex(@"^[A-Fa-z0-9]+([0-9]+)?$");
                string Address = RegMitsubit.IsMatch(oPYDATASTRUCT.Address) ? oPYDATASTRUCT.Address : throw new Exception($"输入{oPYDATASTRUCT.Address}地址错误 正常应为：1");
                int len = IsInt(oPYDATASTRUCT.length) ? Convert.ToInt32(oPYDATASTRUCT.length) : throw new Exception($"输入{oPYDATASTRUCT.length}长度错误 正确类型应为： 1");
                object lpOK;
                 
                if(!Enum.TryParse(typeof(Button_state), oPYDATASTRUCT.lpData,out lpOK))
                    throw new Exception( $"Err报警内容:未找到写入值为：{oPYDATASTRUCT.lpData} 请确定一下值是否正确  应该为：{jss.Serialize(Enum.GetNames(typeof(Button_state)))}");
                bool[] Data = new bool[len];
                IPLC_interface PLCoop = IPLCsurface.PLCDictionary.GetValueOrDefault(pLC) as IPLCcommunicationBase;
                //判断用户是否添加了指定PLC以及PLC是否准备好
                if (PLCoop == null) goto indexPLCNull;
                if (PLCoop.PLC_ready)
                {
                    for (int i = 0; i < len; i++)
                    {
                        if (IsInt(Address))
                        {
                            PLCoop.PLC_write_M_bit(oPYDATASTRUCT.Equipmenttype.Trim(), (Convert.ToInt32(Address) + i).ToString(), (Button_state)Enum.Parse(typeof(Button_state), oPYDATASTRUCT.lpData));
                        }
                        else
                        {
                            string addres = (Convert.ToInt32(Address, 16) + i).ToString("X");
                            PLCoop.PLC_write_M_bit(oPYDATASTRUCT.Equipmenttype.Trim(), addres, (Button_state)Enum.Parse(typeof(Button_state), oPYDATASTRUCT.lpData));
                        }
                    }
                }
                else
                    throw new Exception($"{pLC}PLC未准备好 异常代码为：{PLCoop.PLCerr_content ?? "0"}");
                string jsonStr = jss.Serialize(Data);
                return Replymessage(oPYDATASTRUCT, jsonStr, true, oPYDATASTRUCT.facility);
            }
            //判定用户类型D
            if (D)
            {
                Regex RegMitsubit = new Regex(@"^[A-Fa-z0-9]+([0-9]+)?$");
                string Address = RegMitsubit.IsMatch(oPYDATASTRUCT.Address) ? oPYDATASTRUCT.Address : throw new Exception($"输入{oPYDATASTRUCT.Address}地址错误 正常应为：1");
                _ = IsPLCType<numerical_format>(oPYDATASTRUCT.Type.Trim()) ? true : throw new Exception($"输入类型：{oPYDATASTRUCT.Type} 错误 正确应为：{EnumValue<numerical_format>()}");
                int len = IsInt(oPYDATASTRUCT.length) ? Convert.ToInt32(oPYDATASTRUCT.length) : throw new Exception($"输入{oPYDATASTRUCT.length}长度错误 正确类型应为： 1");
                _ = oPYDATASTRUCT.lpData == null ? throw new Exception("输入内容不能为空") : Convert.ToInt32(oPYDATASTRUCT.lpData);
                IPLC_interface PLCoop = IPLCsurface.PLCDictionary.GetValueOrDefault(pLC) as IPLCcommunicationBase;
                //判断用户是否添加了指定PLC以及PLC是否准备好
                if (PLCoop == null) goto indexPLCNull;
                if (PLCoop.PLC_ready)
                {
                    for (int i = 0; i < len; i++)
                    {
                        if (IsInt(Address))
                        {
                            PLCoop.PLC_write_D_register(oPYDATASTRUCT.Equipmenttype.Trim(), (Convert.ToInt32(Address) + i).ToString(), oPYDATASTRUCT.lpData ?? "00", (numerical_format)Enum.Parse(typeof(numerical_format), oPYDATASTRUCT.Type));
                        }
                    }
                }
                else
                    throw new Exception($"三菱PLC未准备好 异常代码为：{PLCoop.PLCerr_content ?? "0"}");
                return Replymessage(oPYDATASTRUCT, "", true, oPYDATASTRUCT.facility);
            }
            //不存在的功能码
            _ = oPYDATASTRUCT.Type == typeof(bool).Name ? true : throw new Exception($"输入类型:{oPYDATASTRUCT.Type}无法识别 正确类型应为：" + typeof(bool).Name + $"或者是：{jss.Serialize(Enum.GetNames(BitEnumType))}  或者是：{jss.Serialize(Enum.GetNames(DEnumType))}");
            return Replymessage(oPYDATASTRUCT, $"Err报警内容:未找到功能码为：{oPYDATASTRUCT.function} 请确定一下功能码是否正确", false, oPYDATASTRUCT.facility);
        indexPLCNull:
            throw new Exception($"{pLC}PLC未实例化 PLC通信表中不存在改PLC");
        }
        /// <summary>
        /// 查询当前报警表内容
        /// 反馈给对方 内容在COPYDATASTRUCTresult.Data中
        /// 反馈类型：List<EventMessage>
        /// </summary>
        /// <param name="oPYDATASTRUCT"></param>
        /// <returns></returns>
        public COPYDATASTRUCTresult Messagealysis(COPYDATASTRUCT oPYDATASTRUCT)
        {
            using(var db= new PoliceContext())
            {
                var SqlData = db.UserElectricMark.ToList();
                if(SqlData.Count > 0)
                {
                    //回复查询到的数据
                    return Replymessage(oPYDATASTRUCT, new JavaScriptSerializer().Serialize(SqlData), true, "SqlLite");
                }
                //查询数据为0
                return Replymessage(oPYDATASTRUCT, new JavaScriptSerializer().Serialize(SqlData), false, "SqlLite");
            }
        }
        public COPYDATASTRUCTresult Manage(COPYDATASTRUCT oPYDATASTRUCT)
        {
            try
            {
                switch (oPYDATASTRUCT.function)
                {

                    //H05 读取外部PLC链接设备BOOL区
                    case 00:
                    case 01:
                    case 14:
                    case 13:
                    case 10:
                    case 09: 
                    case 06:
                    case 05:
                       return Manageanalysis(oPYDATASTRUCT);
                    //H07 写入外部PLC链接设备bool区 
                    case 16:
                    case 15:
                    case 12:
                    case 11:
                    case 08:
                    case 07:
                        return Manageanalysis(oPYDATASTRUCT,true);
                    //新增读取当前报警表内容
                    case 20:
                       return Messagealysis(oPYDATASTRUCT);
                    default:
                        return Replymessage(oPYDATASTRUCT, $"Err报警内容:未找到功能码为：{oPYDATASTRUCT.function} 请确定一下功能码是否正确", false, "SystemNull");
                }
            }
            catch(Exception e)
            {
                return Replymessage(oPYDATASTRUCT, $"Err报警内容{e.Message}", false, "SystemErr");
            }
        }
        /// <summary>
        /// 读取枚举的值
        /// </summary>
        /// <returns></returns>
        private string EnumValue<T>()
        {
            string err = " ";
            foreach (var i in Enum.GetValues(typeof(T)))
                err += i.ToString() + "  ";
            return err;
        }
        /// <summary>
        /// 判断PLC读写类型 是否正确
        /// 符合返回true  不符合false
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private bool IsPLCType<T>(string value)
        {
            object data = null;
            try
            {
                data = Enum.Parse(typeof(T), value);
            }
            catch { }
            return data == null ? false : true;
        }
        /// <summary>
        /// 判断数据是否int类型
        /// </summary>
        /// <returns></returns>
        private bool IsInt(string value)
        {
            return Regex.IsMatch(value, @"^[+-]?\d*$");
        }
        /// <summary>
        /// 根据参数自己填充回复报文
        /// </summary>
        /// <param name="oPYDATASTRUCT"></param>
        /// <param name="Value"></param>
        /// <param name="result"></param>
        /// <param name="facility"></param>
        /// <returns></returns>
        public COPYDATASTRUCTresult Replymessage(COPYDATASTRUCT oPYDATASTRUCT,string Value,bool result,string facility)
        {
            COPYDATASTRUCTresult tresult=new COPYDATASTRUCTresult();
            tresult.characteristic = oPYDATASTRUCT.characteristic;
            tresult.Equipmenttype = oPYDATASTRUCT.Equipmenttype;
            tresult.Data = Value;
            tresult.Address = oPYDATASTRUCT.Address;
            tresult.function = oPYDATASTRUCT.function;
            tresult.lpData = oPYDATASTRUCT.lpData;
            tresult.result = result;
            tresult.Type = oPYDATASTRUCT.Type;
            tresult.length = oPYDATASTRUCT.length;
            tresult.length = facility;
            //获取所有的字节长度
            byte[] sarr = System.Text.Encoding.Default.GetBytes(tresult.characteristic + tresult.facility + tresult.Equipmenttype + tresult.Data + tresult.Address + tresult.function + tresult.lpData + tresult.result + tresult.Type + tresult.length);
            //获取长度
            int len = sarr.Length;
            tresult.cbData = len + 4;
            return tresult;
        }
        /// <summary>
        /// 计算发送字节的长度
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="vale"></param>
        /// <returns></returns>
        public int Messagelen(COPYDATASTRUCTresult tresult)
        {
            //获取所有的字节长度
            byte[] sarr = System.Text.Encoding.Default.GetBytes(tresult.characteristic + tresult.Equipmenttype + tresult.Data + tresult.Address + tresult.function + tresult.lpData + tresult.result + tresult.Type + tresult.length);
            //获取长度
            int len = sarr.Length+4;
            return len;
        }
    }
}
