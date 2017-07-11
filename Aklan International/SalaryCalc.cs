using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Aklan_International
{
    class SalaryCalc
    {
        public static decimal getRate(String job)
        {
            decimal jobRate = 0;

            MySqlCommand cmd;
            MySqlConnection conn;
            MySqlDataReader reader;

            conn = new MySqlConnection("Server=localhost;Database=dbcore;Uid=root;Pwd=1234");
            cmd = new MySqlCommand("select * from dtjobrates where job='" + job + "'", conn);
            conn.Open();
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                jobRate = decimal.Parse(reader.GetString("rate"));
            }
            conn.Close();
            return jobRate;
        }
        

        public static void updateSalary(string empID, decimal addition)
        {
            MySqlCommand cmd;
            MySqlConnection conn;
            string index = DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString() + "/" + empID;
            conn = new MySqlConnection("Server=localhost;Database=dbcore;Uid=root;Pwd=1234");

            cmd = new MySqlCommand("UPDATE `dbcore`.`dtsalary` SET `salary`='"+(checkTable(empID) + addition).ToString()+"' WHERE `index`='"+index+"' ", conn);
            
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
                                                                                                                                                                                                                                                            
        }

        private static decimal checkTable(string empID)
        {
            decimal lastSalary = 0;
            MySqlCommand cmd;
            MySqlConnection conn;
            MySqlDataReader reader;
            bool rowExist = false;
            conn = new MySqlConnection("Server=localhost;Database=dbcore;Uid=root;Pwd=1234");
            string index = DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString() + "/" + empID;

            cmd = new MySqlCommand("select * from dtsalary where `index`='"+index+"'", conn);

            conn.Open();
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                rowExist = true;
                lastSalary = decimal.Parse(reader.GetString("salary"));
                
            }
            
            conn.Close();

            if (!rowExist)
            {
                cmd = new MySqlCommand("INSERT INTO `dbcore`.`dtsalary` (`index`, `salary`) VALUES ('"+index+"','0');", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            return lastSalary;
        }
    }
}
