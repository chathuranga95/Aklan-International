﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Aklan_International.CreateNewOrder
{
    public partial class FrmCreateOrder : Form
    {
        private Order customerOrder;
        private decimal singleUnitPrice = 0;
        private decimal dozenUnitPrice =0;
        private int singleSheeetQty = 0;
        private int dozenSheetQty = 0;

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
            mtbContactNumber.Clear();
            
            btnCreateOrder.Enabled = false;

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            using (FrmAddItem frmAddItem = new FrmAddItem())
                frmAddItem.ShowDialog(this);
        }

        private void tbxCustomerName_TextChanged(object sender, EventArgs e)
        {
            if(tbxCustomerName.Text.Length > 0 && mtbContactNumber.MaskCompleted && tbxNIC.Text.Length > 0)
            {
                btnCreateOrder.Enabled = true;
            }
        }

        private void mtbContactNumber_TextChanged(object sender, EventArgs e)
        {
            if (tbxCustomerName.Text.Length > 0 && mtbContactNumber.MaskCompleted && tbxNIC.Text.Length > 0)
                btnCreateOrder.Enabled = true;
        }

        private void tbxNIC_TextChanged(object sender, EventArgs e)
        {
            if (tbxCustomerName.Text.Length > 0 && mtbContactNumber.MaskCompleted && tbxNIC.Text.Length > 0)
            {
                btnCreateOrder.Enabled = true;
            }

        }

        

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Create new order for\nCustomer : " + tbxCustomerName.Text + "\nNIC : " + tbxNIC.Text, "Create Order", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                String NIC = tbxNIC.Text;
                if (isValidNIC(NIC))
                {
                    
                    dgvItems.Enabled = true;
                    btnAddItem.Enabled = true;
                    MessageBox.Show("Add Items and submit the order!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Invalid NIC Number!","",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    
                }
            
            }
            Console.WriteLine(DateTime.Now.ToString());
            Console.WriteLine(Support.getMaxVlaueFrom("OrderId", "dtcustomer_orders"));
                
        }

        public void addDgvRow(String stripType, String unitPrice, String qty, String totalAmount)
        {
            if (stripType == "Single Sheet Strip")
            {
                this.singleUnitPrice = decimal.Parse(unitPrice);
                this.singleSheeetQty = this.singleSheeetQty + int.Parse(qty);
            }
            else if (stripType == "12 Sheets Strip")
            {
                this.dozenUnitPrice = decimal.Parse(unitPrice);
                this.dozenSheetQty = this.dozenSheetQty + int.Parse(qty);
            }

            DataGridViewRow row = (DataGridViewRow) dgvItems.Rows[0].Clone() ;
            row.Cells[0].Value = stripType;
            row.Cells[1].Value = unitPrice;
            row.Cells[2].Value = qty;
            row.Cells[3].Value = totalAmount;
            dgvItems.Rows.Add(row);

            
        }

        private bool isValidNIC(String NIC)
        {
            if (NIC.Length == 9 && Support.isNumeric(NIC))
                return true;
            else if (NIC.Length == 10 && Support.isNumeric(NIC.Substring(0, 9)))
            {
                if (NIC.Substring(9, 1) == "v" || NIC.Substring(9, 1) == "V" || NIC.Substring(9, 1) == "x" || NIC.Substring(9, 1) == "X")
                    return true;
                else return false;
            }
            else return false;
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = dgvItems.SelectedRows;
            foreach (DataGridViewRow row in rows)
            {
                subFromTotal(row.Cells[3].Value.ToString());
                dgvItems.Rows.Remove(row);
            }
        }

        private void dgvItems_SelectionChanged(object sender, EventArgs e)
        {            
            Console.WriteLine("Selected index = "+dgvItems.SelectedRows[0].Index);
            if (dgvItems.SelectedRows[0].Cells[0].Value == null)
                btnRemoveItem.Enabled = false;
            else btnRemoveItem.Enabled = true;
        }

        private void dgvItems_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dgvItems.SelectedRows[0].Cells[0].Value == null)
                btnSubmitOrder.Enabled = false;
        }

        

        private void mtbContactNumber_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dgvItems_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            btnSubmitOrder.Enabled = true;
            
        }

        public void addToTotal(String itemTotal)
        {
            if (tbxTotal.Text.Length > 0)
            {
                decimal newTotal = decimal.Parse(tbxTotal.Text) + decimal.Parse(itemTotal);
                tbxTotal.Text = newTotal.ToString();
               
            }

            else
                tbxTotal.Text = itemTotal;

        }

        public void subFromTotal (String itemTotal)
        {
            decimal newTotal = decimal.Parse(tbxTotal.Text) - decimal.Parse(itemTotal);
            tbxTotal.Text = newTotal.ToString();
        }

        private void btnSubmitOrder_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirm Submit Order?","Confirm!",MessageBoxButtons.YesNo , MessageBoxIcon.Question)== DialogResult.Yes)
            {

                customerOrder = new Order(Support.getMaxVlaueFrom("OrderId", "dtcustomer_orders")+1, tbxNIC.Text, tbxCustomerName.Text, mtbContactNumber.Text, DateTime.Now, this.singleSheeetQty, this.singleUnitPrice, this.dozenSheetQty, this.dozenUnitPrice,  decimal.Parse(tbxAmountPaying.Text), tbxDescription.Text);
                MySqlConnection con = Support.setConnection();
                
                MySqlCommand cmd = new MySqlCommand("INSERT INTO `dbcore`.`dtcustomer_orders` (`OrderId`, `OrderDateTime`, `CustomerId`, `CustomerName`, `CustomerContact`, `description`, `SingleSheetQty`, `SingleSheetUnit`, `DozenSheetQty`, `DozenSheetUnit`, `TotalPrice`, `AmountPaid`, `AmountRemaining`, `finished`) VALUES ('"+customerOrder.getOrderID()+"', '"+customerOrder.getDateTime()+"', '"+customerOrder.getCustomerId()+"', '"+customerOrder.getCustomerName()+"', '"+customerOrder.getCustomerContact()+"', '"+customerOrder.getDescription()+"', '"+customerOrder.getSingleQty()+"', '"+customerOrder.getSingleUnitPrice()+"', '"+customerOrder.getDozenQty()+"', '"+customerOrder.getDozenUnitPrice()+"', '"+customerOrder.getTotalPrice()+"', '"+customerOrder.getAmountPaid()+"', '"+customerOrder.getRemainingPrice()+"', 'No')",con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                this.Close();
            }
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxTotal_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tbxAmountRemain.Text = (decimal.Parse(tbxTotal.Text) - decimal.Parse(tbxAmountPaying.Text)).ToString();
            }
            catch (System.FormatException) { tbxAmountRemain.Text = tbxTotal.Text; }
        }

        private void tbxAmountPaying_TextChanged(object sender, EventArgs e)
        {
            if (Support.isNumeric(tbxAmountPaying.Text))
            {
                tbxAmountRemain.Text = (decimal.Parse(tbxTotal.Text) - decimal.Parse(tbxAmountPaying.Text)).ToString();
            }
            else
            {
                tbxAmountRemain.Text = tbxTotal.Text;
                tbxAmountPaying.Clear();
            }
        }
    }
}
