//**********************************************************************
//
// 文件名称(File Name)：
// 功能描述(Description)：
// 作者(Author)：DAtoTA
// 日期(Create Date)： 2021/8/29 14:11:15
//
//**********************************************************************
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类;
using PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLCD控件实现类;
using PLC通讯基础控件项目.控件类基.控件数据结构;
using Sunny.UI;

namespace PLC通讯基础控件项目.控件类基.控件地址选择窗口
{
    /// <summary>
    /// 用于实现PLC属性设置菜单
    /// </summary>
    sealed class  PLCpropertyClass: PLCpublic
    {
        #region Bit位PLC属性处理
        /// <summary>
        /// Bit位构造函数
        /// </summary>
        /// <param name="Description"></param>
        /// <param name="Alamp"></param>
        /// <param name="Aswitch"></param>
        /// <param name="readwrite"></param>
        /// <param name="readwriteplc"></param>
        /// <param name="readwritePLCfunction"></param>
        /// <param name="readwriteaddress"></param>
        /// <param name="Out"></param>
        /// <param name="writePelan"></param>
        /// <param name="writeplc"></param>
        /// <param name="writePLCfunction"></param>
        /// <param name="writeaddress"></param>
        /// <param name="loosenOut"></param>
        /// <param name="propertyPelan"></param>
        /// <param name="pattern"></param>
        /// <param name="pLCBitselect"></param>
        public PLCpropertyClass(UITextBox Description, UICheckBox Alamp, UICheckBox Aswitch, UICheckBox readwrite, UIGroupBox readwritepelan, UIComboBox readwriteplc, UIComboBox readwritePLCfunction,
            UITextBox readwriteaddress, UICheckBox Out, UIGroupBox writePelan, UIComboBox writeplc, UIComboBox writePLCfunction,
            UITextBox writeaddress, UICheckBox loosenOut, UIGroupBox propertyPelan, UIComboBox pattern, PLCBitselectRealize pLCBitselect, UIButton SetPlcButton)
        {
            //初始化操作--PLC下拉菜单
            PLCload(readwriteplc, readwritePLCfunction, readwriteaddress, writePelan, writeplc, writePLCfunction, writeaddress);
            //加载属性选项
            Enum.GetNames(typeof(Button_pattern)).ForEach(s =>
            {
                pattern.Items.Add(s);
            });
            pattern.SelectedIndex = 0;
            ///处理事件
            readwriteaddress.KeyPress += ((send, e) =>
             {
                //不允许输入特殊字符
                if (e.KeyChar != '\b')//这是允许输入退格键  
                {
                     if (e.KeyChar == '.') return;
                     if ((e.KeyChar < '0') || (e.KeyChar > 'F') & (e.KeyChar != '.'))
                      {
                          e.Handled = true;
                      }
                  }
              });
            writeaddress.KeyPress += ((send, e) =>
            {
                //不允许输入特殊字符
                if (e.KeyChar != '\b')//这是允许输入退格键  
                {
                    if (e.KeyChar == '.') return;
                    if ((e.KeyChar < '0') || (e.KeyChar > 'F') & (e.KeyChar != '.'))
                    {
                        e.Handled = true;
                    }
                }
            });
            //处理UI特效部分
            //位状态指示灯特效
            Aswitch.CheckedChanged += ((sendq, s1) =>
            {
                if (Aswitch.Checked)
                {
                    readwritepelan.Visible = false;
                    writePelan.Visible = false;
                    propertyPelan.Visible = false;
                    Alamp.Checked = false;
                }
            });
            //位状态切换特效
            Alamp.CheckedChanged += ((sendq, s1) =>
            {
                if (Alamp.Checked)
                {
                    readwritepelan.Visible = true;
                    propertyPelan.Visible = true;
                    Aswitch.Checked = false;
                    writePelan.Visible = readwrite.Checked;
                }
            });
            //处理读取写入不同地址
            readwrite.CheckedChanged += ((sendq, s1) =>
             {
                 writePelan.Visible = readwrite.Checked;
             });
            //处理用户选择PLC时改变功能码
            readwriteplc.TextChanged += ((sendq, s1) =>
             {
                 readwritePLCfunction.Items.Clear();
                 GetPLCBitName(readwritePLCfunction, readwriteplc.Text);
             });
            writeplc.TextChanged += ((sendq, s1) =>
             {
                 writePLCfunction.Items.Clear();
                 GetPLCBitName(writePLCfunction, writeplc.Text);
             });
            //处理键盘
            readwriteplc.KeyPress += KeyPress;
            readwritePLCfunction.KeyPress += KeyPress;
            writeplc.KeyPress += KeyPress;
            writePLCfunction.KeyPress += KeyPress;
            pattern.KeyPress += KeyPress;
            //----------处理控件值-----------
            GetPLCValue();
            void GetPLCValue()
            {
                Description.Text = pLCBitselect.description ?? this.GetType().Name;
                Alamp.Checked = pLCBitselect.BitPattern ? false : true;
                Aswitch.Checked = pLCBitselect.BitPattern ? true : false;
                readwrite.Checked = pLCBitselect.ReadWrite;
                readwriteplc.Text = pLCBitselect.ReadWritePLC.ToString();
                readwritePLCfunction.Text = pLCBitselect.ReadWriteFunction != null ? pLCBitselect.ReadWriteFunction : "M";
                readwriteaddress.Text = pLCBitselect.ReadWriteAddress != null ? pLCBitselect.ReadWriteAddress : "0";
                Out.Checked = pLCBitselect.OutReverse;
                writeplc.Text = pLCBitselect.WritePLC.ToString();
                writePLCfunction.Text = pLCBitselect.WriteFunction != null ? pLCBitselect.WriteFunction : "M";
                writeaddress.Text = pLCBitselect.WriteAddress != null ? pLCBitselect.WriteAddress : "0";
                loosenOut.Checked = pLCBitselect.LoosenOut;
                pattern.Text = pLCBitselect.Pattern.ToString();
            }
            //-----------保存参数-----------
            SetPlcButton.Click += ((Send, e) =>
              {
                  pLCBitselect.description = Description.Text;
                  pLCBitselect.BitPattern = Alamp.Checked  ? false: true ;
                  //pLCBitselect.BitPattern = Aswitch.Checked;
                  pLCBitselect.ReadWrite = readwrite.Checked;
                  pLCBitselect.ReadWritePLC = (PLC)Enum.Parse(typeof(PLC), readwriteplc.Text);
                  pLCBitselect.ReadWriteFunction = readwritePLCfunction.Text;
                  pLCBitselect.ReadWriteAddress = readwriteaddress.Text;
                  pLCBitselect.OutReverse = Out.Checked;
                  pLCBitselect.WritePLC = (PLC)Enum.Parse(typeof(PLC), writeplc.Text);
                  pLCBitselect.WriteFunction = writePLCfunction.Text;
                  pLCBitselect.WriteAddress = writeaddress.Text;
                  pLCBitselect.LoosenOut = loosenOut.Checked;
                  pLCBitselect.Pattern = (Button_pattern)Enum.Parse(typeof(Button_pattern), pattern.Text);
              });
        }
        #endregion
        #region 实现D寄存器属性
        /// <summary>
        /// 寄存器D构造函数
        /// </summary>
        /// <param name="Description">控件描述</param>
        /// <param name="Alamp">是否启用输入功能</param>
        /// <param name="readwrite">读写不同地址</param>
        /// <param name="readwritepelan">读取面板</param>
        /// <param name="readwriteplc">读取PLC类型</param>
        /// <param name="readwritePLCfunction">读取PLC功能码</param>
        /// <param name="readwriteaddress">读取PLC具体地址</param>
        /// <param name="writePelan">写入面板</param>
        /// <param name="writeplc">写入PLC类型</param>
        /// <param name="writePLCfunction">写入PLC功能码</param>
        /// <param name="writeaddress">写入PLC具体地址</param>
        /// <param name="propertyPelan">通知面板</param>
        /// <param name="inform">通知启用</param>
        /// <param name="inform01Pealn">通知01的面板</param>
        /// <param name="inform1">通知其他状态 设置ON  还是 OFF</param>
        /// <param name="inform0">通知其他状态 设置ON  还是 OFF</param>
        /// <param name="inforplc">通知PLC类型</param>
        /// <param name="informPLCfunction">通知PLC功能码</param>
        /// <param name="informaddress">通知PLC具体地址</param>
        /// <param name="pLCBitselect">D寄存器参数</param>
        /// <param name="SetPlcButton">是否保存按钮</param>
        public PLCpropertyClass(UITextBox Description, UICheckBox Alamp, UICheckBox readwrite, UIGroupBox readwritepelan, UIComboBox readwriteplc, UIComboBox readwritePLCfunction,UITextBox readwriteaddress, UIGroupBox writePelan, UIComboBox writeplc, UIComboBox writePLCfunction,
           UITextBox writeaddress, UIGroupBox propertyPelan,UICheckBox inform,UIGroupBox inform01Pealn, UICheckBox inform1,UICheckBox inform0, UIComboBox inforplc, UIComboBox informPLCfunction,
           UITextBox informaddress, PLCDselectRealize pLCDselect, UIButton SetPlcButton)
        {
            //初始化操作--PLC下拉菜单
            PLCload(readwriteplc, readwritePLCfunction, readwriteaddress, writePelan, writeplc, writePLCfunction, writeaddress);
            //加载通知
            inforplc.Items.Clear();
            Enum.GetNames(typeof(PLC)).ForEach(s =>
            {
                inforplc.Items.Add(s);
            });
            inforplc.SelectedIndex = 0;
            ///处理事件
            readwriteaddress.KeyPress += ((send, e) =>
            {
                //不允许输入特殊字符
                if (e.KeyChar != '\b')//这是允许输入退格键  
                {
                    if ((e.KeyChar < '0') || (e.KeyChar > 'F') & (e.KeyChar != '.'))
                    {
                        e.Handled = true;
                    }
                }
            });
            writeaddress.KeyPress += ((send, e) =>
            {
                //不允许输入特殊字符
                if (e.KeyChar != '\b')//这是允许输入退格键  
                {
                    if ((e.KeyChar < '0') || (e.KeyChar > 'F') & (e.KeyChar != '.'))
                    {
                        e.Handled = true;
                    }
                }
            });
            inforplc.TextChanged += ((sendq, s1) =>
            {
                informPLCfunction.Items.Clear();
                GetPLCBitName(informPLCfunction, inforplc.Text);
                informaddress.Text = "0";
            });
            GetPLCBitName(informPLCfunction, inforplc.Text);
            //处理UI特效部分     
            //处理读取写入不同地址
            readwrite.CheckedChanged += ((sendq, s1) =>
            {
                writePelan.Visible = readwrite.Checked;
            });
            //处理用户选择PLC时改变功能码
            readwriteplc.TextChanged += ((sendq, s1) =>
            {
                readwritePLCfunction.Items.Clear();
                GetPLCDName(readwritePLCfunction, readwriteplc.Text);
            });
            readwritePLCfunction.Items.Clear();
            GetPLCDName(readwritePLCfunction, readwriteplc.Text);
            writeplc.TextChanged += ((sendq, s1) =>
            {
                writePLCfunction.Items.Clear();
                GetPLCDName(writePLCfunction, writeplc.Text);
            });
            writePLCfunction.Items.Clear();
            GetPLCDName(writePLCfunction, writeplc.Text);
            //处理键盘
            readwriteplc.KeyPress += KeyPress;
            readwritePLCfunction.KeyPress += KeyPress;
            writeplc.KeyPress += KeyPress;
            writePLCfunction.KeyPress += KeyPress;
            inforplc.KeyPress += KeyPress;
            informPLCfunction.KeyPress += KeyPress;
            //----------处理通知-------------
            //位状态指示灯特效
            inform1.CheckedChanged += ((sendq, s1) =>
            {
                if (inform1.Checked)
                {
                    inform0.Checked = false;
                }
            });
            //位状态切换特效
            inform0.CheckedChanged += ((sendq, s1) =>
            {
                if (inform0.Checked)
                {
                    inform1.Checked = false;
                }
            });
            inform.CheckedChanged += ((send, s1) =>
              {
                  inform01Pealn.Visible = inform.Checked;
                  inforplc.Visible = inform.Checked;
                  informPLCfunction.Visible = inform.Checked;
                  informaddress.Visible = inform.Checked;
              });
            //----------处理控件值-----------
            GetPLCValue();
            void GetPLCValue()
            {
                Description.Text = pLCDselect.description ?? this.GetType().Name;
                Alamp.Checked = pLCDselect.Dataentryfunction ? true : false;
                readwrite.Checked = pLCDselect.ReadWrite;
                readwriteplc.Text = pLCDselect.ReadWritePLC.ToString();
                readwritePLCfunction.Text = pLCDselect.ReadWriteFunction != null ? pLCDselect.ReadWriteFunction : "M";
                readwriteaddress.Text = pLCDselect.ReadWriteAddress != null ? pLCDselect.ReadWriteAddress : "0";
                writeplc.Text = pLCDselect.WritePLC.ToString();
                writePLCfunction.Text = pLCDselect.WriteFunction != null ? pLCDselect.WriteFunction : "M";
                writeaddress.Text = pLCDselect.WriteAddress != null ? pLCDselect.WriteAddress : "0";

                inform.Checked = pLCDselect.Inform;
                inform1.Checked = pLCDselect.Informpattern > 0 ? true : false;
                inform0.Checked = pLCDselect.Informpattern <1 ? true : false;
                inforplc.Text = pLCDselect.InformPLC.ToString();
                informPLCfunction.Text = pLCDselect.InformFunction.ToString();
                informaddress.Text = pLCDselect.InformAddress;


            }
            //-----------保存参数-----------
            SetPlcButton.Click += ((Send, e) =>
            {
                pLCDselect.description = Description.Text;
                pLCDselect.Dataentryfunction = Alamp.Checked ? true : false;
                //pLCBitselect.BitPattern = Aswitch.Checked;
                pLCDselect.ReadWrite = readwrite.Checked;
                pLCDselect.ReadWritePLC = (PLC)Enum.Parse(typeof(PLC), readwriteplc.Text);
                pLCDselect.ReadWriteFunction = readwritePLCfunction.Text;
                pLCDselect.ReadWriteAddress = readwriteaddress.Text;
                pLCDselect.WritePLC = (PLC)Enum.Parse(typeof(PLC), writeplc.Text);
                pLCDselect.WriteFunction = writePLCfunction.Text;
                pLCDselect.WriteAddress = writeaddress.Text;

                pLCDselect.Inform = inform.Checked;
                pLCDselect.Informpattern = Convert.ToInt32(inform1.Checked);

                pLCDselect.InformPLC = (PLC)Enum.Parse(typeof(PLC), inforplc.Text);
                pLCDselect.InformFunction = informPLCfunction.Text;
                pLCDselect.InformAddress = informaddress.Text;

            });
        }
        #endregion
        /// <summary>
        /// 加载PLC选项
        /// </summary>
        /// <param name="readwriteplc"></param>
        /// <param name="readwritePLCfunction"></param>
        /// <param name="readwriteaddress"></param>
        /// <param name="readwritePelan"></param>
        /// <param name="writeplc"></param>
        /// <param name="writePLCfunction"></param>
        /// <param name="writeaddress"></param>
        private void PLCload(UIComboBox readwriteplc, UIComboBox readwritePLCfunction,
        UITextBox readwriteaddress, UIGroupBox readwritePelan, UIComboBox writeplc, UIComboBox writePLCfunction,
        UITextBox writeaddress)
        {
            readwriteplc.Items.Clear();
            writeplc.Items.Clear();
            Enum.GetNames(typeof(PLC)).ForEach(s =>
            {
                readwriteplc.Items.Add(s);
                writeplc.Items.Add(s);
            });
            readwriteplc.SelectedIndex = 0;
            writeplc.SelectedIndex = 0;
            readwritePLCfunction.Items.Clear();
            writePLCfunction.Items.Clear();
            Enum.GetNames(typeof(Mitsubishi_bit)).ForEach(s =>
            {
                readwritePLCfunction.Items.Add(s);
                writePLCfunction.Items.Add(s);
            });
            readwritePLCfunction.SelectedIndex = 0;
            writePLCfunction.SelectedIndex = 0;
            readwriteaddress.Text = "0";
            writeaddress.Text = "0";
        }
        /// <summary>
        /// 加载PLC类型地址
        /// </summary>
        /// <param name="readwriteplc"></param>
        /// <param name="readwritePLCfunction"></param>
        /// <param name="readwriteaddress"></param>
        private void PLCload(UIComboBox readwriteplc, UIComboBox readwritePLCfunction, UITextBox readwriteaddress)
        {
            readwriteplc.Items.Clear();
            Enum.GetNames(typeof(PLC)).ForEach(s =>
            {
                readwriteplc.Items.Add(s);
            });
            readwriteplc.SelectedIndex = 0;
            readwritePLCfunction.Items.Clear();
            Enum.GetNames(typeof(Mitsubishi_D)).ForEach(s =>
            {
                readwritePLCfunction.Items.Add(s);
            });
            readwritePLCfunction.SelectedIndex = 0;
            readwriteaddress.Text = "0";
        }
    }
}
