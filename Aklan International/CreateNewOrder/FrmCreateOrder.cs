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
            tbxCustomerName.Clear();
            tbxNIC.Clear();
            tbxContactNumber.Clear();
            tbxMail.Clear();

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            using (FrmAddItem frmAddItem = new FrmAddItem())
                frmAddItem.ShowDialog(this);
        }

        private void tbxCustomerName_TextChanged(object sender, EventArgs e)
        {
            if(tbxCustomerName.Text.Length > 0 && tbxContactNumber.Text.Length > 0 && tbxNIC.Text.Length > 0)
            {
                btnCreateOrder.Enabled = true;
            }
        }

        private void tbxNIC_TextChanged(object sender, EventArgs e)
        {
            if (tbxCustomerName.Text.Length > 0 && tbxContactNumber.Text.Length > 0 && tbxNIC.Text.Length > 0)
            {
                btnCreateOrder.Enabled = true;
            }

        }

        private void tbxContactNumber_TextChanged(object sender, EventArgs e)
        {
            if (tbxCustomerName.Text.Length > 0 && tbxContactNumber.Text.Length > 0 && tbxNIC.Text.Length > 0)
            {
                btnCreateOrder.Enabled = true;
            }
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Create new order for\nCustomer : " + tbxCustomerName.Text + "\nNIC : " + tbxNIC.Text, "Create Order", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)== DialogResult.OK)
            {
                dgvItems.Enabled = true;
                MessageBox.Show("Add Items and submit the order!", "", MessageBoxButtons.OK,MessageBoxIcon.Information);
                btnAddItem.Enabled = true;
            }

        }

        public void addDgvRow(String stripType, String unitPrice, String qty, String totalAmount)
        {
            DataGridViewRow row = (DataGridViewRow) dgvItems.Rows[0].Clone() ;
            row.Cells[0].Value = stripType;
            row.Cells[1].Value = unitPrice;
            row.Cells[2].Value = qty;
            row.Cells[3].Value = totalAmount;
            dgvItems.Rows.Add(row);
        }
            
    }
}
