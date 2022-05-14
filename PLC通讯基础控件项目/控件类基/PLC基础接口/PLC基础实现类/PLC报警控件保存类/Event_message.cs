using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Windows.Forms;

namespace PLC通讯基础控件项目.控件类基.PLC基础接口.PLC报警控件保存类
{
    /// <summary>
    /// 报警参数表
    /// </summary>
    [Table("EventMessage")]
    public class EventMessage
    {
        [Key]
        public int id { get; set; }
        public int MessageID { get; set; }
        public int 类型 { get; set; } = 0;
        public string 设备 { get; set; } = "Mitsubishi";
        public string 设备_地址 { get; set; } = "M";
        public string 设备_具体地址 { get; set; } = "0";
        public bool 位触发条件 { get; set; } = true;
        public string 字触发条件 { get; set; } = ">";
        public string 字触发条件_具体 { get; set; } = "0";
        public string 报警内容 { get; set; } = "请输入报警内容。。。";
        //新增报警显示时间
        public string 报警发生时间 { get; set; } = DateTime.Now.ToString("F");
        public string 报警处理时间 { get; set; } = DateTime.Now.ToString("F");
    } 
}
