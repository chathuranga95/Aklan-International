﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aklan_International
{
    public partial class frmAdminWindow : Form
    {
        string empID;
        string adminName;
        public frmAdminWindow()
        {
            InitializeComponent();
        }
        public frmAdminWindow(string adminName, string empID)
        {
            InitializeComponent();
            this.Text = adminName + " - Admin Mode";
            this.adminName = adminName;
            this.empID = empID;
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            CreateNewOrder.FrmCreateOrder createrOrderFrm = new CreateNewOrder.FrmCreateOrder();
            createrOrderFrm.Show();
        }

        private void btnSetJobRates_Click(object sender, EventArgs e)
        {
            frmSetJobRates obj = new frmSetJobRates();
            obj.Show(); 
        }

        private void btnCreateSalesOrder_Click(object sender, EventArgs e)
        {
            frmNewSalesRecord obj = new frmNewSalesRecord();
            obj.Show();
        }

        private void btnManageStock_Click(object sender, EventArgs e)
        {
            frmManageStock obj = new frmManageStock(empID);
            obj.Show();
        }

        private void btnSetUnitPrice_Click(object sender, EventArgs e)
        {
            FrmSetUnitPrice obj = new FrmSetUnitPrice();
            obj.Show();
        }

        

        private void btnViewNotif_Click(object sender, EventArgs e)
        {

        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            frmChangePassword obj = new frmChangePassword(adminName);
            obj.Show();
        }

        private void frmAdminWindow_Load(object sender, EventArgs e)
        {

        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {

        }

        private void btnManageOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnViewStock_Click(object sender, EventArgs e)
        {

        }

        private void btnViewSales_Click(object sender, EventArgs e)
        {

        }

        private void btnViewWorkers_Click(object sender, EventArgs e)
        {

        }

        private void btnManageWorkers_Click(object sender, EventArgs e)
        {

        }
    }
}
