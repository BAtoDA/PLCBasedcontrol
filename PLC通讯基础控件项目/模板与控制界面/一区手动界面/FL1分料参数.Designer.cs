
namespace PLC通讯基础控件项目.模板与控制界面.一区手动界面
{
    partial class FL1分料参数
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
            this.daTextBox1 = new PLC通讯基础控件项目.基础控件.DATextBox();
            this.uiGroupBox2 = new Sunny.UI.UIGroupBox();
            this.daUiButton2 = new PLC通讯基础控件项目.基础控件.DAUiButton();
            this.daUiButton1 = new PLC通讯基础控件项目.基础控件.DAUiButton();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.daTextBox4 = new PLC通讯基础控件项目.基础控件.DATextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.daTextBox3 = new PLC通讯基础控件项目.基础控件.DATextBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.daTextBox2 = new PLC通讯基础控件项目.基础控件.DATextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiGroupBox3 = new Sunny.UI.UIGroupBox();
            this.uiGroupBox4 = new Sunny.UI.UIGroupBox();
            this.uiPanel1.SuspendLayout();
            this.uiGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
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
            // 
            // daTextBox1
            // 
            this.daTextBox1.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.daTextBox1.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daTextBox1.ForeColor = System.Drawing.Color.Black;
            this.daTextBox1.Location = new System.Drawing.Point(28, 71);
            this.daTextBox1.Name = "daTextBox1";
            this.daTextBox1.PLC_Enable = true;
            this.daTextBox1.pLCDselectRealize.AwaitTime = 0;
            this.daTextBox1.pLCDselectRealize.Dataentryfunction = false;
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
            this.daTextBox1.pLCDselectRealize.NumericaldigitMin = 0;
            this.daTextBox1.pLCDselectRealize.NumericalFormat = 0;
            this.daTextBox1.pLCDselectRealize.NumericalMax = 9999999;
            this.daTextBox1.pLCDselectRealize.NumericalMin = -999999;
            this.daTextBox1.pLCDselectRealize.OperationAffirm = false;
            this.daTextBox1.pLCDselectRealize.PLCTimer = null;
            this.daTextBox1.pLCDselectRealize.ReadWrite = false;
            this.daTextBox1.pLCDselectRealize.ReadWriteAddress = "149.0";
            this.daTextBox1.pLCDselectRealize.ReadWriteFunction = "DB";
            this.daTextBox1.pLCDselectRealize.ReadWritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Siemens;
            this.daTextBox1.pLCDselectRealize.SafetyBehaviorPattern = 1;
            this.daTextBox1.pLCDselectRealize.SafetyCategory = 0;
            this.daTextBox1.pLCDselectRealize.SafetyFunction = "M";
            this.daTextBox1.pLCDselectRealize.SafetyPattern = 1;
            this.daTextBox1.pLCDselectRealize.SafetyPLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daTextBox1.pLCDselectRealize.ShowFormat = PLC通讯库.通讯枚举.numerical_format.Signed_32_Bit;
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
            this.daTextBox1.Size = new System.Drawing.Size(133, 21);
            this.daTextBox1.TabIndex = 5;
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
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.daUiButton2);
            this.uiGroupBox2.Controls.Add(this.daUiButton1);
            this.uiGroupBox2.Controls.Add(this.uiLabel4);
            this.uiGroupBox2.Controls.Add(this.daTextBox4);
            this.uiGroupBox2.Controls.Add(this.uiLabel3);
            this.uiGroupBox2.Controls.Add(this.daTextBox3);
            this.uiGroupBox2.Controls.Add(this.uiLabel2);
            this.uiGroupBox2.Controls.Add(this.daTextBox2);
            this.uiGroupBox2.Controls.Add(this.uiLabel1);
            this.uiGroupBox2.Controls.Add(this.daTextBox1);
            this.uiGroupBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiGroupBox2.Location = new System.Drawing.Point(10, 60);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox2.Size = new System.Drawing.Size(428, 201);
            this.uiGroupBox2.TabIndex = 6;
            this.uiGroupBox2.Text = "伺服位置";
            this.uiGroupBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiGroupBox2.TitleAlignment = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.daUiButton2.Location = new System.Drawing.Point(337, 147);
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
            this.daUiButton2.pLCBitselectRealize.Pattern = PLC通讯基础控件项目.控件类基.控件数据结构.Button_pattern.Regression;
            this.daUiButton2.pLCBitselectRealize.PLCTimer = null;
            this.daUiButton2.pLCBitselectRealize.ReadWrite = false;
            this.daUiButton2.pLCBitselectRealize.ReadWriteAddress = "8102.7";
            this.daUiButton2.pLCBitselectRealize.ReadWriteFunction = "M";
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
            this.daUiButton2.pLCBitselectRealize.TextContent_0 = "示教";
            this.daUiButton2.pLCBitselectRealize.TextContent_1 = "示教";
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
            this.daUiButton2.Size = new System.Drawing.Size(84, 35);
            this.daUiButton2.TabIndex = 14;
            this.daUiButton2.Text = "示教";
            this.daUiButton2.Textalign_0 = "MiddleCenter";
            this.daUiButton2.Textalign_1 = "MiddleCenter";
            this.daUiButton2.TextColor_0 = System.Drawing.Color.White;
            this.daUiButton2.TextColor_1 = System.Drawing.Color.White;
            this.daUiButton2.TextContent_0 = "示教";
            this.daUiButton2.TextContent_1 = "示教";
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
            this.daUiButton1.Location = new System.Drawing.Point(337, 64);
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
            this.daUiButton1.pLCBitselectRealize.Pattern = PLC通讯基础控件项目.控件类基.控件数据结构.Button_pattern.Regression;
            this.daUiButton1.pLCBitselectRealize.PLCTimer = null;
            this.daUiButton1.pLCBitselectRealize.ReadWrite = false;
            this.daUiButton1.pLCBitselectRealize.ReadWriteAddress = "8102.6";
            this.daUiButton1.pLCBitselectRealize.ReadWriteFunction = "M";
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
            this.daUiButton1.pLCBitselectRealize.TextContent_0 = "示教";
            this.daUiButton1.pLCBitselectRealize.TextContent_1 = "示教";
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
            this.daUiButton1.Size = new System.Drawing.Size(84, 35);
            this.daUiButton1.TabIndex = 13;
            this.daUiButton1.Text = "示教";
            this.daUiButton1.Textalign_0 = "MiddleCenter";
            this.daUiButton1.Textalign_1 = "MiddleCenter";
            this.daUiButton1.TextColor_0 = System.Drawing.Color.White;
            this.daUiButton1.TextColor_1 = System.Drawing.Color.White;
            this.daUiButton1.TextContent_0 = "示教";
            this.daUiButton1.TextContent_1 = "示教";
            this.daUiButton1.TextFont_0 = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiButton1.TextFont_1 = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel4.Location = new System.Drawing.Point(206, 123);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(100, 23);
            this.uiLabel4.TabIndex = 12;
            this.uiLabel4.Text = "放料位置";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // daTextBox4
            // 
            this.daTextBox4.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.daTextBox4.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daTextBox4.ForeColor = System.Drawing.Color.Black;
            this.daTextBox4.Location = new System.Drawing.Point(186, 153);
            this.daTextBox4.Name = "daTextBox4";
            this.daTextBox4.PLC_Enable = true;
            this.daTextBox4.pLCDselectRealize.AwaitTime = 0;
            this.daTextBox4.pLCDselectRealize.Dataentryfunction = false;
            this.daTextBox4.pLCDselectRealize.description = "PLCDselectRealize";
            this.daTextBox4.pLCDselectRealize.Inform = false;
            this.daTextBox4.pLCDselectRealize.InformAddress = "0";
            this.daTextBox4.pLCDselectRealize.InformFunction = "M";
            this.daTextBox4.pLCDselectRealize.Informpattern = 0;
            this.daTextBox4.pLCDselectRealize.InformPLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daTextBox4.pLCDselectRealize.Keyboard = true;
            this.daTextBox4.pLCDselectRealize.KeyboardStyle = "keyboard";
            this.daTextBox4.pLCDselectRealize.keyMinTime = 0;
            this.daTextBox4.pLCDselectRealize.NoAccessConceal = false;
            this.daTextBox4.pLCDselectRealize.NoAccessForm = false;
            this.daTextBox4.pLCDselectRealize.NumericaldigitMax = 7;
            this.daTextBox4.pLCDselectRealize.NumericaldigitMin = 0;
            this.daTextBox4.pLCDselectRealize.NumericalFormat = 0;
            this.daTextBox4.pLCDselectRealize.NumericalMax = 9999999;
            this.daTextBox4.pLCDselectRealize.NumericalMin = -999999;
            this.daTextBox4.pLCDselectRealize.OperationAffirm = false;
            this.daTextBox4.pLCDselectRealize.PLCTimer = null;
            this.daTextBox4.pLCDselectRealize.ReadWrite = false;
            this.daTextBox4.pLCDselectRealize.ReadWriteAddress = "149.24";
            this.daTextBox4.pLCDselectRealize.ReadWriteFunction = "DB";
            this.daTextBox4.pLCDselectRealize.ReadWritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Siemens;
            this.daTextBox4.pLCDselectRealize.SafetyBehaviorPattern = 1;
            this.daTextBox4.pLCDselectRealize.SafetyCategory = 0;
            this.daTextBox4.pLCDselectRealize.SafetyFunction = "M";
            this.daTextBox4.pLCDselectRealize.SafetyPattern = 1;
            this.daTextBox4.pLCDselectRealize.SafetyPLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daTextBox4.pLCDselectRealize.ShowFormat = PLC通讯库.通讯枚举.numerical_format.Signed_32_Bit;
            this.daTextBox4.pLCDselectRealize.Speech = false;
            this.daTextBox4.pLCDselectRealize.Textalign_0 = "BottomCenter";
            this.daTextBox4.pLCDselectRealize.Textalign_1 = "BottomCenter";
            this.daTextBox4.pLCDselectRealize.TextColor_0 = System.Drawing.Color.Black;
            this.daTextBox4.pLCDselectRealize.TextColor_1 = System.Drawing.Color.Black;
            this.daTextBox4.pLCDselectRealize.TextContent_0 = "0";
            this.daTextBox4.pLCDselectRealize.TextContent_1 = "0";
            this.daTextBox4.pLCDselectRealize.Textflicker_0 = 0;
            this.daTextBox4.pLCDselectRealize.Textflicker_1 = 0;
            this.daTextBox4.pLCDselectRealize.TextFont_0 = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daTextBox4.pLCDselectRealize.TextFont_1 = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daTextBox4.pLCDselectRealize.TextItalic_0 = false;
            this.daTextBox4.pLCDselectRealize.TextItalic_1 = false;
            this.daTextBox4.pLCDselectRealize.TextUnderline_0 = false;
            this.daTextBox4.pLCDselectRealize.TextUnderline_1 = false;
            this.daTextBox4.pLCDselectRealize.WriteAddress = "0";
            this.daTextBox4.pLCDselectRealize.WriteFunction = "D";
            this.daTextBox4.pLCDselectRealize.WritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daTextBox4.pLCDselectRealize.WrSafetyAddress = "0";
            this.daTextBox4.ReadOnly = true;
            this.daTextBox4.Size = new System.Drawing.Size(133, 21);
            this.daTextBox4.TabIndex = 11;
            this.daTextBox4.Text = "0";
            this.daTextBox4.Textalign_0 = null;
            this.daTextBox4.Textalign_1 = null;
            this.daTextBox4.TextColor_0 = System.Drawing.Color.Black;
            this.daTextBox4.TextColor_1 = System.Drawing.Color.Black;
            this.daTextBox4.TextContent_0 = "0";
            this.daTextBox4.TextContent_1 = "0";
            this.daTextBox4.TextFont_0 = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daTextBox4.TextFont_1 = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel3.Location = new System.Drawing.Point(206, 41);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(100, 23);
            this.uiLabel3.TabIndex = 10;
            this.uiLabel3.Text = "取料位置";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // daTextBox3
            // 
            this.daTextBox3.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.daTextBox3.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daTextBox3.ForeColor = System.Drawing.Color.Black;
            this.daTextBox3.Location = new System.Drawing.Point(186, 71);
            this.daTextBox3.Name = "daTextBox3";
            this.daTextBox3.PLC_Enable = true;
            this.daTextBox3.pLCDselectRealize.AwaitTime = 0;
            this.daTextBox3.pLCDselectRealize.Dataentryfunction = false;
            this.daTextBox3.pLCDselectRealize.description = "PLCDselectRealize";
            this.daTextBox3.pLCDselectRealize.Inform = false;
            this.daTextBox3.pLCDselectRealize.InformAddress = "0";
            this.daTextBox3.pLCDselectRealize.InformFunction = "M";
            this.daTextBox3.pLCDselectRealize.Informpattern = 0;
            this.daTextBox3.pLCDselectRealize.InformPLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daTextBox3.pLCDselectRealize.Keyboard = true;
            this.daTextBox3.pLCDselectRealize.KeyboardStyle = "keyboard";
            this.daTextBox3.pLCDselectRealize.keyMinTime = 0;
            this.daTextBox3.pLCDselectRealize.NoAccessConceal = false;
            this.daTextBox3.pLCDselectRealize.NoAccessForm = false;
            this.daTextBox3.pLCDselectRealize.NumericaldigitMax = 7;
            this.daTextBox3.pLCDselectRealize.NumericaldigitMin = 0;
            this.daTextBox3.pLCDselectRealize.NumericalFormat = 0;
            this.daTextBox3.pLCDselectRealize.NumericalMax = 9999999;
            this.daTextBox3.pLCDselectRealize.NumericalMin = -999999;
            this.daTextBox3.pLCDselectRealize.OperationAffirm = false;
            this.daTextBox3.pLCDselectRealize.PLCTimer = null;
            this.daTextBox3.pLCDselectRealize.ReadWrite = false;
            this.daTextBox3.pLCDselectRealize.ReadWriteAddress = "149.20";
            this.daTextBox3.pLCDselectRealize.ReadWriteFunction = "DB";
            this.daTextBox3.pLCDselectRealize.ReadWritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Siemens;
            this.daTextBox3.pLCDselectRealize.SafetyBehaviorPattern = 1;
            this.daTextBox3.pLCDselectRealize.SafetyCategory = 0;
            this.daTextBox3.pLCDselectRealize.SafetyFunction = "M";
            this.daTextBox3.pLCDselectRealize.SafetyPattern = 1;
            this.daTextBox3.pLCDselectRealize.SafetyPLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daTextBox3.pLCDselectRealize.ShowFormat = PLC通讯库.通讯枚举.numerical_format.Signed_32_Bit;
            this.daTextBox3.pLCDselectRealize.Speech = false;
            this.daTextBox3.pLCDselectRealize.Textalign_0 = "BottomCenter";
            this.daTextBox3.pLCDselectRealize.Textalign_1 = "BottomCenter";
            this.daTextBox3.pLCDselectRealize.TextColor_0 = System.Drawing.Color.Black;
            this.daTextBox3.pLCDselectRealize.TextColor_1 = System.Drawing.Color.Black;
            this.daTextBox3.pLCDselectRealize.TextContent_0 = "0";
            this.daTextBox3.pLCDselectRealize.TextContent_1 = "0";
            this.daTextBox3.pLCDselectRealize.Textflicker_0 = 0;
            this.daTextBox3.pLCDselectRealize.Textflicker_1 = 0;
            this.daTextBox3.pLCDselectRealize.TextFont_0 = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daTextBox3.pLCDselectRealize.TextFont_1 = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daTextBox3.pLCDselectRealize.TextItalic_0 = false;
            this.daTextBox3.pLCDselectRealize.TextItalic_1 = false;
            this.daTextBox3.pLCDselectRealize.TextUnderline_0 = false;
            this.daTextBox3.pLCDselectRealize.TextUnderline_1 = false;
            this.daTextBox3.pLCDselectRealize.WriteAddress = "0";
            this.daTextBox3.pLCDselectRealize.WriteFunction = "D";
            this.daTextBox3.pLCDselectRealize.WritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daTextBox3.pLCDselectRealize.WrSafetyAddress = "0";
            this.daTextBox3.ReadOnly = true;
            this.daTextBox3.Size = new System.Drawing.Size(133, 21);
            this.daTextBox3.TabIndex = 9;
            this.daTextBox3.Text = "0";
            this.daTextBox3.Textalign_0 = null;
            this.daTextBox3.Textalign_1 = null;
            this.daTextBox3.TextColor_0 = System.Drawing.Color.Black;
            this.daTextBox3.TextColor_1 = System.Drawing.Color.Black;
            this.daTextBox3.TextContent_0 = "0";
            this.daTextBox3.TextContent_1 = "0";
            this.daTextBox3.TextFont_0 = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daTextBox3.TextFont_1 = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel2.Location = new System.Drawing.Point(48, 123);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(100, 23);
            this.uiLabel2.TabIndex = 8;
            this.uiLabel2.Text = "当前速度";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // daTextBox2
            // 
            this.daTextBox2.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.daTextBox2.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daTextBox2.ForeColor = System.Drawing.Color.Black;
            this.daTextBox2.Location = new System.Drawing.Point(28, 154);
            this.daTextBox2.Name = "daTextBox2";
            this.daTextBox2.PLC_Enable = true;
            this.daTextBox2.pLCDselectRealize.AwaitTime = 0;
            this.daTextBox2.pLCDselectRealize.Dataentryfunction = false;
            this.daTextBox2.pLCDselectRealize.description = "PLCDselectRealize";
            this.daTextBox2.pLCDselectRealize.Inform = false;
            this.daTextBox2.pLCDselectRealize.InformAddress = "0";
            this.daTextBox2.pLCDselectRealize.InformFunction = "M";
            this.daTextBox2.pLCDselectRealize.Informpattern = 0;
            this.daTextBox2.pLCDselectRealize.InformPLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daTextBox2.pLCDselectRealize.Keyboard = true;
            this.daTextBox2.pLCDselectRealize.KeyboardStyle = "keyboard";
            this.daTextBox2.pLCDselectRealize.keyMinTime = 0;
            this.daTextBox2.pLCDselectRealize.NoAccessConceal = false;
            this.daTextBox2.pLCDselectRealize.NoAccessForm = false;
            this.daTextBox2.pLCDselectRealize.NumericaldigitMax = 7;
            this.daTextBox2.pLCDselectRealize.NumericaldigitMin = 0;
            this.daTextBox2.pLCDselectRealize.NumericalFormat = 0;
            this.daTextBox2.pLCDselectRealize.NumericalMax = 9999999;
            this.daTextBox2.pLCDselectRealize.NumericalMin = -999999;
            this.daTextBox2.pLCDselectRealize.OperationAffirm = false;
            this.daTextBox2.pLCDselectRealize.PLCTimer = null;
            this.daTextBox2.pLCDselectRealize.ReadWrite = false;
            this.daTextBox2.pLCDselectRealize.ReadWriteAddress = "149.4";
            this.daTextBox2.pLCDselectRealize.ReadWriteFunction = "DB";
            this.daTextBox2.pLCDselectRealize.ReadWritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Siemens;
            this.daTextBox2.pLCDselectRealize.SafetyBehaviorPattern = 1;
            this.daTextBox2.pLCDselectRealize.SafetyCategory = 0;
            this.daTextBox2.pLCDselectRealize.SafetyFunction = "M";
            this.daTextBox2.pLCDselectRealize.SafetyPattern = 1;
            this.daTextBox2.pLCDselectRealize.SafetyPLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daTextBox2.pLCDselectRealize.ShowFormat = PLC通讯库.通讯枚举.numerical_format.Signed_32_Bit;
            this.daTextBox2.pLCDselectRealize.Speech = false;
            this.daTextBox2.pLCDselectRealize.Textalign_0 = "BottomCenter";
            this.daTextBox2.pLCDselectRealize.Textalign_1 = "BottomCenter";
            this.daTextBox2.pLCDselectRealize.TextColor_0 = System.Drawing.Color.Black;
            this.daTextBox2.pLCDselectRealize.TextColor_1 = System.Drawing.Color.Black;
            this.daTextBox2.pLCDselectRealize.TextContent_0 = "0";
            this.daTextBox2.pLCDselectRealize.TextContent_1 = "0";
            this.daTextBox2.pLCDselectRealize.Textflicker_0 = 0;
            this.daTextBox2.pLCDselectRealize.Textflicker_1 = 0;
            this.daTextBox2.pLCDselectRealize.TextFont_0 = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daTextBox2.pLCDselectRealize.TextFont_1 = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daTextBox2.pLCDselectRealize.TextItalic_0 = false;
            this.daTextBox2.pLCDselectRealize.TextItalic_1 = false;
            this.daTextBox2.pLCDselectRealize.TextUnderline_0 = false;
            this.daTextBox2.pLCDselectRealize.TextUnderline_1 = false;
            this.daTextBox2.pLCDselectRealize.WriteAddress = "0";
            this.daTextBox2.pLCDselectRealize.WriteFunction = "D";
            this.daTextBox2.pLCDselectRealize.WritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daTextBox2.pLCDselectRealize.WrSafetyAddress = "0";
            this.daTextBox2.ReadOnly = true;
            this.daTextBox2.Size = new System.Drawing.Size(133, 21);
            this.daTextBox2.TabIndex = 7;
            this.daTextBox2.Text = "0";
            this.daTextBox2.Textalign_0 = null;
            this.daTextBox2.Textalign_1 = null;
            this.daTextBox2.TextColor_0 = System.Drawing.Color.Black;
            this.daTextBox2.TextColor_1 = System.Drawing.Color.Black;
            this.daTextBox2.TextContent_0 = "0";
            this.daTextBox2.TextContent_1 = "0";
            this.daTextBox2.TextFont_0 = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daTextBox2.TextFont_1 = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiLabel1.Location = new System.Drawing.Point(48, 41);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 23);
            this.uiLabel1.TabIndex = 6;
            this.uiLabel1.Text = "当前位置";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiGroupBox3
            // 
            this.uiGroupBox3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiGroupBox3.Location = new System.Drawing.Point(10, 325);
            this.uiGroupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox3.Name = "uiGroupBox3";
            this.uiGroupBox3.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox3.Size = new System.Drawing.Size(405, 201);
            this.uiGroupBox3.TabIndex = 7;
            this.uiGroupBox3.Text = "伺服速度";
            this.uiGroupBox3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiGroupBox3.TitleAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uiGroupBox4
            // 
            this.uiGroupBox4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiGroupBox4.Location = new System.Drawing.Point(487, 60);
            this.uiGroupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox4.Name = "uiGroupBox4";
            this.uiGroupBox4.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox4.Size = new System.Drawing.Size(405, 201);
            this.uiGroupBox4.TabIndex = 8;
            this.uiGroupBox4.Text = "伺服控制";
            this.uiGroupBox4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiGroupBox4.TitleAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FL1分料参数
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 679);
            this.Name = "FL1分料参数";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FL1分料参数";
            this.uiPanel1.ResumeLayout(false);
            this.uiGroupBox2.ResumeLayout(false);
            this.uiGroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIGroupBox uiGroupBox4;
        private Sunny.UI.UIGroupBox uiGroupBox3;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private 基础控件.DATextBox daTextBox1;
        private Sunny.UI.UILabel uiLabel2;
        private 基础控件.DATextBox daTextBox2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel4;
        private 基础控件.DATextBox daTextBox4;
        private Sunny.UI.UILabel uiLabel3;
        private 基础控件.DATextBox daTextBox3;
        private 基础控件.DAUiButton daUiButton2;
        private 基础控件.DAUiButton daUiButton1;
    }
}