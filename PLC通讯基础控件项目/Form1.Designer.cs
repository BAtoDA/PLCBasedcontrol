
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
            this.plcPreferences1.IPEnd = "127.0.0.1";
            this.plcPreferences1.PLCDevice = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.plcPreferences1.Point = 2000;
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
            this.plcPreferences3.IPEnd = "192.168.234.154";
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
            this.daButton1.Location = new System.Drawing.Point(269, 166);
            this.daButton1.Name = "daButton1";
            this.daButton1.PLC_Enable = true;
            this.daButton1.pLCBitselectRealize.AwaitTime = 0;
            this.daButton1.pLCBitselectRealize.backgroundColor_0 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.daButton1.pLCBitselectRealize.backgroundColor_1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.daButton1.pLCBitselectRealize.ReadWriteFunction = "Y";
            this.daButton1.pLCBitselectRealize.ReadWritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Modbus_TCP;
            this.daButton1.pLCBitselectRealize.SafetyBehaviorPattern = 0;
            this.daButton1.pLCBitselectRealize.SafetyCategory = 0;
            this.daButton1.pLCBitselectRealize.SafetyFunction = "M";
            this.daButton1.pLCBitselectRealize.SafetyPattern = 0;
            this.daButton1.pLCBitselectRealize.SafetyPLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daButton1.pLCBitselectRealize.Speech = false;
            this.daButton1.pLCBitselectRealize.Textalign_0 = "TopLeft";
            this.daButton1.pLCBitselectRealize.Textalign_1 = "TopLeft";
            this.daButton1.pLCBitselectRealize.TextColor_0 = System.Drawing.Color.White;
            this.daButton1.pLCBitselectRealize.TextColor_1 = System.Drawing.Color.White;
            this.daButton1.pLCBitselectRealize.TextContent_0 = "OFF";
            this.daButton1.pLCBitselectRealize.TextContent_1 = "ON";
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
            this.daButton1.pLCBitselectRealize.WrSafetyAddress = "0";
            this.daButton1.PLCTimer = null;
            this.daButton1.Size = new System.Drawing.Size(75, 23);
            this.daButton1.TabIndex = 0;
            this.daButton1.Text = "0";
            this.daButton1.TextColor_0 = System.Drawing.Color.White;
            this.daButton1.TextColor_1 = System.Drawing.Color.White;
            this.daButton1.TextContent_0 = "OFF";
            this.daButton1.TextContent_1 = "ON";
            this.daButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 450);
            this.Controls.Add(this.daButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private PLCControlsPreferences plcControlsPreferences1;
        private PLC参数设置控件.PLCPreferences plcPreferences1;
        private PLC参数设置控件.PLCPreferences plcPreferences2;
        private PLC参数设置控件.PLCPreferences plcPreferences3;
        private 基础控件.DAButton daButton1;
    }
}