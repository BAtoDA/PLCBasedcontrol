using Microsoft.EntityFrameworkCore;
using PLC通讯基础控件项目.控件类基.PLC基础接口.PLC报警控件保存类;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLC报警控件保存类
{
    //==============================================================
    //  作者：BAtoDA
    //  时间：2022/5/11 10:22:28 
    //  文件名：PoliceContext 
    //  版本：V1.0.0
    //  说明： 实现SQLlite数据库EF实体模型
    //  修改者：***
    //  修改说明： 
    //==============================================================
    public class PoliceContext: DbContext
    {
        public string DbPath { get; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($@"Data Source= ‪EventData.db");
        public DbSet<EventMessage> UserElectricMark { set; get; }
        public DbSet<EventHistory> UserEventHistory { set; get; }
    }
}
