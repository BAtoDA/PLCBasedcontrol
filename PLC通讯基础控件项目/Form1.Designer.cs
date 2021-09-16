
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
            this.plcPreferences1 = new PLC通讯基础控件项目.PLC参数设置控件.PLCPreferences();
            this.plcPreferences2 = new PLC通讯基础控件项目.PLC参数设置控件.PLCPreferences();
            this.plcPreferences3 = new PLC通讯基础控件项目.PLC参数设置控件.PLCPreferences();
            this.daButton1 = new PLC通讯基础控件项目.基础控件.DAButton();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.daTextBox1 = new PLC通讯基础控件项目.基础控件.DATextBox();
            this.daUiButton1 = new PLC通讯基础控件项目.基础控件.DAUiButton();
            this.uiImageButton1 = new Sunny.UI.UIImageButton();
            this.daUiLedBulb1 = new PLC通讯基础控件项目.基础控件.DAUiLedBulb();
            this.daUiTextBox1 = new PLC通讯基础控件项目.基础控件.DAUiTextBox();
            this.plcBasement1 = new PLC通讯基础控件项目.基础控件.底层PLC状态监控控件.PlcBasement();
            this.plcFunction2 = new PLC通讯基础控件项目.基础控件.底层PLC状态监控控件.PlcFunction();
            ((System.ComponentModel.ISupportInitialize)(this.uiImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // plcControlsPreferences1
            // 
            this.plcControlsPreferences1.Enabled = true;
            this.plcControlsPreferences1.Interval = 1000;
            this.plcControlsPreferences1.PLCPreferences.Add(this.plcPreferences1);
            this.plcControlsPreferences1.PLCPreferences.Add(this.plcPreferences2);
            this.plcControlsPreferences1.PLCPreferences.Add(this.plcPreferences3);
            // 
            // plcPreferences1
            // 
            this.plcPreferences1.IPEnd = "192.168.3.250";
            this.plcPreferences1.PLCDevice = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.plcPreferences1.Point = 5000;
            this.plcPreferences1.Receptionovertime = 1000;
            this.plcPreferences1.Retain = " ";
            this.plcPreferences1.Sendovertime = 1000;
            // 
            // plcPreferences2
            // 
            this.plcPreferences2.IPEnd = "127.0.0.0";
            this.plcPreferences2.PLCDevice = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Siemens;
            this.plcPreferences2.Point = 2000;
            this.plcPreferences2.Receptionovertime = 1000;
            this.plcPreferences2.Retain = " S1500";
            this.plcPreferences2.Sendovertime = 1000;
            // 
            // plcPreferences3
            // 
            this.plcPreferences3.IPEnd = "192.168.3.250";
            this.plcPreferences3.PLCDevice = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Modbus_TCP;
            this.plcPreferences3.Point = 8000;
            this.plcPreferences3.Receptionovertime = 1000;
            this.plcPreferences3.Retain = " ";
            this.plcPreferences3.Sendovertime = 1000;
            // 
            // daButton1
            // 
            this.daButton1.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.daButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.daButton1.backgroundColor_0 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.daButton1.backgroundColor_1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.daButton1.ForeColor = System.Drawing.Color.White;
            this.daButton1.Location = new System.Drawing.Point(119, 120);
            this.daButton1.Name = "daButton1";
            this.daButton1.PLC_Enable = true;
            this.daButton1.pLCBitselectRealize.AwaitTime = 0;
            this.daButton1.pLCBitselectRealize.backgroundColor_0 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.daButton1.pLCBitselectRealize.backgroundColor_1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.daButton1.pLCBitselectRealize.BitPattern = false;
            this.daButton1.pLCBitselectRealize.description = "PLCBitselectRealize";
            this.daButton1.pLCBitselectRealize.keyMinTime = 200;
            this.daButton1.pLCBitselectRealize.LoosenOut = false;
            this.daButton1.pLCBitselectRealize.NoAccessConceal = false;
            this.daButton1.pLCBitselectRealize.NoAccessForm = false;
            this.daButton1.pLCBitselectRealize.OperationAffirm = true;
            this.daButton1.pLCBitselectRealize.OutReverse = false;
            this.daButton1.pLCBitselectRealize.Pattern = PLC通讯基础控件项目.控件类基.控件数据结构.Button_pattern.selector_witch;
            this.daButton1.pLCBitselectRealize.PLCTimer = null;
            this.daButton1.pLCBitselectRealize.ReadWrite = false;
            this.daButton1.pLCBitselectRealize.ReadWriteAddress = "1";
            this.daButton1.pLCBitselectRealize.ReadWriteFunction = "Y";
            this.daButton1.pLCBitselectRealize.ReadWritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daButton1.pLCBitselectRealize.SafetyBehaviorPattern = 2;
            this.daButton1.pLCBitselectRealize.SafetyCategory = 0;
            this.daButton1.pLCBitselectRealize.SafetyFunction = "Y";
            this.daButton1.pLCBitselectRealize.SafetyPattern = 1;
            this.daButton1.pLCBitselectRealize.SafetyPLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daButton1.pLCBitselectRealize.Speech = true;
            this.daButton1.pLCBitselectRealize.Textalign_0 = "TopLeft";
            this.daButton1.pLCBitselectRealize.Textalign_1 = "TopLeft";
            this.daButton1.pLCBitselectRealize.TextColor_0 = System.Drawing.Color.White;
            this.daButton1.pLCBitselectRealize.TextColor_1 = System.Drawing.Color.White;
            this.daButton1.pLCBitselectRealize.TextContent_0 = "OFF-1";
            this.daButton1.pLCBitselectRealize.TextContent_1 = "ON-1";
            this.daButton1.pLCBitselectRealize.Textflicker_0 = 0;
            this.daButton1.pLCBitselectRealize.Textflicker_1 = 0;
            this.daButton1.pLCBitselectRealize.TextFont_0 = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.daButton1.pLCBitselectRealize.TextFont_1 = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.daButton1.pLCBitselectRealize.TextItalic_0 = false;
            this.daButton1.pLCBitselectRealize.TextItalic_1 = false;
            this.daButton1.pLCBitselectRealize.TextState = 0;
            this.daButton1.pLCBitselectRealize.TextUnderline_0 = false;
            this.daButton1.pLCBitselectRealize.TextUnderline_1 = false;
            this.daButton1.pLCBitselectRealize.WriteAddress = "0";
            this.daButton1.pLCBitselectRealize.WriteFunction = "M";
            this.daButton1.pLCBitselectRealize.WritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daButton1.pLCBitselectRealize.WrSafetyAddress = "2";
            this.daButton1.Size = new System.Drawing.Size(120, 48);
            this.daButton1.TabIndex = 0;
            this.daButton1.Text = "ON-1";
            this.daButton1.TextColor_0 = System.Drawing.Color.White;
            this.daButton1.TextColor_1 = System.Drawing.Color.White;
            this.daButton1.TextContent_0 = "OFF-1";
            this.daButton1.TextContent_1 = "ON-1";
            this.daButton1.UseVisualStyleBackColor = false;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel1.Location = new System.Drawing.Point(350, 174);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 23);
            this.uiLabel1.TabIndex = 1;
            this.uiLabel1.Text = "uiLabel1";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiButton1
            // 
            this.uiButton1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.FillColor = System.Drawing.Color.Black;
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiButton1.Location = new System.Drawing.Point(372, 72);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.RectColor = System.Drawing.Color.White;
            this.uiButton1.Size = new System.Drawing.Size(100, 35);
            this.uiButton1.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton1.TabIndex = 2;
            this.uiButton1.Text = "uiButton1";
            // 
            // daTextBox1
            // 
            this.daTextBox1.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.daTextBox1.ForeColor = System.Drawing.Color.Black;
            this.daTextBox1.Location = new System.Drawing.Point(579, 120);
            this.daTextBox1.Name = "daTextBox1";
            this.daTextBox1.PLC_Enable = true;
            this.daTextBox1.pLCDselectRealize.AwaitTime = 10;
            this.daTextBox1.pLCDselectRealize.Dataentryfunction = true;
            this.daTextBox1.pLCDselectRealize.description = "PLCDselectRealize";
            this.daTextBox1.pLCDselectRealize.Inform = true;
            this.daTextBox1.pLCDselectRealize.InformAddress = "2";
            this.daTextBox1.pLCDselectRealize.InformFunction = "Y";
            this.daTextBox1.pLCDselectRealize.Informpattern = 0;
            this.daTextBox1.pLCDselectRealize.InformPLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daTextBox1.pLCDselectRealize.Keyboard = true;
            this.daTextBox1.pLCDselectRealize.KeyboardStyle = "keyboard";
            this.daTextBox1.pLCDselectRealize.keyMinTime = 10;
            this.daTextBox1.pLCDselectRealize.NoAccessConceal = false;
            this.daTextBox1.pLCDselectRealize.NoAccessForm = false;
            this.daTextBox1.pLCDselectRealize.NumericaldigitMax = 7;
            this.daTextBox1.pLCDselectRealize.NumericaldigitMin = 2;
            this.daTextBox1.pLCDselectRealize.NumericalFormat = 0;
            this.daTextBox1.pLCDselectRealize.NumericalMax = 9999999;
            this.daTextBox1.pLCDselectRealize.NumericalMin = -999999;
            this.daTextBox1.pLCDselectRealize.OperationAffirm = false;
            this.daTextBox1.pLCDselectRealize.PLCTimer = null;
            this.daTextBox1.pLCDselectRealize.ReadWrite = false;
            this.daTextBox1.pLCDselectRealize.ReadWriteAddress = "1";
            this.daTextBox1.pLCDselectRealize.ReadWriteFunction = "D";
            this.daTextBox1.pLCDselectRealize.ReadWritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daTextBox1.pLCDselectRealize.SafetyBehaviorPattern = 1;
            this.daTextBox1.pLCDselectRealize.SafetyCategory = 0;
            this.daTextBox1.pLCDselectRealize.SafetyFunction = "M";
            this.daTextBox1.pLCDselectRealize.SafetyPattern = 1;
            this.daTextBox1.pLCDselectRealize.SafetyPLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daTextBox1.pLCDselectRealize.ShowFormat = PLC通讯库.通讯枚举.numerical_format.Signed_32_Bit;
            this.daTextBox1.pLCDselectRealize.Speech = false;
            this.daTextBox1.pLCDselectRealize.Textalign_0 = "对对对";
            this.daTextBox1.pLCDselectRealize.Textalign_1 = null;
            this.daTextBox1.pLCDselectRealize.TextColor_0 = System.Drawing.Color.Black;
            this.daTextBox1.pLCDselectRealize.TextColor_1 = System.Drawing.Color.Black;
            this.daTextBox1.pLCDselectRealize.TextContent_0 = "PLCpropertyText";
            this.daTextBox1.pLCDselectRealize.TextContent_1 = null;
            this.daTextBox1.pLCDselectRealize.Textflicker_0 = 0;
            this.daTextBox1.pLCDselectRealize.Textflicker_1 = 0;
            this.daTextBox1.pLCDselectRealize.TextFont_0 = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.daTextBox1.pLCDselectRealize.TextFont_1 = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daTextBox1.pLCDselectRealize.TextItalic_0 = false;
            this.daTextBox1.pLCDselectRealize.TextItalic_1 = false;
            this.daTextBox1.pLCDselectRealize.TextUnderline_0 = false;
            this.daTextBox1.pLCDselectRealize.TextUnderline_1 = false;
            this.daTextBox1.pLCDselectRealize.WriteAddress = "0";
            this.daTextBox1.pLCDselectRealize.WriteFunction = "D";
            this.daTextBox1.pLCDselectRealize.WritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daTextBox1.pLCDselectRealize.WrSafetyAddress = "0";
            this.daTextBox1.ReadOnly = true;
            this.daTextBox1.Size = new System.Drawing.Size(100, 23);
            this.daTextBox1.TabIndex = 5;
            this.daTextBox1.Text = "0";
            this.daTextBox1.TextColor_0 = System.Drawing.Color.Black;
            this.daTextBox1.TextColor_1 = System.Drawing.Color.Black;
            this.daTextBox1.TextContent_0 = "PLCpropertyText";
            this.daTextBox1.TextContent_1 = null;
            // 
            // daUiButton1
            // 
            this.daUiButton1.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.daUiButton1.BackColor = System.Drawing.Color.Black;
            this.daUiButton1.backgroundColor_0 = System.Drawing.Color.Black;
            this.daUiButton1.backgroundColor_1 = System.Drawing.Color.Black;
            this.daUiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.daUiButton1.FillColor = System.Drawing.Color.Black;
            this.daUiButton1.FillHoverColor = System.Drawing.Color.Black;
            this.daUiButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiButton1.Location = new System.Drawing.Point(197, 315);
            this.daUiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.daUiButton1.Name = "daUiButton1";
            this.daUiButton1.PLC_Enable = true;
            this.daUiButton1.pLCBitselectRealize.AwaitTime = 0;
            this.daUiButton1.pLCBitselectRealize.backgroundColor_0 = System.Drawing.Color.Black;
            this.daUiButton1.pLCBitselectRealize.backgroundColor_1 = System.Drawing.Color.Black;
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
            this.daUiButton1.pLCBitselectRealize.ReadWriteAddress = "3";
            this.daUiButton1.pLCBitselectRealize.ReadWriteFunction = "Y";
            this.daUiButton1.pLCBitselectRealize.ReadWritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daUiButton1.pLCBitselectRealize.SafetyBehaviorPattern = 0;
            this.daUiButton1.pLCBitselectRealize.SafetyCategory = 0;
            this.daUiButton1.pLCBitselectRealize.SafetyFunction = "M";
            this.daUiButton1.pLCBitselectRealize.SafetyPattern = 0;
            this.daUiButton1.pLCBitselectRealize.SafetyPLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daUiButton1.pLCBitselectRealize.Speech = false;
            this.daUiButton1.pLCBitselectRealize.Textalign_0 = "TopLeft";
            this.daUiButton1.pLCBitselectRealize.Textalign_1 = "TopLeft";
            this.daUiButton1.pLCBitselectRealize.TextColor_0 = System.Drawing.Color.White;
            this.daUiButton1.pLCBitselectRealize.TextColor_1 = System.Drawing.Color.White;
            this.daUiButton1.pLCBitselectRealize.TextContent_0 = "0";
            this.daUiButton1.pLCBitselectRealize.TextContent_1 = "0";
            this.daUiButton1.pLCBitselectRealize.Textflicker_0 = 0;
            this.daUiButton1.pLCBitselectRealize.Textflicker_1 = 0;
            this.daUiButton1.pLCBitselectRealize.TextFont_0 = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.daUiButton1.pLCBitselectRealize.TextFont_1 = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.daUiButton1.pLCBitselectRealize.TextItalic_0 = false;
            this.daUiButton1.pLCBitselectRealize.TextItalic_1 = false;
            this.daUiButton1.pLCBitselectRealize.TextState = 0;
            this.daUiButton1.pLCBitselectRealize.TextUnderline_0 = false;
            this.daUiButton1.pLCBitselectRealize.TextUnderline_1 = false;
            this.daUiButton1.pLCBitselectRealize.WriteAddress = "0";
            this.daUiButton1.pLCBitselectRealize.WriteFunction = "M";
            this.daUiButton1.pLCBitselectRealize.WritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daUiButton1.pLCBitselectRealize.WrSafetyAddress = "0";
            this.daUiButton1.Size = new System.Drawing.Size(100, 35);
            this.daUiButton1.Style = Sunny.UI.UIStyle.Custom;
            this.daUiButton1.TabIndex = 6;
            this.daUiButton1.Text = "0";
            this.daUiButton1.TextColor_0 = System.Drawing.Color.White;
            this.daUiButton1.TextColor_1 = System.Drawing.Color.White;
            this.daUiButton1.TextContent_0 = "0";
            this.daUiButton1.TextContent_1 = "0";
            // 
            // uiImageButton1
            // 
            this.uiImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiImageButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiImageButton1.Location = new System.Drawing.Point(500, 197);
            this.uiImageButton1.Name = "uiImageButton1";
            this.uiImageButton1.Size = new System.Drawing.Size(100, 35);
            this.uiImageButton1.TabIndex = 7;
            this.uiImageButton1.TabStop = false;
            this.uiImageButton1.Text = "uiImageButton1";
            // 
            // daUiLedBulb1
            // 
            this.daUiLedBulb1.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.daUiLedBulb1.backgroundColor_0 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.daUiLedBulb1.backgroundColor_1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.daUiLedBulb1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.daUiLedBulb1.ForeColor = System.Drawing.Color.White;
            this.daUiLedBulb1.Location = new System.Drawing.Point(233, 199);
            this.daUiLedBulb1.Name = "daUiLedBulb1";
            this.daUiLedBulb1.PLC_Enable = true;
            this.daUiLedBulb1.pLCBitselectRealize.AwaitTime = 0;
            this.daUiLedBulb1.pLCBitselectRealize.backgroundColor_0 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.daUiLedBulb1.pLCBitselectRealize.backgroundColor_1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.daUiLedBulb1.pLCBitselectRealize.BitPattern = true;
            this.daUiLedBulb1.pLCBitselectRealize.description = "PLCBitselectRealize";
            this.daUiLedBulb1.pLCBitselectRealize.keyMinTime = 0;
            this.daUiLedBulb1.pLCBitselectRealize.LoosenOut = false;
            this.daUiLedBulb1.pLCBitselectRealize.NoAccessConceal = false;
            this.daUiLedBulb1.pLCBitselectRealize.NoAccessForm = false;
            this.daUiLedBulb1.pLCBitselectRealize.OperationAffirm = false;
            this.daUiLedBulb1.pLCBitselectRealize.OutReverse = false;
            this.daUiLedBulb1.pLCBitselectRealize.Pattern = PLC通讯基础控件项目.控件类基.控件数据结构.Button_pattern.selector_witch;
            this.daUiLedBulb1.pLCBitselectRealize.PLCTimer = null;
            this.daUiLedBulb1.pLCBitselectRealize.ReadWrite = false;
            this.daUiLedBulb1.pLCBitselectRealize.ReadWriteAddress = "1";
            this.daUiLedBulb1.pLCBitselectRealize.ReadWriteFunction = "Y";
            this.daUiLedBulb1.pLCBitselectRealize.ReadWritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daUiLedBulb1.pLCBitselectRealize.SafetyBehaviorPattern = 0;
            this.daUiLedBulb1.pLCBitselectRealize.SafetyCategory = 0;
            this.daUiLedBulb1.pLCBitselectRealize.SafetyFunction = "M";
            this.daUiLedBulb1.pLCBitselectRealize.SafetyPattern = 0;
            this.daUiLedBulb1.pLCBitselectRealize.SafetyPLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daUiLedBulb1.pLCBitselectRealize.Speech = false;
            this.daUiLedBulb1.pLCBitselectRealize.Textalign_0 = "TopLeft";
            this.daUiLedBulb1.pLCBitselectRealize.Textalign_1 = "TopLeft";
            this.daUiLedBulb1.pLCBitselectRealize.TextColor_0 = System.Drawing.Color.White;
            this.daUiLedBulb1.pLCBitselectRealize.TextColor_1 = System.Drawing.Color.White;
            this.daUiLedBulb1.pLCBitselectRealize.TextContent_0 = "0";
            this.daUiLedBulb1.pLCBitselectRealize.TextContent_1 = "0";
            this.daUiLedBulb1.pLCBitselectRealize.Textflicker_0 = 0;
            this.daUiLedBulb1.pLCBitselectRealize.Textflicker_1 = 0;
            this.daUiLedBulb1.pLCBitselectRealize.TextFont_0 = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.daUiLedBulb1.pLCBitselectRealize.TextFont_1 = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.daUiLedBulb1.pLCBitselectRealize.TextItalic_0 = false;
            this.daUiLedBulb1.pLCBitselectRealize.TextItalic_1 = false;
            this.daUiLedBulb1.pLCBitselectRealize.TextState = 0;
            this.daUiLedBulb1.pLCBitselectRealize.TextUnderline_0 = false;
            this.daUiLedBulb1.pLCBitselectRealize.TextUnderline_1 = false;
            this.daUiLedBulb1.pLCBitselectRealize.WriteAddress = "0";
            this.daUiLedBulb1.pLCBitselectRealize.WriteFunction = "M";
            this.daUiLedBulb1.pLCBitselectRealize.WritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daUiLedBulb1.pLCBitselectRealize.WrSafetyAddress = "0";
            this.daUiLedBulb1.Size = new System.Drawing.Size(32, 32);
            this.daUiLedBulb1.TabIndex = 8;
            this.daUiLedBulb1.Text = "0";
            this.daUiLedBulb1.TextColor_0 = System.Drawing.Color.White;
            this.daUiLedBulb1.TextColor_1 = System.Drawing.Color.White;
            this.daUiLedBulb1.TextContent_0 = "0";
            this.daUiLedBulb1.TextContent_1 = "0";
            // 
            // daUiTextBox1
            // 
            this.daUiTextBox1.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.daUiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.daUiTextBox1.FillColor = System.Drawing.Color.White;
            this.daUiTextBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiTextBox1.ForeColor = System.Drawing.Color.Black;
            this.daUiTextBox1.Location = new System.Drawing.Point(442, 389);
            this.daUiTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.daUiTextBox1.Maximum = 2147483647D;
            this.daUiTextBox1.Minimum = -2147483648D;
            this.daUiTextBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.daUiTextBox1.Name = "daUiTextBox1";
            this.daUiTextBox1.PLC_Enable = true;
            this.daUiTextBox1.pLCDselectRealize.AwaitTime = 0;
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
            this.daUiTextBox1.pLCDselectRealize.ReadWriteFunction = "D";
            this.daUiTextBox1.pLCDselectRealize.ReadWritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daUiTextBox1.pLCDselectRealize.SafetyBehaviorPattern = 1;
            this.daUiTextBox1.pLCDselectRealize.SafetyCategory = 0;
            this.daUiTextBox1.pLCDselectRealize.SafetyFunction = "M";
            this.daUiTextBox1.pLCDselectRealize.SafetyPattern = 1;
            this.daUiTextBox1.pLCDselectRealize.SafetyPLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daUiTextBox1.pLCDselectRealize.ShowFormat = PLC通讯库.通讯枚举.numerical_format.Signed_32_Bit;
            this.daUiTextBox1.pLCDselectRealize.Speech = false;
            this.daUiTextBox1.pLCDselectRealize.Textalign_0 = "对对对";
            this.daUiTextBox1.pLCDselectRealize.Textalign_1 = null;
            this.daUiTextBox1.pLCDselectRealize.TextColor_0 = System.Drawing.Color.Black;
            this.daUiTextBox1.pLCDselectRealize.TextColor_1 = System.Drawing.Color.Black;
            this.daUiTextBox1.pLCDselectRealize.TextContent_0 = "PLCpropertyText";
            this.daUiTextBox1.pLCDselectRealize.TextContent_1 = null;
            this.daUiTextBox1.pLCDselectRealize.Textflicker_0 = 0;
            this.daUiTextBox1.pLCDselectRealize.Textflicker_1 = 0;
            this.daUiTextBox1.pLCDselectRealize.TextFont_0 = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.daUiTextBox1.pLCDselectRealize.TextFont_1 = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiTextBox1.pLCDselectRealize.TextItalic_0 = false;
            this.daUiTextBox1.pLCDselectRealize.TextItalic_1 = false;
            this.daUiTextBox1.pLCDselectRealize.TextUnderline_0 = false;
            this.daUiTextBox1.pLCDselectRealize.TextUnderline_1 = false;
            this.daUiTextBox1.pLCDselectRealize.WriteAddress = "0";
            this.daUiTextBox1.pLCDselectRealize.WriteFunction = "D";
            this.daUiTextBox1.pLCDselectRealize.WritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daUiTextBox1.pLCDselectRealize.WrSafetyAddress = "0";
            this.daUiTextBox1.ReadOnly = true;
            this.daUiTextBox1.Size = new System.Drawing.Size(150, 29);
            this.daUiTextBox1.Style = Sunny.UI.UIStyle.Custom;
            this.daUiTextBox1.TabIndex = 9;
            this.daUiTextBox1.Text = "0";
            this.daUiTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.daUiTextBox1.TextColor_0 = System.Drawing.Color.Black;
            this.daUiTextBox1.TextColor_1 = System.Drawing.Color.Black;
            this.daUiTextBox1.TextContent_0 = "PLCpropertyText";
            this.daUiTextBox1.TextContent_1 = null;
            // 
            // plcBasement1
            // 
            this.plcBasement1.BackColor = System.Drawing.Color.DarkGray;
            this.plcBasement1.Location = new System.Drawing.Point(324, 120);
            this.plcBasement1.Name = "plcBasement1";
            this.plcBasement1.Size = new System.Drawing.Size(496, 280);
            this.plcBasement1.TabIndex = 10;
            // 
            // plcFunction2
            // 
            this.plcFunction2.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.plcFunction2.FormName = "Form1";
            this.plcFunction2.FormPath = "PLC通讯基础控件项目.模板与控制界面";
            this.plcFunction2.Location = new System.Drawing.Point(161, 43);
            this.plcFunction2.Name = "plcFunction2";
            this.plcFunction2.PLC_Enable = true;
            this.plcFunction2.Size = new System.Drawing.Size(75, 23);
            this.plcFunction2.TabIndex = 12;
            this.plcFunction2.Text = "plcFunction2";
            this.plcFunction2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 450);
            this.Controls.Add(this.plcFunction2);
            this.Controls.Add(this.plcBasement1);
            this.Controls.Add(this.daUiTextBox1);
            this.Controls.Add(this.daUiLedBulb1);
            this.Controls.Add(this.uiImageButton1);
            this.Controls.Add(this.daUiButton1);
            this.Controls.Add(this.daTextBox1);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.daButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PLCControlsPreferences plcControlsPreferences1;
        private PLC参数设置控件.PLCPreferences plcPreferences1;
        private PLC参数设置控件.PLCPreferences plcPreferences2;
        private PLC参数设置控件.PLCPreferences plcPreferences3;
        private 基础控件.DAButton daButton1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIButton uiButton1;
        private 基础控件.DATextBox daTextBox1;
        private 基础控件.DAUiButton daUiButton1;
        private Sunny.UI.UIImageButton uiImageButton1;
        private 基础控件.DAUiLedBulb daUiLedBulb1;
        private 基础控件.DAUiTextBox daUiTextBox1;
        private 基础控件.底层PLC状态监控控件.PlcBasement plcBasement1;
        private 基础控件.底层PLC状态监控控件.PlcFunction plcFunction2;
    }
}