
namespace PLC通讯基础控件项目.控件类基.控件地址选择窗口.多功能键控件参数界面.类型选择窗口
{
    partial class MultifunctionDForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uiButton2 = new Sunny.UI.UIButton();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.uiTextBox1 = new Sunny.UI.UITextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiTextBox12 = new Sunny.UI.UITextBox();
            this.uiComboBox11 = new Sunny.UI.UIComboBox();
            this.uiComboBox10 = new Sunny.UI.UIComboBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiComboboxEx1 = new Sunny.UI.UIComboboxEx();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiButton2.Location = new System.Drawing.Point(282, 252);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Size = new System.Drawing.Size(84, 38);
            this.uiButton2.TabIndex = 9;
            this.uiButton2.Text = "取消";
            this.uiButton2.Click += new System.EventHandler(this.uiButton2_Click);
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiButton1.Location = new System.Drawing.Point(172, 252);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(84, 38);
            this.uiButton1.TabIndex = 8;
            this.uiButton1.Text = "确定";
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.uiTextBox1);
            this.uiGroupBox1.Controls.Add(this.uiLabel4);
            this.uiGroupBox1.Controls.Add(this.uiTextBox12);
            this.uiGroupBox1.Controls.Add(this.uiComboBox11);
            this.uiGroupBox1.Controls.Add(this.uiComboBox10);
            this.uiGroupBox1.Controls.Add(this.uiLabel3);
            this.uiGroupBox1.Controls.Add(this.uiLabel2);
            this.uiGroupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiGroupBox1.Location = new System.Drawing.Point(4, 75);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Size = new System.Drawing.Size(382, 168);
            this.uiGroupBox1.TabIndex = 7;
            this.uiGroupBox1.Text = "写入";
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiTextBox1
            // 
            this.uiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox1.FillColor = System.Drawing.Color.White;
            this.uiTextBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiTextBox1.HasMaximum = true;
            this.uiTextBox1.HasMinimum = true;
            this.uiTextBox1.Location = new System.Drawing.Point(83, 129);
            this.uiTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox1.Maximum = 2147483647D;
            this.uiTextBox1.MaximumEnabled = true;
            this.uiTextBox1.Minimum = -2147483648D;
            this.uiTextBox1.MinimumEnabled = true;
            this.uiTextBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.Size = new System.Drawing.Size(125, 29);
            this.uiTextBox1.TabIndex = 12;
            this.uiTextBox1.Text = "0";
            this.uiTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox1.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel4.Location = new System.Drawing.Point(19, 130);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(100, 23);
            this.uiLabel4.TabIndex = 11;
            this.uiLabel4.Text = "写入值：";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTextBox12
            // 
            this.uiTextBox12.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox12.FillColor = System.Drawing.Color.White;
            this.uiTextBox12.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiTextBox12.Location = new System.Drawing.Point(193, 85);
            this.uiTextBox12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox12.Maximum = 2147483647D;
            this.uiTextBox12.Minimum = -2147483648D;
            this.uiTextBox12.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTextBox12.Name = "uiTextBox12";
            this.uiTextBox12.Size = new System.Drawing.Size(125, 29);
            this.uiTextBox12.TabIndex = 10;
            this.uiTextBox12.Text = "uiTextBox12";
            this.uiTextBox12.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiComboBox11
            // 
            this.uiComboBox11.DataSource = null;
            this.uiComboBox11.FillColor = System.Drawing.Color.White;
            this.uiComboBox11.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiComboBox11.Location = new System.Drawing.Point(83, 85);
            this.uiComboBox11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox11.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox11.Name = "uiComboBox11";
            this.uiComboBox11.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboBox11.Size = new System.Drawing.Size(106, 29);
            this.uiComboBox11.TabIndex = 9;
            this.uiComboBox11.Text = "uiComboBox11";
            this.uiComboBox11.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiComboBox11.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // uiComboBox10
            // 
            this.uiComboBox10.DataSource = null;
            this.uiComboBox10.FillColor = System.Drawing.Color.White;
            this.uiComboBox10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiComboBox10.Location = new System.Drawing.Point(83, 36);
            this.uiComboBox10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox10.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox10.Name = "uiComboBox10";
            this.uiComboBox10.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboBox10.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiComboBox10.Size = new System.Drawing.Size(265, 29);
            this.uiComboBox10.TabIndex = 8;
            this.uiComboBox10.Text = "uiComboBox10";
            this.uiComboBox10.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiComboBox10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel3.Location = new System.Drawing.Point(35, 88);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(100, 23);
            this.uiLabel3.TabIndex = 7;
            this.uiLabel3.Text = "地址：";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel2.Location = new System.Drawing.Point(35, 39);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(100, 23);
            this.uiLabel2.TabIndex = 6;
            this.uiLabel2.Text = "设备：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiComboboxEx1
            // 
            this.uiComboboxEx1.BackColor = System.Drawing.Color.White;
            this.uiComboboxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.uiComboboxEx1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiComboboxEx1.FormattingEnabled = true;
            this.uiComboboxEx1.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiComboboxEx1.Location = new System.Drawing.Point(227, 43);
            this.uiComboboxEx1.Name = "uiComboboxEx1";
            this.uiComboboxEx1.Size = new System.Drawing.Size(159, 30);
            this.uiComboboxEx1.TabIndex = 6;
            this.uiComboboxEx1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.uiLabel1.Location = new System.Drawing.Point(172, 45);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 23);
            this.uiLabel1.TabIndex = 5;
            this.uiLabel1.Text = "类型：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MultifunctionDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 301);
            this.Controls.Add(this.uiButton2);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.uiGroupBox1);
            this.Controls.Add(this.uiComboboxEx1);
            this.Controls.Add(this.uiLabel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1040);
            this.MinimizeBox = false;
            this.Name = "MultifunctionDForm";
            this.Text = "MultifunctionDForm";
            this.TopMost = true;
            this.uiGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox uiTextBox12;
        private Sunny.UI.UIComboBox uiComboBox11;
        private Sunny.UI.UIComboBox uiComboBox10;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIComboboxEx uiComboboxEx1;
        private Sunny.UI.UILabel uiLabel1;
    }
}