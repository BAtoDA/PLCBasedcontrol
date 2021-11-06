

namespace 控件测试项目
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
            PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLC多功能控件实现类.PLCMultifunctionClassBase plcMultifunctionClassBase1 = new PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLC多功能控件实现类.PLCMultifunctionClassBase();
            PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLC多功能控件实现类.PLCMultifunctionClassBase plcMultifunctionClassBase2 = new PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLC多功能控件实现类.PLCMultifunctionClassBase();
            PLC通讯基础控件项目.基础控件.R r1 = new PLC通讯基础控件项目.基础控件.R();
            PLC通讯基础控件项目.基础控件.R r2 = new PLC通讯基础控件项目.基础控件.R();
            PLC通讯基础控件项目.基础控件.R r3 = new PLC通讯基础控件项目.基础控件.R();
            PLC通讯基础控件项目.基础控件.R r4 = new PLC通讯基础控件项目.基础控件.R();
            PLC通讯基础控件项目.基础控件.R r5 = new PLC通讯基础控件项目.基础控件.R();
            PLC通讯基础控件项目.基础控件.R r6 = new PLC通讯基础控件项目.基础控件.R();
            this.plcControlsPreferences1 = new PLC通讯基础控件项目.PLCControlsPreferences(this.components);
            this.plcPreferences2 = new PLC通讯基础控件项目.PLC参数设置控件.PLCPreferences();
            this.plcPreferences3 = new PLC通讯基础控件项目.PLC参数设置控件.PLCPreferences();
            this.plcPreferences1 = new PLC通讯基础控件项目.PLC参数设置控件.PLCPreferences();
            this.daUiButton1 = new PLC通讯基础控件项目.基础控件.DAUiButton();
            this.plcControlSwitch1 = new PLC通讯基础控件项目.PLC参数设置控件.控件状态切换控件.PLCControlSwitch(this.components);
            this.daUiButton2 = new PLC通讯基础控件项目.基础控件.DAUiButton();
            this.plcStatusView1 = new PLC通讯基础控件项目.基础控件.底层PLC状态监控控件.PLCStatusView();
            this.uiLine1 = new Sunny.UI.UILine();
            this.uiLine2 = new Sunny.UI.UILine();
            this.uiLine3 = new Sunny.UI.UILine();
            this.uiLine4 = new Sunny.UI.UILine();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.plcStatusView2 = new PLC通讯基础控件项目.基础控件.底层PLC状态监控控件.PLCStatusView();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.plcStatusView3 = new PLC通讯基础控件项目.基础控件.底层PLC状态监控控件.PLCStatusView();
            this.uiLine5 = new Sunny.UI.UILine();
            this.daIhatetheqrcode1 = new PLC通讯基础控件项目.基础控件.DAIhatetheqrcode();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.uiListBox1 = new Sunny.UI.UIListBox();
            this.daPlcFunction1 = new PLC通讯基础控件项目.基础控件.底层PLC状态监控控件.DAPlcFunction();
            this.daMultifunction1 = new PLC通讯基础控件项目.基础控件.DAMultifunction();
            this.daPlcGraph1 = new PLC通讯基础控件项目.基础控件.DAPlcGraph();
            ((System.ComponentModel.ISupportInitialize)(this.daIhatetheqrcode1)).BeginInit();
            this.SuspendLayout();
            // 
            // plcControlsPreferences1
            // 
            this.plcControlsPreferences1.Enabled = true;
            this.plcControlsPreferences1.Interval = 1000;
            this.plcControlsPreferences1.PLCPreferences.Add(this.plcPreferences2);
            this.plcControlsPreferences1.PLCPreferences.Add(this.plcPreferences3);
            this.plcControlsPreferences1.PLCPreferences.Add(this.plcPreferences1);
            // 
            // plcPreferences2
            // 
            this.plcPreferences2.IPEnd = "192.168.3.34";
            this.plcPreferences2.PLCDevice = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Fanuc;
            this.plcPreferences2.Point = 2000;
            this.plcPreferences2.Receptionovertime = 1000;
            this.plcPreferences2.Retain = "S1500";
            this.plcPreferences2.Sendovertime = 1000;
            // 
            // plcPreferences3
            // 
            this.plcPreferences3.IPEnd = "192.168.88.105";
            this.plcPreferences3.PLCDevice = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Modbus_TCP;
            this.plcPreferences3.Point = 8000;
            this.plcPreferences3.Receptionovertime = 1000;
            this.plcPreferences3.Retain = "S1500";
            this.plcPreferences3.Sendovertime = 1000;
            // 
            // plcPreferences1
            // 
            this.plcPreferences1.IPEnd = "192.168.3.240";
            this.plcPreferences1.PLCDevice = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.plcPreferences1.Point = 5002;
            this.plcPreferences1.Receptionovertime = 1000;
            this.plcPreferences1.Retain = "S1500";
            this.plcPreferences1.Sendovertime = 1000;
            // 
            // daUiButton1
            // 
            this.daUiButton1.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.daUiButton1.backgroundColor_0 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(61)))), ((int)(((byte)(139)))));
            this.daUiButton1.backgroundColor_1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.daUiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.daUiButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(61)))), ((int)(((byte)(139)))));
            this.daUiButton1.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(61)))), ((int)(((byte)(139)))));
            this.daUiButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiButton1.Location = new System.Drawing.Point(240, 363);
            this.daUiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.daUiButton1.Name = "daUiButton1";
            this.daUiButton1.PLC_Enable = true;
            this.daUiButton1.pLCBitselectRealize.AwaitTime = 0;
            this.daUiButton1.pLCBitselectRealize.backgroundColor_0 = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(61)))), ((int)(((byte)(139)))));
            this.daUiButton1.pLCBitselectRealize.backgroundColor_1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.daUiButton1.pLCBitselectRealize.BitPattern = false;
            this.daUiButton1.pLCBitselectRealize.description = "PLCBitselectRealize";
            this.daUiButton1.pLCBitselectRealize.keyMinTime = 0;
            this.daUiButton1.pLCBitselectRealize.LoosenOut = false;
            this.daUiButton1.pLCBitselectRealize.NoAccessConceal = false;
            this.daUiButton1.pLCBitselectRealize.NoAccessForm = false;
            this.daUiButton1.pLCBitselectRealize.OperationAffirm = false;
            this.daUiButton1.pLCBitselectRealize.OutReverse = false;
            this.daUiButton1.pLCBitselectRealize.Pattern = PLC通讯基础控件项目.控件类基.控件数据结构.Button_pattern.selector_witch;
            this.daUiButton1.pLCBitselectRealize.PLCTimer = null;
            this.daUiButton1.pLCBitselectRealize.ReadWrite = false;
            this.daUiButton1.pLCBitselectRealize.ReadWriteAddress = "10";
            this.daUiButton1.pLCBitselectRealize.ReadWriteFunction = "X";
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
            this.daUiButton1.pLCBitselectRealize.TextContent_0 = "OFF-M10";
            this.daUiButton1.pLCBitselectRealize.TextContent_1 = "ON-M10";
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
            this.daUiButton1.TabIndex = 7;
            this.daUiButton1.Text = "OFF-M10";
            this.daUiButton1.Textalign_0 = "MiddleCenter";
            this.daUiButton1.Textalign_1 = "MiddleCenter";
            this.daUiButton1.TextColor_0 = System.Drawing.Color.White;
            this.daUiButton1.TextColor_1 = System.Drawing.Color.White;
            this.daUiButton1.TextContent_0 = "OFF-M10";
            this.daUiButton1.TextContent_1 = "ON-M10";
            this.daUiButton1.TextFont_0 = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiButton1.TextFont_1 = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiButton1.Click += new System.EventHandler(this.daUiButton1_Click);
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
            this.daUiButton2.Location = new System.Drawing.Point(443, 240);
            this.daUiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.daUiButton2.Name = "daUiButton2";
            this.daUiButton2.PLC_Enable = true;
            this.daUiButton2.pLCBitselectRealize.AwaitTime = 0;
            this.daUiButton2.pLCBitselectRealize.backgroundColor_0 = System.Drawing.Color.Silver;
            this.daUiButton2.pLCBitselectRealize.backgroundColor_1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.daUiButton2.pLCBitselectRealize.BitPattern = false;
            this.daUiButton2.pLCBitselectRealize.description = "PLCBitselectRealize";
            this.daUiButton2.pLCBitselectRealize.keyMinTime = 0;
            this.daUiButton2.pLCBitselectRealize.LoosenOut = false;
            this.daUiButton2.pLCBitselectRealize.NoAccessConceal = false;
            this.daUiButton2.pLCBitselectRealize.NoAccessForm = false;
            this.daUiButton2.pLCBitselectRealize.OperationAffirm = false;
            this.daUiButton2.pLCBitselectRealize.OutReverse = false;
            this.daUiButton2.pLCBitselectRealize.Pattern = PLC通讯基础控件项目.控件类基.控件数据结构.Button_pattern.selector_witch;
            this.daUiButton2.pLCBitselectRealize.PLCTimer = null;
            this.daUiButton2.pLCBitselectRealize.ReadWrite = false;
            this.daUiButton2.pLCBitselectRealize.ReadWriteAddress = "10";
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
            this.daUiButton2.pLCBitselectRealize.TextContent_0 = "OFF-M10";
            this.daUiButton2.pLCBitselectRealize.TextContent_1 = "ON-M10";
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
            this.daUiButton2.TabIndex = 5;
            this.daUiButton2.Text = "OFF-M10";
            this.daUiButton2.Textalign_0 = "MiddleCenter";
            this.daUiButton2.Textalign_1 = "MiddleCenter";
            this.daUiButton2.TextColor_0 = System.Drawing.Color.White;
            this.daUiButton2.TextColor_1 = System.Drawing.Color.White;
            this.daUiButton2.TextContent_0 = "OFF-M10";
            this.daUiButton2.TextContent_1 = "ON-M10";
            this.daUiButton2.TextFont_0 = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiButton2.TextFont_1 = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // plcStatusView1
            // 
            this.plcStatusView1.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Modbus_TCP;
            this.plcStatusView1.AutoSize = true;
            this.plcStatusView1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.plcStatusView1.BackColor = System.Drawing.Color.Transparent;
            this.plcStatusView1.Location = new System.Drawing.Point(611, 366);
            this.plcStatusView1.MinimumSize = new System.Drawing.Size(101, 110);
            this.plcStatusView1.Name = "plcStatusView1";
            this.plcStatusView1.PLC_Enable = true;
            this.plcStatusView1.Size = new System.Drawing.Size(101, 110);
            this.plcStatusView1.TabIndex = 11;
            // 
            // uiLine1
            // 
            this.uiLine1.FillColor = System.Drawing.Color.Transparent;
            this.uiLine1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLine1.Location = new System.Drawing.Point(473, 493);
            this.uiLine1.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(360, 14);
            this.uiLine1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine1.TabIndex = 12;
            // 
            // uiLine2
            // 
            this.uiLine2.Direction = Sunny.UI.UILine.LineDirection.Vertical;
            this.uiLine2.FillColor = System.Drawing.Color.Transparent;
            this.uiLine2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLine2.Location = new System.Drawing.Point(642, 470);
            this.uiLine2.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine2.Name = "uiLine2";
            this.uiLine2.Size = new System.Drawing.Size(31, 29);
            this.uiLine2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine2.TabIndex = 13;
            // 
            // uiLine3
            // 
            this.uiLine3.FillColor = System.Drawing.Color.Transparent;
            this.uiLine3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLine3.Location = new System.Drawing.Point(473, 500);
            this.uiLine3.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine3.Name = "uiLine3";
            this.uiLine3.Size = new System.Drawing.Size(360, 17);
            this.uiLine3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine3.TabIndex = 14;
            // 
            // uiLine4
            // 
            this.uiLine4.Direction = Sunny.UI.UILine.LineDirection.Vertical;
            this.uiLine4.FillColor = System.Drawing.Color.Transparent;
            this.uiLine4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLine4.Location = new System.Drawing.Point(518, 509);
            this.uiLine4.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine4.Name = "uiLine4";
            this.uiLine4.Size = new System.Drawing.Size(31, 29);
            this.uiLine4.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine4.TabIndex = 15;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel1.Location = new System.Drawing.Point(607, 346);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(98, 23);
            this.uiLabel1.TabIndex = 16;
            this.uiLabel1.Text = "Modbus TCP";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // plcStatusView2
            // 
            this.plcStatusView2.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.plcStatusView2.AutoSize = true;
            this.plcStatusView2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.plcStatusView2.BackColor = System.Drawing.Color.Transparent;
            this.plcStatusView2.Location = new System.Drawing.Point(492, 536);
            this.plcStatusView2.MinimumSize = new System.Drawing.Size(101, 110);
            this.plcStatusView2.Name = "plcStatusView2";
            this.plcStatusView2.PLC_Enable = true;
            this.plcStatusView2.Size = new System.Drawing.Size(101, 110);
            this.plcStatusView2.TabIndex = 17;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel2.Location = new System.Drawing.Point(496, 647);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(98, 23);
            this.uiLabel2.TabIndex = 18;
            this.uiLabel2.Text = "Mitsubishi";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel3.Location = new System.Drawing.Point(734, 645);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(98, 23);
            this.uiLabel3.TabIndex = 20;
            this.uiLabel3.Text = "Siemens";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // plcStatusView3
            // 
            this.plcStatusView3.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Siemens;
            this.plcStatusView3.AutoSize = true;
            this.plcStatusView3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.plcStatusView3.BackColor = System.Drawing.Color.Transparent;
            this.plcStatusView3.Location = new System.Drawing.Point(724, 537);
            this.plcStatusView3.MinimumSize = new System.Drawing.Size(101, 110);
            this.plcStatusView3.Name = "plcStatusView3";
            this.plcStatusView3.PLC_Enable = true;
            this.plcStatusView3.Size = new System.Drawing.Size(101, 110);
            this.plcStatusView3.TabIndex = 19;
            // 
            // uiLine5
            // 
            this.uiLine5.Direction = Sunny.UI.UILine.LineDirection.Vertical;
            this.uiLine5.FillColor = System.Drawing.Color.Transparent;
            this.uiLine5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLine5.Location = new System.Drawing.Point(752, 509);
            this.uiLine5.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine5.Name = "uiLine5";
            this.uiLine5.Size = new System.Drawing.Size(31, 29);
            this.uiLine5.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine5.TabIndex = 21;
            // 
            // daIhatetheqrcode1
            // 
            this.daIhatetheqrcode1.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.daIhatetheqrcode1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("daIhatetheqrcode1.BackgroundImage")));
            this.daIhatetheqrcode1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.daIhatetheqrcode1.Location = new System.Drawing.Point(64, 459);
            this.daIhatetheqrcode1.Name = "daIhatetheqrcode1";
            this.daIhatetheqrcode1.PLC_Enable = true;
            this.daIhatetheqrcode1.pLCQRcodeRealize.BindingName = "uiButton1";
            this.daIhatetheqrcode1.pLCQRcodeRealize.BindingOpen = true;
            this.daIhatetheqrcode1.pLCQRcodeRealize.ReadWriteAddress = "0";
            this.daIhatetheqrcode1.pLCQRcodeRealize.ReadWriteFunction = "D";
            this.daIhatetheqrcode1.pLCQRcodeRealize.ReadWritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Modbus_TCP;
            this.daIhatetheqrcode1.pLCQRcodeRealize.Select = true;
            this.daIhatetheqrcode1.pLCQRcodeRealize.ShowFormat = PLC通讯库.通讯枚举.numerical_format.Signed_16_Bit;
            this.daIhatetheqrcode1.pLCQRcodeRealize.WriteAddress = "0";
            this.daIhatetheqrcode1.pLCQRcodeRealize.WriteFunction = "Y";
            this.daIhatetheqrcode1.pLCQRcodeRealize.WritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Modbus_TCP;
            this.daIhatetheqrcode1.Size = new System.Drawing.Size(276, 144);
            this.daIhatetheqrcode1.TabIndex = 22;
            this.daIhatetheqrcode1.TabStop = false;
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiButton1.Location = new System.Drawing.Point(145, 609);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(100, 35);
            this.uiButton1.TabIndex = 23;
            this.uiButton1.Text = "uiButton1";
            // 
            // uiListBox1
            // 
            this.uiListBox1.FillColor = System.Drawing.Color.White;
            this.uiListBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiListBox1.FormatString = "";
            this.uiListBox1.Items.AddRange(new object[] {
            "顶顶顶",
            "顶顶顶"});
            this.uiListBox1.ItemSelectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.uiListBox1.Location = new System.Drawing.Point(876, 387);
            this.uiListBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiListBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiListBox1.Name = "uiListBox1";
            this.uiListBox1.Padding = new System.Windows.Forms.Padding(2);
            this.uiListBox1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.uiListBox1.Size = new System.Drawing.Size(270, 180);
            this.uiListBox1.Style = Sunny.UI.UIStyle.White;
            this.uiListBox1.TabIndex = 24;
            this.uiListBox1.Text = "uiListBox1";
            // 
            // daPlcFunction1
            // 
            this.daPlcFunction1.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.daPlcFunction1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.daPlcFunction1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daPlcFunction1.FormName = "Fomr1";
            this.daPlcFunction1.FormPath = "控件测试项目.dddddd";
            this.daPlcFunction1.Location = new System.Drawing.Point(420, 362);
            this.daPlcFunction1.MinimumSize = new System.Drawing.Size(1, 1);
            this.daPlcFunction1.Name = "daPlcFunction1";
            this.daPlcFunction1.PLC_Enable = true;
            this.daPlcFunction1.Size = new System.Drawing.Size(100, 35);
            this.daPlcFunction1.TabIndex = 25;
            this.daPlcFunction1.Text = "daPlcFunction1";
            // 
            // daMultifunction1
            // 
            this.daMultifunction1.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.daMultifunction1.AwaitTime = 100;
            this.daMultifunction1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.daMultifunction1.backgroundColor_0 = System.Drawing.Color.Silver;
            this.daMultifunction1.backgroundColor_1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.daMultifunction1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.daMultifunction1.FillColor = System.Drawing.Color.Silver;
            this.daMultifunction1.FillHoverColor = System.Drawing.Color.Silver;
            this.daMultifunction1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daMultifunction1.keyMinTime = 100;
            this.daMultifunction1.Location = new System.Drawing.Point(392, 447);
            this.daMultifunction1.MinimumSize = new System.Drawing.Size(1, 1);
            this.daMultifunction1.Name = "daMultifunction1";
            this.daMultifunction1.NoAccessConceal = false;
            this.daMultifunction1.NoAccessForm = false;
            this.daMultifunction1.OperationAffirm = false;
            this.daMultifunction1.PLC_Enable = true;
            this.daMultifunction1.pLCBitselectRealizeq.AwaitTime = 0;
            this.daMultifunction1.pLCBitselectRealizeq.backgroundColor_0 = System.Drawing.Color.Silver;
            this.daMultifunction1.pLCBitselectRealizeq.backgroundColor_1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.daMultifunction1.pLCBitselectRealizeq.BitPattern = false;
            this.daMultifunction1.pLCBitselectRealizeq.description = "PLCBitselectRealize";
            this.daMultifunction1.pLCBitselectRealizeq.keyMinTime = 0;
            this.daMultifunction1.pLCBitselectRealizeq.LoosenOut = false;
            this.daMultifunction1.pLCBitselectRealizeq.NoAccessConceal = false;
            this.daMultifunction1.pLCBitselectRealizeq.NoAccessForm = false;
            this.daMultifunction1.pLCBitselectRealizeq.OperationAffirm = false;
            this.daMultifunction1.pLCBitselectRealizeq.OutReverse = false;
            this.daMultifunction1.pLCBitselectRealizeq.Pattern = PLC通讯基础控件项目.控件类基.控件数据结构.Button_pattern.selector_witch;
            this.daMultifunction1.pLCBitselectRealizeq.PLCTimer = null;
            this.daMultifunction1.pLCBitselectRealizeq.ReadWrite = false;
            this.daMultifunction1.pLCBitselectRealizeq.ReadWriteAddress = "0";
            this.daMultifunction1.pLCBitselectRealizeq.ReadWriteFunction = "M";
            this.daMultifunction1.pLCBitselectRealizeq.ReadWritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daMultifunction1.pLCBitselectRealizeq.SafetyBehaviorPattern = 0;
            this.daMultifunction1.pLCBitselectRealizeq.SafetyCategory = 0;
            this.daMultifunction1.pLCBitselectRealizeq.SafetyFunction = "M";
            this.daMultifunction1.pLCBitselectRealizeq.SafetyPattern = 0;
            this.daMultifunction1.pLCBitselectRealizeq.SafetyPLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daMultifunction1.pLCBitselectRealizeq.Speech = false;
            this.daMultifunction1.pLCBitselectRealizeq.Textalign_0 = "MiddleCenter";
            this.daMultifunction1.pLCBitselectRealizeq.Textalign_1 = "MiddleCenter";
            this.daMultifunction1.pLCBitselectRealizeq.TextColor_0 = System.Drawing.Color.White;
            this.daMultifunction1.pLCBitselectRealizeq.TextColor_1 = System.Drawing.Color.White;
            this.daMultifunction1.pLCBitselectRealizeq.TextContent_0 = "OFF";
            this.daMultifunction1.pLCBitselectRealizeq.TextContent_1 = "ON";
            this.daMultifunction1.pLCBitselectRealizeq.Textflicker_0 = 0;
            this.daMultifunction1.pLCBitselectRealizeq.Textflicker_1 = 0;
            this.daMultifunction1.pLCBitselectRealizeq.TextFont_0 = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daMultifunction1.pLCBitselectRealizeq.TextFont_1 = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daMultifunction1.pLCBitselectRealizeq.TextItalic_0 = false;
            this.daMultifunction1.pLCBitselectRealizeq.TextItalic_1 = false;
            this.daMultifunction1.pLCBitselectRealizeq.TextState = 0;
            this.daMultifunction1.pLCBitselectRealizeq.TextUnderline_0 = false;
            this.daMultifunction1.pLCBitselectRealizeq.TextUnderline_1 = false;
            this.daMultifunction1.pLCBitselectRealizeq.WriteAddress = "0";
            this.daMultifunction1.pLCBitselectRealizeq.WriteFunction = "M";
            this.daMultifunction1.pLCBitselectRealizeq.WritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daMultifunction1.pLCBitselectRealizeq.WrSafetyAddress = "0";
            plcMultifunctionClassBase1.ClassInterface = "PLCMultifunctionBitBase";
            plcMultifunctionClassBase1.FormName = "TemplateForm";
            plcMultifunctionClassBase1.FormPath = "PLC通讯基础控件项目.模板与控制界面";
            plcMultifunctionClassBase1.OutReverse = false;
            plcMultifunctionClassBase1.ReadWriteBitAddress = "0";
            plcMultifunctionClassBase1.ReadWriteBitFunction = "M";
            plcMultifunctionClassBase1.ReadWriteBitPLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            plcMultifunctionClassBase1.ReadWriteDAddress = "0";
            plcMultifunctionClassBase1.ReadWriteDFunction = "D";
            plcMultifunctionClassBase1.ReadWriteDPLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            plcMultifunctionClassBase1.ShowFormat = PLC通讯库.通讯枚举.numerical_format.Signed_16_Bit;
            plcMultifunctionClassBase1.Value = 0;
            plcMultifunctionClassBase1.ValueBit = "ON";
            plcMultifunctionClassBase2.ClassInterface = "PLCMultifunctionBitBase";
            plcMultifunctionClassBase2.FormName = "TemplateForm";
            plcMultifunctionClassBase2.FormPath = "PLC通讯基础控件项目.模板与控制界面";
            plcMultifunctionClassBase2.OutReverse = false;
            plcMultifunctionClassBase2.ReadWriteBitAddress = "0";
            plcMultifunctionClassBase2.ReadWriteBitFunction = "M";
            plcMultifunctionClassBase2.ReadWriteBitPLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            plcMultifunctionClassBase2.ReadWriteDAddress = "0";
            plcMultifunctionClassBase2.ReadWriteDFunction = "D";
            plcMultifunctionClassBase2.ReadWriteDPLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            plcMultifunctionClassBase2.ShowFormat = PLC通讯库.通讯枚举.numerical_format.Signed_16_Bit;
            plcMultifunctionClassBase2.Value = 0;
            plcMultifunctionClassBase2.ValueBit = "ON";
            this.daMultifunction1.pLCMultifunctions = new PLC通讯基础控件项目.控件类基.PLC基础接口.PLC基础实现类.PLC多功能控件实现类.PLCMultifunctionClassBase[] {
        plcMultifunctionClassBase1,
        plcMultifunctionClassBase2};
            this.daMultifunction1.PLCTimer = null;
            this.daMultifunction1.ReadAddress = "1";
            this.daMultifunction1.ReadFunction = "Y";
            this.daMultifunction1.ReadPLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Modbus_TCP;
            this.daMultifunction1.SafetyBehaviorPattern = 0;
            this.daMultifunction1.SafetyCategory = 0;
            this.daMultifunction1.SafetyFunction = "M";
            this.daMultifunction1.SafetyPattern = 0;
            this.daMultifunction1.SafetyPLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daMultifunction1.Size = new System.Drawing.Size(100, 35);
            this.daMultifunction1.Speech = false;
            this.daMultifunction1.Style = Sunny.UI.UIStyle.Custom;
            this.daMultifunction1.StyleCustomMode = true;
            this.daMultifunction1.TabIndex = 26;
            this.daMultifunction1.Text = "OFF";
            this.daMultifunction1.Textalign_0 = "MiddleCenter";
            this.daMultifunction1.Textalign_1 = "MiddleCenter";
            this.daMultifunction1.TextColor_0 = System.Drawing.Color.White;
            this.daMultifunction1.TextColor_1 = System.Drawing.Color.White;
            this.daMultifunction1.TextContent_0 = "OFF";
            this.daMultifunction1.TextContent_1 = "ON";
            this.daMultifunction1.Textflicker_0 = 0;
            this.daMultifunction1.Textflicker_1 = 0;
            this.daMultifunction1.TextFont_0 = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daMultifunction1.TextFont_1 = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daMultifunction1.TextItalic_0 = false;
            this.daMultifunction1.TextItalic_1 = false;
            this.daMultifunction1.TextUnderline_0 = false;
            this.daMultifunction1.TextUnderline_1 = false;
            this.daMultifunction1.WrSafetyAddress = "0";
            // 
            // daPlcGraph1
            // 
            this.daPlcGraph1.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.daPlcGraph1.APLCGraph = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.daPlcGraph1.BackColor = System.Drawing.Color.Transparent;
            this.daPlcGraph1.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daPlcGraph1.ForeColor = System.Drawing.Color.Black;
            r1.Content = "77";
            r1.ID = 0;
            r1.Step = 0;
            r2.Content = "99";
            r2.ID = 1;
            r2.Step = 1;
            r3.Content = "888";
            r3.ID = 2;
            r3.Step = 2;
            r4.Content = "222啊";
            r4.ID = 3;
            r4.Step = 3;
            r5.Content = "666";
            r5.ID = 4;
            r5.Step = 4;
            r6.Content = "8888";
            r6.ID = 5;
            r6.Step = 5;
            this.daPlcGraph1.GraphList = new PLC通讯基础控件项目.基础控件.R[] {
        r1,
        r2,
        r3,
        r4,
        r5,
        r6};
            this.daPlcGraph1.Location = new System.Drawing.Point(473, 18);
            this.daPlcGraph1.Name = "daPlcGraph1";
            this.daPlcGraph1.PLC_Enable = true;
            this.daPlcGraph1.pLCDselectRealize.AwaitTime = 0;
            this.daPlcGraph1.pLCDselectRealize.Dataentryfunction = false;
            this.daPlcGraph1.pLCDselectRealize.description = "";
            this.daPlcGraph1.pLCDselectRealize.Inform = false;
            this.daPlcGraph1.pLCDselectRealize.InformAddress = "0";
            this.daPlcGraph1.pLCDselectRealize.InformFunction = "M";
            this.daPlcGraph1.pLCDselectRealize.Informpattern = 0;
            this.daPlcGraph1.pLCDselectRealize.InformPLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daPlcGraph1.pLCDselectRealize.Keyboard = true;
            this.daPlcGraph1.pLCDselectRealize.KeyboardStyle = "keyboard";
            this.daPlcGraph1.pLCDselectRealize.keyMinTime = 0;
            this.daPlcGraph1.pLCDselectRealize.NoAccessConceal = false;
            this.daPlcGraph1.pLCDselectRealize.NoAccessForm = false;
            this.daPlcGraph1.pLCDselectRealize.NumericaldigitMax = 7;
            this.daPlcGraph1.pLCDselectRealize.NumericaldigitMin = 0;
            this.daPlcGraph1.pLCDselectRealize.NumericalFormat = 0;
            this.daPlcGraph1.pLCDselectRealize.NumericalMax = 9999999;
            this.daPlcGraph1.pLCDselectRealize.NumericalMin = -999999;
            this.daPlcGraph1.pLCDselectRealize.OperationAffirm = false;
            this.daPlcGraph1.pLCDselectRealize.PLCTimer = null;
            this.daPlcGraph1.pLCDselectRealize.ReadWrite = false;
            this.daPlcGraph1.pLCDselectRealize.ReadWriteAddress = "3";
            this.daPlcGraph1.pLCDselectRealize.ReadWriteFunction = "D";
            this.daPlcGraph1.pLCDselectRealize.ReadWritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Modbus_TCP;
            this.daPlcGraph1.pLCDselectRealize.SafetyBehaviorPattern = 1;
            this.daPlcGraph1.pLCDselectRealize.SafetyCategory = 0;
            this.daPlcGraph1.pLCDselectRealize.SafetyFunction = "M";
            this.daPlcGraph1.pLCDselectRealize.SafetyPattern = 1;
            this.daPlcGraph1.pLCDselectRealize.SafetyPLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daPlcGraph1.pLCDselectRealize.ShowFormat = PLC通讯库.通讯枚举.numerical_format.Signed_16_Bit;
            this.daPlcGraph1.pLCDselectRealize.Speech = false;
            this.daPlcGraph1.pLCDselectRealize.Textalign_0 = "BottomCenter";
            this.daPlcGraph1.pLCDselectRealize.Textalign_1 = "BottomCenter";
            this.daPlcGraph1.pLCDselectRealize.TextColor_0 = System.Drawing.Color.Black;
            this.daPlcGraph1.pLCDselectRealize.TextColor_1 = System.Drawing.Color.Black;
            this.daPlcGraph1.pLCDselectRealize.TextContent_0 = "PLCpropertyText";
            this.daPlcGraph1.pLCDselectRealize.TextContent_1 = null;
            this.daPlcGraph1.pLCDselectRealize.Textflicker_0 = 0;
            this.daPlcGraph1.pLCDselectRealize.Textflicker_1 = 0;
            this.daPlcGraph1.pLCDselectRealize.TextFont_0 = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daPlcGraph1.pLCDselectRealize.TextFont_1 = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daPlcGraph1.pLCDselectRealize.TextItalic_0 = false;
            this.daPlcGraph1.pLCDselectRealize.TextItalic_1 = false;
            this.daPlcGraph1.pLCDselectRealize.TextUnderline_0 = false;
            this.daPlcGraph1.pLCDselectRealize.TextUnderline_1 = false;
            this.daPlcGraph1.pLCDselectRealize.WriteAddress = "0";
            this.daPlcGraph1.pLCDselectRealize.WriteFunction = "D";
            this.daPlcGraph1.pLCDselectRealize.WritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daPlcGraph1.pLCDselectRealize.WrSafetyAddress = "0";
            this.daPlcGraph1.PLCTimer = null;
            this.daPlcGraph1.Size = new System.Drawing.Size(449, 325);
            this.daPlcGraph1.TabIndex = 27;
            this.daPlcGraph1.Textalign_0 = null;
            this.daPlcGraph1.Textalign_1 = null;
            this.daPlcGraph1.TextColor_0 = System.Drawing.Color.Black;
            this.daPlcGraph1.TextColor_1 = System.Drawing.Color.Black;
            this.daPlcGraph1.TextContent_0 = "PLCpropertyText";
            this.daPlcGraph1.TextContent_1 = null;
            this.daPlcGraph1.TextFont_0 = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daPlcGraph1.TextFont_1 = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daPlcGraph1.Title = "PLC";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 703);
            this.Controls.Add(this.daPlcGraph1);
            this.Controls.Add(this.daMultifunction1);
            this.Controls.Add(this.daPlcFunction1);
            this.Controls.Add(this.uiListBox1);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.daIhatetheqrcode1);
            this.Controls.Add(this.uiLine5);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.plcStatusView3);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.plcStatusView2);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.uiLine4);
            this.Controls.Add(this.uiLine2);
            this.Controls.Add(this.uiLine1);
            this.Controls.Add(this.plcStatusView1);
            this.Controls.Add(this.daUiButton1);
            this.Controls.Add(this.uiLine3);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.Text = "011";
            ((System.ComponentModel.ISupportInitialize)(this.daIhatetheqrcode1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PLC通讯基础控件项目.PLCControlsPreferences plcControlsPreferences1;
        private PLC通讯基础控件项目.基础控件.DAuiBarChart dAuiBarChart1;
        private PLC通讯基础控件项目.PLC参数设置控件.PLCPreferences plcPreferences2;
        private PLC通讯基础控件项目.PLC参数设置控件.PLCPreferences plcPreferences3;
        private PLC通讯基础控件项目.基础控件.DAUiButton daUiButton1;
        private PLC通讯基础控件项目.PLC参数设置控件.控件状态切换控件.PLCControlSwitch plcControlSwitch1;
        private PLC通讯基础控件项目.PLC参数设置控件.PLCPreferences plcPreferences1;
        private PLC通讯基础控件项目.基础控件.DAUiButton daUiButton2;
        private PLC通讯基础控件项目.基础控件.底层PLC状态监控控件.PLCStatusView plcStatusView1;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UILine uiLine2;
        private Sunny.UI.UILine uiLine3;
        private Sunny.UI.UILine uiLine4;
        private Sunny.UI.UILabel uiLabel1;
        private PLC通讯基础控件项目.基础控件.底层PLC状态监控控件.PLCStatusView plcStatusView2;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private PLC通讯基础控件项目.基础控件.底层PLC状态监控控件.PLCStatusView plcStatusView3;
        private Sunny.UI.UILine uiLine5;
        private PLC通讯基础控件项目.基础控件.DAIhatetheqrcode daIhatetheqrcode1;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIListBox uiListBox1;
        private PLC通讯基础控件项目.基础控件.底层PLC状态监控控件.DAPlcFunction daPlcFunction1;
        private PLC通讯基础控件项目.基础控件.DAMultifunction daMultifunction1;
        private PLC通讯基础控件项目.基础控件.DAPlcGraph daPlcGraph1;
    }
}

