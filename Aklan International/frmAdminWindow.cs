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
            MaterialUpdate mtup = new MaterialUpdate(empID);
            int[] matArr = mtup.retrieveMaterial();

            if (matArr[3] > 0 || matArr[4] > 0)
            {
                frmNewSalesRecord obj = new frmNewSalesRecord();
                obj.Show();

            }
            else
            {
                MessageBox.Show("There is no any material in store.");
            }
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
            frmManageOrders obj = new frmManageOrders(empID);
            obj.Show();
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

        private void frmAdminWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            DialogResult dlgresult = MessageBox.Show("Are you sure to exit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dlgresult == DialogResult.Yes)
            {
                
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            gbAdmin.Enabled = true;

            gbOrders.Enabled = false;
            gbStock.Enabled = false;
            gbWork.Enabled = false;
            gbSales.Enabled = false;

        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            gbOrders.Enabled = true;

            gbAdmin.Enabled = false;
            gbStock.Enabled = false;
            gbWork.Enabled = false;
            gbSales.Enabled = false;
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            gbStock.Enabled = true;

            gbAdmin.Enabled = false;
            gbOrders.Enabled = false;
            gbWork.Enabled = false;
            gbSales.Enabled = false;
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            gbWork.Enabled = true;

            gbAdmin.Enabled = false;
            gbOrders.Enabled = false;
            gbStock.Enabled = false;
            gbSales.Enabled = false;
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            gbSales.Enabled = true;

            gbAdmin.Enabled = false;
            gbOrders.Enabled = false;
            gbStock.Enabled = false;
            gbWork.Enabled = false;

        }
    }
}
