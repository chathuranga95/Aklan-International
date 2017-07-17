using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Aklan_International
{
    class OverManAlert
    {
        private static OverManAlert instance;
        private int count = 0;

        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader reader;

        bool finished;
        

        public OverManAlert()
        {
            conn = new MySqlConnection("server=localhost;user id=root;database=dbcore;pwd=1234;allowuservariables=True");
            
        }
        public static OverManAlert GetInstatance()
        {
            if(instance == null)
            {
                instance = new OverManAlert();
            }
            return instance;
        }
        public bool CheckOrderList()
        {
            conn.Open();
            cmd = new MySqlCommand("SELECT * from dtcustomer_orders where finished = 'no'", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            this.count = 0;
            {
                count++;
            }

            if (count == 0)
            {
                finished = true;
            }
            else
            {
                finished = false;
            }
            
         
            conn.Close();
            return finished;
        }

        public string sendalert()
        {
            string message;
            if (finished)
            {
                message = "All orders are done!!!";
                //Console.WriteLine("All orders are done!!");
                return message;
            }
            else
            {
                if(count == 1)
                {
                    message = this.count.ToString() + " order is still on processing";
                    
                }
                else if (count > 1)
                {
                    message = this.count.ToString() + " order are still on processing";
                    
                }
                else
                {
                    return null;
                }
                
            }
            return message;
            
        }
    }
}
