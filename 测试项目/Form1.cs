using System.Text;
using System.Linq;
using PLC通讯库.发那科机器人通讯实现;
using System.Net.Sockets;
using System.Net;
using NPOI.SS.Formula.Functions;
using Sunny.UI;
using PLC通讯基础控件项目.控件类基.控件地址选择窗口;

namespace 测试项目
{
    public partial class Form1 : UIForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //  new PLCpropertyBit(this.daButton1.pLCBitselectRealize).Show();
        }
        FanucRobot.FanucRobIntelface Robot1;
        /// <summary>
        /// 链接机器人
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton1_Click(object sender, EventArgs e)
        {
            //测试用户是否输入了IP
            var IPEnd = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9500);
            if (IPEndPoint.TryParse(this.uiTextBox1.Text ?? "", out IPEnd))
            {
                Robot1 = new FanucRobot.FanucRobIntelface(IPEnd.Address.ToString());
                var OpenResul = Robot1.Connect();
                if (Robot1.isConnected)
                    Robotlog("打开成功");
                else
                    Robotlog("打开失败");
                Robot1.SocketRead += ((send, e) =>
                {
                    Robotlog(BitConverter.ToString((byte[])send));
                });
                Robot1.Socketsedn += ((send, e) =>
                {
                    Robotlog(BitConverter.ToString((byte[])send));
                });
            }
            else
                Robotlog($"输入文本{this.uiTextBox1.Text}不是一个有效的IP");
        }
        /// <summary>
        /// 关闭机器人
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton2_Click(object sender, EventArgs e)
        {
            if (Robot1 != null && Robot1.isConnected)
            {
                Robot1.Disconnect();
            }
        }
        /// <summary>
        /// 写入PR
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton4_Click(object sender, EventArgs e)
        {
            if (Robot1.isConnected)
            {
                Robot1.WritePR(new FanucRobot.PR { pc = new float[] { 1, 2, 3, 4, 5, 6 } }, 30);
            }
        }
        /// <summary>
        /// 刷新坐标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiButton8_Click(object sender, EventArgs e)
        {
            if (Robot1.isConnected)
            {
                Robot1.Refresh();
            }
        }
        /// <summary>
        /// 输出日志
        /// </summary>
        /// <param name="ErrData"></param>
        private void Robotlog(string ErrData)
        {
            this.BeginInvoke(new Action(() => { this.richTextBox1.AppendText(DateTime.Now.ToString() + ErrData + "\r\n"); }));
        }


        public static readonly bool IsLittleEndian = true;
        unsafe public static int TestInt16(byte[] value, int startIndex)
        {
            fixed (byte* ptr = &value[startIndex])
            {
                if (startIndex % 2 == 0)
                {
                    return *(short*)ptr;
                }

                if (IsLittleEndian)
                {
                    return (short)(*ptr | (ptr[1] << 8));
                }

                return (short)((*ptr << 8) | ptr[1]);
            }
        }

        private void uiLedBulb1_Click(object sender, EventArgs e)
        {

        }

    }
}