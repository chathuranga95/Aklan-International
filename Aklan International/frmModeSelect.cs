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
    public partial class frmModeSelect : Form
    {
        public frmModeSelect()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //admin window to work on
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmWorkerWindow obj = new frmWorkerWindow();
            obj.Show();
            this.Close();
        }
    }
}
