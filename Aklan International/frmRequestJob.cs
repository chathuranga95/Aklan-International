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
            lblWorkerName.Text = workerName;
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

        private int[] retrieveMaterial()
        {
            //array of material consists of the current
            //available material with the order,
            //sheet, cut strip, clip cut, folded 12, folded single
            int[] materialArray = new int[5];
            MySqlConnection conn1 = new MySqlConnection("Server=localhost;Database=dbcore;Uid=root;Pwd=1234");
            conn1.Open();
            cmd = new MySqlCommand("select material from dtmaterial", conn1);
            reader = cmd.ExecuteReader();
            string res = "";
            if (reader.Read())
            {
                res = reader.GetString(0);
            }
            conn1.Close();
            for (int i = 0; i < 5; i++)
            {
                materialArray[i] = int.Parse(res.Split(',')[i]);
            }

            return materialArray;
        }

        private bool validateRequest(string matType, int qty)
        {
            int[] matArray = retrieveMaterial();

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
            mydic.Add("clip Cutting", "cut strip");
            mydic.Add("folding 12", "clip cut");
            mydic.Add("folding single", "clip cut");
            mydic.Add("Rimming 12", "folded 12");
            mydic.Add("Rimming single", "folded single");
            string matType;
            mydic.TryGetValue(cmbJob.Text.Trim(), out matType);


            if (validateRequest(matType, (int)spnQty.Value))
            {
                try
                {
                    cmd = new MySqlCommand("INSERT INTO `dbcore`.`dt" + empID.ToString() + "` (`index`, `date`, `matType`,`job`, `Qty`, `finished`) VALUES ('" + index + "', '" + DateTime.Today.Date.ToShortDateString() + "', '" + matType + "', '" + cmbJob.Text.Trim() + "', '" + spnQty.Value.ToString() + "', 'no')", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success...");
                }
                catch
                {
                    //MessageBox.Show(ee.ToString());
                    throw;
                }
                finally
                {
                    conn.Close();
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
                cmd = new MySqlCommand("select * from dt" + empID.ToString(), conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetInt32("index") + 3 >= index)
                    {
                        lbxJobs.Items.Insert(0, reader.GetString("Qty") + " of " + reader.GetString("matType") + " taken. finish status :" + reader.GetString("finished")); ;
                    }
                }
                conn.Close();

            }
        }

        private void cmbMachineType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbJob.Text == "Folding")
                cmbSingleOr12.Visible = true;
            else
                cmbSingleOr12.Visible = false;
        }
    }
}
