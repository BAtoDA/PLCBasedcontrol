
using System;
using System.Windows.Forms;

namespace PLC通讯基础控件项目.模板与控制界面.窗口底层
{
    partial class TemplateForm
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
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.daPlcFunction5 = new PLC通讯基础控件项目.基础控件.底层PLC状态监控控件.DAPlcFunction();
            this.daPlcFunction4 = new PLC通讯基础控件项目.基础控件.底层PLC状态监控控件.DAPlcFunction();
            this.daPlcFunction3 = new PLC通讯基础控件项目.基础控件.底层PLC状态监控控件.DAPlcFunction();
            this.daPlcFunction2 = new PLC通讯基础控件项目.基础控件.底层PLC状态监控控件.DAPlcFunction();
            this.daPlcFunction1 = new PLC通讯基础控件项目.基础控件.底层PLC状态监控控件.DAPlcFunction();
            this.uiContextMenuStrip1 = new Sunny.UI.UIContextMenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.plcBasement1 = new PLC通讯基础控件项目.基础控件.底层PLC状态监控控件.PlcBasement();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uiContextMenuStrip1.SuspendLayout();
            this.uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiGroupBox1.Location = new System.Drawing.Point(3, 589);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 16, 0, 0);
            this.uiGroupBox1.Radius = 8;
            this.uiGroupBox1.Size = new System.Drawing.Size(889, 51);
            this.uiGroupBox1.StyleCustomMode = true;
            this.uiGroupBox1.TabIndex = 0;
            this.uiGroupBox1.Text = null;
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.uiGroupBox1.TitleInterval = 0;
            this.uiGroupBox1.TitleTop = 0;
            // 
            // daPlcFunction5
            // 
            this.daPlcFunction5.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.daPlcFunction5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.daPlcFunction5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daPlcFunction5.FormName = "参数页面";
            this.daPlcFunction5.FormPath = "PLC通讯基础控件项目.模板与控制界面";
            this.daPlcFunction5.Location = new System.Drawing.Point(744, 595);
            this.daPlcFunction5.MinimumSize = new System.Drawing.Size(1, 1);
            this.daPlcFunction5.Name = "daPlcFunction5";
            this.daPlcFunction5.PLC_Enable = true;
            this.daPlcFunction5.Radius = 20;
            this.daPlcFunction5.Size = new System.Drawing.Size(100, 41);
            this.daPlcFunction5.StyleCustomMode = true;
            this.daPlcFunction5.TabIndex = 4;
            this.daPlcFunction5.Text = "参数页面";
            // 
            // daPlcFunction4
            // 
            this.daPlcFunction4.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.daPlcFunction4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.daPlcFunction4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daPlcFunction4.FormName = "生产页面";
            this.daPlcFunction4.FormPath = "PLC通讯基础控件项目.模板与控制界面";
            this.daPlcFunction4.Location = new System.Drawing.Point(577, 595);
            this.daPlcFunction4.MinimumSize = new System.Drawing.Size(1, 1);
            this.daPlcFunction4.Name = "daPlcFunction4";
            this.daPlcFunction4.PLC_Enable = true;
            this.daPlcFunction4.Radius = 20;
            this.daPlcFunction4.Size = new System.Drawing.Size(100, 41);
            this.daPlcFunction4.StyleCustomMode = true;
            this.daPlcFunction4.TabIndex = 3;
            this.daPlcFunction4.Text = "生产界面";
            // 
            // daPlcFunction3
            // 
            this.daPlcFunction3.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.daPlcFunction3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.daPlcFunction3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daPlcFunction3.FormName = "运转页面";
            this.daPlcFunction3.FormPath = "PLC通讯基础控件项目.模板与控制界面";
            this.daPlcFunction3.Location = new System.Drawing.Point(399, 595);
            this.daPlcFunction3.MinimumSize = new System.Drawing.Size(1, 1);
            this.daPlcFunction3.Name = "daPlcFunction3";
            this.daPlcFunction3.PLC_Enable = true;
            this.daPlcFunction3.Radius = 20;
            this.daPlcFunction3.Size = new System.Drawing.Size(100, 41);
            this.daPlcFunction3.StyleCustomMode = true;
            this.daPlcFunction3.TabIndex = 2;
            this.daPlcFunction3.Text = "运转页面";
            // 
            // daPlcFunction2
            // 
            this.daPlcFunction2.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.daPlcFunction2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.daPlcFunction2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daPlcFunction2.FormName = "手动界面";
            this.daPlcFunction2.FormPath = "PLC通讯基础控件项目.模板与控制界面";
            this.daPlcFunction2.Location = new System.Drawing.Point(216, 595);
            this.daPlcFunction2.MinimumSize = new System.Drawing.Size(1, 1);
            this.daPlcFunction2.Name = "daPlcFunction2";
            this.daPlcFunction2.PLC_Enable = true;
            this.daPlcFunction2.Radius = 20;
            this.daPlcFunction2.Size = new System.Drawing.Size(100, 41);
            this.daPlcFunction2.StyleCustomMode = true;
            this.daPlcFunction2.TabIndex = 1;
            this.daPlcFunction2.Text = "手动页面";
            // 
            // daPlcFunction1
            // 
            this.daPlcFunction1.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.daPlcFunction1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.daPlcFunction1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daPlcFunction1.FormName = "主页面";
            this.daPlcFunction1.FormPath = "PLC通讯基础控件项目.模板与控制界面";
            this.daPlcFunction1.Location = new System.Drawing.Point(43, 595);
            this.daPlcFunction1.MinimumSize = new System.Drawing.Size(1, 1);
            this.daPlcFunction1.Name = "daPlcFunction1";
            this.daPlcFunction1.PLC_Enable = true;
            this.daPlcFunction1.Radius = 20;
            this.daPlcFunction1.Size = new System.Drawing.Size(100, 41);
            this.daPlcFunction1.StyleCustomMode = true;
            this.daPlcFunction1.TabIndex = 0;
            this.daPlcFunction1.Text = "主页面";
            // 
            // uiContextMenuStrip1
            // 
            this.uiContextMenuStrip1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.uiContextMenuStrip1.Name = "uiContextMenuStrip1";
            this.uiContextMenuStrip1.Size = new System.Drawing.Size(177, 82);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(176, 26);
            this.toolStripMenuItem1.Text = "底层日志监控";
            this.toolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(176, 26);
            this.toolStripMenuItem2.Text = "帮助";
            this.toolStripMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(176, 26);
            this.toolStripMenuItem3.Text = "关于系统";
            // 
            // uiPanel1
            // 
            this.uiPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiPanel1.Controls.Add(this.daPlcFunction5);
            this.uiPanel1.Controls.Add(this.plcBasement1);
            this.uiPanel1.Controls.Add(this.daPlcFunction4);
            this.uiPanel1.Controls.Add(this.daPlcFunction3);
            this.uiPanel1.Controls.Add(this.daPlcFunction1);
            this.uiPanel1.Controls.Add(this.daPlcFunction2);
            this.uiPanel1.Controls.Add(this.uiGroupBox1);
            this.uiPanel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiPanel1.Location = new System.Drawing.Point(1, 36);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(897, 647);
            this.uiPanel1.TabIndex = 2;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plcBasement1
            // 
            this.plcBasement1.BackColor = System.Drawing.Color.DarkGray;
            this.plcBasement1.Location = new System.Drawing.Point(201, 166);
            this.plcBasement1.Margin = new System.Windows.Forms.Padding(114, 26, 114, 26);
            this.plcBasement1.Name = "plcBasement1";
            this.plcBasement1.Size = new System.Drawing.Size(495, 277);
            this.plcBasement1.TabIndex = 0;
            this.plcBasement1.Visible = false;
            this.plcBasement1.Load += new System.EventHandler(this.plcBasement1_Load);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(859, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 34);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // TemplateForm
            // 
            this.AllowAddControlOnTitle = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 679);
            this.CloseAskString = "";
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.uiPanel1);
            this.ExtendBox = true;
            this.ExtendMenu = this.uiContextMenuStrip1;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "TemplateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TemplateForm";
            this.ExtendBoxClick += new System.EventHandler(this.TemplateForm_ExtendBoxClick);
            this.Load += new System.EventHandler(this.TemplateForm_Load);
            this.uiContextMenuStrip1.ResumeLayout(false);
            this.uiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIContextMenuStrip uiContextMenuStrip1;
        protected 基础控件.底层PLC状态监控控件.DAPlcFunction daPlcFunction5;
        protected 基础控件.底层PLC状态监控控件.DAPlcFunction daPlcFunction4;
        protected 基础控件.底层PLC状态监控控件.DAPlcFunction daPlcFunction1;
        protected 基础控件.底层PLC状态监控控件.DAPlcFunction daPlcFunction3;
        protected 基础控件.底层PLC状态监控控件.DAPlcFunction daPlcFunction2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        protected Sunny.UI.UIPanel uiPanel1;
        private 基础控件.底层PLC状态监控控件.PlcBasement plcBasement1;
        private PictureBox pictureBox1;
    }
}