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
    public partial class frmManageStock : Form
    {
        string empID;
        public frmManageStock()
        {
            InitializeComponent();
        }
        public frmManageStock(string empID)
        {
            InitializeComponent();
            this.empID = empID;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MaterialUpdate mtup = new MaterialUpdate(empID);
            mtup.updateMaterial("sheet", (int)spnQty.Value, empID, false);
            MessageBox.Show("Success!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmManageStock_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();
            toolTip.SetToolTip(this.btnAdd, "Add "+spnQty.Value.ToString()+" New sheets to the Stock");
        }

        private void spnQty_ValueChanged(object sender, EventArgs e)
        {
            toolTip.SetToolTip(this.btnAdd, "Add " + spnQty.Value.ToString() + " New sheets to the Stock");
        }
    }
}
