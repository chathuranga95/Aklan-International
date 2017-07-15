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
    public partial class frmNotification : Form
    {
        OverManAlert notifi;
        public frmNotification()
        {
            InitializeComponent();
            this.notifi = OverManAlert.GetInstatance();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmNotification_Load(object sender, EventArgs e)
        {
            //grdNotify.Rows.Add("2017.07.15", "hai", Bitmap.FromFile(@"C:\Users\asus\Source\Repos\Aklan-International\Aklan International\Resources\delete_garbage.png"));
            //grdNotify.Rows.Add("2017.07.20", "hui", Bitmap.FromFile(@"C:\Users\asus\Source\Repos\Aklan-International\Aklan International\Resources\delete_garbage.png"));
            notifi.CheckOrderList();
            string message = notifi.sendalert();
            if (message != null)
            {
                grdNotify.Rows.Add(DateTime.Now.ToString(), message, Bitmap.FromFile(@"C:\Users\asus\Source\Repos\Aklan-International\Aklan International\Resources\delete_garbage.png"));
            }
        }

        private void btnClrAll_Click(object sender, EventArgs e)
        {
            grdNotify.Rows.Clear();
            grdNotify.Refresh();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            notifi.CheckOrderList();
            string message = notifi.sendalert();
            if(message != null)
            {
                grdNotify.Rows.Add(DateTime.Now.ToString(), message, Bitmap.FromFile(@"C:\Users\asus\Source\Repos\Aklan-International\Aklan International\Resources\delete_garbage.png"));
            }
            
        }

        private void grdNotify_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = grdNotify.SelectedCells[0].RowIndex;
            grdNotify.Rows.RemoveAt(row);
        }
    }
}
