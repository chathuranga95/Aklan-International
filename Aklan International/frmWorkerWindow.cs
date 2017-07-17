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
                MessageBox.Show("Choose Your Name.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    conn.Open();
                    cmd = new MySqlCommand("select * from dtlogin where empName = '" + cmbWorkerName.Text.Trim() + "'", conn);
                    reader = cmd.ExecuteReader();
                    bool access = false;
                    while (reader.Read())
                    {
                        if (reader.GetString("psw") == txtPassword.Text.Trim() && reader.GetString("empName") == cmbWorkerName.Text.Trim())
                        {
                            MessageBox.Show("Success!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            access = true;
                            this.Hide();
                            frmRequestJob obj = new frmRequestJob(cmbWorkerName.Text.Trim(), this, reader.GetString("empID"));
                            obj.Show();
                            clearComponents();
                            break;
                        }
                    }
                    if (!access)
                    {
                        MessageBox.Show("Invalid Username Or Password!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        clearComponents();
                    }
                }
                catch
                {
                    MessageBox.Show("Sorry. Operation failed.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearComponents();
                    //throw;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void frmWorkerWindow_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(this.btnChangePass, "Change selected Employer's login password");
            toolTip.SetToolTip(this.btnClear, "Clear text");
            toolTip.SetToolTip(this.btnLogin, "Login");
            cmbWorkerName.Focus();
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
            frmChangePassword obj = frmChangePassword.getInstance(cmbWorkerName.Text.Trim());
            obj.Show();
        }

        private void frmWorkerWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlgresult = MessageBox.Show("Are you sure to exit?", "System Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlgresult == DialogResult.Yes)
            {

                (new frmModeSelect()).Show();
            }
            else
            {
                e.Cancel = true;
            }
            
        }

        private void cmbWorkerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
