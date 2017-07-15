﻿using System;
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
    public partial class frmEditWorkerDetails : Form
    {
        string empID = "w001";
        MySqlCommand cmd;
        MySqlConnection conn;
        
        public frmEditWorkerDetails()
        {
            InitializeComponent();
        }
        public frmEditWorkerDetails(string empID)
        {
            this.empID = empID;
            InitializeComponent();
        }

        private void tbxAddress_TextChanged(object sender, EventArgs e)
        {
            if ((tbxFirstName.Text.Trim().Length == 0) || (tbxLastName.Text.Trim().Length == 0) ||
              (tbxNIC.Text.Trim().Length == 0) || (tbxPassword.Text.Trim().Length == 0) ||
              
              (tbxContactNumber.Text.Trim().Length == 0) ||
                (tbxAddress.Text.Trim().Length == 0) || (tbxACNumber.Text.Trim().Length == 0))
            {
                btnChangeDetails.Enabled = false;
            }
            else
            {
                btnChangeDetails.Enabled = true;
            }
        }

        private void btnAddWorker_Click(object sender, EventArgs e)
        {

            string firstName = tbxFirstName.Text;
            string lastName = tbxLastName.Text;
            
            string password = tbxPassword.Text;
            string address = tbxAddress.Text;
            int telNO = 0;
            try
            {
                telNO = int.Parse(tbxContactNumber.Text);
            }
            catch
            {
                MessageBox.Show("error");//****************

            }

            string accNO = tbxACNumber.Text;
            string nicNO = tbxNIC.Text;
            string gender = "";
            if (rbMale.Checked)
            {
                gender = "Male";
            }
            else if (rbFemale.Checked)
            {
                gender = "Female";
            }
            
            string dob = nudYear.Value.ToString() + "-" + dudMonth.Text + "-" + nudDate.Value.ToString();
            try
            {
                conn.Open();

                MySqlCommand comm = conn.CreateCommand();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "update dtlogin set psw = @psw, empName = @empName where empID =@empID ";
                comm.CommandText = "UPDATE worker_details SET first_name = @first_name,last_name=@last_name,user_name=@user_name,password=@password,address=@address,acc_NO=@acc_NO,nic_NO=@nic_NO,gender=@gender,tel_NO=@tel_NO,dob=@dob WHERE empID = '" + empID + "' ";
                cmd.Parameters.AddWithValue("@empID", empID);
                cmd.Parameters.AddWithValue("@psw", password);
                cmd.Parameters.AddWithValue("@empName", firstName +" "+lastName);
                comm.Parameters.AddWithValue("@first_name", firstName);
                comm.Parameters.AddWithValue("@last_name", lastName);
                
                comm.Parameters.AddWithValue("@password", password);
                comm.Parameters.AddWithValue("@address", address);
                comm.Parameters.AddWithValue("@tel_NO", telNO);
                comm.Parameters.AddWithValue("@acc_NO", accNO);
                comm.Parameters.AddWithValue("@nic_NO", nicNO);
                comm.Parameters.AddWithValue("@gender", gender);
                comm.Parameters.AddWithValue("@dob", dob);
                cmd.ExecuteNonQuery();
                comm.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Worker details changed successfully.", "Success");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Error in adding mysql row. Error: ");

            }
        }

        private void frmEditWorkerDetails_Load(object sender, EventArgs e)
        {
            
            conn = new MySqlConnection("Server=localhost;Database=dbcore;Uid=root;Pwd=1234");
            conn.Open();
            cmd = new MySqlCommand("select * from dtlogin", conn);
            MySqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                
                    tbxWorkerID.AutoCompleteCustomSource.Add(reader.GetString("empID"));
                
            }
            conn.Close();
            tbxPassword.Enabled = false;
            tbxNIC.Enabled = false;
            tbxLastName.Enabled = false;
            tbxFirstName.Enabled = false;
            tbxContactNumber.Enabled = false;
            tbxAddress.Enabled = false;
            tbxACNumber.Enabled = false;
            rbFemale.Enabled = false;
            /*try
            {
                conn.Open();
                cmd = new MySqlCommand("select * from worker_details where empID = '" + empID+ "'",conn);
                reader = cmd.ExecuteReader();
                reader.Read();

                if (reader.GetString("deleted") == "No") {
                    tbxWorkerID.Text = empID;
                    tbxFirstName.Text = reader.GetString("first_name");
                    tbxLastName.Text = reader.GetString("last_name");
                    tbxNIC.Text = reader.GetString("nic_NO");
                    tbxPassword.Text = reader.GetString("password");
                    tbxWorkerType.Text = reader.GetString("worker_type");
                    tbxACNumber.Text = reader.GetString("acc_NO");
                    tbxAddress.Text = reader.GetString("address");
                    string gender = reader.GetString("gender");
                    if (gender == "Male")
                    {
                        rbMale.Checked = true;
                    }
                    else
                    {
                        rbMale.Checked = false;
                    }
                    tbxContactNumber.Text = reader.GetString("tel_NO");
                    nudDate.Value = int.Parse(reader.GetString("dob").Substring(9));
                    nudYear.Value = int.Parse(reader.GetString("dob").Substring(0, 4));
                    dudMonth.Text = reader.GetString("dob").Substring(5, 3);
                    tbxConfirmPassword.Text = reader.GetString("password");
                }
                else
                {
                    MessageBox.Show("Worker has deleted.","Edit Worker Details" );
                    this.Close();
                }
                conn.Close();
            }
            catch
            {
                //MessageBox.Show("error in s");
                throw;
            }
            */

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbxFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                tbxLastName.Focus();
            }
        }

        private void tbxLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if (e.KeyChar == 13)
            {
                tbxUserName.Focus();
            }*/
        }

        private void tbxUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                tbxPassword.Focus();
            }
        }

        private void tbxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
        //    if (e.KeyChar == 13)
        //    {
        //        tbxConfirmPassword.Focus();
        //    }
        }

        private void tbxConfirmPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                tbxNIC.Focus();
            }
        }

        private void tbxFirstName_TextChanged(object sender, EventArgs e)
        {
            if ((tbxFirstName.Text.Trim().Length == 0) || (tbxLastName.Text.Trim().Length == 0) ||
              (tbxNIC.Text.Trim().Length == 0) || (tbxPassword.Text.Trim().Length == 0) ||
               
              (tbxContactNumber.Text.Trim().Length == 0)  ||
                (tbxAddress.Text.Trim().Length == 0) || (tbxACNumber.Text.Trim().Length == 0)) {
                btnChangeDetails.Enabled = false;
            }
            else
            {
                btnChangeDetails.Enabled = true;
            }
        }

        private void tbxLastName_TextChanged(object sender, EventArgs e)
        {
            if ((tbxFirstName.Text.Trim().Length == 0) || (tbxLastName.Text.Trim().Length == 0) ||
              (tbxNIC.Text.Trim().Length == 0) || (tbxPassword.Text.Trim().Length == 0) ||
               
              (tbxContactNumber.Text.Trim().Length == 0) ||
                (tbxAddress.Text.Trim().Length == 0) || (tbxACNumber.Text.Trim().Length == 0))
            {
                btnChangeDetails.Enabled = false;
            }
            else
            {
                btnChangeDetails.Enabled = true;
            }
        }

        private void tbxUserName_TextChanged(object sender, EventArgs e)
        {
            if ((tbxFirstName.Text.Trim().Length == 0) || (tbxLastName.Text.Trim().Length == 0) ||
              (tbxNIC.Text.Trim().Length == 0) || (tbxPassword.Text.Trim().Length == 0) ||
               
              (tbxContactNumber.Text.Trim().Length == 0) ||
                (tbxAddress.Text.Trim().Length == 0) || (tbxACNumber.Text.Trim().Length == 0))
            {
                btnChangeDetails.Enabled = false;
            }
            else
            {
                btnChangeDetails.Enabled = true;
            }
        }

        private void tbxPassword_TextChanged(object sender, EventArgs e)
        {
            if ((tbxFirstName.Text.Trim().Length == 0) || (tbxLastName.Text.Trim().Length == 0) ||
              (tbxNIC.Text.Trim().Length == 0) || (tbxPassword.Text.Trim().Length == 0) ||
               
              (tbxContactNumber.Text.Trim().Length == 0) ||
                (tbxAddress.Text.Trim().Length == 0) || (tbxACNumber.Text.Trim().Length == 0))
            {
                btnChangeDetails.Enabled = false;
            }
            else
            {
                btnChangeDetails.Enabled = true;
            }
        }

        private void tbxConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if ((tbxFirstName.Text.Trim().Length == 0) || (tbxLastName.Text.Trim().Length == 0) ||
              (tbxNIC.Text.Trim().Length == 0) || (tbxPassword.Text.Trim().Length == 0) ||
               
              (tbxContactNumber.Text.Trim().Length == 0) ||
                (tbxAddress.Text.Trim().Length == 0) || (tbxACNumber.Text.Trim().Length == 0))
            {
                btnChangeDetails.Enabled = false;
            }
            else
            {
                btnChangeDetails.Enabled = true;
            }
        }

        private void tbxNIC_TextChanged(object sender, EventArgs e)
        {
            if ((tbxFirstName.Text.Trim().Length == 0) || (tbxLastName.Text.Trim().Length == 0) ||
              (tbxNIC.Text.Trim().Length == 0) || (tbxPassword.Text.Trim().Length == 0) ||
               
              (tbxContactNumber.Text.Trim().Length == 0)||
                (tbxAddress.Text.Trim().Length == 0) || (tbxACNumber.Text.Trim().Length == 0))
            {
                btnChangeDetails.Enabled = false;
            }
            else
            {
                btnChangeDetails.Enabled = true;
            }
        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((tbxFirstName.Text.Trim().Length == 0) || (tbxLastName.Text.Trim().Length == 0) ||
              (tbxNIC.Text.Trim().Length == 0) || (tbxPassword.Text.Trim().Length == 0) ||
               
              (tbxContactNumber.Text.Trim().Length == 0) ||
                (tbxAddress.Text.Trim().Length == 0) || (tbxACNumber.Text.Trim().Length == 0))
            {
                btnChangeDetails.Enabled = false;
            }
            else
            {
                btnChangeDetails.Enabled = true;
            }
        }

        private void tbxContactNumber_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if ((tbxFirstName.Text.Trim().Length == 0) || (tbxLastName.Text.Trim().Length == 0) ||
              (tbxNIC.Text.Trim().Length == 0) || (tbxPassword.Text.Trim().Length == 0) ||
              
              (tbxContactNumber.Text.Trim().Length == 0) ||
                (tbxAddress.Text.Trim().Length == 0) || (tbxACNumber.Text.Trim().Length == 0))
            {
                btnChangeDetails.Enabled = false;
            }
            else
            {
                btnChangeDetails.Enabled = true;
            }
        }

        private void tbxACNumber_TextChanged(object sender, EventArgs e)
        {
            if ((tbxFirstName.Text.Trim().Length == 0) || (tbxLastName.Text.Trim().Length == 0) ||
              (tbxNIC.Text.Trim().Length == 0) || (tbxPassword.Text.Trim().Length == 0) ||
               
              (tbxContactNumber.Text.Trim().Length == 0) ||
                (tbxAddress.Text.Trim().Length == 0) || (tbxACNumber.Text.Trim().Length == 0))
            {
                btnChangeDetails.Enabled = false;
            }
            else
            {
                btnChangeDetails.Enabled = true;
            }
        }

        private void tbxWorkerID_TextChanged(object sender, EventArgs e)
        {
            lblStatus.Text = "Not available.";
            tbxPassword.Enabled = false;
            tbxNIC.Enabled = false;
            tbxLastName.Enabled = false;
            tbxFirstName.Enabled = false;
            tbxContactNumber.Enabled = false;
            tbxAddress.Enabled = false;
            tbxACNumber.Enabled = false;
            rbFemale.Enabled = false;

            
            tbxFirstName.Text = "";
            tbxLastName.Text = "";
            tbxNIC.Text = "";
            tbxPassword.Text = "";
            tbxWorkerType.Text = "";
            tbxACNumber.Text = "";
            tbxAddress.Text = "";
            rbMale.Checked = true;
            rbMale.Checked = false;
            tbxContactNumber.Text = "";
            nudDate.Value = 1;
            nudYear.Value = 1980;
            dudMonth.Text = "";

            conn.Open();
            MySqlDataReader reader;
            MySqlCommand cmd1 = conn.CreateCommand();
            cmd1.CommandText = "select * from worker_details";
            
            reader = cmd1.ExecuteReader();
            while (reader.Read())
            {
                string empID = reader.GetString("empID");
                if (tbxWorkerID.Text.Length>0 &&(tbxWorkerID.Text == empID))
                {
                    

                    if (reader.GetString("deleted") == "No")
                    {
                        
                        tbxFirstName.Text = reader.GetString("first_name");
                        tbxLastName.Text = reader.GetString("last_name");
                        tbxNIC.Text = reader.GetString("nic_NO");
                        tbxPassword.Text = reader.GetString("password");
                        tbxWorkerType.Text = reader.GetString("worker_type");
                        tbxACNumber.Text = reader.GetString("acc_NO");
                        tbxAddress.Text = reader.GetString("address");
                        string gender = reader.GetString("gender");
                        if (gender == "Male")
                        {
                            rbMale.Checked = true;
                        }
                        else
                        {
                            rbMale.Checked = false;
                        }
                        tbxContactNumber.Text = reader.GetString("tel_NO");
                        nudDate.Value = int.Parse(reader.GetString("dob").Substring(9));
                        nudYear.Value = int.Parse(reader.GetString("dob").Substring(0, 4));
                        dudMonth.Text = reader.GetString("dob").Substring(5, 3);

                        tbxPassword.Enabled = true;
                        tbxNIC.Enabled = true;
                        tbxLastName.Enabled = true;
                        tbxFirstName.Enabled = true;
                        tbxContactNumber.Enabled = true;
                        tbxAddress.Enabled = true;
                        tbxACNumber.Enabled = true;
                        rbFemale.Enabled = true;
                        

                    }
                    else
                    {
                        lblStatus.Text = "This worker has deleted.";
                    }
                    break;
                }
            }

            conn.Close();

        }
    }
}
