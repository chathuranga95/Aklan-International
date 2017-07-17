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
            this.lblWorkerNameShow = new System.Windows.Forms.Label();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.lblnotAvailable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblempID
            // 
            this.lblempID.AutoSize = true;
            this.lblempID.BackColor = System.Drawing.Color.Transparent;
            this.lblempID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempID.Location = new System.Drawing.Point(18, 18);
            this.lblempID.Name = "lblempID";
            this.lblempID.Size = new System.Drawing.Size(111, 16);
            this.lblempID.TabIndex = 0;
            this.lblempID.Text = "Worker\'s empID :";
            // 
            // tbxempID
            // 
            this.tbxempID.AutoCompleteCustomSource.AddRange(new string[] {
            "w001",
            "w002",
            "s001"});
            this.tbxempID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbxempID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxempID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxempID.Location = new System.Drawing.Point(135, 15);
            this.tbxempID.Name = "tbxempID";
            this.tbxempID.Size = new System.Drawing.Size(224, 22);
            this.tbxempID.TabIndex = 1;
            this.tbxempID.TextChanged += new System.EventHandler(this.tbxempID_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(12, 157);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 32);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(357, 157);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 32);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblWorkerName
            // 
            this.lblWorkerName.AutoSize = true;
            this.lblWorkerName.BackColor = System.Drawing.Color.Transparent;
            this.lblWorkerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkerName.Location = new System.Drawing.Point(18, 74);
            this.lblWorkerName.Name = "lblWorkerName";
            this.lblWorkerName.Size = new System.Drawing.Size(111, 16);
            this.lblWorkerName.TabIndex = 4;
            this.lblWorkerName.Text = "Worker\'s Name  :";
            // 
            // lblWorkerNameShow
            // 
            this.lblWorkerNameShow.AutoSize = true;
            this.lblWorkerNameShow.BackColor = System.Drawing.Color.Transparent;
            this.lblWorkerNameShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkerNameShow.Location = new System.Drawing.Point(135, 67);
            this.lblWorkerNameShow.Name = "lblWorkerNameShow";
            this.lblWorkerNameShow.Size = new System.Drawing.Size(171, 25);
            this.lblWorkerNameShow.TabIndex = 5;
            this.lblWorkerNameShow.Text = "Worker\'s Name";
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.BackColor = System.Drawing.Color.Transparent;
            this.lblAvailable.ForeColor = System.Drawing.Color.Green;
            this.lblAvailable.Location = new System.Drawing.Point(365, 18);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(49, 13);
            this.lblAvailable.TabIndex = 6;
            this.lblAvailable.Text = "available";
            // 
            // lblnotAvailable
            // 
            this.lblnotAvailable.AutoSize = true;
            this.lblnotAvailable.BackColor = System.Drawing.Color.Transparent;
            this.lblnotAvailable.ForeColor = System.Drawing.Color.Crimson;
            this.lblnotAvailable.Location = new System.Drawing.Point(365, 18);
            this.lblnotAvailable.Name = "lblnotAvailable";
            this.lblnotAvailable.Size = new System.Drawing.Size(67, 13);
            this.lblnotAvailable.TabIndex = 7;
            this.lblnotAvailable.Text = "not available";
            this.lblnotAvailable.Click += new System.EventHandler(this.lblnotAvailable_Click);
            // 
            // frmDeleteWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aklan_International.Properties.Resources.Admin_Window_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(444, 201);
            this.Controls.Add(this.lblnotAvailable);
            this.Controls.Add(this.lblAvailable);
            this.Controls.Add(this.lblWorkerNameShow);
            this.Controls.Add(this.lblWorkerName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tbxempID);
            this.Controls.Add(this.lblempID);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDeleteWorker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label lblWorkerNameShow;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.Label lblnotAvailable;
    }
}