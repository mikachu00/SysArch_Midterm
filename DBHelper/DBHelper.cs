using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysArch_Midterm.DBHelper
{
    internal class DBHelper
    {
        public static string gen = "";
        public static OleDbConnection conn;
        public static OleDbCommand command;
        public static OleDbDataReader reader;

        public static void fill(string q, DataGridView dgv)
        {

            try
            {
                Connection.Connection.DB();
                DataTable dt = new DataTable();
                OleDbDataAdapter data = null;
                OleDbCommand command = new OleDbCommand(q,
               Connection.Connection.conn);
                data = new OleDbDataAdapter(command);
                data.Fill(dt);
                dgv.DataSource = dt;
                Connection.Connection.conn.Close();
            }
            catch (Exception ex)
            {
                Connection.Connection.conn.Close();
                MessageBox.Show(ex.Message, "Error FillDataGridView", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public static void ModifyRecord(string updates)
        {
            try
            {
                Connection.Connection.DB();
                OleDbCommand command = new OleDbCommand(updates, Connection.Connection.conn);
                command.ExecuteNonQuery();
                Connection.Connection.conn.Close();
            }
            catch (Exception ex)
            {
                Connection.Connection.conn.Close();
                MessageBox.Show("Error ---->" + updates + ex.Message);
            }
        }

        public static int ExecuteScalar(string query)
        {
            try
            {
                Connection.Connection.DB();
                OleDbCommand command = new OleDbCommand(query, Connection.Connection.conn);
                object result = command.ExecuteScalar();
                Connection.Connection.conn.Close();
                if (result != null && int.TryParse(result.ToString(), out int scalarValue))
                {
                    return scalarValue;
                }
                return 0;
            }
            catch (Exception ex)
            {
                Connection.Connection.conn.Close();
                MessageBox.Show("Error executing scalar query: " + ex.Message);
                return 0;
            }
        }

        public static DataTable GetDataTable(string query)
        {
            try
            {
                Connection.Connection.DB();
                DataTable dt = new DataTable();
                OleDbDataAdapter adapter = new OleDbDataAdapter(new OleDbCommand(query, Connection.Connection.conn));
                adapter.Fill(dt);
                Connection.Connection.conn.Close();
                return dt;
            }
            catch (Exception ex)
            {
                Connection.Connection.conn.Close();
                MessageBox.Show("Error retrieving data: " + ex.Message);
                return null;
            }
        }
    }
}
