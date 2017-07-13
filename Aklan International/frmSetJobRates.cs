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
        MySqlDataReader reader;
        public frmSetJobRates()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new MySqlCommand("UPDATE `dbcore`.`dtjobrates` SET `rate`='" + decimal.Parse(txtRate.Text).ToString() + "' WHERE `job`='" + cmbJob.Text.Trim() + "' ", conn);
                conn.Open();
                if (cmd.ExecuteNonQuery() >= 0)
                {
                    MessageBox.Show("Success...");
                }
                else
                    MessageBox.Show("failed..");

                
            }
            catch (Exception)
            {
                MessageBox.Show("Failed...");
            }
            finally
            {
                conn.Close();
            }
            
        }

        private void frmSetJobRates_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection("Server=localhost;Database=dbcore;Uid=root;Pwd=1234");
        }
    }
}
