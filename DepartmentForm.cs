using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SysArch_Midterm.CollegeMain;

namespace SysArch_Midterm.Departments
{
    public partial class DepartmentForm : Form
    {
        private string sql;
        private string esql;
        public DepartmentForm()
        {
            InitializeComponent();
        }

        private void DepartmentForm_Load(object sender, EventArgs e)
        {
            sql = "SELECT * FROM Department WHERE IsActive = True";
            DBHelper.DBHelper.fill(sql, dgvdept);

            GlobalDeclaration.ClassNumber.getMaxdepartmentID();
            txtdeptid.Text = GlobalDeclaration.Globaldeclaration.GlobalDeclarations.DepartmentID.ToString();

            FillCollegeComboBox();

            esql = "SELECT CollegeId, CollegeName FROM College";
            DBHelper.DBHelper.fill(sql, dgvCollege);
        }

        private void FillCollegeComboBox()
        {
            try
            {
                sql = "SELECT CollegeID, CollegeName FROM College"; 
                DataTable dt = DBHelper.DBHelper.GetDataTable(sql);

                cmbcollegeID.DataSource = dt;
                cmbcollegeID.DisplayMember = "CollegeID";
                cmbcollegeID.ValueMember = "CollegeID";//collegeid
                cmbcollegeID.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading colleges: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtdeptname.Text) || string.IsNullOrWhiteSpace(txtdeptcode.Text) || cmbcollegeID.SelectedIndex == -1)
            {
                MessageBox.Show("All fields must be filled out.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                sql = "INSERT INTO Department (DepartmentID, CollegeID, DepartmentName, DepartmentCode, IsActive) " +
                      "VALUES (" + txtdeptid.Text + ", " +
                      cmbcollegeID.SelectedValue + ", " +
                      "'" + txtdeptname.Text + "', " +
                      "'" + txtdeptcode.Text + "', " +
                      "'" + (chkactive.Checked ? "1" : "0") + "')";

                DBHelper.DBHelper.ModifyRecord(sql);
                MessageBox.Show("Department added successfully.", "Save New Department", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DepartmentForm_Load(sender, e);
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtdeptname.Text) || string.IsNullOrWhiteSpace(txtdeptcode.Text) || cmbcollegeID.SelectedIndex == -1)
            {
                MessageBox.Show("All fields must be filled out.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                sql = "UPDATE Department SET CollegeID = " + cmbcollegeID.SelectedValue +
                      ", DepartmentName = '" + txtdeptname.Text +
                      "', DepartmentCode = '" + txtdeptcode.Text +
                      "', IsActive = '" + (chkactive.Checked ? "1" : "0") +
                      "' WHERE DepartmentID = " + txtdeptid.Text;

                DBHelper.DBHelper.ModifyRecord(sql);
                MessageBox.Show("Department updated successfully.", "Update Department", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DepartmentForm_Load(sender, e);
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                sql = "DELETE FROM Department WHERE DepartmentID = " + txtdeptid.Text;
                DBHelper.DBHelper.ModifyRecord(sql);
                MessageBox.Show("Department deleted successfully.", "Delete Department", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DepartmentForm_Load(sender, e);
                ClearFields();
            }
        }

        private void ClearFields()
        {
            cmbcollegeID.SelectedIndex = -1;
            txtdeptname.Clear();
            txtdeptcode.Clear();
            chkactive.Checked = false;
        }

        private void dgvdept_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvdept.Rows[e.RowIndex];

                txtdeptid.Text = row.Cells["DepartmentID"].Value.ToString();
                txtdeptname.Text = row.Cells["DepartmentName"].Value.ToString();
                txtdeptcode.Text = row.Cells["DepartmentCode"].Value.ToString();
                cmbcollegeID.SelectedValue = row.Cells["CollegeID"].Value;
                chkactive.Checked = row.Cells["IsActive"].Value.ToString() == "True";

            }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Close();
        }
    }
}
