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
    public partial class frmAddNewWorker : Form
    {
        MySqlCommand cmd;
        MySqlConnection conn;
        MySqlDataReader reader;
        public frmAddNewWorker()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmAddNewWorker_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection("Server=localhost;Database=dbcore;Uid=root;Pwd=1234");
        }

        private void rtbxAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddWorker_Click(object sender, EventArgs e)
        {
            if ((tbxFirstName.Text.Length == 0) || (tbxLastName.Text.Length == 0) ||
                (tbxNIC.Text.Length == 0) || (tbxPassword.Text.Length == 0) ||
                (tbxUserName.Text.Length == 0) ||
                (tbxContactNumber.Text.Length == 0) || (tbxConfirmPassword.Text.Length == 0) ||
                (tbxAddress.Text.Length == 0) || (tbxACNumber.Text.Length == 0))
            {
                MessageBox.Show("Fill all fields.", "Warning");
            }
            else if ((tbxConfirmPassword.Text) != (tbxPassword.Text))
            {
                MessageBox.Show("Passwords do not match.", "Warning");
            }
            else {
                conn.Open();
                MySqlCommand comm = conn.CreateCommand();
                comm.CommandText = "INSERT INTO worker_details VALUES(@empID)";
                comm.Parameters.Add("@empID", "Myname");
                
                comm.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("New worker added successfully.", "Success");
                this.Close();
            }
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
