namespace DoAn_31211027580
{
    partial class fAdmin
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.uSPBillReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quan_Ly_Ban_HangDataSet = new DoAn_31211027580.Quan_Ly_Ban_HangDataSet();
            this.tDoanhThu = new System.Windows.Forms.TabPage();
            this.btAll = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.dataGridDThu = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tBill = new System.Windows.Forms.TabControl();
            this.tpageReport = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.uSP_BillReportTableAdapter = new DoAn_31211027580.Quan_Ly_Ban_HangDataSetTableAdapters.USP_BillReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.uSPBillReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quan_Ly_Ban_HangDataSet)).BeginInit();
            this.tDoanhThu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDThu)).BeginInit();
            this.tBill.SuspendLayout();
            this.tpageReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // uSPBillReportBindingSource
            // 
            this.uSPBillReportBindingSource.DataMember = "USP_BillReport";
            this.uSPBillReportBindingSource.DataSource = this.quan_Ly_Ban_HangDataSet;
            // 
            // quan_Ly_Ban_HangDataSet
            // 
            this.quan_Ly_Ban_HangDataSet.DataSetName = "Quan_Ly_Ban_HangDataSet";
            this.quan_Ly_Ban_HangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tDoanhThu
            // 
            this.tDoanhThu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tDoanhThu.Controls.Add(this.btAll);
            this.tDoanhThu.Controls.Add(this.lblTotal);
            this.tDoanhThu.Controls.Add(this.lblTotalValue);
            this.tDoanhThu.Controls.Add(this.dataGridDThu);
            this.tDoanhThu.Controls.Add(this.dateTimePicker1);
            this.tDoanhThu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tDoanhThu.Location = new System.Drawing.Point(4, 29);
            this.tDoanhThu.Margin = new System.Windows.Forms.Padding(0);
            this.tDoanhThu.Name = "tDoanhThu";
            this.tDoanhThu.Size = new System.Drawing.Size(1072, 527);
            this.tDoanhThu.TabIndex = 0;
            this.tDoanhThu.Text = "Doanh Thu";
            // 
            // btAll
            // 
            this.btAll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btAll.Location = new System.Drawing.Point(465, 17);
            this.btAll.Name = "btAll";
            this.btAll.Size = new System.Drawing.Size(113, 31);
            this.btAll.TabIndex = 6;
            this.btAll.Text = "Tất cả";
            this.btAll.UseVisualStyleBackColor = true;
            this.btAll.Click += new System.EventHandler(this.btAll_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(619, 22);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(157, 22);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Tổng doanh thu:";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalValue.Location = new System.Drawing.Point(754, 22);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(298, 39);
            this.lblTotalValue.TabIndex = 4;
            this.lblTotalValue.Text = "0";
            this.lblTotalValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridDThu
            // 
            this.dataGridDThu.AllowUserToAddRows = false;
            this.dataGridDThu.AllowUserToDeleteRows = false;
            this.dataGridDThu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridDThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridDThu.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridDThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDThu.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridDThu.Location = new System.Drawing.Point(-4, 64);
            this.dataGridDThu.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridDThu.MultiSelect = false;
            this.dataGridDThu.Name = "dataGridDThu";
            this.dataGridDThu.ReadOnly = true;
            this.dataGridDThu.RowHeadersWidth = 51;
            this.dataGridDThu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridDThu.Size = new System.Drawing.Size(1080, 467);
            this.dataGridDThu.TabIndex = 3;
            this.dataGridDThu.DataSourceChanged += new System.EventHandler(this.dataGridDThu_DataSourceChanged);
            this.dataGridDThu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDThu_CellClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.dateTimePicker1.Location = new System.Drawing.Point(17, 17);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(332, 26);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // tBill
            // 
            this.tBill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBill.Controls.Add(this.tDoanhThu);
            this.tBill.Controls.Add(this.tpageReport);
            this.tBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tBill.Location = new System.Drawing.Point(-7, -2);
            this.tBill.Margin = new System.Windows.Forms.Padding(0);
            this.tBill.Multiline = true;
            this.tBill.Name = "tBill";
            this.tBill.SelectedIndex = 0;
            this.tBill.Size = new System.Drawing.Size(1080, 560);
            this.tBill.TabIndex = 0;
            // 
            // tpageReport
            // 
            this.tpageReport.Controls.Add(this.reportViewer1);
            this.tpageReport.Location = new System.Drawing.Point(4, 29);
            this.tpageReport.Name = "tpageReport";
            this.tpageReport.Padding = new System.Windows.Forms.Padding(3);
            this.tpageReport.Size = new System.Drawing.Size(1072, 527);
            this.tpageReport.TabIndex = 1;
            this.tpageReport.Text = "Báo cáo";
            this.tpageReport.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSize = true;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.uSPBillReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DoAn_31211027580.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1066, 521);
            this.reportViewer1.TabIndex = 0;
            // 
            // uSP_BillReportTableAdapter
            // 
            this.uSP_BillReportTableAdapter.ClearBeforeFill = true;
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tBill);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fAdmin";
            this.ShowIcon = false;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.fAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uSPBillReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quan_Ly_Ban_HangDataSet)).EndInit();
            this.tDoanhThu.ResumeLayout(false);
            this.tDoanhThu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDThu)).EndInit();
            this.tBill.ResumeLayout(false);
            this.tpageReport.ResumeLayout(false);
            this.tpageReport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tDoanhThu;
        private System.Windows.Forms.Button btAll;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.DataGridView dataGridDThu;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TabControl tBill;
        private System.Windows.Forms.TabPage tpageReport;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Quan_Ly_Ban_HangDataSet quan_Ly_Ban_HangDataSet;
        private System.Windows.Forms.BindingSource uSPBillReportBindingSource;
        private Quan_Ly_Ban_HangDataSetTableAdapters.USP_BillReportTableAdapter uSP_BillReportTableAdapter;
    }
}