namespace Aklan_International
{
    partial class frmChangePassword
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblempID = new System.Windows.Forms.Label();
            this.lblcrntpwd = new System.Windows.Forms.Label();
            this.lblnewepwd = new System.Windows.Forms.Label();
            this.lblConfirmpwd = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxConfirmpwd = new System.Windows.Forms.TextBox();
            this.txtnewpwd = new System.Windows.Forms.TextBox();
            this.tbxcrntpwd = new System.Windows.Forms.TextBox();
            this.tbxempID = new System.Windows.Forms.TextBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name :";
            // 
            // lblempID
            // 
            this.lblempID.AutoSize = true;
            this.lblempID.Location = new System.Drawing.Point(12, 39);
            this.lblempID.Name = "lblempID";
            this.lblempID.Size = new System.Drawing.Size(44, 13);
            this.lblempID.TabIndex = 1;
            this.lblempID.Text = "empID :";
            // 
            // lblcrntpwd
            // 
            this.lblcrntpwd.AutoSize = true;
            this.lblcrntpwd.Location = new System.Drawing.Point(12, 65);
            this.lblcrntpwd.Name = "lblcrntpwd";
            this.lblcrntpwd.Size = new System.Drawing.Size(96, 13);
            this.lblcrntpwd.TabIndex = 2;
            this.lblcrntpwd.Text = "Current Password :";
            // 
            // lblnewepwd
            // 
            this.lblnewepwd.AutoSize = true;
            this.lblnewepwd.Location = new System.Drawing.Point(12, 91);
            this.lblnewepwd.Name = "lblnewepwd";
            this.lblnewepwd.Size = new System.Drawing.Size(84, 13);
            this.lblnewepwd.TabIndex = 3;
            this.lblnewepwd.Text = "New Password :";
            // 
            // lblConfirmpwd
            // 
            this.lblConfirmpwd.AutoSize = true;
            this.lblConfirmpwd.Location = new System.Drawing.Point(12, 117);
            this.lblConfirmpwd.Name = "lblConfirmpwd";
            this.lblConfirmpwd.Size = new System.Drawing.Size(122, 13);
            this.lblConfirmpwd.TabIndex = 4;
            this.lblConfirmpwd.Text = "Confirm New Password :";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(137, 10);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 20);
            this.tbxName.TabIndex = 5;
            // 
            // tbxConfirmpwd
            // 
            this.tbxConfirmpwd.Location = new System.Drawing.Point(136, 114);
            this.tbxConfirmpwd.Name = "tbxConfirmpwd";
            this.tbxConfirmpwd.Size = new System.Drawing.Size(100, 20);
            this.tbxConfirmpwd.TabIndex = 3;
            // 
            // txtnewpwd
            // 
            this.txtnewpwd.Location = new System.Drawing.Point(137, 88);
            this.txtnewpwd.Name = "txtnewpwd";
            this.txtnewpwd.Size = new System.Drawing.Size(100, 20);
            this.txtnewpwd.TabIndex = 2;
            // 
            // tbxcrntpwd
            // 
            this.tbxcrntpwd.Location = new System.Drawing.Point(137, 62);
            this.tbxcrntpwd.Name = "tbxcrntpwd";
            this.tbxcrntpwd.Size = new System.Drawing.Size(100, 20);
            this.tbxcrntpwd.TabIndex = 1;
            // 
            // tbxempID
            // 
            this.tbxempID.Location = new System.Drawing.Point(137, 36);
            this.tbxempID.Name = "tbxempID";
            this.tbxempID.Size = new System.Drawing.Size(100, 20);
            this.tbxempID.TabIndex = 10;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(12, 145);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(122, 23);
            this.btnChangePassword.TabIndex = 4;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(162, 145);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 180);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.tbxempID);
            this.Controls.Add(this.tbxcrntpwd);
            this.Controls.Add(this.txtnewpwd);
            this.Controls.Add(this.tbxConfirmpwd);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblConfirmpwd);
            this.Controls.Add(this.lblnewepwd);
            this.Controls.Add(this.lblcrntpwd);
            this.Controls.Add(this.lblempID);
            this.Controls.Add(this.lblName);
            this.Name = "frmChangePassword";
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblempID;
        private System.Windows.Forms.Label lblcrntpwd;
        private System.Windows.Forms.Label lblnewepwd;
        private System.Windows.Forms.Label lblConfirmpwd;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxConfirmpwd;
        private System.Windows.Forms.TextBox txtnewpwd;
        private System.Windows.Forms.TextBox tbxcrntpwd;
        private System.Windows.Forms.TextBox tbxempID;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnCancel;
    }
}