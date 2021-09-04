
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.class11 = new PLC通讯基础控件项目.Class1();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "权限管理.png");
            // 
            // class11
            // 
            this.class11.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.class11.backgroundColor_0 = System.Drawing.Color.Empty;
            this.class11.backgroundColor_1 = System.Drawing.Color.Empty;
            this.class11.Location = new System.Drawing.Point(347, 118);
            this.class11.Name = "class11";
            this.class11.PLC_Enable = true;
            this.class11.pLCBitselectRealize.AwaitTime = 0;
            this.class11.pLCBitselectRealize.backgroundColor_0 = System.Drawing.Color.White;
            this.class11.pLCBitselectRealize.backgroundColor_1 = System.Drawing.Color.White;
            this.class11.pLCBitselectRealize.BitPattern = false;
            this.class11.pLCBitselectRealize.description = "PLCBitselectRealize";
            this.class11.pLCBitselectRealize.keyMinTime = 0;
            this.class11.pLCBitselectRealize.LoosenOut = false;
            this.class11.pLCBitselectRealize.NoAccessConceal = false;
            this.class11.pLCBitselectRealize.NoAccessForm = false;
            this.class11.pLCBitselectRealize.OperationAffirm = false;
            this.class11.pLCBitselectRealize.OutReverse = true;
            this.class11.pLCBitselectRealize.Pattern = PLC通讯基础控件项目.控件类基.控件数据结构.Button_pattern.selector_witch;
            this.class11.pLCBitselectRealize.PLCTimer = null;
            this.class11.pLCBitselectRealize.ReadWrite = true;
            this.class11.pLCBitselectRealize.ReadWriteAddress = "10";
            this.class11.pLCBitselectRealize.ReadWriteFunction = "Data_Bit";
            this.class11.pLCBitselectRealize.ReadWritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.HMI;
            this.class11.pLCBitselectRealize.SafetyBehaviorPattern = 0;
            this.class11.pLCBitselectRealize.SafetyCategory = 0;
            this.class11.pLCBitselectRealize.SafetyFunction = "M";
            this.class11.pLCBitselectRealize.SafetyPattern = 0;
            this.class11.pLCBitselectRealize.SafetyPLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.class11.pLCBitselectRealize.Speech = false;
            this.class11.pLCBitselectRealize.Textalign_0 = null;
            this.class11.pLCBitselectRealize.Textalign_1 = null;
            this.class11.pLCBitselectRealize.TextColor_0 = System.Drawing.Color.White;
            this.class11.pLCBitselectRealize.TextColor_1 = System.Drawing.Color.White;
            this.class11.pLCBitselectRealize.TextContent_0 = "0";
            this.class11.pLCBitselectRealize.TextContent_1 = "0";
            this.class11.pLCBitselectRealize.Textflicker_0 = 0;
            this.class11.pLCBitselectRealize.Textflicker_1 = 0;
            this.class11.pLCBitselectRealize.TextFont_0 = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.class11.pLCBitselectRealize.TextFont_1 = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.class11.pLCBitselectRealize.TextItalic_0 = false;
            this.class11.pLCBitselectRealize.TextItalic_1 = false;
            this.class11.pLCBitselectRealize.TextState = 0;
            this.class11.pLCBitselectRealize.TextUnderline_0 = false;
            this.class11.pLCBitselectRealize.TextUnderline_1 = false;
            this.class11.pLCBitselectRealize.WriteAddress = "0";
            this.class11.pLCBitselectRealize.WriteFunction = "Data_Bit";
            this.class11.pLCBitselectRealize.WritePLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Mitsubishi;
            this.class11.pLCBitselectRealize.WrSafetyAddress = "0";
            this.class11.PLCTimer = null;
            this.class11.Size = new System.Drawing.Size(75, 23);
            this.class11.TabIndex = 0;
            this.class11.Text = "class11";
            this.class11.TextColor_0 = System.Drawing.Color.Empty;
            this.class11.TextColor_1 = System.Drawing.Color.Empty;
            this.class11.TextContent_0 = null;
            this.class11.TextContent_1 = null;
            this.class11.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.class11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private Class1 class11;
    }
}