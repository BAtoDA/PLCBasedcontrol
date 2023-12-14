using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Nancy.Json;
using PLC通讯基础控件项目.宏脚本;
using PLC通讯基础控件项目.宏脚本.接口类基;
using PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLC报警显示控件实现类;
using Sunny.UI;
using System.Linq;
using PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类;
using PLC通讯基础控件项目.控件类基.PLC基础接口;
using System.Windows.Forms;

namespace PLC通讯基础控件项目.控件类基.控件地址选择窗口
{
    /// <summary>
    /// 该类主要用于加载宏指令
    /// 编辑窗口的属性 以及内容 不进行保持操作
    /// </summary>
    internal class PLCmacrosClass
    {
        /// <summary>
        /// 保存宏指令文本类
        /// </summary>
        MacroContent macroContent;
        /// <summary>
        /// 宏指令列表
        /// </summary>
        List<MacroinstructionClass> macroinstructionClasses = new List<MacroinstructionClass>();
        /// <summary>
        /// 构造函数
        /// 加载窗口数据
        /// </summary>
        /// <param name="macroinstructionInterfac"></param>
        public PLCmacrosClass(UITextBox NumberingTextBox, UITextBox NameTextBox, UIRichTextBox MacrocodeRichTextBox, 
            UIComboboxEx macrosTxtList, dynamic pLCBitselect)
        {
            //-------------------加载参数-----------------------------
            NumberingTextBox.Text = pLCBitselect.macroID.ToString();
            NameTextBox.Text = pLCBitselect.MacroName ?? this.GetType().Name;
            MacrocodeRichTextBox.Text = pLCBitselect.Macrocode ?? "using CSScriptLib; \r\n" +
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
        }
        /// <summary>
        /// 加载宏文件
        /// </summary>
        /// <param name="NumberingTextBox"></param>
        /// <param name="NameTextBox"></param>
        /// <param name="MacrocodeRichTextBox"></param>
        /// <param name="macrosTxtList"></param>
        /// <returns></returns>
        public async Task MacroLoad(UITextBox NumberingTextBox, UITextBox NameTextBox, UIRichTextBox MacrocodeRichTextBox, UIComboboxEx macrosTxtList,
            UIComboboxEx EventList, UIButton button, dynamic pLCBitselect)
        {
            macrosTxtList.KeyPress += ((sender, e) =>
              {
                  e.Handled = true;
              });
            EventList.KeyPress+=((sender, e) =>
            {
                e.Handled= true;
            });
            macroinstructionClasses.Clear();
            macrosTxtList.Items.Clear();
            macroContent = new MacroContent(@"C:\");
            string[] filenames = new string[1] { "" };
            if (!macroContent.IsDirectory())
            {
               // macroContent.DirectoryCreate();
               new UIMessageForm().ShowErrorDialog($"当前路径：@\"C:\\PLCMacroList\", \"*.txt\"为创建宏文件.\r\n" +
                   $"请在项目窗口控件添加：DAMacroControl宏控件后运行软件右键添加宏指令编译成功后正常使用宏绑定",true);
            }
            else
            {
                filenames = Directory.GetFiles(@"C:\PLCMacroList", "*.txt", SearchOption.AllDirectories);
            }
         
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
                        //if (ContentOop.Compilestate)
                            macroinstructionClasses.Add(ContentOop);
                    }
                }
            }
            //-----------加载选项------------
            macroinstructionClasses.ForEach(s => { macrosTxtList.Items.Add(s.Name + s.MacroID); });
            //-----------加载可绑定事件------------------
            EventList.Items.Add("不使用");
            new EventCreateClass().EventName(new Control()).ForEach(s => { EventList.Items.Add(s.Name); });
            EventList.SelectedIndex = 0;
            //-----------加载下拉选项改变内容-----------------
            macrosTxtList.SelectedIndexChanged += ((send, e) =>
              {
                  if (macrosTxtList.SelectedIndex > -1)
                  {
                      NumberingTextBox.Text = macroinstructionClasses[macrosTxtList.SelectedIndex].MacroID.ToString();
                      NameTextBox.Text = macroinstructionClasses[macrosTxtList.SelectedIndex].Name;
                      MacrocodeRichTextBox.Text = macroinstructionClasses[macrosTxtList.SelectedIndex].Macrocode;
                  }
              });
            //-----------恢复之前选项------------------------
            EventList.Text = pLCBitselect.MacroEvent;
            macrosTxtList.Text = pLCBitselect.MacroName + pLCBitselect.macroID;
            if (macroinstructionClasses.Where(p => p.MacroID == pLCBitselect.macroID).FirstOrDefault() != null)
            {
                var macro = macroinstructionClasses.Where(p => p.MacroID == pLCBitselect.macroID).First();
                NumberingTextBox.Text = macro.MacroID.ToString();
                NameTextBox.Text = macro.Name;
                MacrocodeRichTextBox.Text = macro.Macrocode;
                macrosTxtList.Text = macro.Name + macro.MacroID.ToString();
            }
            else
            {
                NumberingTextBox.Text = "Null";
                NameTextBox.Text = "Null";
                MacrocodeRichTextBox.Text = "Null";
                macrosTxtList.Text= "Null";
            }
            NumberingTextBox.Text = pLCBitselect.macroID.ToString();
            NameTextBox.Text = pLCBitselect.MacroName;
            MacrocodeRichTextBox.Text = pLCBitselect.Macrocode;
            //macrosTxtList.Text = pLCBitselect.MacroName + pLCBitselect.macroID.ToString();
            //----------进行保存操作--------------------------
            button.Click += ((send, e) =>
              {
                  if (macroinstructionClasses.Where(p => p.MacroID == Convert.ToInt16(NumberingTextBox.Text)).FirstOrDefault() != null)
                  {
                      var Data = macroinstructionClasses.Where(p => p.MacroID == Convert.ToInt16(NumberingTextBox.Text)).First();
                      pLCBitselect.macroID = Data.MacroID;
                      pLCBitselect.MacroName = Data.Name;
                      pLCBitselect.Macrocode = Data.Macrocode;
                      pLCBitselect.Compilestate = Data.Compilestate;
                  }
                  pLCBitselect.MacroEvent = EventList.Text;
              });
        }

    }
}
