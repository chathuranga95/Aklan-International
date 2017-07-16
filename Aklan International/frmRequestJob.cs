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
    public partial class frmRequestJob : Form
    {
        MySqlCommand cmd;
        MySqlConnection conn;
        MySqlDataReader reader;
        Form frmobj;
        String empID;
        public frmRequestJob()
        {
            InitializeComponent();
        }

        public frmRequestJob(String workerName, Form frmobj, String empID)
        {
            InitializeComponent();
            lblWorkerName.Text = "Welcome : " + workerName;
            this.frmobj = frmobj;
            this.empID = empID;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmobj.Show();
        }

        private void frmRequestJob_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(this.btnExit, "Sign out");
            toolTip.SetToolTip(this.btnRequest , "Request material for work");
            toolTip.SetToolTip(this.cmbJob, "Select Job");
            conn = new MySqlConnection("Server=localhost;Database=dbcore;Uid=root;Pwd=1234");
            checkTable();
        }

        private int retrieveIndex()
        {
            conn.Open();
            int index = 0;
            //retrieve index from the table's last record 
            cmd = new MySqlCommand("select * from dt" + empID.ToString(), conn);

            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                index = reader.GetInt32("index");
            }
            conn.Close();
            index++; //increament index
            return index;
        }

        

        private void checkTable()
        {
            MySqlConnection conn1 = new MySqlConnection("Server=localhost;Database=dbcore;Uid=root;Pwd=1234");
            conn1.Open();
            cmd = new MySqlCommand("SELECT * FROM information_schema.tables WHERE table_schema = 'dbcore' AND table_name = 'dt" + empID + "'", conn1);
            reader = cmd.ExecuteReader();

            if (!reader.Read())
            {
                cmd = new MySqlCommand("CREATE TABLE `dbcore`.`dt" + empID.ToString() + "` ( `index` INT NOT NULL,`date` VARCHAR(20) NULL, `matType` VARCHAR(45) NULL,`job` VARCHAR(45) NULL,`Qty` INT NULL, `finished` VARCHAR(3) NULL, PRIMARY KEY(`index`))", conn1);
                reader.Close();
                cmd.ExecuteNonQuery();
            }

            conn1.Close();
        }

        

        private bool validateRequest(string matType, int qty)
        {
            MaterialUpdate mtup = new Aklan_International.MaterialUpdate(empID);
            int[] matArray = mtup.retrieveMaterial();

            if (matType == "sheet" && matArray[0] > qty)
            {
                return true;
            }
            else if (matType == "cut strip" && matArray[1] > qty)
            {
                return true;
            }
            else if (matType == "clip cut" && matArray[2] > qty)
            {
                return true;
            }
            else if (matType == "folded 12" && matArray[3] > qty)
            {
                return true;
            }
            else if (matType == "folded single" && matArray[4] > qty)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        

        private void btnRequest_Click(object sender, EventArgs e)
        {

            int index = retrieveIndex();

            Dictionary<String, String> mydic = new Dictionary<string, string>();
            mydic.Add("cutting", "sheet");
            mydic.Add("clip cutting", "cut strip");
            mydic.Add("folding 12", "clip cut");
            mydic.Add("folding single", "clip cut");
            mydic.Add("rimming 12", "folded 12");
            mydic.Add("rimming single", "folded single");
            string matType;
            mydic.TryGetValue(cmbJob.Text.Trim(), out matType);

            MaterialUpdate mtup = new Aklan_International.MaterialUpdate(empID);
            if (validateRequest(matType, (int)spnQty.Value))
            {
                try
                {
                    cmd = new MySqlCommand("INSERT INTO `dbcore`.`dt" + empID.ToString() + "` (`index`, `date`, `matType`,`job`, `Qty`, `finished`) VALUES ('" + index + "', '" + DateTime.Today.Date.ToShortDateString() + "', '" + matType + "', '" + cmbJob.Text.Trim() + "', '" + spnQty.Value.ToString() + "', 'no')", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    mtup.updateMaterial(matType, (int)spnQty.Value, empID,true);
                    MessageBox.Show("Success!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Sorry. Operation failed.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //throw;
                }
               
            }
            else
                MessageBox.Show("Request can't obtained. Please try another material or fewer Qty!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            lbxJobs.Items.Clear();
            if (e.TabPageIndex == 1)
            {
                int index = retrieveIndex();
                conn.Open();
                cmd = new MySqlCommand("select * from dt" + empID.ToString() + " where finished = 'no'", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //if (reader.GetInt32("index") + 3 >= index)
                    {
                        lbxJobs.Items.Insert(0, reader.GetString("Qty") + " of " + reader.GetString("matType") + " taken. finish status :" + reader.GetString("finished")); ;
                    }
                }
                conn.Close();

            }
        }

        private void refreshInput()
        {
            btnRequest.Enabled = (cmbJob.Text.Trim()!="" && spnQty.Value != 0);
        }

        private void cmbMachineType_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshInput();
        }

        private void spnQty_ValueChanged(object sender, EventArgs e)
        {
            refreshInput();
        }
    }
}
