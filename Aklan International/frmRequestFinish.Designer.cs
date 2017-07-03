namespace Aklan_International
{
    partial class frmRequestFinish
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rdbRimming = new System.Windows.Forms.RadioButton();
            this.rdbFolding = new System.Windows.Forms.RadioButton();
            this.rdbClipCutting = new System.Windows.Forms.RadioButton();
            this.rdbCutting = new System.Windows.Forms.RadioButton();
            this.btnRequest = new System.Windows.Forms.Button();
            this.spnQty = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbxJobs = new System.Windows.Forms.ListBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnQty)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(461, 215);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rdbRimming);
            this.tabPage1.Controls.Add(this.rdbFolding);
            this.tabPage1.Controls.Add(this.rdbClipCutting);
            this.tabPage1.Controls.Add(this.rdbCutting);
            this.tabPage1.Controls.Add(this.btnRequest);
            this.tabPage1.Controls.Add(this.spnQty);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(453, 189);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Request Job";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rdbRimming
            // 
            this.rdbRimming.AutoSize = true;
            this.rdbRimming.Location = new System.Drawing.Point(161, 110);
            this.rdbRimming.Name = "rdbRimming";
            this.rdbRimming.Size = new System.Drawing.Size(65, 17);
            this.rdbRimming.TabIndex = 8;
            this.rdbRimming.TabStop = true;
            this.rdbRimming.Text = "Rimming";
            this.rdbRimming.UseVisualStyleBackColor = true;
            // 
            // rdbFolding
            // 
            this.rdbFolding.AutoSize = true;
            this.rdbFolding.Location = new System.Drawing.Point(161, 86);
            this.rdbFolding.Name = "rdbFolding";
            this.rdbFolding.Size = new System.Drawing.Size(59, 17);
            this.rdbFolding.TabIndex = 7;
            this.rdbFolding.TabStop = true;
            this.rdbFolding.Text = "Folding";
            this.rdbFolding.UseVisualStyleBackColor = true;
            // 
            // rdbClipCutting
            // 
            this.rdbClipCutting.AutoSize = true;
            this.rdbClipCutting.Location = new System.Drawing.Point(161, 62);
            this.rdbClipCutting.Name = "rdbClipCutting";
            this.rdbClipCutting.Size = new System.Drawing.Size(78, 17);
            this.rdbClipCutting.TabIndex = 6;
            this.rdbClipCutting.TabStop = true;
            this.rdbClipCutting.Text = "Clip Cutting";
            this.rdbClipCutting.UseVisualStyleBackColor = true;
            // 
            // rdbCutting
            // 
            this.rdbCutting.AutoSize = true;
            this.rdbCutting.Location = new System.Drawing.Point(161, 38);
            this.rdbCutting.Name = "rdbCutting";
            this.rdbCutting.Size = new System.Drawing.Size(58, 17);
            this.rdbCutting.TabIndex = 5;
            this.rdbCutting.TabStop = true;
            this.rdbCutting.Text = "Cutting";
            this.rdbCutting.UseVisualStyleBackColor = true;
            // 
            // btnRequest
            // 
            this.btnRequest.Location = new System.Drawing.Point(351, 141);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(75, 23);
            this.btnRequest.TabIndex = 4;
            this.btnRequest.Text = "Request";
            this.btnRequest.UseVisualStyleBackColor = true;
            // 
            // spnQty
            // 
            this.spnQty.Location = new System.Drawing.Point(161, 144);
            this.spnQty.Name = "spnQty";
            this.spnQty.Size = new System.Drawing.Size(120, 20);
            this.spnQty.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Qty";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Machine Type";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbxJobs);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(453, 189);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Current Jobs";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbxJobs
            // 
            this.lbxJobs.FormattingEnabled = true;
            this.lbxJobs.Location = new System.Drawing.Point(26, 19);
            this.lbxJobs.Name = "lbxJobs";
            this.lbxJobs.Size = new System.Drawing.Size(396, 147);
            this.lbxJobs.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(155, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "label1";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(394, 267);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // frmRequestFinish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 315);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmRequestFinish";
            this.Text = "Request or Finish Jobs";
            this.Load += new System.EventHandler(this.frmRequestFinish_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnQty)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.NumericUpDown spnQty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.RadioButton rdbRimming;
        private System.Windows.Forms.RadioButton rdbFolding;
        private System.Windows.Forms.RadioButton rdbClipCutting;
        private System.Windows.Forms.RadioButton rdbCutting;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.ListBox lbxJobs;
        private System.Windows.Forms.Button btnExit;
    }
}