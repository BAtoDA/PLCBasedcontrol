//**********************************************************************
//
// 文件名称(File Name)：
// 功能描述(Description)：
// 作者(Author)：DAtoTA
// 日期(Create Date)： 2021/8/25 9:05:08
//
//**********************************************************************
using System;
using System.Collections.Generic;
using System.Text;

namespace PLC通讯基础控件项目.控件类基.控件数据结构
{
    /// <summary>
    /// 控件选择PLC以及地址的实现类
    /// </summary>
    [Serializable]
    class PLCselectRealize : PLCselectBase
    {
        #region 实现父类
        public override PLC PLCRW { get; set; }
        public override Enum PLCRWType { get; set; }
        public override string PLCRWAddresses { get; set; }
        public override bool Read_write { get; set; }
        public override PLC PLCW { get; set; }
        public override Enum PLCWType { get; set; }
        public override string PLCWAddresses { get; set; }
        public override bool D_Bit { get; set; }
        #endregion
    }
}
