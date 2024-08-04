using CSScriptLib;
using Nancy.Json;
using NPOI.SS.Formula.Functions;
using PLC通讯基础控件项目.控件类基.PLC基础接口;
using PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLC报警显示控件实现类;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PLC通讯基础控件项目.宏脚本.接口类基
{
    /// <summary>
    /// 该类用于启动指定宏任务
    /// </summary>
    public  class McaroTaskRun: MacroContent
    {
        /// <summary>
        /// 宏数据
        /// </summary>
        public MacroinstructionClass MyProperty { get; set; }
        /// <summary>
        /// 宏处理标志
        /// </summary>
        protected bool Macrousy { set; get; }

        public McaroTaskRun(string Textaddress) : base(Textaddress)
        {
            this.Address = @Textaddress;
        }
        public async Task<bool> McaroContent(string McaroAddress)
        {
            //拼接路径
            this.Textaddress = @$"C:\PLCMacroList\{McaroAddress}.txt";
            if (IsText())//判断宏文件是否创建
            {
                //读取宏数据
                await Task.Run(async() =>
                 {
                     var Content = this.TextRead(@$"C:\PLCMacroList\{McaroAddress}.txt");
                     if (Content.Result == null) return  ;
                     MyProperty = new JavaScriptSerializer().Deserialize<MacroinstructionClass>(Content.Result[0]);
                 });
                return true; 
            }
            return false;
        }
        /// <summary>
        /// 执行宏任务
        /// </summary>
        /// <returns></returns>
        public async Task<bool> Run()
        {
            if (MyProperty != null)
            {
                await Task.Run(() =>
                {
                    Macrousy = true;
                    Assembly compilemethod = CSScript.RoslynEvaluator.CompileMethod(@MyProperty.Macrocode);
                    var Macroinstructiontype = compilemethod.GetType("css_root+DynamicClass+ScriptCCStatic");
                    var MacroinstructionMethod = Macroinstructiontype.GetMethod("Main");
                    Debug.WriteLine($"正在执行：{@MyProperty.Name}");
                    MacroinstructionMethod.Invoke(null, new object[] { "1" });
                    Debug.WriteLine($"执行完成：{@MyProperty.Name}");
                    Macrousy = false;
                    return true;
                });
            }
            return false;
        }


    }
}
