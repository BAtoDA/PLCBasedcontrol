using PLC通讯基础控件项目.控件类基.控件数据结构;
using PLC通讯库.通讯枚举;
using System;
using System.Collections.Generic;
using System.Text;

namespace PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLC二维码控件实现类
{
    /// <summary>
    /// 实现二维码以及条形码
    /// 基础接口
    /// </summary>
    [Serializable]
    public sealed class PLCQRcodeRealize : PLCQRcodeBase
    {
        #region 实现二维码接口
        public bool Select { get; set; } = false;
        public bool BindingOpen { get; set; } = false;
        public string BindingName { get; set; }
        public PLC ReadWritePLC { get; set; } = PLC.Mitsubishi;
        public string ReadWriteFunction { get; set; } = "D";
        public string ReadWriteAddress { get; set; } = "0";
        public numerical_format ShowFormat { get; set; } = numerical_format.Signed_32_Bit;
        public PLC WritePLC { get; set; } = PLC.Mitsubishi;
        public string WriteFunction { get; set; } = "M";
        public string WriteAddress { get; set; } = "0";
        #endregion
    }
}
