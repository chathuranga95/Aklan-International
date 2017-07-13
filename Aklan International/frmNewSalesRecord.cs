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
    public partial class frmNewSalesRecord : Form
    {
        public frmNewSalesRecord()
        {
            InitializeComponent();
            btnAdd.Enabled = false;
        }
        public void btnAddState()
        {
            if(tbxCustName.Text.Length>0 &&
               tbxNic.Text.Length == 10 && 
               cmbType.Text !=""&&
               tbxQty.Text.Length>0 &&
               tbxUprice.Text.Length > 0)
            {
                if(tbxNic.Text.Substring(9) == "V" || tbxNic.Text.Substring(9) == "v")
                {
                    btnAdd.Enabled = true;
                }
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTel_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(tbxUprice.Text) * Convert.ToInt32(tbxQty.Text);
            grd.Rows.Add(cmbType.Text, tbxQty.Text, tbxUprice.Text, amount);
            cmbType.Text = "";
            tbxQty.Text = "";
            tbxUprice.Text = "";
        }

        private void tbxCustName_TextChanged(object sender, EventArgs e)
        {
            btnAddState();
        }

        private void cmbType_TextChanged(object sender, EventArgs e)
        {
            btnAddState();
        }

        private void tbxQty_TextChanged(object sender, EventArgs e)
        {
            btnAddState();
        }

        private void tbxUprice_TextChanged(object sender, EventArgs e)
        {
            btnAddState();
        }

        private void tbxNic_TextChanged_1(object sender, EventArgs e)
        {
            btnAddState();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (this.grd.SelectedRows.Count > 0)
            {
               grd.Rows.RemoveAt(this.grd.SelectedRows[0].Index);
            }
        }
    }
}
