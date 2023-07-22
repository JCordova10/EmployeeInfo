namespace CS3280WinEmployee
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
            this.txtDeptName = new System.Windows.Forms.TextBox();
            this.lbDeptName = new System.Windows.Forms.Label();
            this.lbLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lbContactPerson = new System.Windows.Forms.Label();
            this.txtContactPerson = new System.Windows.Forms.TextBox();
            this.lbPhoneNum = new System.Windows.Forms.Label();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.dgDepartment = new System.Windows.Forms.DataGridView();
            this.btnDeptSubmit = new System.Windows.Forms.Button();
            this.lblSearchDept = new System.Windows.Forms.Label();
            this.txtSearchDepartment = new System.Windows.Forms.TextBox();
            this.gbDepartment = new System.Windows.Forms.GroupBox();
            this.btnAddDept = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgDepartment)).BeginInit();
            this.gbDepartment.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDeptName
            // 
            this.txtDeptName.Location = new System.Drawing.Point(164, 45);
            this.txtDeptName.Name = "txtDeptName";
            this.txtDeptName.Size = new System.Drawing.Size(100, 20);
            this.txtDeptName.TabIndex = 0;
            // 
            // lbDeptName
            // 
            this.lbDeptName.AutoSize = true;
            this.lbDeptName.Location = new System.Drawing.Point(40, 45);
            this.lbDeptName.Name = "lbDeptName";
            this.lbDeptName.Size = new System.Drawing.Size(93, 13);
            this.lbDeptName.TabIndex = 1;
            this.lbDeptName.Text = "Department Name";
            // 
            // lbLocation
            // 
            this.lbLocation.AutoSize = true;
            this.lbLocation.Location = new System.Drawing.Point(40, 86);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(48, 13);
            this.lbLocation.TabIndex = 3;
            this.lbLocation.Text = "Location";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(164, 86);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(100, 20);
            this.txtLocation.TabIndex = 2;
            // 
            // lbContactPerson
            // 
            this.lbContactPerson.AutoSize = true;
            this.lbContactPerson.Location = new System.Drawing.Point(40, 125);
            this.lbContactPerson.Name = "lbContactPerson";
            this.lbContactPerson.Size = new System.Drawing.Size(80, 13);
            this.lbContactPerson.TabIndex = 5;
            this.lbContactPerson.Text = "Contact Person";
            // 
            // txtContactPerson
            // 
            this.txtContactPerson.Location = new System.Drawing.Point(164, 122);
            this.txtContactPerson.Name = "txtContactPerson";
            this.txtContactPerson.Size = new System.Drawing.Size(100, 20);
            this.txtContactPerson.TabIndex = 4;
            // 
            // lbPhoneNum
            // 
            this.lbPhoneNum.AutoSize = true;
            this.lbPhoneNum.Location = new System.Drawing.Point(281, 129);
            this.lbPhoneNum.Name = "lbPhoneNum";
            this.lbPhoneNum.Size = new System.Drawing.Size(78, 13);
            this.lbPhoneNum.TabIndex = 7;
            this.lbPhoneNum.Text = "Phone Number";
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Location = new System.Drawing.Point(390, 126);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneNum.TabIndex = 6;
            this.txtPhoneNum.MouseLeave += new System.EventHandler(this.txtPhoneNum_MouseLeave);
            // 
            // dgDepartment
            // 
            this.dgDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDepartment.Location = new System.Drawing.Point(255, 140);
            this.dgDepartment.Name = "dgDepartment";
            this.dgDepartment.RowHeadersWidth = 62;
            this.dgDepartment.Size = new System.Drawing.Size(871, 342);
            this.dgDepartment.TabIndex = 8;
            // 
            // btnDeptSubmit
            // 
            this.btnDeptSubmit.Location = new System.Drawing.Point(213, 187);
            this.btnDeptSubmit.Name = "btnDeptSubmit";
            this.btnDeptSubmit.Size = new System.Drawing.Size(127, 31);
            this.btnDeptSubmit.TabIndex = 9;
            this.btnDeptSubmit.Text = "Submit";
            this.btnDeptSubmit.UseVisualStyleBackColor = true;
            this.btnDeptSubmit.Click += new System.EventHandler(this.btnDeptSubmit_Click);
            // 
            // lblSearchDept
            // 
            this.lblSearchDept.AutoSize = true;
            this.lblSearchDept.Location = new System.Drawing.Point(376, 63);
            this.lblSearchDept.Name = "lblSearchDept";
            this.lblSearchDept.Size = new System.Drawing.Size(41, 13);
            this.lblSearchDept.TabIndex = 10;
            this.lblSearchDept.Text = "Search";
            // 
            // txtSearchDepartment
            // 
            this.txtSearchDepartment.Location = new System.Drawing.Point(447, 56);
            this.txtSearchDepartment.Name = "txtSearchDepartment";
            this.txtSearchDepartment.Size = new System.Drawing.Size(486, 20);
            this.txtSearchDepartment.TabIndex = 11;
            this.txtSearchDepartment.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // gbDepartment
            // 
            this.gbDepartment.Controls.Add(this.lbDeptName);
            this.gbDepartment.Controls.Add(this.txtDeptName);
            this.gbDepartment.Controls.Add(this.txtLocation);
            this.gbDepartment.Controls.Add(this.btnDeptSubmit);
            this.gbDepartment.Controls.Add(this.lbLocation);
            this.gbDepartment.Controls.Add(this.txtContactPerson);
            this.gbDepartment.Controls.Add(this.lbPhoneNum);
            this.gbDepartment.Controls.Add(this.lbContactPerson);
            this.gbDepartment.Controls.Add(this.txtPhoneNum);
            this.gbDepartment.Location = new System.Drawing.Point(392, 602);
            this.gbDepartment.Name = "gbDepartment";
            this.gbDepartment.Size = new System.Drawing.Size(524, 248);
            this.gbDepartment.TabIndex = 12;
            this.gbDepartment.TabStop = false;
            this.gbDepartment.Text = "Add Department";
            // 
            // btnAddDept
            // 
            this.btnAddDept.Location = new System.Drawing.Point(334, 530);
            this.btnAddDept.Name = "btnAddDept";
            this.btnAddDept.Size = new System.Drawing.Size(208, 43);
            this.btnAddDept.TabIndex = 13;
            this.btnAddDept.Text = "Add Department";
            this.btnAddDept.UseVisualStyleBackColor = true;
            this.btnAddDept.Click += new System.EventHandler(this.btnAddDept_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(836, 531);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(208, 43);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear Form";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // DepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 891);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddDept);
            this.Controls.Add(this.gbDepartment);
            this.Controls.Add(this.txtSearchDepartment);
            this.Controls.Add(this.lblSearchDept);
            this.Controls.Add(this.dgDepartment);
            this.Name = "DepartmentForm";
            this.Text = "Department Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgDepartment)).EndInit();
            this.gbDepartment.ResumeLayout(false);
            this.gbDepartment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDeptName;
        private System.Windows.Forms.Label lbDeptName;
        private System.Windows.Forms.Label lbLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lbContactPerson;
        private System.Windows.Forms.TextBox txtContactPerson;
        private System.Windows.Forms.Label lbPhoneNum;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.DataGridView dgDepartment;
        private System.Windows.Forms.Button btnDeptSubmit;
        private System.Windows.Forms.Label lblSearchDept;
        private System.Windows.Forms.TextBox txtSearchDepartment;
        private System.Windows.Forms.GroupBox gbDepartment;
        private System.Windows.Forms.Button btnAddDept;
        private System.Windows.Forms.Button btnClear;
    }
}