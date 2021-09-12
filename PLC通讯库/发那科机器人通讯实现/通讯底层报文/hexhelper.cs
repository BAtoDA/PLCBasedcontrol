using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanucRobot
{
    class hexhelper
    {
        public static byte[] Hexstr2Byte(string hexString)
        {
            var l = hexString.Length;
            if (l % 2 == 1)
            {
                return null;
            }
            else
            {
                byte[] bs = new byte[l / 2];
                for (int i = 0; i < l / 2; i++)
                {
                    var s = hexString.Substring(i * 2, 2);
                    var b = Convert.ToByte(s, 16);
                    bs[i] = b;
                }
                return bs;
            }
        }
        public static string Int2Hexstring(int data)
        {
            var s = string.Format("{0:X4}", data);
            return s.Substring(2) + s.Substring(0, 2);
        }
        public static byte[] Int2Byte(int[] data)
        {
            byte[] rets = new byte[data.Length * 4];
            for (int i = 0; i < data.Length; i++)
            {
                Array.Copy(BitConverter.GetBytes(data[i]), 0, rets, i * 4, 4);
            }
            return rets;
        }
        public static bool CheckEquel(byte[] b1, byte[] b2)
        {
            for (int i = 0; i < b1.Length; i++)
            {
                if (b1[i] != b2[i])
                {
                    return false;
                }
            }
            return true;
        }
        public static int[] Byte2Int(byte[] data, int startIdx = 0, int count = 0)
        {
            if (count == 0)
            {
                count = data.Length;
            }
            var rets = new int[count / 4];
            for (int i = 0; i < rets.Length; i++)
            {
                rets[i] = BitConverter.ToInt32(data, i * 4 + startIdx);
            }
            return rets;
        }
        public static float[] Byte2Float(byte[] data, int startIdx = 0, int count = 0)
        {
            if (count == 0)
            {
                count = data.Length;
            }
            var rets = new float[count / 4];
            for (int i = 0; i < rets.Length; i++)
            {
                rets[i] = BitConverter.ToSingle(data, i * 4 + startIdx);
            }
            return rets;
        }
        public static byte[] Float2Byte(float[] data)
        {
            var retLen = data.Length;
            var rets = new byte[retLen * 4];
            for (int i = 0; i < retLen; i++)
            {
                Array.Copy(BitConverter.GetBytes(data[i]), 0, rets, i * 4, 4);
            }
            return rets;
        }
        public static bool[] Byte2Bit(byte[] data)
        {
            var rets = new bool[data.Length * 8];
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    rets[i * 8 + j] = (data[i] & (1 << j)) == 0 ? false : true;
                }
            }
            return rets;
        }
        public static byte[] Bit2Byte(bool[] data)
        {
            var rets = new byte[data.Length / 8];
            for (int i = 0; i < rets.Length; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    var bit = data[i * 8 + j] ? 1 : 0;
                    rets[i] = (byte)(rets[i] | (bit << j));
                }
            }
            return rets;
        }
    }
}
