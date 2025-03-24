using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysArch_Midterm.Connection
{
    internal class Connection
    {
        public static OleDbConnection conn;
        public static string dbconnect = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\SysArch.accdb";

        public static void DB()
        {
            try
            {
                conn = new OleDbConnection(dbconnect);
                conn.Open();


            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
