using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Aklan_International
{
    public partial class frmDeleteWorker : Form
    {
        MySqlCommand cmd;
        MySqlConnection conn;
        MySqlDataReader reader;
        public Boolean checkAvailability()
        {
            Boolean availability = false;
            conn = new MySqlConnection("Server=localhost;Database=dbcore;Uid=root;Pwd=1234");
            cmd.CommandText = ""


            return availability;
        }
        public frmDeleteWorker()
        {
            InitializeComponent();
        }

        private void frmDeleteWorker_Load(object sender, EventArgs e)
        {

        }
    }
}
