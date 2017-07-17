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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageWorkers));
            this.btnNewWorker = new System.Windows.Forms.Button();
            this.btnDeleteWorker = new System.Windows.Forms.Button();
            this.btnEditWorker = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewWorker
            // 
            this.btnNewWorker.BackColor = System.Drawing.Color.White;
            this.btnNewWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewWorker.Location = new System.Drawing.Point(12, 12);
            this.btnNewWorker.Name = "btnNewWorker";
            this.btnNewWorker.Size = new System.Drawing.Size(260, 85);
            this.btnNewWorker.TabIndex = 0;
            this.btnNewWorker.Text = "New Worker";
            this.btnNewWorker.UseVisualStyleBackColor = false;
            this.btnNewWorker.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDeleteWorker
            // 
            this.btnDeleteWorker.BackColor = System.Drawing.Color.White;
            this.btnDeleteWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteWorker.Location = new System.Drawing.Point(12, 224);
            this.btnDeleteWorker.Name = "btnDeleteWorker";
            this.btnDeleteWorker.Size = new System.Drawing.Size(260, 85);
            this.btnDeleteWorker.TabIndex = 2;
            this.btnDeleteWorker.Text = "Delete Worker";
            this.btnDeleteWorker.UseVisualStyleBackColor = false;
            this.btnDeleteWorker.Click += new System.EventHandler(this.btnDeleteWorker_Click);
            // 
            // btnEditWorker
            // 
            this.btnEditWorker.BackColor = System.Drawing.Color.White;
            this.btnEditWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditWorker.Location = new System.Drawing.Point(12, 118);
            this.btnEditWorker.Name = "btnEditWorker";
            this.btnEditWorker.Size = new System.Drawing.Size(260, 85);
            this.btnEditWorker.TabIndex = 1;
            this.btnEditWorker.Text = "Edit Woker";
            this.btnEditWorker.UseVisualStyleBackColor = false;
            this.btnEditWorker.Click += new System.EventHandler(this.btnEditWorker_Click);
            // 
            // frmManageWorkers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aklan_International.Properties.Resources.Admin_Window_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 321);
            this.Controls.Add(this.btnEditWorker);
            this.Controls.Add(this.btnDeleteWorker);
            this.Controls.Add(this.btnNewWorker);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManageWorkers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Workers";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewWorker;
        private System.Windows.Forms.Button btnDeleteWorker;
        private System.Windows.Forms.Button btnEditWorker;
    }
}