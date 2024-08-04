using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSScriptLib;
using Nancy.Json;
using PLC通讯基础控件项目.宏脚本.宏对象池;
using PLC通讯基础控件项目.宏脚本.接口类基;
using PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLC报警显示控件实现类;
using Sunny.UI;
using Timer = System.Windows.Forms.Timer;
using System.Linq;
using System.Diagnostics;

namespace PLC通讯基础控件项目.基础控件.宏指令控件
{
    /// <summary>
    /// 宏指令控件
    /// </summary>
    [ToolboxItem(true)]
    [Description("宏指令控件")]
    public class DAMacroControl : Control
    {
        #region 控件字段
        /// <summary>
        /// 窗口设计器传入
        /// </summary>
        private IContainer _Designer;
        /// <summary>
        /// 判断是否已经加载
        /// </summary>
        private bool IsLoad = false;
        /// <summary>
        /// 宏指令链表
        /// </summary>
        List<MacroinstructionClass> macroinstructionClasses = new List<MacroinstructionClass>();
        /// <summary>
        /// 异步线程任务取消令牌
        /// </summary>
        CancellationTokenSource tokenSource = new CancellationTokenSource();
        CancellationToken token;
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
        /// 宏指令任务处理定时器
        /// </summary>
        private Timer MacroTimer = new Timer() { Interval = 1000, Enabled = true };
        #endregion
        public DAMacroControl(IContainer container)
        {
            //-----------检查重复性------------
            this._Designer = container;
            foreach (var i in container.Components)
            {
                if (i is DAMacroControl) throw new Exception("该控件已经存在无需重复添加");
            }
            container.Add(this);

            token = tokenSource.Token;
            MacroTimer.Start();
            MacroTimer.Tick += OnTick;
        }
        protected async void OnTick(object send, EventArgs e)
        {
            MacroTimer.Stop();
            //---------判断是否在设计初期--------
            if (DesignMode || !PLC_Enable) return;
            //-----------处理任务-------------
            if (!IsLoad)
            {
                //获取本类的顶级窗口Form
                var FormOop = WhileForm();
                if (FormOop == null)
                {
                    MacroTimer.Start();
                    return;
                }
                //-------添加右键宏指令----
                UIContextMenuStrip uIContextMenuStrip = new UIContextMenuStrip()
                {
                    Name = "contextMenuStrip1",
                    Size = new System.Drawing.Size(193, 48)
                };

                ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem()
                {
                    Size = new System.Drawing.Size(192, 22),
                    Text = "宏指令编辑"
                };
                if (FormOop.ContextMenuStrip != null)
                {
                    FormOop.ContextMenuStrip.Items.Add(toolStripMenuItem);
                }
                else
                {
                    uIContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
                    {
                     toolStripMenuItem
                    });
                    FormOop.ContextMenuStrip = uIContextMenuStrip;
                }
                //-----分配对象池---------

                Func<Task> func = new Func<Task>(() =>
                {
                    return new Task(MacroTask, token);
                });
                MacroObjectPool<Task> objectPool = new MacroObjectPool<Task>(
         20, func);
                //-----处理宏任务-----
                //await MacroLoad();
                //-----处理用户打开宏窗口停止运行任务-----
                toolStripMenuItem.Click += (async (s, e) =>
                  {
                      //终止运行任务
                      tokenSource.Cancel();
                      //打开宏列表窗口
                      new MacroListForm().ShowDialog();
                      //重新开放令牌
                      tokenSource = new CancellationTokenSource();
                      token=tokenSource.Token;
                      //修改完成继续运行任务
                      //await MacroLoad();
                  });
                IsLoad = true;
                void MacroTask()
                {

                }
            }
            async Task MacroLoad()
            {
                await Task.Run(async () =>
                {
                    macroinstructionClasses.Clear();
                    //-----------读取宏指令保存参数----------------
                    MacroContent macroContent = new MacroContent(@"C:\");//实例化
                    if (!macroContent.IsDirectory())
                        macroContent.DirectoryCreate();
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

                    macroinstructionClasses.ForEach( s =>
                    {
                        var state = s.Compilestate ? "编译成功" : "未编译/编译失败";
                        //判断是否程序已经编译  已经启动运行选择||循环运行选择是否选中
                        if (s.Compilestate & (s.FormShowLoad || s.Period))
                        {
                            //向对象池申请 
                            var Poss = MacroObjectPool<Task>.GetObject();
                            Poss = Task.Run(() =>
                            {
                                //开始执行任务
                                Debug.WriteLine($"执行宏任务：{s.MacroID} {s.Name}");
                                try
                                {

                                Missioncontinue:
                                    //是否取消任务
                                    if (token.IsCancellationRequested || s.Macrocode == null || s.Macrocode == "") return;

                                    Assembly compilemethod = CSScript.RoslynEvaluator.CompileMethod(s.Macrocode);
                                    var Macroinstructiontype = compilemethod.GetType("css_root+DynamicClass+ScriptCCStatic");
                                    var MacroinstructionMethod = Macroinstructiontype.GetMethod("Main");
                                    MacroinstructionMethod.Invoke(null, new object[] { "1" });
                                    if (s.Period) goto Missioncontinue;
                                }
                                catch
                                {
                                    return;//异常任务终结
                                }
                                finally
                                {
                                    MacroObjectPool<Task>.PutObject(Poss);
                                }
                            }, token);
                            //Poss.Wait();
                        }
                    });
                });
            }
        }
        Form WhileForm()
        {
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
            return (Form)Oop;
        }
    }
}
