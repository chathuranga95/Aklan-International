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
using Excel = Microsoft.Office.Interop.Excel;

namespace Aklan_International
{
    public partial class frmOrderReport : Form
    {
        private static frmOrderReport instance;



        public static frmOrderReport getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new frmOrderReport();
            }
            return instance;
        }
        public frmOrderReport()
        {
            InitializeComponent();
        }

        private void frmOrderReport_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;pwd=1234;database=dbcore;allowuservariables=True");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT OrderId, OrderDateTime, CustomerName, CustomerContact, description, SingleSheetQty, SingleSheetUnit, DozenSheetQty, DozenSheetUnit,TotalPrice FROM dtcustomer_orders WHERE finished='yes' OR 'Yes' or 'YES'", conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                string str = "";
                for (int i = 0; i < 10; i++)
                {
                    str += reader.GetString(i) + ",";
                }

                grdReport.Rows.Add(str.Split(','));
            }
            conn.Close();
        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection cnn;
                string connectionString = null;
                string sql = null;
                string data = null;
                int i = 0;
                int j = 0;

                Excel.Application xlApp;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                xlApp = new Excel.Application();
                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);


                connectionString = "server=localhost;user id=root;pwd=1234;database=dbcore;allowuservariables=True";
                cnn = new MySqlConnection(connectionString);
                cnn.Open();
                sql = "SELECT OrderId, OrderDateTime, CustomerName, CustomerContact, description, SingleSheetQty, SingleSheetUnit, DozenSheetQty, DozenSheetUnit,TotalPrice FROM dtcustomer_orders WHERE finished='yes'";
                MySqlDataAdapter dscmd = new MySqlDataAdapter(sql, cnn);
                DataSet ds = new DataSet();
                dscmd.Fill(ds);

                foreach (DataTable dt in ds.Tables)
                {
                    for (int i1 = 0; i1 < dt.Columns.Count; i1++)
                    {
                        xlWorkSheet.Cells[1, i1 + 1] = dt.Columns[i1].ColumnName;
                    }
                }

                for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    int s = i + 1;
                    for (j = 0; j <= ds.Tables[0].Columns.Count - 1; j++)
                    {
                        data = ds.Tables[0].Rows[i].ItemArray[j].ToString();
                        xlWorkSheet.Cells[s + 1, j + 1] = data;
                    }
                }
                //xlWorkSheet.Visible = Microsoft.Office.Interop.Excel.XlSheetVisibility.xlSheetVisible;
                xlWorkBook.SaveAs("dtcustomer_orders.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                //xlWorkBook.Open();
                //xlWorkBook.SaveAs("test.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                //xlWorkBook.SaveAs(@"c:\test.xls");
                //xlWorkBook.Close(true, misValue, misValue);
                MessageBox.Show("Excel file created , you can find the file at Documents/dtcustomer_orders.xls");
                xlApp.Visible = true;
                //xlApp.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);

                cnn.Close();

                //
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error occured.......");

            }

        }
    }
}
