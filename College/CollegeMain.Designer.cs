namespace SysArch_Midterm.CollegeMain
{
    partial class CollegeMain
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
            this.dgvcollege = new System.Windows.Forms.DataGridView();
            this.chkactive = new System.Windows.Forms.CheckBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcollegecode = new System.Windows.Forms.TextBox();
            this.txtcollegename = new System.Windows.Forms.TextBox();
            this.txtcollegeID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcollege)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvcollege
            // 
            this.dgvcollege.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcollege.Location = new System.Drawing.Point(0, 12);
            this.dgvcollege.Name = "dgvcollege";
            this.dgvcollege.RowHeadersWidth = 51;
            this.dgvcollege.RowTemplate.Height = 24;
            this.dgvcollege.Size = new System.Drawing.Size(502, 268);
            this.dgvcollege.TabIndex = 0;
            // 
            // chkactive
            // 
            this.chkactive.AutoSize = true;
            this.chkactive.Location = new System.Drawing.Point(768, 206);
            this.chkactive.Name = "chkactive";
            this.chkactive.Size = new System.Drawing.Size(66, 20);
            this.chkactive.TabIndex = 21;
            this.chkactive.Text = "Active";
            this.chkactive.UseVisualStyleBackColor = true;
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(759, 272);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(82, 23);
            this.btndelete.TabIndex = 20;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(662, 272);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 19;
            this.btnedit.Text = "EDIT";
            this.btnedit.UseVisualStyleBackColor = true;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(563, 272);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 18;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(564, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "College Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(560, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "College Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(584, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "College ID:";
            // 
            // txtcollegecode
            // 
            this.txtcollegecode.Location = new System.Drawing.Point(685, 163);
            this.txtcollegecode.Name = "txtcollegecode";
            this.txtcollegecode.Size = new System.Drawing.Size(149, 22);
            this.txtcollegecode.TabIndex = 14;
            // 
            // txtcollegename
            // 
            this.txtcollegename.Location = new System.Drawing.Point(685, 125);
            this.txtcollegename.Name = "txtcollegename";
            this.txtcollegename.Size = new System.Drawing.Size(149, 22);
            this.txtcollegename.TabIndex = 13;
            // 
            // txtcollegeID
            // 
            this.txtcollegeID.Location = new System.Drawing.Point(685, 88);
            this.txtcollegeID.Name = "txtcollegeID";
            this.txtcollegeID.Size = new System.Drawing.Size(149, 22);
            this.txtcollegeID.TabIndex = 12;
            // 
            // CollegeMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 450);
            this.Controls.Add(this.chkactive);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcollegecode);
            this.Controls.Add(this.txtcollegename);
            this.Controls.Add(this.txtcollegeID);
            this.Controls.Add(this.dgvcollege);
            this.Name = "CollegeMain";
            this.Text = "College";
            this.Load += new System.EventHandler(this.CollegeMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcollege)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvcollege;
        private System.Windows.Forms.CheckBox chkactive;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcollegecode;
        private System.Windows.Forms.TextBox txtcollegename;
        private System.Windows.Forms.TextBox txtcollegeID;
    }
}