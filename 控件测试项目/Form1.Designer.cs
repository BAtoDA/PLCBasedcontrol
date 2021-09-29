
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
            this.daDataViewToPlc1 = new PLC通讯基础控件项目.基础控件.DADataViewToPlc();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.plcControlsPreferences1 = new PLC通讯基础控件项目.PLCControlsPreferences(this.components);
            this.plcPreferences1 = new PLC通讯基础控件项目.PLC参数设置控件.PLCPreferences();
            this.dAuiBarChart2 = new PLC通讯基础控件项目.基础控件.DAuiBarChart();
            this.uiButton2 = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.daDataViewToPlc1)).BeginInit();
            this.SuspendLayout();
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
            this.daDataViewToPlc1.Location = new System.Drawing.Point(45, 288);
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
            this.daDataViewToPlc1.Size = new System.Drawing.Size(303, 150);
            this.daDataViewToPlc1.TabIndex = 2;
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiButton1.Location = new System.Drawing.Point(135, 159);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(100, 35);
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
            this.plcPreferences1.IPEnd = "192.168.2.120";
            this.plcPreferences1.PLCDevice = PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Modbus_TCP;
            this.plcPreferences1.Point = 8000;
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
            this.dAuiBarChart2.Location = new System.Drawing.Point(400, 119);
            this.dAuiBarChart2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dAuiBarChart2.MinimumSize = new System.Drawing.Size(1, 1);
            this.dAuiBarChart2.Name = "dAuiBarChart2";
            this.dAuiBarChart2.PLC_Enable = true;
            this.dAuiBarChart2.pLCDataViewselectRealize.BindingName = "uiButton2";
            this.dAuiBarChart2.pLCDataViewselectRealize.BindingOpen = true;
            this.dAuiBarChart2.pLCDataViewselectRealize.DataGridView_Name = new string[] {
        "Valeu1"};
            this.dAuiBarChart2.pLCDataViewselectRealize.DataGridView_numerical = new PLC通讯库.通讯枚举.numerical_format[] {
        PLC通讯库.通讯枚举.numerical_format.Signed_16_Bit};
            this.dAuiBarChart2.pLCDataViewselectRealize.DataGridViewPLC_Time = false;
            this.dAuiBarChart2.pLCDataViewselectRealize.PLC_address = new string[] {
        "0"};
            this.dAuiBarChart2.pLCDataViewselectRealize.ReadCommand = false;
            this.dAuiBarChart2.pLCDataViewselectRealize.ReadWriteFunction = new string[] {
        "D"};
            this.dAuiBarChart2.pLCDataViewselectRealize.ReadWritePLC = new PLC通讯基础控件项目.控件类基.控件数据结构.PLC[] {
        PLC通讯基础控件项目.控件类基.控件数据结构.PLC.Modbus_TCP};
            this.dAuiBarChart2.pLCDataViewselectRealize.SQLCharacter = "uiTextBox2";
            this.dAuiBarChart2.pLCDataViewselectRealize.SQLOpen = false;
            this.dAuiBarChart2.pLCDataViewselectRealize.SQLServer_SQLinte = false;
            this.dAuiBarChart2.pLCDataViewselectRealize.SQLsurface = "";
            this.dAuiBarChart2.pLCDataViewselectRealize.SQLsurfaceType = new string[] {
        "varchar"};
            this.dAuiBarChart2.ReadCommand = false;
            this.dAuiBarChart2.Size = new System.Drawing.Size(389, 319);
            this.dAuiBarChart2.TabIndex = 4;
            this.dAuiBarChart2.Text = "dAuiBarChart2";
            this.dAuiBarChart2.XAxisName = "标题";
            this.dAuiBarChart2.YAxisName = "标题";
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uiButton2.Location = new System.Drawing.Point(547, 29);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Size = new System.Drawing.Size(100, 35);
            this.uiButton2.TabIndex = 5;
            this.uiButton2.Text = "uiButton2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uiButton2);
            this.Controls.Add(this.dAuiBarChart2);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.daDataViewToPlc1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.daDataViewToPlc1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PLC通讯基础控件项目.基础控件.DADataViewToPlc daDataViewToPlc1;
        private Sunny.UI.UIButton uiButton1;
        private PLC通讯基础控件项目.PLCControlsPreferences plcControlsPreferences1;
        private PLC通讯基础控件项目.PLC参数设置控件.PLCPreferences plcPreferences1;
        private PLC通讯基础控件项目.基础控件.DAuiBarChart dAuiBarChart1;
        private PLC通讯基础控件项目.基础控件.DAuiBarChart dAuiBarChart2;
        private Sunny.UI.UIButton uiButton2;
    }
}

