using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS3280WinEmployee
{
    public partial class EmployeeForm : Form
    {
        Color originalGroupBoxColor = Color.White;
        Color originalSubmitBtnColor = Color.White;
        public EmployeeForm()
        {
            InitializeComponent();
            btnSubmit.BackColor = Color.Red;
            originalGroupBoxColor = groupBox1.BackColor;
            groupBox1.BackColor = Color.Aqua;
            cmbState.SelectedItem = "CA";
            radioSalaried.Checked = true;
            originalSubmitBtnColor = btnSubmit.BackColor;
            gbAddEmployee.Visible = false;

            #region Event intialization region
            btnSubmit.MouseEnter += BtnSubmit_MouseEnter;
            btnSubmit.MouseLeave += BtnSubmit_MouseLeave;

            txtLastname.MouseEnter += TxtLastname_MouseEnter;
            txtLastname.MouseLeave += TxtLastname_MouseLeave;
            txtSSN.Leave += TxtSSN_Leave;
            #endregion

            #region Data Access
            Organization.DepartmentsDataTable dtDeptTable = Utility.GetDepartmentsData();
            cbDept.DataSource = dtDeptTable; 
            List<string> myStringList = new List<string>();
            myStringList.Add("1");
            myStringList.Add("2");
            myStringList.Add("3");
            cbDept.DataSource = dtDeptTable;

            cbDept.DisplayMember = dtDeptTable.DeptNameColumn.ColumnName;
            cbDept.ValueMember = dtDeptTable.DeptIDColumn.ColumnName;

            Organization.EmployeesDataTable dtEmpTable = Utility.GetEmployeeData();
            dgEmployee.DataSource = dtEmpTable;
        
            dgEmployee.Columns["EmpID"].Visible = false;
            dgEmployee.Columns["Salary"].Visible = false;
            dgEmployee.Columns["Commission"].Visible = false;
            dgEmployee.Columns["Sales"].Visible = false;
            dgEmployee.Columns["SSN"].ReadOnly = true;

            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.HeaderText = "Use to Delete";
            deleteColumn.Text = "Delete";
            deleteColumn.Name = "Delete";
            deleteColumn.UseColumnTextForButtonValue = true;
            dgEmployee.Columns.Add(deleteColumn);

            DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
            editColumn.HeaderText = "Live edit";
            editColumn.Text = "Edit";
            editColumn.Name = "Edit";
            editColumn.UseColumnTextForButtonValue = true;
            dgEmployee.Columns.Add(editColumn);
            dgEmployee.CellClick += DgEmployee_CellClick;           
            #endregion
        }

       

        private void DgEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentEmpId = -1;
            
            DataGridView dg = (DataGridView)sender;

            DataGridViewRow rowToBeOperatedOn = dgEmployee.Rows[e.RowIndex];
            currentEmpId = int.Parse(rowToBeOperatedOn.Cells["EmpID"].Value.ToString());

            if (e.ColumnIndex == -1)
            {
                MessageBox.Show("Clicked");
                txtFirstName.Text = dgEmployee.SelectedCells[3].Value.ToString();
                txtLastname.Text = dgEmployee.SelectedCells[4].Value.ToString();
                txtSSN.Text = dgEmployee.SelectedCells[5].Value.ToString();
                cbDept.SelectedIndex = int.Parse(dgEmployee.SelectedCells[6].Value.ToString());
                datePickerBirthday.Value = DateTime.Parse(dgEmployee.SelectedCells[10].Value.ToString());
                datePickerHireDate.Value = DateTime.Parse(dgEmployee.SelectedCells[11].Value.ToString());
                if (dgEmployee.SelectedCells[12].Value.ToString() == "Yes")
                {
                    rbMarriedYes.Checked = true;
                }
                else {
                    rbMarriedNo.Checked = true;
                }
                txtAddress1.Text = dgEmployee.SelectedCells[13].Value.ToString();
                txtAddress2.Text = dgEmployee.SelectedCells[14].Value.ToString();
                txtCity.Text = dgEmployee.SelectedCells[15].Value.ToString();
                cmbState.SelectedValue = dgEmployee.SelectedCells[16].Value.ToString();
                txtZipcode.Text = dgEmployee.SelectedCells[17].Value.ToString();


            }
            if (dg.SelectedCells.Count == 1) {
                if (dg.SelectedCells[0] is DataGridViewTextBoxCell)
                {
                    DataGridViewTextBoxCell selectedCell = (DataGridViewTextBoxCell)dg.SelectedCells[0];
                    MessageBox.Show("Clicked");
                }
                else if (dg.SelectedCells[0] is DataGridViewButtonCell)
                {
                    DataGridViewButtonCell selectedCell = (DataGridViewButtonCell)dg.SelectedCells[0];
                    if (selectedCell.Value.Equals("Delete"))
                    {
                        MessageBox.Show("Delete is clicked. Current Emp ID is: " + currentEmpId);
                        Utility.DeleteEmployee(currentEmpId);
                        RefreshGrid();
                        
                    }
                    else if (selectedCell.Value.Equals("Edit"))
                    {
                        MessageBox.Show("Edit is clicked. Current Emp ID is: " + currentEmpId);
                        dg.Update();
                    }
                }
                
            }
            return;
        }

        private void TxtSSN_Leave(object sender, EventArgs e)
        {
            bool isSSNCorrect =   Regex.IsMatch(txtSSN.Text, @"^\d{3}-\d{2}-\d{4}$");
            if (!isSSNCorrect) {
                MessageBox.Show("Enter valid ssn. An example: 111-11-1111");
                txtSSN.Clear();
                txtSSN.Focus();
            }
        }

        private void TxtLastname_MouseLeave(object sender, EventArgs e)
        {
            txtLastname.Size = new Size(txtLastname.Size.Width - 10, txtLastname.Size.Height);
        }
    
        private void TxtLastname_MouseEnter(object sender, EventArgs e)
        {
            txtLastname.Size = new Size(txtLastname.Size.Width + 10, txtLastname.Size.Height);
        }
        private void BtnSubmit_MouseLeave(object sender, EventArgs e)
        {
            btnSubmit.BackColor = originalSubmitBtnColor;         
        }

        private void BtnSubmit_MouseEnter(object sender, EventArgs e)
        {
            btnSubmit.BackColor = Color.Beige;
        }

        private void radioSalaried_CheckedChanged(object sender, EventArgs e)
        {
            lblSalary.Visible = true;
            txtSalary.Visible = true;
            lblSales.Visible = false;
            lblCommission.Visible = false;
            txtComission.Visible = false;
            txtSales.Visible = false;
        }

        private void radioCommision_CheckedChanged(object sender, EventArgs e)
        {
            lblSalary.Visible = false;
            txtSalary.Visible = false;
            lblSales.Visible = true;
            lblCommission.Visible = true;
            txtComission.Visible = true;
            txtSales.Visible = true;
        }

        private void radioBaseComission_CheckedChanged(object sender, EventArgs e)
        {
            lblSalary.Visible = true;
            txtSalary.Visible = true;
            lblSales.Visible = true;
            lblCommission.Visible = true;
            txtComission.Visible = true;
            txtSales.Visible = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string employeeInformation = string.Empty;
            string maritialStatus = string.Empty;
            employeeInformation += txtFirstName.Text + " " +txtLastname.Text + "\r\n";
            employeeInformation += txtAddress1.Text + " " + txtAddress2.Text + " " + cmbState.SelectedItem.ToString() + "\r\n";
            employeeInformation += txtSSN.Text + "\r\n";
            if (txtSalary.Visible) {
                employeeInformation += "Salary : " + txtSalary.Text + "\r\n";
            }
            if (txtComission.Visible) {
                employeeInformation += "Commision Rate : " + txtComission.Text + "\r\n";
            }
            if (txtSales.Visible)
            {
                employeeInformation += "Sales : " + txtSales.Text + "\r\n";
            }

            if (rbMarriedYes.Checked)
            {
                maritialStatus = "Yes";
            }
            else if (rbMarriedNo.Checked){
                maritialStatus = "No";
            }
            

            groupBox1.BackColor = originalGroupBoxColor;

            decimal salary = string.IsNullOrEmpty(txtSalary.Text) ? 0 : decimal.Parse(txtSalary.Text);
            decimal commisionRate = string.IsNullOrEmpty(txtComission.Text) ? 0 : decimal.Parse(txtComission.Text);
            decimal sales = string.IsNullOrEmpty(txtSales.Text) ? 0 : decimal.Parse(txtSales.Text);
            int deptId = int.Parse(cbDept.SelectedValue.ToString());
            int zipcode = int.Parse(txtZipcode.Text);


            Utility.SaveEmployee(txtFirstName.Text,txtLastname.Text,txtSSN.Text, deptId, salary,commisionRate,sales, txtAddress1.Text, txtAddress2.Text, txtCity.Text, cmbState.Text, zipcode, datePickerBirthday.Text, datePickerHireDate.Text, maritialStatus);
            MessageBox.Show("Employee has been added");
            RefreshGrid();
        }

        private void cbDept_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            string s = cbDept.SelectedValue.ToString();

        }

        private void RefreshGrid() {
            Organization.EmployeesDataTable dtEmpTable = Utility.GetEmployeeData();
            dgEmployee.DataSource = dtEmpTable;
            dgEmployee.Refresh();
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            gbAddEmployee.Visible = true;
        }

        private void txtSearchEmployee_TextChanged(object sender, EventArgs e)
        {
            Organization.EmployeesDataTable dtEmpTable = Utility.GetEmployeeData();
            DataView dv = dtEmpTable.DefaultView;
            dv.RowFilter = " LName Like '%" + txtSearchEmployee.Text + "%'";
            dgEmployee.DataSource = dv.ToTable();
        }

        private void datePickerBirthday_ValueChanged(object sender, EventArgs e)
        {
            if (datePickerBirthday.Value > DateTime.Now) {
                MessageBox.Show("Invalid Birthday!");
            }
        }

        private void datePickerHireDate_ValueChanged(object sender, EventArgs e)
        {
            if (datePickerHireDate.Value > DateTime.Now)
            {
                MessageBox.Show("Invalid Hire Date!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastname.Clear();
            txtSSN.Clear();
            txtZipcode.Clear();
            txtAddress1.Clear();
            txtAddress2.Clear();
            txtCity.Clear();
            txtComission.Clear();
            txtSalary.Clear();
            txtSales.Clear();
            cmbState.SelectedIndex = -1;
            datePickerBirthday.Value = DateTime.Now;
            datePickerHireDate.Value = DateTime.Now;
            
        }
    }
}
