namespace 测试项目
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            uiButton1 = new Sunny.UI.UIButton();
            uiGroupBox1 = new Sunny.UI.UIGroupBox();
            uiTextBox2 = new Sunny.UI.UITextBox();
            dAuiLabel2 = new PLC通讯基础控件项目.基础控件.DAuiLabel();
            uiLedBulb1 = new Sunny.UI.UILedBulb();
            uiTextBox1 = new Sunny.UI.UITextBox();
            dAuiLabel1 = new PLC通讯基础控件项目.基础控件.DAuiLabel();
            uiButton2 = new Sunny.UI.UIButton();
            uiGroupBox2 = new Sunny.UI.UIGroupBox();
            uiButton6 = new Sunny.UI.UIButton();
            uiButton7 = new Sunny.UI.UIButton();
            uiButton8 = new Sunny.UI.UIButton();
            uiButton5 = new Sunny.UI.UIButton();
            uiButton3 = new Sunny.UI.UIButton();
            uiButton4 = new Sunny.UI.UIButton();
            uiTabControl1 = new Sunny.UI.UITabControl();
            tabPage2 = new TabPage();
            daMacroControl1 = new PLC通讯基础控件项目.基础控件.宏指令控件.DAMacroControl(components);
            daUiTextBox1 = new PLC通讯基础控件项目.基础控件.DAUiTextBox();
            daButton1 = new PLC通讯基础控件项目.基础控件.DAButton();
            daDataViewToPlc1 = new PLC通讯基础控件项目.基础控件.DADataViewToPlc();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            uiGroupBox5 = new Sunny.UI.UIGroupBox();
            uiGroupBox4 = new Sunny.UI.UIGroupBox();
            tabPage1 = new TabPage();
            uiGroupBox3 = new Sunny.UI.UIGroupBox();
            richTextBox1 = new RichTextBox();
            plcControlsPreferences1 = new PLC通讯基础控件项目.PLCControlsPreferences(components);
            plcPreferences1 = new PLC通讯基础控件项目.PLC参数设置控件.PLCPreferences();
            uiGroupBox1.SuspendLayout();
            uiGroupBox2.SuspendLayout();
            uiTabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)daDataViewToPlc1).BeginInit();
            tabPage1.SuspendLayout();
            uiGroupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // uiButton1
            // 
            uiButton1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton1.IsScaled = false;
            uiButton1.Location = new Point(46, 134);
            uiButton1.Margin = new Padding(4);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Size = new Size(147, 66);
            uiButton1.TabIndex = 1;
            uiButton1.Text = "OpenRobot";
            uiButton1.Click += uiButton1_Click;
            // 
            // uiGroupBox1
            // 
            uiGroupBox1.Controls.Add(uiTextBox2);
            uiGroupBox1.Controls.Add(dAuiLabel2);
            uiGroupBox1.Controls.Add(uiLedBulb1);
            uiGroupBox1.Controls.Add(uiTextBox1);
            uiGroupBox1.Controls.Add(dAuiLabel1);
            uiGroupBox1.Controls.Add(uiButton2);
            uiGroupBox1.Controls.Add(uiButton1);
            uiGroupBox1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiGroupBox1.IsScaled = false;
            uiGroupBox1.Location = new Point(4, 4);
            uiGroupBox1.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox1.MinimumSize = new Size(1, 1);
            uiGroupBox1.Name = "uiGroupBox1";
            uiGroupBox1.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox1.Size = new Size(464, 227);
            uiGroupBox1.TabIndex = 2;
            uiGroupBox1.Text = "打开\\关闭";
            uiGroupBox1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiTextBox2
            // 
            uiTextBox2.ButtonSymbol = 61761;
            uiTextBox2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTextBox2.IsScaled = false;
            uiTextBox2.Location = new Point(102, 85);
            uiTextBox2.Margin = new Padding(4, 5, 4, 5);
            uiTextBox2.Maximum = 2147483647D;
            uiTextBox2.Minimum = -2147483648D;
            uiTextBox2.MinimumSize = new Size(1, 16);
            uiTextBox2.Name = "uiTextBox2";
            uiTextBox2.Size = new Size(243, 42);
            uiTextBox2.TabIndex = 8;
            uiTextBox2.Text = "uiTextBox2";
            uiTextBox2.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // dAuiLabel2
            // 
            dAuiLabel2.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            dAuiLabel2.BackColor = Color.Transparent;
            dAuiLabel2.Cursor = Cursors.SizeAll;
            dAuiLabel2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dAuiLabel2.Location = new Point(50, 91);
            dAuiLabel2.Name = "dAuiLabel2";
            dAuiLabel2.PLC_Enable = false;
            dAuiLabel2.pLCDselectRealize.AwaitTime = 0;
            dAuiLabel2.pLCDselectRealize.Compilestate = false;
            dAuiLabel2.pLCDselectRealize.Dataentryfunction = true;
            dAuiLabel2.pLCDselectRealize.description = "PLCDselectRealize";
            dAuiLabel2.pLCDselectRealize.Inform = false;
            dAuiLabel2.pLCDselectRealize.InformAddress = "0";
            dAuiLabel2.pLCDselectRealize.InformFunction = "M";
            dAuiLabel2.pLCDselectRealize.Informpattern = 0;
            dAuiLabel2.pLCDselectRealize.InformPLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            dAuiLabel2.pLCDselectRealize.Keyboard = true;
            dAuiLabel2.pLCDselectRealize.KeyboardStyle = "keyboard";
            dAuiLabel2.pLCDselectRealize.keyMinTime = 0;
            dAuiLabel2.pLCDselectRealize.Macrocode = resources.GetString("resource.Macrocode");
            dAuiLabel2.pLCDselectRealize.MacroEvent = "不使用";
            dAuiLabel2.pLCDselectRealize.macroID = 1;
            dAuiLabel2.pLCDselectRealize.MacroName = "MacroList";
            dAuiLabel2.pLCDselectRealize.NoAccessConceal = false;
            dAuiLabel2.pLCDselectRealize.NoAccessForm = false;
            dAuiLabel2.pLCDselectRealize.NumericaldigitMax = 7;
            dAuiLabel2.pLCDselectRealize.NumericaldigitMin = 0;
            dAuiLabel2.pLCDselectRealize.NumericalFormat = 0;
            dAuiLabel2.pLCDselectRealize.NumericalMax = 9999999;
            dAuiLabel2.pLCDselectRealize.NumericalMin = -999999;
            dAuiLabel2.pLCDselectRealize.OperationAffirm = false;
            dAuiLabel2.pLCDselectRealize.PLCTimer = null;
            dAuiLabel2.pLCDselectRealize.ReadWrite = false;
            dAuiLabel2.pLCDselectRealize.ReadWriteAddress = "0";
            dAuiLabel2.pLCDselectRealize.ReadWriteFunction = "D";
            dAuiLabel2.pLCDselectRealize.ReadWritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            dAuiLabel2.pLCDselectRealize.SafetyBehaviorPattern = 1;
            dAuiLabel2.pLCDselectRealize.SafetyCategory = 0;
            dAuiLabel2.pLCDselectRealize.SafetyFunction = "M";
            dAuiLabel2.pLCDselectRealize.SafetyPattern = 1;
            dAuiLabel2.pLCDselectRealize.SafetyPLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            dAuiLabel2.pLCDselectRealize.ShowFormat = PLC通讯库.通讯枚举.numerical_format.Signed_32_Bit;
            dAuiLabel2.pLCDselectRealize.Speech = false;
            dAuiLabel2.pLCDselectRealize.Textalign_0 = "BottomCenter";
            dAuiLabel2.pLCDselectRealize.Textalign_1 = "BottomCenter";
            dAuiLabel2.pLCDselectRealize.TextColor_0 = Color.Black;
            dAuiLabel2.pLCDselectRealize.TextColor_1 = Color.Black;
            dAuiLabel2.pLCDselectRealize.TextContent_0 = null;
            dAuiLabel2.pLCDselectRealize.TextContent_1 = null;
            dAuiLabel2.pLCDselectRealize.Textflicker_0 = 0;
            dAuiLabel2.pLCDselectRealize.Textflicker_1 = 0;
            dAuiLabel2.pLCDselectRealize.TextFont_0 = new Font("黑体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dAuiLabel2.pLCDselectRealize.TextFont_1 = new Font("黑体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dAuiLabel2.pLCDselectRealize.TextItalic_0 = false;
            dAuiLabel2.pLCDselectRealize.TextItalic_1 = false;
            dAuiLabel2.pLCDselectRealize.TextUnderline_0 = false;
            dAuiLabel2.pLCDselectRealize.TextUnderline_1 = false;
            dAuiLabel2.pLCDselectRealize.WrietCommand = false;
            dAuiLabel2.pLCDselectRealize.WriteAddress = "0";
            dAuiLabel2.pLCDselectRealize.WriteFunction = "D";
            dAuiLabel2.pLCDselectRealize.WritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            dAuiLabel2.pLCDselectRealize.WrSafetyAddress = "0";
            dAuiLabel2.PLCTimer = null;
            dAuiLabel2.Size = new Size(125, 29);
            dAuiLabel2.Style = Sunny.UI.UIStyle.Custom;
            dAuiLabel2.StyleCustomMode = true;
            dAuiLabel2.TabIndex = 7;
            dAuiLabel2.TextAlign = ContentAlignment.MiddleLeft;
            dAuiLabel2.Textalign_0 = null;
            dAuiLabel2.Textalign_1 = null;
            dAuiLabel2.TextColor_0 = Color.Black;
            dAuiLabel2.TextColor_1 = Color.Empty;
            dAuiLabel2.TextContent_0 = null;
            dAuiLabel2.TextContent_1 = null;
            dAuiLabel2.TextFont_0 = null;
            dAuiLabel2.TextFont_1 = null;
            // 
            // uiLedBulb1
            // 
            uiLedBulb1.Location = new Point(362, 63);
            uiLedBulb1.Name = "uiLedBulb1";
            uiLedBulb1.Size = new Size(40, 40);
            uiLedBulb1.TabIndex = 6;
            uiLedBulb1.Text = "uiLedBulb1";
            uiLedBulb1.Click += uiLedBulb1_Click;
            // 
            // uiTextBox1
            // 
            uiTextBox1.ButtonSymbol = 61761;
            uiTextBox1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTextBox1.IsScaled = false;
            uiTextBox1.Location = new Point(102, 38);
            uiTextBox1.Margin = new Padding(4, 5, 4, 5);
            uiTextBox1.Maximum = 2147483647D;
            uiTextBox1.Minimum = -2147483648D;
            uiTextBox1.MinimumSize = new Size(1, 16);
            uiTextBox1.Name = "uiTextBox1";
            uiTextBox1.Size = new Size(243, 42);
            uiTextBox1.TabIndex = 5;
            uiTextBox1.Text = "uiTextBox1";
            uiTextBox1.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // dAuiLabel1
            // 
            dAuiLabel1.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            dAuiLabel1.BackColor = Color.Transparent;
            dAuiLabel1.Cursor = Cursors.SizeAll;
            dAuiLabel1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dAuiLabel1.Location = new Point(64, 44);
            dAuiLabel1.Name = "dAuiLabel1";
            dAuiLabel1.PLC_Enable = false;
            dAuiLabel1.pLCDselectRealize.AwaitTime = 0;
            dAuiLabel1.pLCDselectRealize.Compilestate = false;
            dAuiLabel1.pLCDselectRealize.Dataentryfunction = true;
            dAuiLabel1.pLCDselectRealize.description = "PLCDselectRealize";
            dAuiLabel1.pLCDselectRealize.Inform = false;
            dAuiLabel1.pLCDselectRealize.InformAddress = "0";
            dAuiLabel1.pLCDselectRealize.InformFunction = "M";
            dAuiLabel1.pLCDselectRealize.Informpattern = 0;
            dAuiLabel1.pLCDselectRealize.InformPLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            dAuiLabel1.pLCDselectRealize.Keyboard = true;
            dAuiLabel1.pLCDselectRealize.KeyboardStyle = "keyboard";
            dAuiLabel1.pLCDselectRealize.keyMinTime = 0;
            dAuiLabel1.pLCDselectRealize.Macrocode = resources.GetString("resource.Macrocode1");
            dAuiLabel1.pLCDselectRealize.MacroEvent = "不使用";
            dAuiLabel1.pLCDselectRealize.macroID = 1;
            dAuiLabel1.pLCDselectRealize.MacroName = "MacroList";
            dAuiLabel1.pLCDselectRealize.NoAccessConceal = false;
            dAuiLabel1.pLCDselectRealize.NoAccessForm = false;
            dAuiLabel1.pLCDselectRealize.NumericaldigitMax = 7;
            dAuiLabel1.pLCDselectRealize.NumericaldigitMin = 0;
            dAuiLabel1.pLCDselectRealize.NumericalFormat = 0;
            dAuiLabel1.pLCDselectRealize.NumericalMax = 9999999;
            dAuiLabel1.pLCDselectRealize.NumericalMin = -999999;
            dAuiLabel1.pLCDselectRealize.OperationAffirm = false;
            dAuiLabel1.pLCDselectRealize.PLCTimer = null;
            dAuiLabel1.pLCDselectRealize.ReadWrite = false;
            dAuiLabel1.pLCDselectRealize.ReadWriteAddress = "0";
            dAuiLabel1.pLCDselectRealize.ReadWriteFunction = "D";
            dAuiLabel1.pLCDselectRealize.ReadWritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            dAuiLabel1.pLCDselectRealize.SafetyBehaviorPattern = 1;
            dAuiLabel1.pLCDselectRealize.SafetyCategory = 0;
            dAuiLabel1.pLCDselectRealize.SafetyFunction = "M";
            dAuiLabel1.pLCDselectRealize.SafetyPattern = 1;
            dAuiLabel1.pLCDselectRealize.SafetyPLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            dAuiLabel1.pLCDselectRealize.ShowFormat = PLC通讯库.通讯枚举.numerical_format.Signed_32_Bit;
            dAuiLabel1.pLCDselectRealize.Speech = false;
            dAuiLabel1.pLCDselectRealize.Textalign_0 = "BottomCenter";
            dAuiLabel1.pLCDselectRealize.Textalign_1 = "BottomCenter";
            dAuiLabel1.pLCDselectRealize.TextColor_0 = Color.Black;
            dAuiLabel1.pLCDselectRealize.TextColor_1 = Color.Black;
            dAuiLabel1.pLCDselectRealize.TextContent_0 = null;
            dAuiLabel1.pLCDselectRealize.TextContent_1 = null;
            dAuiLabel1.pLCDselectRealize.Textflicker_0 = 0;
            dAuiLabel1.pLCDselectRealize.Textflicker_1 = 0;
            dAuiLabel1.pLCDselectRealize.TextFont_0 = new Font("黑体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dAuiLabel1.pLCDselectRealize.TextFont_1 = new Font("黑体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dAuiLabel1.pLCDselectRealize.TextItalic_0 = false;
            dAuiLabel1.pLCDselectRealize.TextItalic_1 = false;
            dAuiLabel1.pLCDselectRealize.TextUnderline_0 = false;
            dAuiLabel1.pLCDselectRealize.TextUnderline_1 = false;
            dAuiLabel1.pLCDselectRealize.WrietCommand = false;
            dAuiLabel1.pLCDselectRealize.WriteAddress = "0";
            dAuiLabel1.pLCDselectRealize.WriteFunction = "D";
            dAuiLabel1.pLCDselectRealize.WritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            dAuiLabel1.pLCDselectRealize.WrSafetyAddress = "0";
            dAuiLabel1.PLCTimer = null;
            dAuiLabel1.Size = new Size(125, 29);
            dAuiLabel1.Style = Sunny.UI.UIStyle.Custom;
            dAuiLabel1.StyleCustomMode = true;
            dAuiLabel1.TabIndex = 4;
            dAuiLabel1.TextAlign = ContentAlignment.MiddleLeft;
            dAuiLabel1.Textalign_0 = null;
            dAuiLabel1.Textalign_1 = null;
            dAuiLabel1.TextColor_0 = Color.Black;
            dAuiLabel1.TextColor_1 = Color.Empty;
            dAuiLabel1.TextContent_0 = null;
            dAuiLabel1.TextContent_1 = null;
            dAuiLabel1.TextFont_0 = null;
            dAuiLabel1.TextFont_1 = null;
            // 
            // uiButton2
            // 
            uiButton2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton2.IsScaled = false;
            uiButton2.Location = new Point(240, 134);
            uiButton2.Margin = new Padding(4);
            uiButton2.MinimumSize = new Size(1, 1);
            uiButton2.Name = "uiButton2";
            uiButton2.Size = new Size(147, 66);
            uiButton2.TabIndex = 2;
            uiButton2.Text = "CloseRobot";
            uiButton2.Click += uiButton2_Click;
            // 
            // uiGroupBox2
            // 
            uiGroupBox2.Controls.Add(uiButton6);
            uiGroupBox2.Controls.Add(uiButton7);
            uiGroupBox2.Controls.Add(uiButton8);
            uiGroupBox2.Controls.Add(uiButton5);
            uiGroupBox2.Controls.Add(uiButton3);
            uiGroupBox2.Controls.Add(uiButton4);
            uiGroupBox2.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiGroupBox2.IsScaled = false;
            uiGroupBox2.Location = new Point(476, 5);
            uiGroupBox2.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox2.MinimumSize = new Size(1, 1);
            uiGroupBox2.Name = "uiGroupBox2";
            uiGroupBox2.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox2.Size = new Size(540, 227);
            uiGroupBox2.TabIndex = 3;
            uiGroupBox2.Text = "读\\写操作";
            uiGroupBox2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiButton6
            // 
            uiButton6.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton6.IsScaled = false;
            uiButton6.Location = new Point(376, 91);
            uiButton6.Margin = new Padding(4);
            uiButton6.MinimumSize = new Size(1, 1);
            uiButton6.Name = "uiButton6";
            uiButton6.Size = new Size(142, 44);
            uiButton6.TabIndex = 6;
            uiButton6.Text = "ReadDO";
            // 
            // uiButton7
            // 
            uiButton7.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton7.IsScaled = false;
            uiButton7.Location = new Point(197, 91);
            uiButton7.Margin = new Padding(4);
            uiButton7.MinimumSize = new Size(1, 1);
            uiButton7.Name = "uiButton7";
            uiButton7.Size = new Size(142, 44);
            uiButton7.TabIndex = 5;
            uiButton7.Text = "ReadDI";
            // 
            // uiButton8
            // 
            uiButton8.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton8.IsScaled = false;
            uiButton8.Location = new Point(24, 91);
            uiButton8.Margin = new Padding(4);
            uiButton8.MinimumSize = new Size(1, 1);
            uiButton8.Name = "uiButton8";
            uiButton8.Size = new Size(142, 44);
            uiButton8.TabIndex = 4;
            uiButton8.Text = "刷新";
            uiButton8.Click += uiButton8_Click;
            // 
            // uiButton5
            // 
            uiButton5.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton5.IsScaled = false;
            uiButton5.Location = new Point(377, 36);
            uiButton5.Margin = new Padding(4);
            uiButton5.MinimumSize = new Size(1, 1);
            uiButton5.Name = "uiButton5";
            uiButton5.Size = new Size(142, 44);
            uiButton5.TabIndex = 3;
            uiButton5.Text = "WrietSR";
            // 
            // uiButton3
            // 
            uiButton3.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton3.IsScaled = false;
            uiButton3.Location = new Point(198, 36);
            uiButton3.Margin = new Padding(4);
            uiButton3.MinimumSize = new Size(1, 1);
            uiButton3.Name = "uiButton3";
            uiButton3.Size = new Size(142, 44);
            uiButton3.TabIndex = 2;
            uiButton3.Text = "WrietR";
            // 
            // uiButton4
            // 
            uiButton4.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiButton4.IsScaled = false;
            uiButton4.Location = new Point(25, 36);
            uiButton4.Margin = new Padding(4);
            uiButton4.MinimumSize = new Size(1, 1);
            uiButton4.Name = "uiButton4";
            uiButton4.Size = new Size(142, 44);
            uiButton4.TabIndex = 1;
            uiButton4.Text = "WrietPR";
            uiButton4.Click += uiButton4_Click;
            // 
            // uiTabControl1
            // 
            uiTabControl1.Controls.Add(tabPage2);
            uiTabControl1.Controls.Add(tabPage1);
            uiTabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            uiTabControl1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTabControl1.ItemSize = new Size(150, 40);
            uiTabControl1.Location = new Point(5, 35);
            uiTabControl1.MainPage = "";
            uiTabControl1.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            uiTabControl1.Name = "uiTabControl1";
            uiTabControl1.SelectedIndex = 0;
            uiTabControl1.Size = new Size(1020, 527);
            uiTabControl1.SizeMode = TabSizeMode.Fixed;
            uiTabControl1.TabIndex = 9;
            uiTabControl1.TabUnSelectedForeColor = Color.FromArgb(240, 240, 240);
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(daMacroControl1);
            tabPage2.Controls.Add(daUiTextBox1);
            tabPage2.Controls.Add(daButton1);
            tabPage2.Controls.Add(daDataViewToPlc1);
            tabPage2.Controls.Add(uiGroupBox5);
            tabPage2.Controls.Add(uiGroupBox4);
            tabPage2.Location = new Point(0, 40);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(1020, 487);
            tabPage2.TabIndex = 1;
            tabPage2.Text = " ";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // daMacroControl1
            // 
            daMacroControl1.Location = new Point(788, 405);
            daMacroControl1.Name = "daMacroControl1";
            daMacroControl1.PLC_Enable = true;
            daMacroControl1.Size = new Size(94, 29);
            daMacroControl1.TabIndex = 4;
            daMacroControl1.Text = "daMacroControl1";
            // 
            // daUiTextBox1
            // 
            daUiTextBox1.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            daUiTextBox1.FillColor = Color.White;
            daUiTextBox1.Font = new Font("黑体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            daUiTextBox1.ForeColor = Color.Black;
            daUiTextBox1.IsScaled = false;
            daUiTextBox1.Location = new Point(817, 352);
            daUiTextBox1.Margin = new Padding(4, 5, 4, 5);
            daUiTextBox1.Maximum = 2147483647D;
            daUiTextBox1.Minimum = -2147483648D;
            daUiTextBox1.MinimumSize = new Size(1, 1);
            daUiTextBox1.Name = "daUiTextBox1";
            daUiTextBox1.PLC_Enable = true;
            daUiTextBox1.pLCDselectRealize.AwaitTime = 0;
            daUiTextBox1.pLCDselectRealize.Compilestate = false;
            daUiTextBox1.pLCDselectRealize.Dataentryfunction = true;
            daUiTextBox1.pLCDselectRealize.description = "PLCDselectRealize";
            daUiTextBox1.pLCDselectRealize.Inform = false;
            daUiTextBox1.pLCDselectRealize.InformAddress = "0";
            daUiTextBox1.pLCDselectRealize.InformFunction = "M";
            daUiTextBox1.pLCDselectRealize.Informpattern = 0;
            daUiTextBox1.pLCDselectRealize.InformPLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            daUiTextBox1.pLCDselectRealize.Keyboard = true;
            daUiTextBox1.pLCDselectRealize.KeyboardStyle = "keyboard";
            daUiTextBox1.pLCDselectRealize.keyMinTime = 0;
            daUiTextBox1.pLCDselectRealize.Macrocode = resources.GetString("resource.Macrocode2");
            daUiTextBox1.pLCDselectRealize.MacroEvent = "不使用";
            daUiTextBox1.pLCDselectRealize.macroID = 1;
            daUiTextBox1.pLCDselectRealize.MacroName = "MacroList";
            daUiTextBox1.pLCDselectRealize.NoAccessConceal = false;
            daUiTextBox1.pLCDselectRealize.NoAccessForm = false;
            daUiTextBox1.pLCDselectRealize.NumericaldigitMax = 7;
            daUiTextBox1.pLCDselectRealize.NumericaldigitMin = 0;
            daUiTextBox1.pLCDselectRealize.NumericalFormat = 0;
            daUiTextBox1.pLCDselectRealize.NumericalMax = 9999999;
            daUiTextBox1.pLCDselectRealize.NumericalMin = -999999;
            daUiTextBox1.pLCDselectRealize.OperationAffirm = false;
            daUiTextBox1.pLCDselectRealize.PLCTimer = null;
            daUiTextBox1.pLCDselectRealize.ReadWrite = false;
            daUiTextBox1.pLCDselectRealize.ReadWriteAddress = "1";
            daUiTextBox1.pLCDselectRealize.ReadWriteFunction = "RW";
            daUiTextBox1.pLCDselectRealize.ReadWritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.HMI;
            daUiTextBox1.pLCDselectRealize.SafetyBehaviorPattern = 1;
            daUiTextBox1.pLCDselectRealize.SafetyCategory = 0;
            daUiTextBox1.pLCDselectRealize.SafetyFunction = "M";
            daUiTextBox1.pLCDselectRealize.SafetyPattern = 1;
            daUiTextBox1.pLCDselectRealize.SafetyPLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            daUiTextBox1.pLCDselectRealize.ShowFormat = PLC通讯库.通讯枚举.numerical_format.Signed_32_Bit;
            daUiTextBox1.pLCDselectRealize.Speech = false;
            daUiTextBox1.pLCDselectRealize.Textalign_0 = "BottomCenter";
            daUiTextBox1.pLCDselectRealize.Textalign_1 = "BottomCenter";
            daUiTextBox1.pLCDselectRealize.TextColor_0 = Color.Black;
            daUiTextBox1.pLCDselectRealize.TextColor_1 = Color.Black;
            daUiTextBox1.pLCDselectRealize.TextContent_0 = "PLCpropertyText";
            daUiTextBox1.pLCDselectRealize.TextContent_1 = null;
            daUiTextBox1.pLCDselectRealize.Textflicker_0 = 0;
            daUiTextBox1.pLCDselectRealize.Textflicker_1 = 0;
            daUiTextBox1.pLCDselectRealize.TextFont_0 = new Font("黑体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            daUiTextBox1.pLCDselectRealize.TextFont_1 = new Font("黑体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            daUiTextBox1.pLCDselectRealize.TextItalic_0 = false;
            daUiTextBox1.pLCDselectRealize.TextItalic_1 = false;
            daUiTextBox1.pLCDselectRealize.TextUnderline_0 = false;
            daUiTextBox1.pLCDselectRealize.TextUnderline_1 = false;
            daUiTextBox1.pLCDselectRealize.WrietCommand = false;
            daUiTextBox1.pLCDselectRealize.WriteAddress = "0";
            daUiTextBox1.pLCDselectRealize.WriteFunction = "D";
            daUiTextBox1.pLCDselectRealize.WritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            daUiTextBox1.pLCDselectRealize.WrSafetyAddress = "0";
            daUiTextBox1.PLCTimer = null;
            daUiTextBox1.Size = new Size(188, 42);
            daUiTextBox1.Style = Sunny.UI.UIStyle.Custom;
            daUiTextBox1.TabIndex = 3;
            daUiTextBox1.Text = "0";
            daUiTextBox1.Textalign_0 = "BottomCenter";
            daUiTextBox1.Textalign_1 = "BottomCenter";
            daUiTextBox1.TextAlignment = ContentAlignment.MiddleLeft;
            daUiTextBox1.TextColor_0 = Color.Black;
            daUiTextBox1.TextColor_1 = Color.Black;
            daUiTextBox1.TextContent_0 = "PLCpropertyText";
            daUiTextBox1.TextContent_1 = null;
            daUiTextBox1.TextFont_0 = new Font("黑体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            daUiTextBox1.TextFont_1 = new Font("黑体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // daButton1
            // 
            daButton1.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            daButton1.BackColor = Color.Silver;
            daButton1.backgroundColor_0 = Color.Silver;
            daButton1.backgroundColor_1 = Color.FromArgb(128, 255, 128);
            daButton1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            daButton1.ForeColor = Color.White;
            daButton1.Location = new Point(848, 296);
            daButton1.Name = "daButton1";
            daButton1.PLC_Enable = true;
            daButton1.pLCBitselectRealize.AwaitTime = 0;
            daButton1.pLCBitselectRealize.backgroundColor_0 = Color.Silver;
            daButton1.pLCBitselectRealize.backgroundColor_1 = Color.FromArgb(128, 255, 128);
            daButton1.pLCBitselectRealize.BitPattern = false;
            daButton1.pLCBitselectRealize.Compilestate = false;
            daButton1.pLCBitselectRealize.description = "PLCBitselectRealize";
            daButton1.pLCBitselectRealize.keyMinTime = 0;
            daButton1.pLCBitselectRealize.LoosenOut = false;
            daButton1.pLCBitselectRealize.Macrocode = resources.GetString("resource.Macrocode3");
            daButton1.pLCBitselectRealize.MacroEvent = "不使用";
            daButton1.pLCBitselectRealize.macroID = 1;
            daButton1.pLCBitselectRealize.MacroName = "MacroList";
            daButton1.pLCBitselectRealize.NoAccessConceal = false;
            daButton1.pLCBitselectRealize.NoAccessForm = false;
            daButton1.pLCBitselectRealize.OperationAffirm = false;
            daButton1.pLCBitselectRealize.OutReverse = false;
            daButton1.pLCBitselectRealize.Pattern = PLC通讯基础控件项目.控件类基.控件数据结构.Button_pattern.Set_as_on;
            daButton1.pLCBitselectRealize.PLCTimer = null;
            daButton1.pLCBitselectRealize.ReadCommand = false;
            daButton1.pLCBitselectRealize.ReadWrite = false;
            daButton1.pLCBitselectRealize.ReadWriteAddress = "1";
            daButton1.pLCBitselectRealize.ReadWriteFunction = "RB";
            daButton1.pLCBitselectRealize.ReadWritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.HMI;
            daButton1.pLCBitselectRealize.SafetyBehaviorPattern = 0;
            daButton1.pLCBitselectRealize.SafetyCategory = 0;
            daButton1.pLCBitselectRealize.SafetyFunction = "M";
            daButton1.pLCBitselectRealize.SafetyPattern = 0;
            daButton1.pLCBitselectRealize.SafetyPLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            daButton1.pLCBitselectRealize.Speech = false;
            daButton1.pLCBitselectRealize.Textalign_0 = "MiddleCenter";
            daButton1.pLCBitselectRealize.Textalign_1 = "MiddleCenter";
            daButton1.pLCBitselectRealize.TextColor_0 = Color.White;
            daButton1.pLCBitselectRealize.TextColor_1 = Color.White;
            daButton1.pLCBitselectRealize.TextContent_0 = "OFF";
            daButton1.pLCBitselectRealize.TextContent_1 = "ON";
            daButton1.pLCBitselectRealize.Textflicker_0 = 0;
            daButton1.pLCBitselectRealize.Textflicker_1 = 0;
            daButton1.pLCBitselectRealize.TextFont_0 = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            daButton1.pLCBitselectRealize.TextFont_1 = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            daButton1.pLCBitselectRealize.TextItalic_0 = false;
            daButton1.pLCBitselectRealize.TextItalic_1 = false;
            daButton1.pLCBitselectRealize.TextState = 0;
            daButton1.pLCBitselectRealize.TextUnderline_0 = false;
            daButton1.pLCBitselectRealize.TextUnderline_1 = false;
            daButton1.pLCBitselectRealize.WrietCommand = false;
            daButton1.pLCBitselectRealize.WriteAddress = "0";
            daButton1.pLCBitselectRealize.WriteFunction = "M";
            daButton1.pLCBitselectRealize.WritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            daButton1.pLCBitselectRealize.WrSafetyAddress = "0";
            daButton1.PLCTimer = null;
            daButton1.ReadCommand = false;
            daButton1.Size = new Size(94, 29);
            daButton1.TabIndex = 2;
            daButton1.Text = "OFF";
            daButton1.Textalign_0 = "MiddleCenter";
            daButton1.Textalign_1 = "MiddleCenter";
            daButton1.TextColor_0 = Color.White;
            daButton1.TextColor_1 = Color.White;
            daButton1.TextContent_0 = "OFF";
            daButton1.TextContent_1 = "ON";
            daButton1.TextFont_0 = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            daButton1.TextFont_1 = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            daButton1.UseVisualStyleBackColor = false;
            // 
            // daDataViewToPlc1
            // 
            dataGridViewCellStyle6.BackColor = Color.FromArgb(235, 243, 255);
            daDataViewToPlc1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            daDataViewToPlc1.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            daDataViewToPlc1.BackgroundColor = Color.White;
            daDataViewToPlc1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle7.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            daDataViewToPlc1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            daDataViewToPlc1.ColumnHeadersHeight = 32;
            daDataViewToPlc1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            daDataViewToPlc1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(155, 200, 255);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            daDataViewToPlc1.DefaultCellStyle = dataGridViewCellStyle8;
            daDataViewToPlc1.EnableHeadersVisualStyles = false;
            daDataViewToPlc1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            daDataViewToPlc1.GridColor = Color.FromArgb(80, 160, 255);
            daDataViewToPlc1.Location = new Point(127, 221);
            daDataViewToPlc1.Name = "daDataViewToPlc1";
            daDataViewToPlc1.PLC_Enable = true;
            daDataViewToPlc1.pLCDataViewselectRealize.BindingName = null;
            daDataViewToPlc1.pLCDataViewselectRealize.BindingOpen = false;
            daDataViewToPlc1.pLCDataViewselectRealize.DataGridView_Name = new string[] { "Name", "Valeu1", "Valeu2", "Valeu3" };
            daDataViewToPlc1.pLCDataViewselectRealize.DataGridView_numerical = new PLC通讯库.通讯枚举.numerical_format[] { PLC通讯库.通讯枚举.numerical_format.Signed_32_Bit, PLC通讯库.通讯枚举.numerical_format.Signed_32_Bit, PLC通讯库.通讯枚举.numerical_format.Signed_32_Bit, PLC通讯库.通讯枚举.numerical_format.Signed_32_Bit };
            daDataViewToPlc1.pLCDataViewselectRealize.DataGridViewPLC_Time = false;
            daDataViewToPlc1.pLCDataViewselectRealize.PLC_address = new string[] { "0", "0", "0", "0" };
            daDataViewToPlc1.pLCDataViewselectRealize.ReadCommand = false;
            daDataViewToPlc1.pLCDataViewselectRealize.ReadWriteFunction = new string[] { "D", "D", "D", "D" };
            daDataViewToPlc1.pLCDataViewselectRealize.ReadWritePLC = new PLC通讯基础控件项目.控件类基.控件数据结构.PLC[] { PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi, PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi, PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi, PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi };
            daDataViewToPlc1.pLCDataViewselectRealize.SQLCharacter = null;
            daDataViewToPlc1.pLCDataViewselectRealize.SQLOpen = false;
            daDataViewToPlc1.pLCDataViewselectRealize.SQLServer_SQLinte = false;
            daDataViewToPlc1.pLCDataViewselectRealize.SQLsurface = null;
            daDataViewToPlc1.pLCDataViewselectRealize.SQLsurfaceType = new string[] { "String", "String", "String", "String" };
            daDataViewToPlc1.ReadCommand = false;
            daDataViewToPlc1.ReadCommandData = null;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle9.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            daDataViewToPlc1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            daDataViewToPlc1.RowHeadersWidth = 51;
            daDataViewToPlc1.RowHeight = 29;
            dataGridViewCellStyle10.BackColor = Color.White;
            daDataViewToPlc1.RowsDefaultCellStyle = dataGridViewCellStyle10;
            daDataViewToPlc1.RowTemplate.Height = 29;
            daDataViewToPlc1.SelectedIndex = -1;
            daDataViewToPlc1.ShowGridLine = true;
            daDataViewToPlc1.Size = new Size(618, 202);
            daDataViewToPlc1.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Name";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.ToolTipText = "Name";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Valeu1";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.ToolTipText = "Valeu1";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Valeu2";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.ToolTipText = "Valeu2";
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Valeu3";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.ToolTipText = "Valeu3";
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // uiGroupBox5
            // 
            uiGroupBox5.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiGroupBox5.IsScaled = false;
            uiGroupBox5.Location = new Point(530, 5);
            uiGroupBox5.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox5.MinimumSize = new Size(1, 1);
            uiGroupBox5.Name = "uiGroupBox5";
            uiGroupBox5.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox5.Size = new Size(486, 233);
            uiGroupBox5.TabIndex = 1;
            uiGroupBox5.Text = "位置寄存器";
            uiGroupBox5.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiGroupBox4
            // 
            uiGroupBox4.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiGroupBox4.IsScaled = false;
            uiGroupBox4.Location = new Point(3, 5);
            uiGroupBox4.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox4.MinimumSize = new Size(1, 1);
            uiGroupBox4.Name = "uiGroupBox4";
            uiGroupBox4.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox4.Size = new Size(519, 233);
            uiGroupBox4.TabIndex = 0;
            uiGroupBox4.Text = "世界坐标";
            uiGroupBox4.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(uiGroupBox3);
            tabPage1.Controls.Add(uiGroupBox2);
            tabPage1.Controls.Add(uiGroupBox1);
            tabPage1.Location = new Point(0, 40);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(200, 60);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "操作";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // uiGroupBox3
            // 
            uiGroupBox3.Controls.Add(richTextBox1);
            uiGroupBox3.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiGroupBox3.IsScaled = false;
            uiGroupBox3.Location = new Point(5, 236);
            uiGroupBox3.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox3.MinimumSize = new Size(100, 100);
            uiGroupBox3.Name = "uiGroupBox3";
            uiGroupBox3.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox3.Size = new Size(1011, 246);
            uiGroupBox3.TabIndex = 4;
            uiGroupBox3.Text = "uiGroupBox3";
            uiGroupBox3.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 32);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1011, 214);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // plcControlsPreferences1
            // 
            plcControlsPreferences1.Enabled = true;
            plcControlsPreferences1.Interval = 2000;
            plcControlsPreferences1.PLCPreferences.Add(plcPreferences1);
            // 
            // plcPreferences1
            // 
            plcPreferences1.IPEnd = "127.0.0.1";
            plcPreferences1.PLCDevice = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.HMI;
            plcPreferences1.Point = 2000;
            plcPreferences1.Receptionovertime = 1000;
            plcPreferences1.Retain = "S1500";
            plcPreferences1.Sendovertime = 1000;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 533);
            Controls.Add(uiTabControl1);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            uiGroupBox1.ResumeLayout(false);
            uiGroupBox2.ResumeLayout(false);
            uiTabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)daDataViewToPlc1).EndInit();
            tabPage1.ResumeLayout(false);
            uiGroupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private Sunny.UI.UIButton uiButton5;
        private Sunny.UI.UIButton uiButton3;
        private Sunny.UI.UIButton uiButton4;
        private Sunny.UI.UIButton uiButton6;
        private Sunny.UI.UIButton uiButton7;
        private Sunny.UI.UIButton uiButton8;
        private PLC通讯基础控件项目.基础控件.DAuiLabel dAuiLabel1;
        private Sunny.UI.UITextBox uiTextBox2;
        private PLC通讯基础控件项目.基础控件.DAuiLabel dAuiLabel2;
        private Sunny.UI.UILedBulb uiLedBulb1;
        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UITabControl uiTabControl1;
        private TabPage tabPage2;
        private Sunny.UI.UIGroupBox uiGroupBox5;
        private Sunny.UI.UIGroupBox uiGroupBox4;
        private TabPage tabPage1;
        private Sunny.UI.UIGroupBox uiGroupBox3;
        private RichTextBox richTextBox1;
        private PLC通讯基础控件项目.基础控件.DADataViewToPlc daDataViewToPlc1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private PLC通讯基础控件项目.基础控件.DAButton daButton1;
        private PLC通讯基础控件项目.PLCControlsPreferences plcControlsPreferences1;
        private PLC通讯基础控件项目.PLC参数设置控件.PLCPreferences plcPreferences1;
        private PLC通讯基础控件项目.基础控件.DAUiTextBox daUiTextBox1;
        private PLC通讯基础控件项目.基础控件.宏指令控件.DAMacroControl daMacroControl1;
    }
}