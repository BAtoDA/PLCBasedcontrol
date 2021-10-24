using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PLC通讯基础控件项目.控件类基.PLC基础接口;
using PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLC二维码控件实现类;
using PLC通讯基础控件项目.控件类基.控件数据结构;
using PLC通讯库.通讯枚举;
using Sunny.UI;

namespace PLC通讯基础控件项目.控件类基.控件地址选择窗口.二维码控件参数界面
{
    public partial class PLCQRcodeForm : UIForm
    {
        PLCQRcodeBaseRealize pLCQRcodeBase;
        Control control;
        public PLCQRcodeForm(PLCQRcodeBaseRealize pLCQRcodeBase, Control control)
        {
            InitializeComponent();
            this.pLCQRcodeBase = pLCQRcodeBase;
            this.control = control;
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            //加载事件
            PLCload(this.uiComboBox10, this.uiComboBox11, this.uiTextBox12, this.uiComboBox13, this.uiComboBox14, this.uiTextBox15);
            this.uiComboBox1.Items.Clear();
            Enum.GetNames(typeof(numerical_format)).ForEach(s1 => { this.uiComboBox1.Items.Add(s1); });
            this.uiComboBox1.SelectedIndex = 0;
            //加载控件绑定
            PLCpublic pLCpublic = new PLCpublic();
            //控件触发部分
            this.uiCheckBox2.Checked = pLCQRcodeBase.pLCQRcodeRealize.BindingOpen;
            //反射获取窗口名称
            uiTextBox1.Text = pLCpublic.GetContrForm(control).Name;
            //反射获取窗口控件
            this.uiComboBox2.Items.Clear();
            this.uiComboBox2.KeyPress += ((send, e1) =>
            {
                e1.Handled = true;
            });
            foreach (Control i in pLCpublic.GetContrForm(control).Controls)
                this.uiComboBox2.Items.Add(i.Name);
            if (this.uiComboBox2.Items.Count > 0)
                this.uiComboBox2.SelectedIndex = 0;
            //填充原来的数据
            if (pLCQRcodeBase.pLCQRcodeRealize.BindingName != null)
                this.uiComboBox2.Text = pLCQRcodeBase.pLCQRcodeRealize.BindingName;
            uiCheckBox1.Checked = pLCQRcodeBase.pLCQRcodeRealize.Select;
            uiComboBox1.Text = pLCQRcodeBase.pLCQRcodeRealize.ShowFormat.ToString();
            uiComboBox10.Text = pLCQRcodeBase.pLCQRcodeRealize.ReadWritePLC.ToString();
            uiComboBox11.Text = pLCQRcodeBase.pLCQRcodeRealize.ReadWriteFunction??"D";
            uiTextBox12.Text = pLCQRcodeBase.pLCQRcodeRealize.ReadWriteAddress ?? "0";

            uiComboBox13.Text = pLCQRcodeBase.pLCQRcodeRealize.WritePLC.ToString();
            uiComboBox14.Text = pLCQRcodeBase.pLCQRcodeRealize.WriteFunction ?? "M";
            uiTextBox15.Text = pLCQRcodeBase.pLCQRcodeRealize.WriteAddress ?? "0";

            this.uiComboBox1.KeyPress += ((send, e1) =>
            {
                e1.Handled = true;
            });
            this.uiComboBox10.KeyPress += ((send, e1) =>
            {
                e1.Handled = true;
            });
            this.uiComboBox11.KeyPress += ((send, e1) =>
            {
                e1.Handled = true;
            });
            this.uiComboBox13.KeyPress += ((send, e1) =>
            {
                e1.Handled = true;
            });
            this.uiComboBox14.KeyPress += ((send, e1) =>
            {
                e1.Handled = true;
            });
        }
        /// <summary>
        /// 加载PLC设备枚举
        /// </summary>
        /// <param name="readwriteplc"></param>
        /// <param name="readwritePLCfunction"></param>
        /// <param name="readwriteaddress"></param>
        /// <param name="writeplc"></param>
        /// <param name="writePLCfunction"></param>
        /// <param name="writeaddress"></param>
        private void PLCload(UIComboBox readwriteplc, UIComboBox readwritePLCfunction,UITextBox readwriteaddress, UIComboBox writeplc, UIComboBox writePLCfunction,UITextBox writeaddress)
        {
            PLCpublic pLCpublic = new PLCpublic();
            readwriteplc.Items.Clear();
            foreach (var i in Enum.GetNames(typeof(PLC)))
                readwriteplc.Items.Add(i);
            readwriteplc.TextChanged += ((send, e) =>
              {
                  readwritePLCfunction.Items.Clear();
                  pLCpublic.GetPLCDName(readwritePLCfunction, readwriteplc.Text);
              });
            readwriteplc.SelectedIndex = 0;
            readwriteaddress.Text = "0";

            writeplc.Items.Clear();
            foreach (var i in Enum.GetNames(typeof(PLC)))
                writeplc.Items.Add(i);
            writeplc.TextChanged += ((send, e1) =>
            {
                writePLCfunction.Items.Clear();
                pLCpublic.GetPLCBitName(writePLCfunction,writeplc.Text);
            });
            writeplc.SelectedIndex = 0;
            writeaddress.Text = "0";
        }
        /// <summary>
        /// 用户点击保存参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton1_Click(object sender, EventArgs e)
        {
            pLCQRcodeBase.pLCQRcodeRealize.BindingOpen = this.uiCheckBox2.Checked;
            pLCQRcodeBase.pLCQRcodeRealize.BindingName = this.uiComboBox2.Text;
            pLCQRcodeBase.pLCQRcodeRealize.Select = uiCheckBox1.Checked;
            pLCQRcodeBase.pLCQRcodeRealize.ShowFormat = (numerical_format)Enum.Parse(typeof(numerical_format), uiComboBox1.Text);
            pLCQRcodeBase.pLCQRcodeRealize.ReadWritePLC = (PLC)Enum.Parse(typeof(PLC), uiComboBox10.Text);
            pLCQRcodeBase.pLCQRcodeRealize.ReadWriteFunction = uiComboBox11.Text;
            pLCQRcodeBase.pLCQRcodeRealize.ReadWriteAddress = uiTextBox12.Text ?? "0";

            pLCQRcodeBase.pLCQRcodeRealize.WritePLC = (PLC)Enum.Parse(typeof(PLC), uiComboBox13.Text);
            pLCQRcodeBase.pLCQRcodeRealize.WriteFunction = uiComboBox14.Text ?? "M";
            pLCQRcodeBase.pLCQRcodeRealize.WriteAddress = uiTextBox15.Text ?? "0";
            this.Close();
        }
        /// <summary>
        /// 用户点击取消保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
