using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLC报警显示控件实现类
{
    /// <summary>
    /// 自动保存报警日志
    /// 
    /// </summary>
    class PLCEventAutoContent: PLCEventContent
    {
        private string Address;
        public PLCEventAutoContent(string Textaddress) :base(Textaddress)
        {
            this.Address = @Textaddress;
            this.Textaddress = Textaddress +"\\PLCEventErr\\"+DateTime.Now.ToString("D")+".txt";
        }
        /// <summary>
        /// 异步读取当天报警历史
        /// </summary>
        /// <returns></returns>
        public async Task<string[]> TextRead()
        {
            try
            {
                return await File.ReadAllLinesAsync(@Textaddress, Encoding.UTF8);
            }
            catch { return new string[] { "" }; };
        }
        /// <summary>
        /// 异步读取当天报警历史
        /// </summary>
        /// <returns></returns>
        public async Task<string[]> TextRead(string Textaddress)
        {
            try
            {
                return await File.ReadAllLinesAsync(@Textaddress, Encoding.UTF8);
            }
            catch { return new string[] { "" }; };
        }
        /// <summary>
        /// 异步写入当前PLC报警类历史内容
        /// 追加一行文本内容
        /// </summary>
        /// <param name="Content"></param>
        /// <returns></returns>
        public override async Task TextWrite(string Content)
        {
            //File.AppendAllLines(@Textaddress, new List<string>() { Content });
            await File.AppendAllLinesAsync(@Textaddress, new List<string>() { Content });
        }
        /// <summary>
        /// 自动创建文件夹
        /// </summary>
        /// <returns></returns>
        public override bool TextCreate()
        {
            //先判定文件夹是否存在
            if (!Directory.Exists(@Address + "\\PLCEventErr"))
            {
                AddSecurityControll2Folder(@Address);
                string Addressq =this.Address + "\\PLCEventErr";
                var fileInfo = Directory.CreateDirectory(@Addressq);
            }
            if (!File.Exists(@Textaddress) & Directory.Exists(@Address + "\\PLCEventErr"))
            {
                AddSecurityControll2Folder(@Address + "\\PLCEventErr");
                using var fileInfo = new FileInfo(@Textaddress).Create();
            }
            return true;
        }
        /// <summary>
        /// 判定文件夹以及文本是否创建
        /// </summary>
        /// <returns></returns>
        public override bool IsText()
        {
            try
            {
                //先判定文件夹是否存在
                return Directory.Exists(@Address + "\\PLCEventErr") & File.Exists(@Textaddress) ? true : false;
            }
            catch
            {
                return false;
            }
        }
    }
}
