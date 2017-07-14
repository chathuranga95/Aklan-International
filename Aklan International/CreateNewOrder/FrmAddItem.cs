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

namespace Aklan_International.CreateNewOrder
{
    public partial class FrmAddItem : Form
    {
        private MySqlConnection con;
        private MySqlCommand cmd;
        private MySqlDataReader reader;

        public FrmAddItem()
        {
            InitializeComponent();
            con = new MySqlConnection("Server=localhost;Database=dbcore;Uid=root;Pwd=1234");
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmCreateOrder frmCreateOrder = (FrmCreateOrder)this.Owner;
            frmCreateOrder.addDgvRow(cmbType.Text, tbxUnitPrice.Text , mtbQty.Text,  tbxTotal.Text);
            mtbQty.Clear();
            tbxTotal.Clear();
            tbxUnitPrice.Clear();
            cmbType.Text = null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
