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
using Microsoft.VisualBasic;

namespace Aklan_International
{
    public partial class frmSupervisorWindow : Form
    {
        string empID;
        MySqlCommand cmd;
        MySqlConnection conn;
        MySqlDataReader reader;
        ArrayList jobList = new ArrayList();
        ArrayList orderList = new ArrayList();
        public frmSupervisorWindow()
        {
            InitializeComponent();
        }
        public frmSupervisorWindow(string empID)
        {
            InitializeComponent();
            this.empID = empID;
        }

        private void frmSupervisorWindow_Load(object sender, EventArgs e)
        {
            refreshJobs();
            refreshOrders();
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
                try
                {
                    jobList.Clear();
                    cmd = new MySqlCommand("select * from dt" + id + " where finished='no'", conn);
                    conn.Open();
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        jobList.Add(new Job(id, int.Parse(reader.GetString("index")), reader.GetString("matType"), reader.GetString("job"), int.Parse(reader.GetString("qty")), reader.GetString("finished") == "yes", reader.GetString("date")));
                    }

                }
                catch (Exception)
                {
                    continue;
                }
                finally
                {
                    conn.Close();
                }

            }
            lbxCurrentJobs.Items.Clear();
            foreach (Job job in jobList)
            {
                lbxCurrentJobs.Items.Add("EmpID :" + job.getEmpID() + "     Material Type :" + job.getMatType() + "     Qty :" + job.getQty() + "       Date :" + job.getDate());
            }
        }
        private void refreshOrders()
        {
            conn = new MySqlConnection("Server=localhost;Database=dbcore;Uid=root;Pwd=1234");
            cmd = new MySqlCommand("select * from dtcustomer_orders where finished = 'no'", conn);
            
            
            conn.Open();
            reader = cmd.ExecuteReader();
            orderList.Clear();
            while (reader.Read())
            {
                orderList.Add(new Order(int.Parse(reader.GetString("OrderId")), reader.GetString("CustomerId"), reader.GetString("CustomerName"), reader.GetString("CustomerContact"),reader.GetDateTime("OrderDateTime"), reader.GetInt32("SingleSheetQty"), reader.GetDecimal("SingleSheetUnit") , reader.GetInt32("DozenSheetQty"), reader.GetDecimal("DozenSheetUnit"), reader.GetDecimal("AmountPaid"),reader.GetString("description")));
            }
            conn.Close();
            
            lbxCurrentOrders.Items.Clear();
            foreach (Order order in orderList)
            {
                lbxCurrentOrders.Items.Add("OrderID : " + order.getOrderID() + "     Order description : "+order.getDescription());
            }
        }




        private void btnMark_Click(object sender, EventArgs e)
        {
            Job selectedJob = (Job)jobList[lbxCurrentJobs.SelectedIndex];
            MaterialUpdate mtup = new Aklan_International.MaterialUpdate(selectedJob.getEmpID());
            conn = new MySqlConnection("Server=localhost;Database=dbcore;Uid=root;Pwd=1234");
            selectedJob.setFinished(true);
            cmd = new MySqlCommand("UPDATE `dbcore`.`dt" + selectedJob.getEmpID() + "` SET `finished`='yes' WHERE `index`='" + selectedJob.getIndex() + "' ", conn);
            conn.Open();
            if (cmd.ExecuteNonQuery() >= 0)
            {
                int outMatqty;
                SalaryCalc.updateSalary(selectedJob.getEmpID(), selectedJob.getQty() * SalaryCalc.getRate(selectedJob.getJob()));
                while (true)
                {
                    try
                    {
                        outMatqty = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Enter output qty", "Get Info", "0", -1, -1));
                        break;
                    }
                    catch
                    {
                        MessageBox.Show("Enter a valid integer...");
                        continue;
                    }
                }
                mtup.updateMaterial(selectedJob.getOutputMaterialType(), outMatqty, empID, false);
                MessageBox.Show("success...");
            }
            conn.Close();
            refreshJobs();

        }

        private void btnMarkOrders_Click(object sender, EventArgs e)
        {
            Order selectedOrder = (Order)orderList[lbxCurrentOrders.SelectedIndex];
            MaterialUpdate mtup = new Aklan_International.MaterialUpdate(empID);
            conn = new MySqlConnection("Server=localhost;Database=dbcore;Uid=root;Pwd=1234");
            selectedOrder.setFinished();
            cmd = new MySqlCommand("UPDATE `dbcore`.`dtcustomer_orders` SET `finished`='yes' WHERE `OrderId`='" + selectedOrder.getOrderID() + "' ", conn);
            conn.Open();
            if (cmd.ExecuteNonQuery() >= 0)
            {
                mtup.updateMaterial("folded single",selectedOrder.getSingleQty(),empID,true);
                mtup.updateMaterial("folded 12", selectedOrder.getDozenQty(), empID, true);
                MessageBox.Show("success...");
            }
            conn.Close();
            refreshOrders();
        }
    }
}
