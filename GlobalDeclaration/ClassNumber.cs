using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysArch_Midterm.GlobalDeclaration
{
    internal class ClassNumber
    {
        public static void getMaxcollegeID()
        {
            try
            {
                string sql = "Select MAX(CollegeID)from College";
                Connection.Connection.DB();
                //folder name       //cs name          //class name
                GlobalDeclaration.Globaldeclaration.GlobalDeclarations.command = new OleDbCommand(sql, Connection.Connection.conn);
                GlobalDeclaration.Globaldeclaration.GlobalDeclarations.reader = GlobalDeclaration.Globaldeclaration.GlobalDeclarations.command.ExecuteReader();
                if (GlobalDeclaration.Globaldeclaration.GlobalDeclarations.reader.Read())
                {
                    sql = GlobalDeclaration.Globaldeclaration.GlobalDeclarations.reader[0].ToString();
                    if (sql == "")
                    {
                        GlobalDeclaration.Globaldeclaration.GlobalDeclarations.CollegeID = 1;
                    }
                    else
                    {
                        GlobalDeclaration.Globaldeclaration.GlobalDeclarations.CollegeID = Convert.ToInt32(GlobalDeclaration.Globaldeclaration.GlobalDeclarations.reader[0].ToString()) + 1;

                    }
                    GlobalDeclaration.Globaldeclaration.GlobalDeclarations.reader.Close();
                }
                Connection.Connection.conn.Close();
            }


            catch (Exception ex)
            {
                Connection.Connection.conn.Close();
                MessageBox.Show("Error ----> GET MAX ID" + ex.Message);
            }
        }

        public static void getMaxdepartmentID()
        {
            try
            {
                string sql = "Select MAX(DepartmentID)from Department";
                Connection.Connection.DB();
                //folder name       //cs name          //class name
                GlobalDeclaration.Globaldeclaration.GlobalDeclarations.command = new OleDbCommand(sql, Connection.Connection.conn);
                GlobalDeclaration.Globaldeclaration.GlobalDeclarations.reader = GlobalDeclaration.Globaldeclaration.GlobalDeclarations.command.ExecuteReader();
                if (GlobalDeclaration.Globaldeclaration.GlobalDeclarations.reader.Read())
                {
                    sql = GlobalDeclaration.Globaldeclaration.GlobalDeclarations.reader[0].ToString();
                    if (sql == "")
                    {
                        GlobalDeclaration.Globaldeclaration.GlobalDeclarations.DepartmentID = 1;
                    }
                    else
                    {
                        GlobalDeclaration.Globaldeclaration.GlobalDeclarations.DepartmentID = Convert.ToInt32(GlobalDeclaration.Globaldeclaration.GlobalDeclarations.reader[0].ToString()) + 1;

                    }
                    GlobalDeclaration.Globaldeclaration.GlobalDeclarations.reader.Close();
                }
                Connection.Connection.conn.Close();
            }


            catch (Exception ex)
            {
                Connection.Connection.conn.Close();
                MessageBox.Show("Error ----> GET MAX ID" + ex.Message);
            }
        }
    }
}
