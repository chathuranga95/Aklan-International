using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aklan_International.CreateOrder
{
    public partial class FrmAddItem : Form
    {
        public FrmAddItem()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblItemType_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmCreateOrder frmCreateOrder = (FrmCreateOrder)this.Owner;
            frmCreateOrder.addDgwRow(cmbStripeType.Text,tbxUnitPrice.Text ,mtbQty.Text, tbxTotalAmount.Text);
            mtbQty.Clear();
            tbxTotalAmount.Clear();
            tbxUnitPrice.Clear();
            cmbStripeType.Text = null;

        }

        private void tbxUnitPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxQty_TextChanged(object sender, EventArgs e)
        {

        }
        private void tbxQty_KeyPress(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }
    }
}
