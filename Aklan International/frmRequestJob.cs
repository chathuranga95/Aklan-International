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
    public partial class frmRequestJob : Form
    {
        Form frmobj;
        public frmRequestJob()
        {
            InitializeComponent();
        }

        public frmRequestJob(String workerName, Form frmobj)
        {
            InitializeComponent();
            lblWorkerName.Text = workerName;
            this.frmobj = frmobj;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmobj.Show();
        }

        private void frmRequestJob_Load(object sender, EventArgs e)
        {

        }
    }
}
