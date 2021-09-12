
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
            this.uiTextBox1 = new Sunny.UI.UITextBox();
            this.daButton2 = new PLC通讯基础控件项目.基础控件.DAButton();
            this.daTextBox1 = new PLC通讯基础控件项目.基础控件.DATextBox();
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
            this.daButton1.pLCBitselectRealize.AwaitTime = 500;
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
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiButton1.Location = new System.Drawing.Point(372, 72);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(100, 35);
            this.uiButton1.TabIndex = 2;
            this.uiButton1.Text = "uiButton1";
            // 
            // uiTextBox1
            // 
            this.uiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox1.FillColor = System.Drawing.Color.White;
            this.uiTextBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiTextBox1.Location = new System.Drawing.Point(421, 291);
            this.uiTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox1.Maximum = 2147483647D;
            this.uiTextBox1.Minimum = -2147483648D;
            this.uiTextBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.Size = new System.Drawing.Size(150, 29);
            this.uiTextBox1.TabIndex = 3;
            this.uiTextBox1.Text = "uiTextBox1";
            this.uiTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // daButton2
            // 
            this.daButton2.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.daButton2.BackColor = System.Drawing.Color.White;
            this.daButton2.backgroundColor_0 = System.Drawing.Color.White;
            this.daButton2.backgroundColor_1 = System.Drawing.Color.White;
            this.daButton2.ForeColor = System.Drawing.Color.White;
            this.daButton2.Location = new System.Drawing.Point(96, 224);
            this.daButton2.Name = "daButton2";
            this.daButton2.PLC_Enable = true;
            this.daButton2.pLCBitselectRealize.AwaitTime = 0;
            this.daButton2.pLCBitselectRealize.backgroundColor_0 = System.Drawing.Color.White;
            this.daButton2.pLCBitselectRealize.backgroundColor_1 = System.Drawing.Color.White;
            this.daButton2.pLCBitselectRealize.BitPattern = false;
            this.daButton2.pLCBitselectRealize.description = "PLCBitselectRealize";
            this.daButton2.pLCBitselectRealize.keyMinTime = 0;
            this.daButton2.pLCBitselectRealize.LoosenOut = false;
            this.daButton2.pLCBitselectRealize.NoAccessConceal = false;
            this.daButton2.pLCBitselectRealize.NoAccessForm = false;
            this.daButton2.pLCBitselectRealize.OperationAffirm = false;
            this.daButton2.pLCBitselectRealize.OutReverse = false;
            this.daButton2.pLCBitselectRealize.Pattern = PLC通讯基础控件项目.控件类基.控件数据结构.Button_pattern.selector_witch;
            this.daButton2.pLCBitselectRealize.PLCTimer = null;
            this.daButton2.pLCBitselectRealize.ReadWrite = false;
            this.daButton2.pLCBitselectRealize.ReadWriteAddress = "2";
            this.daButton2.pLCBitselectRealize.ReadWriteFunction = "Y";
            this.daButton2.pLCBitselectRealize.ReadWritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daButton2.pLCBitselectRealize.SafetyBehaviorPattern = 0;
            this.daButton2.pLCBitselectRealize.SafetyCategory = 0;
            this.daButton2.pLCBitselectRealize.SafetyFunction = "M";
            this.daButton2.pLCBitselectRealize.SafetyPattern = 0;
            this.daButton2.pLCBitselectRealize.SafetyPLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daButton2.pLCBitselectRealize.Speech = false;
            this.daButton2.pLCBitselectRealize.Textalign_0 = "TopLeft";
            this.daButton2.pLCBitselectRealize.Textalign_1 = "TopLeft";
            this.daButton2.pLCBitselectRealize.TextColor_0 = System.Drawing.Color.White;
            this.daButton2.pLCBitselectRealize.TextColor_1 = System.Drawing.Color.White;
            this.daButton2.pLCBitselectRealize.TextContent_0 = "0";
            this.daButton2.pLCBitselectRealize.TextContent_1 = "0";
            this.daButton2.pLCBitselectRealize.Textflicker_0 = 0;
            this.daButton2.pLCBitselectRealize.Textflicker_1 = 0;
            this.daButton2.pLCBitselectRealize.TextFont_0 = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.daButton2.pLCBitselectRealize.TextFont_1 = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.daButton2.pLCBitselectRealize.TextItalic_0 = false;
            this.daButton2.pLCBitselectRealize.TextItalic_1 = false;
            this.daButton2.pLCBitselectRealize.TextState = 0;
            this.daButton2.pLCBitselectRealize.TextUnderline_0 = false;
            this.daButton2.pLCBitselectRealize.TextUnderline_1 = false;
            this.daButton2.pLCBitselectRealize.WriteAddress = "0";
            this.daButton2.pLCBitselectRealize.WriteFunction = "M";
            this.daButton2.pLCBitselectRealize.WritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daButton2.pLCBitselectRealize.WrSafetyAddress = "0";
            this.daButton2.Size = new System.Drawing.Size(75, 23);
            this.daButton2.TabIndex = 4;
            this.daButton2.Text = "0";
            this.daButton2.TextColor_0 = System.Drawing.Color.White;
            this.daButton2.TextColor_1 = System.Drawing.Color.White;
            this.daButton2.TextContent_0 = "0";
            this.daButton2.TextContent_1 = "0";
            this.daButton2.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 450);
            this.Controls.Add(this.daTextBox1);
            this.Controls.Add(this.daButton2);
            this.Controls.Add(this.uiTextBox1);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.daButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private Sunny.UI.UITextBox uiTextBox1;
        private 基础控件.DAButton daButton2;
        private 基础控件.DATextBox daTextBox1;
    }
}