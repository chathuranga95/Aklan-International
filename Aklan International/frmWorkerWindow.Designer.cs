namespace Aklan_International
{
    partial class frmWorkerWindow
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.cmbWorkerName = new System.Windows.Forms.ComboBox();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.pannelPicture = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Worker Name";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(285, 86);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(156, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(285, 156);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(366, 156);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // cmbWorkerName
            // 
            this.cmbWorkerName.BackColor = System.Drawing.Color.White;
            this.cmbWorkerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWorkerName.FormattingEnabled = true;
            this.cmbWorkerName.Location = new System.Drawing.Point(285, 41);
            this.cmbWorkerName.Name = "cmbWorkerName";
            this.cmbWorkerName.Size = new System.Drawing.Size(156, 21);
            this.cmbWorkerName.TabIndex = 12;
            this.cmbWorkerName.SelectedIndexChanged += new System.EventHandler(this.cmbWorkerName_SelectedIndexChanged);
            // 
            // btnChangePass
            // 
            this.btnChangePass.BackColor = System.Drawing.Color.White;
            this.btnChangePass.Enabled = false;
            this.btnChangePass.Location = new System.Drawing.Point(26, 156);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(115, 23);
            this.btnChangePass.TabIndex = 13;
            this.btnChangePass.Text = "Change Password";
            this.btnChangePass.UseVisualStyleBackColor = false;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // pannelPicture
            // 
            this.pannelPicture.BackColor = System.Drawing.Color.White;
            this.pannelPicture.BackgroundImage = global::Aklan_International.Properties.Resources.lock_open_blue;
            this.pannelPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pannelPicture.Location = new System.Drawing.Point(27, 29);
            this.pannelPicture.Name = "pannelPicture";
            this.pannelPicture.Size = new System.Drawing.Size(120, 120);
            this.pannelPicture.TabIndex = 14;
            // 
            // frmWorkerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Aklan_International.Properties.Resources.loginAdmin;
            this.ClientSize = new System.Drawing.Size(464, 201);
            this.Controls.Add(this.pannelPicture);
            this.Controls.Add(this.btnChangePass);
            this.Controls.Add(this.cmbWorkerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmWorkerWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Worker Window";
            this.Load += new System.EventHandler(this.frmWorkerWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ComboBox cmbWorkerName;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Panel pannelPicture;
    }
}