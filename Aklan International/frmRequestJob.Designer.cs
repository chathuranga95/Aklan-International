namespace Aklan_International
{
    partial class frmRequestJob
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnRequest = new System.Windows.Forms.Button();
            this.spnQty = new System.Windows.Forms.NumericUpDown();
            this.cmbMachineType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbxJobs = new System.Windows.Forms.ListBox();
            this.lblWorkerName = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.cmbSingleOr12 = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnQty)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(25, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(485, 290);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmbSingleOr12);
            this.tabPage1.Controls.Add(this.btnRequest);
            this.tabPage1.Controls.Add(this.spnQty);
            this.tabPage1.Controls.Add(this.cmbMachineType);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(477, 264);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Request Job";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRequest
            // 
            this.btnRequest.Location = new System.Drawing.Point(360, 205);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(75, 23);
            this.btnRequest.TabIndex = 4;
            this.btnRequest.Text = "Request";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // spnQty
            // 
            this.spnQty.Location = new System.Drawing.Point(145, 87);
            this.spnQty.Name = "spnQty";
            this.spnQty.Size = new System.Drawing.Size(120, 20);
            this.spnQty.TabIndex = 3;
            // 
            // cmbMachineType
            // 
            this.cmbMachineType.FormattingEnabled = true;
            this.cmbMachineType.Items.AddRange(new object[] {
            "Cutting",
            "Clip Cutting",
            "Folding",
            "Rimming"});
            this.cmbMachineType.Location = new System.Drawing.Point(145, 44);
            this.cmbMachineType.Name = "cmbMachineType";
            this.cmbMachineType.Size = new System.Drawing.Size(121, 21);
            this.cmbMachineType.TabIndex = 2;
            this.cmbMachineType.SelectedIndexChanged += new System.EventHandler(this.cmbMachineType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Qty";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Machine Type";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbxJobs);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(477, 264);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Current Jobs";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbxJobs
            // 
            this.lbxJobs.FormattingEnabled = true;
            this.lbxJobs.Location = new System.Drawing.Point(15, 19);
            this.lbxJobs.Name = "lbxJobs";
            this.lbxJobs.Size = new System.Drawing.Size(417, 225);
            this.lbxJobs.TabIndex = 0;
            // 
            // lblWorkerName
            // 
            this.lblWorkerName.AutoSize = true;
            this.lblWorkerName.Location = new System.Drawing.Point(161, 13);
            this.lblWorkerName.Name = "lblWorkerName";
            this.lblWorkerName.Size = new System.Drawing.Size(35, 13);
            this.lblWorkerName.TabIndex = 1;
            this.lblWorkerName.Text = "label3";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(444, 332);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cmbSingleOr12
            // 
            this.cmbSingleOr12.FormattingEnabled = true;
            this.cmbSingleOr12.Items.AddRange(new object[] {
            "Single",
            "12"});
            this.cmbSingleOr12.Location = new System.Drawing.Point(320, 43);
            this.cmbSingleOr12.Name = "cmbSingleOr12";
            this.cmbSingleOr12.Size = new System.Drawing.Size(121, 21);
            this.cmbSingleOr12.TabIndex = 5;
            this.cmbSingleOr12.Visible = false;
            // 
            // frmRequestJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 367);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblWorkerName);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmRequestJob";
            this.Text = "Request Job";
            this.Load += new System.EventHandler(this.frmRequestJob_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnQty)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.NumericUpDown spnQty;
        private System.Windows.Forms.ComboBox cmbMachineType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lbxJobs;
        private System.Windows.Forms.Label lblWorkerName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.ComboBox cmbSingleOr12;
    }
}