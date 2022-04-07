using System;
using System.Collections.Generic;
using System.Text;
using PLC通讯库.PLC通讯设备类型表;
using PLC通讯库.通讯基础接口;
using PLC通讯库.通讯实现类;
using System.Linq;

namespace PLC通讯基础控件项目.宏脚本.脚本函数类
{
    /// <summary>
    /// PLC类 
    /// 用于处理宏程序 访问PLC用
    /// </summary>
    public class PLC
    {
        /// <summary>
        /// 读取指定PLC的数据
        /// 读取个数由Data个数决定
        /// </summary>
        /// <param name="PLC">需要读取的PLC</param>
        /// <param name="Function">PLC的功能码</param>
        /// <param name="Address">PLC的地址</param>
        /// <param name="Data">读取返回</param>
        /// <returns></returns>
        public static bool GetPLCD(string PLC, string Function, string Address, ref dynamic Data)
        {
            try
            {
                IPLC_interface PLCoop = IPLCsurface.PLCDictionary.GetValueOrDefault(PLC) as IPLCcommunicationBase;
                if (PLCoop == null) return false;
                if (PLCoop.PLC_ready)
                {
                    switch (Data.GetType().Name)
                    {
                        case "Int32[]":
                            var PLCData32 = PLCoop.PLC_read_D_register_bit(Function, Address, PLC通讯库.通讯枚举.numerical_format.Signed_32_Bit, (ushort)Data.Length);
                            PLCData32.CopyTo(Data, 0);
                            return true;
                        case "Int16[]":
                            var PLCData16 = PLCoop.PLC_read_D_register_bit(Function, Address, PLC通讯库.通讯枚举.numerical_format.Signed_16_Bit, (ushort)Data.Length);
                            PLCData16.CopyTo(Data, 0);
                            return true;
                        case "UInt32[]":
                            var PLCDataU32 = PLCoop.PLC_read_D_register_bit(Function, Address, PLC通讯库.通讯枚举.numerical_format.Unsigned_32_Bit, (ushort)Data.Length);
                            PLCDataU32.CopyTo(Data, 0);
                            return true;
                        case "UInt16[]":
                            var PLCDataU16 = PLCoop.PLC_read_D_register_bit(Function, Address, PLC通讯库.通讯枚举.numerical_format.Unsigned_16_Bit, (ushort)Data.Length);
                            PLCDataU16.CopyTo(Data, 0);
                            return true;
                        case "Int32":
                            PLCoop.PLC_read_D_register(Function, Address, PLC通讯库.通讯枚举.numerical_format.Signed_32_Bit);
                            return true;
                        case "Int16":
                            PLCoop.PLC_read_D_register(Function, Address, PLC通讯库.通讯枚举.numerical_format.Signed_16_Bit);
                            return true;
                        case "UInt32":
                            PLCoop.PLC_read_D_register(Function, Address, PLC通讯库.通讯枚举.numerical_format.Unsigned_32_Bit);
                            return true;
                        case "UInt16":
                            PLCoop.PLC_read_D_register(Function, Address, PLC通讯库.通讯枚举.numerical_format.Unsigned_16_Bit);
                            return true;
                        case "Single":
                            PLCoop.PLC_read_D_register(Function, Address, PLC通讯库.通讯枚举.numerical_format.Float_32_Bit);
                            return true;
                    }
                    //判断用于需要读取的类型
                    var dd = Data.GetType().Name;
                }
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show($"未链接:{PLC}");
                return false;
            }
            return false;
        }

        /// <summary>
        /// 写入指定PLC的数据
        /// 写入个数由Data个数决定
        /// </summary>
        /// <param name="PLC">需要读取的PLC</param>
        /// <param name="Function">PLC的功能码</param>
        /// <param name="Address">PLC的地址</param>
        /// <param name="Data">读取返回</param>
        /// <returns></returns>
        public static bool SetPLCD(string PLC, string Function, string Address, ref dynamic Data)
        {
            try
            {
                //判断是否数组
                if (Data.GetType().BaseType != typeof(Array))
                {
                    return Set(Data);
                }
                //遍历写入数据的数组
                foreach (var content in Data)
                {
                    Set(content);
                }
                return true;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show($"未链接:{PLC}");
                return false;
            }
            bool Set(dynamic content)
            {
                IPLC_interface PLCoop = IPLCsurface.PLCDictionary.GetValueOrDefault(PLC) as IPLCcommunicationBase;
                if (PLCoop == null) return false;
                if (PLCoop.PLC_ready)
                {
                    switch (content.GetType().Name)
                    {
                        case "Int32":
                            PLCoop.PLC_write_D_register(Function, Address, content.ToString(), PLC通讯库.通讯枚举.numerical_format.Signed_32_Bit);
                            return true;
                        case "Int16":
                            PLCoop.PLC_write_D_register(Function, Address, content.ToString(), PLC通讯库.通讯枚举.numerical_format.Signed_16_Bit);
                            return true;
                        case "UInt32":
                            PLCoop.PLC_write_D_register(Function, Address, content.ToString(), PLC通讯库.通讯枚举.numerical_format.Unsigned_32_Bit);
                            return true;
                        case "UInt16":
                            PLCoop.PLC_write_D_register(Function, Address, content.ToString(), PLC通讯库.通讯枚举.numerical_format.Unsigned_16_Bit);
                            return true;
                        case "Single":
                            PLCoop.PLC_write_D_register(Function, Address, content.ToString(), PLC通讯库.通讯枚举.numerical_format.Float_32_Bit);
                            return true;
                    }
                }
                return false;
            }

        }

    }

}

