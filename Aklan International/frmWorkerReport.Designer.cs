namespace Aklan_International
{
    partial class frmWorkerReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdReport = new System.Windows.Forms.DataGridView();
            this.empID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.worker_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acc_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.panelWorkReport = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.grdReport)).BeginInit();
            this.panelWorkReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdReport
            // 
            this.grdReport.AllowUserToAddRows = false;
            this.grdReport.AllowUserToDeleteRows = false;
            this.grdReport.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empID,
            this.first_name,
            this.address,
            this.tel_NO,
            this.worker_type,
            this.acc_NO});
            this.grdReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdReport.Location = new System.Drawing.Point(0, 0);
            this.grdReport.Name = "grdReport";
            this.grdReport.ReadOnly = true;
            this.grdReport.Size = new System.Drawing.Size(1019, 216);
            this.grdReport.TabIndex = 0;
            // 
            // empID
            // 
            this.empID.HeaderText = "Emp ID";
            this.empID.Name = "empID";
            this.empID.ReadOnly = true;
            // 
            // first_name
            // 
            this.first_name.HeaderText = "First Name";
            this.first_name.Name = "first_name";
            this.first_name.ReadOnly = true;
            this.first_name.Width = 200;
            // 
            // address
            // 
            this.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // tel_NO
            // 
            this.tel_NO.HeaderText = "Tel";
            this.tel_NO.Name = "tel_NO";
            this.tel_NO.ReadOnly = true;
            // 
            // worker_type
            // 
            this.worker_type.HeaderText = "Type";
            this.worker_type.Name = "worker_type";
            this.worker_type.ReadOnly = true;
            // 
            // acc_NO
            // 
            this.acc_NO.HeaderText = "ACC. NO";
            this.acc_NO.Name = "acc_NO";
            this.acc_NO.ReadOnly = true;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.BackColor = System.Drawing.Color.White;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(891, 234);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(140, 43);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Save and Open with Excel\r\n";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // panelWorkReport
            // 
            this.panelWorkReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelWorkReport.Controls.Add(this.grdReport);
            this.panelWorkReport.Location = new System.Drawing.Point(12, 12);
            this.panelWorkReport.Name = "panelWorkReport";
            this.panelWorkReport.Size = new System.Drawing.Size(1019, 216);
            this.panelWorkReport.TabIndex = 2;
            // 
            // frmWorkerReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aklan_International.Properties.Resources.Admin_Window_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1043, 289);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.panelWorkReport);
            this.DoubleBuffered = true;
            this.MinimizeBox = false;
            this.Name = "frmWorkerReport";
            this.Text = "Worker Report";
            this.Load += new System.EventHandler(this.frmWorkerReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdReport)).EndInit();
            this.panelWorkReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdReport;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.DataGridViewTextBoxColumn empID;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn worker_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn acc_NO;
        private System.Windows.Forms.Panel panelWorkReport;
    }
}