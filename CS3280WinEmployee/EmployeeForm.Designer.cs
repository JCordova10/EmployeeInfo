namespace CS3280WinEmployee
{
    partial class EmployeeForm
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
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.lblSSN = new System.Windows.Forms.Label();
            this.txtSSN = new System.Windows.Forms.TextBox();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.radioSalaried = new System.Windows.Forms.RadioButton();
            this.radioCommision = new System.Windows.Forms.RadioButton();
            this.radioBaseComission = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblCommission = new System.Windows.Forms.Label();
            this.txtComission = new System.Windows.Forms.TextBox();
            this.lblSales = new System.Windows.Forms.Label();
            this.txtSales = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cbDept = new System.Windows.Forms.ComboBox();
            this.lblDept = new System.Windows.Forms.Label();
            this.dgEmployee = new System.Windows.Forms.DataGridView();
            this.gbMarried = new System.Windows.Forms.GroupBox();
            this.rbMarriedYes = new System.Windows.Forms.RadioButton();
            this.rbMarriedNo = new System.Windows.Forms.RadioButton();
            this.lblZipcode = new System.Windows.Forms.Label();
            this.txtZipcode = new System.Windows.Forms.TextBox();
            this.datePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblHireDate = new System.Windows.Forms.Label();
            this.datePickerHireDate = new System.Windows.Forms.DateTimePicker();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchEmployee = new System.Windows.Forms.TextBox();
            this.lblSearchEmp = new System.Windows.Forms.Label();
            this.gbAddEmployee = new System.Windows.Forms.GroupBox();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployee)).BeginInit();
            this.gbMarried.SuspendLayout();
            this.gbAddEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(282, 37);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(135, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(178, 40);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(178, 72);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name";
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(282, 68);
            this.txtLastname.Margin = new System.Windows.Forms.Padding(2);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(135, 20);
            this.txtLastname.TabIndex = 2;
            // 
            // lblSSN
            // 
            this.lblSSN.AutoSize = true;
            this.lblSSN.Location = new System.Drawing.Point(178, 103);
            this.lblSSN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSSN.Name = "lblSSN";
            this.lblSSN.Size = new System.Drawing.Size(29, 13);
            this.lblSSN.TabIndex = 5;
            this.lblSSN.Text = "SSN";
            // 
            // txtSSN
            // 
            this.txtSSN.Location = new System.Drawing.Point(282, 99);
            this.txtSSN.Margin = new System.Windows.Forms.Padding(2);
            this.txtSSN.Name = "txtSSN";
            this.txtSSN.Size = new System.Drawing.Size(135, 20);
            this.txtSSN.TabIndex = 4;
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Location = new System.Drawing.Point(178, 135);
            this.lblAddress1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(77, 13);
            this.lblAddress1.TabIndex = 7;
            this.lblAddress1.Text = "Address Line 1";
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(282, 131);
            this.txtAddress1.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(135, 20);
            this.txtAddress1.TabIndex = 6;
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Location = new System.Drawing.Point(178, 167);
            this.lblAddress2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(77, 13);
            this.lblAddress2.TabIndex = 9;
            this.lblAddress2.Text = "Address Line 2";
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(282, 163);
            this.txtAddress2.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(135, 20);
            this.txtAddress2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 202);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "State";
            // 
            // cmbState
            // 
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Items.AddRange(new object[] {
            "UT",
            "CA",
            "NV",
            "OR",
            "WA",
            "CO",
            "NY"});
            this.cmbState.Location = new System.Drawing.Point(282, 196);
            this.cmbState.Margin = new System.Windows.Forms.Padding(2);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(82, 21);
            this.cmbState.TabIndex = 11;
            // 
            // radioSalaried
            // 
            this.radioSalaried.AutoSize = true;
            this.radioSalaried.Location = new System.Drawing.Point(17, 29);
            this.radioSalaried.Margin = new System.Windows.Forms.Padding(2);
            this.radioSalaried.Name = "radioSalaried";
            this.radioSalaried.Size = new System.Drawing.Size(63, 17);
            this.radioSalaried.TabIndex = 14;
            this.radioSalaried.TabStop = true;
            this.radioSalaried.Text = "Salaried";
            this.radioSalaried.UseVisualStyleBackColor = true;
            this.radioSalaried.CheckedChanged += new System.EventHandler(this.radioSalaried_CheckedChanged);
            // 
            // radioCommision
            // 
            this.radioCommision.AutoSize = true;
            this.radioCommision.Location = new System.Drawing.Point(109, 29);
            this.radioCommision.Margin = new System.Windows.Forms.Padding(2);
            this.radioCommision.Name = "radioCommision";
            this.radioCommision.Size = new System.Drawing.Size(80, 17);
            this.radioCommision.TabIndex = 14;
            this.radioCommision.TabStop = true;
            this.radioCommision.Text = "Commission";
            this.radioCommision.UseVisualStyleBackColor = true;
            this.radioCommision.CheckedChanged += new System.EventHandler(this.radioCommision_CheckedChanged);
            // 
            // radioBaseComission
            // 
            this.radioBaseComission.AutoSize = true;
            this.radioBaseComission.Location = new System.Drawing.Point(216, 29);
            this.radioBaseComission.Margin = new System.Windows.Forms.Padding(2);
            this.radioBaseComission.Name = "radioBaseComission";
            this.radioBaseComission.Size = new System.Drawing.Size(102, 17);
            this.radioBaseComission.TabIndex = 15;
            this.radioBaseComission.TabStop = true;
            this.radioBaseComission.Text = "Base+Comission";
            this.radioBaseComission.UseVisualStyleBackColor = true;
            this.radioBaseComission.CheckedChanged += new System.EventHandler(this.radioBaseComission_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioSalaried);
            this.groupBox1.Controls.Add(this.radioCommision);
            this.groupBox1.Controls.Add(this.radioBaseComission);
            this.groupBox1.Location = new System.Drawing.Point(133, 271);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(364, 65);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type of Employee";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(139, 372);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(2);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(68, 20);
            this.txtSalary.TabIndex = 20;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblSalary.Location = new System.Drawing.Point(130, 347);
            this.lblSalary.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(97, 13);
            this.lblSalary.TabIndex = 21;
            this.lblSalary.Text = "Salary/Base Salary";
            // 
            // lblCommission
            // 
            this.lblCommission.AutoSize = true;
            this.lblCommission.Location = new System.Drawing.Point(253, 347);
            this.lblCommission.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCommission.Name = "lblCommission";
            this.lblCommission.Size = new System.Drawing.Size(86, 13);
            this.lblCommission.TabIndex = 23;
            this.lblCommission.Text = "Commisson Rate";
            // 
            // txtComission
            // 
            this.txtComission.Location = new System.Drawing.Point(266, 372);
            this.txtComission.Margin = new System.Windows.Forms.Padding(2);
            this.txtComission.Name = "txtComission";
            this.txtComission.Size = new System.Drawing.Size(68, 20);
            this.txtComission.TabIndex = 22;
            // 
            // lblSales
            // 
            this.lblSales.AutoSize = true;
            this.lblSales.Location = new System.Drawing.Point(409, 347);
            this.lblSales.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(33, 13);
            this.lblSales.TabIndex = 25;
            this.lblSales.Text = "Sales";
            // 
            // txtSales
            // 
            this.txtSales.Location = new System.Drawing.Point(398, 372);
            this.txtSales.Margin = new System.Windows.Forms.Padding(2);
            this.txtSales.Name = "txtSales";
            this.txtSales.Size = new System.Drawing.Size(68, 20);
            this.txtSales.TabIndex = 24;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSubmit.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSubmit.Location = new System.Drawing.Point(378, 447);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(234, 42);
            this.btnSubmit.TabIndex = 26;
            this.btnSubmit.Text = "submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cbDept
            // 
            this.cbDept.FormattingEnabled = true;
            this.cbDept.Location = new System.Drawing.Point(282, 230);
            this.cbDept.Margin = new System.Windows.Forms.Padding(2);
            this.cbDept.Name = "cbDept";
            this.cbDept.Size = new System.Drawing.Size(82, 21);
            this.cbDept.TabIndex = 28;
            this.cbDept.SelectedIndexChanged += new System.EventHandler(this.cbDept_SelectedIndexChanged);
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Location = new System.Drawing.Point(180, 230);
            this.lblDept.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(62, 13);
            this.lblDept.TabIndex = 29;
            this.lblDept.Text = "Department";
            // 
            // dgEmployee
            // 
            this.dgEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmployee.Location = new System.Drawing.Point(86, 114);
            this.dgEmployee.Name = "dgEmployee";
            this.dgEmployee.RowHeadersWidth = 62;
            this.dgEmployee.Size = new System.Drawing.Size(1466, 330);
            this.dgEmployee.TabIndex = 30;
            // 
            // gbMarried
            // 
            this.gbMarried.Controls.Add(this.rbMarriedYes);
            this.gbMarried.Controls.Add(this.rbMarriedNo);
            this.gbMarried.Location = new System.Drawing.Point(627, 203);
            this.gbMarried.Margin = new System.Windows.Forms.Padding(2);
            this.gbMarried.Name = "gbMarried";
            this.gbMarried.Padding = new System.Windows.Forms.Padding(2);
            this.gbMarried.Size = new System.Drawing.Size(131, 48);
            this.gbMarried.TabIndex = 34;
            this.gbMarried.TabStop = false;
            this.gbMarried.Text = "Married";
            // 
            // rbMarriedYes
            // 
            this.rbMarriedYes.AutoSize = true;
            this.rbMarriedYes.Location = new System.Drawing.Point(17, 29);
            this.rbMarriedYes.Margin = new System.Windows.Forms.Padding(2);
            this.rbMarriedYes.Name = "rbMarriedYes";
            this.rbMarriedYes.Size = new System.Drawing.Size(43, 17);
            this.rbMarriedYes.TabIndex = 14;
            this.rbMarriedYes.TabStop = true;
            this.rbMarriedYes.Text = "Yes";
            this.rbMarriedYes.UseVisualStyleBackColor = true;
            // 
            // rbMarriedNo
            // 
            this.rbMarriedNo.AutoSize = true;
            this.rbMarriedNo.Location = new System.Drawing.Point(79, 29);
            this.rbMarriedNo.Margin = new System.Windows.Forms.Padding(2);
            this.rbMarriedNo.Name = "rbMarriedNo";
            this.rbMarriedNo.Size = new System.Drawing.Size(39, 17);
            this.rbMarriedNo.TabIndex = 14;
            this.rbMarriedNo.TabStop = true;
            this.rbMarriedNo.Text = "No";
            this.rbMarriedNo.UseVisualStyleBackColor = true;
            // 
            // lblZipcode
            // 
            this.lblZipcode.AutoSize = true;
            this.lblZipcode.Location = new System.Drawing.Point(400, 244);
            this.lblZipcode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblZipcode.Name = "lblZipcode";
            this.lblZipcode.Size = new System.Drawing.Size(46, 13);
            this.lblZipcode.TabIndex = 35;
            this.lblZipcode.Text = "Zipcode";
            // 
            // txtZipcode
            // 
            this.txtZipcode.Location = new System.Drawing.Point(477, 237);
            this.txtZipcode.Margin = new System.Windows.Forms.Padding(2);
            this.txtZipcode.Name = "txtZipcode";
            this.txtZipcode.Size = new System.Drawing.Size(93, 20);
            this.txtZipcode.TabIndex = 36;
            // 
            // datePickerBirthday
            // 
            this.datePickerBirthday.Location = new System.Drawing.Point(647, 37);
            this.datePickerBirthday.Name = "datePickerBirthday";
            this.datePickerBirthday.Size = new System.Drawing.Size(200, 20);
            this.datePickerBirthday.TabIndex = 37;
            this.datePickerBirthday.ValueChanged += new System.EventHandler(this.datePickerBirthday_ValueChanged);
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(600, 16);
            this.lblBirthday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(98, 13);
            this.lblBirthday.TabIndex = 38;
            this.lblBirthday.Text = "Enter Your Birthday";
            // 
            // lblHireDate
            // 
            this.lblHireDate.AutoSize = true;
            this.lblHireDate.Location = new System.Drawing.Point(600, 85);
            this.lblHireDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHireDate.Name = "lblHireDate";
            this.lblHireDate.Size = new System.Drawing.Size(52, 13);
            this.lblHireDate.TabIndex = 40;
            this.lblHireDate.Text = "Hire Date";
            // 
            // datePickerHireDate
            // 
            this.datePickerHireDate.Location = new System.Drawing.Point(638, 112);
            this.datePickerHireDate.Name = "datePickerHireDate";
            this.datePickerHireDate.Size = new System.Drawing.Size(200, 20);
            this.datePickerHireDate.TabIndex = 39;
            this.datePickerHireDate.ValueChanged += new System.EventHandler(this.datePickerHireDate_ValueChanged);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(477, 197);
            this.txtCity.Margin = new System.Windows.Forms.Padding(2);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(93, 20);
            this.txtCity.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 204);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "City";
            // 
            // txtSearchEmployee
            // 
            this.txtSearchEmployee.Location = new System.Drawing.Point(660, 68);
            this.txtSearchEmployee.Name = "txtSearchEmployee";
            this.txtSearchEmployee.Size = new System.Drawing.Size(435, 20);
            this.txtSearchEmployee.TabIndex = 43;
            this.txtSearchEmployee.TextChanged += new System.EventHandler(this.txtSearchEmployee_TextChanged);
            // 
            // lblSearchEmp
            // 
            this.lblSearchEmp.AutoSize = true;
            this.lblSearchEmp.Location = new System.Drawing.Point(585, 71);
            this.lblSearchEmp.Name = "lblSearchEmp";
            this.lblSearchEmp.Size = new System.Drawing.Size(41, 13);
            this.lblSearchEmp.TabIndex = 44;
            this.lblSearchEmp.Text = "Search";
            // 
            // gbAddEmployee
            // 
            this.gbAddEmployee.Controls.Add(this.lblFirstName);
            this.gbAddEmployee.Controls.Add(this.txtFirstName);
            this.gbAddEmployee.Controls.Add(this.txtLastname);
            this.gbAddEmployee.Controls.Add(this.lblHireDate);
            this.gbAddEmployee.Controls.Add(this.txtCity);
            this.gbAddEmployee.Controls.Add(this.datePickerHireDate);
            this.gbAddEmployee.Controls.Add(this.label2);
            this.gbAddEmployee.Controls.Add(this.lblBirthday);
            this.gbAddEmployee.Controls.Add(this.datePickerBirthday);
            this.gbAddEmployee.Controls.Add(this.lblLastName);
            this.gbAddEmployee.Controls.Add(this.txtSSN);
            this.gbAddEmployee.Controls.Add(this.lblSSN);
            this.gbAddEmployee.Controls.Add(this.txtAddress1);
            this.gbAddEmployee.Controls.Add(this.lblAddress1);
            this.gbAddEmployee.Controls.Add(this.txtZipcode);
            this.gbAddEmployee.Controls.Add(this.txtAddress2);
            this.gbAddEmployee.Controls.Add(this.lblZipcode);
            this.gbAddEmployee.Controls.Add(this.lblAddress2);
            this.gbAddEmployee.Controls.Add(this.label1);
            this.gbAddEmployee.Controls.Add(this.gbMarried);
            this.gbAddEmployee.Controls.Add(this.cmbState);
            this.gbAddEmployee.Controls.Add(this.groupBox1);
            this.gbAddEmployee.Controls.Add(this.lblDept);
            this.gbAddEmployee.Controls.Add(this.txtSalary);
            this.gbAddEmployee.Controls.Add(this.cbDept);
            this.gbAddEmployee.Controls.Add(this.lblSalary);
            this.gbAddEmployee.Controls.Add(this.btnSubmit);
            this.gbAddEmployee.Controls.Add(this.txtComission);
            this.gbAddEmployee.Controls.Add(this.lblSales);
            this.gbAddEmployee.Controls.Add(this.lblCommission);
            this.gbAddEmployee.Controls.Add(this.txtSales);
            this.gbAddEmployee.Location = new System.Drawing.Point(241, 522);
            this.gbAddEmployee.Name = "gbAddEmployee";
            this.gbAddEmployee.Size = new System.Drawing.Size(994, 525);
            this.gbAddEmployee.TabIndex = 45;
            this.gbAddEmployee.TabStop = false;
            this.gbAddEmployee.Text = "Add Employee";
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.Location = new System.Drawing.Point(200, 473);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(92, 31);
            this.btnAddEmp.TabIndex = 46;
            this.btnAddEmp.Text = "Add Employee";
            this.btnAddEmp.UseVisualStyleBackColor = true;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1173, 473);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 33);
            this.btnClear.TabIndex = 47;
            this.btnClear.Text = "Clear Form";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1643, 1061);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddEmp);
            this.Controls.Add(this.gbAddEmployee);
            this.Controls.Add(this.lblSearchEmp);
            this.Controls.Add(this.txtSearchEmployee);
            this.Controls.Add(this.dgEmployee);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EmployeeForm";
            this.Text = "Employee Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployee)).EndInit();
            this.gbMarried.ResumeLayout(false);
            this.gbMarried.PerformLayout();
            this.gbAddEmployee.ResumeLayout(false);
            this.gbAddEmployee.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label lblSSN;
        private System.Windows.Forms.TextBox txtSSN;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.RadioButton radioSalaried;
        private System.Windows.Forms.RadioButton radioCommision;
        private System.Windows.Forms.RadioButton radioBaseComission;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblCommission;
        private System.Windows.Forms.TextBox txtComission;
        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.TextBox txtSales;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cbDept;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.DataGridView dgEmployee;
        private System.Windows.Forms.GroupBox gbMarried;
        private System.Windows.Forms.RadioButton rbMarriedYes;
        private System.Windows.Forms.RadioButton rbMarriedNo;
        private System.Windows.Forms.Label lblZipcode;
        private System.Windows.Forms.TextBox txtZipcode;
        private System.Windows.Forms.DateTimePicker datePickerBirthday;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblHireDate;
        private System.Windows.Forms.DateTimePicker datePickerHireDate;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchEmployee;
        private System.Windows.Forms.Label lblSearchEmp;
        private System.Windows.Forms.GroupBox gbAddEmployee;
        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.Button btnClear;
    }
}

