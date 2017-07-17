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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRequestJob));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnRequest = new System.Windows.Forms.Button();
            this.spnQty = new System.Windows.Forms.NumericUpDown();
            this.cmbJob = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbxJobs = new System.Windows.Forms.ListBox();
            this.lblWorkerName = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
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
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(540, 299);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnRequest);
            this.tabPage1.Controls.Add(this.spnQty);
            this.tabPage1.Controls.Add(this.cmbJob);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(532, 270);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Request Job";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRequest
            // 
            this.btnRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRequest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRequest.BackgroundImage")));
            this.btnRequest.Enabled = false;
            this.btnRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequest.Location = new System.Drawing.Point(6, 215);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(110, 50);
            this.btnRequest.TabIndex = 4;
            this.btnRequest.Text = "Request";
            this.btnRequest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRequest.UseVisualStyleBackColor = false;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // spnQty
            // 
            this.spnQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spnQty.Location = new System.Drawing.Point(258, 119);
            this.spnQty.Name = "spnQty";
            this.spnQty.Size = new System.Drawing.Size(195, 29);
            this.spnQty.TabIndex = 3;
            this.spnQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.spnQty.ValueChanged += new System.EventHandler(this.spnQty_ValueChanged);
            // 
            // cmbJob
            // 
            this.cmbJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbJob.FormattingEnabled = true;
            this.cmbJob.Items.AddRange(new object[] {
            "cutting",
            "clip cutting",
            "folding 12",
            "folding single",
            "rimming 12",
            "rimming single"});
            this.cmbJob.Location = new System.Drawing.Point(258, 50);
            this.cmbJob.Name = "cmbJob";
            this.cmbJob.Size = new System.Drawing.Size(195, 32);
            this.cmbJob.TabIndex = 2;
            this.cmbJob.SelectedIndexChanged += new System.EventHandler(this.cmbMachineType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Qty";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Job";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbxJobs);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(532, 270);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Current Jobs";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbxJobs
            // 
            this.lbxJobs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxJobs.FormattingEnabled = true;
            this.lbxJobs.ItemHeight = 16;
            this.lbxJobs.Location = new System.Drawing.Point(3, 3);
            this.lbxJobs.Name = "lbxJobs";
            this.lbxJobs.Size = new System.Drawing.Size(526, 264);
            this.lbxJobs.TabIndex = 0;
            // 
            // lblWorkerName
            // 
            this.lblWorkerName.AutoSize = true;
            this.lblWorkerName.BackColor = System.Drawing.Color.White;
            this.lblWorkerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkerName.Location = new System.Drawing.Point(12, 9);
            this.lblWorkerName.Name = "lblWorkerName";
            this.lblWorkerName.Size = new System.Drawing.Size(70, 25);
            this.lblWorkerName.TabIndex = 1;
            this.lblWorkerName.Text = "label3";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(448, 359);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 50);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmRequestJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aklan_International.Properties.Resources.Admin_Window_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(564, 421);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblWorkerName);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRequestJob";
            this.Text = "Request Job";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRequestJob_FormClosing);
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
        private System.Windows.Forms.ComboBox cmbJob;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lbxJobs;
        private System.Windows.Forms.Label lblWorkerName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRequest;
    }
}