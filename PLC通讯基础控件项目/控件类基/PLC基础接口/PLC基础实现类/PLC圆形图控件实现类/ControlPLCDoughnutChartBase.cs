using PLC通讯基础控件项目.控件类基.PLC基础接口.表格控件_TO_PLC;
using PLC通讯基础控件项目.控件类基.控件数据结构;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using PLC通讯库.通讯基础接口;
using PLC通讯库.PLC通讯设备类型表;
using System.Data.SqlClient;
using System.Data.SQLite;
using PLC通讯库.通讯实现类;

namespace PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLC圆形图控件实现类
{
    /// <summary>
    /// 
    /// </summary>
    class ControlPLCDoughnutChartBase:BasepublicClass
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
        ControlDoughnutChartClassBase pLCBarCharttClassBase;
        /// <summary>
        /// 安全控制状态--true正确 false 异常
        /// </summary>
        bool SafetyPattern;
        /// <summary>
        /// 控件对象
        /// </summary>
        UIChart PlcControl;
        /// <summary>
        /// SQL事务表
        /// </summary>
        volatile List<string> SQLoperation = new List<string>();
        /// <summary>
        /// PLC当前值表
        /// </summary>
        volatile List<Tuple<string, string>> PLCValue = new List<Tuple<string, string>>();
        /// <summary>
        /// 复归型按钮标志位
        /// </summary>
        //private volatile bool State = false;
        /// <summary>
        /// PLC安全操作模式
        /// </summary>
        volatile Safetypattern PLCsafetypattern = Safetypattern.Nooperation;
        #endregion
        public ControlPLCDoughnutChartBase(UIChart PLCcontrol)
        {
            if (!(PLCcontrol is PLCDataViewClassBase)) throw new Exception($"{PLCcontrol.GetType().Name} 不实现：PLCDataViewClassBase接口");
            if (!(PLCcontrol is ControlDoughnutChartClassBase)) throw new Exception($"{PLCcontrol.GetType().Name} 不实现：ControlDoughnutChartClassBase接口");
            this.pLCViewClassBase = PLCcontrol as PLCDataViewClassBase;
            this.pLCBarCharttClassBase = PLCcontrol as ControlDoughnutChartClassBase;
            //----------处理控件PLC--自动获取PLC类型对象----------
            PLCoopErr(pLCViewClassBase);
            this.PlcControl = PLCcontrol;
            //----------判断是否绑定了触发控件--------------------
            if (this.pLCViewClassBase.pLCDataViewselectRealize.BindingOpen)
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
                for (int i = 0; i < this.pLCViewClassBase.pLCDataViewselectRealize.ReadWritePLC.Length; i++)
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
                    PLCValue.Add(new Tuple<string, string>(this.pLCViewClassBase.pLCDataViewselectRealize.DataGridView_Name[i], PLCdata));
                }
            }
            //---处理SQL数据事务---
            if (this.pLCViewClassBase.pLCDataViewselectRealize.SQLOpen)
            {
                SetSQL(this.pLCViewClassBase.pLCDataViewselectRealize.SQLCharacter, this.pLCViewClassBase.pLCDataViewselectRealize.SQLsurface, SQLoperation.ToArray(), this.pLCViewClassBase.pLCDataViewselectRealize.SQLServer_SQLinte);
            }
            //--处理添加后的事务--修改当
            SetOption();

            //var series = option.Series[0];

            //for (int i = 0; i < this.PLCValue.Count; i++)
            //{
            //    series.Data[i] = (Convert.ToDouble(this.PLCValue[i]));
            //}

            //for (int i = 0; i < 3; i++)
            //    this.PlcControl.SetOption(option);
        }
        /// <summary>
        /// 设置表格的数据
        /// </summary>
        private void SetOption()
        {
            this.PlcControl.SuspendLayout();
            var option = new UIDoughnutOption();
            //设置Title
            option.Title = new UITitle();
            option.Title.Text = pLCBarCharttClassBase.TitleText;
            option.Title.SubText = pLCBarCharttClassBase.TitleSubText;
            option.Title.Left = UILeftAlignment.Center;

            //设置ToolTip
            option.ToolTip.Visible = true;

            //设置Legend
            option.Legend = new UILegend();
            option.Legend.Orient = UIOrient.Vertical;
            option.Legend.Top = UITopAlignment.Top;
            option.Legend.Left = UILeftAlignment.Left;
            foreach (var i in PLCValue)
                option.Legend.AddData(i.Item1);

            //设置Series
            var series = new UIDoughnutSeries();
            series.Name = "Star count";
            series.Center = new UICenter(50, 55);
            series.Radius.Inner = 40;
            series.Radius.Outer = 70;
            series.Label.Show = true;
            series.Label.Position = UIPieSeriesLabelPosition.Center;

            //增加数据
            foreach (var i in PLCValue)
                series.AddData(i.Item1,Convert.ToInt32(i.Item2));

            //增加Series
            option.Series.Add(series);

            //设置Option
            this.PlcControl.SetOption(option);
            this.PlcControl.Refresh();
            this.PlcControl.ResumeLayout();
        }
        /// <summary>
        /// 使用事务把数据
        /// 写入到SQLServer/SQLLite
        /// </summary>
        /// <param name="SQLlink">SQL链接字符串</param>
        /// <param name="SQLsurface">SQL表名</param>
        /// <param name="SQLstatement">SQL需要执行的语句</param>
        private void SetSQL(string SQLlink, string SQLsurface, string[] SQLstatement, bool SLQServer_SLQLite)
        {
            if (SLQServer_SLQLite)
            {
                //建立连接并打开
                using (SqlConnection myConn = new SqlConnection(SQLlink))
                {
                    myConn.Open();
                    SqlCommand myComm = new SqlCommand();
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
            }
            else
            {
                //建立连接并打开
                using (SQLiteConnection myConn = new SQLiteConnection(SQLlink))
                {
                    myConn.Open();
                    SQLiteCommand myComm = new SQLiteCommand();
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
}
