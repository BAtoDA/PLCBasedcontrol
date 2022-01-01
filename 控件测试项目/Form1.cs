using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using PLC通讯基础控件项目.控件类基.PLC基础接口;
using PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类;
using PLC通讯基础控件项目.控件类基.控件地址选择窗口;
using PLC通讯基础控件项目.控件类基.控件地址选择窗口.配方控件参数设置界面;

namespace 控件测试项目
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // new PLCRecipeForm(this.daRecipe1.PLCRecipeClass).Show();

            



            // new PLCpropertyBit( new PLCBitselectRealize()).Show();
            var dw = new EventCreateClass();

            foreach(var i in dw.EventName(this.uiButton1))
                this.uiComboBox1.Items.Add(i.Name);
            this.uiComboBox1.SelectedIndex = 22;
            dw.GainHandler(this.uiButton1, this.uiComboBox1.Text);
            dw.ControlEvent += ((sender, e) =>
              {
                  MessageBox.Show(sender.ToString());
              });

            //测试代码
            List<string> l = new List<string>();
            l.Add("if ");
            l.Add("else ");

            foreach (var v in l)
            {
                int count = Regex.Matches(this.uiRichTextBox1.Text, v).Count;//count occurrences of string
                int WordLen = v.Length;
                int startFrom = 0;
                for (int i = 0; i < count; i++)
                {
                    uiRichTextBox1.SelectionStart = uiRichTextBox1.Text.IndexOf(v, startFrom);
                    uiRichTextBox1.SelectionLength = WordLen;
                    uiRichTextBox1.SelectionColor = Color.Red;
                    startFrom = uiRichTextBox1.Text.IndexOf(v, startFrom) + WordLen;

                }
            }
        }

        private void uiRichTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (w1e) { w1e=false;  return; }
            //测试代码
            List<string> l = new List<string>();
            l.Add("if ");
            l.Add("else ");

            foreach (var v in l)
            {
                int count = Regex.Matches(this.uiRichTextBox1.Text, v).Count;//count occurrences of string
                int WordLen = v.Length;
                int startFrom = 0;
                for (int i = 0; i < count; i++)
                {
                    var w= uiRichTextBox1.Text.IndexOf(v, startFrom); 
                   // uiRichTextBox1.SelectionStart = uiRichTextBox1.Text.IndexOf(v, startFrom);
                   // uiRichTextBox1.SelectionLength = WordLen;
                   // uiRichTextBox1.SelectionColor = Color.Red;
                    // startFrom = uiRichTextBox1.Text.IndexOf(v, startFrom) + WordLen;
                    uiRichTextBox1.Select(w, v.Length);
                    uiRichTextBox1.SelectionColor = Color.Red;
                }
            }
            uiRichTextBox1.SelectionColor = Color.Black;

        }
        bool w1e=false;
        private void uiRichTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                w1e = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            daUiTextBox1.Text = "856";
            daUiTextBox1.WrietCommand = true;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
           
        }
    }
}
