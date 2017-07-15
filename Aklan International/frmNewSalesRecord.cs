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
        bool salesmanMode;
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader reader;
        public frmNewSalesRecord()
        {
            InitializeComponent();
            btnAdd.Enabled = false;
        }
        public frmNewSalesRecord(string salesmanName)
        {
            InitializeComponent();
            btnAdd.Enabled = false;
            this.Text = "New Sales Record : Salesman Mode - " + salesmanName;
            salesmanMode = true;
        }
        public void btnAddState()
        {
            if (tbxCustName.Text.Length > 0 &&
               tbxNic.Text.Length == 10 &&
               cmbType.Text != "" &&
               tbxQty.Text.Length > 0 &&
               tbxUprice.Text.Length > 0)
            {
                if (tbxNic.Text.Substring(9) == "V" || tbxNic.Text.Substring(9) == "v")
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
            decimal amount = Convert.ToDecimal(tbxUprice.Text) * Convert.ToDecimal(tbxQty.Text);
            grd.Rows.Add(cmbType.Text, tbxQty.Text, tbxUprice.Text, amount);
            cmbType.Text = null;
            tbxQty.Clear();
            tbxUprice.Clear();
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

        private void frmNewSalesRecord_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection("server = localhost; user id = root; database = dbcore; pwd = 1234; allowuservariables = True");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //conn = new MySqlConnection("server = localhost; user id = root; database = dbcore; pwd = 1234; allowuservariables = True");
            int rows = grd.Rows.Count;
            for (int x = 0; x < rows - 1; ++x)
            {
                conn.Open();
                string StrQuery;
                StrQuery = "insert into dtsales values('" + tbxCustName.Text.Trim() + "', '" + tbxNic.Text.Trim() + "', '" + tbxTel.Text.Trim() + "', '" + grd.Rows[x].Cells[0].Value.ToString() + "', '" + grd.Rows[x].Cells[1].Value.ToString() + "', '" + grd.Rows[x].Cells[2].Value.ToString() + "', '" + grd.Rows[x].Cells[3].Value.ToString() + "')";
                cmd = new MySqlCommand(StrQuery, conn);

                if (cmd.ExecuteNonQuery() >= 0)
                {
                    MessageBox.Show("Sucess","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed");
                }
                conn.Close();
                grd.Rows.Clear();
                tbxCustName.Clear();
                tbxNic.Clear();
                tbxTel.Clear();
                cmbType.Text = null;
                

            }


        }
        private void frmNewSalesRecord_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (salesmanMode)
            {
                DialogResult dlgresult = MessageBox.Show("Are you sure to exit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dlgresult == DialogResult.Yes)
                {

                    Application.ExitThread();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                this.Hide();
            }
        }
    

    private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Decimal unitprice;
            MySqlCommand cmd2;
            conn.Open();
            if (cmbType.Text.Trim() == "Single")
            {
                cmd2 = new MySqlCommand("SELECT UnitPrice from dtunitprices where TypeId = 1", conn);
            }
            else 
            {
                cmd2 = new MySqlCommand("SELECT UnitPrice from dtunitprices where TypeId = 2", conn);
            }
            reader = cmd2.ExecuteReader();
            if (reader.Read())
            {
                unitprice = reader.GetDecimal(0);
                tbxUprice.Text = unitprice.ToString();
            }
            conn.Close();
        }
    }
}
