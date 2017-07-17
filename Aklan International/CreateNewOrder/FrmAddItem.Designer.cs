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
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSripeType
            // 
            this.lblSripeType.AutoSize = true;
            this.lblSripeType.BackColor = System.Drawing.Color.Transparent;
            this.lblSripeType.Location = new System.Drawing.Point(30, 28);
            this.lblSripeType.Name = "lblSripeType";
            this.lblSripeType.Size = new System.Drawing.Size(55, 13);
            this.lblSripeType.TabIndex = 0;
            this.lblSripeType.Text = "Strip Type";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblUnitPrice.Location = new System.Drawing.Point(30, 61);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(53, 13);
            this.lblUnitPrice.TabIndex = 1;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.BackColor = System.Drawing.Color.Transparent;
            this.lblQty.Location = new System.Drawing.Point(30, 94);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(46, 13);
            this.lblQty.TabIndex = 2;
            this.lblQty.Text = "Quantity";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Location = new System.Drawing.Point(30, 127);
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
            "12 Sheets Strip"});
            this.cmbType.Location = new System.Drawing.Point(139, 25);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(299, 21);
            this.cmbType.TabIndex = 1;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // tbxUnitPrice
            // 
            this.tbxUnitPrice.BackColor = System.Drawing.Color.White;
            this.tbxUnitPrice.Location = new System.Drawing.Point(139, 58);
            this.tbxUnitPrice.Name = "tbxUnitPrice";
            this.tbxUnitPrice.ReadOnly = true;
            this.tbxUnitPrice.Size = new System.Drawing.Size(299, 20);
            this.tbxUnitPrice.TabIndex = 0;
            this.tbxUnitPrice.TabStop = false;
            this.tbxUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbxUnitPrice.TextChanged += new System.EventHandler(this.tbxUnitPrice_TextChanged);
            // 
            // tbxTotal
            // 
            this.tbxTotal.BackColor = System.Drawing.Color.White;
            this.tbxTotal.Location = new System.Drawing.Point(139, 122);
            this.tbxTotal.Name = "tbxTotal";
            this.tbxTotal.ReadOnly = true;
            this.tbxTotal.Size = new System.Drawing.Size(299, 20);
            this.tbxTotal.TabIndex = 0;
            this.tbxTotal.TabStop = false;
            this.tbxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(30, 175);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Tag = "";
            this.btnAdd.Text = "Add item";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(282, 175);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "Clear";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // mtbQty
            // 
            this.mtbQty.Enabled = false;
            this.mtbQty.Location = new System.Drawing.Point(139, 90);
            this.mtbQty.Mask = "000000";
            this.mtbQty.Name = "mtbQty";
            this.mtbQty.PromptChar = ' ';
            this.mtbQty.Size = new System.Drawing.Size(299, 20);
            this.mtbQty.TabIndex = 2;
            this.mtbQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtbQty.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbQty_MaskInputRejected);
            this.mtbQty.TextChanged += new System.EventHandler(this.mtbQty_TextChanged);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(363, 175);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmAddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aklan_International.Properties.Resources.Admin_Window_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(464, 221);
            this.Controls.Add(this.btnClose);
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
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddItem";
            this.ShowInTaskbar = false;
            this.Text = "Add Item";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmAddItem_Load);
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
        private System.Windows.Forms.Button btnClose;
    }
}