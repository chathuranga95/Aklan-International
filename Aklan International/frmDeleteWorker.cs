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
    public partial class frmDeleteWorker : Form
    {
        static frmDeleteWorker instance = null;
        public static frmDeleteWorker getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new frmDeleteWorker();
            }
            return instance;

        }

        MySqlConnection conn;
        
        public Boolean checkAvailability(string empID)
        {
            Boolean availability = false;
            conn = new MySqlConnection("Server=localhost;Database=dbcore;Uid=root;Pwd=1234");
            conn.Open();
            MySqlCommand cmd;
            MySqlDataReader reader;
               
            cmd = new MySqlCommand("select * from dtLogin", conn);

            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if(empID == reader.GetString("empID"))
                {
                    availability = true;
                }
               
            }
            conn.Close();
            
            return availability;
        }
        public frmDeleteWorker()
        {
            InitializeComponent();
        }

        private void frmDeleteWorker_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(this.btnDelete, "Delete Selected User");
            toolTip.SetToolTip(this.btnCancel, "Cancel operation and close this window");

            tbxempID.AutoCompleteCustomSource.Clear();
            conn = new MySqlConnection("Server=localhost;Database=dbcore;Uid=root;Pwd=1234");
            conn.Open();
            MySqlCommand cmd;
            MySqlDataReader reader;

            cmd = new MySqlCommand("select * from dtLogin", conn);

            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                tbxempID.AutoCompleteCustomSource.Add(reader.GetString("empID"));


            }
            btnDelete.Enabled = false;
            lblAvailable.Visible = false;
            lblnotAvailable.Visible = false;
            lblWorkerNameShow.Text = "-";
        }

        private string getName(string empID)
        {
            String name = "";
            conn.Open();
            MySqlCommand cmd;
            MySqlDataReader reader;

            cmd = new MySqlCommand("select * from worker_details", conn);

            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (empID == reader.GetString("empID"))
                {
                    name = reader.GetString("first_name") + " " + reader.GetString("last_name");
                }

            }
            conn.Close();
            return name;
        }
        private void tbxempID_TextChanged(object sender, EventArgs e)
        {
            
            if (checkAvailability(tbxempID.Text)) {
                btnDelete.Enabled = true;
                lblAvailable.Visible = true;
                lblnotAvailable.Visible = false;


                lblWorkerNameShow.Text = getName(tbxempID.Text);
            }
            else
            {
                btnDelete.Enabled = false;
                lblAvailable.Visible = false;
                lblnotAvailable.Visible = true;
                lblWorkerNameShow.Text = "-";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure?", "Cancel", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void deleteWorker(string empID)
        {
            DialogResult dr = MessageBox.Show("Are you sure?","Delete Worker", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr == DialogResult.Yes) {

                conn = new MySqlConnection("Server=localhost;Database=dbcore;Uid=root;Pwd=1234");
                conn.Open();
                MySqlCommand cmd;
                MySqlCommand cmd1;
                cmd = new MySqlCommand("UPDATE worker_details SET deleted = @Yes WHERE empID ='"+empID+"'",conn);
                cmd1 = new MySqlCommand("delete from dtlogin where empID ='" + empID + "' ",conn);
                cmd1.ExecuteNonQuery();
                cmd.Parameters.AddWithValue("@Yes", "Yes");
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Worker deleted successfully.","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();

            }
            
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            conn = new MySqlConnection("Server=localhost;Database=dbcore;Uid=root;Pwd=1234");
            conn.Open();
            MySqlCommand cmd;
            MySqlDataReader reader;

            cmd = new MySqlCommand("select * from worker_details", conn);

            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (tbxempID.Text  == reader.GetString("empID"))
                {
                    if (reader.GetString("deleted") == "Yes")
                    {
                        MessageBox.Show("This worker already deleted.","Delete worker",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        deleteWorker(tbxempID.Text);
                    }
                }
            }
            conn.Close();
            
        }

        private void lblnotAvailable_Click(object sender, EventArgs e)
        {

        }
    }
}
