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
            this.btnMarkJobs = new System.Windows.Forms.Button();
            this.lbxCurrentJobs = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMarkOrders = new System.Windows.Forms.Button();
            this.lbxCurrentOrders = new System.Windows.Forms.ListBox();
            this.btnChangePw = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnMarkJobs);
            this.groupBox1.Controls.Add(this.lbxCurrentJobs);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(765, 325);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current jobs";
            // 
            // btnMarkJobs
            // 
            this.btnMarkJobs.BackColor = System.Drawing.Color.White;
            this.btnMarkJobs.Location = new System.Drawing.Point(660, 272);
            this.btnMarkJobs.Name = "btnMarkJobs";
            this.btnMarkJobs.Size = new System.Drawing.Size(86, 38);
            this.btnMarkJobs.TabIndex = 1;
            this.btnMarkJobs.Text = "Mark as Finished";
            this.btnMarkJobs.UseVisualStyleBackColor = false;
            this.btnMarkJobs.Click += new System.EventHandler(this.btnMark_Click);
            // 
            // lbxCurrentJobs
            // 
            this.lbxCurrentJobs.FormattingEnabled = true;
            this.lbxCurrentJobs.Location = new System.Drawing.Point(23, 28);
            this.lbxCurrentJobs.Name = "lbxCurrentJobs";
            this.lbxCurrentJobs.Size = new System.Drawing.Size(725, 238);
            this.lbxCurrentJobs.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnMarkOrders);
            this.groupBox2.Controls.Add(this.lbxCurrentOrders);
            this.groupBox2.Location = new System.Drawing.Point(10, 344);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(765, 325);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current Orders";
            // 
            // btnMarkOrders
            // 
            this.btnMarkOrders.BackColor = System.Drawing.Color.White;
            this.btnMarkOrders.Location = new System.Drawing.Point(659, 271);
            this.btnMarkOrders.Name = "btnMarkOrders";
            this.btnMarkOrders.Size = new System.Drawing.Size(86, 38);
            this.btnMarkOrders.TabIndex = 1;
            this.btnMarkOrders.Text = "Mark as Finished";
            this.btnMarkOrders.UseVisualStyleBackColor = false;
            this.btnMarkOrders.Click += new System.EventHandler(this.btnMarkOrders_Click);
            // 
            // lbxCurrentOrders
            // 
            this.lbxCurrentOrders.FormattingEnabled = true;
            this.lbxCurrentOrders.Location = new System.Drawing.Point(20, 27);
            this.lbxCurrentOrders.Name = "lbxCurrentOrders";
            this.lbxCurrentOrders.Size = new System.Drawing.Size(725, 238);
            this.lbxCurrentOrders.TabIndex = 0;
            // 
            // btnChangePw
            // 
            this.btnChangePw.BackColor = System.Drawing.Color.White;
            this.btnChangePw.Location = new System.Drawing.Point(10, 675);
            this.btnChangePw.Name = "btnChangePw";
            this.btnChangePw.Size = new System.Drawing.Size(114, 24);
            this.btnChangePw.TabIndex = 2;
            this.btnChangePw.Text = "Change Password";
            this.btnChangePw.UseVisualStyleBackColor = false;
            this.btnChangePw.Click += new System.EventHandler(this.btnChangePw_Click);
            // 
            // frmSupervisorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aklan_International.Properties.Resources.Admin_Window_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 711);
            this.Controls.Add(this.btnChangePw);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSupervisorWindow";
            this.Text = "Supervisor Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSupervisorWindow_FormClosing);
            this.Load += new System.EventHandler(this.frmSupervisorWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMarkJobs;
        private System.Windows.Forms.ListBox lbxCurrentJobs;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMarkOrders;
        private System.Windows.Forms.ListBox lbxCurrentOrders;
        private System.Windows.Forms.Button btnChangePw;
    }
}