using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aklan_International.CreateNewOrder
{
    public partial class FrmInvoice : Form
    {
        public FrmInvoice()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmInvoice_Load(object sender, EventArgs e)
        {

        }

        public void setDetails(String name, String contact, string datetime, int orderNo, object dataSource)
        {
            dgvInvoice.DataSource = dataSource;
            
        }
    }
}
