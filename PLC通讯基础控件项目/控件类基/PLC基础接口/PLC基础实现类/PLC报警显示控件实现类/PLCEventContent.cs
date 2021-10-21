using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLC报警显示控件实现类
{
    /// <summary>
    /// 读取以及写入PLC报警类
    /// 写入路径默认在Debug/PLCEventErr文件夹下
    /// </summary>
    public  class PLCEventContent
    {
        protected string Textaddress;
        public PLCEventContent(string Textaddress) => this.@Textaddress = @Textaddress;
        /// <summary>
        /// 异步读取当前PLC报警类设置参数
        /// </summary>
        /// <returns></returns>
        public virtual async Task<string> TextRead()
        {
            using StreamReader TextReader = new StreamReader(@Textaddress, Encoding.UTF8);
            return await TextReader.ReadToEndAsync();
        }
        /// <summary>
        /// 异步写入当前PLC报警类设置参数
        /// 自动覆盖当前文本内容
        /// </summary>
        /// <param name="Content"></param>
        /// <returns></returns>
        public virtual async Task TextWrite(string Content)
        {
            await Task.Run(() =>
            {
                File.WriteAllText(@Textaddress, Content);
                return true;
            });
        }
        /// <summary>
        /// 创建文本
        /// </summary>
        /// <returns></returns>
        public virtual bool TextCreate()
        {
            //先判定文件夹是否存在
            if (!Directory.Exists(System.IO.Directory.GetCurrentDirectory() + "\\PLCEventErr"))
            {
                string Address= System.IO.Directory.GetCurrentDirectory() + "\\PLCEventErr";
                var fileInfo = Directory.CreateDirectory(@Address);
            }
            if (!File.Exists(@Textaddress)&Directory.Exists(System.IO.Directory.GetCurrentDirectory() + "\\PLCEventErr"))
            {
                using var fileInfo = new FileInfo(@Textaddress).Create();
            }
            return true;
        }
        /// <summary>
        /// 判定文件是否存在
        /// </summary>
        public virtual bool IsText()
        {
            try
            {
                //先判定文件夹是否存在
                return Directory.Exists(System.IO.Directory.GetCurrentDirectory() + "\\PLCEventErr") & File.Exists(@Textaddress) ? true : false;
            }
            catch
            {
                return false;
            }
        }
    }
}
