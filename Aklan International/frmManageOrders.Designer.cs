namespace Aklan_International
{
    partial class frmManageOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageOrders));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMarkOrders = new System.Windows.Forms.Button();
            this.lbxCurrentOrders = new System.Windows.Forms.ListBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnMarkOrders);
            this.groupBox2.Controls.Add(this.lbxCurrentOrders);
            this.groupBox2.Location = new System.Drawing.Point(9, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(664, 302);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current Orders";
            // 
            // btnMarkOrders
            // 
            this.btnMarkOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMarkOrders.BackColor = System.Drawing.Color.White;
            this.btnMarkOrders.Location = new System.Drawing.Point(564, 251);
            this.btnMarkOrders.Name = "btnMarkOrders";
            this.btnMarkOrders.Size = new System.Drawing.Size(86, 38);
            this.btnMarkOrders.TabIndex = 1;
            this.btnMarkOrders.Text = "Mark as Finished";
            this.btnMarkOrders.UseVisualStyleBackColor = false;
            this.btnMarkOrders.Click += new System.EventHandler(this.btnMarkOrders_Click);
            // 
            // lbxCurrentOrders
            // 
            this.lbxCurrentOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxCurrentOrders.FormattingEnabled = true;
            this.lbxCurrentOrders.Location = new System.Drawing.Point(18, 25);
            this.lbxCurrentOrders.Name = "lbxCurrentOrders";
            this.lbxCurrentOrders.Size = new System.Drawing.Size(632, 212);
            this.lbxCurrentOrders.TabIndex = 0;
            // 
            // frmManageOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aklan_International.Properties.Resources.Admin_Window_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 321);
            this.Controls.Add(this.groupBox2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManageOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Orders";
            this.Load += new System.EventHandler(this.frmManageOrders_Load);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMarkOrders;
        private System.Windows.Forms.ListBox lbxCurrentOrders;
    }
}