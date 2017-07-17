namespace Aklan_International
{
    partial class frmStockReport
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
            this.lblSheets = new System.Windows.Forms.Label();
            this.lblCutstrip = new System.Windows.Forms.Label();
            this.lblClipcut = new System.Windows.Forms.Label();
            this.lblFolded12 = new System.Windows.Forms.Label();
            this.lblFoldedsingle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSheets
            // 
            this.lblSheets.AutoSize = true;
            this.lblSheets.BackColor = System.Drawing.Color.Transparent;
            this.lblSheets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSheets.Location = new System.Drawing.Point(23, 22);
            this.lblSheets.Name = "lblSheets";
            this.lblSheets.Size = new System.Drawing.Size(46, 17);
            this.lblSheets.TabIndex = 0;
            this.lblSheets.Text = "label1";
            // 
            // lblCutstrip
            // 
            this.lblCutstrip.AutoSize = true;
            this.lblCutstrip.BackColor = System.Drawing.Color.Transparent;
            this.lblCutstrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCutstrip.Location = new System.Drawing.Point(23, 75);
            this.lblCutstrip.Name = "lblCutstrip";
            this.lblCutstrip.Size = new System.Drawing.Size(46, 17);
            this.lblCutstrip.TabIndex = 1;
            this.lblCutstrip.Text = "label1";
            // 
            // lblClipcut
            // 
            this.lblClipcut.AutoSize = true;
            this.lblClipcut.BackColor = System.Drawing.Color.Transparent;
            this.lblClipcut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClipcut.Location = new System.Drawing.Point(23, 128);
            this.lblClipcut.Name = "lblClipcut";
            this.lblClipcut.Size = new System.Drawing.Size(46, 17);
            this.lblClipcut.TabIndex = 2;
            this.lblClipcut.Text = "label2";
            // 
            // lblFolded12
            // 
            this.lblFolded12.AutoSize = true;
            this.lblFolded12.BackColor = System.Drawing.Color.Transparent;
            this.lblFolded12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolded12.Location = new System.Drawing.Point(23, 181);
            this.lblFolded12.Name = "lblFolded12";
            this.lblFolded12.Size = new System.Drawing.Size(46, 17);
            this.lblFolded12.TabIndex = 3;
            this.lblFolded12.Text = "label3";
            this.lblFolded12.Click += new System.EventHandler(this.lblFolded12_Click);
            // 
            // lblFoldedsingle
            // 
            this.lblFoldedsingle.AutoSize = true;
            this.lblFoldedsingle.BackColor = System.Drawing.Color.Transparent;
            this.lblFoldedsingle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoldedsingle.Location = new System.Drawing.Point(23, 234);
            this.lblFoldedsingle.Name = "lblFoldedsingle";
            this.lblFoldedsingle.Size = new System.Drawing.Size(46, 17);
            this.lblFoldedsingle.TabIndex = 4;
            this.lblFoldedsingle.Text = "label4";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(189, 260);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 49);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmStockReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aklan_International.Properties.Resources.Admin_Window_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 321);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblFoldedsingle);
            this.Controls.Add(this.lblFolded12);
            this.Controls.Add(this.lblClipcut);
            this.Controls.Add(this.lblCutstrip);
            this.Controls.Add(this.lblSheets);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStockReport";
            this.Text = "Stock Report";
            this.Load += new System.EventHandler(this.frmStockReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSheets;
        private System.Windows.Forms.Label lblCutstrip;
        private System.Windows.Forms.Label lblClipcut;
        private System.Windows.Forms.Label lblFolded12;
        private System.Windows.Forms.Label lblFoldedsingle;
        private System.Windows.Forms.Button btnClose;
    }
}