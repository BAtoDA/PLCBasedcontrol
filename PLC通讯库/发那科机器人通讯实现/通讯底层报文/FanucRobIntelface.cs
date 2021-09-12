using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FanucRobot
{
    public class FanucRobIntelface:SocketBase
    {
        int regCount = 0;
        protected bool isConnected = false;
        Dictionary<RegCls, int[]> registerList = new Dictionary<RegCls, int[]>();

        //数值寄存器
        //int和float数组是同一块R寄存器的内容，只是编码方式不同，区间设置可以重叠。
        public int[] intRegion = new int[] { 1, 100 };//表示R[1]~R[100]为整数
        public int[] intRegs = null;//数据
        public int[] floatRegion = new int[] { 101, 200 };//表示R[101]~R[200]为实数
        public float[] floatRegs = null;

        //位置寄存器
        public int[] prRegion = new int[] { 1, 10 };
        public PR[] prRegs = null;
        public bool canReadCurrentPos = true;//设置是否读取当前位置
        public PR curPos = null;

        //字符串寄存器
        public int[] strRegion = new int[] { 1, 10 };
        public string[] strRegs = null;

        public FanucRobIntelface(string ipAdr) : base(ipAdr, 60008) { }
        public ResultMessage Connect()
        {
            if (this.isConnected) return CreatResult();
            var cmdSend = hexhelper.Hexstr2Byte("0000040000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000");
            byte[] recData = new byte[256];
            var result = SendRead(cmdSend, recData);
            if (result.isError) return result;  
            var isSuccess = hexhelper.CheckEquel(hexhelper.Hexstr2Byte("0100000000000000010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000"), recData);
            if (!isSuccess) return CreatResult(true, "data error : in CheckEquel.");
            cmdSend = hexhelper.Hexstr2Byte("08000100000000000001000000000000000100000000000000000000000001c000000000100e000001014f01000000000000000000000000");
            result = SendRead(cmdSend, recData);
            if (result.isError) return result;
            result = CheckAnswer(recData, "01", "d4", 0, "02");
            if (result.isError) return result;
            cmdSend = hexhelper.Hexstr2Byte("02000800000000000001000000000000000100000000000000000000000008c000000000100e00000101073800000600434c524153470400");
            result = SendRead(cmdSend, recData);
            if (result.isError) return result;
            result = CheckAnswer(recData, "08", "d4", 0);
            if (result.isError) return result;

            int regLength = 0;
            string regStr = null;
            //注册int区
            if (intRegion[0] < intRegion[1])
            {
                regLength = (intRegion[1] - intRegion[0] + 1) * 2;
                regStr = $"SETASG {regCount + 1} {regLength} R[{intRegion[0]}] 1.0";
                result = Register(regStr);
                if (result.isError) return result;
                registerList.Add(RegCls.Rint, new int[] { regCount, regLength });
                regCount += regLength;
            }

            //注册float区
            if (floatRegion[0] < floatRegion[1])
            {
                regLength = (floatRegion[1] - floatRegion[0] + 1) * 2;
                regStr = $"SETASG {regCount + 1} {regLength} R[{floatRegion[0]}] 0";
                result = Register(regStr);
                if (result.isError) return result;
                registerList.Add(RegCls.Rfloat, new int[] { regCount, regLength });
                regCount += regLength;
            }

            //注册当前位置
            if (canReadCurrentPos)
            {
                regLength = 50;
                regStr = $"SETASG {regCount + 1} {regLength} POS[0] 0.0";
                result = Register(regStr);
                if (result.isError) return result;
                registerList.Add(RegCls.Rpos, new int[] { regCount, regLength });
                regCount += regLength;
            }
            //注册PR寄存器
            if (prRegion[0] < prRegion[1])
            {
                regLength = (prRegion[1] - prRegion[0] + 1) * 50;
                regStr = $"SETASG {regCount + 1} {regLength} PR[{prRegion[0]}] 0.0";
                result = Register(regStr);
                if (result.isError) return result;
                registerList.Add(RegCls.Rpr, new int[] { regCount, regLength });
                regCount += regLength;
            }
            //注册SR寄存器
            if (strRegion[0] < strRegion[1])
            {
                regLength = (strRegion[1] - strRegion[0] + 1) * 40;
                regStr = $"SETASG {regCount + 1} {regLength} SR[{strRegion[0]}] 1";
                result = Register(regStr);
                if (result.isError) return result;
                registerList.Add(RegCls.Rstring, new int[] { regCount, regLength });
                regCount += regLength;
            }
            this.isConnected = true;
            return result;
        }
        public void Disconnect()
        {
            Close();
        }
        public ResultMessage Refresh()
        {
            byte[] conRec = new byte[8000];
            var result = FetchData(conRec, 0, regCount, "0408");
            if (result.isError) return result;
            byte[] data = null;
            result = CheckAnswer2(conRec, regCount * 2,ref data);
            if (result.isError) return result;
            return GetData(data);
        }
        public ResultMessage ReadSdo(int startIdx, int count,ref bool[] dataOut)
        {
            startIdx--;
            return ReadIO(startIdx, count, "0446",ref dataOut);
        }
        public ResultMessage ReadSdI(int startIdx, int count, ref bool[] dataOut)
        {
            startIdx--;
            return ReadIO(startIdx, count, "0448", ref dataOut);
        }
        public ResultMessage ReadRdo(int startIdx, int count, ref bool[] dataOut)
        {
            startIdx--;
            startIdx += 5000;
            return ReadIO(startIdx, count, "0446",ref dataOut);
        }
        public ResultMessage ReadRdi(int startIdx, int count, ref bool[] dataOut)
        {
            startIdx--;
            startIdx += 5000;
            return ReadIO(startIdx, count, "0448",ref dataOut);
        }
        public ResultMessage ReadRuo(int startIdx, int count, ref bool[] dataOut)
        {
            startIdx--;
            startIdx += 6000;
            return ReadIO(startIdx, count, "0446", ref dataOut);
        }
        public ResultMessage ReadRui(int startIdx, int count, ref bool[] dataOut)
        {
            startIdx--;
            startIdx += 6000;
            return ReadIO(startIdx, count, "0448", ref dataOut);
        }
        public ResultMessage WriteSdo(bool[] data, int startIdx)
        {
            startIdx--;
            return WriteIO(data, startIdx);
        }
        public ResultMessage WriteRdo(bool[] data, int startIdx)
        {
            startIdx--;
            startIdx += 5000;
            return WriteIO(data, startIdx);
        }
        public ResultMessage WriteUo(bool[] data, int startIdx)
        {
            startIdx--;
            startIdx += 6000;
            return WriteIO(data, startIdx);
        }
        public ResultMessage WriteR(int[] data, int startIdx)
        {
            startIdx -= intRegion[0];
            startIdx *= 2;
            startIdx += registerList[RegCls.Rint][0];
            var dataB = hexhelper.Int2Byte(data);
            return WriteData1(dataB, startIdx, dataB.Length / 2, "0708");
        }
        public ResultMessage WriteR(float[] data, int startIdx)
        {
            startIdx -= floatRegion[0];
            startIdx *= 2;
            startIdx += registerList[RegCls.Rfloat][0];
            var dataB = hexhelper.Float2Byte(data);
            return WriteData1(dataB, startIdx, dataB.Length / 2, "0708");
        }
        public ResultMessage WritePR(PR data, int startIdx)
        {
            startIdx -= prRegion[0];
            startIdx *= 50;
            startIdx += registerList[RegCls.Rpr][0];
            var dataB = Pos2Bytes(data);
            return WriteData1(dataB, startIdx, dataB.Length / 2, "0708");
        }
        public ResultMessage WriteSR(string[] data, int startIdx)
        {
            startIdx -= strRegion[0];
            startIdx *= 40;
            startIdx += registerList[RegCls.Rstring][0];
            var dataB = String2Byte(data);
            return WriteData1(dataB, startIdx, dataB.Length / 2, "0708");
        }



        ResultMessage Register(string rStr)
        {
            return WriteData1(Encoding.ASCII.GetBytes(rStr), 0, rStr.Length, "0738");
        }
        ResultMessage WriteData1(byte[] data, int startIdx, int count, string code)
        {
            byte[] recData = new byte[256];
            var len = hexhelper.Int2Hexstring(data.Length);
            var countH = hexhelper.Int2Hexstring(count);
            var startIdxH = hexhelper.Int2Hexstring(startIdx);
            var cmdData = hexhelper.Hexstr2Byte($"02000900{len}000000020000000000000002000000000000000000000000098000000000100e000001013200000000000101{code}{startIdxH}{countH}");
            var sendData = new byte[cmdData.Length + data.Length];
            Array.Copy(cmdData, 0, sendData, 0, cmdData.Length);
            Array.Copy(data, 0, sendData, cmdData.Length, data.Length);
            var result = SendRead(sendData, recData);
            if (result.isError) return result;
            return CheckAnswer(recData, "09", "d4", 0);
        }
        ResultMessage WriteData2(byte[] data, int startIdx, int count, string code)
        {
            byte[] recData = new byte[256]; 
            var countH = hexhelper.Int2Hexstring(count);
            var startIdxH = hexhelper.Int2Hexstring(startIdx);
            var cmdData = hexhelper.Hexstr2Byte($"02000800000000000001000000000000000100000000000000000000000008c000000000100e00000101{code}{startIdxH}{countH}0100020003000400");
            Array.Copy(data, 0, cmdData, cmdData.Length - 8, data.Length);
            var result = SendRead(cmdData, recData);
            if (result.isError) return result;
            return CheckAnswer(recData, "08", "d4", 0);

        }
        ResultMessage FetchData(byte[] data, int startIdx, int count, string code)
        {
            var countH = hexhelper.Int2Hexstring(count);
            var startIdxH = hexhelper.Int2Hexstring(startIdx);
            var cmdData = hexhelper.Hexstr2Byte($"02000600000000000001000000000000000100000000000000000000000006c000000000100e00000101{code}{startIdxH}{countH}0000000000000000");
            return SendRead(cmdData, data);
        }
        ResultMessage CheckAnswer(byte[] data, string code1, string code2, int count, string code3 = "04")
        {
            var len = hexhelper.Int2Hexstring(count);
            var str = $"0300{code1}00{len}000000010000000000000001000000000000000000000000{code1}{code2}100e0000303a000001010000000000000101ff{code3}00007c21";
            var corrB = hexhelper.Hexstr2Byte(str);
            return hexhelper.CheckEquel(corrB, data)? CreatResult():CreatResult(true,"data error : in CheckAnswer");
        }
        ResultMessage CheckAnswer1(byte[] answer,ref byte[] dataOut)
        {
            var correctAnswer = hexhelper.Hexstr2Byte($"03000600000000000001000000000000000100000000000000000000000006d4100e0000303a000001010000000000000000000000007c21");
            var dataB = new byte[6];
            Array.Copy(answer, 44, dataB, 0, dataB.Length);
            Array.Copy(new byte[] { 0, 0, 0, 0, 0, 0 }, 0, answer, 44, 6);
            if (hexhelper.CheckEquel(correctAnswer, answer))
            {
                dataOut = dataB;
                return CreatResult();
            }
            return CreatResult(true, "data error : in CheckAnswer1");
        }
        ResultMessage CheckAnswer2(byte[] answer, int count ,ref byte[] dataOut)
        {
            var result = CheckAnswer(answer, "06", "94", count);
            if (!result.isError)
            {
                var dataB = new byte[count];
                Array.Copy(answer, 56, dataB, 0, dataB.Length);
                dataOut = dataB;
            }
            return result;
        }
        ResultMessage ReadIO(int startIdx, int count, string code,ref bool[] dataOut)
        {
            var countP = (startIdx % 8) + count;
            countP = 8 - (countP % 8) + countP;
            var idx = startIdx / 8 * 8;

            var recData = new byte[800];
            var result = FetchData(recData, idx, countP, code);
            if (result.isError) return result;
            bool[] dataR;
            if (countP > 48)
            {
                byte[] data = null;
                result = CheckAnswer2(recData, countP / 8, ref data);
                if (result.isError) return result;
                dataR = hexhelper.Byte2Bit(data);
            }
            else
            {
                byte[] data = null;
                result = CheckAnswer1(recData,ref data);
                if (result.isError) return result;
                dataR = hexhelper.Byte2Bit(data);
            }
            var rets = new bool[count];
            Array.Copy(dataR, startIdx % 8, rets, 0, rets.Length);
            dataOut = rets;
            return result;
        }
        ResultMessage WriteIO(bool[] data, int startIdx)
        {
            var count = data.Length;
            var l = data.ToList();
            if (startIdx % 8 > 0)
            {
                l.InsertRange(0, new bool[startIdx % 8]);
            }
            if (l.Count % 8 > 0)
            {
                l.AddRange(new bool[8 - (l.Count % 8)]);
            }
            var dataR = l.ToArray(); 
            var dataB = hexhelper.Bit2Byte(dataR);
            if (dataB.Length > 6)
            {
                return WriteData1(dataB, startIdx, count, "0746");
            }
            else
            {
                return WriteData2(dataB, startIdx, count, "0746");
            }
        }
        ResultMessage GetData(byte[] data)
        {
            foreach (var reg in registerList)
            {
                var startIdx = reg.Value[0] * 2;
                var count = reg.Value[1] * 2;
                switch (reg.Key)
                {
                    case RegCls.Rint:
                        intRegs = hexhelper.Byte2Int(data, startIdx, count);
                        break;
                    case RegCls.Rfloat:
                        floatRegs = hexhelper.Byte2Float(data, startIdx, count);
                        break;
                    case RegCls.Rpos:
                        curPos = GetPosData(data, startIdx, count)[0];
                        break;
                    case RegCls.Rpr:
                        prRegs = GetPosData(data, startIdx, count);
                        break;
                    case RegCls.Rstring:
                        strRegs = GetString(data, startIdx, count);
                        break;
                    default:
                        return CreatResult(true, "data error : in get data");
                }
            }
            return CreatResult();
        }
        PR[] GetPosData(byte[] data, int startIdx = 0, int count = 0)
        {
            var dataF = hexhelper.Byte2Float(data, startIdx, count);
            var countP = dataF.Length / 25;
            var prs = new PR[countP];
            for (int i = 0; i < countP; i++)
            {
                PR pr = new PR();
                Array.Copy(dataF, i * 25 + 0, pr.pc, 0, 6);
                Array.Copy(dataF, i * 25 + 13, pr.pj, 0, 6);
                prs[i] = pr;
            }
            return prs;
        }
        byte[] Pos2Bytes(PR pr)
        {
            var rets = new byte[52];
            var dataB = hexhelper.Float2Byte(pr.pc);
            Array.Copy(dataB, 0, rets, 0, dataB.Length);
            return rets;
        }
        byte[] String2Byte(string[] data)
        {
            var countS = data.Length;
            var rets = new byte[countS * 80];
            for (int i = 0; i < countS; i++)
            {
                var dataB = Encoding.ASCII.GetBytes(data[i]);
                Array.Copy(dataB, 0, rets, i * 80, dataB.Length);
            }
            return rets;
        }
        string[] GetString(byte[] data, int startIdx = 0, int count = 0)
        {
            if (count == 0)
            {
                count = data.Length;
            }
            count /= 80;
            var rets = new string[count];
            for (int i = 0; i < count; i++)
            {
                rets[i] = Encoding.ASCII.GetString(data, i * 80 + startIdx, 80);
            }
            return rets;
        }
    }
}
