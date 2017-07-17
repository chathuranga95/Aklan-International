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
    public partial class frmStockReport : Form
    {
        public frmStockReport()
        {
            InitializeComponent();
        }

        private void frmStockReport_Load(object sender, EventArgs e)
        {
            MaterialUpdate mtup = new MaterialUpdate("a001");
            int[] mtarr = mtup.retrieveMaterial();

            lblSheets.Text = "Sheets : " + mtarr[0].ToString();
            lblCutstrip.Text = "Cut Strips : " + mtarr[1].ToString();
            lblClipcut.Text = "Clip cuts : " + mtarr[2].ToString();
            lblFolded12.Text = "Folded 12 : " + mtarr[3].ToString();
            lblFoldedsingle.Text = "Folded single : " + mtarr[4].ToString();
        }

        private void lblFolded12_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            MaterialUpdate mtup = new MaterialUpdate("a001");
            int[] mtarr = mtup.retrieveMaterial();

            lblSheets.Text = "Sheets : " + mtarr[0].ToString();
            lblCutstrip.Text = "Cut Strips : " + mtarr[1].ToString();
            lblClipcut.Text = "Clip cuts : " + mtarr[2].ToString();
            lblFolded12.Text = "Folded 12 : " + mtarr[3].ToString();
            lblFoldedsingle.Text = "Folded single : " + mtarr[4].ToString();
        }
    }
}
