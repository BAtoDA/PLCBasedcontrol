using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 项目
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void daPlcFunction1_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
            this.Hide();
        }
        int ImgeIndex = 0;
        /// <summary>
        /// 启动界面UI 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if ( ImgeIndex >= this.imageList1.Images.Count)
            {
                ImgeIndex = 0;
                return;
            }
            this.pictureBox1.Image = this.imageList1.Images[ImgeIndex];
            ImgeIndex += 1;
        }
    }
}
