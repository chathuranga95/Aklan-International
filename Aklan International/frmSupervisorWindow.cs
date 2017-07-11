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
using System.Collections;

namespace Aklan_International
{
    public partial class frmSupervisorWindow : Form
    {
        MySqlCommand cmd;
        MySqlConnection conn;
        MySqlDataReader reader;
        ArrayList jobList = new ArrayList();
        public frmSupervisorWindow()
        {
            InitializeComponent();
        }

        private void frmSupervisorWindow_Load(object sender, EventArgs e)
        {
            refreshJobs();
        }

        private void refreshJobs()
        {
            conn = new MySqlConnection("Server=localhost;Database=dbcore;Uid=root;Pwd=1234");
            cmd = new MySqlCommand("select empID from dtlogin", conn);
            /*
            DialogResult res = MessageBox.Show("here","abc", MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes)
            {
                MessageBox.Show("you chose yes");
            }
            */
            ArrayList empList = new ArrayList();
            conn.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                empList.Add(reader.GetString(0));
            }
            conn.Close();
            foreach (string id in empList)
            {
                lbxCurrentJobs.Items.Clear();
                cmd = new MySqlCommand("select * from dt" + id + " where finished='no'", conn);
                conn.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    jobList.Add(new Job(id,int.Parse(reader.GetString("index")), reader.GetString("matType"), int.Parse(reader.GetString("qty")), reader.GetString("finished")=="yes",reader.GetString("date")));
                }
                conn.Close();
            }
            lbxCurrentJobs.Items.Clear();
            foreach (Job job in jobList)
            {
                lbxCurrentJobs.Items.Add("EmpID :" + job.getEmpID() + "Material Type :" + job.getMatType() + "Qty :" + job.getQty() + "Date :" + job.getDate());
            }
        }

        
        private void btnMark_Click(object sender, EventArgs e)
        {
            Job selectedJob = (Job)jobList[lbxCurrentJobs.SelectedIndex];
            conn = new MySqlConnection("Server=localhost;Database=dbcore;Uid=root;Pwd=1234");
            selectedJob.setFinished(true);
            cmd = new MySqlCommand("UPDATE `dbcore`.`dt"+selectedJob.getEmpID()+"` SET `finished`='yes' WHERE `index`='" + selectedJob.getIndex() + "' ", conn);
            conn.Open();
            if (cmd.ExecuteNonQuery() >= 0)
            {
                MessageBox.Show("success...");
            }
            conn.Close();
        }

    }
}
