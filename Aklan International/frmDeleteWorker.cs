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
    public partial class frmDeleteWorker : Form
    {
        
        MySqlConnection conn;
        
        public Boolean checkAvailability(string empID)
        {
            Boolean availability = false;
            conn = new MySqlConnection("Server=localhost;Database=dbcore;Uid=root;Pwd=1234");
            conn.Open();
            MySqlCommand cmd;
            MySqlDataReader reader;
               
            cmd = new MySqlCommand("select * from worker_details", conn);

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
            tbxempID.AutoCompleteCustomSource.Clear();
            conn = new MySqlConnection("Server=localhost;Database=dbcore;Uid=root;Pwd=1234");
            conn.Open();
            MySqlCommand cmd;
            MySqlDataReader reader;

            cmd = new MySqlCommand("select * from worker_details", conn);

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
            this.Close();

        }

        private void deleteWorker(string empID)
        {
            DialogResult dr = MessageBox.Show("Delete Worker", "Are you sure?", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr == DialogResult.Yes) {

                conn = new MySqlConnection("Server=localhost;Database=dbcore;Uid=root;Pwd=1234");
                conn.Open();
                MySqlCommand cmd;
                cmd = new MySqlCommand("UPDATE worker_details SET deleted = @Yes WHERE empID ='"+empID+"'",conn);
                cmd.Parameters.AddWithValue("@Yes", "Yes");
                cmd.ExecuteNonQuery();
                conn.Close();
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
                        MessageBox.Show("");
                        MessageBox.Show("This Worker is Already Deleted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        deleteWorker(tbxempID.Text);
                    }
                }
            }
            conn.Close();
            
        }
    }
}
