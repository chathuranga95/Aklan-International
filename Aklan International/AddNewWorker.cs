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
        
         MySqlConnection conn;
        string empid = "";

        
        private int retrieveIndex(string workerType)
        {
            conn.Open();
            MySqlCommand cmd;
            MySqlDataReader reader;
            int index = 0;
            //retrieve index from the table's last record 
            cmd = new MySqlCommand("select * from worker_details", conn);

            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (workerType == "Admin" && reader.GetString("empID").Substring(0, 1) == "a") {
                    index++;
                }
                else if (workerType == "Salesman" && reader.GetString("empID").Substring(0, 2) == "sm")
                {
                    index++;
                }
                else if(workerType == "Supervisor" && reader.GetString("empID").Substring(0, 1) == "s")
                {
                    index++;
                }
                else if (workerType == "Worker" && reader.GetString("empID").Substring(0, 1) == "w")
                {
                    index++;
                }

            }
            conn.Close();
            index++; //increament index
            return index;
        }
        public frmAddNewWorker()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmAddNewWorker_Load(object sender, EventArgs e)
        {
            dudMonth.Text = "Jan";
            lblPasswordMaching.Text = "";
            btnAddWorker.Enabled = false;
            rbMale.Checked = true;
            

        }

        private void rtbxAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddWorker_Click(object sender, EventArgs e)
        {
            
            
            
            {
                string firstName = tbxFirstName.Text;
                string lastName = tbxLastName.Text;
                string workerType = cmbWorkerType.Text;
                string password = tbxPassword.Text;
                string address = tbxAddress.Text;
                int telNO = 0;
                try
                {
                    telNO = int.Parse(tbxContactNumber.Text);
                }
                catch
                {

                }
                               
                string accNO = tbxACNumber.Text;
                string nicNO = tbxNIC.Text;
                string gender;
                string deleted = "No";
                if (rbMale.Checked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                string dob = nudYear.Value.ToString() + "-" + dudMonth.Text + "-" + nudDate.Value.ToString();
                try { 
                conn.Open();
                    
                    MySqlCommand comm = conn.CreateCommand();
                    
                    comm.CommandText = "INSERT INTO worker_details(empID,first_name,last_name,worker_type,password,address,acc_NO,nic_NO,gender,tel_NO,dob,deleted) VALUES (@empID,@first_name,@last_name,@worker_type,@password,@address,@acc_NO,@nic_NO,@gender,@tel_NO,@dob,@deleted)";
                    comm.Parameters.AddWithValue("@empID", empid);
                    comm.Parameters.AddWithValue("@first_name", firstName);
                    comm.Parameters.AddWithValue("@last_name",lastName);
                    comm.Parameters.AddWithValue("@worker_type",workerType );
                    comm.Parameters.AddWithValue("@password", password);
                    comm.Parameters.AddWithValue("@address", address);
                    comm.Parameters.AddWithValue("@tel_NO", telNO);
                    comm.Parameters.AddWithValue("@acc_NO",accNO );
                    comm.Parameters.AddWithValue("@nic_NO", nicNO );
                    comm.Parameters.AddWithValue("@gender", gender );
                    comm.Parameters.AddWithValue("@dob", dob );
                    comm.Parameters.AddWithValue("@deleted", deleted);
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

        private void tbxFirstName_TextChanged(object sender, EventArgs e)
        {
            if ((tbxConfirmPassword.Text) != (tbxPassword.Text))
            {
                btnAddWorker.Enabled = false;
                lblPasswordMaching.Text = "*Passwords do not match.";
            }
            else if ((tbxFirstName.Text.Length == 0) || (tbxLastName.Text.Length == 0) ||
                (tbxNIC.Text.Length == 0) || (tbxPassword.Text.Length == 0) ||
                (cmbWorkerType.Text.Length <2) ||
                (tbxContactNumber.Text.Length == 0) || (tbxConfirmPassword.Text.Length == 0) ||
                (tbxAddress.Text.Length == 0) || (tbxACNumber.Text.Length == 0))
            {
                btnAddWorker.Enabled = false;
                lblPasswordMaching.Text = "";
            }
            else
            {
                btnAddWorker.Enabled = true;
            }
        }

        private void tbxLastName_TextChanged(object sender, EventArgs e)
        {
            if ((tbxConfirmPassword.Text) != (tbxPassword.Text))
            {
                btnAddWorker.Enabled = false;
                lblPasswordMaching.Text = "*Passwords do not match.";
            }
            else if ((tbxFirstName.Text.Length == 0) || (tbxLastName.Text.Length == 0) ||
                (tbxNIC.Text.Length == 0) || (tbxPassword.Text.Length == 0) ||
                (cmbWorkerType.Text.Length < 2) ||
                (tbxContactNumber.Text.Length == 0) || (tbxConfirmPassword.Text.Length == 0) ||
                (tbxAddress.Text.Length == 0) || (tbxACNumber.Text.Length == 0))
            {
                btnAddWorker.Enabled = false;
                lblPasswordMaching.Text = "";
            }
            else
            {
                btnAddWorker.Enabled = true;
            }
        }

        private void tbxUserName_TextChanged(object sender, EventArgs e)
        {
            if ((tbxConfirmPassword.Text) != (tbxPassword.Text))
            {
                btnAddWorker.Enabled = false;
                lblPasswordMaching.Text = "*Passwords do not match.";
            }
            else if ((tbxFirstName.Text.Length == 0) || (tbxLastName.Text.Length == 0) ||
                (tbxNIC.Text.Length == 0) || (tbxPassword.Text.Length == 0) ||
                (cmbWorkerType.Text.Length < 2) ||
                (tbxContactNumber.Text.Length == 0) || (tbxConfirmPassword.Text.Length == 0) ||
                (tbxAddress.Text.Length == 0) || (tbxACNumber.Text.Length == 0))
            {
                btnAddWorker.Enabled = false;
                lblPasswordMaching.Text = "";
            }
            else
            {
                btnAddWorker.Enabled = true;
            }
        }

        private void tbxPassword_TextChanged(object sender, EventArgs e)
        {
            if ((tbxConfirmPassword.Text) != (tbxPassword.Text))
            {
                btnAddWorker.Enabled = false;
                lblPasswordMaching.Text = "*Passwords do not match.";
            }
            else if ((tbxFirstName.Text.Length == 0) || (tbxLastName.Text.Length == 0) ||
                (tbxNIC.Text.Length == 0) || (tbxPassword.Text.Length == 0) ||
                (cmbWorkerType.Text.Length < 2) ||
                (tbxContactNumber.Text.Length == 0) || (tbxConfirmPassword.Text.Length == 0) ||
                (tbxAddress.Text.Length == 0) || (tbxACNumber.Text.Length == 0))
            {
                btnAddWorker.Enabled = false;
                lblPasswordMaching.Text = "";
            }
            else
            {
                btnAddWorker.Enabled = true;
            }
        }

        private void tbxConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if ((tbxConfirmPassword.Text) != (tbxPassword.Text))
            {
                btnAddWorker.Enabled = false;
                lblPasswordMaching.Text = "*Passwords do not match.";
            }
            else if ((tbxFirstName.Text.Length == 0) || (tbxLastName.Text.Length == 0) ||
                (tbxNIC.Text.Length == 0) || (tbxPassword.Text.Length == 0) || (cmbWorkerType.Text.Length < 2) ||
                (tbxContactNumber.Text.Length == 0) || (tbxConfirmPassword.Text.Length == 0) ||
                (tbxAddress.Text.Length == 0) || (tbxACNumber.Text.Length == 0))
            {
                btnAddWorker.Enabled = false;
                lblPasswordMaching.Text = "";
            }
            else
            {
                btnAddWorker.Enabled = true;
            }
        }

        private void tbxNIC_TextChanged(object sender, EventArgs e)
        {
            if ((tbxConfirmPassword.Text) != (tbxPassword.Text))
            {
                btnAddWorker.Enabled = false;
                lblPasswordMaching.Text = "*Passwords do not match.";
            }
            else if ((tbxFirstName.Text.Length == 0) || (tbxLastName.Text.Length == 0) ||
                (tbxNIC.Text.Length == 0) || (tbxPassword.Text.Length == 0) ||
                (cmbWorkerType.Text.Length < 2) ||
                (tbxContactNumber.Text.Length == 0) || (tbxConfirmPassword.Text.Length == 0) ||
                (tbxAddress.Text.Length == 0) || (tbxACNumber.Text.Length == 0))
            {
                btnAddWorker.Enabled = false;
                lblPasswordMaching.Text = "";
            }
            else
            {
                btnAddWorker.Enabled = true;
            }
        }

        private void tbxAddress_TextChanged(object sender, EventArgs e)
        {
            if ((tbxConfirmPassword.Text) != (tbxPassword.Text))
            {
                btnAddWorker.Enabled = false;
                lblPasswordMaching.Text = "*Passwords do not match.";
            }
            else if ((tbxFirstName.Text.Length == 0) || (tbxLastName.Text.Length == 0) ||
                (tbxNIC.Text.Length == 0) || (tbxPassword.Text.Length == 0) ||
                (cmbWorkerType.Text.Length < 2) ||
                (tbxContactNumber.Text.Length == 0) || (tbxConfirmPassword.Text.Length == 0) ||
                (tbxAddress.Text.Length == 0) || (tbxACNumber.Text.Length == 0))
            {
                btnAddWorker.Enabled = false;
                lblPasswordMaching.Text = "";
            }
            else
            {
                btnAddWorker.Enabled = true;
            }
        }

        private void tbxContactNumber_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if ((tbxConfirmPassword.Text) != (tbxPassword.Text))
            {
                btnAddWorker.Enabled = false;
                lblPasswordMaching.Text = "*Passwords do not match.";
            }
            else if ((tbxFirstName.Text.Length == 0) || (tbxLastName.Text.Length == 0) ||
                (tbxNIC.Text.Length == 0) || (tbxPassword.Text.Length == 0) ||
               (cmbWorkerType.Text.Length < 2) ||
                (tbxContactNumber.Text.Length == 0) || (tbxConfirmPassword.Text.Length == 0) ||
                (tbxAddress.Text.Length == 0) || (tbxACNumber.Text.Length == 0))
            {
                btnAddWorker.Enabled = false;
                lblPasswordMaching.Text = "";
            }
            else
            {
                btnAddWorker.Enabled = true;
            }
        }

        private void tbxACNumber_TextChanged(object sender, EventArgs e)
        {
            if ((tbxConfirmPassword.Text) != (tbxPassword.Text))
            {
                btnAddWorker.Enabled = false;
                lblPasswordMaching.Text = "*Passwords do not match.";
            }
            else if ((tbxFirstName.Text.Length == 0) || (tbxLastName.Text.Length == 0) ||
                (tbxNIC.Text.Length == 0) || (tbxPassword.Text.Length == 0) ||
                (cmbWorkerType.Text.Length < 2) ||
                (tbxContactNumber.Text.Length == 0) || (tbxConfirmPassword.Text.Length == 0) ||
                (tbxAddress.Text.Length == 0) || (tbxACNumber.Text.Length == 0))
            {
                btnAddWorker.Enabled = false;
                lblPasswordMaching.Text = "";
            }
            else
            {
                btnAddWorker.Enabled = true;
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbWorkerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((tbxConfirmPassword.Text) != (tbxPassword.Text))
            {
                btnAddWorker.Enabled = false;
                lblPasswordMaching.Text = "*Passwords do not match.";
            }
            else if ((tbxFirstName.Text.Length == 0) || (tbxLastName.Text.Length == 0) ||
                (tbxNIC.Text.Length == 0) || (tbxPassword.Text.Length == 0) ||
                (cmbWorkerType.Text.Length < 2) ||
                (tbxContactNumber.Text.Length == 0) || (tbxConfirmPassword.Text.Length == 0) ||
                (tbxAddress.Text.Length == 0) || (tbxACNumber.Text.Length == 0))
            {
                btnAddWorker.Enabled = false;
                lblPasswordMaching.Text = "";
            }
            else
            {
                btnAddWorker.Enabled = true;
            }

            conn = new MySqlConnection("Server=localhost;Database=dbcore;Uid=root;Pwd=1234");
            int index = retrieveIndex(cmbWorkerType.Text);

            string type = "";

            if (cmbWorkerType.Text == "Salesman")
            {
                type = "sm";
            }
            else {
                type = cmbWorkerType.Text.Substring(0,1).ToLower();
            }

            if (index < 10)
            {
                empid = type+"00" + index.ToString();
            }
            else if (index < 100)
            {
                empid = type+"0" + index.ToString();
            }
            else
            {
                empid = type + index.ToString();
            }
            lblworkerID.Text = empid;
        }
    }
}
