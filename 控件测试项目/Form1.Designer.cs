
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.plcControlsPreferences1 = new PLC通讯基础控件项目.PLCControlsPreferences(this.components);
            this.plcPreferences2 = new PLC通讯基础控件项目.PLC参数设置控件.PLCPreferences();
            this.plcPreferences3 = new PLC通讯基础控件项目.PLC参数设置控件.PLCPreferences();
            this.plcPreferences1 = new PLC通讯基础控件项目.PLC参数设置控件.PLCPreferences();
            this.dAuiBarChart2 = new PLC通讯基础控件项目.基础控件.DAuiBarChart();
            this.daUiButton1 = new PLC通讯基础控件项目.基础控件.DAUiButton();
            this.daTextBox1 = new PLC通讯基础控件项目.基础控件.DATextBox();
            this.plcControlSwitch1 = new PLC通讯基础控件项目.PLC参数设置控件.控件状态切换控件.PLCControlSwitch(this.components);
            this.daUiButton2 = new PLC通讯基础控件项目.基础控件.DAUiButton();
            this.daDataViewToPlcErr1 = new PLC通讯基础控件项目.基础控件.DADataViewToPlcErr(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.daDataViewToPlcErr1)).BeginInit();
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
            this.plcPreferences3.IPEnd = "192.168.3.115";
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
            // dAuiBarChart2
            // 
            this.dAuiBarChart2.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.dAuiBarChart2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dAuiBarChart2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dAuiBarChart2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.dAuiBarChart2.Location = new System.Drawing.Point(26, 30);
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
        "10"};
            this.dAuiBarChart2.pLCDataViewselectRealize.ReadCommand = false;
            this.dAuiBarChart2.pLCDataViewselectRealize.ReadWriteFunction = new string[] {
        "D"};
            this.dAuiBarChart2.pLCDataViewselectRealize.ReadWritePLC = new PLC通讯基础控件项目.控件类基.控件数据结构.PLC[] {
        PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi};
            this.dAuiBarChart2.pLCDataViewselectRealize.SQLCharacter = "uiTextBox2";
            this.dAuiBarChart2.pLCDataViewselectRealize.SQLOpen = false;
            this.dAuiBarChart2.pLCDataViewselectRealize.SQLServer_SQLinte = false;
            this.dAuiBarChart2.pLCDataViewselectRealize.SQLsurface = "";
            this.dAuiBarChart2.pLCDataViewselectRealize.SQLsurfaceType = new string[] {
        "varchar"};
            this.dAuiBarChart2.ReadCommand = false;
            this.dAuiBarChart2.Size = new System.Drawing.Size(201, 300);
            this.dAuiBarChart2.TabIndex = 5;
            this.dAuiBarChart2.Text = "dAuiBarChart2";
            this.dAuiBarChart2.XAxisName = "PLC";
            this.dAuiBarChart2.YAxisName = "标题";
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
            this.daUiButton1.Location = new System.Drawing.Point(381, 372);
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
            this.daUiButton1.pLCBitselectRealize.ReadWriteAddress = "10";
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
            this.daTextBox1.PLCTimer = null;
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
            // daDataViewToPlcErr1
            // 
            this.daDataViewToPlcErr1.AaveAddressz = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.daDataViewToPlcErr1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.daDataViewToPlcErr1.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.daDataViewToPlcErr1.BackgroundColor = System.Drawing.Color.White;
            this.daDataViewToPlcErr1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.daDataViewToPlcErr1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.daDataViewToPlcErr1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.daDataViewToPlcErr1.EnableHeadersVisualStyles = false;
            this.daDataViewToPlcErr1.EventAddress = "C:\\WINDOWS\\System32";
            this.daDataViewToPlcErr1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daDataViewToPlcErr1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.daDataViewToPlcErr1.Location = new System.Drawing.Point(316, 30);
            this.daDataViewToPlcErr1.Name = "daDataViewToPlcErr1";
            this.daDataViewToPlcErr1.PLC_Enable = true;
            this.daDataViewToPlcErr1.ReadCommand = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.daDataViewToPlcErr1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.daDataViewToPlcErr1.RowHeight = 25;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.daDataViewToPlcErr1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.daDataViewToPlcErr1.RowTemplate.Height = 25;
            this.daDataViewToPlcErr1.Save = true;
            this.daDataViewToPlcErr1.SaveAddress = "C:\\Users\\Administrator\\Desktop\\自动报警记录测试";
            this.daDataViewToPlcErr1.SelectedIndex = -1;
            this.daDataViewToPlcErr1.ShowGridLine = true;
            this.daDataViewToPlcErr1.Size = new System.Drawing.Size(643, 300);
            this.daDataViewToPlcErr1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 592);
            this.Controls.Add(this.daDataViewToPlcErr1);
            this.Controls.Add(this.daTextBox1);
            this.Controls.Add(this.daUiButton1);
            this.Controls.Add(this.dAuiBarChart2);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.Text = "011";
            ((System.ComponentModel.ISupportInitialize)(this.daDataViewToPlcErr1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PLC通讯基础控件项目.PLCControlsPreferences plcControlsPreferences1;
        private PLC通讯基础控件项目.基础控件.DAuiBarChart dAuiBarChart1;
        private PLC通讯基础控件项目.PLC参数设置控件.PLCPreferences plcPreferences2;
        private PLC通讯基础控件项目.PLC参数设置控件.PLCPreferences plcPreferences3;
        private PLC通讯基础控件项目.基础控件.DAuiBarChart dAuiBarChart2;
        private PLC通讯基础控件项目.基础控件.DAUiButton daUiButton1;
        private PLC通讯基础控件项目.基础控件.DATextBox daTextBox1;
        private PLC通讯基础控件项目.PLC参数设置控件.控件状态切换控件.PLCControlSwitch plcControlSwitch1;
        private PLC通讯基础控件项目.PLC参数设置控件.PLCPreferences plcPreferences1;
        private PLC通讯基础控件项目.基础控件.DAUiButton daUiButton2;
        private PLC通讯基础控件项目.基础控件.DADataViewToPlcErr daDataViewToPlcErr1;
    }
}

