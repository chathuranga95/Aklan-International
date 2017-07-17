using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aklan_International
{
    public partial class frmSalaryView : Form
    {
        MySqlCommand cmd;
        MySqlConnection conn;
        MySqlDataReader reader;

        public static frmSalaryView instance;
        public static frmSalaryView getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new frmSalaryView();
            }
            return instance;
        }

        private frmSalaryView()
        {
            InitializeComponent();
        }

        private void frmSalaryView_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(this.btnRefresh, "View Salaries of all employers for selected month");
            toolTip.SetToolTip(this.spnMonth, "Select Month number");
            toolTip.SetToolTip(this.spnYear, "Select Year number");
            spnMonth.Value = DateTime.Today.Month;
            spnYear.Value = DateTime.Today.Year;
            conn = new MySqlConnection("Server=localhost;Database=dbcore;Uid=root;Pwd=1234");
            btnRefresh.PerformClick();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            grdSalary.Rows.Clear();

            cmd = new MySqlCommand("select * from dtsalary where `index` like '" + spnMonth.Value.ToString() + "/" + spnYear.Value.ToString() + "%'", conn);
            ArrayList empIDList = new ArrayList();
            conn.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                empIDList.Add(reader.GetString("index").Split('/')[2]);
            }
            conn.Close();

            foreach (string empID in empIDList)
            {
                cmd = new MySqlCommand("select * from dtsalary where `index` = '" + spnMonth.Value.ToString() + "/" + spnYear.Value.ToString() + "/" + empID + "'", conn);
                string salary = "";
                conn.Open();
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    salary = reader.GetString("salary");
                }
                conn.Close();
                
                cmd = new MySqlCommand("select * from worker_details where empID = '" + empID + "'", conn);
                conn.Open();
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    
                    grdSalary.Rows.Add(empID, reader.GetString("first_name"), reader.GetString("acc_NO"), reader.GetString("tel_NO"), salary);
                }
                conn.Close();
            }
        }
    }
}
