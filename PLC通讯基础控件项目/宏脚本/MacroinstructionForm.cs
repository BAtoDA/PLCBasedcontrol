using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSScriptLib;
using PLC通讯基础控件项目.宏脚本.接口类基;
using Sunny.UI;

namespace PLC通讯基础控件项目.宏脚本
{
    public partial class MacroinstructionForm : UIForm
    {
        /// <summary>
        /// 宏指令接口
        /// </summary>
        MacroinstructionInterface macroinstructionInterface;
        MacroinstructionInterface PlcBitselectCopy;
        /// <summary>
        /// 宏指令编译标志位
        /// </summary>
        volatile bool Compiling = false;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="macroinstructionInterface">宏指令接口</param>
        public MacroinstructionForm(MacroinstructionInterface macroinstructionInterface)
        {
            InitializeComponent();
            //----------------复制该对象的属性---------------
            var Copy = macroinstructionInterface.GetType().GetProperties();

            this.macroinstructionInterface = (MacroinstructionClass)Activator.CreateInstance(macroinstructionInterface.GetType());

            for (int i = 0; i < Copy.Length; i++)
            {
                this.macroinstructionInterface.GetType().GetProperties()[i].SetValue(this.macroinstructionInterface, Copy[i].GetValue(macroinstructionInterface));
            }
            PlcBitselectCopy = macroinstructionInterface;
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            //加载参数
            MacroinstructionLoad();
        }
        /// <summary>
        /// 参数加载
        /// </summary>
        private void MacroinstructionLoad()
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                this.uiTextBox1.Text = Convert.ToString(macroinstructionInterface.Numbering);
                this.uiTextBox2.Text = macroinstructionInterface.Name ?? "Null";
                this.uiCheckBox1.Checked = macroinstructionInterface.Period;
                this.uiCheckBox2.Checked = macroinstructionInterface.Condition;
                this.uiCheckBox3.Checked = macroinstructionInterface.FormShowLoad;
                this.uiRichTextBox1.Text = macroinstructionInterface.Macrocode ?? "using CSScriptLib; \r\n" +
            "using Microsoft.CSharp;using System; \r\n" +
            "using System.CodeDom.Compiler; \r\n" +
            "using System.Collections.Generic; \r\n" +
            "using System.ComponentModel; \r\n" +
            "using System.Data; \r\n" +
            "using System.Drawing; \r\n" +
            "using System.IO; \r\n" +
            "using System.Linq; \r\n" +
            "using System.Net.Sockets; \r\n" +
            "using System.Reflection; \r\n" +
            "using System.Text; \r\n" +
            "using System.Threading.Tasks; \r\n" +
            "using System.Windows.Forms; \r\n" +
            "using System.Net; \r\n" +
            "using System.Threading; \r\n" +
            "public static class ScriptCCStatic \r\n" +
            "{ \r\n" +
                  "//主方法不可更改和删除否则编译报错 \r\n" +
              "   public static void Main(string greeting) \r\n" +
            "      { \r\n " +
                     "//编写代码行： \r\n" +
            "      } \r\n" +
            "} \r\n";
            });
        }
        /// <summary>
        /// 用户点击了编译操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void uiButton1_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            string Code = this.uiRichTextBox1.Text;
            try
            {
                await Task.Run(()=>
                {
                    stopwatch.Start();
                    Assembly compilemethod = CSScript.RoslynEvaluator.CompileMethod(@Code);
                    var Macroinstructiontype = compilemethod.GetType("css_root+DynamicClass+ScriptCCStatic");
                    var MacroinstructionMethod = Macroinstructiontype.GetMethod("Main");
                    MacroinstructionMethod.Invoke(null, new object[] { "1" });
                });
                stopwatch.Stop();
                this.uiLabel4.Text = stopwatch.Elapsed.TotalMilliseconds.ToString();
                this.uiLedBulb1.On = true;
                Compiling=true;
                this.uiRichTextBox3.AppendText(DateTime.Now.ToString("f") + "编译完成：耗时"+ stopwatch.Elapsed.TotalMilliseconds.ToString() + "\r\n");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                stopwatch.Stop();
                this.uiLabel4.Text = stopwatch.Elapsed.TotalMilliseconds.ToString();
                this.uiLedBulb1.On = false;
                this.uiRichTextBox3.AppendText(DateTime.Now.ToString("f")+ex.Message+"\r\n");
                Compiling = false;
            }
        }
        /// <summary>
        /// 用户点击保存 
        /// 先编号后保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void uiButton2_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            string Code = this.uiRichTextBox1.Text;
            try
            {
                await Task.Run(() =>
                {
                    stopwatch.Start();
                    Assembly compilemethod = CSScript.RoslynEvaluator.CompileMethod(@Code);
                    var Macroinstructiontype = compilemethod.GetType("css_root+DynamicClass+ScriptCCStatic");
                    var MacroinstructionMethod = Macroinstructiontype.GetMethod("Main");
                    MacroinstructionMethod.Invoke(null, new object[] { "1" });
                });
                stopwatch.Stop();
                this.uiLabel4.Text = stopwatch.Elapsed.TotalMilliseconds.ToString();
                this.uiLedBulb1.On = true;
                Compiling = true;
                this.uiRichTextBox3.AppendText(DateTime.Now.ToString("f") + "编译完成：耗时" + stopwatch.Elapsed.TotalMilliseconds.ToString() + "\r\n");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                stopwatch.Stop();
                this.uiLabel4.Text = stopwatch.Elapsed.TotalMilliseconds.ToString();
                this.uiLedBulb1.On = false;
                this.uiRichTextBox3.AppendText(DateTime.Now.ToString("f") + ex.Message + "\r\n");
                Compiling = false;
            }
            macroinstructionInterface.Compilestate = Compiling;
            macroinstructionInterface.Numbering = Convert.ToInt32(this.uiTextBox1.Text);
            macroinstructionInterface.Name = this.uiTextBox2.Text ?? "Null";
            macroinstructionInterface.Period = this.uiCheckBox1.Checked;
            macroinstructionInterface.Condition = this.uiCheckBox2.Checked;
            macroinstructionInterface.FormShowLoad = this.uiCheckBox3.Checked;
            macroinstructionInterface.Macrocode = this.uiRichTextBox1.Text ?? "using CSScriptLib; \r\n" +
        "using Microsoft.CSharp;\r\n" +
        "using System; \r\n" +
        "using System.CodeDom.Compiler; \r\n" +
        "using System.Collections.Generic; \r\n" +
        "using System.ComponentModel; \r\n" +
        "using System.Data; \r\n" +
        "using System.Drawing; \r\n" +
        "using System.IO; \r\n" +
        "using System.Linq; \r\n" +
        "using System.Net.Sockets; \r\n" +
        "using System.Reflection; \r\n" +
        "using System.Text; \r\n" +
        "using System.Threading.Tasks; \r\n" +
        "using System.Windows.Forms; \r\n" +
        "using System.Net; \r\n" +
        "using System.Threading; \r\n" +
        "public static class ScriptCCStatic \r\n" +
        "{ \r\n" +
              "//主方法不可更改和删除否则编译报错 \r\n" +
          "   public static void Main(string greeting) \r\n" +
        "      { \r\n " +
                 "//编写代码行： \r\n" +
        "      } \r\n" +
        "} \r\n";

            //-------------放回对象属性----------------
            var Copy = macroinstructionInterface.GetType().GetProperties();
            for (int i = 0; i < Copy.Length; i++)
            {
                PlcBitselectCopy.GetType().GetProperties()[i].SetValue(PlcBitselectCopy, Copy[i].GetValue(macroinstructionInterface));
            }
            this.Close();
        }
        /// <summary>
        /// 用户点击取消保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
