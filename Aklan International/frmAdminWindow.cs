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
    public partial class frmAdminWindow : Form
    {
        public frmAdminWindow()
        {
            InitializeComponent();
        }
        public frmAdminWindow(string adminName)
        {
            InitializeComponent();
            this.Text = adminName;
        }
    }
}
