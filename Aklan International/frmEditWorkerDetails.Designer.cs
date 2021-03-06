﻿namespace Aklan_International
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditWorkerDetails));
            this.nudYear = new System.Windows.Forms.NumericUpDown();
            this.dudMonth = new System.Windows.Forms.DomainUpDown();
            this.nudDate = new System.Windows.Forms.NumericUpDown();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnChangeDetails = new System.Windows.Forms.Button();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
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
            this.lblempID = new System.Windows.Forms.Label();
            this.tbxContactNumber = new System.Windows.Forms.MaskedTextBox();
            this.tbxNIC = new System.Windows.Forms.TextBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.lblWorkerType = new System.Windows.Forms.Label();
            this.tbxWorkerID = new System.Windows.Forms.TextBox();
            this.tbxWorkerType = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDate)).BeginInit();
            this.SuspendLayout();
            // 
            // nudYear
            // 
            this.nudYear.BackColor = System.Drawing.Color.White;
            this.nudYear.Location = new System.Drawing.Point(258, 276);
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
            this.nudYear.Size = new System.Drawing.Size(53, 20);
            this.nudYear.TabIndex = 11;
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
            this.dudMonth.BackColor = System.Drawing.Color.White;
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
            this.dudMonth.Location = new System.Drawing.Point(202, 276);
            this.dudMonth.Name = "dudMonth";
            this.dudMonth.ReadOnly = true;
            this.dudMonth.Size = new System.Drawing.Size(45, 20);
            this.dudMonth.TabIndex = 10;
            this.dudMonth.Text = "Jan";
            this.dudMonth.SelectedItemChanged += new System.EventHandler(this.dudMonth_SelectedItemChanged);
            // 
            // nudDate
            // 
            this.nudDate.BackColor = System.Drawing.Color.White;
            this.nudDate.Location = new System.Drawing.Point(153, 276);
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
            this.nudDate.Size = new System.Drawing.Size(38, 20);
            this.nudDate.TabIndex = 9;
            this.nudDate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(127, 191);
            this.tbxAddress.Multiline = true;
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(185, 79);
            this.tbxAddress.TabIndex = 8;
            this.tbxAddress.TextChanged += new System.EventHandler(this.tbxAddress_TextChanged);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.Location = new System.Drawing.Point(13, 167);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 49;
            this.lblGender.Text = "Gender";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(237, 386);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnChangeDetails
            // 
            this.btnChangeDetails.BackColor = System.Drawing.Color.White;
            this.btnChangeDetails.Location = new System.Drawing.Point(16, 386);
            this.btnChangeDetails.Name = "btnChangeDetails";
            this.btnChangeDetails.Size = new System.Drawing.Size(88, 23);
            this.btnChangeDetails.TabIndex = 14;
            this.btnChangeDetails.Text = "Change Details";
            this.btnChangeDetails.UseVisualStyleBackColor = false;
            this.btnChangeDetails.Click += new System.EventHandler(this.btnAddWorker_Click);
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(127, 86);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(188, 20);
            this.tbxLastName.TabIndex = 3;
            this.tbxLastName.TextChanged += new System.EventHandler(this.tbxLastName_TextChanged);
            this.tbxLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxLastName_KeyPress);
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(127, 112);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(188, 20);
            this.tbxPassword.TabIndex = 4;
            this.tbxPassword.TextChanged += new System.EventHandler(this.tbxPassword_TextChanged);
            this.tbxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPassword_KeyPress);
            // 
            // tbxACNumber
            // 
            this.tbxACNumber.Location = new System.Drawing.Point(127, 329);
            this.tbxACNumber.Name = "tbxACNumber";
            this.tbxACNumber.Size = new System.Drawing.Size(188, 20);
            this.tbxACNumber.TabIndex = 13;
            this.tbxACNumber.TextChanged += new System.EventHandler(this.tbxACNumber_TextChanged);
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(127, 60);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(188, 20);
            this.tbxFirstName.TabIndex = 2;
            this.tbxFirstName.TextChanged += new System.EventHandler(this.tbxFirstName_TextChanged);
            this.tbxFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxFirstName_KeyPress);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Location = new System.Drawing.Point(13, 191);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 43;
            this.lblAddress.Text = "Address";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Location = new System.Drawing.Point(13, 116);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 42;
            this.lblPassword.Text = "Password";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.Location = new System.Drawing.Point(13, 90);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 37;
            this.lblLastName.Text = "Last Name";
            // 
            // lblACNumber
            // 
            this.lblACNumber.AutoSize = true;
            this.lblACNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblACNumber.Location = new System.Drawing.Point(13, 333);
            this.lblACNumber.Name = "lblACNumber";
            this.lblACNumber.Size = new System.Drawing.Size(115, 13);
            this.lblACNumber.TabIndex = 35;
            this.lblACNumber.Text = "Bank Account Number";
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblContactNumber.Location = new System.Drawing.Point(13, 307);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(84, 13);
            this.lblContactNumber.TabIndex = 33;
            this.lblContactNumber.Text = "Contact Number";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.BackColor = System.Drawing.Color.Transparent;
            this.lblDOB.Location = new System.Drawing.Point(13, 280);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(66, 13);
            this.lblDOB.TabIndex = 31;
            this.lblDOB.Text = "Date of Birth";
            // 
            // lblNICNumber
            // 
            this.lblNICNumber.AutoSize = true;
            this.lblNICNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblNICNumber.Location = new System.Drawing.Point(13, 142);
            this.lblNICNumber.Name = "lblNICNumber";
            this.lblNICNumber.Size = new System.Drawing.Size(65, 13);
            this.lblNICNumber.TabIndex = 30;
            this.lblNICNumber.Text = "NIC Number";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.Location = new System.Drawing.Point(13, 64);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 28;
            this.lblFirstName.Text = "First Name";
            // 
            // lblempID
            // 
            this.lblempID.AutoSize = true;
            this.lblempID.BackColor = System.Drawing.Color.Transparent;
            this.lblempID.Location = new System.Drawing.Point(13, 11);
            this.lblempID.Name = "lblempID";
            this.lblempID.Size = new System.Drawing.Size(56, 13);
            this.lblempID.TabIndex = 54;
            this.lblempID.Text = "Worker ID";
            // 
            // tbxContactNumber
            // 
            this.tbxContactNumber.Location = new System.Drawing.Point(127, 303);
            this.tbxContactNumber.Mask = "(999) 000-0000";
            this.tbxContactNumber.Name = "tbxContactNumber";
            this.tbxContactNumber.PromptChar = ' ';
            this.tbxContactNumber.Size = new System.Drawing.Size(188, 20);
            this.tbxContactNumber.TabIndex = 12;
            this.tbxContactNumber.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.tbxContactNumber_MaskInputRejected);
            // 
            // tbxNIC
            // 
            this.tbxNIC.Location = new System.Drawing.Point(127, 138);
            this.tbxNIC.Name = "tbxNIC";
            this.tbxNIC.Size = new System.Drawing.Size(188, 20);
            this.tbxNIC.TabIndex = 5;
            this.tbxNIC.TextChanged += new System.EventHandler(this.tbxNIC_TextChanged);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.BackColor = System.Drawing.Color.Transparent;
            this.rbMale.Location = new System.Drawing.Point(143, 165);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 6;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = false;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.BackColor = System.Drawing.Color.Transparent;
            this.rbFemale.Location = new System.Drawing.Point(237, 165);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 7;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = false;
            // 
            // lblWorkerType
            // 
            this.lblWorkerType.AutoSize = true;
            this.lblWorkerType.BackColor = System.Drawing.Color.Transparent;
            this.lblWorkerType.Location = new System.Drawing.Point(13, 38);
            this.lblWorkerType.Name = "lblWorkerType";
            this.lblWorkerType.Size = new System.Drawing.Size(69, 13);
            this.lblWorkerType.TabIndex = 58;
            this.lblWorkerType.Text = "Worker Type";
            // 
            // tbxWorkerID
            // 
            this.tbxWorkerID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbxWorkerID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbxWorkerID.Location = new System.Drawing.Point(127, 7);
            this.tbxWorkerID.Name = "tbxWorkerID";
            this.tbxWorkerID.Size = new System.Drawing.Size(64, 20);
            this.tbxWorkerID.TabIndex = 1;
            this.tbxWorkerID.TextChanged += new System.EventHandler(this.tbxWorkerID_TextChanged);
            // 
            // tbxWorkerType
            // 
            this.tbxWorkerType.Enabled = false;
            this.tbxWorkerType.Location = new System.Drawing.Point(127, 34);
            this.tbxWorkerType.Name = "tbxWorkerType";
            this.tbxWorkerType.Size = new System.Drawing.Size(188, 20);
            this.tbxWorkerType.TabIndex = 60;
            this.tbxWorkerType.TextChanged += new System.EventHandler(this.tbxWorkerType_TextChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.ForeColor = System.Drawing.Color.Crimson;
            this.lblStatus.Location = new System.Drawing.Point(199, 10);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(35, 13);
            this.lblStatus.TabIndex = 61;
            this.lblStatus.Text = "label1";
            // 
            // frmEditWorkerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(324, 421);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.tbxWorkerType);
            this.Controls.Add(this.tbxWorkerID);
            this.Controls.Add(this.lblWorkerType);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.tbxContactNumber);
            this.Controls.Add(this.lblempID);
            this.Controls.Add(this.nudYear);
            this.Controls.Add(this.dudMonth);
            this.Controls.Add(this.nudDate);
            this.Controls.Add(this.tbxAddress);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChangeDetails);
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
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditWorkerDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Worker Details";
            this.Load += new System.EventHandler(this.frmEditWorkerDetails_Load);
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
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnChangeDetails;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxPassword;
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
        private System.Windows.Forms.Label lblempID;
        private System.Windows.Forms.MaskedTextBox tbxContactNumber;
        private System.Windows.Forms.TextBox tbxNIC;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Label lblWorkerType;
        private System.Windows.Forms.TextBox tbxWorkerID;
        private System.Windows.Forms.TextBox tbxWorkerType;
        private System.Windows.Forms.Label lblStatus;
    }
}