using System;
using System.Collections.Generic;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLC报警显示控件实现类
{
    /// <summary>
    /// 自动保存宏指令
    /// </summary>
    public class MacroContent
    {
        #region 字段
        public string Textaddress;
        private string Address;
        #endregion
        public MacroContent(string Textaddress)
        {
            this.Address = @Textaddress;
           // this.Textaddress = Textaddress + "\\PLCMacroList\\" + $"{Name}.txt";
        }
        /// <summary>
        /// 异步读取宏指令文件
        /// </summary>
        /// <returns></returns>
        public async Task<string[]> TextRead()
        {
            try
            {
                var Data = await File.ReadAllLinesAsync(@Textaddress, Encoding.UTF8);
                return Data;
            }
            catch { return new string[] { }; };
        }
        /// <summary>
        /// 异步读取宏指令文件
        /// </summary>
        /// <returns></returns>
        public async Task<string[]> TextRead(string Textaddress)
        {
            try
            {
                //using (StreamReader fsRead = new StreamReader(@Textaddress, Encoding.UTF8))
                //{
                //   return await fsRead.ReadLineAsync();
                //}
                return await File.ReadAllLinesAsync(@Textaddress, Encoding.UTF8);
                //var Data = await File.ReadAllLinesAsync(@Textaddress, Encoding.UTF8);
                //return Data;
            }
            catch { return null; };
        }
        /// <summary>
        /// 异步写入当前宏指令文件
        /// 覆盖内容
        /// </summary>
        /// <param name="Content"></param>
        /// <returns></returns>
        public async Task TextWrite(string Content)
        {
            try
            {
                await File.WriteAllTextAsync(@Textaddress, Content);
            }
            catch { }
        }
        /// <summary>
        /// 移除宏文本
        /// </summary>
        /// <returns></returns>
        public bool TexDelete()
        {
            try
            {
                AddSecurityControll2Folder(@Textaddress);
                File.Delete(@Textaddress);
                return true;
            }
            catch { return false; }
        }
        /// <summary>
        /// 自动创建文件夹
        /// </summary>
        /// <returns></returns>
        public bool TextCreate()
        {
            try
            {
                //先判定文件夹是否存在
                if (!Directory.Exists(@Address + "\\PLCMacroList"))
                {
                    AddSecurityControll2Folder(@Address);
                    string Addressq = this.Address + "\\PLCMacroList";
                    var fileInfo = Directory.CreateDirectory(@Addressq);
                }
                if (!File.Exists(@Textaddress) & Directory.Exists(@Address + "\\PLCMacroList"))
                {
                    AddSecurityControll2Folder(@Address + "\\PLCMacroList");
                    using var fileInfo = new FileInfo(@Textaddress).Create();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// 自动创建文件夹
        /// </summary>
        /// <returns></returns>
        public bool DirectoryCreate()
        {
            try
            {
                //先判定文件夹是否存在
                if (!Directory.Exists(@Address + "\\PLCMacroList"))
                {
                    AddSecurityControll2Folder(@Address);
                    string Addressq = this.Address + "\\PLCMacroList";
                    var fileInfo = Directory.CreateDirectory(@Addressq);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// 判定文件夹以及文本是否创建
        /// </summary>
        /// <returns></returns>
        public bool IsText()
        {
            try
            {
                //先判定文件夹是否存在
                return Directory.Exists(@Address + "\\PLCMacroList") & File.Exists(@Textaddress) ? true : false;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// 判定文件夹以及文本是否创建
        /// </summary>
        /// <returns></returns>
        public bool IsDirectory()
        {
            try
            {
                //先判定文件夹是否存在
                return Directory.Exists(@Address + "\\PLCMacroList") ? true : false;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        ///为文件夹添加users，everyone用户组的完全控制权限
        /// </summary>
        /// <param name="dirPath"></param>
        public void AddSecurityControll2Folder(string dirPath)
        {
            try
            {
                //获取文件夹信息
                DirectoryInfo dir = new DirectoryInfo(dirPath);
                //获得该文件夹的所有访问权限
                System.Security.AccessControl.DirectorySecurity dirSecurity = dir.GetAccessControl(AccessControlSections.Access);
                //设定文件ACL继承
                InheritanceFlags inherits = InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit;
                //添加ereryone用户组的访问权限规则 完全控制权限
                FileSystemAccessRule everyoneFileSystemAccessRule = new FileSystemAccessRule("Everyone", FileSystemRights.FullControl, inherits, PropagationFlags.None, AccessControlType.Allow);
                //添加Users用户组的访问权限规则 完全控制权限
                FileSystemAccessRule usersFileSystemAccessRule = new FileSystemAccessRule("Users", FileSystemRights.FullControl, inherits, PropagationFlags.None, AccessControlType.Allow);
                bool isModified = false;
                dirSecurity.ModifyAccessRule(AccessControlModification.Add, everyoneFileSystemAccessRule, out isModified);
                dirSecurity.ModifyAccessRule(AccessControlModification.Add, usersFileSystemAccessRule, out isModified);
                //设置访问权限
                dir.SetAccessControl(dirSecurity);
            }
            catch { }
        }
        /// <summary>
        /// 判断当前是否开启了管理员权限
        /// </summary>
        /// <returns></returns>
        public bool IsAdministrator()
        {
            try
            {
                WindowsIdentity identity = WindowsIdentity.GetCurrent();
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                return principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
            catch { return false; }
        }
    }
}
