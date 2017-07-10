namespace Aklan_International
{
    partial class frmEditWorkerDetails
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
            this.nudYear = new System.Windows.Forms.NumericUpDown();
            this.dudMonth = new System.Windows.Forms.DomainUpDown();
            this.nudDate = new System.Windows.Forms.NumericUpDown();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.tbxConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddWorker = new System.Windows.Forms.Button();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxUserName = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxNIC = new System.Windows.Forms.TextBox();
            this.tbxContactNumber = new System.Windows.Forms.TextBox();
            this.tbxACNumber = new System.Windows.Forms.TextBox();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblACNumber = new System.Windows.Forms.Label();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblNICNumber = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDate)).BeginInit();
            this.SuspendLayout();
            // 
            // nudYear
            // 
            this.nudYear.Location = new System.Drawing.Point(218, 272);
            this.nudYear.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.nudYear.Minimum = new decimal(new int[] {
            1940,
            0,
            0,
            0});
            this.nudYear.Name = "nudYear";
            this.nudYear.Size = new System.Drawing.Size(47, 20);
            this.nudYear.TabIndex = 53;
            this.nudYear.Tag = "";
            this.nudYear.Value = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            // 
            // dudMonth
            // 
            this.dudMonth.Items.Add("Jan");
            this.dudMonth.Items.Add("Feb");
            this.dudMonth.Items.Add("Mar");
            this.dudMonth.Items.Add("Apr");
            this.dudMonth.Items.Add("May");
            this.dudMonth.Items.Add("Jun");
            this.dudMonth.Items.Add("Jul");
            this.dudMonth.Items.Add("Aug");
            this.dudMonth.Items.Add("Sep");
            this.dudMonth.Items.Add("Oct");
            this.dudMonth.Items.Add("Nov");
            this.dudMonth.Items.Add("Dec");
            this.dudMonth.Location = new System.Drawing.Point(172, 272);
            this.dudMonth.Name = "dudMonth";
            this.dudMonth.Size = new System.Drawing.Size(40, 20);
            this.dudMonth.TabIndex = 52;
            this.dudMonth.Text = "Jan";
            // 
            // nudDate
            // 
            this.nudDate.Location = new System.Drawing.Point(129, 272);
            this.nudDate.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudDate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDate.Name = "nudDate";
            this.nudDate.Size = new System.Drawing.Size(37, 20);
            this.nudDate.TabIndex = 51;
            this.nudDate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(129, 195);
            this.tbxAddress.Multiline = true;
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(121, 71);
            this.tbxAddress.TabIndex = 44;
            // 
            // tbxConfirmPassword
            // 
            this.tbxConfirmPassword.Location = new System.Drawing.Point(129, 113);
            this.tbxConfirmPassword.Name = "tbxConfirmPassword";
            this.tbxConfirmPassword.Size = new System.Drawing.Size(121, 20);
            this.tbxConfirmPassword.TabIndex = 38;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(14, 116);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(91, 13);
            this.lblConfirmPassword.TabIndex = 50;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(129, 166);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(121, 21);
            this.cmbGender.TabIndex = 41;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(14, 169);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 49;
            this.lblGender.Text = "Gender";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(176, 355);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 48;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAddWorker
            // 
            this.btnAddWorker.Location = new System.Drawing.Point(17, 355);
            this.btnAddWorker.Name = "btnAddWorker";
            this.btnAddWorker.Size = new System.Drawing.Size(75, 23);
            this.btnAddWorker.TabIndex = 47;
            this.btnAddWorker.Text = "Add Worker";
            this.btnAddWorker.UseVisualStyleBackColor = true;
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(129, 33);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(121, 20);
            this.tbxLastName.TabIndex = 32;
            // 
            // tbxUserName
            // 
            this.tbxUserName.Location = new System.Drawing.Point(129, 60);
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.Size = new System.Drawing.Size(121, 20);
            this.tbxUserName.TabIndex = 34;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(129, 86);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(121, 20);
            this.tbxPassword.TabIndex = 36;
            // 
            // tbxNIC
            // 
            this.tbxNIC.Location = new System.Drawing.Point(129, 140);
            this.tbxNIC.Name = "tbxNIC";
            this.tbxNIC.Size = new System.Drawing.Size(121, 20);
            this.tbxNIC.TabIndex = 39;
            // 
            // tbxContactNumber
            // 
            this.tbxContactNumber.Location = new System.Drawing.Point(130, 298);
            this.tbxContactNumber.Name = "tbxContactNumber";
            this.tbxContactNumber.Size = new System.Drawing.Size(120, 20);
            this.tbxContactNumber.TabIndex = 45;
            // 
            // tbxACNumber
            // 
            this.tbxACNumber.Location = new System.Drawing.Point(130, 324);
            this.tbxACNumber.Name = "tbxACNumber";
            this.tbxACNumber.Size = new System.Drawing.Size(120, 20);
            this.tbxACNumber.TabIndex = 46;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(130, 8);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(120, 20);
            this.tbxFirstName.TabIndex = 29;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(14, 195);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 43;
            this.lblAddress.Text = "Address";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(14, 89);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 42;
            this.lblPassword.Text = "Password";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(14, 63);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(60, 13);
            this.lblUserName.TabIndex = 40;
            this.lblUserName.Text = "User Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(14, 36);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 37;
            this.lblLastName.Text = "Last Name";
            // 
            // lblACNumber
            // 
            this.lblACNumber.AutoSize = true;
            this.lblACNumber.Location = new System.Drawing.Point(14, 327);
            this.lblACNumber.Name = "lblACNumber";
            this.lblACNumber.Size = new System.Drawing.Size(115, 13);
            this.lblACNumber.TabIndex = 35;
            this.lblACNumber.Text = "Bank Account Number";
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Location = new System.Drawing.Point(14, 301);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(84, 13);
            this.lblContactNumber.TabIndex = 33;
            this.lblContactNumber.Text = "Contact Number";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(14, 275);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(66, 13);
            this.lblDOB.TabIndex = 31;
            this.lblDOB.Text = "Date of Birth";
            // 
            // lblNICNumber
            // 
            this.lblNICNumber.AutoSize = true;
            this.lblNICNumber.Location = new System.Drawing.Point(14, 143);
            this.lblNICNumber.Name = "lblNICNumber";
            this.lblNICNumber.Size = new System.Drawing.Size(65, 13);
            this.lblNICNumber.TabIndex = 30;
            this.lblNICNumber.Text = "NIC Number";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(14, 11);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 28;
            this.lblFirstName.Text = "First Name";
            // 
            // frmEditWorkerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 387);
            this.Controls.Add(this.nudYear);
            this.Controls.Add(this.dudMonth);
            this.Controls.Add(this.nudDate);
            this.Controls.Add(this.tbxAddress);
            this.Controls.Add(this.tbxConfirmPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddWorker);
            this.Controls.Add(this.tbxLastName);
            this.Controls.Add(this.tbxUserName);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxNIC);
            this.Controls.Add(this.tbxContactNumber);
            this.Controls.Add(this.tbxACNumber);
            this.Controls.Add(this.tbxFirstName);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblACNumber);
            this.Controls.Add(this.lblContactNumber);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblNICNumber);
            this.Controls.Add(this.lblFirstName);
            this.Name = "frmEditWorkerDetails";
            this.Text = "Edit Worker Details";
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudYear;
        private System.Windows.Forms.DomainUpDown dudMonth;
        private System.Windows.Forms.NumericUpDown nudDate;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.TextBox tbxConfirmPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddWorker;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxUserName;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxNIC;
        private System.Windows.Forms.TextBox tbxContactNumber;
        private System.Windows.Forms.TextBox tbxACNumber;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblACNumber;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblNICNumber;
        private System.Windows.Forms.Label lblFirstName;
    }
}