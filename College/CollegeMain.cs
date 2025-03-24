using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysArch_Midterm.CollegeMain
{
    public partial class CollegeMain : Form
    {
        private string sql;
        public CollegeMain()
        {
            InitializeComponent();
        }

        private void CollegeMain_Load(object sender, EventArgs e)
        {
            sql = "SELECT * FROM college WHERE IsActive = True";
            DBHelper.DBHelper.fill(sql, dgvcollege);

            GlobalDeclaration.ClassNumber.getMaxcollegeID();
            txtcollegeID.Text = GlobalDeclaration.Globaldeclaration.GlobalDeclarations.CollegeID.ToString();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtcollegename.Text) || string.IsNullOrWhiteSpace(txtcollegecode.Text))
            {
                MessageBox.Show("All fields must be filled out.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                sql = "INSERT INTO college(CollegeID, CollegeName, CollegeCode, IsActive)" +
                          "VALUES(" + txtcollegeID.Text + "," +
                          " '" + txtcollegename.Text + "'," +
                          " '" + txtcollegecode.Text + "'," +
                          " '" + (chkactive.Checked ? "1" : "0") + "')";

                DBHelper.DBHelper.ModifyRecord(sql);
                MessageBox.Show("Data has been added...", "Save new college", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CollegeMain_Load(sender, e); // Refresh the data grid
                clearfields();        // Clear input fields
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void clearfields()
        {
            txtcollegename.Clear();
            txtcollegecode.Clear();
            chkactive.Checked = false;
        }
    }
}
