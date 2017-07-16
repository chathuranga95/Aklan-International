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

namespace Aklan_International.CreateNewOrder
{
    public partial class FrmAddItem : Form
    {
        private MySqlConnection con;
        private MySqlCommand cmd;
        private MySqlDataReader reader;
        private decimal[] unitPrices = new decimal[2];

        public FrmAddItem()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=localhost;Database=dbcore;Uid=root;Pwd=1234");
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmCreateOrder frmCreateOrder = (FrmCreateOrder)this.Owner;
            frmCreateOrder.addDgvRow(cmbType.Text, tbxUnitPrice.Text , mtbQty.Text,  tbxTotal.Text);
            frmCreateOrder.addToTotal(tbxTotal.Text);
            
            mtbQty.Clear();
            tbxTotal.Clear();
            
            btnAdd.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mtbQty.Clear();
            tbxTotal.Clear();
            tbxUnitPrice.Clear();
            cmbType.Text = null;
            btnAdd.Enabled = false;
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(cmbType.Text == "Single Sheet Strip")
            {
                cmd = new MySqlCommand("select * from dtunitprices where TypeId ='1'", con);
                con.Open();
                reader = cmd.ExecuteReader();
                reader.Read();
                tbxUnitPrice.Text = reader.GetDecimal("UnitPrice").ToString();
                con.Close();
            }

            if (cmbType.Text == "12 Sheets Strip")
            {
                cmd = new MySqlCommand("select * from dtunitprices where TypeId ='2'", con);
                con.Open();
                reader = cmd.ExecuteReader();
                reader.Read();
                tbxUnitPrice.Text = reader.GetDecimal("UnitPrice").ToString();
                con.Close();
            }

            mtbQty.Enabled = true;



        }

        private void mtbQty_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //tbxTotal.Text = (int.Parse(mtbQty.Text)*decimal.Parse(tbxUnitPrice.Text)).ToString();
            //mtbQty.changed
        }

        private void tbxUnitPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void mtbQty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tbxTotal.Text = (int.Parse(mtbQty.Text) * decimal.Parse(tbxUnitPrice.Text)).ToString();
                btnAdd.Enabled = true;
            }catch (System.FormatException)
            {
                tbxTotal.Clear();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void FrmAddItem_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(this.btnAdd, "Add Item to the Order");
            toolTip.SetToolTip(this.btnCancel, "Clear components");
            toolTip.SetToolTip(this.btnClose, "Close this Form");
        }
    }
}
