
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
            this.uiBattery1 = new Sunny.UI.UIBattery();
            this.daDataViewToPlc1 = new PLC通讯基础控件项目.基础控件.DADataViewToPlc();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.plcControlsPreferences1 = new PLC通讯基础控件项目.PLCControlsPreferences(this.components);
            this.plcPreferences1 = new PLC通讯基础控件项目.PLC参数设置控件.PLCPreferences();
            this.uiBarChart1 = new Sunny.UI.UIBarChart();
            ((System.ComponentModel.ISupportInitialize)(this.daDataViewToPlc1)).BeginInit();
            this.SuspendLayout();
            // 
            // uiBattery1
            // 
            this.uiBattery1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiBattery1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiBattery1.Location = new System.Drawing.Point(203, 145);
            this.uiBattery1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiBattery1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiBattery1.Name = "uiBattery1";
            this.uiBattery1.Size = new System.Drawing.Size(62, 28);
            this.uiBattery1.TabIndex = 1;
            this.uiBattery1.Text = "uiBattery1";
            // 
            // daDataViewToPlc1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.daDataViewToPlc1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.daDataViewToPlc1.APLC = PLC通讯基础控件项目.控件类基.控件数据结构.PLCSet.Set1;
            this.daDataViewToPlc1.BackgroundColor = System.Drawing.Color.White;
            this.daDataViewToPlc1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.daDataViewToPlc1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.daDataViewToPlc1.ColumnHeadersHeight = 32;
            this.daDataViewToPlc1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.daDataViewToPlc1.EnableHeadersVisualStyles = false;
            this.daDataViewToPlc1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.daDataViewToPlc1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.daDataViewToPlc1.Location = new System.Drawing.Point(266, 196);
            this.daDataViewToPlc1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.daDataViewToPlc1.Name = "daDataViewToPlc1";
            this.daDataViewToPlc1.PLC_Enable = true;
            this.daDataViewToPlc1.pLCDataViewselectRealize.BindingName = "uiButton1";
            this.daDataViewToPlc1.pLCDataViewselectRealize.BindingOpen = true;
            this.daDataViewToPlc1.pLCDataViewselectRealize.DataGridView_Name = new string[] {
        "Data"};
            this.daDataViewToPlc1.pLCDataViewselectRealize.DataGridView_numerical = new PLC通讯库.通讯枚举.numerical_format[] {
        PLC通讯库.通讯枚举.numerical_format.Signed_32_Bit};
            this.daDataViewToPlc1.pLCDataViewselectRealize.DataGridViewPLC_Time = false;
            this.daDataViewToPlc1.pLCDataViewselectRealize.PLC_address = new string[] {
        "0"};
            this.daDataViewToPlc1.pLCDataViewselectRealize.ReadCommand = false;
            this.daDataViewToPlc1.pLCDataViewselectRealize.ReadWriteFunction = new string[] {
        "D"};
            this.daDataViewToPlc1.pLCDataViewselectRealize.ReadWritePLC = new PLC通讯基础控件项目.控件类基.控件数据结构.PLC[] {
        PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Modbus_TCP};
            this.daDataViewToPlc1.pLCDataViewselectRealize.SQLCharacter = "Data Source=LAPTOP-INNCV6MO;Initial Catalog=Test;Integrated Security=True";
            this.daDataViewToPlc1.pLCDataViewselectRealize.SQLOpen = true;
            this.daDataViewToPlc1.pLCDataViewselectRealize.SQLServer_SQLinte = true;
            this.daDataViewToPlc1.pLCDataViewselectRealize.SQLsurface = "NAME";
            this.daDataViewToPlc1.pLCDataViewselectRealize.SQLsurfaceType = new string[] {
        "varchar"};
            this.daDataViewToPlc1.ReadCommand = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.daDataViewToPlc1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.daDataViewToPlc1.RowHeadersWidth = 51;
            this.daDataViewToPlc1.RowHeight = 25;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.daDataViewToPlc1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.daDataViewToPlc1.RowTemplate.Height = 25;
            this.daDataViewToPlc1.SelectedIndex = -1;
            this.daDataViewToPlc1.ShowGridLine = true;
            this.daDataViewToPlc1.Size = new System.Drawing.Size(390, 176);
            this.daDataViewToPlc1.TabIndex = 2;
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiButton1.Location = new System.Drawing.Point(501, 66);
            this.uiButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(129, 41);
            this.uiButton1.TabIndex = 3;
            this.uiButton1.Text = "uiButton1";
            // 
            // plcControlsPreferences1
            // 
            this.plcControlsPreferences1.Enabled = true;
            this.plcControlsPreferences1.Interval = 1000;
            this.plcControlsPreferences1.PLCPreferences.Add(this.plcPreferences1);
            // 
            // plcPreferences1
            // 
            this.plcPreferences1.IPEnd = "192.168.231.154";
            this.plcPreferences1.PLCDevice = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Modbus_TCP;
            this.plcPreferences1.Point = 8000;
            this.plcPreferences1.Receptionovertime = 1000;
            this.plcPreferences1.Retain = "S1500";
            this.plcPreferences1.Sendovertime = 1000;
            // 
            // uiBarChart1
            // 
            this.uiBarChart1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.uiBarChart1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiBarChart1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.uiBarChart1.Location = new System.Drawing.Point(314, 51);
            this.uiBarChart1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiBarChart1.Name = "uiBarChart1";
            this.uiBarChart1.Size = new System.Drawing.Size(500, 375);
            this.uiBarChart1.TabIndex = 4;
            this.uiBarChart1.Text = "uiBarChart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 529);
            this.Controls.Add(this.uiBarChart1);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.daDataViewToPlc1);
            this.Controls.Add(this.uiBattery1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.daDataViewToPlc1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIBattery uiBattery1;
        private PLC通讯基础控件项目.基础控件.DADataViewToPlc daDataViewToPlc1;
        private Sunny.UI.UIButton uiButton1;
        private PLC通讯基础控件项目.PLCControlsPreferences plcControlsPreferences1;
        private PLC通讯基础控件项目.PLC参数设置控件.PLCPreferences plcPreferences1;
        private Sunny.UI.UIBarChart uiBarChart1;
    }
}

