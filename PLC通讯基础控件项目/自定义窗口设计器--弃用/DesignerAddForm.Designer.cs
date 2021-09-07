
namespace PLC通讯基础控件项目.自定义窗口设计器
{
    partial class DesignerAddForm
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
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.uiTextBox4 = new Sunny.UI.UITextBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiTextBox3 = new Sunny.UI.UITextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiTextBox2 = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiComboboxEx1 = new Sunny.UI.UIComboboxEx();
            this.uiTextBox1 = new Sunny.UI.UITextBox();
            this.uiComboBox1 = new Sunny.UI.UIComboBox();
            this.uiGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel1.Location = new System.Drawing.Point(44, 51);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 23);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "PLC类型:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel2.Location = new System.Drawing.Point(44, 92);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(100, 23);
            this.uiLabel2.TabIndex = 2;
            this.uiLabel2.Text = "IP地址:";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiGroupBox1.Controls.Add(this.uiButton2);
            this.uiGroupBox1.Controls.Add(this.uiButton1);
            this.uiGroupBox1.Controls.Add(this.uiTextBox4);
            this.uiGroupBox1.Controls.Add(this.uiLabel5);
            this.uiGroupBox1.Controls.Add(this.uiTextBox3);
            this.uiGroupBox1.Controls.Add(this.uiLabel4);
            this.uiGroupBox1.Controls.Add(this.uiTextBox2);
            this.uiGroupBox1.Controls.Add(this.uiLabel3);
            this.uiGroupBox1.Controls.Add(this.uiComboboxEx1);
            this.uiGroupBox1.Controls.Add(this.uiTextBox1);
            this.uiGroupBox1.Controls.Add(this.uiLabel2);
            this.uiGroupBox1.Controls.Add(this.uiLabel1);
            this.uiGroupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiGroupBox1.Location = new System.Drawing.Point(4, 40);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Size = new System.Drawing.Size(332, 313);
            this.uiGroupBox1.TabIndex = 0;
            this.uiGroupBox1.Text = "PLC参数";
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiGroupBox1.TitleAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiButton2.Location = new System.Drawing.Point(198, 259);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Size = new System.Drawing.Size(100, 35);
            this.uiButton2.TabIndex = 12;
            this.uiButton2.Text = "取消";
            this.uiButton2.Click += new System.EventHandler(this.uiButton2_Click);
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiButton1.Location = new System.Drawing.Point(45, 259);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(100, 35);
            this.uiButton1.TabIndex = 11;
            this.uiButton1.Text = "确定";
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // uiTextBox4
            // 
            this.uiTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox4.DoubleValue = 10000D;
            this.uiTextBox4.FillColor = System.Drawing.Color.White;
            this.uiTextBox4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiTextBox4.HasMaximum = true;
            this.uiTextBox4.HasMinimum = true;
            this.uiTextBox4.IntValue = 10000;
            this.uiTextBox4.Location = new System.Drawing.Point(127, 207);
            this.uiTextBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox4.Maximum = 2147483647D;
            this.uiTextBox4.MaximumEnabled = true;
            this.uiTextBox4.Minimum = 10000D;
            this.uiTextBox4.MinimumEnabled = true;
            this.uiTextBox4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTextBox4.Name = "uiTextBox4";
            this.uiTextBox4.Size = new System.Drawing.Size(150, 29);
            this.uiTextBox4.TabIndex = 10;
            this.uiTextBox4.Text = "10000";
            this.uiTextBox4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox4.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel5.Location = new System.Drawing.Point(29, 210);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(133, 23);
            this.uiLabel5.TabIndex = 9;
            this.uiLabel5.Text = "Receive超时:";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTextBox3
            // 
            this.uiTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox3.DoubleValue = 10000D;
            this.uiTextBox3.FillColor = System.Drawing.Color.White;
            this.uiTextBox3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiTextBox3.HasMaximum = true;
            this.uiTextBox3.HasMinimum = true;
            this.uiTextBox3.IntValue = 10000;
            this.uiTextBox3.Location = new System.Drawing.Point(127, 168);
            this.uiTextBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox3.Maximum = 2147483647D;
            this.uiTextBox3.MaximumEnabled = true;
            this.uiTextBox3.Minimum = 1000D;
            this.uiTextBox3.MinimumEnabled = true;
            this.uiTextBox3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTextBox3.Name = "uiTextBox3";
            this.uiTextBox3.Size = new System.Drawing.Size(150, 29);
            this.uiTextBox3.TabIndex = 8;
            this.uiTextBox3.Text = "10000";
            this.uiTextBox3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox3.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel4.Location = new System.Drawing.Point(45, 171);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(100, 23);
            this.uiLabel4.TabIndex = 7;
            this.uiLabel4.Text = "Send超时:";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTextBox2
            // 
            this.uiTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox2.DoubleValue = 2000D;
            this.uiTextBox2.FillColor = System.Drawing.Color.White;
            this.uiTextBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiTextBox2.IntValue = 2000;
            this.uiTextBox2.Location = new System.Drawing.Point(127, 129);
            this.uiTextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox2.Maximum = 2147483647D;
            this.uiTextBox2.Minimum = -2147483648D;
            this.uiTextBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTextBox2.Name = "uiTextBox2";
            this.uiTextBox2.Size = new System.Drawing.Size(150, 29);
            this.uiTextBox2.TabIndex = 6;
            this.uiTextBox2.Text = "2000";
            this.uiTextBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox2.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel3.Location = new System.Drawing.Point(44, 131);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(100, 23);
            this.uiLabel3.TabIndex = 5;
            this.uiLabel3.Text = "IP端口:";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiComboboxEx1
            // 
            this.uiComboboxEx1.BackColor = System.Drawing.Color.White;
            this.uiComboboxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.uiComboboxEx1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiComboboxEx1.FormattingEnabled = true;
            this.uiComboboxEx1.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiComboboxEx1.Location = new System.Drawing.Point(127, 49);
            this.uiComboboxEx1.Name = "uiComboboxEx1";
            this.uiComboboxEx1.Size = new System.Drawing.Size(150, 30);
            this.uiComboboxEx1.TabIndex = 4;
            // 
            // uiTextBox1
            // 
            this.uiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox1.FillColor = System.Drawing.Color.White;
            this.uiTextBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiTextBox1.Location = new System.Drawing.Point(127, 90);
            this.uiTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox1.Maximum = 2147483647D;
            this.uiTextBox1.Minimum = -2147483648D;
            this.uiTextBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.Size = new System.Drawing.Size(150, 29);
            this.uiTextBox1.TabIndex = 3;
            this.uiTextBox1.Text = "127.0.0.1";
            this.uiTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiComboBox1
            // 
            this.uiComboBox1.DataSource = null;
            this.uiComboBox1.FillColor = System.Drawing.Color.White;
            this.uiComboBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiComboBox1.Location = new System.Drawing.Point(99, 47);
            this.uiComboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox1.Name = "uiComboBox1";
            this.uiComboBox1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboBox1.Size = new System.Drawing.Size(198, 29);
            this.uiComboBox1.TabIndex = 1;
            this.uiComboBox1.Text = "uiComboBox1";
            this.uiComboBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DesignerAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 358);
            this.Controls.Add(this.uiGroupBox1);
            this.Name = "DesignerAddForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DesignerAddForm_Load);
            this.uiGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UITextBox uiTextBox3;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox uiTextBox2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UIComboboxEx uiComboboxEx1;
        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UIComboBox uiComboBox1;
        private Sunny.UI.UITextBox uiTextBox4;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UIButton uiButton1;
    }
}