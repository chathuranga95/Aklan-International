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
    public partial class frmLogin : Form
    {
        MySqlCommand cmd;
        MySqlConnection conn;
        MySqlDataReader reader;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmpID.Text.Trim() == "" ||  txtPassword.Text.Trim()=="")
            {
                MessageBox.Show("Type your Employ ID and Password");
            }
            else
            {
                conn.Open();
                cmd = new MySqlCommand("select * from dtlogin where empID = '" + txtEmpID.Text.Trim() + "'", conn);
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    if (reader.GetString("psw") == txtPassword.Text.Trim())
                    {
                        if (txtEmpID.Text.Substring(0, 1) == "a")
                        {
                            MessageBox.Show("Admin access granted!!!");
                            frmAdminWindow obj = new frmAdminWindow(reader.GetString("empName"), txtEmpID.Text.Trim());
                            obj.Show();
                            this.Hide();
                        }
                        else if (txtEmpID.Text.Substring(0, 2) == "sm")
                        {
                            MessageBox.Show("Salesman access granted!!!");
                            frmNewSalesRecord obj = new frmNewSalesRecord(reader.GetString("empName"));
                            obj.Show();
                            this.Hide();
                        }
                        else if (txtEmpID.Text.Substring(0, 1) == "s")
                        {
                            MessageBox.Show("Supervisor access granted!!!");
                            frmSupervisorWindow obj = new frmSupervisorWindow(txtEmpID.Text.Trim());
                            obj.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("failed");
                    }
                }
                conn.Close();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection("Server=localhost;Database=dbcore;Uid=root;Pwd=1234");

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmpID.Clear();
            txtPassword.Clear();
            txtEmpID.Focus();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            (new frmModeSelect()).Show();
        }
    }
}
