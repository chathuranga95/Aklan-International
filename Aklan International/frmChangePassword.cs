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
    
    public partial class frmChangePassword : Form
    {
        MySqlCommand cmd;
        MySqlConnection conn;
        MySqlDataReader reader;

        string workerName;
        public frmChangePassword()
        {
            InitializeComponent();
        }
        public frmChangePassword(string wName)
        {
            InitializeComponent();
            this.Text ="Change Password : " +  wName;
            this.workerName = wName;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (txtNewPass.Text == txtConfirmPass.Text)
            {
                bool passMatch = false;
                string empID = "";
                try
                {
                    conn.Open();
                    cmd = new MySqlCommand("select * from dtlogin where empName = '" + workerName + "'", conn);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader.GetString("psw") == txtOldPass.Text.Trim() && reader.GetString("empName") == workerName.Trim())
                        {
                            passMatch = true;
                            empID = reader.GetString("empID"); ;
                            
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
                if (passMatch)
                {
                    cmd = new MySqlCommand("UPDATE `dbcore`.`dtlogin` SET `psw`='" + txtNewPass.Text + "' WHERE `empID`='" + empID + "' ", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Password change success...");
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Old password incorrect!");
                }
                clearComponents();
            }
        }

        private void clearComponents()
        {
            txtConfirmPass.Clear();
            txtNewPass.Clear();
            txtOldPass.Clear();

        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection("Server=localhost;Database=dbcore;Uid=root;Pwd=1234");
        }
    }
}
