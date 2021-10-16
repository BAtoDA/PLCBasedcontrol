using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PLC通讯基础控件项目.控件类基.PLC基础接口.判定控件是否在设计期
{
    /// <summary>
    /// 判定类 
    /// 自定义控件判断是否处于IDE设计模式
    /// </summary>
    class IsDesignModeClass
    {
        /// <summary>
        /// 是否在设计期
        /// </summary>
        public static bool IsDesignMode
        {
            get
            {
                
                if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                {
                    return true;
                }
                else if (System.Diagnostics.Process.GetCurrentProcess().ProcessName == "devenv")
                {
                    return true;
                }

                return false;
            }
        }
    }
}
