using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;


namespace PLC通讯基础控件项目.基础控件.宏指令控件
{
    /// <summary>
    /// 宏指令控件
    /// </summary>
    internal class MacroControl:Timer
    {
        private IContainer _Designer;
        public MacroControl(IContainer container)
        {
            //-----------检查重复性------------
            this._Designer = container;
            foreach (var i in container.Components)
            {
                if (i is MacroControl) throw new Exception("该控件已经存在无需重复添加");
            }
            container.Add(this);


        }
        protected override void OnTick(EventArgs e)
        {
            base.OnTick(e);
            this.Stop();
            //-----------处理任务-------------

        }
    }
}
