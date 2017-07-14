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
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader reader;

        bool finished;

        public OverManAlert()
        {
            conn = new MySqlConnection("server=localhost;user id=root;database=dbcore;pwd=1234;allowuservariables=True");
            conn.Open();
        }
        public bool CheckOrderList()
        {
            cmd = new MySqlCommand("SELECT * from dtcustomer_orders where finished = 'no'", conn);
            reader = cmd.ExecuteReader();
        }
    }
}
