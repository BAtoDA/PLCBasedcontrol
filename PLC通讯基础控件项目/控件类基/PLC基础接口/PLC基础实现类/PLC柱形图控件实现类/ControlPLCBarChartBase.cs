//**********************************************************************
//
// 文件名称(File Name)：
// 功能描述(Description)：
// 作者(Author)：DAtoTA
// 日期(Create Date)： 2021/9/24 21:10:00
//
//**********************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLC柱形图控件实现类;
using PLC通讯基础控件项目.控件类基.PLC基础接口.表格控件_TO_PLC;
using PLC通讯基础控件项目.控件类基.控件数据结构;
using PLC通讯库.PLC通讯设备类型表;
using PLC通讯库.通讯基础接口;
using PLC通讯库.通讯实现类;
using Sunny.UI;

namespace PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLC表格控件实现类
{
    /// <summary>
    /// 实现基本柱形图控件类--读取数据--刷新到SQL
    /// </summary>
    public partial class ControlPLCBarChartBase : BasepublicClass
    {
        #region 实现基本接口  
        //基础外部文本颜色 与 内容控制
        /// <summary>
        /// 控件保存的参数
        /// </summary>
        PLCDataViewClassBase pLCViewClassBase;
        /// <summary>
        /// 控件基础接口参数
        /// </summary>
        PLCBarCharttClassBase pLCBarCharttClassBase;
        /// <summary>
        /// 安全控制状态--true正确 false 异常
        /// </summary>
        bool SafetyPattern;
        /// <summary>
        /// 控件对象
        /// </summary>
        UIBarChart PlcControl;
        /// <summary>
        /// SQL事务表
        /// </summary>
        volatile List<string> SQLoperation = new List<string>();
        /// <summary>
        /// PLC当前值表
        /// </summary>
        volatile List<string> PLCValue = new List<string>();
        /// <summary>
        /// 复归型按钮标志位
        /// </summary>
        //private volatile bool State = false;
        /// <summary>
        /// PLC安全操作模式
        /// </summary>
        volatile Safetypattern PLCsafetypattern = Safetypattern.Nooperation;
        #endregion
        public ControlPLCBarChartBase(UIBarChart PLCcontrol)
        {
            if(!(PLCcontrol is PLCDataViewClassBase))throw new Exception($"{PLCcontrol.GetType().Name} 不实现：PLCDataViewClassBase接口");
            if (!(PLCcontrol is PLCBarCharttClassBase)) throw new Exception($"{PLCcontrol.GetType().Name} 不实现：PLCBarCharttClassBase接口");
            this.pLCViewClassBase = PLCcontrol as PLCDataViewClassBase;
            this.pLCBarCharttClassBase = PLCcontrol as PLCBarCharttClassBase;
            //----------处理控件PLC--自动获取PLC类型对象----------
            PLCoopErr(pLCViewClassBase);
            this.PlcControl = PLCcontrol;
            //----------判断是否绑定了触发控件--------------------
            if(this.pLCViewClassBase.pLCDataViewselectRealize.BindingOpen)
            {
                var FormContr = (from Control p in GetContrForm(PLCcontrol).Controls where p.Name == this.pLCViewClassBase.pLCDataViewselectRealize.BindingName select p).FirstOrDefault();
                if (FormContr == null) throw new Exception($"查找{this.pLCViewClassBase.pLCDataViewselectRealize.BindingOpen}控件失败 \r\n 归属窗口是{GetContrForm(PLCcontrol).Parent.GetType().Name}");
                //-----绑定提前触发更新事件 不绑定表示代码层面刷新-----
                FormContr.Click += ((send, e) =>
                  {
                      lock (this)
                      {
                          this.PlcControl.BeginInvoke((EventHandler)delegate
                          {
                              GetPLC();
                          });
                      }
                  });

            }          
        }
        /// <summary>
        /// 读取PLC数据
        /// </summary>
        public void GetPLC()
        {
            if (PlcControl.IsDisposed || PlcControl.Created == false) return;
            if (((dynamic)this.PlcControl).PLC_Enable)
            {
                //PLCoopErr(pLCViewClassBase);
                //---清除事务表---
                SQLoperation.Clear();
                PLCValue.Clear();
                //循环遍历---获取PLC对象名---
                for (int i=0;i< this.pLCViewClassBase.pLCDataViewselectRealize.ReadWritePLC.Length;i++)
                {
                    IPLC_interface PLCoop = IPLCsurface.PLCDictionary.Where(p => p.Key.Trim() == this.pLCViewClassBase.pLCDataViewselectRealize.ReadWritePLC[i].ToString().Trim()).FirstOrDefault().Value as IPLCcommunicationBase;
                    if (PLCoop == null) return;
                    if (!PLCoop.PLC_ready)
                    {
                        //--当有PLC未就绪时直接返回方法--
                        return;
                    }
                    var PLCdata = PLCoop.PLC_read_D_register(this.pLCViewClassBase.pLCDataViewselectRealize.ReadWriteFunction[i], this.pLCViewClassBase.pLCDataViewselectRealize.PLC_address[i], this.pLCViewClassBase.pLCDataViewselectRealize.DataGridView_numerical[i]);
                    SQLoperation.Add($" INSERT INTO {this.pLCViewClassBase.pLCDataViewselectRealize.SQLsurface} ({this.pLCViewClassBase.pLCDataViewselectRealize.DataGridView_Name[i]}) VALUES ( { GetSQLType(this.pLCViewClassBase.pLCDataViewselectRealize.SQLsurfaceType[i], PLCdata)} )");
                    PLCValue.Add(PLCdata);
                }
            }
            //---处理SQL数据事务---
            if(this.pLCViewClassBase.pLCDataViewselectRealize.SQLOpen)
            {
                SetSQL(this.pLCViewClassBase.pLCDataViewselectRealize.SQLCharacter, this.pLCViewClassBase.pLCDataViewselectRealize.SQLsurface, SQLoperation.ToArray(), this.pLCViewClassBase.pLCDataViewselectRealize.SQLServer_SQLinte);
            }
            //--处理添加后的事务--修改当
            var option = this.PlcControl.Option;

            var series = option.Series[0];

            for (int i = 0; i < this.PLCValue.Count; i++)
            {
                series.Data[i]=(Convert.ToDouble(this.PLCValue[i]));
            }
            option.YAxisScaleLines.Add(new UIScaleLine() { Color = Color.Red, Name = "上限", Value = this.pLCBarCharttClassBase.YAxisMax });
            option.YAxisScaleLines.Add(new UIScaleLine() { Color = Color.Gold, Name = "下限", Value = this.pLCBarCharttClassBase.YAxisMin });

            option.XAxisScaleLines.Add(new UIScaleLine() { Color = Color.Red, Name = "上限", Value = this.pLCBarCharttClassBase.XAxisMax });
            option.XAxisScaleLines.Add(new UIScaleLine() { Color = Color.Gold, Name = "下限", Value = this.pLCBarCharttClassBase.XAxisMin });

            for (int i = 0; i < 3; i++)
                this.PlcControl.SetOption(option);
        }
        /// <summary>
        /// 使用事务把数据
        /// 写入到SQLServer/SQLLite
        /// </summary>
        /// <param name="SQLlink">SQL链接字符串</param>
        /// <param name="SQLsurface">SQL表名</param>
        /// <param name="SQLstatement">SQL需要执行的语句</param>
        private void SetSQL(string SQLlink,string SQLsurface,string[] SQLstatement,bool SLQServer_SLQLite)
        {
            if (SLQServer_SLQLite)
            {
                //建立连接并打开
                using SqlConnection myConn = new SqlConnection(SQLlink);
                myConn.Open();
                using SqlCommand myComm = new SqlCommand();
                SqlTransaction myTran;
                myTran = myConn.BeginTransaction();
                myComm.Transaction = myTran; //定位到pubs数据库
                myComm.Connection = myConn;
                foreach (var i in SQLstatement)
                {
                    //下面绑定连接和事务对象
                    myComm.CommandText = i;
                    myComm.ExecuteNonQuery();//更新数据
                }
                //提交事务--当提交失败自动回滚数据
                myTran.Commit();

            }
            else
            {
                //建立连接并打开
                using SQLiteConnection myConn = new SQLiteConnection(SQLlink);
                myConn.Open();
                using SQLiteCommand myComm = new SQLiteCommand();
                SQLiteTransaction myTran;
                myTran = myConn.BeginTransaction();
                myComm.Transaction = myTran; //定位到pubs数据库
                myComm.Connection = myConn;
                foreach (var i in SQLstatement)
                {
                    //下面绑定连接和事务对象
                    myComm.CommandText = i;
                    myComm.ExecuteNonQuery();//更新数据
                }
                //提交事务--当提交失败自动回滚数据
                myTran.Commit();

            }
        }
     
    }

}
