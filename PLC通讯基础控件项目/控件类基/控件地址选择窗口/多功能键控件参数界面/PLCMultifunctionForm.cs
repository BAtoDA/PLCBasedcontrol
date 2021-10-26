﻿using System;
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
using PLC通讯基础控件项目.控件类基.控件地址选择窗口.多功能键控件参数界面.类型选择窗口;
using System.Diagnostics;

namespace PLC通讯基础控件项目.控件类基.控件地址选择窗口.多功能键控件参数界面
{
    public partial class PLCMultifunctionForm : UIForm
    {
        #region 字段
        PLCMultifunctionBase pLCMultifunctionBase;
        List<PLCMultifunctionClassBase> pLCMultifunction = new List<PLCMultifunctionClassBase>();
        #endregion

        public PLCMultifunctionForm(PLCMultifunctionBase pLCMultifunctionBase)
        {
            InitializeComponent();
            this.pLCMultifunctionBase = pLCMultifunctionBase;
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            //填充安全页面
            PLCpropertysafety pLCpropertysafety = new PLCpropertysafety(uiComboBox20, uiCheckBox20, uiComboBox21, uiComboBox22, uiComboBox23, uiTextBox20, uiComboBox24
                , uiComboBox25, uiComboBox26, new Sunny.UI.UIGroupBox[] { uiGroupBox21, uiGroupBox22, uiGroupBox23 }, new Sunny.UI.UICheckBox[] { uiCheckBox21, uiCheckBox22 },
                this.uiCheckBox23, this.uiButton1, pLCMultifunctionBase);
            //填充处理文字选择页面
            PLCpropertyText pLCpropertyText = new PLCpropertyText(uiComboBox30, uiButton30, uiButton31, uiComboBox31, uiComboBox32, uiComboBox33, uiComboBox34, uiRichTextBox30
                , uiColorPicker30, uiColorPicker31, uiCheckBox30, uiCheckBox31, pLCMultifunctionBase.pLCBitselectRealizeq, uiButton1);
            //填充PLC属性设置页面
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
            uiComboBox10.Text = pLCMultifunctionBase.ReadPLC.ToString();
            uiComboBox11.Text = pLCMultifunctionBase.ReadFunction ?? "M";
            uiTextBox12.Text = pLCMultifunctionBase.ReadAddress ?? "0";

            //动作下拉填充
            this.uiListBox1.Items.Clear();
            if (pLCMultifunctionBase.pLCMultifunctions.Length > 0)
            {
                pLCMultifunctionBase.pLCMultifunctions.ForEach(s =>
                {
                    switch (s.ClassInterface)
                    {
                        case "PLCmMltifunctionFunctionBase":
                            //显示功能键
                            this.uiListBox1.Items.Add($"{((PLCmMltifunctionFunctionBase)s).FormName},{((PLCmMltifunctionFunctionBase)s).FormPath}");
                            break;
                        case "PLCMultifunctionBitBase":
                            //显示Bit位
                            this.uiListBox1.Items.Add($"{((PLCMultifunctionBitBase)s).ReadWritePLC} {((PLCMultifunctionBitBase)s).ReadWriteFunction} " +
                                $"{((PLCMultifunctionBitBase)s).ReadWriteAddress} {((PLCMultifunctionBitBase)s).Pattern}");
                            break;
                        case "PLCMultifunctionDBase":
                            //显示寄存器D
                            this.uiListBox1.Items.Add($"{((PLCMultifunctionDBase)s).ReadWritePLC} {((PLCMultifunctionDBase)s).ReadWriteFunction} " +
                            $"{((PLCMultifunctionDBase)s).ReadWriteAddress} {((PLCMultifunctionDBase)s).Value}");
                            break;
                    }
                });
                //保存参数
                pLCMultifunction = pLCMultifunctionBase.pLCMultifunctions.ToList();
            }

            //--------------注册动作页面 操作按钮-----------
            this.uiButton1.Click += ((send, e) =>
              {
                  //弹出窗口--用户选择添加的类型
                  this.uiPanel1.Visible = true;
              });
            this.uiButton2.Click += ((send, e) =>
            {
                //移除指定索引的行
                if (this.uiListBox1.SelectedIndex > -1)
                {
                    pLCMultifunction.RemoveAt(this.uiListBox1.SelectedIndex);

                    this.uiListBox1.Items.Clear();
                    pLCMultifunction.ForEach(s => { LitsAdd(s); });
                }
            });
            this.uiButton3.Click += ((send, e) =>
            {
                //向上移动一格
                if (this.uiListBox1.SelectedIndex < 0) return;
                int Index = this.uiListBox1.SelectedIndex > 0 ? this.uiListBox1.SelectedIndex - 1 : 0;
                pLCMultifunction.Insert(this.uiListBox1.SelectedIndex > 0 ? this.uiListBox1.SelectedIndex - 1 : 0, pLCMultifunction[this.uiListBox1.SelectedIndex]);
                pLCMultifunction.RemoveAt(this.uiListBox1.SelectedIndex + 1);

                this.uiListBox1.Items.Clear();
                pLCMultifunction.ForEach(s => { LitsAdd(s); });

                //赋予索引
                this.uiListBox1.SelectedIndex = Index;
            });
            this.uiButton4.Click += ((send, e) =>
            {
                if (this.uiListBox1.SelectedIndex < 0|| this.uiListBox1.SelectedIndex+2> pLCMultifunction.Count) return;
                //向下移动一格
                int Index = this.uiListBox1.SelectedIndex < pLCMultifunction.Count ? this.uiListBox1.SelectedIndex + 1 : 0;
                pLCMultifunction.Insert(this.uiListBox1.SelectedIndex < pLCMultifunction .Count? this.uiListBox1.SelectedIndex + 2 : 0, pLCMultifunction[this.uiListBox1.SelectedIndex]);
                pLCMultifunction.RemoveAt(this.uiListBox1.SelectedIndex );

                this.uiListBox1.Items.Clear();
                pLCMultifunction.ForEach(s => { LitsAdd(s); });

                //赋予索引
                this.uiListBox1.SelectedIndex = Index;


            });

            //------------选择对应的窗口-------------
            this.uiButton7.Click += ((send, e) =>
            {
                this.uiPanel1.Visible = false;
                //位处理
                PLCMultifunctionClassBase classBase = new PLCMultifunctionClassBase();
                MultifunctionBitForm bitForm = new MultifunctionBitForm(classBase);
                bitForm.ShowDialog();
                classBase.ClassInterface = "PLCMultifunctionBitBase";

                Add(classBase);
            });

            this.uiButton8.Click += ((send, e) =>
            {
                this.uiPanel1.Visible = false;
                //字处理
                PLCMultifunctionClassBase classBase = new PLCMultifunctionClassBase();
                MultifunctionDForm dForm = new MultifunctionDForm(classBase);
                dForm.ShowDialog();
                classBase.ClassInterface = "PLCMultifunctionDBase";

                Add(classBase);
            });

            this.uiButton9.Click += ((send, e) =>
            {
                this.uiPanel1.Visible = false;
                //窗口处理
                PLCMultifunctionClassBase classBase = new PLCMultifunctionClassBase();
                MultifunctionFunctionForm functionForm = new MultifunctionFunctionForm(classBase);
                functionForm.ShowDialog();
                classBase.ClassInterface = "PLCmMltifunctionFunctionBase";

                Add(classBase);
            });
            void Add(PLCMultifunctionClassBase Data)
            {
                //添加数据
                pLCMultifunction.Add(Data);
                //重新填充下拉菜单
                LitsAdd(Data);
            }

            void LitsAdd(PLCMultifunctionClassBase Data)
            {
                //重新填充下拉菜单
                switch (Data.ClassInterface)
                {
                    case "PLCmMltifunctionFunctionBase":
                        //显示功能键
                        this.uiListBox1.Items.Add($"{((PLCmMltifunctionFunctionBase)Data).FormName},{((PLCmMltifunctionFunctionBase)Data).FormPath}");
                        break;
                    case "PLCMultifunctionBitBase":
                        //显示Bit位
                        this.uiListBox1.Items.Add($"{((PLCMultifunctionBitBase)Data).ReadWritePLC} {((PLCMultifunctionBitBase)Data).ReadWriteFunction} " +
                            $"{((PLCMultifunctionBitBase)Data).ReadWriteAddress} {((PLCMultifunctionBitBase)Data).Pattern}");
                        break;
                    case "PLCMultifunctionDBase":
                        //显示寄存器D
                        this.uiListBox1.Items.Add($"{((PLCMultifunctionDBase)Data).ReadWritePLC} {((PLCMultifunctionDBase)Data).ReadWriteFunction} " +
                        $"{((PLCMultifunctionDBase)Data).ReadWriteAddress} {((PLCMultifunctionDBase)Data).Value}");
                        break;
                }
            }
                
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
        }
        public const int WM_LBUTTONUP = 528;
        protected override void WndProc(ref Message m)
        {
            //Debug.WriteLine(m.Msg.ToString());
            if (m.Msg == WM_LBUTTONUP)
            {
                //隐藏窗口--用户选择添加的类型
                //this.uiPanel1.Visible = false;
            }
            base.WndProc(ref m);
        }
        /// <summary>
        /// 取消键盘事件
        /// </summary>
        /// <param name="send"></param>
        /// <param name="e"></param>
        public virtual void KeyPress(object send, KeyPressEventArgs e) => e.Handled = true;
    }
}
