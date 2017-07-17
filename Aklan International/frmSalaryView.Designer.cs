namespace Aklan_International
{
    partial class frmSalaryView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalaryView));
            this.label1 = new System.Windows.Forms.Label();
            this.spnYear = new System.Windows.Forms.NumericUpDown();
            this.spnMonth = new System.Windows.Forms.NumericUpDown();
            this.grdSalary = new System.Windows.Forms.DataGridView();
            this.empID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spnYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Month";
            // 
            // spnYear
            // 
            this.spnYear.CausesValidation = false;
            this.spnYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spnYear.Location = new System.Drawing.Point(129, 29);
            this.spnYear.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.spnYear.Name = "spnYear";
            this.spnYear.Size = new System.Drawing.Size(53, 21);
            this.spnYear.TabIndex = 2;
            this.spnYear.Value = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            // 
            // spnMonth
            // 
            this.spnMonth.CausesValidation = false;
            this.spnMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spnMonth.Location = new System.Drawing.Point(198, 29);
            this.spnMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.spnMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spnMonth.Name = "spnMonth";
            this.spnMonth.Size = new System.Drawing.Size(62, 21);
            this.spnMonth.TabIndex = 3;
            this.spnMonth.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // grdSalary
            // 
            this.grdSalary.AllowUserToAddRows = false;
            this.grdSalary.AllowUserToDeleteRows = false;
            this.grdSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdSalary.BackgroundColor = System.Drawing.Color.White;
            this.grdSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSalary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empID,
            this.name,
            this.accNo,
            this.telNo,
            this.salary});
            this.grdSalary.Location = new System.Drawing.Point(18, 74);
            this.grdSalary.Name = "grdSalary";
            this.grdSalary.Size = new System.Drawing.Size(586, 268);
            this.grdSalary.TabIndex = 4;
            // 
            // empID
            // 
            this.empID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.empID.HeaderText = "Worker ID";
            this.empID.Name = "empID";
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // accNo
            // 
            this.accNo.HeaderText = "Account No";
            this.accNo.Name = "accNo";
            // 
            // telNo
            // 
            this.telNo.HeaderText = "Telephone No";
            this.telNo.Name = "telNo";
            // 
            // salary
            // 
            this.salary.HeaderText = "Salary";
            this.salary.Name = "salary";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(529, 25);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 30);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "View";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmSalaryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aklan_International.Properties.Resources.Admin_Window_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(624, 361);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.grdSalary);
            this.Controls.Add(this.spnMonth);
            this.Controls.Add(this.spnYear);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmSalaryView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Payroll";
            this.Load += new System.EventHandler(this.frmSalaryView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spnYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown spnYear;
        private System.Windows.Forms.NumericUpDown spnMonth;
        private System.Windows.Forms.DataGridView grdSalary;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn empID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn accNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn telNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary;
    }
}