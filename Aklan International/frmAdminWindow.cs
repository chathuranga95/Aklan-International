using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Aklan_International
{
    public partial class frmAdminWindow : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader reader;
        public frmAdminWindow()
        {
            InitializeComponent();
        }
        public frmAdminWindow(string adminName)
        {
            InitializeComponent();
            this.Text = adminName;
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
           MaterialUpdate mtup = new MaterialUpdate(emp)

            frmNewSalesRecord obj = new frmNewSalesRecord();
            obj.Show();
        }
    }
}
