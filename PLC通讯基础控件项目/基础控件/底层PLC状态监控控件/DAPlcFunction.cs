//**********************************************************************
//
// 文件名称(File Name)：
// 功能描述(Description)：
// 作者(Author)：DAtoTA
// 日期(Create Date)： 2021/9/15 21:00:25
//
//**********************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using PLC通讯基础控件项目.基础控件.底层PLC状态监控控件.功能键参数设置窗口;
using PLC通讯基础控件项目.控件类基.控件数据结构;
using Sunny.UI;

namespace PLC通讯基础控件项目.基础控件.底层PLC状态监控控件
{
    /// <summary>
    /// PLC功能键
    /// 读取固定路径// 模板与控制界面命名空间
    /// </summary>
    public partial class DAPlcFunction
    {
        protected override void OnClick(EventArgs e)
        {
            //用户是否启用该功能
            if (!this.plc_Enable) return;
            //获取所有运行中的窗口
            foreach (Form i in Application.OpenForms)
            {
                if (i.GetType().FullName == this.FormPath + "." + this.FormName)
                {
                    i.Activate();
                    return;
                }
            }
            //找不到窗口--窗口新的窗口
            //var Formoop = Assembly.GetExecutingAssembly().GetTypes(this.FormPath + "." + this.FormName);
            //获取所有运行中的窗口
            Regex rq = new Regex(this.formPath ?? "PLC通讯基础控件项目.模板与控制界面");
            var Formoop = Assembly.GetEntryAssembly().GetTypes().Where(p=> rq.IsMatch(p.FullName)).ToList();
            if (Formoop != null)
            {
                Regex regex = new Regex(this.FormName);
                var Form = Formoop.Where(p => regex.IsMatch(p.FullName)).FirstOrDefault();
                if (Form != null)
                {
                    Form FormShow = Activator.CreateInstance(Form) as Form;
                    FormShow.StartPosition = FormStartPosition.CenterScreen;
                    FormShow.Show();
                }
            }
            else
                return;
            //关闭当前窗口
            //获取所有运行中的窗口
            Regex r = new Regex(this.formPath ?? "PLC通讯基础控件项目.模板与控制界面");
            //递归查找顶级窗口Form
            object Oop = this;
            while (true)
            {
                if ((((dynamic)Oop).Parent as Form) != null)
                {
                    Oop = ((dynamic)Oop).Parent;
                    break;
                }
                else
                    Oop = ((dynamic)Oop).Parent;
            }
            if(Application.OpenForms.Count<=2)
            {
                if (MessageBox.Show("代码检测到你窗口数量少于2 \r\n 这表示会导致关闭主窗口 \r\n 这在C#主窗口是不允许关闭的\r\n 这样会导致整个程序都进行关闭", "Err", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
            }
            foreach (Form i in Application.OpenForms)
            {
                //if (r.IsMatch(i.GetType().FullName) && i == (Form)Oop)
                if (i == (Form)Oop)
                {
                    i.Close();
                    return;
                }
            }

            base.OnClick(e);

        }
    }
    [ToolboxItem(true)]
    public partial class DAPlcFunction : UIButton
    {
        [Browsable(false)]
        public event EventHandler Modification;
        /// <summary>
        /// 私有保存参数 自动添加
        /// </summary>
        [Description("选择修改的属性"), Category("PLC类型")]
        [Browsable(true)]
        public PLCSet APLC
        {
            get => PLCsz;
            set
            {
                if (plc_Enable)
                {
                    this.Modification += new EventHandler(Modifications_Eeve);
                    this.Modification(this, new EventArgs());
                    this.Modification -= new EventHandler(Modifications_Eeve);
                    return;
                }
                this.Modification -= new EventHandler(Modifications_Eeve);
            }

        }
        /// <summary>
        /// 私有设置PLC参数
        /// </summary>
        private PLCSet PLCsz = 0;
        /// <summary>
        /// 是否启用PLC功能
        /// </summary>
        [Browsable(true)]
        [Description("是否启用功能键"), Category("PLC类型")]
        public bool PLC_Enable
        {
            get => plc_Enable;
            set => plc_Enable = value;
        }
        private bool plc_Enable = false;
        /// <summary>
        /// Form 窗口路径
        /// </summary>
        [ToolboxItem(true)]
        [Browsable(true)]
        [Description("反射Form窗口路径"), Category("PLC类型")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string FormPath { get => formPath; set => formPath = value; }
        private string formPath = "PLC通讯基础控件项目.模板与控制界面";
        /// <summary>
        /// Form反射窗口名称
        /// </summary>
        [ToolboxItem(true)]
        [Browsable(false)]
        [Description("Form窗口路径"), Category("PLC类型")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string FormName { get; set; } = "TemplateForm";
        /// <summary>
        /// 修改参数界面窗口事件方法
        /// </summary>
        /// <param name="send"></param>
        /// <param name="e"></param>

        public void Modifications_Eeve(object send, EventArgs e)
        {
            this.Modification -= new EventHandler(Modifications_Eeve);
            FunctionForm pLCpropertyBit = new FunctionForm(this.FormPath, FormName);
            pLCpropertyBit.StartPosition = FormStartPosition.CenterParent;
            pLCpropertyBit.ShowDialog();
            if (pLCpropertyBit.Save)
            {
                this.formPath = pLCpropertyBit.Formpthan;
                this.FormName = pLCpropertyBit.FormName;
            }
        }
    }
}
