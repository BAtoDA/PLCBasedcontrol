using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLC多功能控件实现类;
using PLC通讯基础控件项目.控件类基.控件数据结构;
using PLC通讯库.通讯枚举;
using Sunny.UI;

namespace PLC通讯基础控件项目.控件类基.控件地址选择窗口.多功能键控件参数界面.类型选择窗口
{
    public partial class MultifunctionDForm : UIForm
    {
        PLCMultifunctionDBase pLCMultifunctionDBase;
        public bool Save=false;
        public MultifunctionDForm(PLCMultifunctionDBase pLCMultifunctionDBase)
        {
            InitializeComponent();
            this.pLCMultifunctionDBase = pLCMultifunctionDBase;
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
                new PLCpublic().GetPLCDName(uiComboBox11, uiComboBox10.Text);
            });
            uiComboBox10.SelectedIndex = 0;
            uiTextBox12.Text = "0";

            //填充保存的数据
            uiComboBox10.Text = pLCMultifunctionDBase.ReadWriteDPLC.ToString();
            uiComboBox11.Text = pLCMultifunctionDBase.ReadWriteDFunction ?? "D";
            uiTextBox12.Text = pLCMultifunctionDBase.ReadWriteDAddress ?? "0";
            uiTextBox1.Text = pLCMultifunctionDBase.Value.ToString();

            Enum.GetNames(typeof(numerical_format)).ForEach(s => { uiComboboxEx1.Items.Add(s); });

            uiComboboxEx1.Text = pLCMultifunctionDBase.ShowFormat.ToString();

        }
        /// <summary>
        /// 用户点击保存数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton1_Click(object sender, EventArgs e)
        {
            //填充保存的数据
            pLCMultifunctionDBase.ReadWriteDPLC = (PLC)Enum.Parse(typeof(PLC), uiComboBox10.Text);
            pLCMultifunctionDBase.ReadWriteDFunction = uiComboBox11.Text;
            pLCMultifunctionDBase.ReadWriteDAddress = uiTextBox12.Text;
            pLCMultifunctionDBase.Value = Convert.ToInt32(uiTextBox1.Text);

            pLCMultifunctionDBase.ShowFormat = (numerical_format)Enum.Parse(typeof(numerical_format), uiComboboxEx1.Text);

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
