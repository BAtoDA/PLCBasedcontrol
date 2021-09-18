
namespace PLC通讯基础控件项目.模板与控制界面
{
    partial class 手动界面
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
            this.uiGroupBox2 = new Sunny.UI.UIGroupBox();
            this.daUiButton1 = new PLC通讯基础控件项目.基础控件.DAUiButton();
            this.daPlcFunction6 = new PLC通讯基础控件项目.基础控件.底层PLC状态监控控件.DAPlcFunction();
            this.uiGroupBox3 = new Sunny.UI.UIGroupBox();
            this.daUiButton2 = new PLC通讯基础控件项目.基础控件.DAUiButton();
            this.daPlcFunction7 = new PLC通讯基础控件项目.基础控件.底层PLC状态监控控件.DAPlcFunction();
            this.uiGroupBox4 = new Sunny.UI.UIGroupBox();
            this.daUiButton3 = new PLC通讯基础控件项目.基础控件.DAUiButton();
            this.daPlcFunction8 = new PLC通讯基础控件项目.基础控件.底层PLC状态监控控件.DAPlcFunction();
            this.uiGroupBox5 = new Sunny.UI.UIGroupBox();
            this.daUiButton4 = new PLC通讯基础控件项目.基础控件.DAUiButton();
            this.daPlcFunction9 = new PLC通讯基础控件项目.基础控件.底层PLC状态监控控件.DAPlcFunction();
            this.uiPanel1.SuspendLayout();
            this.uiGroupBox2.SuspendLayout();
            this.uiGroupBox3.SuspendLayout();
            this.uiGroupBox4.SuspendLayout();
            this.uiGroupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.uiGroupBox5);
            this.uiPanel1.Controls.Add(this.uiGroupBox4);
            this.uiPanel1.Controls.Add(this.uiGroupBox3);
            this.uiPanel1.Controls.Add(this.uiGroupBox2);
            this.uiPanel1.Controls.SetChildIndex(this.uiGroupBox2, 0);
            this.uiPanel1.Controls.SetChildIndex(this.daPlcFunction2, 0);
            this.uiPanel1.Controls.SetChildIndex(this.daPlcFunction1, 0);
            this.uiPanel1.Controls.SetChildIndex(this.daPlcFunction3, 0);
            this.uiPanel1.Controls.SetChildIndex(this.daPlcFunction4, 0);
            this.uiPanel1.Controls.SetChildIndex(this.daPlcFunction5, 0);
            this.uiPanel1.Controls.SetChildIndex(this.uiGroupBox3, 0);
            this.uiPanel1.Controls.SetChildIndex(this.uiGroupBox4, 0);
            this.uiPanel1.Controls.SetChildIndex(this.uiGroupBox5, 0);
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.daUiButton1);
            this.uiGroupBox2.Controls.Add(this.daPlcFunction6);
            this.uiGroupBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiGroupBox2.Location = new System.Drawing.Point(14, 41);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox2.Size = new System.Drawing.Size(422, 211);
            this.uiGroupBox2.TabIndex = 5;
            this.uiGroupBox2.Text = "一区手动/自动";
            this.uiGroupBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiGroupBox2.TitleAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // daUiButton1
            // 
            this.daUiButton1.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.daUiButton1.backgroundColor_0 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.daUiButton1.backgroundColor_1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.daUiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.daUiButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.daUiButton1.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.daUiButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiButton1.Location = new System.Drawing.Point(246, 83);
            this.daUiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.daUiButton1.Name = "daUiButton1";
            this.daUiButton1.PLC_Enable = true;
            this.daUiButton1.pLCBitselectRealize.AwaitTime = 0;
            this.daUiButton1.pLCBitselectRealize.backgroundColor_0 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.daUiButton1.pLCBitselectRealize.backgroundColor_1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.daUiButton1.pLCBitselectRealize.BitPattern = false;
            this.daUiButton1.pLCBitselectRealize.description = "PLCBitselectRealize";
            this.daUiButton1.pLCBitselectRealize.keyMinTime = 0;
            this.daUiButton1.pLCBitselectRealize.LoosenOut = false;
            this.daUiButton1.pLCBitselectRealize.NoAccessConceal = false;
            this.daUiButton1.pLCBitselectRealize.NoAccessForm = false;
            this.daUiButton1.pLCBitselectRealize.OperationAffirm = false;
            this.daUiButton1.pLCBitselectRealize.OutReverse = false;
            this.daUiButton1.pLCBitselectRealize.Pattern = PLC通讯基础控件项目.控件类基.控件数据结构.Button_pattern.Regression;
            this.daUiButton1.pLCBitselectRealize.PLCTimer = null;
            this.daUiButton1.pLCBitselectRealize.ReadWrite = true;
            this.daUiButton1.pLCBitselectRealize.ReadWriteAddress = "100.0";
            this.daUiButton1.pLCBitselectRealize.ReadWriteFunction = "Q";
            this.daUiButton1.pLCBitselectRealize.ReadWritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Siemens;
            this.daUiButton1.pLCBitselectRealize.SafetyBehaviorPattern = 0;
            this.daUiButton1.pLCBitselectRealize.SafetyCategory = 0;
            this.daUiButton1.pLCBitselectRealize.SafetyFunction = "M";
            this.daUiButton1.pLCBitselectRealize.SafetyPattern = 0;
            this.daUiButton1.pLCBitselectRealize.SafetyPLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daUiButton1.pLCBitselectRealize.Speech = false;
            this.daUiButton1.pLCBitselectRealize.Textalign_0 = "MiddleCenter";
            this.daUiButton1.pLCBitselectRealize.Textalign_1 = "MiddleCenter";
            this.daUiButton1.pLCBitselectRealize.TextColor_0 = System.Drawing.Color.White;
            this.daUiButton1.pLCBitselectRealize.TextColor_1 = System.Drawing.Color.White;
            this.daUiButton1.pLCBitselectRealize.TextContent_0 = "一区运行正常";
            this.daUiButton1.pLCBitselectRealize.TextContent_1 = "一区运行异常";
            this.daUiButton1.pLCBitselectRealize.Textflicker_0 = 0;
            this.daUiButton1.pLCBitselectRealize.Textflicker_1 = 0;
            this.daUiButton1.pLCBitselectRealize.TextFont_0 = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiButton1.pLCBitselectRealize.TextFont_1 = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiButton1.pLCBitselectRealize.TextItalic_0 = false;
            this.daUiButton1.pLCBitselectRealize.TextItalic_1 = false;
            this.daUiButton1.pLCBitselectRealize.TextState = 0;
            this.daUiButton1.pLCBitselectRealize.TextUnderline_0 = false;
            this.daUiButton1.pLCBitselectRealize.TextUnderline_1 = false;
            this.daUiButton1.pLCBitselectRealize.WriteAddress = "600.4";
            this.daUiButton1.pLCBitselectRealize.WriteFunction = "M";
            this.daUiButton1.pLCBitselectRealize.WritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Siemens;
            this.daUiButton1.pLCBitselectRealize.WrSafetyAddress = "0";
            this.daUiButton1.Size = new System.Drawing.Size(138, 70);
            this.daUiButton1.TabIndex = 1;
            this.daUiButton1.Text = "一区运行正常";
            this.daUiButton1.Textalign_0 = "MiddleCenter";
            this.daUiButton1.Textalign_1 = "MiddleCenter";
            this.daUiButton1.TextColor_0 = System.Drawing.Color.White;
            this.daUiButton1.TextColor_1 = System.Drawing.Color.White;
            this.daUiButton1.TextContent_0 = "一区运行正常";
            this.daUiButton1.TextContent_1 = "一区运行异常";
            this.daUiButton1.TextFont_0 = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiButton1.TextFont_1 = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // daPlcFunction6
            // 
            this.daPlcFunction6.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.daPlcFunction6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.daPlcFunction6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daPlcFunction6.FormName = "一区手动主界面";
            this.daPlcFunction6.FormPath = "PLC通讯基础控件项目.模板与控制界面";
            this.daPlcFunction6.Location = new System.Drawing.Point(44, 83);
            this.daPlcFunction6.MinimumSize = new System.Drawing.Size(1, 1);
            this.daPlcFunction6.Name = "daPlcFunction6";
            this.daPlcFunction6.PLC_Enable = true;
            this.daPlcFunction6.Size = new System.Drawing.Size(138, 70);
            this.daPlcFunction6.TabIndex = 0;
            this.daPlcFunction6.Text = "一区手动界面";
            // 
            // uiGroupBox3
            // 
            this.uiGroupBox3.Controls.Add(this.daUiButton2);
            this.uiGroupBox3.Controls.Add(this.daPlcFunction7);
            this.uiGroupBox3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiGroupBox3.Location = new System.Drawing.Point(458, 41);
            this.uiGroupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox3.Name = "uiGroupBox3";
            this.uiGroupBox3.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox3.Size = new System.Drawing.Size(422, 211);
            this.uiGroupBox3.TabIndex = 6;
            this.uiGroupBox3.Text = "二区手动/自动";
            this.uiGroupBox3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiGroupBox3.TitleAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // daUiButton2
            // 
            this.daUiButton2.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.daUiButton2.backgroundColor_0 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.daUiButton2.backgroundColor_1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.daUiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.daUiButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.daUiButton2.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.daUiButton2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiButton2.Location = new System.Drawing.Point(246, 83);
            this.daUiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.daUiButton2.Name = "daUiButton2";
            this.daUiButton2.PLC_Enable = true;
            this.daUiButton2.pLCBitselectRealize.AwaitTime = 0;
            this.daUiButton2.pLCBitselectRealize.backgroundColor_0 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.daUiButton2.pLCBitselectRealize.backgroundColor_1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.daUiButton2.pLCBitselectRealize.BitPattern = false;
            this.daUiButton2.pLCBitselectRealize.description = "PLCBitselectRealize";
            this.daUiButton2.pLCBitselectRealize.keyMinTime = 0;
            this.daUiButton2.pLCBitselectRealize.LoosenOut = false;
            this.daUiButton2.pLCBitselectRealize.NoAccessConceal = false;
            this.daUiButton2.pLCBitselectRealize.NoAccessForm = false;
            this.daUiButton2.pLCBitselectRealize.OperationAffirm = false;
            this.daUiButton2.pLCBitselectRealize.OutReverse = false;
            this.daUiButton2.pLCBitselectRealize.Pattern = PLC通讯基础控件项目.控件类基.控件数据结构.Button_pattern.Regression;
            this.daUiButton2.pLCBitselectRealize.PLCTimer = null;
            this.daUiButton2.pLCBitselectRealize.ReadWrite = true;
            this.daUiButton2.pLCBitselectRealize.ReadWriteAddress = "400.3";
            this.daUiButton2.pLCBitselectRealize.ReadWriteFunction = "Q";
            this.daUiButton2.pLCBitselectRealize.ReadWritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Siemens;
            this.daUiButton2.pLCBitselectRealize.SafetyBehaviorPattern = 0;
            this.daUiButton2.pLCBitselectRealize.SafetyCategory = 0;
            this.daUiButton2.pLCBitselectRealize.SafetyFunction = "M";
            this.daUiButton2.pLCBitselectRealize.SafetyPattern = 0;
            this.daUiButton2.pLCBitselectRealize.SafetyPLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daUiButton2.pLCBitselectRealize.Speech = false;
            this.daUiButton2.pLCBitselectRealize.Textalign_0 = "MiddleCenter";
            this.daUiButton2.pLCBitselectRealize.Textalign_1 = "MiddleCenter";
            this.daUiButton2.pLCBitselectRealize.TextColor_0 = System.Drawing.Color.White;
            this.daUiButton2.pLCBitselectRealize.TextColor_1 = System.Drawing.Color.White;
            this.daUiButton2.pLCBitselectRealize.TextContent_0 = "二区运行正常";
            this.daUiButton2.pLCBitselectRealize.TextContent_1 = "二区运行异常";
            this.daUiButton2.pLCBitselectRealize.Textflicker_0 = 0;
            this.daUiButton2.pLCBitselectRealize.Textflicker_1 = 0;
            this.daUiButton2.pLCBitselectRealize.TextFont_0 = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiButton2.pLCBitselectRealize.TextFont_1 = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiButton2.pLCBitselectRealize.TextItalic_0 = false;
            this.daUiButton2.pLCBitselectRealize.TextItalic_1 = false;
            this.daUiButton2.pLCBitselectRealize.TextState = 0;
            this.daUiButton2.pLCBitselectRealize.TextUnderline_0 = false;
            this.daUiButton2.pLCBitselectRealize.TextUnderline_1 = false;
            this.daUiButton2.pLCBitselectRealize.WriteAddress = "601.4";
            this.daUiButton2.pLCBitselectRealize.WriteFunction = "M";
            this.daUiButton2.pLCBitselectRealize.WritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Siemens;
            this.daUiButton2.pLCBitselectRealize.WrSafetyAddress = "0";
            this.daUiButton2.Size = new System.Drawing.Size(138, 70);
            this.daUiButton2.TabIndex = 1;
            this.daUiButton2.Text = "二区运行正常";
            this.daUiButton2.Textalign_0 = "MiddleCenter";
            this.daUiButton2.Textalign_1 = "MiddleCenter";
            this.daUiButton2.TextColor_0 = System.Drawing.Color.White;
            this.daUiButton2.TextColor_1 = System.Drawing.Color.White;
            this.daUiButton2.TextContent_0 = "二区运行正常";
            this.daUiButton2.TextContent_1 = "二区运行异常";
            this.daUiButton2.TextFont_0 = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiButton2.TextFont_1 = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // daPlcFunction7
            // 
            this.daPlcFunction7.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.daPlcFunction7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.daPlcFunction7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daPlcFunction7.FormName = "二区手动主界面";
            this.daPlcFunction7.FormPath = "PLC通讯基础控件项目.模板与控制界面";
            this.daPlcFunction7.Location = new System.Drawing.Point(44, 83);
            this.daPlcFunction7.MinimumSize = new System.Drawing.Size(1, 1);
            this.daPlcFunction7.Name = "daPlcFunction7";
            this.daPlcFunction7.PLC_Enable = true;
            this.daPlcFunction7.Size = new System.Drawing.Size(138, 70);
            this.daPlcFunction7.TabIndex = 0;
            this.daPlcFunction7.Text = "二区手动界面";
            // 
            // uiGroupBox4
            // 
            this.uiGroupBox4.Controls.Add(this.daUiButton3);
            this.uiGroupBox4.Controls.Add(this.daPlcFunction8);
            this.uiGroupBox4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiGroupBox4.Location = new System.Drawing.Point(14, 312);
            this.uiGroupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox4.Name = "uiGroupBox4";
            this.uiGroupBox4.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox4.Size = new System.Drawing.Size(422, 211);
            this.uiGroupBox4.TabIndex = 7;
            this.uiGroupBox4.Text = "一区手动/自动";
            this.uiGroupBox4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiGroupBox4.TitleAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // daUiButton3
            // 
            this.daUiButton3.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.daUiButton3.backgroundColor_0 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.daUiButton3.backgroundColor_1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.daUiButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.daUiButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.daUiButton3.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.daUiButton3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiButton3.Location = new System.Drawing.Point(246, 83);
            this.daUiButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.daUiButton3.Name = "daUiButton3";
            this.daUiButton3.PLC_Enable = true;
            this.daUiButton3.pLCBitselectRealize.AwaitTime = 0;
            this.daUiButton3.pLCBitselectRealize.backgroundColor_0 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.daUiButton3.pLCBitselectRealize.backgroundColor_1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.daUiButton3.pLCBitselectRealize.BitPattern = false;
            this.daUiButton3.pLCBitselectRealize.description = "PLCBitselectRealize";
            this.daUiButton3.pLCBitselectRealize.keyMinTime = 0;
            this.daUiButton3.pLCBitselectRealize.LoosenOut = false;
            this.daUiButton3.pLCBitselectRealize.NoAccessConceal = false;
            this.daUiButton3.pLCBitselectRealize.NoAccessForm = false;
            this.daUiButton3.pLCBitselectRealize.OperationAffirm = false;
            this.daUiButton3.pLCBitselectRealize.OutReverse = false;
            this.daUiButton3.pLCBitselectRealize.Pattern = PLC通讯基础控件项目.控件类基.控件数据结构.Button_pattern.Regression;
            this.daUiButton3.pLCBitselectRealize.PLCTimer = null;
            this.daUiButton3.pLCBitselectRealize.ReadWrite = true;
            this.daUiButton3.pLCBitselectRealize.ReadWriteAddress = "509.0";
            this.daUiButton3.pLCBitselectRealize.ReadWriteFunction = "Q";
            this.daUiButton3.pLCBitselectRealize.ReadWritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Siemens;
            this.daUiButton3.pLCBitselectRealize.SafetyBehaviorPattern = 0;
            this.daUiButton3.pLCBitselectRealize.SafetyCategory = 0;
            this.daUiButton3.pLCBitselectRealize.SafetyFunction = "M";
            this.daUiButton3.pLCBitselectRealize.SafetyPattern = 0;
            this.daUiButton3.pLCBitselectRealize.SafetyPLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daUiButton3.pLCBitselectRealize.Speech = false;
            this.daUiButton3.pLCBitselectRealize.Textalign_0 = "MiddleCenter";
            this.daUiButton3.pLCBitselectRealize.Textalign_1 = "MiddleCenter";
            this.daUiButton3.pLCBitselectRealize.TextColor_0 = System.Drawing.Color.White;
            this.daUiButton3.pLCBitselectRealize.TextColor_1 = System.Drawing.Color.White;
            this.daUiButton3.pLCBitselectRealize.TextContent_0 = "三区运行正常";
            this.daUiButton3.pLCBitselectRealize.TextContent_1 = "三区运行异常";
            this.daUiButton3.pLCBitselectRealize.Textflicker_0 = 0;
            this.daUiButton3.pLCBitselectRealize.Textflicker_1 = 0;
            this.daUiButton3.pLCBitselectRealize.TextFont_0 = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiButton3.pLCBitselectRealize.TextFont_1 = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiButton3.pLCBitselectRealize.TextItalic_0 = false;
            this.daUiButton3.pLCBitselectRealize.TextItalic_1 = false;
            this.daUiButton3.pLCBitselectRealize.TextState = 0;
            this.daUiButton3.pLCBitselectRealize.TextUnderline_0 = false;
            this.daUiButton3.pLCBitselectRealize.TextUnderline_1 = false;
            this.daUiButton3.pLCBitselectRealize.WriteAddress = "602.4";
            this.daUiButton3.pLCBitselectRealize.WriteFunction = "M";
            this.daUiButton3.pLCBitselectRealize.WritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Siemens;
            this.daUiButton3.pLCBitselectRealize.WrSafetyAddress = "0";
            this.daUiButton3.Size = new System.Drawing.Size(138, 70);
            this.daUiButton3.TabIndex = 1;
            this.daUiButton3.Text = "三区运行正常";
            this.daUiButton3.Textalign_0 = "MiddleCenter";
            this.daUiButton3.Textalign_1 = "MiddleCenter";
            this.daUiButton3.TextColor_0 = System.Drawing.Color.White;
            this.daUiButton3.TextColor_1 = System.Drawing.Color.White;
            this.daUiButton3.TextContent_0 = "三区运行正常";
            this.daUiButton3.TextContent_1 = "三区运行异常";
            this.daUiButton3.TextFont_0 = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiButton3.TextFont_1 = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // daPlcFunction8
            // 
            this.daPlcFunction8.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.daPlcFunction8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.daPlcFunction8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daPlcFunction8.FormName = "三区手动主界面";
            this.daPlcFunction8.FormPath = "PLC通讯基础控件项目.模板与控制界面";
            this.daPlcFunction8.Location = new System.Drawing.Point(44, 83);
            this.daPlcFunction8.MinimumSize = new System.Drawing.Size(1, 1);
            this.daPlcFunction8.Name = "daPlcFunction8";
            this.daPlcFunction8.PLC_Enable = true;
            this.daPlcFunction8.Size = new System.Drawing.Size(138, 70);
            this.daPlcFunction8.TabIndex = 0;
            this.daPlcFunction8.Text = "三区手动界面";
            // 
            // uiGroupBox5
            // 
            this.uiGroupBox5.Controls.Add(this.daUiButton4);
            this.uiGroupBox5.Controls.Add(this.daPlcFunction9);
            this.uiGroupBox5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiGroupBox5.Location = new System.Drawing.Point(458, 312);
            this.uiGroupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox5.Name = "uiGroupBox5";
            this.uiGroupBox5.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox5.Size = new System.Drawing.Size(422, 211);
            this.uiGroupBox5.TabIndex = 6;
            this.uiGroupBox5.Text = "一区手动/自动";
            this.uiGroupBox5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiGroupBox5.TitleAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // daUiButton4
            // 
            this.daUiButton4.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.daUiButton4.backgroundColor_0 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.daUiButton4.backgroundColor_1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.daUiButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.daUiButton4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.daUiButton4.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.daUiButton4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiButton4.Location = new System.Drawing.Point(246, 83);
            this.daUiButton4.MinimumSize = new System.Drawing.Size(1, 1);
            this.daUiButton4.Name = "daUiButton4";
            this.daUiButton4.PLC_Enable = true;
            this.daUiButton4.pLCBitselectRealize.AwaitTime = 0;
            this.daUiButton4.pLCBitselectRealize.backgroundColor_0 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.daUiButton4.pLCBitselectRealize.backgroundColor_1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.daUiButton4.pLCBitselectRealize.BitPattern = false;
            this.daUiButton4.pLCBitselectRealize.description = "PLCBitselectRealize";
            this.daUiButton4.pLCBitselectRealize.keyMinTime = 0;
            this.daUiButton4.pLCBitselectRealize.LoosenOut = false;
            this.daUiButton4.pLCBitselectRealize.NoAccessConceal = false;
            this.daUiButton4.pLCBitselectRealize.NoAccessForm = false;
            this.daUiButton4.pLCBitselectRealize.OperationAffirm = false;
            this.daUiButton4.pLCBitselectRealize.OutReverse = false;
            this.daUiButton4.pLCBitselectRealize.Pattern = PLC通讯基础控件项目.控件类基.控件数据结构.Button_pattern.Regression;
            this.daUiButton4.pLCBitselectRealize.PLCTimer = null;
            this.daUiButton4.pLCBitselectRealize.ReadWrite = true;
            this.daUiButton4.pLCBitselectRealize.ReadWriteAddress = "600.0";
            this.daUiButton4.pLCBitselectRealize.ReadWriteFunction = "Q";
            this.daUiButton4.pLCBitselectRealize.ReadWritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Siemens;
            this.daUiButton4.pLCBitselectRealize.SafetyBehaviorPattern = 0;
            this.daUiButton4.pLCBitselectRealize.SafetyCategory = 0;
            this.daUiButton4.pLCBitselectRealize.SafetyFunction = "M";
            this.daUiButton4.pLCBitselectRealize.SafetyPattern = 0;
            this.daUiButton4.pLCBitselectRealize.SafetyPLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daUiButton4.pLCBitselectRealize.Speech = false;
            this.daUiButton4.pLCBitselectRealize.Textalign_0 = "MiddleCenter";
            this.daUiButton4.pLCBitselectRealize.Textalign_1 = "MiddleCenter";
            this.daUiButton4.pLCBitselectRealize.TextColor_0 = System.Drawing.Color.White;
            this.daUiButton4.pLCBitselectRealize.TextColor_1 = System.Drawing.Color.White;
            this.daUiButton4.pLCBitselectRealize.TextContent_0 = "四区运行正常";
            this.daUiButton4.pLCBitselectRealize.TextContent_1 = "四区运行异常";
            this.daUiButton4.pLCBitselectRealize.Textflicker_0 = 0;
            this.daUiButton4.pLCBitselectRealize.Textflicker_1 = 0;
            this.daUiButton4.pLCBitselectRealize.TextFont_0 = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiButton4.pLCBitselectRealize.TextFont_1 = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiButton4.pLCBitselectRealize.TextItalic_0 = false;
            this.daUiButton4.pLCBitselectRealize.TextItalic_1 = false;
            this.daUiButton4.pLCBitselectRealize.TextState = 0;
            this.daUiButton4.pLCBitselectRealize.TextUnderline_0 = false;
            this.daUiButton4.pLCBitselectRealize.TextUnderline_1 = false;
            this.daUiButton4.pLCBitselectRealize.WriteAddress = "603.4";
            this.daUiButton4.pLCBitselectRealize.WriteFunction = "M";
            this.daUiButton4.pLCBitselectRealize.WritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Siemens;
            this.daUiButton4.pLCBitselectRealize.WrSafetyAddress = "0";
            this.daUiButton4.Size = new System.Drawing.Size(138, 70);
            this.daUiButton4.TabIndex = 1;
            this.daUiButton4.Text = "四区运行正常";
            this.daUiButton4.Textalign_0 = "MiddleCenter";
            this.daUiButton4.Textalign_1 = "MiddleCenter";
            this.daUiButton4.TextColor_0 = System.Drawing.Color.White;
            this.daUiButton4.TextColor_1 = System.Drawing.Color.White;
            this.daUiButton4.TextContent_0 = "四区运行正常";
            this.daUiButton4.TextContent_1 = "四区运行异常";
            this.daUiButton4.TextFont_0 = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiButton4.TextFont_1 = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // daPlcFunction9
            // 
            this.daPlcFunction9.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.daPlcFunction9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.daPlcFunction9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daPlcFunction9.FormName = "四区手动主界面";
            this.daPlcFunction9.FormPath = "PLC通讯基础控件项目.模板与控制界面";
            this.daPlcFunction9.Location = new System.Drawing.Point(44, 83);
            this.daPlcFunction9.MinimumSize = new System.Drawing.Size(1, 1);
            this.daPlcFunction9.Name = "daPlcFunction9";
            this.daPlcFunction9.PLC_Enable = true;
            this.daPlcFunction9.Size = new System.Drawing.Size(138, 70);
            this.daPlcFunction9.TabIndex = 0;
            this.daPlcFunction9.Text = "四区手动界面";
            // 
            // 手动界面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 679);
            this.Name = "手动界面";
            this.Text = "手动界面";
            this.uiPanel1.ResumeLayout(false);
            this.uiGroupBox2.ResumeLayout(false);
            this.uiGroupBox3.ResumeLayout(false);
            this.uiGroupBox4.ResumeLayout(false);
            this.uiGroupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIGroupBox uiGroupBox2;
        private 基础控件.底层PLC状态监控控件.DAPlcFunction daPlcFunction6;
        private 基础控件.DAUiButton daUiButton1;
        private Sunny.UI.UIGroupBox uiGroupBox5;
        private 基础控件.DAUiButton daUiButton4;
        private 基础控件.底层PLC状态监控控件.DAPlcFunction daPlcFunction9;
        private Sunny.UI.UIGroupBox uiGroupBox4;
        private 基础控件.DAUiButton daUiButton3;
        private 基础控件.底层PLC状态监控控件.DAPlcFunction daPlcFunction8;
        private Sunny.UI.UIGroupBox uiGroupBox3;
        private 基础控件.DAUiButton daUiButton2;
        private 基础控件.底层PLC状态监控控件.DAPlcFunction daPlcFunction7;
    }
}