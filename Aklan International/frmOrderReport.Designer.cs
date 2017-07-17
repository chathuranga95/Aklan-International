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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdReport = new System.Windows.Forms.DataGridView();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.panelOrderReport = new System.Windows.Forms.Panel();
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
            ((System.ComponentModel.ISupportInitialize)(this.grdReport)).BeginInit();
            this.panelOrderReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdReport
            // 
            this.grdReport.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.grdReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdReport.Location = new System.Drawing.Point(0, 0);
            this.grdReport.Name = "grdReport";
            this.grdReport.Size = new System.Drawing.Size(1019, 216);
            this.grdReport.TabIndex = 0;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.BackColor = System.Drawing.Color.White;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(904, 234);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(127, 43);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Save and Open with Excel";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // panelOrderReport
            // 
            this.panelOrderReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOrderReport.Controls.Add(this.grdReport);
            this.panelOrderReport.Location = new System.Drawing.Point(12, 12);
            this.panelOrderReport.Name = "panelOrderReport";
            this.panelOrderReport.Size = new System.Drawing.Size(1019, 216);
            this.panelOrderReport.TabIndex = 2;
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
            this.Customer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
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
            this.SingleQty.Width = 80;
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
            this.DozenQty.Width = 80;
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
            // frmOrderReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aklan_International.Properties.Resources.Admin_Window_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1043, 289);
            this.Controls.Add(this.panelOrderReport);
            this.Controls.Add(this.btnGenerate);
            this.DoubleBuffered = true;
            this.MinimizeBox = false;
            this.Name = "frmOrderReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Order Report";
            this.Load += new System.EventHandler(this.frmOrderReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdReport)).EndInit();
            this.panelOrderReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdReport;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Panel panelOrderReport;
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
    }
}