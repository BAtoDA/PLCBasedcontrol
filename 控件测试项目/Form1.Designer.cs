
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
            this.plcControlsPreferences1 = new PLC通讯基础控件项目.PLCControlsPreferences(this.components);
            this.plcPreferences2 = new PLC通讯基础控件项目.PLC参数设置控件.PLCPreferences();
            this.plcPreferences3 = new PLC通讯基础控件项目.PLC参数设置控件.PLCPreferences();
            this.dAuiBarChart2 = new PLC通讯基础控件项目.基础控件.DAuiBarChart();
            this.uiDoughnutChart1 = new Sunny.UI.UIDoughnutChart();
            this.daUiButton1 = new PLC通讯基础控件项目.基础控件.DAUiButton();
            this.daTextBox1 = new PLC通讯基础控件项目.基础控件.DATextBox();
            this.daButton1 = new PLC通讯基础控件项目.基础控件.DAButton();
            this.SuspendLayout();
            // 
            // plcControlsPreferences1
            // 
            this.plcControlsPreferences1.Enabled = true;
            this.plcControlsPreferences1.Interval = 1000;
            this.plcControlsPreferences1.PLCPreferences.Add(this.plcPreferences2);
            this.plcControlsPreferences1.PLCPreferences.Add(this.plcPreferences3);
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
            this.plcPreferences3.IPEnd = "192.168.11.154";
            this.plcPreferences3.PLCDevice = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Modbus_TCP;
            this.plcPreferences3.Point = 8000;
            this.plcPreferences3.Receptionovertime = 1000;
            this.plcPreferences3.Retain = "S1500";
            this.plcPreferences3.Sendovertime = 1000;
            // 
            // dAuiBarChart2
            // 
            this.dAuiBarChart2.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.dAuiBarChart2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dAuiBarChart2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dAuiBarChart2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.dAuiBarChart2.Location = new System.Drawing.Point(106, 51);
            this.dAuiBarChart2.MinimumSize = new System.Drawing.Size(1, 1);
            this.dAuiBarChart2.Name = "dAuiBarChart2";
            this.dAuiBarChart2.PLC_Enable = true;
            this.dAuiBarChart2.pLCDataViewselectRealize.BindingName = "daUiButton1";
            this.dAuiBarChart2.pLCDataViewselectRealize.BindingOpen = true;
            this.dAuiBarChart2.pLCDataViewselectRealize.DataGridView_Name = new string[] {
        "Name"};
            this.dAuiBarChart2.pLCDataViewselectRealize.DataGridView_numerical = new PLC通讯库.通讯枚举.numerical_format[] {
        PLC通讯库.通讯枚举.numerical_format.Signed_16_Bit};
            this.dAuiBarChart2.pLCDataViewselectRealize.DataGridViewPLC_Time = false;
            this.dAuiBarChart2.pLCDataViewselectRealize.PLC_address = new string[] {
        "0"};
            this.dAuiBarChart2.pLCDataViewselectRealize.ReadCommand = false;
            this.dAuiBarChart2.pLCDataViewselectRealize.ReadWriteFunction = new string[] {
        "D"};
            this.dAuiBarChart2.pLCDataViewselectRealize.ReadWritePLC = new PLC通讯基础控件项目.控件类基.控件数据结构.PLC[] {
        PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Modbus_TCP};
            this.dAuiBarChart2.pLCDataViewselectRealize.SQLCharacter = "uiTextBox2";
            this.dAuiBarChart2.pLCDataViewselectRealize.SQLOpen = false;
            this.dAuiBarChart2.pLCDataViewselectRealize.SQLServer_SQLinte = false;
            this.dAuiBarChart2.pLCDataViewselectRealize.SQLsurface = "";
            this.dAuiBarChart2.pLCDataViewselectRealize.SQLsurfaceType = new string[] {
        "varchar"};
            this.dAuiBarChart2.ReadCommand = false;
            this.dAuiBarChart2.Size = new System.Drawing.Size(400, 300);
            this.dAuiBarChart2.TabIndex = 5;
            this.dAuiBarChart2.Text = "dAuiBarChart2";
            this.dAuiBarChart2.XAxisName = "PLC";
            this.dAuiBarChart2.YAxisName = "标题";
            // 
            // uiDoughnutChart1
            // 
            this.uiDoughnutChart1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.uiDoughnutChart1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiDoughnutChart1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.uiDoughnutChart1.Location = new System.Drawing.Point(600, 51);
            this.uiDoughnutChart1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiDoughnutChart1.Name = "uiDoughnutChart1";
            this.uiDoughnutChart1.Size = new System.Drawing.Size(400, 300);
            this.uiDoughnutChart1.TabIndex = 6;
            this.uiDoughnutChart1.Text = "uiDoughnutChart1";
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
            this.daUiButton1.Location = new System.Drawing.Point(504, 418);
            this.daUiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.daUiButton1.Name = "daUiButton1";
            this.daUiButton1.PLC_Enable = true;
            this.daUiButton1.pLCBitselectRealize.AwaitTime = 0;
            this.daUiButton1.pLCBitselectRealize.backgroundColor_0 = System.Drawing.Color.Silver;
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
            this.daUiButton1.pLCBitselectRealize.ReadWriteAddress = "1";
            this.daUiButton1.pLCBitselectRealize.ReadWriteFunction = "Y";
            this.daUiButton1.pLCBitselectRealize.ReadWritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Modbus_TCP;
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
            this.daUiButton1.Size = new System.Drawing.Size(100, 35);
            this.daUiButton1.Style = Sunny.UI.UIStyle.Custom;
            this.daUiButton1.TabIndex = 7;
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
            // daTextBox1
            // 
            this.daTextBox1.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.daTextBox1.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daTextBox1.ForeColor = System.Drawing.Color.Black;
            this.daTextBox1.Location = new System.Drawing.Point(240, 432);
            this.daTextBox1.Name = "daTextBox1";
            this.daTextBox1.PLC_Enable = true;
            this.daTextBox1.pLCDselectRealize.AwaitTime = 0;
            this.daTextBox1.pLCDselectRealize.Dataentryfunction = true;
            this.daTextBox1.pLCDselectRealize.description = "PLCDselectRealize";
            this.daTextBox1.pLCDselectRealize.Inform = false;
            this.daTextBox1.pLCDselectRealize.InformAddress = "0";
            this.daTextBox1.pLCDselectRealize.InformFunction = "M";
            this.daTextBox1.pLCDselectRealize.Informpattern = 0;
            this.daTextBox1.pLCDselectRealize.InformPLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daTextBox1.pLCDselectRealize.Keyboard = true;
            this.daTextBox1.pLCDselectRealize.KeyboardStyle = "keyboard";
            this.daTextBox1.pLCDselectRealize.keyMinTime = 0;
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
            this.daTextBox1.pLCDselectRealize.ReadWriteAddress = "0";
            this.daTextBox1.pLCDselectRealize.ReadWriteFunction = "D";
            this.daTextBox1.pLCDselectRealize.ReadWritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Modbus_TCP;
            this.daTextBox1.pLCDselectRealize.SafetyBehaviorPattern = 1;
            this.daTextBox1.pLCDselectRealize.SafetyCategory = 0;
            this.daTextBox1.pLCDselectRealize.SafetyFunction = "M";
            this.daTextBox1.pLCDselectRealize.SafetyPattern = 1;
            this.daTextBox1.pLCDselectRealize.SafetyPLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daTextBox1.pLCDselectRealize.ShowFormat = PLC通讯库.通讯枚举.numerical_format.Float_32_Bit;
            this.daTextBox1.pLCDselectRealize.Speech = false;
            this.daTextBox1.pLCDselectRealize.Textalign_0 = "BottomCenter";
            this.daTextBox1.pLCDselectRealize.Textalign_1 = "BottomCenter";
            this.daTextBox1.pLCDselectRealize.TextColor_0 = System.Drawing.Color.Black;
            this.daTextBox1.pLCDselectRealize.TextColor_1 = System.Drawing.Color.Black;
            this.daTextBox1.pLCDselectRealize.TextContent_0 = "0";
            this.daTextBox1.pLCDselectRealize.TextContent_1 = "0";
            this.daTextBox1.pLCDselectRealize.Textflicker_0 = 0;
            this.daTextBox1.pLCDselectRealize.Textflicker_1 = 0;
            this.daTextBox1.pLCDselectRealize.TextFont_0 = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.daTextBox1.Size = new System.Drawing.Size(100, 21);
            this.daTextBox1.TabIndex = 8;
            this.daTextBox1.Text = "0";
            this.daTextBox1.Textalign_0 = null;
            this.daTextBox1.Textalign_1 = null;
            this.daTextBox1.TextColor_0 = System.Drawing.Color.Black;
            this.daTextBox1.TextColor_1 = System.Drawing.Color.Black;
            this.daTextBox1.TextContent_0 = "0";
            this.daTextBox1.TextContent_1 = "0";
            this.daTextBox1.TextFont_0 = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daTextBox1.TextFont_1 = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // daButton1
            // 
            this.daButton1.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.daButton1.backgroundColor_0 = System.Drawing.Color.Silver;
            this.daButton1.backgroundColor_1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.daButton1.Location = new System.Drawing.Point(720, 418);
            this.daButton1.Name = "daButton1";
            this.daButton1.PLC_Enable = false;
            this.daButton1.pLCBitselectRealize.AwaitTime = 0;
            this.daButton1.pLCBitselectRealize.backgroundColor_0 = System.Drawing.Color.Silver;
            this.daButton1.pLCBitselectRealize.backgroundColor_1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.daButton1.pLCBitselectRealize.BitPattern = false;
            this.daButton1.pLCBitselectRealize.description = "PLCBitselectRealize";
            this.daButton1.pLCBitselectRealize.keyMinTime = 0;
            this.daButton1.pLCBitselectRealize.LoosenOut = false;
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
            this.daButton1.Size = new System.Drawing.Size(206, 75);
            this.daButton1.TabIndex = 9;
            this.daButton1.Text = "daButton1";
            this.daButton1.Textalign_0 = "MiddleCenter";
            this.daButton1.Textalign_1 = "MiddleCenter";
            this.daButton1.TextColor_0 = System.Drawing.Color.White;
            this.daButton1.TextColor_1 = System.Drawing.Color.White;
            this.daButton1.TextContent_0 = "OFF";
            this.daButton1.TextContent_1 = "ON";
            this.daButton1.TextFont_0 = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daButton1.TextFont_1 = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 592);
            this.Controls.Add(this.daButton1);
            this.Controls.Add(this.daTextBox1);
            this.Controls.Add(this.daUiButton1);
            this.Controls.Add(this.uiDoughnutChart1);
            this.Controls.Add(this.dAuiBarChart2);
            this.Name = "Form1";
            this.Text = "011";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PLC通讯基础控件项目.PLCControlsPreferences plcControlsPreferences1;
        private PLC通讯基础控件项目.基础控件.DAuiBarChart dAuiBarChart1;
        private PLC通讯基础控件项目.PLC参数设置控件.PLCPreferences plcPreferences2;
        private PLC通讯基础控件项目.PLC参数设置控件.PLCPreferences plcPreferences3;
        private PLC通讯基础控件项目.基础控件.DAuiBarChart dAuiBarChart2;
        private Sunny.UI.UIDoughnutChart uiDoughnutChart1;
        private PLC通讯基础控件项目.基础控件.DAUiButton daUiButton1;
        private PLC通讯基础控件项目.基础控件.DATextBox daTextBox1;
        private PLC通讯基础控件项目.基础控件.DAButton daButton1;
    }
}

