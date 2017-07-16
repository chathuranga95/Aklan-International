namespace Aklan_International
{
    partial class frmManageWorkers
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
            this.btnNewWorker = new System.Windows.Forms.Button();
            this.btnDeleteWorker = new System.Windows.Forms.Button();
            this.btnEditWorker = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewWorker
            // 
            this.btnNewWorker.Location = new System.Drawing.Point(30, 12);
            this.btnNewWorker.Name = "btnNewWorker";
            this.btnNewWorker.Size = new System.Drawing.Size(246, 101);
            this.btnNewWorker.TabIndex = 0;
            this.btnNewWorker.Text = "New Worker";
            this.btnNewWorker.UseVisualStyleBackColor = true;
            this.btnNewWorker.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDeleteWorker
            // 
            this.btnDeleteWorker.Location = new System.Drawing.Point(30, 233);
            this.btnDeleteWorker.Name = "btnDeleteWorker";
            this.btnDeleteWorker.Size = new System.Drawing.Size(246, 101);
            this.btnDeleteWorker.TabIndex = 1;
            this.btnDeleteWorker.Text = "Delete Worker";
            this.btnDeleteWorker.UseVisualStyleBackColor = true;
            this.btnDeleteWorker.Click += new System.EventHandler(this.btnDeleteWorker_Click);
            // 
            // btnEditWorker
            // 
            this.btnEditWorker.Location = new System.Drawing.Point(30, 123);
            this.btnEditWorker.Name = "btnEditWorker";
            this.btnEditWorker.Size = new System.Drawing.Size(246, 101);
            this.btnEditWorker.TabIndex = 2;
            this.btnEditWorker.Text = "Edit Woker";
            this.btnEditWorker.UseVisualStyleBackColor = true;
            this.btnEditWorker.Click += new System.EventHandler(this.btnEditWorker_Click);
            // 
            // frmManageWorkers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 345);
            this.Controls.Add(this.btnEditWorker);
            this.Controls.Add(this.btnDeleteWorker);
            this.Controls.Add(this.btnNewWorker);
            this.Name = "frmManageWorkers";
            this.Text = "Manage Workers";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewWorker;
        private System.Windows.Forms.Button btnDeleteWorker;
        private System.Windows.Forms.Button btnEditWorker;
    }
}