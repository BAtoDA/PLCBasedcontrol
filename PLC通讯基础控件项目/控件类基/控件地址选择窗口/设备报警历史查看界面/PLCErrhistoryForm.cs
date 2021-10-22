using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nancy.Json;
using PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLC报警显示控件实现类;
using PLC通讯基础控件项目.控件类基.PLC基础接口.报警表_TO_Json;
using Sunny.UI;
using System.Linq;

namespace PLC通讯基础控件项目.控件类基.控件地址选择窗口.设备报警历史查看界面
{
    public partial class PLCErrhistoryForm : UIForm
    {
        PLCEventAutoContent pLCEventAutoContent;
        PLCEvent_messageBase pLCEvent_MessageBase;
        volatile List<Event_message> Event_Messages = new List<Event_message>();
        public PLCErrhistoryForm(PLCEvent_messageBase pLCEvent_MessageBase)
        {
            InitializeComponent();
            this.pLCEvent_MessageBase = pLCEvent_MessageBase;
            pLCEventAutoContent = new PLCEventAutoContent(@pLCEvent_MessageBase.SaveAddress);
        }
        /// <summary>
        /// 异步读取用户设定内容
        /// </summary>
        private async Task TextRead()
        {
            if (!pLCEventAutoContent.IsText()) return;
            //-----获取后30天最新的报警表---------
            //清空表
            Event_Messages.Clear();
            //获取后30天的日期
            string[] Days = new string[30];
            for (int i = 0; i < Days.Length; i++)
            {
                Days[i] = @pLCEvent_MessageBase.SaveAddress+ "\\PLCEventErr\\" + DateTime.Now.AddDays(Convert.ToInt16($"-{i}")).ToString("D") + ".txt"; //当前时间减去7天
                //读取PLC设置报警内容表
                var Content = await pLCEventAutoContent.TextRead(Days[i]);
                //反序列化
                foreach (var ix in Content)
                {
                    var ContentOop = new JavaScriptSerializer().Deserialize<Event_message>(ix);
                    if (ContentOop != null)
                    {
                        Event_Messages.Add(ContentOop);
                    }
                }
            }
        }
        protected async override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //显示UI过度
            UIWaitFormService.ShowWaitForm("开始加载UI...");
            //读取自动保存历史
            await TextRead();
            await Task.Run(() =>
            {
                //从数据获取数据
                var data = Event_Messages;
                var query = (from q in Event_Messages where DateTime.Parse(q.报警发生时间.ToString("D")).ToString("D") == DateTime.Now.ToString("D") select q).ToList();
                //填充7天警告次数
                var query1 = (from q in data where (DateTime.Parse(DateTime.Now.ToString("F")) - DateTime.Parse(q.报警发生时间.ToString("f"))).Days >= 0 && (DateTime.Parse(DateTime.Now.ToString("F")) - DateTime.Parse(q.报警发生时间.ToString("f"))).Days <= 7 select q).ToList();
                //查询月度警告次数
                var Monthly = (from q in data where (DateTime.Parse(DateTime.Now.ToString("Y")) == DateTime.Parse(DateTime.Parse(q.报警发生时间.ToString("f")).ToString("Y"))) select q).ToList();
                //填充报警历史
                this.BeginInvoke((EventHandler)delegate
                {
                    //填充月底报警次数
                    this.uiLabel5.Text = Monthly.Count.ToString();
                    //填充当天报警次数
                    this.uiLabel2.Text = query.Count.ToString();
                    //填充7天警告次数
                    this.uiLabel3.Text = query1.Count.ToString();
                    this.uiDataGridView1.DataSource = data;
                    //填充报警历史的查询项
                    this.uiComboboxEx1.Items.Clear();
                    this.uiComboboxEx2.Items.Clear();
                    this.uiComboboxEx3.Items.Clear();
                    data.ForEach(s =>
                    {
                        this.uiComboboxEx1.Items.Add(s.报警发生时间.ToString("f").Trim());
                        this.uiComboboxEx2.Items.Add(s.报警处理时间.ToString("f").Trim());
                        this.uiComboboxEx3.Items.Add(s.设备.Trim());
                    });
                    this.uiComboboxEx1.Items.Add("全部");
                    this.uiComboboxEx2.Items.Add("全部");
                    this.uiComboboxEx3.Items.Add("全部");
                    this.uiComboboxEx1.Text = "全部";
                    this.uiComboboxEx2.Text = "全部";
                    this.uiComboboxEx3.Text = "全部";
                    //填充报警注册内容
                    this.uiDataGridView2.DataSource = data;
                });
                //生成分析7天警告报表
                //把7天结果LINQ分组
                var grouping = query1.GroupBy(pi => DateTime.Parse(pi.报警发生时间.ToString("f").Trim()).Date).Select(group => new StoreInfo
                {
                    StoreID = group.Key,
                    List = group.ToList()
                }).ToList();
                //获取后7天的日期
                string[] Days = new string[7];
                for (int i = 0; i < Days.Length; i++)
                    Days[i] = DateTime.Now.AddDays(Convert.ToInt16($"-{i}")).ToString(); //当前时间减去7天
                //计算每天处理异常的总时间
                List<Tuple<int, string>> Histogramdata = new List<Tuple<int, string>>();
                DateTime dateTime = DateTime.Parse(DateTime.Now.ToString("yyyy - MM - dd"));
                int quantity = 0;
                foreach (var i in Days)
                {
                    dateTime = DateTime.Parse(DateTime.Now.ToString("yyyy - MM - dd"));
                    quantity = 0;
                    var group = grouping.Where(pi => pi.StoreID.ToString("D") == DateTime.Parse(i.Trim()).ToString("D")).Select(pi => pi).FirstOrDefault();
                    if (group != null)
                    {
                        var grouptime = group.List.Where(pi => pi.报警发生时间.ToString("D") == DateTime.Parse(i.Trim()).ToString("D")).Select(P => new { DatetimeName = P.报警处理时间 - P.报警发生时间}).ToList();
                        //求和时间
                        grouptime.ForEach(s =>
                        {
                            dateTime += s.DatetimeName;
                        });
                        quantity = grouptime.Count;
                    }
                    Histogramdata.Add(new Tuple<int, string>(quantity, dateTime.ToString("T")));
                }
                //填充7天警告分析图形
                this.BeginInvoke((EventHandler)delegate
                {
                    Histogram(Days, Histogramdata);
                    //填充警告处理用时
                    this.uiLabel16.Text = Histogramdata[0].Item2;//当天用时
                });

                //处理7天用时
                TimeSpan dateTim = MonthlyErr(query1, query1.Count);
                //填充月度处理用时
                dateTim = new TimeSpan();
                MonthlyErr(Monthly).ForEach(s =>
                {
                    dateTim += TimeSpan.Parse(s.Item2.Trim());
                });
                this.BeginInvoke((EventHandler)delegate
                {
                    this.uiLabel12.Text = $"{(24 * dateTim.Days) + dateTim.Hours}:{dateTim.Minutes}:{dateTim.Seconds}";
                    this.uiLabel14.Text = $"{(24 * dateTim.Days) + dateTim.Hours}:{dateTim.Minutes}:{dateTim.Seconds}";
                });

                //填充设备警告分析
                //查找重复最多的数据--意味着报警最多的
                EquipmentErr(Monthly);

            });
            //启用定时刷新
            timer1.Enabled = true;
            timer1.Start();
            //关闭显示UI窗口
            UIWaitFormService.HideWaitForm();
        }
        /// <summary>
        /// 定时刷新--加载数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void HistoryErrTiming()
        {
            //读取自动保存历史
            await TextRead();
            var data = Event_Messages;
            var query = (from q in data where DateTime.Parse(q.报警发生时间.ToString("f").Trim()).ToString("D") == DateTime.Now.ToString("D") select q).ToList();
            //填充7天警告次数
            var query1 = (from q in data where (DateTime.Parse(DateTime.Now.ToString("F")) - DateTime.Parse(q.报警发生时间.ToString("f").Trim())).Days >= 0 && (DateTime.Parse(DateTime.Now.ToString("F")) - DateTime.Parse(q.报警发生时间.ToString("f").Trim())).Days <= 7 select q).ToList();
            //查询月度警告次数
            var Monthly = (from q in data where (DateTime.Parse(DateTime.Now.ToString("Y")) == DateTime.Parse(DateTime.Parse(q.报警发生时间.ToString("f").Trim()).ToString("Y"))) select q).ToList();
            this.BeginInvoke((EventHandler)delegate
            {
                //填充当天报警次数
                this.uiLabel2.Text = query.Count.ToString();
                this.uiLabel3.Text = query1.Count.ToString();
                //填充月底报警次数
                this.uiLabel5.Text = Monthly.Count.ToString();
            });
            //生成分析7天警告报表
            //把7天结果LINQ分组
            var grouping = query1.GroupBy(pi => DateTime.Parse(pi.报警发生时间.ToString("f").Trim()).Date).Select(group => new StoreInfo
            {
                StoreID = group.Key,
                List = group.ToList()
            }).ToList();
            //获取后7天的日期
            string[] Days = new string[7];
            for (int i = 0; i < Days.Length; i++)
                Days[i] = DateTime.Now.AddDays(Convert.ToInt16($"-{i}")).ToString(); //当前时间减去7天
            //计算每天处理异常的总时间
            List<Tuple<int, string>> Histogramdata = new List<Tuple<int, string>>();
            DateTime dateTime = DateTime.Parse(DateTime.Now.ToString("yyyy - MM - dd"));
            int quantity = 0;
            foreach (var i in Days)
            {
                dateTime = DateTime.Parse(DateTime.Now.ToString("yyyy - MM - dd"));
                quantity = 0;
                var group = grouping.Where(pi => pi.StoreID.ToString("D") == DateTime.Parse(i.Trim()).ToString("D")).Select(pi => pi).FirstOrDefault();
                if (group != null)
                {
                    var grouptime = group.List.Where(pi => pi.报警发生时间.ToString("D") == DateTime.Parse(i.Trim()).ToString("D")).Select(P => new { DatetimeName = P.报警处理时间 - P.报警发生时间 }).ToList();
                    //求和时间
                    grouptime.ForEach(s =>
                    {
                        dateTime += s.DatetimeName;
                    });
                    quantity = grouptime.Count;
                }
                Histogramdata.Add(new Tuple<int, string>(quantity, dateTime.ToString("T")));
            }
            //填充7天警告分析图形
            this.BeginInvoke((EventHandler)delegate
            {
                Histogram(Days, Histogramdata);
            });
            //处理7天用时
            TimeSpan dateTim = MonthlyErr(query1, query1.Count);
            //填充月度处理用时
            dateTim = new TimeSpan();
            MonthlyErr(Monthly).ForEach(s =>
            {
                dateTim += TimeSpan.Parse(s.Item2.Trim());
            });
            this.BeginInvoke((EventHandler)delegate
            {
                //填充警告处理用时
                this.uiLabel16.Text = Histogramdata[0].Item2;//当天用时
                this.uiLabel14.Text = $"{(24 * dateTim.Days) + dateTim.Hours}:{dateTim.Minutes}:{dateTim.Seconds}";
                this.uiLabel12.Text = $"{(24 * dateTim.Days) + dateTim.Hours}:{dateTim.Minutes}:{dateTim.Seconds}";
            });
            //填充设备警告分析
            //查找重复最多的数据--意味着报警最多的
            EquipmentErr(Monthly);
        }
        /// <summary>
        /// 计算30天的报警处理用时
        /// </summary>
        private List<Tuple<int, string>> MonthlyErr(List<Event_message> Querydata)
        {
            //把30天结果LINQ分组
            var grouping = Querydata.GroupBy(pi => DateTime.Parse(pi.报警发生时间.ToString("f").Trim()).Date).Select(group => new StoreInfo
            {
                StoreID = group.Key,
                List = group.ToList()
            }).ToList();
            //获取后30天的日期
            string[] Days = new string[30];
            for (int i = 0; i < Days.Length; i++)
                Days[i] = DateTime.Now.AddDays(Convert.ToInt16($"-{i}")).ToString(); //当前时间减去30天
            //计算每天处理异常的总时间
            List<Tuple<int, string>> Histogramdata = new List<Tuple<int, string>>();
            TimeSpan dateTime = new TimeSpan();
            int quantity = 0;
            foreach (var i in Days)
            {
                dateTime = new TimeSpan();
                quantity = 0;
                var group = grouping.Where(pi => pi.StoreID.ToString("D") == DateTime.Parse(i.Trim()).ToString("D")).Select(pi => pi).FirstOrDefault();
                if (group != null)
                {
                    var grouptime = group.List.Where(pi => pi.报警发生时间.ToString("D") == DateTime.Parse(i.Trim()).ToString("D")).Select(P => new { DatetimeName = P.报警处理时间 - P.报警发生时间}).ToList();
                    //求和时间
                    grouptime.ForEach(s =>
                    {
                        dateTime += s.DatetimeName;
                    });
                    quantity = grouptime.Count;
                }
                Histogramdata.Add(new Tuple<int, string>(quantity, dateTime.ToString("T")));
            }
            return Histogramdata;
        }
        /// <summary>
        /// 分析设备报警最多的数据
        /// </summary>
        private void EquipmentErr(List<Event_message> Querydata)
        {
            var res = (from n in Querydata
                       group n by n.报警内容 into g
                       orderby g.Count() descending
                       select g).Select(P => new StoreInfoErr { ErrID = P.Key, List = P }).ToList();
            var data = Querydata.GroupBy(p => p.报警内容).OrderBy(x => x.Key).Select(P => new StoreInfoErr { ErrID = P.Key, List = P }).ToList();//该语句同等于上面
            //划分查询结果重新生成表
            BindingList<ShowErr> showErrs = new BindingList<ShowErr>();
            if (data.Count < 10)
            {
                for (int i = 0; i < data.Count; i++)
                {
                    var ErrData = data[i].List.First();
                    var dateTim = MonthlyErr(data[i].List.Select(pi => pi).ToList(), data[i].List.Count());
                    var Errtime = $"{(24 * dateTim.Days) + dateTim.Hours}:{dateTim.Minutes}:{dateTim.Seconds}";
                    showErrs.Add(new ShowErr() { 报警内容 = ErrData.报警内容.Trim(), 设备 = ErrData.设备.Trim(), 地址 = ErrData.设备_地址.Trim() + ErrData.设备_具体地址.Trim(), 用时 = Errtime, 次数 = data[i].List.Count() });
                }
            }
            else
            {
                for (int i = 0; i < 10; i++)
                {
                    var ErrData = data[i].List.First();
                    var dateTim = MonthlyErr(data[i].List.Select(pi => pi).ToList(), data[i].List.Count());
                    var Errtime = $"{(24 * dateTim.Days) + dateTim.Hours}:{dateTim.Minutes}:{dateTim.Seconds}";
                    showErrs.Add(new ShowErr() { 报警内容 = ErrData.报警内容.Trim(), 设备 = ErrData.设备.Trim(), 地址 = ErrData.设备_地址.Trim() + ErrData.设备_具体地址.Trim(), 用时 = Errtime, 次数 = data[i].List.Count() });
                }
            }
            this.BeginInvoke((EventHandler)delegate
            {
                uiDataGridView3.DataSource = showErrs.OrderByDescending(x => x.次数).Select(pi => pi).ToList();
                uiDataGridView3.Columns[0].Width = 300;
                uiDataGridView3.Columns[2].Width = 80;
                uiDataGridView3.Columns[3].Width = 50;
                uiDataGridView3.Columns[4].Width = 70;
            });
        }
        /// <summary>
        /// 计算的报警处理用时
        /// </summary>
        private TimeSpan MonthlyErr(List<Event_message> Querydata, int index)
        {
            TimeSpan time = new TimeSpan();
            Querydata.ForEach(P =>
            {
                time += P.报警处理时间 - P.报警发生时间;
            });
            return time;
        }
        private void Histogram(string[] Days, List<Tuple<int, string>> Histogramdata)
        {
            UIBarOption option = new UIBarOption();
            option.Title = new UITitle();
            option.Title.Text = "7天警告分析";
            option.Title.SubText = "";

            //设置Legend
            option.Legend = new UILegend();
            option.Legend.Orient = UIOrient.Horizontal;
            option.Legend.Top = UITopAlignment.Top;
            option.Legend.Left = UILeftAlignment.Left;
            option.Legend.AddData("警告总时长");
            option.Legend.AddData("发生次数");

            var series = new UIBarSeries();
            series.Name = "Bar1";
            //填充当前报警次数
            foreach (var i in Histogramdata)
                series.AddData(i.Item1);
            option.Series.Add(series);

            series = new UIBarSeries();
            series.Name = "Bar2";
            //填充当前报警时长
            foreach (var i in Histogramdata)
                series.AddData(DateTime.Parse(i.Item2).Hour == 0 ? DateTime.Parse(i.Item2).Minute : DateTime.Parse(i.Item2).Hour);

            option.Series.Add(series);
            //填充7天日期
            foreach (var i in Days)
                option.XAxis.Data.Add(DateTime.Parse(i).ToString("M"));

            option.ToolTip.Visible = true;
            option.YAxis.Scale = true;

            option.XAxis.Name = "发生日期";
            option.YAxis.Name = "时间/次数";

            this.uiBarChart1.SetOption(option);
        }
        /// <summary>
        /// 定时刷新 定时器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void timer1_Tick(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                try
                {
                    HistoryErrTiming();
                }
                catch (Exception ex)
                {
                }
            });

        }
        /// <summary>
        /// 用于保存历史报警源数据
        /// </summary>
        List<Event_message> alarmhistories = new List<Event_message>();
        /// <summary>
        /// 用户点击了刷新数据源
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton1_Click(object sender, EventArgs e)
        {
            alarmhistories = Event_Messages.Where(pi => true).OrderBy(p => p.报警发生时间.ToString("f").Trim()).ToList();
            this.uiDataGridView1.DataSource = alarmhistories;
        }
        /// <summary>
        /// 查询报警历史
        /// </summary>
        public void QueryErr(object sender, EventArgs e)
        {
            if (this.uiDataGridView1.DataSource != null && alarmhistories != null)
                this.uiDataGridView1.DataSource = alarmhistories.Where(pi => pi.报警发生时间.ToString("f") == (uiComboboxEx1.Text == "全部" ? pi.报警发生时间.ToString("f") : uiComboboxEx1.Text) && pi.报警处理时间.ToString("f") == (uiComboboxEx2.Text == "全部" ? pi.报警处理时间.ToString("f") : uiComboboxEx2.Text) && pi.设备 == (this.uiComboboxEx3.Text == "全部" ? pi.设备 : this.uiComboboxEx3.Text)).OrderBy(x => x.报警发生时间.ToString("f").Trim()).ToList();
        }
    }
    public class StoreInfo
    {
        public DateTime StoreID { get; set; }
        public List<Event_message> List { get; set; }

    }
    public class StoreInfoErr
    {
        public string ErrID { get; set; }
        public IGrouping<string, Event_message> List { get; set; }
    }
    [Serializable]
    public class ShowErr
    {
        public string 报警内容 { get; set; }
        public string 设备 { get; set; }
        public string 地址 { get; set; }
        public int 次数 { get; set; }
        public string 用时 { get; set; }
    }
}
