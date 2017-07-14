namespace Aklan_International.CreateNewOrder
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
            this.lblSripeType = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.tbxUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxTotal = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.mtbQty = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblSripeType
            // 
            this.lblSripeType.AutoSize = true;
            this.lblSripeType.Location = new System.Drawing.Point(12, 28);
            this.lblSripeType.Name = "lblSripeType";
            this.lblSripeType.Size = new System.Drawing.Size(55, 13);
            this.lblSripeType.TabIndex = 0;
            this.lblSripeType.Text = "Strip Type";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(12, 60);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(53, 13);
            this.lblUnitPrice.TabIndex = 1;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(12, 92);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(46, 13);
            this.lblQty.TabIndex = 2;
            this.lblQty.Text = "Quantity";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(12, 127);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(70, 13);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total Amount";
            // 
            // cmbType
            // 
            this.cmbType.AllowDrop = true;
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Single Sheet Strip",
            "Dozen Sheets Strip"});
            this.cmbType.Location = new System.Drawing.Point(124, 25);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(299, 21);
            this.cmbType.TabIndex = 1;
            // 
            // tbxUnitPrice
            // 
            this.tbxUnitPrice.Location = new System.Drawing.Point(124, 57);
            this.tbxUnitPrice.Name = "tbxUnitPrice";
            this.tbxUnitPrice.ReadOnly = true;
            this.tbxUnitPrice.Size = new System.Drawing.Size(299, 20);
            this.tbxUnitPrice.TabIndex = 5;
            // 
            // tbxTotal
            // 
            this.tbxTotal.Location = new System.Drawing.Point(124, 124);
            this.tbxTotal.Name = "tbxTotal";
            this.tbxTotal.ReadOnly = true;
            this.tbxTotal.Size = new System.Drawing.Size(299, 20);
            this.tbxTotal.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(15, 175);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add item";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(348, 175);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // mtbQty
            // 
            this.mtbQty.Location = new System.Drawing.Point(124, 89);
            this.mtbQty.Mask = "000000";
            this.mtbQty.Name = "mtbQty";
            this.mtbQty.PromptChar = ' ';
            this.mtbQty.Size = new System.Drawing.Size(299, 20);
            this.mtbQty.TabIndex = 2;
            this.mtbQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FrmAddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 216);
            this.Controls.Add(this.mtbQty);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbxTotal);
            this.Controls.Add(this.tbxUnitPrice);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.lblSripeType);
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

        private System.Windows.Forms.Label lblSripeType;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.TextBox tbxUnitPrice;
        private System.Windows.Forms.TextBox tbxTotal;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.MaskedTextBox mtbQty;
    }
}