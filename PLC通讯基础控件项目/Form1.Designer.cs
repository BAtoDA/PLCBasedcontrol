﻿
namespace PLC通讯基础控件项目
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.plcControlsPreferences1 = new PLC通讯基础控件项目.PLCControlsPreferences(this.components);
            this.SuspendLayout();
            // 
            // plcControlsPreferences1
            // 
            this.plcControlsPreferences1.Location = new System.Drawing.Point(0, 0);
            this.plcControlsPreferences1.Name = "plcControlsPreferences1";
            this.plcControlsPreferences1.TabIndex = 0;
            this.plcControlsPreferences1.Text = "plcControlsPreferences1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 450);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private PLCControlsPreferences plcControlsPreferences1;
    }
}