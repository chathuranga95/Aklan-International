using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; //my sql
using System.Windows.Forms;

namespace Aklan_International
{
    public partial class frmWorkerWindow : Form
    {
        MySqlCommand cmd;
        MySqlConnection conn;
        MySqlDataReader reader;

        public frmWorkerWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (cmbWorkerName.Text.Trim() == "")
            {
                MessageBox.Show("Choose your name");
            }
            else
            {
                try
                {
                    conn.Open();
                    cmd = new MySqlCommand("select * from dtlogin where empName = '" + cmbWorkerName.Text.Trim() + "'", conn);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader.GetString("psw") == txtPassword.Text.Trim() && reader.GetString("empName") == cmbWorkerName.Text.Trim())
                        {
                            MessageBox.Show("success...");

                            this.Hide();
                            frmRequestJob obj = new frmRequestJob(cmbWorkerName.Text.Trim(), this, reader.GetString("empID"));
                            obj.Show();
                            clearComponents();
                        }
                        else
                        {
                            MessageBox.Show("Failed...");
                        }
                    }

                }
                catch
                {
                    //MessageBox.Show(ee.ToString());
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void frmWorkerWindow_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection("Server=localhost;Database=dbcore;Uid=root;Pwd=1234");
            try
            {
                conn.Open();
                cmd = new MySqlCommand("select * from dtlogin where empID like 'w%'", conn);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbWorkerName.Items.Add(reader.GetString("empName"));
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        private void clearComponents()
        {
            txtPassword.Clear();
            cmbWorkerName.Text = "";
            cmbWorkerName.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearComponents();
        }

        private void cmbWorkerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnChangePass.Enabled = cmbWorkerName.Text != "";
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            frmChangePassword obj = new frmChangePassword(cmbWorkerName.Text.Trim());
            obj.Show();
        }
    }
}
