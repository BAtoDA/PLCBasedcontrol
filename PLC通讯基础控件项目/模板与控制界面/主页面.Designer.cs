
namespace PLC通讯基础控件项目.模板与控制界面
{
    partial class 主页面
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
            this.uiGroupBox2 = new Sunny.UI.UIGroupBox();
            this.daUiButton1 = new PLC通讯基础控件项目.基础控件.DAUiButton();
            this.daUiTextBox1 = new PLC通讯基础控件项目.基础控件.DAUiTextBox();
            this.uiPanel1.SuspendLayout();
            this.uiGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.daUiTextBox1);
            this.uiPanel1.Controls.Add(this.uiGroupBox2);
            this.uiPanel1.Size = new System.Drawing.Size(896, 520);
            this.uiPanel1.Controls.SetChildIndex(this.daPlcFunction2, 0);
            this.uiPanel1.Controls.SetChildIndex(this.daPlcFunction1, 0);
            this.uiPanel1.Controls.SetChildIndex(this.daPlcFunction3, 0);
            this.uiPanel1.Controls.SetChildIndex(this.daPlcFunction4, 0);
            this.uiPanel1.Controls.SetChildIndex(this.daPlcFunction5, 0);
            this.uiPanel1.Controls.SetChildIndex(this.uiGroupBox2, 0);
            this.uiPanel1.Controls.SetChildIndex(this.daUiTextBox1, 0);
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Controls.Add(this.daUiButton1);
            this.uiGroupBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiGroupBox2.Location = new System.Drawing.Point(10, 5);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox2.Size = new System.Drawing.Size(342, 205);
            this.uiGroupBox2.TabIndex = 2;
            this.uiGroupBox2.Text = "一区监控";
            this.uiGroupBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiGroupBox2.TitleAlignment = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.daUiButton1.Location = new System.Drawing.Point(15, 35);
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
            this.daUiButton1.pLCBitselectRealize.ReadWrite = true;
            this.daUiButton1.pLCBitselectRealize.ReadWriteAddress = "0.0";
            this.daUiButton1.pLCBitselectRealize.ReadWriteFunction = "Q";
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
            this.daUiButton1.pLCBitselectRealize.TextContent_0 = "   ROB1\n原点回归";
            this.daUiButton1.pLCBitselectRealize.TextContent_1 = "   ROB1\n原点回归";
            this.daUiButton1.pLCBitselectRealize.Textflicker_0 = 0;
            this.daUiButton1.pLCBitselectRealize.Textflicker_1 = 0;
            this.daUiButton1.pLCBitselectRealize.TextFont_0 = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiButton1.pLCBitselectRealize.TextFont_1 = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiButton1.pLCBitselectRealize.TextItalic_0 = false;
            this.daUiButton1.pLCBitselectRealize.TextItalic_1 = false;
            this.daUiButton1.pLCBitselectRealize.TextState = 0;
            this.daUiButton1.pLCBitselectRealize.TextUnderline_0 = false;
            this.daUiButton1.pLCBitselectRealize.TextUnderline_1 = false;
            this.daUiButton1.pLCBitselectRealize.WriteAddress = "0.0";
            this.daUiButton1.pLCBitselectRealize.WriteFunction = "M";
            this.daUiButton1.pLCBitselectRealize.WritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Siemens;
            this.daUiButton1.pLCBitselectRealize.WrSafetyAddress = "0";
            this.daUiButton1.Size = new System.Drawing.Size(103, 47);
            this.daUiButton1.TabIndex = 0;
            this.daUiButton1.Text = "   ROB1\n原点回归";
            this.daUiButton1.Textalign_0 = "MiddleCenter";
            this.daUiButton1.Textalign_1 = "MiddleCenter";
            this.daUiButton1.TextColor_0 = System.Drawing.Color.White;
            this.daUiButton1.TextColor_1 = System.Drawing.Color.White;
            this.daUiButton1.TextContent_0 = "   ROB1\n原点回归";
            this.daUiButton1.TextContent_1 = "   ROB1\n原点回归";
            this.daUiButton1.TextFont_0 = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiButton1.TextFont_1 = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // daUiTextBox1
            // 
            this.daUiTextBox1.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.daUiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.daUiTextBox1.FillColor = System.Drawing.Color.White;
            this.daUiTextBox1.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiTextBox1.Location = new System.Drawing.Point(434, 113);
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
            this.daUiTextBox1.pLCDselectRealize.ReadWriteAddress = "0";
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
            this.daUiTextBox1.pLCDselectRealize.TextContent_0 = null;
            this.daUiTextBox1.pLCDselectRealize.TextContent_1 = null;
            this.daUiTextBox1.pLCDselectRealize.Textflicker_0 = 0;
            this.daUiTextBox1.pLCDselectRealize.Textflicker_1 = 0;
            this.daUiTextBox1.pLCDselectRealize.TextFont_0 = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiTextBox1.pLCDselectRealize.TextFont_1 = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiTextBox1.pLCDselectRealize.TextItalic_0 = false;
            this.daUiTextBox1.pLCDselectRealize.TextItalic_1 = false;
            this.daUiTextBox1.pLCDselectRealize.TextUnderline_0 = false;
            this.daUiTextBox1.pLCDselectRealize.TextUnderline_1 = false;
            this.daUiTextBox1.pLCDselectRealize.WriteAddress = "0";
            this.daUiTextBox1.pLCDselectRealize.WriteFunction = "D";
            this.daUiTextBox1.pLCDselectRealize.WritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.daUiTextBox1.pLCDselectRealize.WrSafetyAddress = "0";
            this.daUiTextBox1.PLCTimer = null;
            this.daUiTextBox1.Size = new System.Drawing.Size(150, 29);
            this.daUiTextBox1.TabIndex = 5;
            this.daUiTextBox1.Textalign_0 = "BottomCenter";
            this.daUiTextBox1.Textalign_1 = "BottomCenter";
            this.daUiTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.daUiTextBox1.TextColor_0 = System.Drawing.Color.Black;
            this.daUiTextBox1.TextColor_1 = System.Drawing.Color.Black;
            this.daUiTextBox1.TextContent_0 = null;
            this.daUiTextBox1.TextContent_1 = null;
            this.daUiTextBox1.TextFont_0 = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daUiTextBox1.TextFont_1 = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // 主页面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 552);
            this.Name = "主页面";
            this.Text = "主页面";
            this.uiPanel1.ResumeLayout(false);
            this.uiGroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIGroupBox uiGroupBox2;
        private 基础控件.DAUiButton daUiButton1;
        private 基础控件.DAUiTextBox daUiTextBox1;
    }
}