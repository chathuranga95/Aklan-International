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
    public partial class frmAbout : Form
    {
        private static frmAbout instance;
        public static frmAbout getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new frmAbout();
            }
            return instance;
        }
        private frmAbout()
        {
            InitializeComponent();
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {

        }
    }
}
