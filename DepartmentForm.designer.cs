namespace SysArch_Midterm.Departments
{
    partial class DepartmentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtdeptcode = new System.Windows.Forms.TextBox();
            this.txtdeptname = new System.Windows.Forms.TextBox();
            this.txtdeptid = new System.Windows.Forms.TextBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.chkactive = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvdept = new System.Windows.Forms.DataGridView();
            this.cmbcollegeID = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdept)).BeginInit();
            this.SuspendLayout();
            // 
            // txtdeptcode
            // 
            this.txtdeptcode.Location = new System.Drawing.Point(309, 372);
            this.txtdeptcode.Name = "txtdeptcode";
            this.txtdeptcode.Size = new System.Drawing.Size(234, 22);
            this.txtdeptcode.TabIndex = 32;
            // 
            // txtdeptname
            // 
            this.txtdeptname.Location = new System.Drawing.Point(309, 344);
            this.txtdeptname.Name = "txtdeptname";
            this.txtdeptname.Size = new System.Drawing.Size(234, 22);
            this.txtdeptname.TabIndex = 31;
            // 
            // txtdeptid
            // 
            this.txtdeptid.Location = new System.Drawing.Point(309, 283);
            this.txtdeptid.Name = "txtdeptid";
            this.txtdeptid.Size = new System.Drawing.Size(234, 22);
            this.txtdeptid.TabIndex = 29;
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(468, 446);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(79, 23);
            this.btndelete.TabIndex = 28;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(375, 446);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 27;
            this.btnedit.Text = "EDIT";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(284, 446);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 26;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // chkactive
            // 
            this.chkactive.AutoSize = true;
            this.chkactive.Location = new System.Drawing.Point(477, 400);
            this.chkactive.Name = "chkactive";
            this.chkactive.Size = new System.Drawing.Size(66, 20);
            this.chkactive.TabIndex = 25;
            this.chkactive.Text = "Active";
            this.chkactive.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Department Code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Department Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "College ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Department ID:";
            // 
            // dgvdept
            // 
            this.dgvdept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdept.Location = new System.Drawing.Point(90, 24);
            this.dgvdept.Name = "dgvdept";
            this.dgvdept.RowHeadersWidth = 51;
            this.dgvdept.RowTemplate.Height = 24;
            this.dgvdept.Size = new System.Drawing.Size(657, 207);
            this.dgvdept.TabIndex = 20;
            // 
            // cmbcollegeID
            // 
            this.cmbcollegeID.FormattingEnabled = true;
            this.cmbcollegeID.Location = new System.Drawing.Point(309, 316);
            this.cmbcollegeID.Name = "cmbcollegeID";
            this.cmbcollegeID.Size = new System.Drawing.Size(234, 24);
            this.cmbcollegeID.TabIndex = 33;
            // 
            // DepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 533);
            this.Controls.Add(this.cmbcollegeID);
            this.Controls.Add(this.txtdeptcode);
            this.Controls.Add(this.txtdeptname);
            this.Controls.Add(this.txtdeptid);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.chkactive);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvdept);
            this.Name = "DepartmentForm";
            this.Text = "DepartmentForm";
            this.Load += new System.EventHandler(this.DepartmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdept)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdeptcode;
        private System.Windows.Forms.TextBox txtdeptname;
        private System.Windows.Forms.TextBox txtdeptid;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.CheckBox chkactive;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvdept;
        private System.Windows.Forms.ComboBox cmbcollegeID;
    }
}