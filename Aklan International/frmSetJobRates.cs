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
    public partial class frmSetJobRates : Form
    {
        MySqlCommand cmd;
        MySqlConnection conn;

        private static frmSetJobRates instance;
        public static frmSetJobRates getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new frmSetJobRates();
            }
            return instance;
        }
        private frmSetJobRates()
        {
            InitializeComponent();
        }
        private bool verifyRate(string rate)
        {
            bool res = false;
            try
            {
                decimal.Parse(rate);
                res = true;
            }
            catch
            {
                res = false;
            }
            return res;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (verifyRate(txtRate.Text.Trim()))
            {
                try
                {
                    cmd = new MySqlCommand("UPDATE `dbcore`.`dtjobrates` SET `rate`='" + decimal.Parse(txtRate.Text).ToString() + "' WHERE `job`='" + cmbJob.Text.Trim() + "' ", conn);
                    conn.Open();
                    if (cmd.ExecuteNonQuery() >= 0)
                    {
                        MessageBox.Show("Success!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Sorry. Operation failed.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                catch (Exception)
                {
                    MessageBox.Show("Sorry. Operation failed.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void frmSetJobRates_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(this.btnOK, "Set selected job rate");
            toolTip.SetToolTip(this.btnCancel, "Cancel operation and close this window");
            toolTip.SetToolTip(this.cmbJob, "Select Job to edit rate");
            conn = new MySqlConnection("Server=localhost;Database=dbcore;Uid=root;Pwd=1234");
            btnOK.Enabled = false;
        }

        private void cmbJob_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnOK.Enabled = (cmbJob.Text != "");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
