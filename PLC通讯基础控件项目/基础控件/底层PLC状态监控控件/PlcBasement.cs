using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using PLC通讯库.PLC通讯设备类型表;
using Sunny.UI;
using PLC通讯库.通讯实现类;
using PLC通讯库.通讯基础接口;

namespace PLC通讯基础控件项目.基础控件.底层PLC状态监控控件
{
    public partial class PlcBasement : UserControl
    {
        public PlcBasement()
        {
            InitializeComponent();
        }

        private void PlcBasement_Load(object sender, EventArgs e)
        {
            this.uiComboboxEx1.Items.Clear();
            foreach (var i in IPLCsurface.PLCDictionary)
                this.uiComboboxEx1.Items.Add(i.Key);
            this.uiLedBulb1.On = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var PLCoop = IPLCsurface.PLCDictionary.Where(P => P.Key == this.uiComboboxEx1.Text).FirstOrDefault();
            if (PLCoop.Value != null)
            {
                this.uiTextBox1.Text = ((IPLCcommunicationBase)PLCoop.Value).IPEndPoint.Address.ToString();
                this.uiTextBox2.Text = ((IPLCcommunicationBase)PLCoop.Value).IPEndPoint.Port.ToString();
                this.uiLedBulb1.On = ((IPLC_interface)PLCoop.Value).PLC_ready;
                this.uiTextBox4.Text = ((IPLC_interface)PLCoop.Value).ReadContn.ToString();
                this.uiTextBox3.Text = ((IPLC_interface)PLCoop.Value).WriteContn.ToString();
            }
        }

        private void uiComboboxEx1_TextChanged(object sender, EventArgs e)
        {
            //用户变更PLC对象选择
            string Name = ((UIComboboxEx)sender).Text;
            var PLCoop= IPLCsurface.PLCDictionary.Where(P => P.Key == Name).FirstOrDefault();
            if(PLCoop.Value!=null)
            {
                this.uiTextBox1.Text = ((IPLCcommunicationBase)PLCoop.Value).IPEndPoint.Address.ToString();
                this.uiTextBox2.Text= ((IPLCcommunicationBase)PLCoop.Value).IPEndPoint.Port.ToString();
                this.uiLedBulb1.On = ((IPLC_interface)PLCoop.Value).PLC_ready;
                this.uiTextBox4.Text = ((IPLC_interface)PLCoop.Value).ReadContn.ToString();
                this.uiTextBox3.Text = ((IPLC_interface)PLCoop.Value).WriteContn.ToString();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.timer2.Stop();
            this.uiComboboxEx1.Items.Clear();
            foreach (var i in IPLCsurface.PLCDictionary)
                this.uiComboboxEx1.Items.Add(i.Key);
            if (this.uiComboboxEx1.Items.Count > 0)
                this.uiComboboxEx1.SelectedIndex = 0;
            ControlDebug.EventMessage += ((send, e) =>
            {
                try
                {
                    this.uiRichTextBox1.BeginInvoke((MethodInvoker)delegate
                    {
                        this.uiRichTextBox1.AppendText($"{DateTime.Now} : {send}  \r\n");
                    });
                }
                catch { }
            });
        }

        private void uiLabel5_Click(object sender, EventArgs e)
        {

        }
    }
}
