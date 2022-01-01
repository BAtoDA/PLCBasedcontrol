﻿namespace 控件测试项目
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.plcControlsPreferences1 = new PLC通讯基础控件项目.PLCControlsPreferences(this.components);
            this.plcPreferences1 = new PLC通讯基础控件项目.PLC参数设置控件.PLCPreferences();
            this.plcPreferences2 = new PLC通讯基础控件项目.PLC参数设置控件.PLCPreferences();
            this.plcPreferences3 = new PLC通讯基础控件项目.PLC参数设置控件.PLCPreferences();
            this.plcPreferences4 = new PLC通讯基础控件项目.PLC参数设置控件.PLCPreferences();
            this.plcPreferences5 = new PLC通讯基础控件项目.PLC参数设置控件.PLCPreferences();
            this.plcPreferences6 = new PLC通讯基础控件项目.PLC参数设置控件.PLCPreferences();
            this.daUiButton2 = new PLC通讯基础控件项目.基础控件.DAUiButton();
            this.daUiButton1 = new PLC通讯基础控件项目.基础控件.DAUiButton();
            this.daMacroControl1 = new PLC通讯基础控件项目.基础控件.宏指令控件.DAMacroControl(this.components);
            this.uiComboBox1 = new Sunny.UI.UIComboBox();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.uiRichTextBox1 = new Sunny.UI.UIRichTextBox();
            this.daUiTextBox1 = new PLC通讯基础控件项目.基础控件.DAUiTextBox();
            this.daButton1 = new PLC通讯基础控件项目.基础控件.DAButton();
            this.daPlcFunction1 = new PLC通讯基础控件项目.基础控件.底层PLC状态监控控件.DAPlcFunction();
            this.button1 = new System.Windows.Forms.Button();
            this.daUiButton3 = new PLC通讯基础控件项目.基础控件.DAUiButton();
            this.daUiTextBox2 = new PLC通讯基础控件项目.基础控件.DAUiTextBox();
            this.daUiTextBox3 = new PLC通讯基础控件项目.基础控件.DAUiTextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // plcControlsPreferences1
            // 
            this.plcControlsPreferences1.Enabled = true;
            this.plcControlsPreferences1.Interval = 1000;
            this.plcControlsPreferences1.PLCPreferences.Add(this.plcPreferences1);
            this.plcControlsPreferences1.PLCPreferences.Add(this.plcPreferences2);
            this.plcControlsPreferences1.PLCPreferences.Add(this.plcPreferences3);
            this.plcControlsPreferences1.PLCPreferences.Add(this.plcPreferences4);
            this.plcControlsPreferences1.PLCPreferences.Add(this.plcPreferences5);
            this.plcControlsPreferences1.PLCPreferences.Add(this.plcPreferences6);
            // 
            // plcPreferences1
            // 
            this.plcPreferences1.IPEnd = "127.0.0.1";
            this.plcPreferences1.PLCDevice = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.plcPreferences1.Point = 2000;
            this.plcPreferences1.Receptionovertime = 1000;
            this.plcPreferences1.Retain = "FX";
            this.plcPreferences1.Sendovertime = 1000;
            // 
            // plcPreferences2
            // 
            this.plcPreferences2.IPEnd = "127.0.0.1";
            this.plcPreferences2.PLCDevice = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Siemens;
            this.plcPreferences2.Point = 2000;
            this.plcPreferences2.Receptionovertime = 1000;
            this.plcPreferences2.Retain = "S1500";
            this.plcPreferences2.Sendovertime = 1000;
            // 
            // plcPreferences3
            // 
            this.plcPreferences3.IPEnd = "127.0.0.1";
            this.plcPreferences3.PLCDevice = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Modbus_TCP;
            this.plcPreferences3.Point = 2000;
            this.plcPreferences3.Receptionovertime = 1000;
            this.plcPreferences3.Retain = "S1500";
            this.plcPreferences3.Sendovertime = 1000;
            // 
            // plcPreferences4
            // 
            this.plcPreferences4.IPEnd = "127.0.0.1";
            this.plcPreferences4.PLCDevice = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.HMI;
            this.plcPreferences4.Point = 2000;
            this.plcPreferences4.Receptionovertime = 1000;
            this.plcPreferences4.Retain = "S1500";
            this.plcPreferences4.Sendovertime = 1000;
            // 
            // plcPreferences5
            // 
            this.plcPreferences5.IPEnd = "127.0.0.1";
            this.plcPreferences5.PLCDevice = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Fanuc;
            this.plcPreferences5.Point = 2000;
            this.plcPreferences5.Receptionovertime = 1000;
            this.plcPreferences5.Retain = "S1500";
            this.plcPreferences5.Sendovertime = 1000;
            // 
            // plcPreferences6
            // 
            this.plcPreferences6.IPEnd = "127.0.0.1";
            this.plcPreferences6.PLCDevice = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.OmronTCP;
            this.plcPreferences6.Point = 2000;
            this.plcPreferences6.Receptionovertime = 1000;
            this.plcPreferences6.Retain = "S1500";
            this.plcPreferences6.Sendovertime = 1000;
            // 
            // daUiButton2
            // 
            this.daUiButton2.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.daUiButton2.backgroundColor_0 = System.Drawing.Color.Silver;
            this.daUiButton2.backgroundColor_1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.daUiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.daUiButton2.FillColor = System.Drawing.Color.Silver;
            this.daUiButton2.FillHoverColor = System.Drawing.Color.Silver;
            this.daUiButton2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiButton2.Location = new System.Drawing.Point(406, 235);
            this.daUiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.daUiButton2.Name = "daUiButton2";
            this.daUiButton2.PLC_Enable = true;
            this.daUiButton2.pLCBitselectRealize.AwaitTime = 0;
            this.daUiButton2.pLCBitselectRealize.backgroundColor_0 = System.Drawing.Color.Silver;
            this.daUiButton2.pLCBitselectRealize.backgroundColor_1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.daUiButton2.pLCBitselectRealize.BitPattern = false;
            this.daUiButton2.pLCBitselectRealize.Compilestate = true;
            this.daUiButton2.pLCBitselectRealize.description = "PLCBitselectRealize";
            this.daUiButton2.pLCBitselectRealize.keyMinTime = 0;
            this.daUiButton2.pLCBitselectRealize.LoosenOut = false;
            this.daUiButton2.pLCBitselectRealize.Macrocode = resources.GetString("resource.Macrocode");
            this.daUiButton2.pLCBitselectRealize.MacroEvent = "不使用";
            this.daUiButton2.pLCBitselectRealize.macroID = 1;
            this.daUiButton2.pLCBitselectRealize.MacroName = "MacroList1";
            this.daUiButton2.pLCBitselectRealize.NoAccessConceal = false;
            this.daUiButton2.pLCBitselectRealize.NoAccessForm = false;
            this.daUiButton2.pLCBitselectRealize.OperationAffirm = false;
            this.daUiButton2.pLCBitselectRealize.OutReverse = false;
            this.daUiButton2.pLCBitselectRealize.Pattern = PLC通讯基础控件项目.控件类基.控件数据结构.Button_pattern.selector_witch;
            this.daUiButton2.pLCBitselectRealize.PLCTimer = null;
            this.daUiButton2.pLCBitselectRealize.ReadWrite = false;
            this.daUiButton2.pLCBitselectRealize.ReadWriteAddress = "0";
            this.daUiButton2.pLCBitselectRealize.ReadWriteFunction = "M";
            this.daUiButton2.pLCBitselectRealize.ReadWritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
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
            this.daUiButton2.pLCBitselectRealize.TextContent_0 = "OFF";
            this.daUiButton2.pLCBitselectRealize.TextContent_1 = "ON";
            this.daUiButton2.pLCBitselectRealize.Textflicker_0 = 0;
            this.daUiButton2.pLCBitselectRealize.Textflicker_1 = 0;
            this.daUiButton2.pLCBitselectRealize.TextFont_0 = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiButton2.pLCBitselectRealize.TextFont_1 = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiButton2.pLCBitselectRealize.TextItalic_0 = false;
            this.daUiButton2.pLCBitselectRealize.TextItalic_1 = false;
            this.daUiButton2.pLCBitselectRealize.TextState = 0;
            this.daUiButton2.pLCBitselectRealize.TextUnderline_0 = false;
            this.daUiButton2.pLCBitselectRealize.TextUnderline_1 = false;
            this.daUiButton2.pLCBitselectRealize.WriteAddress = "0";
            this.daUiButton2.pLCBitselectRealize.WriteFunction = "M";
            this.daUiButton2.pLCBitselectRealize.WritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daUiButton2.pLCBitselectRealize.WrSafetyAddress = "0";
            this.daUiButton2.PLCTimer = null;
            this.daUiButton2.Size = new System.Drawing.Size(100, 35);
            this.daUiButton2.Style = Sunny.UI.UIStyle.Custom;
            this.daUiButton2.TabIndex = 2;
            this.daUiButton2.Text = "OFF";
            this.daUiButton2.Textalign_0 = "MiddleCenter";
            this.daUiButton2.Textalign_1 = "MiddleCenter";
            this.daUiButton2.TextColor_0 = System.Drawing.Color.White;
            this.daUiButton2.TextColor_1 = System.Drawing.Color.White;
            this.daUiButton2.TextContent_0 = "OFF";
            this.daUiButton2.TextContent_1 = "ON";
            this.daUiButton2.TextFont_0 = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiButton2.TextFont_1 = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // daUiButton1
            // 
            this.daUiButton1.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.daUiButton1.backgroundColor_0 = System.Drawing.Color.Silver;
            this.daUiButton1.backgroundColor_1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.daUiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.daUiButton1.FillColor = System.Drawing.Color.Silver;
            this.daUiButton1.FillHoverColor = System.Drawing.Color.Silver;
            this.daUiButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiButton1.Location = new System.Drawing.Point(238, 368);
            this.daUiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.daUiButton1.Name = "daUiButton1";
            this.daUiButton1.PLC_Enable = true;
            this.daUiButton1.pLCBitselectRealize.AwaitTime = 0;
            this.daUiButton1.pLCBitselectRealize.backgroundColor_0 = System.Drawing.Color.Silver;
            this.daUiButton1.pLCBitselectRealize.backgroundColor_1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.daUiButton1.pLCBitselectRealize.BitPattern = false;
            this.daUiButton1.pLCBitselectRealize.Compilestate = true;
            this.daUiButton1.pLCBitselectRealize.description = "PLCBitselectRealize";
            this.daUiButton1.pLCBitselectRealize.keyMinTime = 0;
            this.daUiButton1.pLCBitselectRealize.LoosenOut = false;
            this.daUiButton1.pLCBitselectRealize.Macrocode = resources.GetString("resource.Macrocode1");
            this.daUiButton1.pLCBitselectRealize.MacroEvent = "Click";
            this.daUiButton1.pLCBitselectRealize.macroID = 3;
            this.daUiButton1.pLCBitselectRealize.MacroName = "MacroList3";
            this.daUiButton1.pLCBitselectRealize.NoAccessConceal = false;
            this.daUiButton1.pLCBitselectRealize.NoAccessForm = false;
            this.daUiButton1.pLCBitselectRealize.OperationAffirm = false;
            this.daUiButton1.pLCBitselectRealize.OutReverse = false;
            this.daUiButton1.pLCBitselectRealize.Pattern = PLC通讯基础控件项目.控件类基.控件数据结构.Button_pattern.selector_witch;
            this.daUiButton1.pLCBitselectRealize.PLCTimer = null;
            this.daUiButton1.pLCBitselectRealize.ReadWrite = false;
            this.daUiButton1.pLCBitselectRealize.ReadWriteAddress = "0";
            this.daUiButton1.pLCBitselectRealize.ReadWriteFunction = "M";
            this.daUiButton1.pLCBitselectRealize.ReadWritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
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
            this.daUiButton1.pLCBitselectRealize.TextContent_0 = "OFF";
            this.daUiButton1.pLCBitselectRealize.TextContent_1 = "ON";
            this.daUiButton1.pLCBitselectRealize.Textflicker_0 = 0;
            this.daUiButton1.pLCBitselectRealize.Textflicker_1 = 0;
            this.daUiButton1.pLCBitselectRealize.TextFont_0 = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiButton1.pLCBitselectRealize.TextFont_1 = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiButton1.pLCBitselectRealize.TextItalic_0 = false;
            this.daUiButton1.pLCBitselectRealize.TextItalic_1 = false;
            this.daUiButton1.pLCBitselectRealize.TextState = 0;
            this.daUiButton1.pLCBitselectRealize.TextUnderline_0 = false;
            this.daUiButton1.pLCBitselectRealize.TextUnderline_1 = false;
            this.daUiButton1.pLCBitselectRealize.WriteAddress = "0";
            this.daUiButton1.pLCBitselectRealize.WriteFunction = "M";
            this.daUiButton1.pLCBitselectRealize.WritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daUiButton1.pLCBitselectRealize.WrSafetyAddress = "0";
            this.daUiButton1.PLCTimer = null;
            this.daUiButton1.Size = new System.Drawing.Size(100, 35);
            this.daUiButton1.Style = Sunny.UI.UIStyle.Custom;
            this.daUiButton1.TabIndex = 1;
            this.daUiButton1.Text = "OFF";
            this.daUiButton1.Textalign_0 = "MiddleCenter";
            this.daUiButton1.Textalign_1 = "MiddleCenter";
            this.daUiButton1.TextColor_0 = System.Drawing.Color.White;
            this.daUiButton1.TextColor_1 = System.Drawing.Color.White;
            this.daUiButton1.TextContent_0 = "OFF";
            this.daUiButton1.TextContent_1 = "ON";
            this.daUiButton1.TextFont_0 = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiButton1.TextFont_1 = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // daMacroControl1
            // 
            this.daMacroControl1.Location = new System.Drawing.Point(305, 305);
            this.daMacroControl1.Name = "daMacroControl1";
            this.daMacroControl1.PLC_Enable = true;
            this.daMacroControl1.Size = new System.Drawing.Size(75, 23);
            this.daMacroControl1.TabIndex = 3;
            this.daMacroControl1.Text = "daMacroControl1";
            // 
            // uiComboBox1
            // 
            this.uiComboBox1.DataSource = null;
            this.uiComboBox1.FillColor = System.Drawing.Color.White;
            this.uiComboBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiComboBox1.Location = new System.Drawing.Point(139, 31);
            this.uiComboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox1.Name = "uiComboBox1";
            this.uiComboBox1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboBox1.Size = new System.Drawing.Size(150, 29);
            this.uiComboBox1.TabIndex = 4;
            this.uiComboBox1.Text = "uiComboBox1";
            this.uiComboBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiButton1.Location = new System.Drawing.Point(305, 31);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(100, 35);
            this.uiButton1.TabIndex = 5;
            this.uiButton1.Text = "uiButton1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(193, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(192, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(192, 22);
            this.toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // uiRichTextBox1
            // 
            this.uiRichTextBox1.AutoWordSelection = true;
            this.uiRichTextBox1.FillColor = System.Drawing.Color.White;
            this.uiRichTextBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiRichTextBox1.Location = new System.Drawing.Point(80, 135);
            this.uiRichTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiRichTextBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRichTextBox1.Name = "uiRichTextBox1";
            this.uiRichTextBox1.Padding = new System.Windows.Forms.Padding(2);
            this.uiRichTextBox1.Size = new System.Drawing.Size(270, 180);
            this.uiRichTextBox1.Style = Sunny.UI.UIStyle.Custom;
            this.uiRichTextBox1.TabIndex = 6;
            this.uiRichTextBox1.Text = "ifd \nelse1";
            this.uiRichTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiRichTextBox1.WordWrap = true;
            this.uiRichTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.uiRichTextBox1_KeyPress);
            this.uiRichTextBox1.TextChanged += new System.EventHandler(this.uiRichTextBox1_TextChanged);
            // 
            // daUiTextBox1
            // 
            this.daUiTextBox1.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.daUiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.daUiTextBox1.FillColor = System.Drawing.Color.White;
            this.daUiTextBox1.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiTextBox1.ForeColor = System.Drawing.Color.Black;
            this.daUiTextBox1.Location = new System.Drawing.Point(56, 363);
            this.daUiTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.daUiTextBox1.Maximum = 2147483647D;
            this.daUiTextBox1.Minimum = -2147483648D;
            this.daUiTextBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.daUiTextBox1.Name = "daUiTextBox1";
            this.daUiTextBox1.PLC_Enable = true;
            this.daUiTextBox1.pLCDselectRealize.AwaitTime = 0;
            this.daUiTextBox1.pLCDselectRealize.Compilestate = true;
            this.daUiTextBox1.pLCDselectRealize.Dataentryfunction = true;
            this.daUiTextBox1.pLCDselectRealize.description = "PLCDselectRealize";
            this.daUiTextBox1.pLCDselectRealize.Inform = false;
            this.daUiTextBox1.pLCDselectRealize.InformAddress = "0";
            this.daUiTextBox1.pLCDselectRealize.InformFunction = "M";
            this.daUiTextBox1.pLCDselectRealize.Informpattern = 0;
            this.daUiTextBox1.pLCDselectRealize.InformPLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daUiTextBox1.pLCDselectRealize.Keyboard = true;
            this.daUiTextBox1.pLCDselectRealize.KeyboardStyle = "keyboard";
            this.daUiTextBox1.pLCDselectRealize.keyMinTime = 0;
            this.daUiTextBox1.pLCDselectRealize.Macrocode = resources.GetString("resource.Macrocode2");
            this.daUiTextBox1.pLCDselectRealize.MacroEvent = "Click";
            this.daUiTextBox1.pLCDselectRealize.macroID = 1;
            this.daUiTextBox1.pLCDselectRealize.MacroName = "MacroList1";
            this.daUiTextBox1.pLCDselectRealize.NoAccessConceal = false;
            this.daUiTextBox1.pLCDselectRealize.NoAccessForm = false;
            this.daUiTextBox1.pLCDselectRealize.NumericaldigitMax = 7;
            this.daUiTextBox1.pLCDselectRealize.NumericaldigitMin = 0;
            this.daUiTextBox1.pLCDselectRealize.NumericalFormat = 0;
            this.daUiTextBox1.pLCDselectRealize.NumericalMax = 9999999;
            this.daUiTextBox1.pLCDselectRealize.NumericalMin = -999999;
            this.daUiTextBox1.pLCDselectRealize.OperationAffirm = false;
            this.daUiTextBox1.pLCDselectRealize.PLCTimer = null;
            this.daUiTextBox1.pLCDselectRealize.ReadWrite = false;
            this.daUiTextBox1.pLCDselectRealize.ReadWriteAddress = "1";
            this.daUiTextBox1.pLCDselectRealize.ReadWriteFunction = "RW";
            this.daUiTextBox1.pLCDselectRealize.ReadWritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.HMI;
            this.daUiTextBox1.pLCDselectRealize.SafetyBehaviorPattern = 1;
            this.daUiTextBox1.pLCDselectRealize.SafetyCategory = 0;
            this.daUiTextBox1.pLCDselectRealize.SafetyFunction = "M";
            this.daUiTextBox1.pLCDselectRealize.SafetyPattern = 1;
            this.daUiTextBox1.pLCDselectRealize.SafetyPLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daUiTextBox1.pLCDselectRealize.ShowFormat = PLC通讯库.通讯枚举.numerical_format.Signed_32_Bit;
            this.daUiTextBox1.pLCDselectRealize.Speech = false;
            this.daUiTextBox1.pLCDselectRealize.Textalign_0 = "BottomCenter";
            this.daUiTextBox1.pLCDselectRealize.Textalign_1 = "BottomCenter";
            this.daUiTextBox1.pLCDselectRealize.TextColor_0 = System.Drawing.Color.Black;
            this.daUiTextBox1.pLCDselectRealize.TextColor_1 = System.Drawing.Color.Black;
            this.daUiTextBox1.pLCDselectRealize.TextContent_0 = "PLCpropertyText";
            this.daUiTextBox1.pLCDselectRealize.TextContent_1 = null;
            this.daUiTextBox1.pLCDselectRealize.Textflicker_0 = 0;
            this.daUiTextBox1.pLCDselectRealize.Textflicker_1 = 0;
            this.daUiTextBox1.pLCDselectRealize.TextFont_0 = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiTextBox1.pLCDselectRealize.TextFont_1 = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiTextBox1.pLCDselectRealize.TextItalic_0 = false;
            this.daUiTextBox1.pLCDselectRealize.TextItalic_1 = false;
            this.daUiTextBox1.pLCDselectRealize.TextUnderline_0 = false;
            this.daUiTextBox1.pLCDselectRealize.TextUnderline_1 = false;
            this.daUiTextBox1.pLCDselectRealize.WriteAddress = "0";
            this.daUiTextBox1.pLCDselectRealize.WriteFunction = "D";
            this.daUiTextBox1.pLCDselectRealize.WritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daUiTextBox1.pLCDselectRealize.WrSafetyAddress = "0";
            this.daUiTextBox1.PLCTimer = null;
            this.daUiTextBox1.Size = new System.Drawing.Size(150, 29);
            this.daUiTextBox1.Style = Sunny.UI.UIStyle.Custom;
            this.daUiTextBox1.TabIndex = 8;
            this.daUiTextBox1.Text = "0";
            this.daUiTextBox1.Textalign_0 = "BottomCenter";
            this.daUiTextBox1.Textalign_1 = "BottomCenter";
            this.daUiTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.daUiTextBox1.TextColor_0 = System.Drawing.Color.Black;
            this.daUiTextBox1.TextColor_1 = System.Drawing.Color.Black;
            this.daUiTextBox1.TextContent_0 = "PLCpropertyText";
            this.daUiTextBox1.TextContent_1 = null;
            this.daUiTextBox1.TextFont_0 = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiTextBox1.TextFont_1 = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // daButton1
            // 
            this.daButton1.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.daButton1.BackColor = System.Drawing.Color.Silver;
            this.daButton1.backgroundColor_0 = System.Drawing.Color.Silver;
            this.daButton1.backgroundColor_1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.daButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daButton1.ForeColor = System.Drawing.Color.White;
            this.daButton1.Location = new System.Drawing.Point(417, 179);
            this.daButton1.Name = "daButton1";
            this.daButton1.PLC_Enable = false;
            this.daButton1.pLCBitselectRealize.AwaitTime = 0;
            this.daButton1.pLCBitselectRealize.backgroundColor_0 = System.Drawing.Color.Silver;
            this.daButton1.pLCBitselectRealize.backgroundColor_1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.daButton1.pLCBitselectRealize.BitPattern = false;
            this.daButton1.pLCBitselectRealize.Compilestate = false;
            this.daButton1.pLCBitselectRealize.description = "PLCBitselectRealize";
            this.daButton1.pLCBitselectRealize.keyMinTime = 0;
            this.daButton1.pLCBitselectRealize.LoosenOut = false;
            this.daButton1.pLCBitselectRealize.Macrocode = resources.GetString("resource.Macrocode3");
            this.daButton1.pLCBitselectRealize.MacroEvent = "不使用";
            this.daButton1.pLCBitselectRealize.macroID = 1;
            this.daButton1.pLCBitselectRealize.MacroName = "MacroList";
            this.daButton1.pLCBitselectRealize.NoAccessConceal = false;
            this.daButton1.pLCBitselectRealize.NoAccessForm = false;
            this.daButton1.pLCBitselectRealize.OperationAffirm = false;
            this.daButton1.pLCBitselectRealize.OutReverse = false;
            this.daButton1.pLCBitselectRealize.Pattern = PLC通讯基础控件项目.控件类基.控件数据结构.Button_pattern.selector_witch;
            this.daButton1.pLCBitselectRealize.PLCTimer = null;
            this.daButton1.pLCBitselectRealize.ReadWrite = false;
            this.daButton1.pLCBitselectRealize.ReadWriteAddress = "0";
            this.daButton1.pLCBitselectRealize.ReadWriteFunction = "M";
            this.daButton1.pLCBitselectRealize.ReadWritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daButton1.pLCBitselectRealize.SafetyBehaviorPattern = 0;
            this.daButton1.pLCBitselectRealize.SafetyCategory = 0;
            this.daButton1.pLCBitselectRealize.SafetyFunction = "M";
            this.daButton1.pLCBitselectRealize.SafetyPattern = 0;
            this.daButton1.pLCBitselectRealize.SafetyPLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daButton1.pLCBitselectRealize.Speech = false;
            this.daButton1.pLCBitselectRealize.Textalign_0 = "MiddleCenter";
            this.daButton1.pLCBitselectRealize.Textalign_1 = "MiddleCenter";
            this.daButton1.pLCBitselectRealize.TextColor_0 = System.Drawing.Color.White;
            this.daButton1.pLCBitselectRealize.TextColor_1 = System.Drawing.Color.White;
            this.daButton1.pLCBitselectRealize.TextContent_0 = "OFF";
            this.daButton1.pLCBitselectRealize.TextContent_1 = "ON";
            this.daButton1.pLCBitselectRealize.Textflicker_0 = 0;
            this.daButton1.pLCBitselectRealize.Textflicker_1 = 0;
            this.daButton1.pLCBitselectRealize.TextFont_0 = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daButton1.pLCBitselectRealize.TextFont_1 = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daButton1.pLCBitselectRealize.TextItalic_0 = false;
            this.daButton1.pLCBitselectRealize.TextItalic_1 = false;
            this.daButton1.pLCBitselectRealize.TextState = 0;
            this.daButton1.pLCBitselectRealize.TextUnderline_0 = false;
            this.daButton1.pLCBitselectRealize.TextUnderline_1 = false;
            this.daButton1.pLCBitselectRealize.WriteAddress = "0";
            this.daButton1.pLCBitselectRealize.WriteFunction = "M";
            this.daButton1.pLCBitselectRealize.WritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daButton1.pLCBitselectRealize.WrSafetyAddress = "0";
            this.daButton1.PLCTimer = null;
            this.daButton1.Size = new System.Drawing.Size(75, 23);
            this.daButton1.TabIndex = 9;
            this.daButton1.Text = "OFF";
            this.daButton1.Textalign_0 = "MiddleCenter";
            this.daButton1.Textalign_1 = "MiddleCenter";
            this.daButton1.TextColor_0 = System.Drawing.Color.White;
            this.daButton1.TextColor_1 = System.Drawing.Color.White;
            this.daButton1.TextContent_0 = "OFF";
            this.daButton1.TextContent_1 = "ON";
            this.daButton1.TextFont_0 = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daButton1.TextFont_1 = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daButton1.UseVisualStyleBackColor = false;
            // 
            // daPlcFunction1
            // 
            this.daPlcFunction1.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.daPlcFunction1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.daPlcFunction1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daPlcFunction1.FormClose = true;
            this.daPlcFunction1.FormName = "TemplateForm";
            this.daPlcFunction1.FormPath = "PLC通讯基础控件项目.模板与控制界面";
            this.daPlcFunction1.Location = new System.Drawing.Point(601, 179);
            this.daPlcFunction1.MinimumSize = new System.Drawing.Size(1, 1);
            this.daPlcFunction1.Name = "daPlcFunction1";
            this.daPlcFunction1.PLC_Enable = false;
            this.daPlcFunction1.Size = new System.Drawing.Size(100, 35);
            this.daPlcFunction1.TabIndex = 10;
            this.daPlcFunction1.Text = "daPlcFunction1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(519, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 114);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // daUiButton3
            // 
            this.daUiButton3.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.daUiButton3.backgroundColor_0 = System.Drawing.Color.Silver;
            this.daUiButton3.backgroundColor_1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.daUiButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.daUiButton3.FillColor = System.Drawing.Color.Silver;
            this.daUiButton3.FillHoverColor = System.Drawing.Color.Silver;
            this.daUiButton3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiButton3.Location = new System.Drawing.Point(36, 69);
            this.daUiButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.daUiButton3.Name = "daUiButton3";
            this.daUiButton3.PLC_Enable = true;
            this.daUiButton3.pLCBitselectRealize.AwaitTime = 0;
            this.daUiButton3.pLCBitselectRealize.backgroundColor_0 = System.Drawing.Color.Silver;
            this.daUiButton3.pLCBitselectRealize.backgroundColor_1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.daUiButton3.pLCBitselectRealize.BitPattern = false;
            this.daUiButton3.pLCBitselectRealize.Compilestate = true;
            this.daUiButton3.pLCBitselectRealize.description = "PLCBitselectRealize";
            this.daUiButton3.pLCBitselectRealize.keyMinTime = 0;
            this.daUiButton3.pLCBitselectRealize.LoosenOut = false;
            this.daUiButton3.pLCBitselectRealize.Macrocode = resources.GetString("resource.Macrocode4");
            this.daUiButton3.pLCBitselectRealize.MacroEvent = "不使用";
            this.daUiButton3.pLCBitselectRealize.macroID = 1;
            this.daUiButton3.pLCBitselectRealize.MacroName = "MacroList1";
            this.daUiButton3.pLCBitselectRealize.NoAccessConceal = false;
            this.daUiButton3.pLCBitselectRealize.NoAccessForm = false;
            this.daUiButton3.pLCBitselectRealize.OperationAffirm = false;
            this.daUiButton3.pLCBitselectRealize.OutReverse = false;
            this.daUiButton3.pLCBitselectRealize.Pattern = PLC通讯基础控件项目.控件类基.控件数据结构.Button_pattern.selector_witch;
            this.daUiButton3.pLCBitselectRealize.PLCTimer = null;
            this.daUiButton3.pLCBitselectRealize.ReadWrite = false;
            this.daUiButton3.pLCBitselectRealize.ReadWriteAddress = "1";
            this.daUiButton3.pLCBitselectRealize.ReadWriteFunction = "RB";
            this.daUiButton3.pLCBitselectRealize.ReadWritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.HMI;
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
            this.daUiButton3.pLCBitselectRealize.TextContent_0 = "OFF";
            this.daUiButton3.pLCBitselectRealize.TextContent_1 = "ON";
            this.daUiButton3.pLCBitselectRealize.Textflicker_0 = 0;
            this.daUiButton3.pLCBitselectRealize.Textflicker_1 = 0;
            this.daUiButton3.pLCBitselectRealize.TextFont_0 = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiButton3.pLCBitselectRealize.TextFont_1 = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiButton3.pLCBitselectRealize.TextItalic_0 = false;
            this.daUiButton3.pLCBitselectRealize.TextItalic_1 = false;
            this.daUiButton3.pLCBitselectRealize.TextState = 0;
            this.daUiButton3.pLCBitselectRealize.TextUnderline_0 = false;
            this.daUiButton3.pLCBitselectRealize.TextUnderline_1 = false;
            this.daUiButton3.pLCBitselectRealize.WriteAddress = "0";
            this.daUiButton3.pLCBitselectRealize.WriteFunction = "M";
            this.daUiButton3.pLCBitselectRealize.WritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daUiButton3.pLCBitselectRealize.WrSafetyAddress = "0";
            this.daUiButton3.PLCTimer = null;
            this.daUiButton3.Size = new System.Drawing.Size(100, 35);
            this.daUiButton3.Style = Sunny.UI.UIStyle.Custom;
            this.daUiButton3.TabIndex = 13;
            this.daUiButton3.Text = "OFF";
            this.daUiButton3.Textalign_0 = "MiddleCenter";
            this.daUiButton3.Textalign_1 = "MiddleCenter";
            this.daUiButton3.TextColor_0 = System.Drawing.Color.White;
            this.daUiButton3.TextColor_1 = System.Drawing.Color.White;
            this.daUiButton3.TextContent_0 = "OFF";
            this.daUiButton3.TextContent_1 = "ON";
            this.daUiButton3.TextFont_0 = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiButton3.TextFont_1 = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // daUiTextBox2
            // 
            this.daUiTextBox2.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.daUiTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.daUiTextBox2.FillColor = System.Drawing.Color.White;
            this.daUiTextBox2.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiTextBox2.ForeColor = System.Drawing.Color.Black;
            this.daUiTextBox2.Location = new System.Drawing.Point(406, 363);
            this.daUiTextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.daUiTextBox2.Maximum = 2147483647D;
            this.daUiTextBox2.Minimum = -2147483648D;
            this.daUiTextBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.daUiTextBox2.Name = "daUiTextBox2";
            this.daUiTextBox2.PLC_Enable = true;
            this.daUiTextBox2.pLCDselectRealize.AwaitTime = 0;
            this.daUiTextBox2.pLCDselectRealize.Compilestate = true;
            this.daUiTextBox2.pLCDselectRealize.Dataentryfunction = true;
            this.daUiTextBox2.pLCDselectRealize.description = "PLCDselectRealize";
            this.daUiTextBox2.pLCDselectRealize.Inform = false;
            this.daUiTextBox2.pLCDselectRealize.InformAddress = "0";
            this.daUiTextBox2.pLCDselectRealize.InformFunction = "M";
            this.daUiTextBox2.pLCDselectRealize.Informpattern = 0;
            this.daUiTextBox2.pLCDselectRealize.InformPLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daUiTextBox2.pLCDselectRealize.Keyboard = true;
            this.daUiTextBox2.pLCDselectRealize.KeyboardStyle = "keyboard";
            this.daUiTextBox2.pLCDselectRealize.keyMinTime = 0;
            this.daUiTextBox2.pLCDselectRealize.Macrocode = resources.GetString("resource.Macrocode5");
            this.daUiTextBox2.pLCDselectRealize.MacroEvent = "Click";
            this.daUiTextBox2.pLCDselectRealize.macroID = 1;
            this.daUiTextBox2.pLCDselectRealize.MacroName = "MacroList1";
            this.daUiTextBox2.pLCDselectRealize.NoAccessConceal = false;
            this.daUiTextBox2.pLCDselectRealize.NoAccessForm = false;
            this.daUiTextBox2.pLCDselectRealize.NumericaldigitMax = 7;
            this.daUiTextBox2.pLCDselectRealize.NumericaldigitMin = 0;
            this.daUiTextBox2.pLCDselectRealize.NumericalFormat = 0;
            this.daUiTextBox2.pLCDselectRealize.NumericalMax = 9999999;
            this.daUiTextBox2.pLCDselectRealize.NumericalMin = -999999;
            this.daUiTextBox2.pLCDselectRealize.OperationAffirm = false;
            this.daUiTextBox2.pLCDselectRealize.PLCTimer = null;
            this.daUiTextBox2.pLCDselectRealize.ReadWrite = false;
            this.daUiTextBox2.pLCDselectRealize.ReadWriteAddress = "1";
            this.daUiTextBox2.pLCDselectRealize.ReadWriteFunction = "RW";
            this.daUiTextBox2.pLCDselectRealize.ReadWritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.HMI;
            this.daUiTextBox2.pLCDselectRealize.SafetyBehaviorPattern = 1;
            this.daUiTextBox2.pLCDselectRealize.SafetyCategory = 0;
            this.daUiTextBox2.pLCDselectRealize.SafetyFunction = "M";
            this.daUiTextBox2.pLCDselectRealize.SafetyPattern = 1;
            this.daUiTextBox2.pLCDselectRealize.SafetyPLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daUiTextBox2.pLCDselectRealize.ShowFormat = PLC通讯库.通讯枚举.numerical_format.Signed_32_Bit;
            this.daUiTextBox2.pLCDselectRealize.Speech = false;
            this.daUiTextBox2.pLCDselectRealize.Textalign_0 = "BottomCenter";
            this.daUiTextBox2.pLCDselectRealize.Textalign_1 = "BottomCenter";
            this.daUiTextBox2.pLCDselectRealize.TextColor_0 = System.Drawing.Color.Black;
            this.daUiTextBox2.pLCDselectRealize.TextColor_1 = System.Drawing.Color.Black;
            this.daUiTextBox2.pLCDselectRealize.TextContent_0 = "PLCpropertyText";
            this.daUiTextBox2.pLCDselectRealize.TextContent_1 = null;
            this.daUiTextBox2.pLCDselectRealize.Textflicker_0 = 0;
            this.daUiTextBox2.pLCDselectRealize.Textflicker_1 = 0;
            this.daUiTextBox2.pLCDselectRealize.TextFont_0 = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiTextBox2.pLCDselectRealize.TextFont_1 = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiTextBox2.pLCDselectRealize.TextItalic_0 = false;
            this.daUiTextBox2.pLCDselectRealize.TextItalic_1 = false;
            this.daUiTextBox2.pLCDselectRealize.TextUnderline_0 = false;
            this.daUiTextBox2.pLCDselectRealize.TextUnderline_1 = false;
            this.daUiTextBox2.pLCDselectRealize.WriteAddress = "0";
            this.daUiTextBox2.pLCDselectRealize.WriteFunction = "D";
            this.daUiTextBox2.pLCDselectRealize.WritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daUiTextBox2.pLCDselectRealize.WrSafetyAddress = "0";
            this.daUiTextBox2.PLCTimer = null;
            this.daUiTextBox2.Size = new System.Drawing.Size(150, 29);
            this.daUiTextBox2.Style = Sunny.UI.UIStyle.Custom;
            this.daUiTextBox2.TabIndex = 14;
            this.daUiTextBox2.Text = "0";
            this.daUiTextBox2.Textalign_0 = "BottomCenter";
            this.daUiTextBox2.Textalign_1 = "BottomCenter";
            this.daUiTextBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.daUiTextBox2.TextColor_0 = System.Drawing.Color.Black;
            this.daUiTextBox2.TextColor_1 = System.Drawing.Color.Black;
            this.daUiTextBox2.TextContent_0 = "PLCpropertyText";
            this.daUiTextBox2.TextContent_1 = null;
            this.daUiTextBox2.TextFont_0 = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiTextBox2.TextFont_1 = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // daUiTextBox3
            // 
            this.daUiTextBox3.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.daUiTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.daUiTextBox3.FillColor = System.Drawing.Color.White;
            this.daUiTextBox3.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiTextBox3.ForeColor = System.Drawing.Color.Black;
            this.daUiTextBox3.Location = new System.Drawing.Point(597, 363);
            this.daUiTextBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.daUiTextBox3.Maximum = 2147483647D;
            this.daUiTextBox3.Minimum = -2147483648D;
            this.daUiTextBox3.MinimumSize = new System.Drawing.Size(1, 1);
            this.daUiTextBox3.Name = "daUiTextBox3";
            this.daUiTextBox3.PLC_Enable = true;
            this.daUiTextBox3.pLCDselectRealize.AwaitTime = 0;
            this.daUiTextBox3.pLCDselectRealize.Compilestate = true;
            this.daUiTextBox3.pLCDselectRealize.Dataentryfunction = true;
            this.daUiTextBox3.pLCDselectRealize.description = "PLCDselectRealize";
            this.daUiTextBox3.pLCDselectRealize.Inform = false;
            this.daUiTextBox3.pLCDselectRealize.InformAddress = "0";
            this.daUiTextBox3.pLCDselectRealize.InformFunction = "M";
            this.daUiTextBox3.pLCDselectRealize.Informpattern = 0;
            this.daUiTextBox3.pLCDselectRealize.InformPLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daUiTextBox3.pLCDselectRealize.Keyboard = true;
            this.daUiTextBox3.pLCDselectRealize.KeyboardStyle = "keyboard";
            this.daUiTextBox3.pLCDselectRealize.keyMinTime = 0;
            this.daUiTextBox3.pLCDselectRealize.Macrocode = resources.GetString("resource.Macrocode6");
            this.daUiTextBox3.pLCDselectRealize.MacroEvent = "Click";
            this.daUiTextBox3.pLCDselectRealize.macroID = 1;
            this.daUiTextBox3.pLCDselectRealize.MacroName = "MacroList1";
            this.daUiTextBox3.pLCDselectRealize.NoAccessConceal = false;
            this.daUiTextBox3.pLCDselectRealize.NoAccessForm = false;
            this.daUiTextBox3.pLCDselectRealize.NumericaldigitMax = 7;
            this.daUiTextBox3.pLCDselectRealize.NumericaldigitMin = 0;
            this.daUiTextBox3.pLCDselectRealize.NumericalFormat = 0;
            this.daUiTextBox3.pLCDselectRealize.NumericalMax = 9999999;
            this.daUiTextBox3.pLCDselectRealize.NumericalMin = -999999;
            this.daUiTextBox3.pLCDselectRealize.OperationAffirm = false;
            this.daUiTextBox3.pLCDselectRealize.PLCTimer = null;
            this.daUiTextBox3.pLCDselectRealize.ReadWrite = false;
            this.daUiTextBox3.pLCDselectRealize.ReadWriteAddress = "1";
            this.daUiTextBox3.pLCDselectRealize.ReadWriteFunction = "RW";
            this.daUiTextBox3.pLCDselectRealize.ReadWritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.HMI;
            this.daUiTextBox3.pLCDselectRealize.SafetyBehaviorPattern = 1;
            this.daUiTextBox3.pLCDselectRealize.SafetyCategory = 0;
            this.daUiTextBox3.pLCDselectRealize.SafetyFunction = "M";
            this.daUiTextBox3.pLCDselectRealize.SafetyPattern = 1;
            this.daUiTextBox3.pLCDselectRealize.SafetyPLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daUiTextBox3.pLCDselectRealize.ShowFormat = PLC通讯库.通讯枚举.numerical_format.Signed_32_Bit;
            this.daUiTextBox3.pLCDselectRealize.Speech = false;
            this.daUiTextBox3.pLCDselectRealize.Textalign_0 = "BottomCenter";
            this.daUiTextBox3.pLCDselectRealize.Textalign_1 = "BottomCenter";
            this.daUiTextBox3.pLCDselectRealize.TextColor_0 = System.Drawing.Color.Black;
            this.daUiTextBox3.pLCDselectRealize.TextColor_1 = System.Drawing.Color.Black;
            this.daUiTextBox3.pLCDselectRealize.TextContent_0 = "PLCpropertyText";
            this.daUiTextBox3.pLCDselectRealize.TextContent_1 = null;
            this.daUiTextBox3.pLCDselectRealize.Textflicker_0 = 0;
            this.daUiTextBox3.pLCDselectRealize.Textflicker_1 = 0;
            this.daUiTextBox3.pLCDselectRealize.TextFont_0 = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiTextBox3.pLCDselectRealize.TextFont_1 = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiTextBox3.pLCDselectRealize.TextItalic_0 = false;
            this.daUiTextBox3.pLCDselectRealize.TextItalic_1 = false;
            this.daUiTextBox3.pLCDselectRealize.TextUnderline_0 = false;
            this.daUiTextBox3.pLCDselectRealize.TextUnderline_1 = false;
            this.daUiTextBox3.pLCDselectRealize.WriteAddress = "0";
            this.daUiTextBox3.pLCDselectRealize.WriteFunction = "D";
            this.daUiTextBox3.pLCDselectRealize.WritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daUiTextBox3.pLCDselectRealize.WrSafetyAddress = "0";
            this.daUiTextBox3.PLCTimer = null;
            this.daUiTextBox3.Size = new System.Drawing.Size(150, 29);
            this.daUiTextBox3.Style = Sunny.UI.UIStyle.Custom;
            this.daUiTextBox3.TabIndex = 15;
            this.daUiTextBox3.Text = "0";
            this.daUiTextBox3.Textalign_0 = "BottomCenter";
            this.daUiTextBox3.Textalign_1 = "BottomCenter";
            this.daUiTextBox3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.daUiTextBox3.TextColor_0 = System.Drawing.Color.Black;
            this.daUiTextBox3.TextColor_1 = System.Drawing.Color.Black;
            this.daUiTextBox3.TextContent_0 = "PLCpropertyText";
            this.daUiTextBox3.TextContent_1 = null;
            this.daUiTextBox3.TextFont_0 = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiTextBox3.TextFont_1 = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.daUiTextBox3);
            this.Controls.Add(this.daUiTextBox2);
            this.Controls.Add(this.daUiButton3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.daPlcFunction1);
            this.Controls.Add(this.daButton1);
            this.Controls.Add(this.daUiTextBox1);
            this.Controls.Add(this.uiRichTextBox1);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.uiComboBox1);
            this.Controls.Add(this.daMacroControl1);
            this.Controls.Add(this.daUiButton2);
            this.Controls.Add(this.daUiButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private PLC通讯基础控件项目.PLCControlsPreferences plcControlsPreferences1;
        private PLC通讯基础控件项目.PLC参数设置控件.PLCPreferences plcPreferences1;
        private PLC通讯基础控件项目.PLC参数设置控件.PLCPreferences plcPreferences2;
        private PLC通讯基础控件项目.PLC参数设置控件.PLCPreferences plcPreferences3;
        private PLC通讯基础控件项目.PLC参数设置控件.PLCPreferences plcPreferences4;
        private PLC通讯基础控件项目.PLC参数设置控件.PLCPreferences plcPreferences5;
        private PLC通讯基础控件项目.PLC参数设置控件.PLCPreferences plcPreferences6;
        private PLC通讯基础控件项目.基础控件.DAUiButton daUiButton2;
        private PLC通讯基础控件项目.基础控件.DAUiButton daUiButton1;
        private PLC通讯基础控件项目.基础控件.宏指令控件.DAMacroControl daMacroControl1;
        private Sunny.UI.UIComboBox uiComboBox1;
        private Sunny.UI.UIButton uiButton1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private Sunny.UI.UIRichTextBox uiRichTextBox1;
        private PLC通讯基础控件项目.基础控件.DAUiTextBox daUiTextBox1;
        private PLC通讯基础控件项目.基础控件.DAButton daButton1;
        private PLC通讯基础控件项目.基础控件.底层PLC状态监控控件.DAPlcFunction daPlcFunction1;
        private System.Windows.Forms.Button button1;
        private PLC通讯基础控件项目.基础控件.DAUiButton daUiButton3;
        private PLC通讯基础控件项目.基础控件.DAUiTextBox daUiTextBox2;
        private PLC通讯基础控件项目.基础控件.DAUiTextBox daUiTextBox3;
    }
}