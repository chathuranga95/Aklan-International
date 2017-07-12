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
using System.Collections;

namespace Aklan_International
{
    public partial class FrmSetUnitPrice : Form
    {
        private MySqlConnection con;
        private MySqlCommand command;
        private MySqlDataReader reader;
        private decimal[] unitPrices; 

        public FrmSetUnitPrice()
        {
            InitializeComponent();
            unitPrices = new decimal[2];
            con = new MySqlConnection("Server=localhost;Database=dbcore;Uid=root;Pwd=1234");
        

        }

        private void FrmSetUnitPrice_Load(object sender, EventArgs e)
        {
            command = new MySqlCommand("select * from dtunitprices ", con);
            con.Open();
            reader = command.ExecuteReader();

            int i = 0;            
            while(reader.Read() && i<2)
            {
                
                try {
                    decimal iUnitPrice = reader.GetDecimal("unitprice");
                    unitPrices[i] = iUnitPrice;
                    Console.WriteLine("Unit Price " + i + "= " + iUnitPrice);                    
                    i++;
                }catch(System.Data.SqlTypes.SqlNullValueException )
                {                    
                    unitPrices[i] = 0;
                    i++;
                    continue;

                }

            }
            con.Close();

            if (unitPrices[0] == 0)
                this.tbxSingleCurrentPrice.Text = "Price not set!";
            else
                this.tbxSingleCurrentPrice.Text = unitPrices[0].ToString();

            if (unitPrices[1] == 0)
                this.tbx12Current.Text = "Price not set!";
            else
                this.tbx12Current.Text = unitPrices[0].ToString();
        }

        private void btnSingleUpdate_Click(object sender, EventArgs e)
        {
           
        }
    }
}
