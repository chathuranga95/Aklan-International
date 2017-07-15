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
        private decimal newSingleUnitPrice, new12UnitPrice;

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
                this.tbx12Current.Text = unitPrices[1].ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbxSingleNewPrice.Clear();
        }

        private void btnClear12New_Click(object sender, EventArgs e)
        {
            tbx12New.Clear();
        }

        private void btn12Update_Click(object sender, EventArgs e)
        {
            if (tbx12New.Text.Split().Length > 0)
            {
                try
                {
                    if (decimal.Parse(tbx12New.Text) > 0)
                    {

                        new12UnitPrice = decimal.Parse(tbx12New.Text);
                        MessageBox.Show("12 Sheet Strip Unit Price Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnSave.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Please enter a non-zero Price!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        tbx12New.Clear();
                    }
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Please enter a valid value for new unit price!", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tbx12New.Clear();
                }
            }
            else
                MessageBox.Show("Please enter a valid value for new unit price!", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Question);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (newSingleUnitPrice >0)
            {
                Console.WriteLine("Single UP "+newSingleUnitPrice);
                command = new MySqlCommand("UPDATE `dbcore`.`dtunitprices` SET `UnitPrice`= '" + newSingleUnitPrice + "' WHERE `TypeId`= '1'",con);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
            }

            if (new12UnitPrice >0)
            {
                Console.WriteLine("12 UP " + new12UnitPrice);
                command = new MySqlCommand("UPDATE `dbcore`.`dtunitprices` SET `UnitPrice`= '" + new12UnitPrice + "' WHERE `TypeId`= '2'",con);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();

            }


        }

        private void btnSingleUpdate_Click(object sender, EventArgs e)
        {
           if(tbxSingleNewPrice.Text.Split().Length > 0)
            {
                try
                {
                    if (decimal.Parse(tbxSingleNewPrice.Text) > 0)
                    {

                        newSingleUnitPrice = decimal.Parse(tbxSingleNewPrice.Text);
                        MessageBox.Show("Sinlge Sheet Strip Unit Price Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnSave.Enabled = true;
                    }

                    else
                    {
                        MessageBox.Show("Please enter a non-zero Price!", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        tbxSingleNewPrice.Clear();
                    }
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Please enter a valid value for new unit price!", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tbxSingleNewPrice.Clear();
                }
            }
            else
                MessageBox.Show("Please enter a valid value for new unit price!", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Question);

        }
    }
}
