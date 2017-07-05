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
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand("SELECT * FROM information_schema.tables WHERE table_schema = 'dbcore' AND table_name = 'dt" + empID + "'", conn);
                reader = cmd.ExecuteReader();
                int index = 0;
                if (!reader.Read())
                {
                    cmd = new MySqlCommand("CREATE TABLE `dbcore`.`dt"+empID.ToString()+ "` ( `index` INT NOT NULL,`date` VARCHAR(20) NULL, `matType` VARCHAR(45) NULL,`Qty` INT NULL, `finished` VARCHAR(3) NULL, PRIMARY KEY(`index`))", conn);
                    reader.Close();
                    cmd.ExecuteNonQuery();
                    index = 1;
                }
                else
                {
                    reader.Close();
                    conn.Close();
                    //retrieve index from the table's last record 
                    cmd = new MySqlCommand("select * from dt"+empID.ToString(),conn);
                    conn.Open();
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        index = reader.GetInt32("index");
                    }

                    index++; //increament index
                }

                conn.Close();
                conn.Open();
                Dictionary<String, String> mydic = new Dictionary<string, string>();
                mydic.Add("Cutting", "Sheet");
                mydic.Add("Clip Cutting", "Cut strip");
                mydic.Add("Folding", "Clip cut strip");
                mydic.Add("Rimming", "Folded strip");
                string matType;
                mydic.TryGetValue(cmbMachineType.Text.Trim(),out matType);
                cmd = new MySqlCommand("INSERT INTO `dbcore`.`dt"+empID.ToString()+"` (`index`, `date`, `matType`, `Qty`, `finished`) VALUES ('"+index.ToString()+"', '"+DateTime.Today.Date.ToShortDateString()+"', '"+matType+"', '"+spnQty.Value.ToString()+"', 'no')",conn);
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
    }
}
