using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aklan_International.CreateNewOrder
{
    public partial class FrmCreateOrder : Form
    {
        public FrmCreateOrder()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            FrmAddItem frmAddItem = new FrmAddItem();
            frmAddItem.Show();
        }

        private void tbxCustomerName_TextChanged(object sender, EventArgs e)
        {
            if(tbxCustomerName.Text.Length > 0 && tbxContactNumber.Text.Length > 0 && tbxNIC.Text.Length > 0)
            {
                btnCreateOrder.Enabled = true;
            }
        }
    }
}
