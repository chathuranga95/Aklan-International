namespace Aklan_International
{
    partial class frmAdminWindow
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.btnManageOrder = new System.Windows.Forms.Button();
            this.btnViewOrders = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCreateSalesOrder = new System.Windows.Forms.Button();
            this.btnViewSales = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSetUnitPrice = new System.Windows.Forms.Button();
            this.btnManageStock = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSetJobRates = new System.Windows.Forms.Button();
            this.btnManageWorkers = new System.Windows.Forms.Button();
            this.btnViewWorkers = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCreateOrder);
            this.groupBox1.Controls.Add(this.btnManageOrder);
            this.groupBox1.Controls.Add(this.btnViewOrders);
            this.groupBox1.Location = new System.Drawing.Point(28, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 122);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Orders";
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Location = new System.Drawing.Point(183, 33);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(85, 37);
            this.btnCreateOrder.TabIndex = 1;
            this.btnCreateOrder.Text = "Create Order";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // btnManageOrder
            // 
            this.btnManageOrder.Location = new System.Drawing.Point(344, 33);
            this.btnManageOrder.Name = "btnManageOrder";
            this.btnManageOrder.Size = new System.Drawing.Size(85, 37);
            this.btnManageOrder.TabIndex = 1;
            this.btnManageOrder.Text = "Manage Orders";
            this.btnManageOrder.UseVisualStyleBackColor = true;
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.Location = new System.Drawing.Point(16, 34);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.Size = new System.Drawing.Size(85, 37);
            this.btnViewOrders.TabIndex = 0;
            this.btnViewOrders.Text = "View Orders";
            this.btnViewOrders.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCreateSalesOrder);
            this.groupBox2.Controls.Add(this.btnViewSales);
            this.groupBox2.Location = new System.Drawing.Point(28, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(577, 122);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sales";
            // 
            // btnCreateSalesOrder
            // 
            this.btnCreateSalesOrder.Location = new System.Drawing.Point(166, 39);
            this.btnCreateSalesOrder.Name = "btnCreateSalesOrder";
            this.btnCreateSalesOrder.Size = new System.Drawing.Size(85, 38);
            this.btnCreateSalesOrder.TabIndex = 1;
            this.btnCreateSalesOrder.Text = "Create Sales orders";
            this.btnCreateSalesOrder.UseVisualStyleBackColor = true;
            this.btnCreateSalesOrder.Click += new System.EventHandler(this.btnCreateSalesOrder_Click);
            // 
            // btnViewSales
            // 
            this.btnViewSales.Location = new System.Drawing.Point(16, 39);
            this.btnViewSales.Name = "btnViewSales";
            this.btnViewSales.Size = new System.Drawing.Size(85, 38);
            this.btnViewSales.TabIndex = 2;
            this.btnViewSales.Text = "View Sales Orders";
            this.btnViewSales.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSetUnitPrice);
            this.groupBox3.Controls.Add(this.btnManageStock);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Location = new System.Drawing.Point(28, 140);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(577, 122);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Stock";
            // 
            // btnSetUnitPrice
            // 
            this.btnSetUnitPrice.Location = new System.Drawing.Point(313, 41);
            this.btnSetUnitPrice.Name = "btnSetUnitPrice";
            this.btnSetUnitPrice.Size = new System.Drawing.Size(85, 38);
            this.btnSetUnitPrice.TabIndex = 1;
            this.btnSetUnitPrice.Text = "Set Unit Plrices";
            this.btnSetUnitPrice.UseVisualStyleBackColor = true;
            this.btnSetUnitPrice.Click += new System.EventHandler(this.btnSetUnitPrice_Click);
            // 
            // btnManageStock
            // 
            this.btnManageStock.Location = new System.Drawing.Point(166, 41);
            this.btnManageStock.Name = "btnManageStock";
            this.btnManageStock.Size = new System.Drawing.Size(85, 38);
            this.btnManageStock.TabIndex = 0;
            this.btnManageStock.Text = "Manage Stock";
            this.btnManageStock.UseVisualStyleBackColor = true;
            this.btnManageStock.Click += new System.EventHandler(this.btnManageStock_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 38);
            this.button2.TabIndex = 0;
            this.button2.Text = "View Stock";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSetJobRates);
            this.groupBox4.Controls.Add(this.btnManageWorkers);
            this.groupBox4.Controls.Add(this.btnViewWorkers);
            this.groupBox4.Location = new System.Drawing.Point(28, 396);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(577, 122);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Work";
            // 
            // btnSetJobRates
            // 
            this.btnSetJobRates.Location = new System.Drawing.Point(313, 47);
            this.btnSetJobRates.Name = "btnSetJobRates";
            this.btnSetJobRates.Size = new System.Drawing.Size(85, 38);
            this.btnSetJobRates.TabIndex = 2;
            this.btnSetJobRates.Text = "Set Job Rates";
            this.btnSetJobRates.UseVisualStyleBackColor = true;
            this.btnSetJobRates.Click += new System.EventHandler(this.btnSetJobRates_Click);
            // 
            // btnManageWorkers
            // 
            this.btnManageWorkers.Location = new System.Drawing.Point(166, 47);
            this.btnManageWorkers.Name = "btnManageWorkers";
            this.btnManageWorkers.Size = new System.Drawing.Size(85, 38);
            this.btnManageWorkers.TabIndex = 3;
            this.btnManageWorkers.Text = "Manage Workers";
            this.btnManageWorkers.UseVisualStyleBackColor = true;
            // 
            // btnViewWorkers
            // 
            this.btnViewWorkers.Location = new System.Drawing.Point(16, 47);
            this.btnViewWorkers.Name = "btnViewWorkers";
            this.btnViewWorkers.Size = new System.Drawing.Size(85, 38);
            this.btnViewWorkers.TabIndex = 4;
            this.btnViewWorkers.Text = "View Workers";
            this.btnViewWorkers.UseVisualStyleBackColor = true;
            // 
            // frmAdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 543);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAdminWindow";
            this.Text = "Admin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnManageOrder;
        private System.Windows.Forms.Button btnViewOrders;
        private System.Windows.Forms.Button btnManageStock;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCreateSalesOrder;
        private System.Windows.Forms.Button btnViewSales;
        private System.Windows.Forms.Button btnManageWorkers;
        private System.Windows.Forms.Button btnViewWorkers;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.Button btnSetUnitPrice;
        private System.Windows.Forms.Button btnSetJobRates;
    }
}