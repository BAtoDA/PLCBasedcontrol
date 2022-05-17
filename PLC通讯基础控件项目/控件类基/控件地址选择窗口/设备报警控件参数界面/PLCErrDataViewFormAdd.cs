using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PLC通讯基础控件项目.控件类基.报警表_TO_Json;
using PLC通讯基础控件项目.控件类基.控件数据结构;
using Sunny.UI;

namespace PLC通讯基础控件项目.控件类基.控件地址选择窗口.设备报警控件参数界面
{
    public partial class PLCErrDataViewFormAdd : UIForm
    {
        /// <summary>
        /// PLC参数事件
        /// </summary>
        Event_message event_Message;
        /// <summary>
        /// 标识是否保存数据
        /// </summary>
        public bool Save=false;
        public PLCErrDataViewFormAdd(Event_message  event_Message)
        {
            InitializeComponent();
            this.event_Message = event_Message;
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            //处理通用方法
            PLCpublic pLCpublic = new PLCpublic();
            //填充PLC设备选项
            pLCpublic.GetPLCEnumName<PLC>(this.uiComboBox10);
            this.uiTextBox12.Text = "0";
            //处理PLC类型事件
            this.uiCheckBox1.CheckedChanged += ((send,e1) =>
              {
                  if(uiCheckBox1.Checked)
                  {
                      //用户选中了位Bit类型
                      uiCheckBox2.Checked = false;
                      this.uiComboBox11.Items.Clear();
                      pLCpublic.GetPLCBitName(this.uiComboBox11, this.uiComboBox10.Text);
                      this.uiTextBox1.Visible = false;
                      this.uiLabel4.Visible = true;
                      this.uiComboboxEx1.Visible = true;
                      this.uiComboboxEx2.Visible = false;
                      this.uiLabel1.Visible = false;
                      pLCpublic.GetPLCErrBase(true, this.uiComboboxEx1);
                  }
              });
            this.uiCheckBox2.CheckedChanged += ((send, e1) =>
            {
                if (uiCheckBox2.Checked)
                {
                    //用户选中了字Word类型
                    uiCheckBox1.Checked = false;
                    this.uiComboBox11.Items.Clear();
                    pLCpublic.GetPLCDName(this.uiComboBox11, this.uiComboBox10.Text);
                    this.uiTextBox1.Visible = true;
                    this.uiLabel4.Visible = false;
                    this.uiComboboxEx1.Visible = false;
                    this.uiComboboxEx2.Visible = true;
                    this.uiLabel1.Visible = true;
                    this.uiTextBox1.Text = "0";
                    pLCpublic.GetPLCErrBase(false, this.uiComboboxEx2);
                }
            });
            this.uiComboBox10.SelectedIndexChanged += ((Send, e1) =>
              {
                  this.uiComboBox11.Items.Clear();
                  if (uiCheckBox1.Checked)
                      pLCpublic.GetPLCBitName(this.uiComboBox11, this.uiComboBox10.Text);
                  else
                      pLCpublic.GetPLCDName(this.uiComboBox11, this.uiComboBox10.Text);
              });
            this.uiCheckBox1.Checked = true;
            //填充默认数据
            this.uiCheckBox1.Checked = event_Message.类型 == 0 ? true : false;
            this.uiCheckBox2.Checked = event_Message.类型 == 1 ? true : false;

            this.uiComboBox10.Text = event_Message.设备.Trim();
            this.uiComboBox11.Text = event_Message.设备_地址.Trim();
            this.uiTextBox12.Text = event_Message.设备_具体地址.Trim();

            this.uiComboboxEx1.SelectedItem = event_Message.位触发条件 ? 1 : 0;
            this.uiComboboxEx1.Text= event_Message.位触发条件 ? "ON" : "OFF";

            this.uiComboboxEx2.Text = event_Message.字触发条件.Trim();
            this.uiTextBox1.Text = event_Message.字触发条件_具体.Trim();

            this.uiRichTextBox1.Text = event_Message.报警内容 == null || event_Message.报警内容 == "" ? "请输入报警内容。。。" : event_Message.报警内容;

        }
        /// <summary>
        /// 用户点击保存参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton1_Click(object sender, EventArgs e)
        {
            //填充选择后参数数据
            event_Message.类型 = this.uiCheckBox1.Checked & !this.uiCheckBox2.Checked? 0 : 1;

            event_Message.设备 = this.uiComboBox10.Text;
            event_Message.设备_地址 = this.uiComboBox11.Text;
            event_Message.设备_具体地址 = this.uiTextBox12.Text;

            event_Message.位触发条件= this.uiComboboxEx1.SelectedIndex>0?false:true;
            event_Message.字触发条件 = this.uiComboboxEx2.Text;
            event_Message.字触发条件_具体 = this.uiTextBox1.Text;

            event_Message.报警内容=this.uiRichTextBox1.Text== null || this.uiRichTextBox1.Text == "" ? "请输入报警内容。。。" : this.uiRichTextBox1.Text;
            Save = true;
            this.Close();
        }
        /// <summary>
        /// 用户点击取消保存参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
