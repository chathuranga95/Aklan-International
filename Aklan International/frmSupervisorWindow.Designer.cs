namespace Aklan_International
{
    partial class frmSupervisorWindow
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMark = new System.Windows.Forms.Button();
            this.lbxCurrentJobs = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMark);
            this.groupBox1.Controls.Add(this.lbxCurrentJobs);
            this.groupBox1.Location = new System.Drawing.Point(29, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(728, 326);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current jobs";
            // 
            // btnMark
            // 
            this.btnMark.Location = new System.Drawing.Point(606, 282);
            this.btnMark.Name = "btnMark";
            this.btnMark.Size = new System.Drawing.Size(86, 38);
            this.btnMark.TabIndex = 1;
            this.btnMark.Text = "Mark as Finished";
            this.btnMark.UseVisualStyleBackColor = true;
            this.btnMark.Click += new System.EventHandler(this.btnMark_Click);
            // 
            // lbxCurrentJobs
            // 
            this.lbxCurrentJobs.FormattingEnabled = true;
            this.lbxCurrentJobs.Location = new System.Drawing.Point(23, 28);
            this.lbxCurrentJobs.Name = "lbxCurrentJobs";
            this.lbxCurrentJobs.Size = new System.Drawing.Size(680, 238);
            this.lbxCurrentJobs.TabIndex = 0;
            // 
            // frmSupervisorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 394);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSupervisorWindow";
            this.Text = "frmSupervisorWindow";
            this.Load += new System.EventHandler(this.frmSupervisorWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMark;
        private System.Windows.Forms.ListBox lbxCurrentJobs;
    }
}