using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysArch_Midterm.Departments
{
    public partial class DepartmentForm : Form
    {
        private string sql;
        public DepartmentForm()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtdeptname.Text) || string.IsNullOrWhiteSpace(txtdeptcode.Text))
            {
                MessageBox.Show("All fields must be filled out.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                sql = "INSERT INTO Department(DepartmentID, CollegeID, DepartmentName, DepartmentCode, IsActive) " +
                      "VALUES(" + txtdeptid.Text + ", " +
                      txtcollegeID.Text + ", " +
                      "'" + txtdeptname.Text + "', " +
                      "'" + txtdeptcode.Text + "', " +
                      "'" + (chkactive.Checked ? "1" : "0") + "')";

                DBHelper.DBHelper.ModifyRecord(sql);
                MessageBox.Show("Department added successfully.", "Save New Department", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DepartmentForm_Load(sender, e); // Refresh DataGridView
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DepartmentForm_Load(object sender, EventArgs e)
        {
            sql = "SELECT * FROM Department WHERE IsActive = True";
            DBHelper.DBHelper.fill(sql, dgvdept);
            GlobalDeclaration.ClassNumber.getMaxdepartmentID();
            txtdeptid.Text = GlobalDeclaration.Globaldeclaration.GlobalDeclarations.DepartmentID.ToString();
        }

        private void ClearFields()
        {
            txtcollegeID.Clear();
            txtdeptname.Clear();
            txtdeptcode.Clear();
            chkactive.Checked = false;
        }

    }
}
