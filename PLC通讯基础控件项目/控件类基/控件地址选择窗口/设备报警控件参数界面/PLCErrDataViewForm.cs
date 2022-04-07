using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Nancy.Json;
using PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLC报警显示控件实现类;
using PLC通讯基础控件项目.控件类基.PLC基础接口.报警表_TO_Json;
using Sunny.UI;
using System.Linq;
using PLC通讯基础控件项目.控件类基.控件数据结构;
using PLC通讯基础控件项目.控件类基.控件地址选择窗口.设备报警历史导出界面.导出表格类;

namespace PLC通讯基础控件项目.控件类基.控件地址选择窗口.设备报警控件参数界面
{
    public partial class PLCErrDataViewForm : UIForm
    {
        #region 接口参数
        PLCEvent_messageBase pLCEvent_MessageBase;
        PLCEventContent pLCEventContent;
        #endregion
        public PLCErrDataViewForm(PLCEvent_messageBase pLCEvent_MessageBase)
        {
            InitializeComponent();
            this.pLCEvent_MessageBase = pLCEvent_MessageBase;          
            pLCEventContent = new PLCEventContent(pLCEvent_MessageBase.EventAddress);
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            DataGridViewLoad();
        }

        private async void uiDataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)//判断用户是否选中行
                {
                    if (this.uiDataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString().Trim() == "")//用户是否选中了空行
                    {
                        MessageBox.Show("你选中了空行", "Err");//提示异常
                        return; //返回方法
                    }
                    else
                    {
                        var Index = EventLink.PLCEventLink.Where(p => p.ID == Convert.ToInt32(this.uiDataGridView1.Rows[e.RowIndex].Cells[0].Value)).FirstOrDefault();
                        PLCErrDataViewFormAdd PLCErr = new PLCErrDataViewFormAdd(Index);
                        PLCErr.ShowDialog();
                        //修改参数完成 进行参数序列化保存
                        if (PLCErr.Save)
                            await pLCEventContent.TextWrite(new JavaScriptSerializer().Serialize(EventLink.PLCEventLink));
                        DataGridViewLoad();

                    }
                }
                else
                {
                    MessageBox.Show("你选中了空行", "Err");//提示异常
                }
            }
            catch { }
        }
        /// <summary>
        /// 用户点击了添加报警
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var PLCErrData = new Event_message()
            {

                ID = EventLink.PLCEventLink.Count > 0 ? EventLink.PLCEventLink.Max(pi => pi.ID)+1 : 1,
                位触发条件 = true,
                字触发条件 = ">",
                字触发条件_具体 = "0",
                报警内容 = "请输入报警内容...",
                类型 = 0,
                设备 = PLC.Mitsubishi.ToString(),
                设备_地址 = Mitsubishi_bit.M.ToString(),
                设备_具体地址 = "0"
            };
            PLCErrDataViewFormAdd PLCErr = new PLCErrDataViewFormAdd(PLCErrData);
            PLCErr.ShowDialog();
            if (PLCErr.Save)
            {
                //把数据添加到表中
                EventLink.PLCEventLink.Add(PLCErrData);
                //修改参数完成 进行参数序列化保存
                await pLCEventContent.TextWrite(new JavaScriptSerializer().Serialize(EventLink.PLCEventLink));
                DataGridViewLoad();
            }
        }
        /// <summary>
        /// 用户点击了修改报警
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.uiDataGridView1.SelectedIndex > -1)//判断用户是否选中行
                {
                    if (this.uiDataGridView1.Rows[this.uiDataGridView1.SelectedIndex].Cells[0].Value.ToString().Trim() == "")//用户是否选中了空行
                    {
                        MessageBox.Show("你选中了空行", "Err");//提示异常
                        return; //返回方法
                    }
                    else
                    {
                        var Index = EventLink.PLCEventLink.Where(p => p.ID == Convert.ToInt32(this.uiDataGridView1.Rows[this.uiDataGridView1.SelectedIndex].Cells[0].Value)).FirstOrDefault();
                        PLCErrDataViewFormAdd PLCErr = new PLCErrDataViewFormAdd(Index);
                        PLCErr.ShowDialog();
                        //修改参数完成 进行参数序列化保存
                        if (PLCErr.Save)
                            await pLCEventContent.TextWrite(new JavaScriptSerializer().Serialize(EventLink.PLCEventLink));
                        DataGridViewLoad();

                    }
                }
                else
                {
                    MessageBox.Show("你选中了空行", "Err");//提示异常
                }
            }
            catch { }
        }
        /// <summary>
        /// 用户点击了删除报警
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.uiDataGridView1.SelectedIndex > -1)//判断用户是否选中行
                {
                    if (this.uiDataGridView1.Rows[this.uiDataGridView1.SelectedIndex].Cells[0].Value.ToString().Trim() == "")//用户是否选中了空行
                    {
                        MessageBox.Show("你选中了空行", "Err");//提示异常
                        return; //返回方法
                    }
                    else
                    {
                        var Index = EventLink.PLCEventLink.Where(p => p.ID == Convert.ToInt32(this.uiDataGridView1.Rows[this.uiDataGridView1.SelectedIndex].Cells[0].Value)).FirstOrDefault();
                        EventLink.PLCEventLink.Remove(Index);
                        await pLCEventContent.TextWrite(new JavaScriptSerializer().Serialize(EventLink.PLCEventLink));
                        DataGridViewLoad();
                    }
                }
                else
                {
                    MessageBox.Show("你选中了空行", "Err");//提示异常
                }
            }
            catch { }
        }
        /// <summary>
        /// 刷新表显示
        /// </summary>
        private async void DataGridViewLoad()
        {
            //加载参数
            if (pLCEventContent.IsText())
            {
                var Content = await pLCEventContent.TextRead();
                //反序列化
                var ContentOop = new JavaScriptSerializer().Deserialize<List<Event_message>>(Content);
                if (ContentOop != null)
                {
                    this.uiDataGridView1.DataSource = ContentOop;
                    EventLink.PLCEventLink = ContentOop;
                }
            }
            else
            {
                pLCEventContent.TextCreate();
                await pLCEventContent.TextWrite(new JavaScriptSerializer().Serialize(EventLink.PLCEventLink));
            }
        }
        /// <summary>
        /// 用户点击从威纶通导出的表格导入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            var EvenList = await new PLCErrExportData().ExportImportData();
            //获得导入的参数
            if (EvenList.Count > 0)
            {
                EventLink.PLCEventLink = EvenList;
                //保存到本地
                await pLCEventContent.TextWrite(new JavaScriptSerializer().Serialize(EventLink.PLCEventLink));
                //重新加载表格控件
                DataGridViewLoad();
            }
        }
    }
}
