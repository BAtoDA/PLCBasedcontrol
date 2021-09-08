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
using PLC通讯基础控件项目.控件类基.控件数据结构;

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

            // Initialize a new instance of the SpeechSynthesizer.  
            SpeechSynthesizer synth = new SpeechSynthesizer();

            // Configure the audio output.   
            synth.SetOutputToDefaultAudioDevice();

            // Speak a string.  
            //synth.Speak(Value??"数据为空");
            synth.SpeakAsync(Value ?? "数据为空");
        }
    }
}
