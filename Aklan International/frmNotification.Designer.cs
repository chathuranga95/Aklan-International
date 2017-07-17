namespace Aklan_International
{
    partial class frmNotification
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
            this.grdNotify = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClrAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdNotify)).BeginInit();
            this.SuspendLayout();
            // 
            // grdNotify
            // 
            this.grdNotify.AllowUserToAddRows = false;
            this.grdNotify.AllowUserToDeleteRows = false;
            this.grdNotify.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdNotify.BackgroundColor = System.Drawing.Color.White;
            this.grdNotify.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdNotify.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.Notification,
            this.Column1});
            this.grdNotify.Location = new System.Drawing.Point(12, 17);
            this.grdNotify.Name = "grdNotify";
            this.grdNotify.ReadOnly = true;
            this.grdNotify.Size = new System.Drawing.Size(440, 134);
            this.grdNotify.TabIndex = 0;
            this.grdNotify.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdNotify_CellContentClick);
            // 
            // Time
            // 
            this.Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Time.FillWeight = 76.14214F;
            this.Time.HeaderText = "Time";
            this.Time.MinimumWidth = 30;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // Notification
            // 
            this.Notification.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Notification.FillWeight = 223.0715F;
            this.Notification.HeaderText = "Notification";
            this.Notification.MinimumWidth = 150;
            this.Notification.Name = "Notification";
            this.Notification.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.FillWeight = 0.7863408F;
            this.Column1.HeaderText = "Del";
            this.Column1.Image = global::Aklan_International.Properties.Resources.delete_garbage;
            this.Column1.MinimumWidth = 30;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefresh.BackColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(12, 186);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClrAll
            // 
            this.btnClrAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClrAll.BackColor = System.Drawing.Color.White;
            this.btnClrAll.Location = new System.Drawing.Point(377, 186);
            this.btnClrAll.Name = "btnClrAll";
            this.btnClrAll.Size = new System.Drawing.Size(75, 23);
            this.btnClrAll.TabIndex = 2;
            this.btnClrAll.Text = "Clear All";
            this.btnClrAll.UseVisualStyleBackColor = false;
            this.btnClrAll.Click += new System.EventHandler(this.btnClrAll_Click);
            // 
            // frmNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Aklan_International.Properties.Resources.Admin_Window_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(464, 221);
            this.Controls.Add(this.btnClrAll);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.grdNotify);
            this.DoubleBuffered = true;
            this.MinimizeBox = false;
            this.Name = "frmNotification";
            this.Text = "View Notifications";
            this.Load += new System.EventHandler(this.frmNotification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdNotify)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdNotify;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClrAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notification;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
    }
}