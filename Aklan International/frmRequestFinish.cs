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
    public partial class frmRequestFinish : Form
    {
        public frmRequestFinish()
        {
            InitializeComponent();
        }
        public frmRequestFinish(String name) 
        {
            InitializeComponent();
            lblName.Text = name;
        }

        private void frmRequestFinish_Load(object sender, EventArgs e)
        {

        }
    }
}
