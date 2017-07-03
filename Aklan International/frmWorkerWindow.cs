using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Aklan_International
{
    public partial class frmWorkerWindow : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;

        public frmWorkerWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            cmd = new SqlCommand("select * from dtLogin where username = '" + txtUserName.Text.Trim() + "'", conn);
            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if (reader["password"].ToString().Trim() == txtPassword.Text.Trim())
                    {

                        MessageBox.Show("Login success...");
                        //frmMain obj = new frmMain(reader["userName"].ToString());
                        //obj.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Login failed...");
                    }
                }
                else
                {
                    MessageBox.Show("Login failed...");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
