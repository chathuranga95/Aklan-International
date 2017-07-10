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
    public partial class FrmAddItem : Form
    {
        public FrmAddItem()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmCreateOrder frmCreateOrder = (FrmCreateOrder)this.Owner;
            frmCreateOrder.addDgvRow(cmbType.Text, tbxUnitPrice.Text , mtbQty.Text,  tbxTotal.Text);
            mtbQty.Clear();
            tbxTotal.Clear();
            tbxUnitPrice.Clear();
            cmbType.Text = null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
