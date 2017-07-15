using System;
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
    public partial class frmManageWorkers : Form
    {
        public frmManageWorkers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Run(new frmAddNewWorker());

        }

        private void btnEditWorker_Click(object sender, EventArgs e)
        {
            Application.Run(new frmEditWorkerDetails());
        }
    }
}
