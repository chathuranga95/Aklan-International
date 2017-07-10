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
        //MySqlCommand cmd;
         MySqlConnection conn;
       
        //MySqlDataReader reader;
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
            //if ((tbxFirstName.Text.Length == 0) || (tbxLastName.Text.Length == 0) ||
            //    (tbxNIC.Text.Length == 0) || (tbxPassword.Text.Length == 0) ||
            //    (tbxUserName.Text.Length == 0) || (tbxDOB.Text.Length == 0) ||
            //    (tbxContactNumber.Text.Length == 0) || (tbxConfirmPassword.Text.Length == 0) ||
            //    (tbxAddress.Text.Length == 0) || (tbxACNumber.Text.Length == 0))
            //{
            //    MessageBox.Show("Fill all fields.", "Warning");
            //}
            //else 
            if ((tbxConfirmPassword.Text) != (tbxPassword.Text))
            {
                MessageBox.Show("Passwords do not match.", "Warning");
            }
            else {
                string firstName = tbxFirstName.Text;
                string lastName = tbxLastName.Text;
                string userName = tbxUserName.Text;
                string password = tbxPassword.Text;
                string address = tbxAddress.Text;
                int telNO = 0;
                try
                {
                    telNO = int.Parse(tbxContactNumber.Text);
                }
                catch
                {
                    MessageBox.Show("error");//should be cahnged
                    
                }
                
                string accNO = tbxACNumber.Text;
                string nicNO = tbxNIC.Text;
                string gender = cmbGender.Text;
                string dob = nudYear.Value.ToString() + "-" + dudMonth.Text + "-" + nudDate.Value.ToString();
                try { 
                conn.Open();
                    
                    MySqlCommand comm = conn.CreateCommand();
                    //comm.CommandText = "INSERT INTO worker_details(first_name,last_name,user_name,password,address,nic_NO,gender,acc_NO) VALUES(@first_name,@last_name,@user_name,@password,@address,,@nic_NO,@gender,@acc_NO)";
                    comm.CommandText = "INSERT INTO worker_details(first_name,last_name,user_name,password,address,acc_NO,nic_NO,gender,tel_NO,dob) VALUES (@first_name,@last_name,@user_name,@password,@address,@acc_NO,@nic_NO,@gender,@tel_NO,@dob)";
                    comm.Parameters.Add("@first_name", firstName);
                    comm.Parameters.Add("@last_name",lastName);
                    comm.Parameters.Add("@user_name", userName );
                    comm.Parameters.Add("@password", password);
                    comm.Parameters.Add("@address", address);
                    comm.Parameters.Add("@tel_NO", telNO);
                    comm.Parameters.Add("@acc_NO",accNO );
                    comm.Parameters.Add("@nic_NO", nicNO );
                    comm.Parameters.Add("@gender", gender );
                    comm.Parameters.Add("@dob", dob );
                    comm.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("New worker added successfully.", "Success");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Error in adding mysql row. Error: " );

                }
            }
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nudYear_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
