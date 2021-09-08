using HslCommunication;
using HslCommunication.Profinet;
using PLC通讯库.通讯枚举;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLC通讯库.通讯实现类
{
    /// <summary>
    /// 本类是共用类 
    /// </summary>
    public class PLC_public_Class:Object
    {
        /// <summary>
        /// 指示着其他用户正在访问
        /// </summary>
        public static bool PLC_busy;//指示着其他用户正在访问
     
        /// <summary>
        /// int转B00L
        /// </summary>
        /// <param name="result"></param>
        /// <param name="len"></param>
        /// <returns></returns>
        public bool[] ConvertIntToBoolArray(int result, int len)//int转B00L
        {

            if (len > 32 || len < 0)
            {
                Console.WriteLine("bool数组长度应该在0到32之间。");
            }

            bool[] barray2 = new bool[len];

            for (int i = 0; i < len; i++)
            {
                barray2[len - i - 1] = ((result >> i) % 2) == 1;
            }
            return barray2;
        }
        /// <summary>
        /// 处理bit位数据 公有方法
        /// </summary>
        /// <param name="import"></param>
        /// <returns></returns>
        public List<bool> bit_public(short[] import)//处理bit位数据 公有方法
        {
            List<bool> data = new List<bool>();//创建表
            bool[] Inputtheresults = ConvertIntToBoolArray(import[0], 16);//强转BOOL类型
            Array.Reverse(Inputtheresults);//翻转数组
            foreach (bool i in Inputtheresults) data.Add(i);//填充表
            return data;
        }
        /// <summary>
        /// 从新合并INT类型
        /// </summary>
        /// <param name="Resistancedata"></param>
        /// <returns></returns>
        public int merge(short[] Resistancedata) //从新合并INT类型
        {
            //合并PLC电阻数据操作
            byte[] transform = BitConverter.GetBytes(Resistancedata[0]);
            byte[] transform_1 = BitConverter.GetBytes(Resistancedata[1]);
            byte[] taran = new byte[transform.Length + transform_1.Length];
            for (int i = 0; i < taran.Length; i++)
            {
                if (i < transform.Length) taran[i] = transform[i]; else taran[i] = transform_1[i - transform.Length];
            }
            return BitConverter.ToInt32(taran,0);
        }
        /// <summary>
        /// 从新合并INT类型
        /// </summary>
        /// <param name="Resistancedata"></param>
        /// <returns></returns>
        public Double merge_to_Double(short[] Resistancedata) //从新合并INT类型
        {
            //合并PLC电阻数据操作
            byte[] transform = BitConverter.GetBytes(Resistancedata[0]);
            byte[] transform_1 = BitConverter.GetBytes(Resistancedata[1]);
            byte[] taran = new byte[transform.Length + transform_1.Length];
            for (int i = 0; i < taran.Length; i++)
            {
                if (i < transform.Length) taran[i] = transform[i]; else taran[i] = transform_1[i - transform.Length];
            }
            return BitConverter.ToSingle(taran, 0);//转换成浮点小数
        }
        /// <summary>
        /// BOOL转INT类型
        /// </summary>
        /// <param name="barray"></param>
        /// <returns></returns>
        public int ConvertBoolArrayToInt(bool[] barray)//BOOL转INT类型
        {
            int result = 0;
            if (barray != null)
            {
                int len = barray.Length;

                if (len < 33)
                {
                    foreach (bool b in barray)
                    {
                        result = (result << 1) + (b ? 1 : 0);
                    }
                }
                else
                {
                    Console.WriteLine("bool数组长度大于32，整数只有32位。");
                }
            }
            else
            {
                Console.WriteLine("bool数组为空。");
            }
            return result;
        }
   
  
        /// <summary>
        /// 数据类型查询
        /// </summary>
        /// <returns></returns>
        public numerical_format inquire_numerical(string format)
        {
            numerical_format numerical = numerical_format.Unsigned_32_Bit;//默认类型
            foreach (numerical_format suit in Enum.GetValues(typeof(numerical_format)))
            {
                if (suit.ToString() == format.Trim()) numerical = suit;//获取到的数据类型
            }
            return numerical;
        }
        /// <summary>
        /// float-转-short
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public short[] float_to_short(float Name)//float-转-short
        {
            byte[] data = new byte[32];//寄存器
            data = BitConverter.GetBytes(Name);//解析数据
            return new short[] { BitConverter.ToInt16(data, 0), BitConverter.ToInt16(data, 2) };//合并数据返回数据
        }
        /// <summary>
        /// string-to-short
        /// </summary>
        /// <param name="inString"></param>
        /// <param name="outShort"></param>
        /// <returns></returns>
        public short[] stringToShort(string inString, short[] outShort)//string-to-short
        {
            byte[] data = new byte[32];//寄存器
            data = BitConverter.GetBytes(Convert.ToInt32(inString));//解析数据
            return new short[] { BitConverter.ToInt16(data, 0), BitConverter.ToInt16(data, 2) };//合并数据返回数据
        }
        /// <summary>
        /// 移除多余的short
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public short[] bit32_to_bit32(short[] Name)//移除多余的short
        {
            return new short[] { Name[0] };//返回数据
        }
        /// <summary>
        /// hex-to-bcd
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public int Hex_to_BCD(int d)
        {
            int de = ((d >> 8) * 100) | ((d >> 4) * 10) | (d & 0x0f);
            return de;
        }
        /// <summary>
        /// 解析Y点线圈状态
        /// </summary>
        /// <param name="Data"></param>
        /// <param name="address"></param>
        /// <returns></returns>
        public bool Analysis(byte[] Data, int address)
        {
            int len = 0;//Y点读取位置
            int inx = 0;//尾部位置
            switch (address.ToString().Length)
            {
                case 1:
                    len = 1;
                    inx = address;
                    break;
                case 2:
                    len = Convert.ToInt32(address.ToString().Remove(1, 1)) % 2 > 0 ? 2 : 1;
                    inx = Convert.ToInt32(address.ToString().Remove(0, 1));
                    break;
                case 3:
                    len = Convert.ToInt32(address.ToString().Remove(2, 2)) % 2 > 0 ? 2 : 1;
                    inx = Convert.ToInt32(address.ToString().Remove(0, 2));
                    break;
            }
            if (len > 1)
            {
                int a = 15 + (inx / 2);
                return Y_ysis(Data[15 + (inx / 2)], inx);
            }
            return Y_ysis(Data[11 + (inx / 2)], inx);
        }
        private bool Y_ysis(byte Data, int inx)
        {
            switch (Data)
            {
                case 1:
                    if (inx % 2 == 1)
                        return true;
                    else
                        return false;
                case 16:
                    if (inx % 2 == 1)
                        return false;
                    else
                        return true;
                case 17:
                    if (inx % 2 == 1)
                        return true;
                    else
                        return true;
                case 0:
                    if (inx % 2 == 1)
                        return false;
                    else
                        return false;
            }
            return false;
        }
    }
}
