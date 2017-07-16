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
            this.grdReport = new System.Windows.Forms.DataGridView();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.empID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.worker_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acc_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdReport)).BeginInit();
            this.SuspendLayout();
            // 
            // grdReport
            // 
            this.grdReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empID,
            this.first_name,
            this.address,
            this.tel_NO,
            this.worker_type,
            this.acc_NO});
            this.grdReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.grdReport.Location = new System.Drawing.Point(0, 0);
            this.grdReport.Name = "grdReport";
            this.grdReport.Size = new System.Drawing.Size(641, 150);
            this.grdReport.TabIndex = 0;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(480, 183);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(140, 43);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Save and Open with Excel\r\n";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
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
            // 
            // address
            // 
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
            // frmWorkerReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 261);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.grdReport);
            this.Name = "frmWorkerReport";
            this.Text = "Worker Report";
            this.Load += new System.EventHandler(this.frmWorkerReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdReport)).EndInit();
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
    }
}