using System;
using System.Collections.Generic;
using System.Text;

namespace PLC通讯基础控件项目.控件类基.控件数据结构
{
    /// <summary>
    /// 设备报警判定类基
    /// </summary>
    public class PLCErrBase
    {
        /// <summary>
        /// 触发条件--bit位
        /// </summary>
        public static readonly string[] condition_Bit = new string[] { "ON", "OFF" };
        /// <summary>
        /// 触发条件--word字--由于枚举不能写小于等于号现用字符串替代
        /// </summary>
        public static readonly string[] condition_word = new string[] { "<", ">", "==", "<>", ">=", "<=" };
    }
}
