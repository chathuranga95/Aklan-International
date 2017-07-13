namespace Aklan_International
{
    partial class frmDeleteWorker
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
            this.lblempID = new System.Windows.Forms.Label();
            this.tbxempID = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblWorkerName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblempID
            // 
            this.lblempID.AutoSize = true;
            this.lblempID.Location = new System.Drawing.Point(26, 47);
            this.lblempID.Name = "lblempID";
            this.lblempID.Size = new System.Drawing.Size(83, 13);
            this.lblempID.TabIndex = 0;
            this.lblempID.Text = "Worker\'s empID";
            // 
            // tbxempID
            // 
            this.tbxempID.Location = new System.Drawing.Point(129, 40);
            this.tbxempID.Name = "tbxempID";
            this.tbxempID.Size = new System.Drawing.Size(100, 20);
            this.tbxempID.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(29, 152);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(186, 152);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblWorkerName
            // 
            this.lblWorkerName.AutoSize = true;
            this.lblWorkerName.Location = new System.Drawing.Point(24, 77);
            this.lblWorkerName.Name = "lblWorkerName";
            this.lblWorkerName.Size = new System.Drawing.Size(80, 13);
            this.lblWorkerName.TabIndex = 4;
            this.lblWorkerName.Text = "Worker\'s Name";
            // 
            // frmDeleteWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblWorkerName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tbxempID);
            this.Controls.Add(this.lblempID);
            this.Name = "frmDeleteWorker";
            this.Text = "Delete Worker";
            this.Load += new System.EventHandler(this.frmDeleteWorker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblempID;
        private System.Windows.Forms.TextBox tbxempID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblWorkerName;
    }
}