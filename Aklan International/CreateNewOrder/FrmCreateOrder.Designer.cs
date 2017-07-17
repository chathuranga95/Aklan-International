namespace Aklan_International.CreateNewOrder
{
    partial class FrmCreateOrder
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
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblNIC = new System.Windows.Forms.Label();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.tbxCustomerName = new System.Windows.Forms.TextBox();
            this.tbxNIC = new System.Windows.Forms.TextBox();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalAmonut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnSubmitOrder = new System.Windows.Forms.Button();
            this.mtbContactNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.tbxTotal = new System.Windows.Forms.TextBox();
            this.lblDecription = new System.Windows.Forms.Label();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.lblAomuntPaying = new System.Windows.Forms.Label();
            this.tbxAmountPaying = new System.Windows.Forms.TextBox();
            this.tbxAmountRemain = new System.Windows.Forms.TextBox();
            this.lblAmountRemaining = new System.Windows.Forms.Label();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerName.Location = new System.Drawing.Point(12, 12);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(82, 13);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // lblNIC
            // 
            this.lblNIC.AutoSize = true;
            this.lblNIC.BackColor = System.Drawing.Color.Transparent;
            this.lblNIC.Location = new System.Drawing.Point(251, 46);
            this.lblNIC.Name = "lblNIC";
            this.lblNIC.Size = new System.Drawing.Size(65, 13);
            this.lblNIC.TabIndex = 1;
            this.lblNIC.Text = "NIC Number";
            this.lblNIC.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblContactNumber.Location = new System.Drawing.Point(12, 46);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(84, 13);
            this.lblContactNumber.TabIndex = 2;
            this.lblContactNumber.Text = "Contact Number";
            // 
            // tbxCustomerName
            // 
            this.tbxCustomerName.Location = new System.Drawing.Point(112, 9);
            this.tbxCustomerName.Name = "tbxCustomerName";
            this.tbxCustomerName.Size = new System.Drawing.Size(316, 20);
            this.tbxCustomerName.TabIndex = 4;
            this.tbxCustomerName.TextChanged += new System.EventHandler(this.tbxCustomerName_TextChanged);
            // 
            // tbxNIC
            // 
            this.tbxNIC.Location = new System.Drawing.Point(322, 43);
            this.tbxNIC.Name = "tbxNIC";
            this.tbxNIC.Size = new System.Drawing.Size(105, 20);
            this.tbxNIC.TabIndex = 6;
            this.tbxNIC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxNIC.TextChanged += new System.EventHandler(this.tbxNIC_TextChanged);
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.BackColor = System.Drawing.Color.White;
            this.btnCreateOrder.Enabled = false;
            this.btnCreateOrder.Location = new System.Drawing.Point(14, 123);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(75, 23);
            this.btnCreateOrder.TabIndex = 8;
            this.btnCreateOrder.Text = "Create Order";
            this.btnCreateOrder.UseVisualStyleBackColor = false;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(336, 123);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 23);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AllowUserToResizeColumns = false;
            this.dgvItems.AllowUserToResizeRows = false;
            this.dgvItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colType,
            this.colUnitPrice,
            this.colQty,
            this.colTotalAmonut});
            this.dgvItems.Enabled = false;
            this.dgvItems.Location = new System.Drawing.Point(15, 152);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvItems.RowHeadersVisible = false;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(413, 142);
            this.dgvItems.TabIndex = 0;
            this.dgvItems.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvItems_RowsAdded);
            this.dgvItems.SelectionChanged += new System.EventHandler(this.dgvItems_SelectionChanged);
            // 
            // colType
            // 
            this.colType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colType.HeaderText = "Strip Type";
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.HeaderText = "Unit Price";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.ReadOnly = true;
            this.colUnitPrice.Width = 80;
            // 
            // colQty
            // 
            this.colQty.HeaderText = "Quantity";
            this.colQty.Name = "colQty";
            this.colQty.ReadOnly = true;
            this.colQty.Width = 60;
            // 
            // colTotalAmonut
            // 
            this.colTotalAmonut.HeaderText = "Full Amount";
            this.colTotalAmonut.Name = "colTotalAmonut";
            this.colTotalAmonut.ReadOnly = true;
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.White;
            this.btnAddItem.Enabled = false;
            this.btnAddItem.Location = new System.Drawing.Point(14, 405);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 23);
            this.btnAddItem.TabIndex = 9;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.BackColor = System.Drawing.Color.White;
            this.btnRemoveItem.Enabled = false;
            this.btnRemoveItem.Location = new System.Drawing.Point(92, 405);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveItem.TabIndex = 0;
            this.btnRemoveItem.Text = "Remove";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnSubmitOrder
            // 
            this.btnSubmitOrder.BackColor = System.Drawing.Color.White;
            this.btnSubmitOrder.Enabled = false;
            this.btnSubmitOrder.Location = new System.Drawing.Point(352, 405);
            this.btnSubmitOrder.Name = "btnSubmitOrder";
            this.btnSubmitOrder.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitOrder.TabIndex = 11;
            this.btnSubmitOrder.Text = "Submit";
            this.btnSubmitOrder.UseVisualStyleBackColor = false;
            this.btnSubmitOrder.Click += new System.EventHandler(this.btnSubmitOrder_Click);
            // 
            // mtbContactNumber
            // 
            this.mtbContactNumber.Location = new System.Drawing.Point(112, 43);
            this.mtbContactNumber.Mask = "(999) 000-0000";
            this.mtbContactNumber.Name = "mtbContactNumber";
            this.mtbContactNumber.PromptChar = ' ';
            this.mtbContactNumber.Size = new System.Drawing.Size(110, 20);
            this.mtbContactNumber.TabIndex = 5;
            this.mtbContactNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbContactNumber.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbContactNumber_MaskInputRejected);
            this.mtbContactNumber.TextChanged += new System.EventHandler(this.mtbContactNumber_TextChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Location = new System.Drawing.Point(220, 303);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(70, 13);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "Total Amount";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // tbxTotal
            // 
            this.tbxTotal.BackColor = System.Drawing.Color.White;
            this.tbxTotal.Location = new System.Drawing.Point(323, 300);
            this.tbxTotal.Name = "tbxTotal";
            this.tbxTotal.ReadOnly = true;
            this.tbxTotal.Size = new System.Drawing.Size(105, 20);
            this.tbxTotal.TabIndex = 12;
            this.tbxTotal.TabStop = false;
            this.tbxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbxTotal.TextChanged += new System.EventHandler(this.tbxTotal_TextChanged);
            // 
            // lblDecription
            // 
            this.lblDecription.AutoSize = true;
            this.lblDecription.BackColor = System.Drawing.Color.Transparent;
            this.lblDecription.Location = new System.Drawing.Point(12, 72);
            this.lblDecription.Name = "lblDecription";
            this.lblDecription.Size = new System.Drawing.Size(89, 13);
            this.lblDecription.TabIndex = 13;
            this.lblDecription.Text = "Order Description";
            // 
            // tbxDescription
            // 
            this.tbxDescription.Location = new System.Drawing.Point(112, 69);
            this.tbxDescription.Multiline = true;
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(315, 48);
            this.tbxDescription.TabIndex = 7;
            this.tbxDescription.Text = " ";
            // 
            // lblAomuntPaying
            // 
            this.lblAomuntPaying.AutoSize = true;
            this.lblAomuntPaying.BackColor = System.Drawing.Color.Transparent;
            this.lblAomuntPaying.Location = new System.Drawing.Point(220, 329);
            this.lblAomuntPaying.Name = "lblAomuntPaying";
            this.lblAomuntPaying.Size = new System.Drawing.Size(78, 13);
            this.lblAomuntPaying.TabIndex = 14;
            this.lblAomuntPaying.Text = "Amount Paying";
            this.lblAomuntPaying.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbxAmountPaying
            // 
            this.tbxAmountPaying.HideSelection = false;
            this.tbxAmountPaying.Location = new System.Drawing.Point(323, 326);
            this.tbxAmountPaying.Name = "tbxAmountPaying";
            this.tbxAmountPaying.Size = new System.Drawing.Size(104, 20);
            this.tbxAmountPaying.TabIndex = 10;
            this.tbxAmountPaying.Text = "0.00";
            this.tbxAmountPaying.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbxAmountPaying.TextChanged += new System.EventHandler(this.tbxAmountPaying_TextChanged);
            // 
            // tbxAmountRemain
            // 
            this.tbxAmountRemain.BackColor = System.Drawing.Color.White;
            this.tbxAmountRemain.Location = new System.Drawing.Point(323, 352);
            this.tbxAmountRemain.Name = "tbxAmountRemain";
            this.tbxAmountRemain.ReadOnly = true;
            this.tbxAmountRemain.Size = new System.Drawing.Size(104, 20);
            this.tbxAmountRemain.TabIndex = 16;
            this.tbxAmountRemain.TabStop = false;
            this.tbxAmountRemain.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbxAmountRemain.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblAmountRemaining
            // 
            this.lblAmountRemaining.AutoSize = true;
            this.lblAmountRemaining.BackColor = System.Drawing.Color.Transparent;
            this.lblAmountRemaining.Location = new System.Drawing.Point(220, 355);
            this.lblAmountRemaining.Name = "lblAmountRemaining";
            this.lblAmountRemaining.Size = new System.Drawing.Size(96, 13);
            this.lblAmountRemaining.TabIndex = 17;
            this.lblAmountRemaining.Text = "Amount Remaining";
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.BackColor = System.Drawing.Color.White;
            this.btnCancelOrder.Enabled = false;
            this.btnCancelOrder.Location = new System.Drawing.Point(238, 123);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(92, 23);
            this.btnCancelOrder.TabIndex = 18;
            this.btnCancelOrder.TabStop = false;
            this.btnCancelOrder.Text = "Cancel Order";
            this.btnCancelOrder.UseVisualStyleBackColor = false;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            // 
            // FrmCreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aklan_International.Properties.Resources.Admin_Window_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(439, 440);
            this.Controls.Add(this.btnCancelOrder);
            this.Controls.Add(this.lblAmountRemaining);
            this.Controls.Add(this.tbxAmountRemain);
            this.Controls.Add(this.tbxAmountPaying);
            this.Controls.Add(this.lblAomuntPaying);
            this.Controls.Add(this.tbxDescription);
            this.Controls.Add(this.lblDecription);
            this.Controls.Add(this.tbxTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.mtbContactNumber);
            this.Controls.Add(this.btnSubmitOrder);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCreateOrder);
            this.Controls.Add(this.tbxNIC);
            this.Controls.Add(this.tbxCustomerName);
            this.Controls.Add(this.lblContactNumber);
            this.Controls.Add(this.lblNIC);
            this.Controls.Add(this.lblCustomerName);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCreateOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New Order";
            this.Load += new System.EventHandler(this.FrmCreateOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblNIC;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.TextBox tbxCustomerName;
        private System.Windows.Forms.TextBox tbxNIC;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnSubmitOrder;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.MaskedTextBox mtbContactNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalAmonut;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox tbxTotal;
        private System.Windows.Forms.Label lblDecription;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.Label lblAomuntPaying;
        private System.Windows.Forms.TextBox tbxAmountPaying;
        private System.Windows.Forms.TextBox tbxAmountRemain;
        private System.Windows.Forms.Label lblAmountRemaining;
        private System.Windows.Forms.Button btnCancelOrder;
    }
}