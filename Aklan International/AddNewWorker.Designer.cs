namespace Aklan_International
{
    partial class frmAddNewWorker
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
            this.btnAddWorker = new System.Windows.Forms.Button();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.tbxContactNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblempID = new System.Windows.Forms.Label();
            this.nudYear = new System.Windows.Forms.NumericUpDown();
            this.dudMonth = new System.Windows.Forms.DomainUpDown();
            this.nudDate = new System.Windows.Forms.NumericUpDown();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.tbxConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxNIC = new System.Windows.Forms.TextBox();
            this.tbxACNumber = new System.Windows.Forms.TextBox();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblACNumber = new System.Windows.Forms.Label();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblNICNumber = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblPasswordMaching = new System.Windows.Forms.Label();
            this.cmbWorkerType = new System.Windows.Forms.ComboBox();
            this.lblWorkerType = new System.Windows.Forms.Label();
            this.tbxWorkerID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddWorker
            // 
            this.btnAddWorker.Location = new System.Drawing.Point(12, 394);
            this.btnAddWorker.Name = "btnAddWorker";
            this.btnAddWorker.Size = new System.Drawing.Size(75, 23);
            this.btnAddWorker.TabIndex = 15;
            this.btnAddWorker.Text = "Add Worker";
            this.btnAddWorker.UseVisualStyleBackColor = true;
            this.btnAddWorker.Click += new System.EventHandler(this.btnAddWorker_Click);
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(188, 211);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 8;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(126, 211);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 7;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // tbxContactNumber
            // 
            this.tbxContactNumber.Location = new System.Drawing.Point(125, 337);
            this.tbxContactNumber.Mask = "(999) 000-0000";
            this.tbxContactNumber.Name = "tbxContactNumber";
            this.tbxContactNumber.PromptChar = ' ';
            this.tbxContactNumber.Size = new System.Drawing.Size(137, 20);
            this.tbxContactNumber.TabIndex = 13;
            this.tbxContactNumber.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.tbxContactNumber_MaskInputRejected);
            // 
            // lblempID
            // 
            this.lblempID.AutoSize = true;
            this.lblempID.Location = new System.Drawing.Point(10, 40);
            this.lblempID.Name = "lblempID";
            this.lblempID.Size = new System.Drawing.Size(56, 13);
            this.lblempID.TabIndex = 82;
            this.lblempID.Text = "Worker ID";
            // 
            // nudYear
            // 
            this.nudYear.AllowDrop = true;
            this.nudYear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudYear.Location = new System.Drawing.Point(214, 311);
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
            this.nudYear.ReadOnly = true;
            this.nudYear.Size = new System.Drawing.Size(47, 20);
            this.nudYear.TabIndex = 12;
            this.nudYear.Tag = "";
            this.nudYear.Value = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            // 
            // dudMonth
            // 
            this.dudMonth.AllowDrop = true;
            this.dudMonth.Items.Add("Dec");
            this.dudMonth.Items.Add("Nov");
            this.dudMonth.Items.Add("Oct");
            this.dudMonth.Items.Add("Sep");
            this.dudMonth.Items.Add("Aug");
            this.dudMonth.Items.Add("Jul");
            this.dudMonth.Items.Add("Jun");
            this.dudMonth.Items.Add("May");
            this.dudMonth.Items.Add("Apr");
            this.dudMonth.Items.Add("Mar");
            this.dudMonth.Items.Add("Feb");
            this.dudMonth.Items.Add("Jan");
            this.dudMonth.Location = new System.Drawing.Point(168, 311);
            this.dudMonth.Name = "dudMonth";
            this.dudMonth.ReadOnly = true;
            this.dudMonth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dudMonth.Size = new System.Drawing.Size(40, 20);
            this.dudMonth.TabIndex = 11;
            this.dudMonth.TabStop = false;
            // 
            // nudDate
            // 
            this.nudDate.AllowDrop = true;
            this.nudDate.Location = new System.Drawing.Point(125, 311);
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
            this.nudDate.ReadOnly = true;
            this.nudDate.Size = new System.Drawing.Size(37, 20);
            this.nudDate.TabIndex = 10;
            this.nudDate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(125, 234);
            this.tbxAddress.Multiline = true;
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(136, 71);
            this.tbxAddress.TabIndex = 9;
            this.tbxAddress.TextChanged += new System.EventHandler(this.tbxAddress_TextChanged);
            // 
            // tbxConfirmPassword
            // 
            this.tbxConfirmPassword.Location = new System.Drawing.Point(125, 142);
            this.tbxConfirmPassword.Name = "tbxConfirmPassword";
            this.tbxConfirmPassword.PasswordChar = '*';
            this.tbxConfirmPassword.Size = new System.Drawing.Size(136, 20);
            this.tbxConfirmPassword.TabIndex = 5;
            this.tbxConfirmPassword.TextChanged += new System.EventHandler(this.tbxConfirmPassword_TextChanged);
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(10, 145);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(91, 13);
            this.lblConfirmPassword.TabIndex = 81;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(10, 213);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 80;
            this.lblGender.Text = "Gender";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(186, 394);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(125, 89);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(136, 20);
            this.tbxLastName.TabIndex = 3;
            this.tbxLastName.TextChanged += new System.EventHandler(this.tbxLastName_TextChanged);
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(125, 115);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.Size = new System.Drawing.Size(136, 20);
            this.tbxPassword.TabIndex = 4;
            this.tbxPassword.TextChanged += new System.EventHandler(this.tbxPassword_TextChanged);
            // 
            // tbxNIC
            // 
            this.tbxNIC.Location = new System.Drawing.Point(125, 179);
            this.tbxNIC.Name = "tbxNIC";
            this.tbxNIC.Size = new System.Drawing.Size(136, 20);
            this.tbxNIC.TabIndex = 6;
            this.tbxNIC.TextChanged += new System.EventHandler(this.tbxNIC_TextChanged);
            // 
            // tbxACNumber
            // 
            this.tbxACNumber.Location = new System.Drawing.Point(126, 363);
            this.tbxACNumber.Name = "tbxACNumber";
            this.tbxACNumber.Size = new System.Drawing.Size(135, 20);
            this.tbxACNumber.TabIndex = 14;
            this.tbxACNumber.TextChanged += new System.EventHandler(this.tbxACNumber_TextChanged);
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(125, 63);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(135, 20);
            this.tbxFirstName.TabIndex = 2;
            this.tbxFirstName.TextChanged += new System.EventHandler(this.tbxFirstName_TextChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(10, 237);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 79;
            this.lblAddress.Text = "Address";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(10, 118);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 78;
            this.lblPassword.Text = "Password";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(10, 92);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 76;
            this.lblLastName.Text = "Last Name";
            // 
            // lblACNumber
            // 
            this.lblACNumber.AutoSize = true;
            this.lblACNumber.Location = new System.Drawing.Point(10, 366);
            this.lblACNumber.Name = "lblACNumber";
            this.lblACNumber.Size = new System.Drawing.Size(115, 13);
            this.lblACNumber.TabIndex = 75;
            this.lblACNumber.Text = "Bank Account Number";
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Location = new System.Drawing.Point(10, 340);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(84, 13);
            this.lblContactNumber.TabIndex = 74;
            this.lblContactNumber.Text = "Contact Number";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(10, 314);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(66, 13);
            this.lblDOB.TabIndex = 73;
            this.lblDOB.Text = "Date of Birth";
            // 
            // lblNICNumber
            // 
            this.lblNICNumber.AutoSize = true;
            this.lblNICNumber.Location = new System.Drawing.Point(10, 182);
            this.lblNICNumber.Name = "lblNICNumber";
            this.lblNICNumber.Size = new System.Drawing.Size(65, 13);
            this.lblNICNumber.TabIndex = 72;
            this.lblNICNumber.Text = "NIC Number";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(10, 66);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 71;
            this.lblFirstName.Text = "First Name";
            // 
            // lblPasswordMaching
            // 
            this.lblPasswordMaching.AutoSize = true;
            this.lblPasswordMaching.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordMaching.Location = new System.Drawing.Point(126, 164);
            this.lblPasswordMaching.Name = "lblPasswordMaching";
            this.lblPasswordMaching.Size = new System.Drawing.Size(35, 13);
            this.lblPasswordMaching.TabIndex = 86;
            this.lblPasswordMaching.Text = "label1";
            // 
            // cmbWorkerType
            // 
            this.cmbWorkerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWorkerType.FormattingEnabled = true;
            this.cmbWorkerType.Items.AddRange(new object[] {
            "Admin",
            "Supervisor",
            "Salesman",
            "Worker"});
            this.cmbWorkerType.Location = new System.Drawing.Point(125, 10);
            this.cmbWorkerType.Name = "cmbWorkerType";
            this.cmbWorkerType.Size = new System.Drawing.Size(136, 21);
            this.cmbWorkerType.TabIndex = 1;
            this.cmbWorkerType.SelectedIndexChanged += new System.EventHandler(this.cmbWorkerType_SelectedIndexChanged);
            // 
            // lblWorkerType
            // 
            this.lblWorkerType.AutoSize = true;
            this.lblWorkerType.Location = new System.Drawing.Point(10, 13);
            this.lblWorkerType.Name = "lblWorkerType";
            this.lblWorkerType.Size = new System.Drawing.Size(69, 13);
            this.lblWorkerType.TabIndex = 88;
            this.lblWorkerType.Text = "Worker Type";
            // 
            // tbxWorkerID
            // 
            this.tbxWorkerID.Enabled = false;
            this.tbxWorkerID.Location = new System.Drawing.Point(125, 37);
            this.tbxWorkerID.Name = "tbxWorkerID";
            this.tbxWorkerID.Size = new System.Drawing.Size(135, 20);
            this.tbxWorkerID.TabIndex = 89;
            this.tbxWorkerID.TextChanged += new System.EventHandler(this.tbxWorkerID_TextChanged);
            // 
            // frmAddNewWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 421);
            this.Controls.Add(this.tbxWorkerID);
            this.Controls.Add(this.lblWorkerType);
            this.Controls.Add(this.cmbWorkerType);
            this.Controls.Add(this.lblPasswordMaching);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.tbxContactNumber);
            this.Controls.Add(this.lblempID);
            this.Controls.Add(this.nudYear);
            this.Controls.Add(this.dudMonth);
            this.Controls.Add(this.nudDate);
            this.Controls.Add(this.tbxAddress);
            this.Controls.Add(this.tbxConfirmPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbxLastName);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxNIC);
            this.Controls.Add(this.tbxACNumber);
            this.Controls.Add(this.tbxFirstName);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblACNumber);
            this.Controls.Add(this.lblContactNumber);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblNICNumber);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnAddWorker);
            this.Name = "frmAddNewWorker";
            this.Text = "Add New Worker";
            this.Load += new System.EventHandler(this.frmAddNewWorker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddWorker;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.MaskedTextBox tbxContactNumber;
        private System.Windows.Forms.Label lblempID;
        private System.Windows.Forms.NumericUpDown nudYear;
        private System.Windows.Forms.DomainUpDown dudMonth;
        private System.Windows.Forms.NumericUpDown nudDate;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.TextBox tbxConfirmPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxNIC;
        private System.Windows.Forms.TextBox tbxACNumber;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblACNumber;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblNICNumber;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblPasswordMaching;
        private System.Windows.Forms.ComboBox cmbWorkerType;
        private System.Windows.Forms.Label lblWorkerType;
        private System.Windows.Forms.TextBox tbxWorkerID;
    }
}