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
            this.SuspendLayout();
            // 
            // lblSheets
            // 
            this.lblSheets.AutoSize = true;
            this.lblSheets.Location = new System.Drawing.Point(31, 22);
            this.lblSheets.Name = "lblSheets";
            this.lblSheets.Size = new System.Drawing.Size(35, 13);
            this.lblSheets.TabIndex = 0;
            this.lblSheets.Text = "label1";
            // 
            // lblCutstrip
            // 
            this.lblCutstrip.AutoSize = true;
            this.lblCutstrip.Location = new System.Drawing.Point(30, 61);
            this.lblCutstrip.Name = "lblCutstrip";
            this.lblCutstrip.Size = new System.Drawing.Size(35, 13);
            this.lblCutstrip.TabIndex = 1;
            this.lblCutstrip.Text = "label1";
            // 
            // lblClipcut
            // 
            this.lblClipcut.AutoSize = true;
            this.lblClipcut.Location = new System.Drawing.Point(31, 104);
            this.lblClipcut.Name = "lblClipcut";
            this.lblClipcut.Size = new System.Drawing.Size(35, 13);
            this.lblClipcut.TabIndex = 2;
            this.lblClipcut.Text = "label2";
            // 
            // lblFolded12
            // 
            this.lblFolded12.AutoSize = true;
            this.lblFolded12.Location = new System.Drawing.Point(32, 151);
            this.lblFolded12.Name = "lblFolded12";
            this.lblFolded12.Size = new System.Drawing.Size(35, 13);
            this.lblFolded12.TabIndex = 3;
            this.lblFolded12.Text = "label3";
            // 
            // lblFoldedsingle
            // 
            this.lblFoldedsingle.AutoSize = true;
            this.lblFoldedsingle.Location = new System.Drawing.Point(32, 200);
            this.lblFoldedsingle.Name = "lblFoldedsingle";
            this.lblFoldedsingle.Size = new System.Drawing.Size(35, 13);
            this.lblFoldedsingle.TabIndex = 4;
            this.lblFoldedsingle.Text = "label4";
            // 
            // frmStockReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 261);
            this.Controls.Add(this.lblFoldedsingle);
            this.Controls.Add(this.lblFolded12);
            this.Controls.Add(this.lblClipcut);
            this.Controls.Add(this.lblCutstrip);
            this.Controls.Add(this.lblSheets);
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
    }
}