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
            this.gbOrders = new System.Windows.Forms.GroupBox();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.btnManageOrder = new System.Windows.Forms.Button();
            this.btnViewOrders = new System.Windows.Forms.Button();
            this.gbSales = new System.Windows.Forms.GroupBox();
            this.btnCreateSalesOrder = new System.Windows.Forms.Button();
            this.btnViewSales = new System.Windows.Forms.Button();
            this.gbStock = new System.Windows.Forms.GroupBox();
            this.btnSetUnitPrice = new System.Windows.Forms.Button();
            this.btnManageStock = new System.Windows.Forms.Button();
            this.btnViewStock = new System.Windows.Forms.Button();
            this.gbWork = new System.Windows.Forms.GroupBox();
            this.btnSetJobRates = new System.Windows.Forms.Button();
            this.btnManageWorkers = new System.Windows.Forms.Button();
            this.btnViewWorkers = new System.Windows.Forms.Button();
            this.gbAdmin = new System.Windows.Forms.GroupBox();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.btnViewNotif = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnWork = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.gbOrders.SuspendLayout();
            this.gbSales.SuspendLayout();
            this.gbStock.SuspendLayout();
            this.gbWork.SuspendLayout();
            this.gbAdmin.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOrders
            // 
            this.gbOrders.Controls.Add(this.btnCreateOrder);
            this.gbOrders.Controls.Add(this.btnManageOrder);
            this.gbOrders.Controls.Add(this.btnViewOrders);
            this.gbOrders.Enabled = false;
            this.gbOrders.Location = new System.Drawing.Point(171, 108);
            this.gbOrders.Name = "gbOrders";
            this.gbOrders.Size = new System.Drawing.Size(600, 90);
            this.gbOrders.TabIndex = 0;
            this.gbOrders.TabStop = false;
            this.gbOrders.Text = "Orders";
            this.gbOrders.UseCompatibleTextRendering = true;
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Location = new System.Drawing.Point(269, 28);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(85, 37);
            this.btnCreateOrder.TabIndex = 1;
            this.btnCreateOrder.Text = "Create Order";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // btnManageOrder
            // 
            this.btnManageOrder.Location = new System.Drawing.Point(435, 28);
            this.btnManageOrder.Name = "btnManageOrder";
            this.btnManageOrder.Size = new System.Drawing.Size(85, 37);
            this.btnManageOrder.TabIndex = 1;
            this.btnManageOrder.Text = "Manage Orders";
            this.btnManageOrder.UseVisualStyleBackColor = true;
            this.btnManageOrder.Click += new System.EventHandler(this.btnManageOrder_Click);
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.Location = new System.Drawing.Point(103, 28);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.Size = new System.Drawing.Size(85, 37);
            this.btnViewOrders.TabIndex = 0;
            this.btnViewOrders.Text = "View Orders";
            this.btnViewOrders.UseVisualStyleBackColor = true;
            this.btnViewOrders.Click += new System.EventHandler(this.btnViewOrders_Click);
            // 
            // gbSales
            // 
            this.gbSales.Controls.Add(this.btnCreateSalesOrder);
            this.gbSales.Controls.Add(this.btnViewSales);
            this.gbSales.Enabled = false;
            this.gbSales.Location = new System.Drawing.Point(171, 396);
            this.gbSales.Name = "gbSales";
            this.gbSales.Size = new System.Drawing.Size(600, 90);
            this.gbSales.TabIndex = 1;
            this.gbSales.TabStop = false;
            this.gbSales.Text = "Sales";
            // 
            // btnCreateSalesOrder
            // 
            this.btnCreateSalesOrder.Location = new System.Drawing.Point(269, 30);
            this.btnCreateSalesOrder.Name = "btnCreateSalesOrder";
            this.btnCreateSalesOrder.Size = new System.Drawing.Size(85, 38);
            this.btnCreateSalesOrder.TabIndex = 1;
            this.btnCreateSalesOrder.Text = "Create Sales Record";
            this.btnCreateSalesOrder.UseVisualStyleBackColor = true;
            this.btnCreateSalesOrder.Click += new System.EventHandler(this.btnCreateSalesOrder_Click);
            // 
            // btnViewSales
            // 
            this.btnViewSales.Location = new System.Drawing.Point(103, 30);
            this.btnViewSales.Name = "btnViewSales";
            this.btnViewSales.Size = new System.Drawing.Size(85, 38);
            this.btnViewSales.TabIndex = 2;
            this.btnViewSales.Text = "View Sales Record";
            this.btnViewSales.UseVisualStyleBackColor = true;
            this.btnViewSales.Click += new System.EventHandler(this.btnViewSales_Click);
            // 
            // gbStock
            // 
            this.gbStock.Controls.Add(this.btnSetUnitPrice);
            this.gbStock.Controls.Add(this.btnManageStock);
            this.gbStock.Controls.Add(this.btnViewStock);
            this.gbStock.Enabled = false;
            this.gbStock.Location = new System.Drawing.Point(171, 204);
            this.gbStock.Name = "gbStock";
            this.gbStock.Size = new System.Drawing.Size(600, 90);
            this.gbStock.TabIndex = 1;
            this.gbStock.TabStop = false;
            this.gbStock.Text = "Stock";
            // 
            // btnSetUnitPrice
            // 
            this.btnSetUnitPrice.Location = new System.Drawing.Point(435, 31);
            this.btnSetUnitPrice.Name = "btnSetUnitPrice";
            this.btnSetUnitPrice.Size = new System.Drawing.Size(85, 38);
            this.btnSetUnitPrice.TabIndex = 1;
            this.btnSetUnitPrice.Text = "Set Unit Plrices";
            this.btnSetUnitPrice.UseVisualStyleBackColor = true;
            this.btnSetUnitPrice.Click += new System.EventHandler(this.btnSetUnitPrice_Click);
            // 
            // btnManageStock
            // 
            this.btnManageStock.Location = new System.Drawing.Point(269, 31);
            this.btnManageStock.Name = "btnManageStock";
            this.btnManageStock.Size = new System.Drawing.Size(85, 38);
            this.btnManageStock.TabIndex = 0;
            this.btnManageStock.Text = "Manage Stock";
            this.btnManageStock.UseVisualStyleBackColor = true;
            this.btnManageStock.Click += new System.EventHandler(this.btnManageStock_Click);
            // 
            // btnViewStock
            // 
            this.btnViewStock.Location = new System.Drawing.Point(103, 31);
            this.btnViewStock.Name = "btnViewStock";
            this.btnViewStock.Size = new System.Drawing.Size(85, 38);
            this.btnViewStock.TabIndex = 0;
            this.btnViewStock.Text = "View Stock";
            this.btnViewStock.UseVisualStyleBackColor = true;
            this.btnViewStock.Click += new System.EventHandler(this.btnViewStock_Click);
            // 
            // gbWork
            // 
            this.gbWork.Controls.Add(this.btnSetJobRates);
            this.gbWork.Controls.Add(this.btnManageWorkers);
            this.gbWork.Controls.Add(this.btnViewWorkers);
            this.gbWork.Enabled = false;
            this.gbWork.Location = new System.Drawing.Point(171, 300);
            this.gbWork.Name = "gbWork";
            this.gbWork.Size = new System.Drawing.Size(600, 90);
            this.gbWork.TabIndex = 2;
            this.gbWork.TabStop = false;
            this.gbWork.Text = "Work";
            // 
            // btnSetJobRates
            // 
            this.btnSetJobRates.Location = new System.Drawing.Point(435, 28);
            this.btnSetJobRates.Name = "btnSetJobRates";
            this.btnSetJobRates.Size = new System.Drawing.Size(85, 38);
            this.btnSetJobRates.TabIndex = 2;
            this.btnSetJobRates.Text = "Set Job Rates";
            this.btnSetJobRates.UseVisualStyleBackColor = true;
            this.btnSetJobRates.Click += new System.EventHandler(this.btnSetJobRates_Click);
            // 
            // btnManageWorkers
            // 
            this.btnManageWorkers.Location = new System.Drawing.Point(269, 28);
            this.btnManageWorkers.Name = "btnManageWorkers";
            this.btnManageWorkers.Size = new System.Drawing.Size(85, 38);
            this.btnManageWorkers.TabIndex = 3;
            this.btnManageWorkers.Text = "Manage Workers";
            this.btnManageWorkers.UseVisualStyleBackColor = true;
            this.btnManageWorkers.Click += new System.EventHandler(this.btnManageWorkers_Click);
            // 
            // btnViewWorkers
            // 
            this.btnViewWorkers.Location = new System.Drawing.Point(103, 28);
            this.btnViewWorkers.Name = "btnViewWorkers";
            this.btnViewWorkers.Size = new System.Drawing.Size(85, 38);
            this.btnViewWorkers.TabIndex = 4;
            this.btnViewWorkers.Text = "View Workers";
            this.btnViewWorkers.UseVisualStyleBackColor = true;
            this.btnViewWorkers.Click += new System.EventHandler(this.btnViewWorkers_Click);
            // 
            // gbAdmin
            // 
            this.gbAdmin.BackColor = System.Drawing.Color.White;
            this.gbAdmin.Controls.Add(this.btnChangePass);
            this.gbAdmin.Controls.Add(this.btnViewNotif);
            this.gbAdmin.Enabled = false;
            this.gbAdmin.Location = new System.Drawing.Point(171, 12);
            this.gbAdmin.Name = "gbAdmin";
            this.gbAdmin.Size = new System.Drawing.Size(600, 90);
            this.gbAdmin.TabIndex = 2;
            this.gbAdmin.TabStop = false;
            this.gbAdmin.Text = "Admin";
            // 
            // btnChangePass
            // 
            this.btnChangePass.Location = new System.Drawing.Point(269, 28);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(85, 37);
            this.btnChangePass.TabIndex = 1;
            this.btnChangePass.Text = "Change Password";
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // btnViewNotif
            // 
            this.btnViewNotif.Location = new System.Drawing.Point(103, 28);
            this.btnViewNotif.Name = "btnViewNotif";
            this.btnViewNotif.Size = new System.Drawing.Size(85, 37);
            this.btnViewNotif.TabIndex = 0;
            this.btnViewNotif.Text = "View Notifications";
            this.btnViewNotif.UseVisualStyleBackColor = true;
            this.btnViewNotif.Click += new System.EventHandler(this.btnViewNotif_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSales);
            this.panel1.Controls.Add(this.btnWork);
            this.panel1.Controls.Add(this.btnStock);
            this.panel1.Controls.Add(this.btnOrders);
            this.panel1.Controls.Add(this.btnAdmin);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 501);
            this.panel1.TabIndex = 3;
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(0, 12);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(165, 90);
            this.btnAdmin.TabIndex = 2;
            this.btnAdmin.Text = "Adimn";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(0, 108);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(165, 90);
            this.btnOrders.TabIndex = 3;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnStock
            // 
            this.btnStock.Location = new System.Drawing.Point(0, 204);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(165, 90);
            this.btnStock.TabIndex = 4;
            this.btnStock.Text = "Stock";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnWork
            // 
            this.btnWork.Location = new System.Drawing.Point(0, 300);
            this.btnWork.Name = "btnWork";
            this.btnWork.Size = new System.Drawing.Size(165, 90);
            this.btnWork.TabIndex = 5;
            this.btnWork.Text = "Work";
            this.btnWork.UseVisualStyleBackColor = true;
            this.btnWork.Click += new System.EventHandler(this.btnWork_Click);
            // 
            // btnSales
            // 
            this.btnSales.Location = new System.Drawing.Point(0, 396);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(165, 90);
            this.btnSales.TabIndex = 6;
            this.btnSales.Text = "Sales";
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // frmAdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 501);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbAdmin);
            this.Controls.Add(this.gbWork);
            this.Controls.Add(this.gbOrders);
            this.Controls.Add(this.gbSales);
            this.Controls.Add(this.gbStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAdminWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAdminWindow_FormClosing);
            this.Load += new System.EventHandler(this.frmAdminWindow_Load);
            this.gbOrders.ResumeLayout(false);
            this.gbSales.ResumeLayout(false);
            this.gbStock.ResumeLayout(false);
            this.gbWork.ResumeLayout(false);
            this.gbAdmin.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOrders;
        private System.Windows.Forms.GroupBox gbSales;
        private System.Windows.Forms.GroupBox gbStock;
        private System.Windows.Forms.GroupBox gbWork;
        private System.Windows.Forms.Button btnManageOrder;
        private System.Windows.Forms.Button btnViewOrders;
        private System.Windows.Forms.Button btnManageStock;
        private System.Windows.Forms.Button btnViewStock;
        private System.Windows.Forms.Button btnCreateSalesOrder;
        private System.Windows.Forms.Button btnViewSales;
        private System.Windows.Forms.Button btnManageWorkers;
        private System.Windows.Forms.Button btnViewWorkers;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.Button btnSetUnitPrice;
        private System.Windows.Forms.Button btnSetJobRates;
        private System.Windows.Forms.GroupBox gbAdmin;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Button btnViewNotif;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnWork;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnAdmin;
    }
}