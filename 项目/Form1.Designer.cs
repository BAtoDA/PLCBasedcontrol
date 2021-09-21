
namespace 项目
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.daPlcFunction1 = new PLC通讯基础控件项目.基础控件.底层PLC状态监控控件.DAPlcFunction();
            this.plcControlsPreferences1 = new PLC通讯基础控件项目.PLCControlsPreferences(this.components);
            this.plcPreferences2 = new PLC通讯基础控件项目.PLC参数设置控件.PLCPreferences();
            this.plcPreferences1 = new PLC通讯基础控件项目.PLC参数设置控件.PLCPreferences();
            this.plcPreferences3 = new PLC通讯基础控件项目.PLC参数设置控件.PLCPreferences();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // daPlcFunction1
            // 
            this.daPlcFunction1.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.daPlcFunction1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.daPlcFunction1.FillColor = System.Drawing.Color.Gray;
            this.daPlcFunction1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daPlcFunction1.FormName = "主页面";
            this.daPlcFunction1.FormPath = "PLC通讯基础控件项目.模板与控制界面";
            this.daPlcFunction1.Location = new System.Drawing.Point(240, 274);
            this.daPlcFunction1.MinimumSize = new System.Drawing.Size(1, 1);
            this.daPlcFunction1.Name = "daPlcFunction1";
            this.daPlcFunction1.PLC_Enable = true;
            this.daPlcFunction1.Size = new System.Drawing.Size(172, 74);
            this.daPlcFunction1.Style = Sunny.UI.UIStyle.Custom;
            this.daPlcFunction1.TabIndex = 0;
            this.daPlcFunction1.Text = "进入主界面";
            this.daPlcFunction1.Click += new System.EventHandler(this.daPlcFunction1_Click);
            // 
            // plcControlsPreferences1
            // 
            this.plcControlsPreferences1.Enabled = true;
            this.plcControlsPreferences1.Interval = 1000;
            this.plcControlsPreferences1.PLCPreferences.Add(this.plcPreferences2);
            this.plcControlsPreferences1.PLCPreferences.Add(this.plcPreferences1);
            this.plcControlsPreferences1.PLCPreferences.Add(this.plcPreferences3);
            // 
            // plcPreferences2
            // 
            this.plcPreferences2.IPEnd = "192.168.0.11";
            this.plcPreferences2.PLCDevice = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Siemens;
            this.plcPreferences2.Point = 102;
            this.plcPreferences2.Receptionovertime = 1000;
            this.plcPreferences2.Retain = "S1500";
            this.plcPreferences2.Sendovertime = 1000;
            // 
            // plcPreferences1
            // 
            this.plcPreferences1.IPEnd = "127.0.0.1";
            this.plcPreferences1.PLCDevice = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.plcPreferences1.Point = 2000;
            this.plcPreferences1.Receptionovertime = 1000;
            this.plcPreferences1.Retain = "S1500";
            this.plcPreferences1.Sendovertime = 1000;
            // 
            // plcPreferences3
            // 
            this.plcPreferences3.IPEnd = "192.168.1.10";
            this.plcPreferences3.PLCDevice = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Modbus_TCP;
            this.plcPreferences3.Point = 8000;
            this.plcPreferences3.Receptionovertime = 1000;
            this.plcPreferences3.Retain = "S1500";
            this.plcPreferences3.Sendovertime = 1000;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(1, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(644, 357);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "c443eb6298f8c3b19ca5a16ac782ca3f.jpeg");
            this.imageList1.Images.SetKeyName(1, "3b31a8d12f1bd16f60085c8d2fa6a611.jpeg");
            this.imageList1.Images.SetKeyName(2, "170a7e99e7ede025490fdd412056699f.jpeg");
            this.imageList1.Images.SetKeyName(3, "71093f82045f191894b7071960fb473c.jpeg");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(647, 360);
            this.ControlBox = false;
            this.Controls.Add(this.daPlcFunction1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PLC通讯基础控件项目.基础控件.底层PLC状态监控控件.DAPlcFunction daPlcFunction1;
        private PLC通讯基础控件项目.PLCControlsPreferences plcControlsPreferences1;
        private PLC通讯基础控件项目.PLC参数设置控件.PLCPreferences plcPreferences1;
        private PLC通讯基础控件项目.PLC参数设置控件.PLCPreferences plcPreferences2;
        private PLC通讯基础控件项目.PLC参数设置控件.PLCPreferences plcPreferences3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList imageList1;
    }
}

