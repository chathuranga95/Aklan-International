using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Aklan_International
{
    class Support
    {
        public static bool isNumeric(String str)
        {
            float output;
            return float.TryParse(str, out output);
        }

        public static MySqlConnection setConnection()
        {
            return new MySqlConnection("Server=localhost;Database=dbcore;Uid=root;Pwd=1234");
        }

        public static int getHighestVlaueFrom(String coloumnName, String tableName)
        {
            int max;
            MySqlConnection con = setConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM "+tableName+" WHERE "+coloumnName+"= 'MAX("+coloumnName+")'", con);
            MySqlDataReader reader;
            con.Open();
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {

                max = int.Parse(reader.GetString(coloumnName));
            }

            else max = 0;
            con.Close();
            return max;

        }
    }

    
}
