using System;
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
        Image notSelectedButton = Aklan_International.Properties.Resources.adminWinButton5;
        Image selectedButton = Aklan_International.Properties.Resources.adminWinButtonSelect;
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
                frmNewSalesRecord obj = new frmNewSalesRecord(empID);
                obj.Show();

            }
            else
            {
                MessageBox.Show("There is no any material in store.","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
            frmNotification obj = new frmNotification();
            obj.Show();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            frmChangePassword obj = new frmChangePassword(adminName);
            obj.Show();
        }

        private void frmAdminWindow_Load(object sender, EventArgs e)
        {
            btnAdmin.PerformClick();
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            frmOrderReport obj = new Aklan_International.frmOrderReport();
            obj.Show();
        }

        private void btnManageOrder_Click(object sender, EventArgs e)
        {
            frmManageOrders obj = new frmManageOrders(empID);
            obj.Show();
        }

        private void btnViewStock_Click(object sender, EventArgs e)
        {
            frmStockReport obj = new Aklan_International.frmStockReport();
            obj.Show();
        }

        private void btnViewSales_Click(object sender, EventArgs e)
        {
            frmSalesReport obj = new Aklan_International.frmSalesReport();
            obj.Show();
        }

        private void btnViewWorkers_Click(object sender, EventArgs e)
        {
            frmWorkerReport obj = new Aklan_International.frmWorkerReport();
            obj.Show();
        }

        private void btnManageWorkers_Click(object sender, EventArgs e)
        {
            frmManageWorkers obj = new Aklan_International.frmManageWorkers();
            obj.Show();
        }

        private void frmAdminWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            DialogResult dlgresult = MessageBox.Show("Are you sure to exit?", "System Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
            btnAdmin.BackgroundImage = selectedButton;

            btnOrders.BackgroundImage = notSelectedButton;
            btnStock.BackgroundImage = notSelectedButton;
            btnSales.BackgroundImage = notSelectedButton;
            btnWork.BackgroundImage = notSelectedButton;

        
            gbAdmin.Enabled = true;

            gbOrders.Enabled = false;
            gbStock.Enabled = false;
            gbWork.Enabled = false;
            gbSales.Enabled = false;

            gbAdmin.Visible = true;

            gbOrders.Visible = false;
            gbStock.Visible = false;
            gbWork.Visible = false;
            gbSales.Visible = false;


        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            btnOrders.BackgroundImage = selectedButton;

            btnAdmin.BackgroundImage = notSelectedButton;
            btnStock.BackgroundImage = notSelectedButton;
            btnSales.BackgroundImage = notSelectedButton;
            btnWork.BackgroundImage = notSelectedButton;


            gbOrders.Enabled = true;

            gbAdmin.Enabled = false;
            gbStock.Enabled = false;
            gbWork.Enabled = false;
            gbSales.Enabled = false;

            gbOrders.Visible = true;

            gbAdmin.Visible = false;
            gbStock.Visible = false;
            gbWork.Visible = false;
            gbSales.Visible = false;

        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            btnStock.BackgroundImage = selectedButton;

            btnAdmin.BackgroundImage = notSelectedButton;
            btnOrders.BackgroundImage = notSelectedButton;
            btnSales.BackgroundImage = notSelectedButton;
            btnWork.BackgroundImage = notSelectedButton;

            gbStock.Enabled = true;

            gbAdmin.Enabled = false;
            gbOrders.Enabled = false;
            gbWork.Enabled = false;
            gbSales.Enabled = false;

            gbStock.Visible = true;

            gbAdmin.Visible = false;
            gbOrders.Visible = false;
            gbWork.Visible = false;
            gbSales.Visible = false;

        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            btnWork.BackgroundImage = selectedButton;

            btnAdmin.BackgroundImage = notSelectedButton;
            btnOrders.BackgroundImage = notSelectedButton;
            btnSales.BackgroundImage = notSelectedButton;
            btnStock.BackgroundImage = notSelectedButton;

            gbWork.Enabled = true;

            gbAdmin.Enabled = false;
            gbOrders.Enabled = false;
            gbStock.Enabled = false;
            gbSales.Enabled = false;

            gbWork.Visible = true;

            gbAdmin.Visible = false;
            gbOrders.Visible = false;
            gbStock.Visible = false;
            gbSales.Visible = false;
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            btnSales.BackgroundImage = selectedButton;

            btnAdmin.BackgroundImage = notSelectedButton;
            btnOrders.BackgroundImage = notSelectedButton;
            btnWork.BackgroundImage = notSelectedButton;
            btnStock.BackgroundImage = notSelectedButton;

            gbSales.Enabled = true;

            gbAdmin.Enabled = false;
            gbOrders.Enabled = false;
            gbStock.Enabled = false;
            gbWork.Enabled = false;

            gbSales.Visible = true;

            gbAdmin.Visible = false;
            gbOrders.Visible = false;
            gbStock.Visible = false;
            gbWork.Visible = false;

        }

        
    }
}
