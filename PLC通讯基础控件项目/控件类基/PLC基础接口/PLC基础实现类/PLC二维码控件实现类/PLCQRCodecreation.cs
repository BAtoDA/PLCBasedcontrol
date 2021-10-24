using PLC通讯基础控件项目.控件类基.控件地址选择窗口;
using PLC通讯基础控件项目.控件类基.控件数据结构;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Linq;
using PLC通讯库.通讯基础接口;
using PLC通讯库.通讯实现类;
using PLC通讯库.PLC通讯设备类型表;
using PLC通讯库.通讯枚举;
using Sunny.UI;
using System.Threading.Tasks;

namespace PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLC二维码控件实现类
{
    /// <summary>
    /// 主要通过读取PLC生成二维码以及条形码
    /// </summary>
    public class PLCQRCodecreation
    {
        #region 实现基本接口  
        //基础外部文本颜色 与 内容控制
        /// <summary>
        /// 控件保存的参数
        /// </summary>
        PLCQRcodeBaseRealize pLCQRcodeBaseRealize;
        /// <summary>
        /// 安全控制状态--true正确 false 异常
        /// </summary>
        bool SafetyPattern;
        /// <summary>
        /// 控件对象
        /// </summary>
        Control PlcControl;
        /// <summary>
        /// PLC安全操作模式
        /// </summary>
        volatile Safetypattern PLCsafetypattern = Safetypattern.Nooperation;
        private bool Focused
        {
            get
            {
                PlcControl.BeginInvoke((MethodInvoker)delegate
                {
                    focused = PlcControl.Focused;
                });
                return focused;
            }
        }
        private volatile bool focused;
        #endregion
        public PLCQRCodecreation(Control PlcControl)
        {
            //---------处理控件接口问题---------
            if (!(PlcControl is PLCQRcodeBaseRealize)) throw new Exception($"{PlcControl.GetType().Name} 不实现：PLCQRcodeBaseRealize接口");
            pLCQRcodeBaseRealize = PlcControl as PLCQRcodeBaseRealize;
            this.PlcControl = PlcControl;
            //----------判断是否绑定了触发控件--------------------
            if (this.pLCQRcodeBaseRealize.pLCQRcodeRealize.BindingOpen)
            {
                PLCpublic pLCpublic = new PLCpublic();
                var FormContr = (from Control p in pLCpublic.GetContrForm(PlcControl).Controls where p.Name == this.pLCQRcodeBaseRealize.pLCQRcodeRealize.BindingName select p).FirstOrDefault();
                if (FormContr == null) throw new Exception($"查找{this.pLCQRcodeBaseRealize.pLCQRcodeRealize.BindingOpen}控件失败 \r\n 归属窗口是{pLCpublic.GetContrForm(PlcControl).Parent.GetType().Name}");
                //-----绑定提前触发更新事件 不绑定表示代码层面刷新-----
                FormContr.Click += (async (send, e) =>
                {
                    await PLCWrite(this.pLCQRcodeBaseRealize.pLCQRcodeRealize.WritePLC, this.pLCQRcodeBaseRealize.pLCQRcodeRealize.WriteFunction, this.pLCQRcodeBaseRealize.pLCQRcodeRealize.WriteAddress, true);
                    await PLCrefresh();
                });

            }
        }
        /// <summary>
        /// 刷新二维码
        /// </summary>
        public async Task PLCrefresh()
        {
            await System.Threading.Tasks.Task.Run(() =>
            {
                if (PlcControl.IsDisposed || PlcControl.Created == false) return;
                IPLC_interface PLCoop = IPLCsurface.PLCDictionary.Where(p => p.Key.Trim() == this.pLCQRcodeBaseRealize.pLCQRcodeRealize.ReadWritePLC.ToString().Trim()).FirstOrDefault().Value as IPLCcommunicationBase;
                if (PLCoop == null) return;
                if (!PLCoop.PLC_ready) return;
                var State = PLCoop.PLC_read_D_register(this.pLCQRcodeBaseRealize.pLCQRcodeRealize.ReadWriteFunction, this.pLCQRcodeBaseRealize.pLCQRcodeRealize.ReadWriteAddress, this.pLCQRcodeBaseRealize.pLCQRcodeRealize.ShowFormat);
                if (State.Length < 2)
                    State = "000";
                this.PlcControl.BackgroundImageLayout = ImageLayout.Stretch;//显示方式铺满
                if (this.pLCQRcodeBaseRealize.pLCQRcodeRealize.Select != true)
                    this.PlcControl.BackgroundImage = new IhatetheqrcodeCreate().Generate1(State, this.PlcControl.Size.Width, this.PlcControl.Size.Height);//加载二维码
                else
                    this.PlcControl.BackgroundImage = new IhatetheqrcodeCreate().Generate2(State, this.PlcControl.Size.Width, this.PlcControl.Size.Height);//加载条形码
            });
        }

        /// <summary>
        /// 写入PLC操作
        /// </summary>
        public async Task PLCWrite(PLC IPLC, string Id, string Addary, bool Value)
        {
            if (PlcControl.IsDisposed || PlcControl.Created == false) return;
            await System.Threading.Tasks.Task.Run(() =>
            {
                IPLC_interface PLCoop = IPLCsurface.PLCDictionary.GetValueOrDefault(IPLC.ToString()) as IPLCcommunicationBase;
                if (PLCoop.PLC_ready)
                    PLCoop.PLC_write_M_bit(Id, Addary, (Button_state)Enum.Parse(typeof(Button_state), Value ? "ON" : "Off"));
            });
        }
    }
}
