
namespace PLC通讯基础控件项目.模板与控制界面.二区手动界面
{
    partial class 二区手动主界面
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
            this.daUiButton3 = new PLC通讯基础控件项目.基础控件.DAUiButton();
            this.dauiAnalogMeter1 = new PLC通讯基础控件项目.基础控件.DAUIAnalogMeter();
            this.daUiButton2 = new PLC通讯基础控件项目.基础控件.DAUiButton();
            this.daUiButton1 = new PLC通讯基础控件项目.基础控件.DAUiButton();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiGroupBox2 = new Sunny.UI.UIGroupBox();
            this.daPlcFunction9 = new PLC通讯基础控件项目.基础控件.底层PLC状态监控控件.DAPlcFunction();
            this.daPlcFunction8 = new PLC通讯基础控件项目.基础控件.底层PLC状态监控控件.DAPlcFunction();
            this.daPlcFunction7 = new PLC通讯基础控件项目.基础控件.底层PLC状态监控控件.DAPlcFunction();
            this.daPlcFunction6 = new PLC通讯基础控件项目.基础控件.底层PLC状态监控控件.DAPlcFunction();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiPanel1.SuspendLayout();
            this.uiGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.uiLabel2);
            this.uiPanel1.Controls.Add(this.daUiButton3);
            this.uiPanel1.Controls.Add(this.dauiAnalogMeter1);
            this.uiPanel1.Controls.Add(this.daUiButton2);
            this.uiPanel1.Controls.Add(this.daUiButton1);
            this.uiPanel1.Controls.Add(this.uiLabel1);
            this.uiPanel1.Controls.Add(this.uiGroupBox2);
            this.uiPanel1.Controls.SetChildIndex(this.daPlcFunction2, 0);
            this.uiPanel1.Controls.SetChildIndex(this.daPlcFunction1, 0);
            this.uiPanel1.Controls.SetChildIndex(this.daPlcFunction3, 0);
            this.uiPanel1.Controls.SetChildIndex(this.daPlcFunction4, 0);
            this.uiPanel1.Controls.SetChildIndex(this.daPlcFunction5, 0);
            this.uiPanel1.Controls.SetChildIndex(this.uiGroupBox2, 0);
            this.uiPanel1.Controls.SetChildIndex(this.uiLabel1, 0);
            this.uiPanel1.Controls.SetChildIndex(this.daUiButton1, 0);
            this.uiPanel1.Controls.SetChildIndex(this.daUiButton2, 0);
            this.uiPanel1.Controls.SetChildIndex(this.dauiAnalogMeter1, 0);
            this.uiPanel1.Controls.SetChildIndex(this.daUiButton3, 0);
            this.uiPanel1.Controls.SetChildIndex(this.uiLabel2, 0);
            // 
            // daUiButton3
            // 
            this.daUiButton3.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.daUiButton3.backgroundColor_0 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(88)))));
            this.daUiButton3.backgroundColor_1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.daUiButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.daUiButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(88)))));
            this.daUiButton3.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(88)))));
            this.daUiButton3.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiButton3.Location = new System.Drawing.Point(647, 367);
            this.daUiButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.daUiButton3.Name = "daUiButton3";
            this.daUiButton3.PLC_Enable = true;
            this.daUiButton3.pLCBitselectRealize.AwaitTime = 0;
            this.daUiButton3.pLCBitselectRealize.backgroundColor_0 = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(88)))));
            this.daUiButton3.pLCBitselectRealize.backgroundColor_1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.daUiButton3.pLCBitselectRealize.BitPattern = false;
            this.daUiButton3.pLCBitselectRealize.description = "PLCBitselectRealize";
            this.daUiButton3.pLCBitselectRealize.keyMinTime = 0;
            this.daUiButton3.pLCBitselectRealize.LoosenOut = false;
            this.daUiButton3.pLCBitselectRealize.NoAccessConceal = false;
            this.daUiButton3.pLCBitselectRealize.NoAccessForm = false;
            this.daUiButton3.pLCBitselectRealize.OperationAffirm = false;
            this.daUiButton3.pLCBitselectRealize.OutReverse = false;
            this.daUiButton3.pLCBitselectRealize.Pattern = PLC通讯基础控件项目.控件类基.控件数据结构.Button_pattern.selector_witch;
            this.daUiButton3.pLCBitselectRealize.PLCTimer = null;
            this.daUiButton3.pLCBitselectRealize.ReadWrite = false;
            this.daUiButton3.pLCBitselectRealize.ReadWriteAddress = "510.1";
            this.daUiButton3.pLCBitselectRealize.ReadWriteFunction = "M";
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
            this.daUiButton3.pLCBitselectRealize.TextContent_0 = "段2-手动";
            this.daUiButton3.pLCBitselectRealize.TextContent_1 = "段2-自动";
            this.daUiButton3.pLCBitselectRealize.Textflicker_0 = 0;
            this.daUiButton3.pLCBitselectRealize.Textflicker_1 = 0;
            this.daUiButton3.pLCBitselectRealize.TextFont_0 = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiButton3.pLCBitselectRealize.TextFont_1 = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiButton3.pLCBitselectRealize.TextItalic_0 = false;
            this.daUiButton3.pLCBitselectRealize.TextItalic_1 = false;
            this.daUiButton3.pLCBitselectRealize.TextState = 0;
            this.daUiButton3.pLCBitselectRealize.TextUnderline_0 = false;
            this.daUiButton3.pLCBitselectRealize.TextUnderline_1 = false;
            this.daUiButton3.pLCBitselectRealize.WriteAddress = "0";
            this.daUiButton3.pLCBitselectRealize.WriteFunction = "M";
            this.daUiButton3.pLCBitselectRealize.WritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daUiButton3.pLCBitselectRealize.WrSafetyAddress = "0";
            this.daUiButton3.Size = new System.Drawing.Size(201, 73);
            this.daUiButton3.TabIndex = 16;
            this.daUiButton3.Text = "段2-手动";
            this.daUiButton3.Textalign_0 = "MiddleCenter";
            this.daUiButton3.Textalign_1 = "MiddleCenter";
            this.daUiButton3.TextColor_0 = System.Drawing.Color.White;
            this.daUiButton3.TextColor_1 = System.Drawing.Color.White;
            this.daUiButton3.TextContent_0 = "段2-手动";
            this.daUiButton3.TextContent_1 = "段2-自动";
            this.daUiButton3.TextFont_0 = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiButton3.TextFont_1 = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // dauiAnalogMeter1
            // 
            this.dauiAnalogMeter1.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.dauiAnalogMeter1.BodyColor = System.Drawing.Color.Transparent;
            this.dauiAnalogMeter1.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dauiAnalogMeter1.ForeColor = System.Drawing.Color.Black;
            this.dauiAnalogMeter1.Location = new System.Drawing.Point(619, 122);
            this.dauiAnalogMeter1.MaxValue = 100D;
            this.dauiAnalogMeter1.MinimumSize = new System.Drawing.Size(1, 1);
            this.dauiAnalogMeter1.MinValue = 0D;
            this.dauiAnalogMeter1.Name = "dauiAnalogMeter1";
            this.dauiAnalogMeter1.NeedleColor = System.Drawing.Color.DodgerBlue;
            this.dauiAnalogMeter1.PLC_Enable = true;
            this.dauiAnalogMeter1.pLCDselectRealize.AwaitTime = 0;
            this.dauiAnalogMeter1.pLCDselectRealize.Dataentryfunction = false;
            this.dauiAnalogMeter1.pLCDselectRealize.description = "PLCDselectRealize";
            this.dauiAnalogMeter1.pLCDselectRealize.Inform = false;
            this.dauiAnalogMeter1.pLCDselectRealize.InformAddress = "0";
            this.dauiAnalogMeter1.pLCDselectRealize.InformFunction = "M";
            this.dauiAnalogMeter1.pLCDselectRealize.Informpattern = 0;
            this.dauiAnalogMeter1.pLCDselectRealize.InformPLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.dauiAnalogMeter1.pLCDselectRealize.Keyboard = false;
            this.dauiAnalogMeter1.pLCDselectRealize.KeyboardStyle = "keyboard";
            this.dauiAnalogMeter1.pLCDselectRealize.keyMinTime = 0;
            this.dauiAnalogMeter1.pLCDselectRealize.NoAccessConceal = false;
            this.dauiAnalogMeter1.pLCDselectRealize.NoAccessForm = false;
            this.dauiAnalogMeter1.pLCDselectRealize.NumericaldigitMax = 7;
            this.dauiAnalogMeter1.pLCDselectRealize.NumericaldigitMin = 0;
            this.dauiAnalogMeter1.pLCDselectRealize.NumericalFormat = 0;
            this.dauiAnalogMeter1.pLCDselectRealize.NumericalMax = 9999999;
            this.dauiAnalogMeter1.pLCDselectRealize.NumericalMin = -999999;
            this.dauiAnalogMeter1.pLCDselectRealize.OperationAffirm = false;
            this.dauiAnalogMeter1.pLCDselectRealize.PLCTimer = null;
            this.dauiAnalogMeter1.pLCDselectRealize.ReadWrite = false;
            this.dauiAnalogMeter1.pLCDselectRealize.ReadWriteAddress = "252";
            this.dauiAnalogMeter1.pLCDselectRealize.ReadWriteFunction = "M";
            this.dauiAnalogMeter1.pLCDselectRealize.ReadWritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Siemens;
            this.dauiAnalogMeter1.pLCDselectRealize.SafetyBehaviorPattern = 1;
            this.dauiAnalogMeter1.pLCDselectRealize.SafetyCategory = 0;
            this.dauiAnalogMeter1.pLCDselectRealize.SafetyFunction = "M";
            this.dauiAnalogMeter1.pLCDselectRealize.SafetyPattern = 1;
            this.dauiAnalogMeter1.pLCDselectRealize.SafetyPLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.dauiAnalogMeter1.pLCDselectRealize.ShowFormat = PLC通讯库.通讯枚举.numerical_format.Signed_16_Bit;
            this.dauiAnalogMeter1.pLCDselectRealize.Speech = false;
            this.dauiAnalogMeter1.pLCDselectRealize.Textalign_0 = "BottomCenter";
            this.dauiAnalogMeter1.pLCDselectRealize.Textalign_1 = "BottomCenter";
            this.dauiAnalogMeter1.pLCDselectRealize.TextColor_0 = System.Drawing.Color.Black;
            this.dauiAnalogMeter1.pLCDselectRealize.TextColor_1 = System.Drawing.Color.Black;
            this.dauiAnalogMeter1.pLCDselectRealize.TextContent_0 = "PLCpropertyText";
            this.dauiAnalogMeter1.pLCDselectRealize.TextContent_1 = null;
            this.dauiAnalogMeter1.pLCDselectRealize.Textflicker_0 = 0;
            this.dauiAnalogMeter1.pLCDselectRealize.Textflicker_1 = 0;
            this.dauiAnalogMeter1.pLCDselectRealize.TextFont_0 = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dauiAnalogMeter1.pLCDselectRealize.TextFont_1 = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dauiAnalogMeter1.pLCDselectRealize.TextItalic_0 = false;
            this.dauiAnalogMeter1.pLCDselectRealize.TextItalic_1 = false;
            this.dauiAnalogMeter1.pLCDselectRealize.TextUnderline_0 = false;
            this.dauiAnalogMeter1.pLCDselectRealize.TextUnderline_1 = false;
            this.dauiAnalogMeter1.pLCDselectRealize.WriteAddress = "0";
            this.dauiAnalogMeter1.pLCDselectRealize.WriteFunction = "D";
            this.dauiAnalogMeter1.pLCDselectRealize.WritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.dauiAnalogMeter1.pLCDselectRealize.WrSafetyAddress = "0";
            this.dauiAnalogMeter1.ReadOnly = false;
            this.dauiAnalogMeter1.Renderer = null;
            this.dauiAnalogMeter1.ScaleColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dauiAnalogMeter1.Size = new System.Drawing.Size(260, 287);
            this.dauiAnalogMeter1.Style = Sunny.UI.UIStyle.Custom;
            this.dauiAnalogMeter1.StyleCustomMode = true;
            this.dauiAnalogMeter1.TabIndex = 17;
            this.dauiAnalogMeter1.Text = "0";
            this.dauiAnalogMeter1.Textalign_0 = null;
            this.dauiAnalogMeter1.Textalign_1 = null;
            this.dauiAnalogMeter1.TextColor_0 = System.Drawing.Color.Black;
            this.dauiAnalogMeter1.TextColor_1 = System.Drawing.Color.Black;
            this.dauiAnalogMeter1.TextContent_0 = "PLCpropertyText";
            this.dauiAnalogMeter1.TextContent_1 = null;
            this.dauiAnalogMeter1.TextFont_0 = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dauiAnalogMeter1.TextFont_1 = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dauiAnalogMeter1.Value = 0D;
            this.dauiAnalogMeter1.ViewGlass = true;
            // 
            // daUiButton2
            // 
            this.daUiButton2.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.daUiButton2.backgroundColor_0 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(69)))), ((int)(((byte)(0)))));
            this.daUiButton2.backgroundColor_1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.daUiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.daUiButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(69)))), ((int)(((byte)(0)))));
            this.daUiButton2.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(69)))), ((int)(((byte)(0)))));
            this.daUiButton2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiButton2.Location = new System.Drawing.Point(466, 498);
            this.daUiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.daUiButton2.Name = "daUiButton2";
            this.daUiButton2.PLC_Enable = true;
            this.daUiButton2.pLCBitselectRealize.AwaitTime = 0;
            this.daUiButton2.pLCBitselectRealize.backgroundColor_0 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(69)))), ((int)(((byte)(0)))));
            this.daUiButton2.pLCBitselectRealize.backgroundColor_1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.daUiButton2.pLCBitselectRealize.BitPattern = true;
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
            this.daUiButton2.pLCBitselectRealize.ReadWriteAddress = "407.6";
            this.daUiButton2.pLCBitselectRealize.ReadWriteFunction = "I";
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
            this.daUiButton2.pLCBitselectRealize.TextContent_0 = "二区安全门异常";
            this.daUiButton2.pLCBitselectRealize.TextContent_1 = "二区安全门正常";
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
            this.daUiButton2.Size = new System.Drawing.Size(124, 29);
            this.daUiButton2.TabIndex = 15;
            this.daUiButton2.Text = "二区安全门异常";
            this.daUiButton2.Textalign_0 = "MiddleCenter";
            this.daUiButton2.Textalign_1 = "MiddleCenter";
            this.daUiButton2.TextColor_0 = System.Drawing.Color.White;
            this.daUiButton2.TextColor_1 = System.Drawing.Color.White;
            this.daUiButton2.TextContent_0 = "二区安全门异常";
            this.daUiButton2.TextContent_1 = "二区安全门正常";
            this.daUiButton2.TextFont_0 = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiButton2.TextFont_1 = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // daUiButton1
            // 
            this.daUiButton1.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.daUiButton1.backgroundColor_0 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(69)))), ((int)(((byte)(0)))));
            this.daUiButton1.backgroundColor_1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.daUiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.daUiButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(69)))), ((int)(((byte)(0)))));
            this.daUiButton1.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(69)))), ((int)(((byte)(0)))));
            this.daUiButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiButton1.Location = new System.Drawing.Point(339, 498);
            this.daUiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.daUiButton1.Name = "daUiButton1";
            this.daUiButton1.PLC_Enable = true;
            this.daUiButton1.pLCBitselectRealize.AwaitTime = 0;
            this.daUiButton1.pLCBitselectRealize.backgroundColor_0 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(69)))), ((int)(((byte)(0)))));
            this.daUiButton1.pLCBitselectRealize.backgroundColor_1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.daUiButton1.pLCBitselectRealize.BitPattern = true;
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
            this.daUiButton1.pLCBitselectRealize.ReadWriteAddress = "407.2";
            this.daUiButton1.pLCBitselectRealize.ReadWriteFunction = "I";
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
            this.daUiButton1.pLCBitselectRealize.TextContent_0 = "二区急停异常";
            this.daUiButton1.pLCBitselectRealize.TextContent_1 = "二区急停正常";
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
            this.daUiButton1.Size = new System.Drawing.Size(124, 29);
            this.daUiButton1.TabIndex = 14;
            this.daUiButton1.Text = "二区急停异常";
            this.daUiButton1.Textalign_0 = "MiddleCenter";
            this.daUiButton1.Textalign_1 = "MiddleCenter";
            this.daUiButton1.TextColor_0 = System.Drawing.Color.White;
            this.daUiButton1.TextColor_1 = System.Drawing.Color.White;
            this.daUiButton1.TextContent_0 = "二区急停异常";
            this.daUiButton1.TextContent_1 = "二区急停正常";
            this.daUiButton1.TextFont_0 = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiButton1.TextFont_1 = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel1.Location = new System.Drawing.Point(34, 501);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(329, 23);
            this.uiLabel1.TabIndex = 13;
            this.uiLabel1.Text = "注意：进入手动界面前是否开启手动！！！";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.daPlcFunction9);
            this.uiGroupBox2.Controls.Add(this.daPlcFunction8);
            this.uiGroupBox2.Controls.Add(this.daPlcFunction7);
            this.uiGroupBox2.Controls.Add(this.daPlcFunction6);
            this.uiGroupBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiGroupBox2.Location = new System.Drawing.Point(34, 57);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox2.Size = new System.Drawing.Size(556, 437);
            this.uiGroupBox2.TabIndex = 12;
            this.uiGroupBox2.Text = "手动界面";
            this.uiGroupBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiGroupBox2.TitleAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // daPlcFunction9
            // 
            this.daPlcFunction9.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.daPlcFunction9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.daPlcFunction9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daPlcFunction9.FormName = "PY03手动界面";
            this.daPlcFunction9.FormPath = "PLC通讯基础控件项目.模板与控制界面";
            this.daPlcFunction9.Location = new System.Drawing.Point(38, 159);
            this.daPlcFunction9.MinimumSize = new System.Drawing.Size(1, 1);
            this.daPlcFunction9.Name = "daPlcFunction9";
            this.daPlcFunction9.PLC_Enable = true;
            this.daPlcFunction9.Size = new System.Drawing.Size(125, 49);
            this.daPlcFunction9.TabIndex = 3;
            this.daPlcFunction9.Text = "PY03-手动界面";
            // 
            // daPlcFunction8
            // 
            this.daPlcFunction8.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.daPlcFunction8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.daPlcFunction8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daPlcFunction8.FormName = "PY02后手动界面";
            this.daPlcFunction8.FormPath = "PLC通讯基础控件项目.模板与控制界面";
            this.daPlcFunction8.Location = new System.Drawing.Point(390, 71);
            this.daPlcFunction8.MinimumSize = new System.Drawing.Size(1, 1);
            this.daPlcFunction8.Name = "daPlcFunction8";
            this.daPlcFunction8.PLC_Enable = true;
            this.daPlcFunction8.Size = new System.Drawing.Size(125, 49);
            this.daPlcFunction8.TabIndex = 2;
            this.daPlcFunction8.Text = "PY02后手动界面";
            // 
            // daPlcFunction7
            // 
            this.daPlcFunction7.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.daPlcFunction7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.daPlcFunction7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daPlcFunction7.FormName = "PY02前手动界面";
            this.daPlcFunction7.FormPath = "PLC通讯基础控件项目.模板与控制界面";
            this.daPlcFunction7.Location = new System.Drawing.Point(215, 71);
            this.daPlcFunction7.MinimumSize = new System.Drawing.Size(1, 1);
            this.daPlcFunction7.Name = "daPlcFunction7";
            this.daPlcFunction7.PLC_Enable = true;
            this.daPlcFunction7.Size = new System.Drawing.Size(125, 49);
            this.daPlcFunction7.TabIndex = 1;
            this.daPlcFunction7.Text = "PY02前手动界面";
            // 
            // daPlcFunction6
            // 
            this.daPlcFunction6.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.daPlcFunction6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.daPlcFunction6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daPlcFunction6.FormName = "FL3手动界面";
            this.daPlcFunction6.FormPath = "PLC通讯基础控件项目.模板与控制界面";
            this.daPlcFunction6.Location = new System.Drawing.Point(38, 71);
            this.daPlcFunction6.MinimumSize = new System.Drawing.Size(1, 1);
            this.daPlcFunction6.Name = "daPlcFunction6";
            this.daPlcFunction6.PLC_Enable = true;
            this.daPlcFunction6.Size = new System.Drawing.Size(125, 49);
            this.daPlcFunction6.TabIndex = 0;
            this.daPlcFunction6.Text = "FL3-手动界面";
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel2.Location = new System.Drawing.Point(706, 329);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(100, 23);
            this.uiLabel2.TabIndex = 18;
            this.uiLabel2.Text = "ROB速度";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // 二区手动主界面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 679);
            this.Name = "二区手动主界面";
            this.Text = "二区手动主界面";
            this.uiPanel1.ResumeLayout(false);
            this.uiGroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private 基础控件.DAUiButton daUiButton3;
        private 基础控件.DAUIAnalogMeter dauiAnalogMeter1;
        private 基础控件.DAUiButton daUiButton2;
        private 基础控件.DAUiButton daUiButton1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private 基础控件.底层PLC状态监控控件.DAPlcFunction daPlcFunction9;
        private 基础控件.底层PLC状态监控控件.DAPlcFunction daPlcFunction8;
        private 基础控件.底层PLC状态监控控件.DAPlcFunction daPlcFunction7;
        private 基础控件.底层PLC状态监控控件.DAPlcFunction daPlcFunction6;
        private Sunny.UI.UILabel uiLabel2;
    }
}