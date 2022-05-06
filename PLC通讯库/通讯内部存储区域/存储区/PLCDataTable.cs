using System;
using System.Collections.Generic;
using System.Text;

namespace PLC通讯库.通讯内部存储区域.存储区
{
    public class PLCDataTable
    {
        /// <summary>
        /// PLCbit位的内存存储表
        /// </summary>
        public static PLCDataSet.PLCData_BitDataTable pLCData_Bits = new PLCDataSet.PLCData_BitDataTable();
        /// <summary>
        /// PLCD寄存器的内存存储表
        /// </summary>
        public static PLCDataSet.PLCData_DDataTable pLCData_Ds = new PLCDataSet.PLCData_DDataTable();

    }
}
