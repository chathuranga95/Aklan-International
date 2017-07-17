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
            frmLogin obj = new frmLogin();
            obj.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmWorkerWindow obj = new frmWorkerWindow();
            obj.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
           
            this.Close();


            
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            //btnClose.BackColor = System.Drawing.Color.Transparent;
            //btnClose.FlatStyle = FlatStyle.Flat;
            
            Image image = Aklan_International.Properties.Resources.CloseButtonSelected2;
            btnClose.BackgroundImage = image;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {

            Image image = Aklan_International.Properties.Resources.CloseButton;
            btnClose.BackgroundImage = image;

        }

        private void btnAdmin_MouseEnter(object sender, EventArgs e)
        {
            Image image = Aklan_International.Properties.Resources.ModeButtonSelected;
            btnAdmin.BackgroundImage = image;
        }

        private void btnAdmin_MouseLeave(object sender, EventArgs e)
        {
            Image image = Aklan_International.Properties.Resources.ModeButton;
            btnAdmin.BackgroundImage = image;
        }

        private void btnWorker_MouseEnter(object sender, EventArgs e)
        {

            Image image = Aklan_International.Properties.Resources.ModeButtonSelected;
            btnWorker.BackgroundImage = image;
        }

        private void btnWorker_MouseLeave(object sender, EventArgs e)
        {
            Image image = Aklan_International.Properties.Resources.ModeButton;
            btnWorker.BackgroundImage = image;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            frmLogin obj = new frmLogin();
            obj.Show();
            this.Hide();
        }

        private void btnAdmin_Enter(object sender, EventArgs e)
        {
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.FlatAppearance.BorderSize = 0;
            Image image = Aklan_International.Properties.Resources.ModeButtonSelected;
            btnAdmin.BackgroundImage = image;
        }



        private void btnWorker_Enter(object sender, EventArgs e)
        {
            btnWorker.FlatStyle = FlatStyle.Flat;
            btnWorker.FlatAppearance.BorderSize = 0;
            Image image = Aklan_International.Properties.Resources.ModeButtonSelected;
            btnWorker.BackgroundImage = image;
        }

        private void btnAdmin_Leave(object sender, EventArgs e)
        {
            Image image = Aklan_International.Properties.Resources.ModeButtonSelected;
            btnAdmin.BackgroundImage = image;
        }

        private void btnWorker_Leave(object sender, EventArgs e)
        {
            Image image = Aklan_International.Properties.Resources.ModeButton;
            btnWorker.BackgroundImage = image;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.Show();
        }

        private void btnAbout_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void panelbottom_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAbout_MouseHover(object sender, EventArgs e)
        {
           
        }
    }
}
