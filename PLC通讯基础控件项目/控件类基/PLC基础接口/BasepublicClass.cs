//**********************************************************************
//
// 文件名称(File Name)：
// 功能描述(Description)：
// 作者(Author)：DAtoTA
// 日期(Create Date)： 2021/9/8 22:51:19
//
//**********************************************************************
using System;
using System.Collections.Generic;
using System.Text;
using System.Speech.Synthesis;
using System.Threading.Tasks;
using PLC通讯基础控件项目.控件类基.控件数据结构;
using PLC通讯基础控件项目.控件类基.控件安全对象池;
using PLC通讯库.PLC通讯设备类型表;
using System.Diagnostics;
using PLC通讯基础控件项目.控件类基.PLC基础接口.表格控件_TO_PLC;
using System.Windows.Forms;
using PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLC报警显示控件实现类;

namespace PLC通讯基础控件项目.控件类基.PLC基础接口
{
    public class BasepublicClass
    {
        /// <summary>
        /// 判断当前安全模式状态
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        protected Safetypattern Getsafetypattern(int  Value)
        {
            switch (Value)
            {
                case 0:
                    return Safetypattern.Close;
                case 1:
                    return Safetypattern.Hide;
                case 2:
                    return Safetypattern.Gray;
                case 3:
                    return Safetypattern.Nooperation;
            }
            return Safetypattern.Nooperation;
        }
        /// <summary>
        /// 使用系统语音播报系统进行播放
        /// </summary>
        /// <param name="Value"></param>
        protected void Voicebroadcast(string Value)
        {
            //判断对象池是否为空
            if (VoiceObjectPool<Tuple<SpeechSynthesizer>>._objects == null) return;
            //向对象池申请 
            var Poss = VoiceObjectPool<Tuple<SpeechSynthesizer>>.GetObject();
            //使用对象池--对象进行语音播报
            Poss.Item1.SetOutputToDefaultAudioDevice();
            Poss.Item1.SpeakAsync(Value??"语音播报数据未Null");
            //归还对象----
            Poss.Item1.SpeakCompleted += Voice;
            void Voice(object send,EventArgs e)
            {
                Poss.Item1.SpeakCompleted -= Voice;
                VoiceObjectPool<Tuple<SpeechSynthesizer>>.PutObject(Poss);
            }
        }
        /// <summary>
        /// 用于位校验PLC对象
        /// </summary>
        protected void PLCoopErr(PLCBitClassBase pLCBitClassBase, PLCBitproperty pLCBitproperty)
        {
            try
            {
                if (pLCBitClassBase == null) throw new Exception($" 不实现：PLCBitBase接口");
                if (pLCBitproperty == null) throw new Exception($" 不实现：PLCBitproperty接口");
                if (IPLCsurface.PLCDictionary.Count < 1 || !IPLCsurface.PLCDictionary.ContainsKey(pLCBitClassBase.pLCBitselectRealize.ReadWritePLC.ToString())) throw new Exception("PLC通讯表为空");
            }
            catch (Exception E)
            {
                Debug.WriteLine(E.Message);
            }
        }
        /// <summary>
        /// 用于寄存器校验PLC对象
        /// </summary>
        protected void PLCoopErr(PLCDClassBase pLCDClassBase, PLCDproperty pLCDproperty)
        {
            try
            {
                if (pLCDClassBase == null) throw new Exception($" 不实现：PLCDBase接口");
                if (pLCDproperty == null) throw new Exception($" 不实现：PLCDproperty接口");
                if (IPLCsurface.PLCDictionary.Count < 1 || !IPLCsurface.PLCDictionary.ContainsKey(pLCDClassBase.pLCDselectRealize.ReadWritePLC.ToString())) throw new Exception("PLC通讯表为空");
            }
            catch (Exception E)
            {
                Debug.WriteLine(E.Message);
            }
        }
        /// <summary>
        /// 用于表格校验PLC对象
        /// </summary>
        protected void PLCoopErr(PLCDataViewClassBase pLCViewClassBase)
        {
            try
            {
                if (pLCViewClassBase == null) throw new Exception($" 不实现：PLCDataViewClassBase接口");
                if (IPLCsurface.PLCDictionary.Count < 1 || !IPLCsurface.PLCDictionary.ContainsKey(pLCViewClassBase.pLCDataViewselectRealize.ReadWritePLC.ToString())) throw new Exception("PLC通讯表为空");
            }
            catch (Exception E)
            {
                Debug.WriteLine(E.Message);
            }
        }
        /// <summary>
        /// 获取控件归属的窗口
        /// </summary>
        /// <param name="OopContr"></param>
        /// <returns></returns>
        protected Form GetContrForm(dynamic OopContr)
        {
            //递归查找顶级窗口Form
            object Oop = OopContr;
            while (true)
            {
                if ((((dynamic)Oop).Parent as Form) != null)
                {
                    return (Form)((dynamic)Oop).Parent;

                }
                else
                    Oop = ((dynamic)Oop).Parent;
            }
        }
        protected dynamic GetSQLType(string Type,string Value)
        {
            dynamic reval = string.Empty;
            switch (Type.ToLower())
            {
                case "int":
                   return Convert.ToInt32(Value);
                default:
                case "varchar":
                case "nvarchar":
                case "ntext":
                case "nchar":
                case "char":
                case "text":
                    return $" '  {Value}  '";
                case "bigint":
                    return Convert.ToInt64(Value);
                case "binary":
                case "image":
                case "varbinary":
                    return Encoding.UTF8.GetBytes(Value);
                case "bit":
                    return Convert.ToBoolean(Value);
                case "smalldatetime":
                case "datetime":
                case "timestamp":
                    return DateTime.Parse(Value);
                case "numeric":
                case "money":
                case "decimal":
                case "smallmoney":
                    return Decimal.Parse(Value);
                case "float":
                    return Convert.ToDouble(Value);
                case "real":
                    return Convert.ToSingle(Value);
                case "smallint":
                    return Convert.ToInt16(Value);
                case "tinyint":
                    return Convert.ToByte(Value);
                case "uniqueidentifier":
                   return Guid.Parse(Value);
                case "Variant":
                    return (Object)Value;
            }
        }
    }
}
