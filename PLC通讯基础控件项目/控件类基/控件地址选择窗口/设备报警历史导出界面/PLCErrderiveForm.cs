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
using PLC通讯基础控件项目.控件类基.控件地址选择窗口.设备报警历史导出界面.导出表格类;
using Sunny.UI;
using System.Threading;

namespace PLC通讯基础控件项目.控件类基.控件地址选择窗口.设备报警历史导出界面
{
    public partial class PLCErrderiveForm : Form
    {
        PLCEventAutoContent pLCEventAutoContent;
        PLCEvent_messageBase pLCEvent_MessageBase;
        volatile List<Event_message> Event_Messages = new List<Event_message>();
        public PLCErrderiveForm(PLCEvent_messageBase pLCEvent_MessageBase)
        {
            InitializeComponent();
            this.pLCEvent_MessageBase = pLCEvent_MessageBase;
            this.pLCEventAutoContent = new PLCEventAutoContent(@pLCEvent_MessageBase.SaveAddress);
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            this.timer1.Stop();
            await TextRead();//读取数据
            //开始导出数据
            PLCErrExportData exportData = new PLCErrExportData();
            exportData.ExportDataRun += ((Send, e1) =>
            {
                this.BeginInvoke((MethodInvoker)delegate
                {
                    this.uiProcessBar1.Value = (Event_Messages.Count / 100);
                    this.uiLabel5.Text = exportData.Content;
                    this.uiLabel6.Text = exportData.Count.ToString();
                    this.uiLabel7.Text = exportData.Address;
                });
                //延时一点
                Thread.Sleep(10);
            });
            var ok = await exportData.ExporData(Event_Messages);
            //是否导出完成
            if (ok)
            {
                MessageBox.Show("导出完毕", "消息", MessageBoxButtons.YesNo);
                this.Close();
            }
            else
            {
                MessageBox.Show("导出失败", "消息", MessageBoxButtons.YesNo);
                this.Close();
            }
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
                Days[i] = @pLCEvent_MessageBase.SaveAddress + "\\PLCEventErr\\" + DateTime.Now.AddDays(Convert.ToInt16($"-{i}")).ToString("D") + ".txt"; //当前时间减去30天
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
    }
}
