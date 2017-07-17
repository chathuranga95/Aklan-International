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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminWindow));
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
            this.btnViewPayroll = new System.Windows.Forms.Button();
            this.btnSetJobRates = new System.Windows.Forms.Button();
            this.btnManageWorkers = new System.Windows.Forms.Button();
            this.btnViewWorkers = new System.Windows.Forms.Button();
            this.gbAdmin = new System.Windows.Forms.GroupBox();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.btnViewNotif = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnWork = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
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
            this.gbOrders.BackColor = System.Drawing.Color.Transparent;
            this.gbOrders.Controls.Add(this.btnCreateOrder);
            this.gbOrders.Controls.Add(this.btnManageOrder);
            this.gbOrders.Controls.Add(this.btnViewOrders);
            this.gbOrders.Enabled = false;
            this.gbOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbOrders.Location = new System.Drawing.Point(171, 12);
            this.gbOrders.Name = "gbOrders";
            this.gbOrders.Size = new System.Drawing.Size(600, 396);
            this.gbOrders.TabIndex = 0;
            this.gbOrders.TabStop = false;
            this.gbOrders.UseCompatibleTextRendering = true;
            this.gbOrders.Visible = false;
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.BackColor = System.Drawing.Color.White;
            this.btnCreateOrder.BackgroundImage = global::Aklan_International.Properties.Resources.newOrder;
            this.btnCreateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateOrder.Location = new System.Drawing.Point(229, 28);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(140, 150);
            this.btnCreateOrder.TabIndex = 1;
            this.btnCreateOrder.Text = "Create Order";
            this.btnCreateOrder.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnCreateOrder.UseVisualStyleBackColor = false;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // btnManageOrder
            // 
            this.btnManageOrder.BackColor = System.Drawing.Color.White;
            this.btnManageOrder.BackgroundImage = global::Aklan_International.Properties.Resources.manageOrder;
            this.btnManageOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageOrder.Location = new System.Drawing.Point(411, 28);
            this.btnManageOrder.Name = "btnManageOrder";
            this.btnManageOrder.Size = new System.Drawing.Size(140, 150);
            this.btnManageOrder.TabIndex = 1;
            this.btnManageOrder.Text = "Manage Orders";
            this.btnManageOrder.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnManageOrder.UseVisualStyleBackColor = false;
            this.btnManageOrder.Click += new System.EventHandler(this.btnManageOrder_Click);
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.BackColor = System.Drawing.Color.White;
            this.btnViewOrders.BackgroundImage = global::Aklan_International.Properties.Resources.viewOrder;
            this.btnViewOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewOrders.Location = new System.Drawing.Point(47, 28);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.Size = new System.Drawing.Size(140, 150);
            this.btnViewOrders.TabIndex = 0;
            this.btnViewOrders.Text = "View Orders";
            this.btnViewOrders.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnViewOrders.UseVisualStyleBackColor = false;
            this.btnViewOrders.Click += new System.EventHandler(this.btnViewOrders_Click);
            // 
            // gbSales
            // 
            this.gbSales.BackColor = System.Drawing.Color.Transparent;
            this.gbSales.Controls.Add(this.btnCreateSalesOrder);
            this.gbSales.Controls.Add(this.btnViewSales);
            this.gbSales.Enabled = false;
            this.gbSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbSales.Location = new System.Drawing.Point(171, 12);
            this.gbSales.Name = "gbSales";
            this.gbSales.Size = new System.Drawing.Size(600, 396);
            this.gbSales.TabIndex = 1;
            this.gbSales.TabStop = false;
            this.gbSales.Visible = false;
            // 
            // btnCreateSalesOrder
            // 
            this.btnCreateSalesOrder.BackColor = System.Drawing.Color.White;
            this.btnCreateSalesOrder.BackgroundImage = global::Aklan_International.Properties.Resources.CreateSalesRec;
            this.btnCreateSalesOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateSalesOrder.Location = new System.Drawing.Point(325, 28);
            this.btnCreateSalesOrder.Name = "btnCreateSalesOrder";
            this.btnCreateSalesOrder.Size = new System.Drawing.Size(220, 150);
            this.btnCreateSalesOrder.TabIndex = 1;
            this.btnCreateSalesOrder.Text = "Create Sales Record";
            this.btnCreateSalesOrder.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnCreateSalesOrder.UseVisualStyleBackColor = false;
            this.btnCreateSalesOrder.Click += new System.EventHandler(this.btnCreateSalesOrder_Click);
            // 
            // btnViewSales
            // 
            this.btnViewSales.BackColor = System.Drawing.Color.White;
            this.btnViewSales.BackgroundImage = global::Aklan_International.Properties.Resources.ViewSalesREc;
            this.btnViewSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewSales.Location = new System.Drawing.Point(55, 28);
            this.btnViewSales.Name = "btnViewSales";
            this.btnViewSales.Size = new System.Drawing.Size(220, 150);
            this.btnViewSales.TabIndex = 2;
            this.btnViewSales.Text = "View Sales Record";
            this.btnViewSales.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnViewSales.UseVisualStyleBackColor = false;
            this.btnViewSales.Click += new System.EventHandler(this.btnViewSales_Click);
            // 
            // gbStock
            // 
            this.gbStock.BackColor = System.Drawing.Color.Transparent;
            this.gbStock.Controls.Add(this.btnSetUnitPrice);
            this.gbStock.Controls.Add(this.btnManageStock);
            this.gbStock.Controls.Add(this.btnViewStock);
            this.gbStock.Enabled = false;
            this.gbStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbStock.Location = new System.Drawing.Point(171, 12);
            this.gbStock.Name = "gbStock";
            this.gbStock.Size = new System.Drawing.Size(600, 396);
            this.gbStock.TabIndex = 1;
            this.gbStock.TabStop = false;
            this.gbStock.Visible = false;
            // 
            // btnSetUnitPrice
            // 
            this.btnSetUnitPrice.BackColor = System.Drawing.Color.White;
            this.btnSetUnitPrice.BackgroundImage = global::Aklan_International.Properties.Resources.SetUnitPrice;
            this.btnSetUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetUnitPrice.Location = new System.Drawing.Point(411, 28);
            this.btnSetUnitPrice.Name = "btnSetUnitPrice";
            this.btnSetUnitPrice.Size = new System.Drawing.Size(140, 150);
            this.btnSetUnitPrice.TabIndex = 1;
            this.btnSetUnitPrice.Text = "Set Unit Prices";
            this.btnSetUnitPrice.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSetUnitPrice.UseVisualStyleBackColor = false;
            this.btnSetUnitPrice.Click += new System.EventHandler(this.btnSetUnitPrice_Click);
            // 
            // btnManageStock
            // 
            this.btnManageStock.BackColor = System.Drawing.Color.White;
            this.btnManageStock.BackgroundImage = global::Aklan_International.Properties.Resources.manageOrder;
            this.btnManageStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageStock.Location = new System.Drawing.Point(229, 28);
            this.btnManageStock.Name = "btnManageStock";
            this.btnManageStock.Size = new System.Drawing.Size(140, 150);
            this.btnManageStock.TabIndex = 0;
            this.btnManageStock.Text = "Manage Stock";
            this.btnManageStock.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnManageStock.UseVisualStyleBackColor = false;
            this.btnManageStock.Click += new System.EventHandler(this.btnManageStock_Click);
            // 
            // btnViewStock
            // 
            this.btnViewStock.BackColor = System.Drawing.Color.White;
            this.btnViewStock.BackgroundImage = global::Aklan_International.Properties.Resources.viewOrder;
            this.btnViewStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewStock.Location = new System.Drawing.Point(47, 28);
            this.btnViewStock.Name = "btnViewStock";
            this.btnViewStock.Size = new System.Drawing.Size(140, 150);
            this.btnViewStock.TabIndex = 0;
            this.btnViewStock.Text = "View Stock";
            this.btnViewStock.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnViewStock.UseVisualStyleBackColor = false;
            this.btnViewStock.Click += new System.EventHandler(this.btnViewStock_Click);
            // 
            // gbWork
            // 
            this.gbWork.BackColor = System.Drawing.Color.Transparent;
            this.gbWork.Controls.Add(this.btnViewPayroll);
            this.gbWork.Controls.Add(this.btnSetJobRates);
            this.gbWork.Controls.Add(this.btnManageWorkers);
            this.gbWork.Controls.Add(this.btnViewWorkers);
            this.gbWork.Enabled = false;
            this.gbWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbWork.Location = new System.Drawing.Point(171, 6);
            this.gbWork.Name = "gbWork";
            this.gbWork.Size = new System.Drawing.Size(600, 402);
            this.gbWork.TabIndex = 2;
            this.gbWork.TabStop = false;
            this.gbWork.Visible = false;
            // 
            // btnViewPayroll
            // 
            this.btnViewPayroll.BackColor = System.Drawing.Color.White;
            this.btnViewPayroll.BackgroundImage = global::Aklan_International.Properties.Resources.Payroll;
            this.btnViewPayroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewPayroll.Location = new System.Drawing.Point(456, 28);
            this.btnViewPayroll.Name = "btnViewPayroll";
            this.btnViewPayroll.Size = new System.Drawing.Size(120, 150);
            this.btnViewPayroll.TabIndex = 5;
            this.btnViewPayroll.Text = "View Payroll";
            this.btnViewPayroll.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnViewPayroll.UseVisualStyleBackColor = false;
            this.btnViewPayroll.Click += new System.EventHandler(this.btnViewPayroll_Click);
            // 
            // btnSetJobRates
            // 
            this.btnSetJobRates.BackColor = System.Drawing.Color.White;
            this.btnSetJobRates.BackgroundImage = global::Aklan_International.Properties.Resources.setJobRates;
            this.btnSetJobRates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetJobRates.Location = new System.Drawing.Point(313, 28);
            this.btnSetJobRates.Name = "btnSetJobRates";
            this.btnSetJobRates.Size = new System.Drawing.Size(120, 150);
            this.btnSetJobRates.TabIndex = 2;
            this.btnSetJobRates.Text = "Set Job Rates";
            this.btnSetJobRates.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSetJobRates.UseVisualStyleBackColor = false;
            this.btnSetJobRates.Click += new System.EventHandler(this.btnSetJobRates_Click);
            // 
            // btnManageWorkers
            // 
            this.btnManageWorkers.BackColor = System.Drawing.Color.White;
            this.btnManageWorkers.BackgroundImage = global::Aklan_International.Properties.Resources.ManageWorker;
            this.btnManageWorkers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageWorkers.Location = new System.Drawing.Point(170, 28);
            this.btnManageWorkers.Name = "btnManageWorkers";
            this.btnManageWorkers.Size = new System.Drawing.Size(120, 150);
            this.btnManageWorkers.TabIndex = 3;
            this.btnManageWorkers.Text = "Manage Workers";
            this.btnManageWorkers.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnManageWorkers.UseVisualStyleBackColor = false;
            this.btnManageWorkers.Click += new System.EventHandler(this.btnManageWorkers_Click);
            // 
            // btnViewWorkers
            // 
            this.btnViewWorkers.BackColor = System.Drawing.Color.White;
            this.btnViewWorkers.BackgroundImage = global::Aklan_International.Properties.Resources.viewworker;
            this.btnViewWorkers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewWorkers.Location = new System.Drawing.Point(27, 28);
            this.btnViewWorkers.Name = "btnViewWorkers";
            this.btnViewWorkers.Size = new System.Drawing.Size(120, 150);
            this.btnViewWorkers.TabIndex = 4;
            this.btnViewWorkers.Text = "View Workers";
            this.btnViewWorkers.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnViewWorkers.UseVisualStyleBackColor = false;
            this.btnViewWorkers.Click += new System.EventHandler(this.btnViewWorkers_Click);
            // 
            // gbAdmin
            // 
            this.gbAdmin.BackColor = System.Drawing.Color.Transparent;
            this.gbAdmin.Controls.Add(this.btnChangePass);
            this.gbAdmin.Controls.Add(this.btnViewNotif);
            this.gbAdmin.Enabled = false;
            this.gbAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbAdmin.Location = new System.Drawing.Point(171, 12);
            this.gbAdmin.Margin = new System.Windows.Forms.Padding(0);
            this.gbAdmin.Name = "gbAdmin";
            this.gbAdmin.Size = new System.Drawing.Size(600, 396);
            this.gbAdmin.TabIndex = 2;
            this.gbAdmin.TabStop = false;
            this.gbAdmin.Visible = false;
            // 
            // btnChangePass
            // 
            this.btnChangePass.BackColor = System.Drawing.Color.White;
            this.btnChangePass.BackgroundImage = global::Aklan_International.Properties.Resources.Change_Pass;
            this.btnChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePass.Location = new System.Drawing.Point(325, 28);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(220, 150);
            this.btnChangePass.TabIndex = 1;
            this.btnChangePass.Text = "Change Password";
            this.btnChangePass.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnChangePass.UseVisualStyleBackColor = false;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // btnViewNotif
            // 
            this.btnViewNotif.BackColor = System.Drawing.Color.White;
            this.btnViewNotif.BackgroundImage = global::Aklan_International.Properties.Resources.ViewNotific1;
            this.btnViewNotif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewNotif.Location = new System.Drawing.Point(55, 28);
            this.btnViewNotif.Name = "btnViewNotif";
            this.btnViewNotif.Size = new System.Drawing.Size(220, 150);
            this.btnViewNotif.TabIndex = 0;
            this.btnViewNotif.Text = "View Notifications";
            this.btnViewNotif.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnViewNotif.UseVisualStyleBackColor = false;
            this.btnViewNotif.Click += new System.EventHandler(this.btnViewNotif_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnSales);
            this.panel1.Controls.Add(this.btnWork);
            this.panel1.Controls.Add(this.btnStock);
            this.panel1.Controls.Add(this.btnOrders);
            this.panel1.Controls.Add(this.btnAdmin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 441);
            this.panel1.TabIndex = 3;
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.Color.White;
            this.btnSales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSales.FlatAppearance.BorderSize = 0;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.Location = new System.Drawing.Point(0, 334);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(165, 74);
            this.btnSales.TabIndex = 6;
            this.btnSales.Text = "Sales";
            this.btnSales.UseVisualStyleBackColor = false;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnWork
            // 
            this.btnWork.BackColor = System.Drawing.Color.White;
            this.btnWork.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWork.FlatAppearance.BorderSize = 0;
            this.btnWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWork.Location = new System.Drawing.Point(0, 255);
            this.btnWork.Name = "btnWork";
            this.btnWork.Size = new System.Drawing.Size(165, 74);
            this.btnWork.TabIndex = 5;
            this.btnWork.Text = "Work";
            this.btnWork.UseVisualStyleBackColor = false;
            this.btnWork.Click += new System.EventHandler(this.btnWork_Click);
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.White;
            this.btnStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStock.FlatAppearance.BorderSize = 0;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.Location = new System.Drawing.Point(0, 176);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(165, 74);
            this.btnStock.TabIndex = 4;
            this.btnStock.Text = "Stock";
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.BackColor = System.Drawing.Color.White;
            this.btnOrders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrders.Location = new System.Drawing.Point(0, 97);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(165, 74);
            this.btnOrders.TabIndex = 3;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = false;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.White;
            this.btnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Location = new System.Drawing.Point(0, 18);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(165, 74);
            this.btnAdmin.TabIndex = 2;
            this.btnAdmin.Text = "Adimn";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // frmAdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Aklan_International.Properties.Resources.Admin_Window_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbStock);
            this.Controls.Add(this.gbAdmin);
            this.Controls.Add(this.gbWork);
            this.Controls.Add(this.gbOrders);
            this.Controls.Add(this.gbSales);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button btnViewPayroll;
    }
}