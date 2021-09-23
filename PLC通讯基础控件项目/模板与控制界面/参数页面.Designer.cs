
namespace PLC通讯基础控件项目.模板与控制界面
{
    partial class 参数页面
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
            this.uiGroupBox2 = new Sunny.UI.UIGroupBox();
            this.daPlcFunction6 = new PLC通讯基础控件项目.基础控件.底层PLC状态监控控件.DAPlcFunction();
            this.uiGroupBox3 = new Sunny.UI.UIGroupBox();
            this.uiGroupBox4 = new Sunny.UI.UIGroupBox();
            this.uiGroupBox5 = new Sunny.UI.UIGroupBox();
            this.uiPanel1.SuspendLayout();
            this.uiGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.uiGroupBox5);
            this.uiPanel1.Controls.Add(this.uiGroupBox4);
            this.uiPanel1.Controls.Add(this.uiGroupBox3);
            this.uiPanel1.Controls.Add(this.uiGroupBox2);
            this.uiPanel1.Location = new System.Drawing.Point(1, 34);
            this.uiPanel1.Size = new System.Drawing.Size(994, 876);
            this.uiPanel1.Controls.SetChildIndex(this.daPlcFunction2, 0);
            this.uiPanel1.Controls.SetChildIndex(this.daPlcFunction1, 0);
            this.uiPanel1.Controls.SetChildIndex(this.daPlcFunction3, 0);
            this.uiPanel1.Controls.SetChildIndex(this.daPlcFunction4, 0);
            this.uiPanel1.Controls.SetChildIndex(this.daPlcFunction5, 0);
            this.uiPanel1.Controls.SetChildIndex(this.uiGroupBox2, 0);
            this.uiPanel1.Controls.SetChildIndex(this.uiGroupBox3, 0);
            this.uiPanel1.Controls.SetChildIndex(this.uiGroupBox4, 0);
            this.uiPanel1.Controls.SetChildIndex(this.uiGroupBox5, 0);
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.daPlcFunction6);
            this.uiGroupBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiGroupBox2.Location = new System.Drawing.Point(23, 15);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox2.Size = new System.Drawing.Size(393, 274);
            this.uiGroupBox2.TabIndex = 5;
            this.uiGroupBox2.Text = "一区参数设置";
            this.uiGroupBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiGroupBox2.TitleAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // daPlcFunction6
            // 
            this.daPlcFunction6.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.daPlcFunction6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.daPlcFunction6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daPlcFunction6.FormName = "FL1分料参数";
            this.daPlcFunction6.FormPath = "PLC通讯基础控件项目.模板与控制界面";
            this.daPlcFunction6.Location = new System.Drawing.Point(37, 68);
            this.daPlcFunction6.MinimumSize = new System.Drawing.Size(1, 1);
            this.daPlcFunction6.Name = "daPlcFunction6";
            this.daPlcFunction6.PLC_Enable = true;
            this.daPlcFunction6.Size = new System.Drawing.Size(100, 35);
            this.daPlcFunction6.TabIndex = 0;
            this.daPlcFunction6.Text = "FL1参数设置";
            // 
            // uiGroupBox3
            // 
            this.uiGroupBox3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiGroupBox3.Location = new System.Drawing.Point(478, 15);
            this.uiGroupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox3.Name = "uiGroupBox3";
            this.uiGroupBox3.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox3.Size = new System.Drawing.Size(393, 274);
            this.uiGroupBox3.TabIndex = 6;
            this.uiGroupBox3.Text = "二区参数设置";
            this.uiGroupBox3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiGroupBox3.TitleAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uiGroupBox4
            // 
            this.uiGroupBox4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiGroupBox4.Location = new System.Drawing.Point(23, 301);
            this.uiGroupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox4.Name = "uiGroupBox4";
            this.uiGroupBox4.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox4.Size = new System.Drawing.Size(393, 274);
            this.uiGroupBox4.TabIndex = 7;
            this.uiGroupBox4.Text = "三区参数设置";
            this.uiGroupBox4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiGroupBox4.TitleAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uiGroupBox5
            // 
            this.uiGroupBox5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiGroupBox5.Location = new System.Drawing.Point(478, 301);
            this.uiGroupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox5.Name = "uiGroupBox5";
            this.uiGroupBox5.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox5.Size = new System.Drawing.Size(393, 274);
            this.uiGroupBox5.TabIndex = 8;
            this.uiGroupBox5.Text = "四区参数设置";
            this.uiGroupBox5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiGroupBox5.TitleAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // 参数页面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 679);
            this.Name = "参数页面";
            this.Text = "参数页面";
            this.uiPanel1.ResumeLayout(false);
            this.uiGroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIGroupBox uiGroupBox5;
        private Sunny.UI.UIGroupBox uiGroupBox4;
        private Sunny.UI.UIGroupBox uiGroupBox3;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private 基础控件.底层PLC状态监控控件.DAPlcFunction daPlcFunction6;
    }
}