using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PLC通讯库;
using PLC通讯库.通讯实现类;
using System.Net;
using HslCommunication.Profinet.Melsec;

namespace PLC通讯基础控件项目
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IPLCcommunicationBase iPLCcommunicationBase = new IPLCcommunicationBase(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 4999), new MelsecMcNet());
            iPLCcommunicationBase.PLC_open();
        }
    }
}
