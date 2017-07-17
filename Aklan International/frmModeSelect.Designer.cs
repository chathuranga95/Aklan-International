namespace Aklan_International
{
    partial class frmModeSelect
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
            this.btnWorker = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblModeSelect = new System.Windows.Forms.Label();
            this.panelbottom = new System.Windows.Forms.Panel();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelbottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnWorker
            // 
            this.btnWorker.BackColor = System.Drawing.Color.Transparent;
            this.btnWorker.BackgroundImage = global::Aklan_International.Properties.Resources.ModeButton;
            this.btnWorker.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnWorker.FlatAppearance.BorderSize = 0;
            this.btnWorker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorker.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWorker.Location = new System.Drawing.Point(0, 180);
            this.btnWorker.Name = "btnWorker";
            this.btnWorker.Size = new System.Drawing.Size(480, 130);
            this.btnWorker.TabIndex = 1;
            this.btnWorker.Text = "Worker Mode";
            this.btnWorker.UseVisualStyleBackColor = false;
            this.btnWorker.Click += new System.EventHandler(this.button2_Click);
            this.btnWorker.Enter += new System.EventHandler(this.btnWorker_Enter);
            this.btnWorker.Leave += new System.EventHandler(this.btnWorker_Leave);
            this.btnWorker.MouseEnter += new System.EventHandler(this.btnWorker_MouseEnter);
            this.btnWorker.MouseLeave += new System.EventHandler(this.btnWorker_MouseLeave);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.White;
            this.btnAdmin.BackgroundImage = global::Aklan_International.Properties.Resources.ModeButton;
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Location = new System.Drawing.Point(0, 50);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(480, 130);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.Text = "Admin Mode\r\n";
            this.btnAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            this.btnAdmin.Enter += new System.EventHandler(this.btnAdmin_Enter);
            this.btnAdmin.Leave += new System.EventHandler(this.btnAdmin_Leave);
            this.btnAdmin.MouseEnter += new System.EventHandler(this.btnAdmin_MouseEnter);
            this.btnAdmin.MouseLeave += new System.EventHandler(this.btnAdmin_MouseLeave);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.BackgroundImage = global::Aklan_International.Properties.Resources.Pannel_up_with_text3;
            this.panelTop.Controls.Add(this.lblModeSelect);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(480, 50);
            this.panelTop.TabIndex = 3;
            // 
            // lblModeSelect
            // 
            this.lblModeSelect.AutoSize = true;
            this.lblModeSelect.BackColor = System.Drawing.Color.Transparent;
            this.lblModeSelect.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModeSelect.Location = new System.Drawing.Point(142, 4);
            this.lblModeSelect.Name = "lblModeSelect";
            this.lblModeSelect.Size = new System.Drawing.Size(0, 43);
            this.lblModeSelect.TabIndex = 0;
            this.lblModeSelect.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelbottom
            // 
            this.panelbottom.BackColor = System.Drawing.Color.White;
            this.panelbottom.BackgroundImage = global::Aklan_International.Properties.Resources.bottom_pannel_480x50;
            this.panelbottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelbottom.Controls.Add(this.btnAbout);
            this.panelbottom.Controls.Add(this.btnClose);
            this.panelbottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelbottom.Location = new System.Drawing.Point(0, 310);
            this.panelbottom.Name = "panelbottom";
            this.panelbottom.Size = new System.Drawing.Size(480, 50);
            this.panelbottom.TabIndex = 2;
            this.panelbottom.Paint += new System.Windows.Forms.PaintEventHandler(this.panelbottom_Paint);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Transparent;
            this.btnAbout.BackgroundImage = global::Aklan_International.Properties.Resources.info1600__1_;
            this.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Location = new System.Drawing.Point(0, 0);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(50, 50);
            this.btnAbout.TabIndex = 4;
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            this.btnAbout.MouseEnter += new System.EventHandler(this.btnAbout_MouseEnter);
            this.btnAbout.MouseHover += new System.EventHandler(this.btnAbout_MouseHover);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::Aklan_International.Properties.Resources.CloseButton;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.Location = new System.Drawing.Point(405, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(2);
            this.btnClose.Size = new System.Drawing.Size(75, 50);
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // frmModeSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 360);
            this.Controls.Add(this.btnWorker);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelbottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmModeSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Mode";
            this.TopMost = true;
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelbottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnWorker;
        private System.Windows.Forms.Panel panelbottom;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblModeSelect;
        private System.Windows.Forms.Button btnAbout;
    }
}