namespace Aklan_International.CreateOrder
{
    partial class FrmAddItem
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
            this.lblItemType = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.cmbStripeType = new System.Windows.Forms.ComboBox();
            this.tbxQty = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.tbxUnitPrice = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.tbTotalAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblItemType
            // 
            this.lblItemType.AutoSize = true;
            this.lblItemType.Location = new System.Drawing.Point(16, 37);
            this.lblItemType.Name = "lblItemType";
            this.lblItemType.Size = new System.Drawing.Size(61, 13);
            this.lblItemType.TabIndex = 0;
            this.lblItemType.Text = "Stripe Type";
            this.lblItemType.Click += new System.EventHandler(this.lblItemType_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(16, 128);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 1;
            this.lblQuantity.Text = "Quantity";
            this.lblQuantity.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmbStripeType
            // 
            this.cmbStripeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStripeType.FormattingEnabled = true;
            this.cmbStripeType.Items.AddRange(new object[] {
            "Single Sheet",
            "Dozen Sheets"});
            this.cmbStripeType.Location = new System.Drawing.Point(101, 34);
            this.cmbStripeType.Name = "cmbStripeType";
            this.cmbStripeType.Size = new System.Drawing.Size(250, 21);
            this.cmbStripeType.TabIndex = 2;
            // 
            // tbxQty
            // 
            this.tbxQty.Location = new System.Drawing.Point(101, 121);
            this.tbxQty.Name = "tbxQty";
            this.tbxQty.Size = new System.Drawing.Size(250, 20);
            this.tbxQty.TabIndex = 3;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(16, 84);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(53, 13);
            this.lblUnitPrice.TabIndex = 4;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // tbxUnitPrice
            // 
            this.tbxUnitPrice.Location = new System.Drawing.Point(101, 81);
            this.tbxUnitPrice.Name = "tbxUnitPrice";
            this.tbxUnitPrice.Size = new System.Drawing.Size(250, 20);
            this.tbxUnitPrice.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(19, 215);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(276, 215);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(16, 171);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(70, 13);
            this.lblTotalAmount.TabIndex = 8;
            this.lblTotalAmount.Text = "Total Amount";
            // 
            // tbTotalAmount
            // 
            this.tbTotalAmount.Location = new System.Drawing.Point(101, 163);
            this.tbTotalAmount.Name = "tbTotalAmount";
            this.tbTotalAmount.Size = new System.Drawing.Size(250, 20);
            this.tbTotalAmount.TabIndex = 9;
            // 
            // FrmAddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 250);
            this.Controls.Add(this.tbTotalAmount);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbxUnitPrice);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.tbxQty);
            this.Controls.Add(this.cmbStripeType);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblItemType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddItem";
            this.ShowInTaskbar = false;
            this.Text = "Add Item";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblItemType;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.ComboBox cmbStripeType;
        private System.Windows.Forms.TextBox tbxQty;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.TextBox tbxUnitPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.TextBox tbTotalAmount;
    }
}