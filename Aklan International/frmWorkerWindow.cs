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
    public partial class frmWorkerWindow : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;

        public frmWorkerWindow()
        {
            InitializeComponent();
        }

        private void frmWorkerWindow_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\chathuranga\documents\visual studio 2015\Projects\Aklan International\Aklan International\dbCore.mdf;Integrated Security=True");
            cmd = new SqlCommand("select * from dtLogin", conn);

            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbWorkerName.Items.Add(reader["userName"]);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }


        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from dtLogin where username = '" + cmbWorkerName.Text.Trim() + "'", conn);
            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if (reader["password"].ToString().Trim() == txtPassword.Text.Trim())
                    {

                        MessageBox.Show("Login success...");
                        frmRequestFinish obj = new frmRequestFinish(reader["userName"].ToString());
                        obj.Show();
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
