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
        private static frmManageWorkers instance;



        public static frmManageWorkers getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new frmManageWorkers();
            }
            return instance;
        }
        public frmManageWorkers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            frmAddNewWorker obj = frmAddNewWorker.getInstance();
            obj.Show();
            obj.BringToFront();

        }

        private void btnEditWorker_Click(object sender, EventArgs e)
        {
            frmEditWorkerDetails obj = frmEditWorkerDetails.getInstance();
            obj.Show();
            obj.BringToFront();
        }

        private void btnDeleteWorker_Click(object sender, EventArgs e)
        {
            
            frmDeleteWorker obj = frmDeleteWorker.getInstance();
            obj.Show();
            obj.BringToFront();
        }
    }
}
