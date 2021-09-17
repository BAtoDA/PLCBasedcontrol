
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
            this.daPlcFunction1 = new PLC通讯基础控件项目.基础控件.底层PLC状态监控控件.DAPlcFunction();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiProgressIndicator1 = new Sunny.UI.UIProgressIndicator();
            this.SuspendLayout();
            // 
            // daPlcFunction1
            // 
            this.daPlcFunction1.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.daPlcFunction1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.daPlcFunction1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daPlcFunction1.FormName = "主页面";
            this.daPlcFunction1.FormPath = "PLC通讯基础控件项目.模板与控制界面";
            this.daPlcFunction1.Location = new System.Drawing.Point(163, 180);
            this.daPlcFunction1.MinimumSize = new System.Drawing.Size(1, 1);
            this.daPlcFunction1.Name = "daPlcFunction1";
            this.daPlcFunction1.PLC_Enable = true;
            this.daPlcFunction1.Size = new System.Drawing.Size(124, 59);
            this.daPlcFunction1.TabIndex = 0;
            this.daPlcFunction1.Text = "进入主界面";
            this.daPlcFunction1.Click += new System.EventHandler(this.daPlcFunction1_Click);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel1.ForeColor = System.Drawing.Color.White;
            this.uiLabel1.Location = new System.Drawing.Point(140, 2);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(200, 60);
            this.uiLabel1.TabIndex = 1;
            this.uiLabel1.Text = "系统界面";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiProgressIndicator1
            // 
            this.uiProgressIndicator1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiProgressIndicator1.Location = new System.Drawing.Point(169, 59);
            this.uiProgressIndicator1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiProgressIndicator1.Name = "uiProgressIndicator1";
            this.uiProgressIndicator1.Size = new System.Drawing.Size(100, 100);
            this.uiProgressIndicator1.TabIndex = 3;
            this.uiProgressIndicator1.Text = "uiProgressIndicator1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(425, 255);
            this.ControlBox = false;
            this.Controls.Add(this.uiProgressIndicator1);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.daPlcFunction1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private PLC通讯基础控件项目.基础控件.底层PLC状态监控控件.DAPlcFunction daPlcFunction1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIProgressIndicator uiProgressIndicator1;
    }
}

