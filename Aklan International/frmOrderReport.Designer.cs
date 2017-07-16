namespace Aklan_International
{
    partial class frmOrderReport
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
            this.grdReport = new System.Windows.Forms.DataGridView();
            this.OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SingleQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SheetUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DozenQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DozenUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenerate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdReport)).BeginInit();
            this.SuspendLayout();
            // 
            // grdReport
            // 
            this.grdReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderId,
            this.OrderDateTime,
            this.Customer,
            this.Tel,
            this.Description,
            this.SingleQty,
            this.SheetUnitPrice,
            this.DozenQty,
            this.DozenUnitPrice,
            this.Amount});
            this.grdReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.grdReport.Location = new System.Drawing.Point(0, 0);
            this.grdReport.Name = "grdReport";
            this.grdReport.Size = new System.Drawing.Size(1043, 150);
            this.grdReport.TabIndex = 0;
            // 
            // OrderId
            // 
            this.OrderId.HeaderText = "Order ID";
            this.OrderId.Name = "OrderId";
            this.OrderId.ReadOnly = true;
            // 
            // OrderDateTime
            // 
            this.OrderDateTime.HeaderText = "Date/Time";
            this.OrderDateTime.Name = "OrderDateTime";
            this.OrderDateTime.ReadOnly = true;
            // 
            // Customer
            // 
            this.Customer.HeaderText = "Customer";
            this.Customer.Name = "Customer";
            this.Customer.ReadOnly = true;
            // 
            // Tel
            // 
            this.Tel.HeaderText = "Tel";
            this.Tel.Name = "Tel";
            this.Tel.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // SingleQty
            // 
            this.SingleQty.HeaderText = "Single-Qty";
            this.SingleQty.Name = "SingleQty";
            this.SingleQty.ReadOnly = true;
            // 
            // SheetUnitPrice
            // 
            this.SheetUnitPrice.HeaderText = "Sheet-UnitPrice";
            this.SheetUnitPrice.Name = "SheetUnitPrice";
            this.SheetUnitPrice.ReadOnly = true;
            // 
            // DozenQty
            // 
            this.DozenQty.HeaderText = "12-Qty";
            this.DozenQty.Name = "DozenQty";
            this.DozenQty.ReadOnly = true;
            // 
            // DozenUnitPrice
            // 
            this.DozenUnitPrice.HeaderText = "12-UnitPrice";
            this.DozenUnitPrice.Name = "DozenUnitPrice";
            this.DozenUnitPrice.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(904, 198);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(127, 43);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Save and Open with Excel";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // frmOrderReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 289);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.grdReport);
            this.Name = "frmOrderReport";
            this.Text = "Order Report";
            this.Load += new System.EventHandler(this.frmOrderReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn SingleQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn SheetUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DozenQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn DozenUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.Button btnGenerate;
    }
}