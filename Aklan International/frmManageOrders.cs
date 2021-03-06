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
using System.Collections;

namespace Aklan_International
{
    public partial class frmManageOrders : Form
    {
        string empID;
        MySqlCommand cmd;
        MySqlConnection conn;
        MySqlDataReader reader;
        
        ArrayList orderList = new ArrayList();
        public static frmManageOrders instance;
        public static frmManageOrders getInstance(string empID)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new frmManageOrders(empID);
            }
            return instance;
        }
        public frmManageOrders()
        {
            InitializeComponent();
        }
        private frmManageOrders(string empID)
        {
            InitializeComponent();
            this.empID = empID;
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
                orderList.Add(new Order(int.Parse(reader.GetString("OrderId")), reader.GetString("CustomerId"), reader.GetString("CustomerName"), reader.GetString("CustomerContact"), reader.GetString("OrderDateTime").Trim(), reader.GetInt32("SingleSheetQty"), reader.GetDecimal("SingleSheetUnit"), reader.GetInt32("DozenSheetQty"), reader.GetDecimal("DozenSheetUnit"), reader.GetDecimal("AmountPaid"), reader.GetString("description")));
            }
            conn.Close();

            lbxCurrentOrders.Items.Clear();
            foreach (Order order in orderList)
            {
                lbxCurrentOrders.Items.Add("OrderID : " + order.getOrderID() + "     Order description : " + order.getDescription());
            }
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
                mtup.updateMaterial("folded single", selectedOrder.getSingleQty(), empID, true);
                mtup.updateMaterial("folded 12", selectedOrder.getDozenQty(), empID, true);
                MessageBox.Show("Success!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conn.Close();
            refreshOrders();
        }

        private void frmManageOrders_Load(object sender, EventArgs e)
        {
            refreshOrders();
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(this.btnMarkOrders, "Set Selected order as a completed order");
            if (lbxCurrentOrders.Items.Count > 0)
            {
                lbxCurrentOrders.SelectedIndex = 0;
            }
            else
            {
                btnMarkOrders.Enabled = false;
            }
        }
    }
}
