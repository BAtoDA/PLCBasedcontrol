namespace 控件测试项目
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
            this.daButton1 = new PLC通讯基础控件项目.基础控件.DAButton();
            this.daMacroControl1 = new PLC通讯基础控件项目.基础控件.宏指令控件.DAMacroControl(this.components);
            this.daUiTextBox1 = new PLC通讯基础控件项目.基础控件.DAUiTextBox();
            this.daPlcFunction1 = new PLC通讯基础控件项目.基础控件.底层PLC状态监控控件.DAPlcFunction();
            this.plcBasement1 = new PLC通讯基础控件项目.基础控件.底层PLC状态监控控件.PlcBasement();
            this.uiTextBox1 = new Sunny.UI.UITextBox();
            this.dAuiBarChart1 = new PLC通讯基础控件项目.基础控件.DAuiBarChart();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // plcControlsPreferences1
            // 
            this.plcControlsPreferences1.Enabled = true;
            this.plcControlsPreferences1.Interval = 2000;
            this.plcControlsPreferences1.PLCPreferences.Add(this.plcPreferences1);
            this.plcControlsPreferences1.PLCPreferences.Add(this.plcPreferences2);
            // 
            // plcPreferences1
            // 
            this.plcPreferences1.IPEnd = "10.50.65.138";
            this.plcPreferences1.PLCDevice = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.plcPreferences1.Point = 5016;
            this.plcPreferences1.Receptionovertime = 1000;
            this.plcPreferences1.Retain = "Q";
            this.plcPreferences1.Sendovertime = 1000;
            // 
            // plcPreferences2
            // 
            this.plcPreferences2.IPEnd = "127.0.0.1";
            this.plcPreferences2.PLCDevice = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.HMI;
            this.plcPreferences2.Point = 2000;
            this.plcPreferences2.Receptionovertime = 1000;
            this.plcPreferences2.Retain = "S1500";
            this.plcPreferences2.Sendovertime = 1000;
            // 
            // daButton1
            // 
            this.daButton1.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.daButton1.BackColor = System.Drawing.Color.Silver;
            this.daButton1.backgroundColor_0 = System.Drawing.Color.Silver;
            this.daButton1.backgroundColor_1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.daButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daButton1.ForeColor = System.Drawing.Color.White;
            this.daButton1.Location = new System.Drawing.Point(34, 109);
            this.daButton1.Name = "daButton1";
            this.daButton1.PLC_Enable = true;
            this.daButton1.pLCBitselectRealize.AwaitTime = 0;
            this.daButton1.pLCBitselectRealize.backgroundColor_0 = System.Drawing.Color.Silver;
            this.daButton1.pLCBitselectRealize.backgroundColor_1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.daButton1.pLCBitselectRealize.BitPattern = false;
            this.daButton1.pLCBitselectRealize.Compilestate = true;
            this.daButton1.pLCBitselectRealize.description = "PLCBitselectRealize";
            this.daButton1.pLCBitselectRealize.keyMinTime = 0;
            this.daButton1.pLCBitselectRealize.LoosenOut = false;
            this.daButton1.pLCBitselectRealize.Macrocode = resources.GetString("resource.Macrocode");
            this.daButton1.pLCBitselectRealize.MacroEvent = "Click";
            this.daButton1.pLCBitselectRealize.macroID = 2;
            this.daButton1.pLCBitselectRealize.MacroName = "MacroList2";
            this.daButton1.pLCBitselectRealize.NoAccessConceal = false;
            this.daButton1.pLCBitselectRealize.NoAccessForm = false;
            this.daButton1.pLCBitselectRealize.OperationAffirm = false;
            this.daButton1.pLCBitselectRealize.OutReverse = false;
            this.daButton1.pLCBitselectRealize.Pattern = PLC通讯基础控件项目.控件类基.控件数据结构.Button_pattern.selector_witch;
            this.daButton1.pLCBitselectRealize.PLCTimer = null;
            this.daButton1.pLCBitselectRealize.ReadCommand = false;
            this.daButton1.pLCBitselectRealize.ReadWrite = false;
            this.daButton1.pLCBitselectRealize.ReadWriteAddress = "20";
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
            this.daButton1.pLCBitselectRealize.TextContent_0 = "M20-OFF";
            this.daButton1.pLCBitselectRealize.TextContent_1 = "M20-ON";
            this.daButton1.pLCBitselectRealize.Textflicker_0 = 0;
            this.daButton1.pLCBitselectRealize.Textflicker_1 = 0;
            this.daButton1.pLCBitselectRealize.TextFont_0 = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daButton1.pLCBitselectRealize.TextFont_1 = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daButton1.pLCBitselectRealize.TextItalic_0 = false;
            this.daButton1.pLCBitselectRealize.TextItalic_1 = false;
            this.daButton1.pLCBitselectRealize.TextState = 0;
            this.daButton1.pLCBitselectRealize.TextUnderline_0 = false;
            this.daButton1.pLCBitselectRealize.TextUnderline_1 = false;
            this.daButton1.pLCBitselectRealize.WrietCommand = false;
            this.daButton1.pLCBitselectRealize.WriteAddress = "0";
            this.daButton1.pLCBitselectRealize.WriteFunction = "M";
            this.daButton1.pLCBitselectRealize.WritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daButton1.pLCBitselectRealize.WrSafetyAddress = "0";
            this.daButton1.PLCTimer = null;
            this.daButton1.ReadCommand = false;
            this.daButton1.Size = new System.Drawing.Size(176, 74);
            this.daButton1.TabIndex = 0;
            this.daButton1.Text = "M20-OFF";
            this.daButton1.Textalign_0 = "MiddleCenter";
            this.daButton1.Textalign_1 = "MiddleCenter";
            this.daButton1.TextColor_0 = System.Drawing.Color.White;
            this.daButton1.TextColor_1 = System.Drawing.Color.White;
            this.daButton1.TextContent_0 = "M20-OFF";
            this.daButton1.TextContent_1 = "M20-ON";
            this.daButton1.TextFont_0 = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daButton1.TextFont_1 = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daButton1.UseVisualStyleBackColor = false;
            // 
            // daMacroControl1
            // 
            this.daMacroControl1.Location = new System.Drawing.Point(153, 301);
            this.daMacroControl1.Name = "daMacroControl1";
            this.daMacroControl1.PLC_Enable = true;
            this.daMacroControl1.Size = new System.Drawing.Size(119, 82);
            this.daMacroControl1.TabIndex = 1;
            this.daMacroControl1.Text = "daMacroControl1";
            // 
            // daUiTextBox1
            // 
            this.daUiTextBox1.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.daUiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.daUiTextBox1.FillColor = System.Drawing.Color.White;
            this.daUiTextBox1.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiTextBox1.ForeColor = System.Drawing.Color.Black;
            this.daUiTextBox1.Location = new System.Drawing.Point(34, 264);
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
            this.daUiTextBox1.pLCDselectRealize.Macrocode = resources.GetString("resource.Macrocode1");
            this.daUiTextBox1.pLCDselectRealize.MacroEvent = "Click";
            this.daUiTextBox1.pLCDselectRealize.macroID = 2;
            this.daUiTextBox1.pLCDselectRealize.MacroName = "MacroList2";
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
            this.daUiTextBox1.pLCDselectRealize.ReadWriteAddress = "10";
            this.daUiTextBox1.pLCDselectRealize.ReadWriteFunction = "D";
            this.daUiTextBox1.pLCDselectRealize.ReadWritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
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
            this.daUiTextBox1.pLCDselectRealize.WrietCommand = false;
            this.daUiTextBox1.pLCDselectRealize.WriteAddress = "0";
            this.daUiTextBox1.pLCDselectRealize.WriteFunction = "D";
            this.daUiTextBox1.pLCDselectRealize.WritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daUiTextBox1.pLCDselectRealize.WrSafetyAddress = "0";
            this.daUiTextBox1.PLCTimer = null;
            this.daUiTextBox1.Size = new System.Drawing.Size(150, 29);
            this.daUiTextBox1.Style = Sunny.UI.UIStyle.Custom;
            this.daUiTextBox1.TabIndex = 2;
            this.daUiTextBox1.Text = "PLCpropertyText";
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
            // daPlcFunction1
            // 
            this.daPlcFunction1.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.daPlcFunction1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.daPlcFunction1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daPlcFunction1.FormClose = true;
            this.daPlcFunction1.FormName = "TemplateForm";
            this.daPlcFunction1.FormPath = "PLC通讯基础控件项目.模板与控制界面";
            this.daPlcFunction1.Location = new System.Drawing.Point(434, 131);
            this.daPlcFunction1.MinimumSize = new System.Drawing.Size(1, 1);
            this.daPlcFunction1.Name = "daPlcFunction1";
            this.daPlcFunction1.PLC_Enable = false;
            this.daPlcFunction1.Size = new System.Drawing.Size(100, 35);
            this.daPlcFunction1.TabIndex = 3;
            this.daPlcFunction1.Text = "daPlcFunction1";
            // 
            // plcBasement1
            // 
            this.plcBasement1.BackColor = System.Drawing.Color.DarkGray;
            this.plcBasement1.Location = new System.Drawing.Point(269, 0);
            this.plcBasement1.Name = "plcBasement1";
            this.plcBasement1.Size = new System.Drawing.Size(496, 280);
            this.plcBasement1.TabIndex = 4;
            // 
            // uiTextBox1
            // 
            this.uiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox1.FillColor = System.Drawing.Color.White;
            this.uiTextBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiTextBox1.Location = new System.Drawing.Point(46, 194);
            this.uiTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox1.Maximum = 2147483647D;
            this.uiTextBox1.Minimum = -2147483648D;
            this.uiTextBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.Size = new System.Drawing.Size(150, 29);
            this.uiTextBox1.TabIndex = 5;
            this.uiTextBox1.Text = "uiTextBox1";
            this.uiTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dAuiBarChart1
            // 
            this.dAuiBarChart1.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.dAuiBarChart1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.dAuiBarChart1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dAuiBarChart1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.dAuiBarChart1.Location = new System.Drawing.Point(278, 138);
            this.dAuiBarChart1.MinimumSize = new System.Drawing.Size(1, 1);
            this.dAuiBarChart1.Name = "dAuiBarChart1";
            this.dAuiBarChart1.PLC_Enable = true;
            this.dAuiBarChart1.pLCDataViewselectRealize.BindingName = "daButton1";
            this.dAuiBarChart1.pLCDataViewselectRealize.BindingOpen = false;
            this.dAuiBarChart1.pLCDataViewselectRealize.DataGridView_Name = new string[] {
        "Name",
        "Valeu1"};
            this.dAuiBarChart1.pLCDataViewselectRealize.DataGridView_numerical = new PLC通讯库.通讯枚举.numerical_format[] {
        PLC通讯库.通讯枚举.numerical_format.Signed_32_Bit,
        PLC通讯库.通讯枚举.numerical_format.Signed_32_Bit};
            this.dAuiBarChart1.pLCDataViewselectRealize.DataGridViewPLC_Time = false;
            this.dAuiBarChart1.pLCDataViewselectRealize.PLC_address = new string[] {
        "10",
        "12"};
            this.dAuiBarChart1.pLCDataViewselectRealize.ReadCommand = false;
            this.dAuiBarChart1.pLCDataViewselectRealize.ReadWriteFunction = new string[] {
        "D",
        "D"};
            this.dAuiBarChart1.pLCDataViewselectRealize.ReadWritePLC = new PLC通讯基础控件项目.控件类基.控件数据结构.PLC[] {
        PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi,
        PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi};
            this.dAuiBarChart1.pLCDataViewselectRealize.SQLCharacter = "uiTextBox2";
            this.dAuiBarChart1.pLCDataViewselectRealize.SQLOpen = false;
            this.dAuiBarChart1.pLCDataViewselectRealize.SQLServer_SQLinte = false;
            this.dAuiBarChart1.pLCDataViewselectRealize.SQLsurface = "";
            this.dAuiBarChart1.pLCDataViewselectRealize.SQLsurfaceType = new string[] {
        "varchar",
        "varchar"};
            this.dAuiBarChart1.ReadCommand = true;
            this.dAuiBarChart1.Size = new System.Drawing.Size(400, 300);
            this.dAuiBarChart1.TabIndex = 6;
            this.dAuiBarChart1.Text = "dAuiBarChart1";
            this.dAuiBarChart1.XAxisName = "标题";
            this.dAuiBarChart1.YAxisName = "标题";
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiButton1.Location = new System.Drawing.Point(46, 12);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(126, 78);
            this.uiButton1.TabIndex = 7;
            this.uiButton1.Text = "测试宏代码";
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.dAuiBarChart1);
            this.Controls.Add(this.uiTextBox1);
            this.Controls.Add(this.plcBasement1);
            this.Controls.Add(this.daPlcFunction1);
            this.Controls.Add(this.daUiTextBox1);
            this.Controls.Add(this.daMacroControl1);
            this.Controls.Add(this.daButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private PLC通讯基础控件项目.PLCControlsPreferences plcControlsPreferences1;
        private PLC通讯基础控件项目.PLC参数设置控件.PLCPreferences plcPreferences1;
        private PLC通讯基础控件项目.PLC参数设置控件.PLCPreferences plcPreferences2;
        private PLC通讯基础控件项目.基础控件.DAButton daButton1;
        private PLC通讯基础控件项目.基础控件.宏指令控件.DAMacroControl daMacroControl1;
        private PLC通讯基础控件项目.基础控件.DAUiTextBox daUiTextBox1;
        private PLC通讯基础控件项目.基础控件.底层PLC状态监控控件.DAPlcFunction daPlcFunction1;
        private PLC通讯基础控件项目.基础控件.底层PLC状态监控控件.PlcBasement plcBasement1;
        private Sunny.UI.UITextBox uiTextBox1;
        private PLC通讯基础控件项目.基础控件.DAuiBarChart dAuiBarChart1;
        private Sunny.UI.UIButton uiButton1;
    }
}