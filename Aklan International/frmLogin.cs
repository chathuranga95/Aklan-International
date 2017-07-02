using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Aklan_International
{
    public partial class frmLogin : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;

        public frmLogin()
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

        private void frmLogin_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\asus\Source\Repos\Aklan - International\Aklan International\dbCore.mdf;Integrated Security=True");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtUserName.Focus();
        }
    }
}
