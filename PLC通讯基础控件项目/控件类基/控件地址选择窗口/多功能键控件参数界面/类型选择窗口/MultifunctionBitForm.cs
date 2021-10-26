using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLC多功能控件实现类;
using PLC通讯基础控件项目.控件类基.控件数据结构;
using Sunny.UI;
using System.Linq;

namespace PLC通讯基础控件项目.控件类基.控件地址选择窗口.多功能键控件参数界面.类型选择窗口
{
    public partial class MultifunctionBitForm : UIForm
    {
        PLCMultifunctionBitBase pLCMultifunctionBitBase;
        public bool Save = false;
        public MultifunctionBitForm(PLCMultifunctionBitBase pLCMultifunctionBitBase)
        {
            InitializeComponent();
            this.pLCMultifunctionBitBase = pLCMultifunctionBitBase;
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);


            uiComboBox10.Items.Clear();
            foreach (var i in Enum.GetNames(typeof(PLC)))
                uiComboBox10.Items.Add(i);
            uiComboBox10.TextChanged += ((send, e1) =>
            {
                uiComboBox11.Items.Clear();
                new PLCpublic().GetPLCBitName(uiComboBox11, uiComboBox10.Text);
            });
            uiComboBox10.SelectedIndex = 0;
            uiTextBox12.Text = "0";

            //填充保存的数据
            uiComboBox10.Text = pLCMultifunctionBitBase.ReadWritePLC.ToString();
            uiComboBox11.Text = pLCMultifunctionBitBase.ReadWriteFunction ?? "M";
            uiTextBox12.Text = pLCMultifunctionBitBase.ReadWriteAddress ?? "0";

            Enum.GetNames(typeof(Button_pattern)).ForEach(s => { uiComboboxEx1.Items.Add(s); });

            uiComboboxEx1.Text = pLCMultifunctionBitBase.Pattern.ToString();

        }
        /// <summary>
        /// 用户点击了保存数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton1_Click(object sender, EventArgs e)
        {
            //填充保存的数据
            pLCMultifunctionBitBase.ReadWriteAddress = uiComboBox10.Text;
            pLCMultifunctionBitBase.ReadWriteFunction = uiComboBox11.Text;
            pLCMultifunctionBitBase.ReadWriteAddress = uiTextBox12.Text;

            pLCMultifunctionBitBase.Pattern = (Button_pattern)Enum.Parse(typeof(Button_pattern), uiComboboxEx1.Text);

            Save = true;
            this.Close();
        }
        /// <summary>
        /// 用户点击取消数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton2_Click(object sender, EventArgs e)
        {
            Save = false;
            this.Close();
        }
        /// <summary>
        /// 取消键盘事件
        /// </summary>
        /// <param name="send"></param>
        /// <param name="e"></param>
        public virtual void KeyPress(object send, KeyPressEventArgs e) => e.Handled = true;
    }
}
