using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Security.AccessControl;
using System.Security.Principal;

namespace PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLC报警显示控件实现类
{
    /// <summary>
    /// 读取以及写入PLC报警类
    /// 写入路径默认在Debug/PLCEventErr文件夹下
    /// </summary>
    public  class PLCEventContent
    {
        protected string Textaddress;
        private string Address;
        public PLCEventContent(string Textaddress)
        {
            this.Address = @Textaddress;
            this.@Textaddress = @Textaddress+ "\\PLCEventErr\\PLCErr.txt";
        }
        /// <summary>
        /// 异步读取当前PLC报警类设置参数
        /// </summary>
        /// <returns></returns>
        public virtual async Task<string> TextRead()
        {
            try
            {
                using StreamReader TextReader = new StreamReader(@Textaddress, Encoding.UTF8);
                return await TextReader.ReadToEndAsync();
            }
            catch { return ""; }
        }
        /// <summary>
        /// 异步写入当前PLC报警类设置参数
        /// 自动覆盖当前文本内容
        /// </summary>
        /// <param name="Content"></param>
        /// <returns></returns>
        public virtual async Task TextWrite(string Content)
        {
            try
            {
                //File.WriteAllText(@Textaddress, Content);
                await File.WriteAllTextAsync(@Textaddress, Content);
            }
            catch { }
        }
        /// <summary>
        /// 创建文本
        /// </summary>
        /// <returns></returns>
        public virtual bool TextCreate()
        {
            //先判定文件夹是否存在
            if (!Directory.Exists(@Address+ "\\PLCEventErr"))
            {
                //if (!IsAdministrator()) throw new Exception("当前用户无权限创建");
                //向系统申请权限
                AddSecurityControll2Folder(@Address);
                var fileInfo = Directory.CreateDirectory(@Address+ "\\PLCEventErr");
            }
            if (!File.Exists(@Textaddress)&Directory.Exists(@Address+ "\\PLCEventErr"))
            {
                //向系统申请权限
                AddSecurityControll2Folder(@Address + "\\PLCEventErr");
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
                return Directory.Exists(@Address+ "\\PLCEventErr") & File.Exists(@Textaddress) ? true : false;
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
        /// <summary>
        /// 判断当前是否开启了管理员权限
        /// </summary>
        /// <returns></returns>
        public  bool IsAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }
    }
}
