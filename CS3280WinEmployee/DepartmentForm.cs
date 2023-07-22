using DataAccessLayer;
using DataAccessLayer.OrganizationTableAdapters;
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
    public partial class DepartmentForm : Form
    {
        ErrorProvider errorProviderPhoneNum = new ErrorProvider();

        public DepartmentForm()
        {
            InitializeComponent();
            
            gbDepartment.Visible = false;

            #region Data Access
            Organization.DepartmentsDataTable dtDeptTable = Utility.GetDepartmentsData();
            dgDepartment.DataSource = dtDeptTable;

            //Delete Button
            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.HeaderText = "Delete";
            deleteColumn.Text = "Delete";
            deleteColumn.Name = "Delete";
            deleteColumn.UseColumnTextForButtonValue = true;
            dgDepartment.Columns.Add(deleteColumn);

            //Edit Button
            DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
            editColumn.HeaderText = "Edit";
            editColumn.Text = "Edit";
            editColumn.Name = "Edit";
            editColumn.UseColumnTextForButtonValue = true;
            dgDepartment.Columns.Add(editColumn);
            dgDepartment.CellClick += DgDepartment_CellClick;
            #endregion

            txtPhoneNum.Leave += txtPhoneNum_MouseLeave;
        }

        private void txtPhoneNum_MouseLeave(object sender, EventArgs e)
        {
            bool isSSNCorrect = Regex.IsMatch(txtPhoneNum.Text, @"^\d{3}-\d{3}-\d{4}$");
            if (!isSSNCorrect)
            { 
                errorProviderPhoneNum.SetError(txtPhoneNum, "Phone Number provided is is the wrong format! Format should be ###-###-####");
                
                txtPhoneNum.Clear();
                txtPhoneNum.Focus();
            }
            else
            {
                errorProviderPhoneNum.SetError(txtPhoneNum, null);
            }
        }

        private void btnDeptSubmit_Click(object sender, EventArgs e)
        {
            Utility.SaveDepartment(txtDeptName.Text, txtLocation.Text, txtContactPerson.Text, txtPhoneNum.Text);
            MessageBox.Show("Department has been added");
            RefreshGrid();
        }

        private void DgDepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentDeptId = -1;

            DataGridView dg = (DataGridView)sender;

            DataGridViewRow rowToBeOperatedOn = dgDepartment.Rows[e.RowIndex];
            currentDeptId = int.Parse(rowToBeOperatedOn.Cells["DeptID"].Value.ToString());

            if (e.ColumnIndex == -1)
            {
                txtDeptName.Text = dgDepartment.SelectedCells[3].Value.ToString();
                txtLocation.Text = dgDepartment.SelectedCells[4].Value.ToString();
                txtContactPerson.Text = dgDepartment.SelectedCells[5].Value.ToString();
                txtPhoneNum.Text = dgDepartment.SelectedCells[6].Value.ToString();


            }

            if (dg.SelectedCells.Count == 1)
            {
                if (dg.SelectedCells[0] is DataGridViewTextBoxCell)
                {
                    DataGridViewTextBoxCell selectedCell = (DataGridViewTextBoxCell)dg.SelectedCells[0];
                }
                else if (dg.SelectedCells[0] is DataGridViewButtonCell)
                {
                    DataGridViewButtonCell selectedCell = (DataGridViewButtonCell)dg.SelectedCells[0];
                    if (selectedCell.Value.Equals("Delete"))
                    {
                        MessageBox.Show("Department " + currentDeptId + " has been deleted.");                                       
                        Utility.DeleteDepartment(currentDeptId);
                        RefreshGrid();
                    }
                    else if (selectedCell.Value.Equals("Edit"))
                    {
                        MessageBox.Show("Department " + currentDeptId + " has been updated.");
                        //Utility.UpdateDepartment(currentDeptId);
                        RefreshGrid();
                                                
                    }
                }

            }
            return;
        }

        private void RefreshGrid()
        {
            Organization.DepartmentsDataTable dtDeptTable = Utility.GetDepartmentsData();
            dgDepartment.DataSource = dtDeptTable;
            dgDepartment.Refresh();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Organization.DepartmentsDataTable dtDeptTable = Utility.GetDepartmentsData();
            DataView dv = dtDeptTable.DefaultView;
            dv.RowFilter = " DeptName Like '%" + txtSearchDepartment.Text + "%'";
            dgDepartment.DataSource = dv.ToTable();
        }

        private void btnAddDept_Click(object sender, EventArgs e)
        {
            gbDepartment.Visible = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDeptName.Clear();
            txtLocation.Clear();
            txtPhoneNum.Clear();
            txtContactPerson.Clear();
        }
    }
}
