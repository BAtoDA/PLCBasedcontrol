using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLC报警控件保存类
{
    [Table("EventHistory")]
    public class EventHistory
    {
        [Key]
        public int id { get; set; }
        public int MessageID { get; set; }
        public int 类型 { get; set; } 
        public string 设备 { get; set; } 
        public string 设备_地址 { get; set; } 
        public string 设备_具体地址 { get; set; }
        public bool 位触发条件 { get; set; }
        public string 字触发条件 { get; set; } 
        public string 字触发条件_具体 { get; set; } 
        public string 报警内容 { get; set; }
        //新增报警显示时间
        public DateTime 报警发生时间 { get; set; }
        public DateTime 报警处理时间 { get; set; }
    }
}
