using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Aklan_International
{
    class MaterialUpdate
    {
        MySqlCommand cmd;
        MySqlConnection conn;
        MySqlDataReader reader;
        string empID;

        public MaterialUpdate(string empID)
        {
            this.empID = empID;
            conn = new MySqlConnection("Server=localhost;Database=dbcore;Uid=root;Pwd=1234");
        }
        public int[] retrieveMaterial()
        {
            //array of material consists of the current
            //available material with the order,
            //sheet, cut strip, clip cut, folded 12, folded single
            int[] materialArray = new int[5];
            MySqlConnection conn1 = new MySqlConnection("Server=localhost;Database=dbcore;Uid=root;Pwd=1234");
            conn1.Open();
            cmd = new MySqlCommand("select material from dtmaterial", conn1);
            reader = cmd.ExecuteReader();
            string res = "";
            while (reader.Read())
            {
                res = reader.GetString(0);
            }
            conn1.Close();
            for (int i = 0; i < 5; i++)
            {
                materialArray[i] = int.Parse(res.Split(',')[i]);
            }

            return materialArray;
        }
        public int retrieveMaterialIndex()
        {
            conn.Open();
            int index = 0;
            //retrieve index from the table's last record 
            cmd = new MySqlCommand("select * from dtmaterial", conn);

            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                index = reader.GetInt32("index");
            }
            conn.Close();
            index++; //increament index
            return index;
        }
        public void updateMaterial(string matType, int qty, string empID,bool getting)
        {
            MySqlCommand cmd;
            MySqlConnection conn2;

            //array of material consists of the current
            //available material with the order,
            //sheet, cut strip, clip cut, folded 12, folded single
            int index = retrieveMaterialIndex();
            int[] matArr = retrieveMaterial();
            string cmdtxt = "";
            if (getting)
            {
                if (matType == "sheet")
                {
                    cmdtxt = "INSERT INTO `dbcore`.`dtmaterial` (`index`, `empID`, `date`,`description`, `material`) VALUES ('" + index + "', '" + empID + "', '" + DateTime.Today.Date.ToShortDateString() + "', '"+qty.ToString()+" of "+matType+" taken', '" + (matArr[0] - qty).ToString() + "," + matArr[1].ToString() + "," + matArr[2].ToString() + "," + matArr[3].ToString() + "," + matArr[4].ToString() + "')";
                }
                else if (matType == "cut strip")
                {
                    cmdtxt = "INSERT INTO `dbcore`.`dtmaterial` (`index`, `empID`, `date`,`description`, `material`) VALUES ('" + index + "', '" + empID + "', '" + DateTime.Today.Date.ToShortDateString() + "', '" + qty.ToString() + " of " + matType + " taken', '" + (matArr[0]).ToString() + "," + (matArr[1] - qty).ToString() + "," + matArr[2].ToString() + "," + matArr[3].ToString() + "," + matArr[4].ToString() + "')";
                }
                else if (matType == "clip cut")
                {
                    cmdtxt = "INSERT INTO `dbcore`.`dtmaterial` (`index`, `empID`, `date`,`description`, `material`) VALUES ('" + index + "', '" + empID + "', '" + DateTime.Today.Date.ToShortDateString() + "',  '" + qty.ToString() + " of " + matType + " taken', '" + (matArr[0]).ToString() + "," + matArr[1].ToString() + "," + (matArr[2] - qty).ToString() + "," + matArr[3].ToString() + "," + matArr[4].ToString() + "')";
                }
                else if (matType == "folded 12")
                {
                    cmdtxt = "INSERT INTO `dbcore`.`dtmaterial` (`index`, `empID`, `date`,`description`, `material`) VALUES ('" + index + "', '" + empID + "', '" + DateTime.Today.Date.ToShortDateString() + "',  '" + qty.ToString() + " of " + matType + " taken', '" + matArr[0].ToString() + "," + matArr[1].ToString() + "," + matArr[2].ToString() + "," + (matArr[3] - qty).ToString() + "," + matArr[4].ToString() + "')";
                }
                else if (matType == "folded single")
                {
                    cmdtxt = "INSERT INTO `dbcore`.`dtmaterial` (`index`, `empID`, `date`,`description`, `material`) VALUES ('" + index + "', '" + empID + "', '" + DateTime.Today.Date.ToShortDateString() + "',  '" + qty.ToString() + " of " + matType + " taken', '" + (matArr[0]).ToString() + "," + matArr[1].ToString() + "," + matArr[2].ToString() + "," + matArr[3].ToString() + "," + (matArr[4] - qty).ToString() + "')";
                }
            }
            else
            {
                if (matType == "sheet")
                {
                    cmdtxt = "INSERT INTO `dbcore`.`dtmaterial` (`index`, `empID`, `date`,`description`, `material`) VALUES ('" + index + "', '" + empID + "', '" + DateTime.Today.Date.ToShortDateString() + "', '" + qty.ToString() + " of " + matType + " inserted by Admin', '" + (matArr[0] + qty).ToString() + "," + matArr[1].ToString() + "," + matArr[2].ToString() + "," + matArr[3].ToString() + "," + matArr[4].ToString() + "')";
                }
                else if (matType == "cut strip")
                {
                    cmdtxt = "INSERT INTO `dbcore`.`dtmaterial` (`index`, `empID`, `date`,`description`, `material`) VALUES ('" + index + "', '" + empID + "', '" + DateTime.Today.Date.ToShortDateString() + "', '" + qty.ToString() + " of " + matType + " made', '" + (matArr[0]).ToString() + "," + (matArr[1] + qty).ToString() + "," + matArr[2].ToString() + "," + matArr[3].ToString() + "," + matArr[4].ToString() + "')";
                }
                else if (matType == "clip cut")
                {
                    cmdtxt = "INSERT INTO `dbcore`.`dtmaterial` (`index`, `empID`, `date`,`description`, `material`) VALUES ('" + index + "', '" + empID + "', '" + DateTime.Today.Date.ToShortDateString() + "',  '" + qty.ToString() + " of " + matType + " made', '" + (matArr[0]).ToString() + "," + matArr[1].ToString() + "," + (matArr[2] + qty).ToString() + "," + matArr[3].ToString() + "," + matArr[4].ToString() + "')";
                }
                else if (matType == "folded 12")
                {
                    cmdtxt = "INSERT INTO `dbcore`.`dtmaterial` (`index`, `empID`, `date`,`description`, `material`) VALUES ('" + index + "', '" + empID + "', '" + DateTime.Today.Date.ToShortDateString() + "',  '" + qty.ToString() + " of " + matType + " made', '" + matArr[0].ToString() + "," + matArr[1].ToString() + "," + matArr[2].ToString() + "," + (matArr[3] + qty).ToString() + "," + matArr[4].ToString() + "')";
                }
                else if (matType == "folded single")
                {
                    cmdtxt = "INSERT INTO `dbcore`.`dtmaterial` (`index`, `empID`, `date`,`description`, `material`) VALUES ('" + index + "', '" + empID + "', '" + DateTime.Today.Date.ToShortDateString() + "',  '" + qty.ToString() + " of " + matType + " made', '" + (matArr[0]).ToString() + "," + matArr[1].ToString() + "," + matArr[2].ToString() + "," + matArr[3].ToString() + "," + (matArr[4] + qty).ToString() + "')";
                }
            }
            conn2 = new MySqlConnection("Server=localhost;Database=dbcore;Uid=root;Pwd=1234");
            cmd = new MySqlCommand(cmdtxt, conn2);
            conn2.Open();
            cmd.ExecuteNonQuery();
            conn2.Close();
        }
    }
}
