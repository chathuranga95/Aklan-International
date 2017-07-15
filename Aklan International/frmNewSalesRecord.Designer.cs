namespace Aklan_International
{
    partial class frmNewSalesRecord
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
            this.lblCustName = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.tbxCustName = new System.Windows.Forms.TextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxQty = new System.Windows.Forms.MaskedTextBox();
            this.tbxUprice = new System.Windows.Forms.MaskedTextBox();
            this.tbxTel = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grd = new System.Windows.Forms.DataGridView();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tbxNic = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(12, 6);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(82, 13);
            this.lblCustName.TabIndex = 0;
            this.lblCustName.Text = "Customer Name";
            this.lblCustName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(12, 32);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(39, 13);
            this.lblTel.TabIndex = 1;
            this.lblTel.Text = "Tel No";
            this.lblTel.Click += new System.EventHandler(this.lblTel_Click);
            // 
            // tbxCustName
            // 
            this.tbxCustName.Location = new System.Drawing.Point(131, 6);
            this.tbxCustName.Name = "tbxCustName";
            this.tbxCustName.Size = new System.Drawing.Size(194, 20);
            this.tbxCustName.TabIndex = 2;
            this.tbxCustName.TextChanged += new System.EventHandler(this.tbxCustName_TextChanged);
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Single",
            "12 sheets"});
            this.cmbType.Location = new System.Drawing.Point(130, 58);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(121, 21);
            this.cmbType.TabIndex = 4;
            this.cmbType.TextChanged += new System.EventHandler(this.cmbType_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Qty";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Unit Price";
            // 
            // tbxQty
            // 
            this.tbxQty.Location = new System.Drawing.Point(130, 85);
            this.tbxQty.Mask = "00000";
            this.tbxQty.Name = "tbxQty";
            this.tbxQty.Size = new System.Drawing.Size(100, 20);
            this.tbxQty.TabIndex = 11;
            this.tbxQty.ValidatingType = typeof(int);
            this.tbxQty.TextChanged += new System.EventHandler(this.tbxQty_TextChanged);
            // 
            // tbxUprice
            // 
            this.tbxUprice.Location = new System.Drawing.Point(130, 111);
            this.tbxUprice.Mask = "00000";
            this.tbxUprice.Name = "tbxUprice";
            this.tbxUprice.Size = new System.Drawing.Size(100, 20);
            this.tbxUprice.TabIndex = 12;
            this.tbxUprice.ValidatingType = typeof(int);
            this.tbxUprice.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            this.tbxUprice.TextChanged += new System.EventHandler(this.tbxUprice_TextChanged);
            // 
            // tbxTel
            // 
            this.tbxTel.Location = new System.Drawing.Point(130, 32);
            this.tbxTel.Mask = "(999) 000-0000";
            this.tbxTel.Name = "tbxTel";
            this.tbxTel.Size = new System.Drawing.Size(195, 20);
            this.tbxTel.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(355, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "NIC No";
            // 
            // grd
            // 
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.Qty,
            this.Unit_Price,
            this.Amount});
            this.grd.Location = new System.Drawing.Point(6, 213);
            this.grd.Name = "grd";
            this.grd.Size = new System.Drawing.Size(443, 95);
            this.grd.TabIndex = 14;
            this.grd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Qty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Unit_Price
            // 
            this.Unit_Price.HeaderText = "Unit Price";
            this.Unit_Price.Name = "Unit_Price";
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(15, 152);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(374, 152);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(374, 348);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 20;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // tbxNic
            // 
            this.tbxNic.Location = new System.Drawing.Point(424, 8);
            this.tbxNic.Name = "tbxNic";
            this.tbxNic.Size = new System.Drawing.Size(148, 20);
            this.tbxNic.TabIndex = 21;
            this.tbxNic.TextChanged += new System.EventHandler(this.tbxNic_TextChanged_1);
            // 
            // frmNewSalesRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 404);
            this.Controls.Add(this.tbxNic);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grd);
            this.Controls.Add(this.tbxTel);
            this.Controls.Add(this.tbxUprice);
            this.Controls.Add(this.tbxQty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.tbxCustName);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblCustName);
            this.Name = "frmNewSalesRecord";
            this.Text = "New Sales Record";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNewSalesRecord_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox tbxCustName;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox tbxQty;
        private System.Windows.Forms.MaskedTextBox tbxUprice;
        private System.Windows.Forms.MaskedTextBox tbxTel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView grd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.TextBox tbxNic;
    }
}