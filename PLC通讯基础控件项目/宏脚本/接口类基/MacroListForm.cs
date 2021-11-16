using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Nancy.Json;
using PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLC报警显示控件实现类;
using Sunny.UI;
using System.Linq;

namespace PLC通讯基础控件项目.宏脚本.接口类基
{
    public partial class MacroListForm : UIForm
    {
        /// <summary>
        /// 保存宏指令文本类
        /// </summary>
        MacroContent macroContent;
        /// <summary>
        /// 宏指令列表
        /// </summary>
        List<MacroinstructionClass> macroinstructionClasses = new List<MacroinstructionClass>();

        public MacroListForm()
        {
            InitializeComponent();
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            //-----------读取宏指令保存参数----------------
            macroContent = new MacroContent(@"C:\");//实例化
            if (!macroContent.IsDirectory())
                macroContent.DirectoryCreate();
            MacroLoad();
            //------------用户添加宏操作-----------------------
            this.uiButton1.Click += (async (send, e) =>
            {
                var ID = macroinstructionClasses.Count>0?macroinstructionClasses.Max(p => p.MacroID) + 1:1;
                macroContent.Textaddress = @"C:\PLCMacroList\MacroList" + ID + ".txt";
                while (File.Exists(macroContent.Textaddress))
                {
                    ID += 1;
                    macroContent.Textaddress = @"C:\PLCMacroList\MacroList" + ID + ".txt";
                }
                  //创建文件夹
                  macroContent.TextCreate();
                  //追加默认值
                  await macroContent.TextWrite(new JavaScriptSerializer().Serialize(new MacroinstructionClass()
                  {
                      MacroID = ID,
                      Numbering = ID,
                      Name = "MacroList"+ID
                  }));
                MacroLoad();
            });
            //------------用户移除宏-----------------------
            this.uiButton2.Click += ((send, e) =>
            {
                if(uiListBox1.SelectedIndex< macroinstructionClasses.Count)
                macroContent.Textaddress = @"C:\PLCMacroList\MacroList" + macroinstructionClasses[uiListBox1.SelectedIndex].MacroID + ".txt";
                MessageBox.Show(macroContent.TexDelete() ? "删除宏文件成功" : "删除宏文件失败");
                MacroLoad();
            });
            //-----------用户点击项-----------------------
            this.uiListBox1.ItemDoubleClick+=(async (sender, e) =>
            {
                if (this.uiListBox1.SelectedIndex < 0) return;
                new MacroinstructionForm(macroinstructionClasses[uiListBox1.SelectedIndex]).ShowDialog();
                macroContent.Textaddress = @"C:\PLCMacroList\MacroList" + macroinstructionClasses[uiListBox1.SelectedIndex].MacroID + ".txt";
                await macroContent.TextWrite(new JavaScriptSerializer().Serialize(macroinstructionClasses[uiListBox1.SelectedIndex]));
                MacroLoad();
            });
            async void  MacroLoad()
            {
                macroinstructionClasses.Clear();
                this.uiListBox1.Items.Clear();
                string[] filenames = Directory.GetFiles(@"C:\PLCMacroList", "*.txt", SearchOption.AllDirectories);
                //遍历文件夹下面的.txt文本
                foreach (string filename in filenames)
                {
                    macroContent.Textaddress = @filename;
                    if (!File.Exists(macroContent.Textaddress)) continue;
                    //读取宏指令内容 
                    var Content = await macroContent.TextRead(macroContent.Textaddress);
                    if (Content == null) continue;
                    //反序列化
                    foreach (var ix in Content)
                    {
                        var ContentOop = new JavaScriptSerializer().Deserialize<MacroinstructionClass>(ix);
                        if (ContentOop != null)
                        {
                            macroinstructionClasses.Add(ContentOop);
                        }
                    }
                }
                this.uiListBox1.Items.Clear();
                macroinstructionClasses.ForEach(s =>
                {
                    var state = s.Compilestate ? "编译成功" : "未编译/编译失败";
                    this.uiListBox1.Items.Add(s.Name + $"        编译状态：{state}");
                });
            }
        }

    }
}
