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
                cmd = new MySqlCommand("CREATE TABLE `dbcore`.`dt" + empID.ToString() + "` ( `index` INT NOT NULL,`date` VARCHAR(20) NULL, `matType` VARCHAR(45) NULL,`Qty` INT NULL, `finished` VARCHAR(3) NULL, PRIMARY KEY(`index`))", conn1);
                reader.Close();
                cmd.ExecuteNonQuery();
            }
            
            conn1.Close();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            try
            {
                int index = retrieveIndex();   
                conn.Open();
                Dictionary<String, String> mydic = new Dictionary<string, string>();
                mydic.Add("Cutting", "Sheet");
                mydic.Add("Clip Cutting", "Cut strip");
                mydic.Add("Folding", "Clip cut strip");
                mydic.Add("Rimming", "Folded strip");
                string matType;
                mydic.TryGetValue(cmbMachineType.Text.Trim(),out matType);
                cmd = new MySqlCommand("INSERT INTO `dbcore`.`dt"+empID.ToString()+"` (`index`, `date`, `matType`, `Qty`, `finished`) VALUES ('"+index+"', '"+DateTime.Today.Date.ToShortDateString()+"', '"+matType+"', '"+spnQty.Value.ToString()+"', 'no')",conn);
                cmd.ExecuteNonQuery();
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

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            lbxJobs.Items.Clear();
            if (e.TabPageIndex == 1)
            {
                int index = retrieveIndex();
                conn.Open();
                cmd = new MySqlCommand("select * from dt"+empID.ToString(), conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if(reader.GetInt32("index") + 3 >= index)
                    {
                        lbxJobs.Items.Insert(0,reader.GetString("Qty") +  " of " + reader.GetString("matType") + " taken. finish status :" + reader.GetString("finished")); ;
                    }
                }
                conn.Close();
                
            }
        }
    }
}
