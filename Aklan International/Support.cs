﻿using System;
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

        public static int getMaxVlaueFrom(String coloumnName, String tableName)
        {
            int max;
            MySqlConnection con = setConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT MAX("+coloumnName+") AS OrderId FROM "+tableName+"", con);
            MySqlDataReader reader;
            con.Open();
            reader = cmd.ExecuteReader();
            try {
                if (reader.Read())
                {
                    try
                    {

                        max = int.Parse(reader.GetString(coloumnName));
                    }
                    catch (System.Data.SqlTypes.SqlNullValueException) { max = 0; }
                }

                else max = 0;
            }catch ( MySql.Data.MySqlClient.MySqlException) { max = -1; }
            con.Close();
            return max;

        }

        public static bool isValidAmount(string str)
        {
            decimal value = decimal.Parse(str) * 100;
            return value == Math.Floor(value);
        }
        public static bool isValidNIC(String NIC)
        {
            if (NIC.Length == 9 && Support.isNumeric(NIC))
                return true;
            else if (NIC.Length == 10 && Support.isNumeric(NIC.Substring(0, 9)))
            {
                if (NIC.Substring(9, 1) == "v" || NIC.Substring(9, 1) == "V" || NIC.Substring(9, 1) == "x" || NIC.Substring(9, 1) == "X")
                    return true;
                else return false;
            }
            else return false;
        }
        public static bool isValidTel(String str)
        {
            if(Support.isNumeric(str) && str.Length == 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}

    
