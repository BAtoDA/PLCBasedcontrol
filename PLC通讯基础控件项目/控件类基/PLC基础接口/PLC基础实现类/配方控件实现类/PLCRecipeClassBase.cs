using System;
using System.Collections.Generic;
using System.Text;
using PLC通讯基础控件项目.控件类基.控件数据结构;
using PLC通讯库.通讯枚举;

namespace PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.配方控件实现类
{
    /// <summary>
    /// PLC配方基础类
    /// 用于实现配方控件保存的参数
    /// </summary>
    public class PLCRecipeClassBase
    {
        /// <summary>
        /// 读取或者写入PLC类型
        /// </summary>
        public PLC[] ReadWritePLC { get; set; }=new PLC[] { PLC.Mitsubishi };
        /// <summary>
        /// 读取或者写入PLC的功能码
        /// </summary>
        public string[] ReadWriteFunction { get; set; }=new string[] {"M" };
        /// <summary>
        /// 需要访问的PLC地址
        /// </summary>
        public string[] PLC_address { get; set; } = new string[] { "0" };
        /// <summary>
        /// 显示表格的名称
        /// </summary>
        public string[] DataGridView_Name { get; set; } = new string[] { "Name1" };
        /// <summary>
        /// 表格对应的数据类型
        /// </summary>
        public numerical_format[] DataGridView_numerical { get; set; }=new numerical_format[] { numerical_format.Signed_16_Bit};
        /// <summary>
        /// 配方名称
        /// </summary>
        public string RecipeName { get; set; } = "Recipe1";
        /// <summary>
        /// 配方ID
        /// </summary>
        public int RecipeID { get; set; } = 1;
    }
}
