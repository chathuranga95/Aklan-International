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
            CreateNewOrder.FrmCreateOrder createrOrderFrm = CreateNewOrder.FrmCreateOrder.getInstance();
            createrOrderFrm.Show();
            createrOrderFrm.BringToFront();
        }

        private void btnSetJobRates_Click(object sender, EventArgs e)
        {
            frmSetJobRates obj = frmSetJobRates.getInstance();
            obj.Show();
            obj.BringToFront();
        }

        private void btnCreateSalesOrder_Click(object sender, EventArgs e)
        {
            MaterialUpdate mtup = new MaterialUpdate(empID);
            int[] matArr = mtup.retrieveMaterial();

            if (matArr[3] > 0 || matArr[4] > 0)
            {
                frmNewSalesRecord obj = frmNewSalesRecord.getInstance(empID);
                obj.Show();
                obj.BringToFront();
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
            FrmSetUnitPrice obj =  FrmSetUnitPrice.getInstance();
            obj.Show();
            obj.BringToFront();
        }



        private void btnViewNotif_Click(object sender, EventArgs e)
        {
            frmNotification obj = frmNotification.getInstance();
            obj.Show();
            obj.BringToFront();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            
            frmChangePassword obj = frmChangePassword.getInstance(adminName);
            obj.Show();
            obj.BringToFront();
            
        }

        private void frmAdminWindow_Load(object sender, EventArgs e)
        {
            btnAdmin.PerformClick();
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(this.btnViewNotif, "View incoming Notifications");
            toolTip.SetToolTip(this.btnChangePass, "Change own Login Password");
            toolTip.SetToolTip(this.btnCreateOrder, "Create a New Order");
            toolTip.SetToolTip(this.btnCreateSalesOrder, "Add a Sales record");
            toolTip.SetToolTip(this.btnManageOrder, "View Onging Orders, Set finished Orders");
            toolTip.SetToolTip(this.btnManageStock, "Add Materials to the Stock");
            toolTip.SetToolTip(this.btnManageWorkers, "Add, Edit, Delete the Employers");
            toolTip.SetToolTip(this.btnOrders, "View Order Category Controllers");
            toolTip.SetToolTip(this.btnSales, "View Sales Category Controllers");
            toolTip.SetToolTip(this.btnSetJobRates, "Edit the Rates for Jobs");
            toolTip.SetToolTip(this.btnSetUnitPrice, "Edit item Selling prices");
            toolTip.SetToolTip(this.btnStock, "View Stock Category Controllers");
            toolTip.SetToolTip(this.btnViewOrders, "View Current Orders");
            toolTip.SetToolTip(this.btnViewSales, "View Sales Records");
            toolTip.SetToolTip(this.btnViewWorkers, "View Employer Details");
            toolTip.SetToolTip(this.btnWork, "View Work/Employer Category Controllers");
            toolTip.SetToolTip(this.btnAdmin, "View Admin Category Controllers");
            toolTip.SetToolTip(this.btnViewStock, "View current Stock status");
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            frmOrderReport obj = frmOrderReport.getInstance();
            obj.Show();
            obj.BringToFront();
        }

        private void btnManageOrder_Click(object sender, EventArgs e)
        {
            frmManageOrders obj = frmManageOrders.getInstance(empID);
            obj.Show();
            obj.BringToFront();
        }

        private void btnViewStock_Click(object sender, EventArgs e)
        {
            frmStockReport obj = frmStockReport.getInstance();
            obj.Show();
            obj.BringToFront();
        }

        private void btnViewSales_Click(object sender, EventArgs e)
        {
            frmSalesReport obj = frmSalesReport.getInstance();
            obj.Show();
            obj.BringToFront();
        }

        private void btnViewWorkers_Click(object sender, EventArgs e)
        {
            frmWorkerReport obj = frmWorkerReport.getInstance();
            obj.Show();
            obj.BringToFront();
        }

        private void btnManageWorkers_Click(object sender, EventArgs e)
        {
            frmManageWorkers obj = frmManageWorkers.getInstance();
            obj.Show();
            obj.BringToFront();
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

        private void btnViewPayroll_Click(object sender, EventArgs e)
        {
            frmSalaryView frmSalary = frmSalaryView.getInstance();
            frmSalary.Show();
            frmSalary.BringToFront();
        }
    }
}
