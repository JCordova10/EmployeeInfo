using DataAccessLayer.OrganizationTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class Utility
    {
       ///Deptartment Table
        public static void SaveDepartment(string deptName, string location, string contactName, string deptPhoneNum) {
            
            OrganizationTableAdapters.DepartmentsTableAdapter deptAdapter = new OrganizationTableAdapters.DepartmentsTableAdapter();
            Organization.DepartmentsDataTable dtDeptTable = new Organization.DepartmentsDataTable();

            deptAdapter.Fill(dtDeptTable);

            Organization.DepartmentsRow newDepartmentsRow = dtDeptTable.NewDepartmentsRow();
            newDepartmentsRow.DeptName = deptName;
            newDepartmentsRow.Location = location;
            newDepartmentsRow.ContactPersonName = contactName;
            newDepartmentsRow.DeptPhoneNum = deptPhoneNum;

            dtDeptTable.AddDepartmentsRow(newDepartmentsRow);
            deptAdapter.Update(dtDeptTable);

        }

        public static Organization.DepartmentsDataTable GetDepartmentsData() {
            OrganizationTableAdapters.DepartmentsTableAdapter deptAdapter = new OrganizationTableAdapters.DepartmentsTableAdapter();
            Organization.DepartmentsDataTable dtDeptTable = new Organization.DepartmentsDataTable();
            deptAdapter.Fill(dtDeptTable);

            return dtDeptTable;
        }

        public static void DeleteDepartment(int Dept) {
            OrganizationTableAdapters.DepartmentsTableAdapter deptAdapter = new OrganizationTableAdapters.DepartmentsTableAdapter();
            Organization.DepartmentsDataTable dtDeptTable = new Organization.DepartmentsDataTable();
            deptAdapter.Fill(dtDeptTable);
            Organization.DepartmentsRow departmentsRow = dtDeptTable.FindByDeptID(Dept);

            deptAdapter.Delete(departmentsRow.DeptID, departmentsRow.DeptName, departmentsRow.Location, departmentsRow.ContactPersonName, departmentsRow.DeptPhoneNum);

        }

        public static void UpdateDepartment(int DeptId) {
            OrganizationTableAdapters.DepartmentsTableAdapter deptAdapter = new OrganizationTableAdapters.DepartmentsTableAdapter();
            Organization.DepartmentsDataTable dtDeptTable = new Organization.DepartmentsDataTable();
            deptAdapter.Fill(dtDeptTable);
            Organization.DepartmentsRow departmentsRow = dtDeptTable.FindByDeptID(DeptId);

            dtDeptTable.AddDepartmentsRow(departmentsRow);

        }


        //////Employee Table////
        public static void SaveEmployee(string fname, string lname, string ssn, int deptID, decimal salary, decimal commission, decimal sales, string address1,
            string address2, string city, string state, int zipcode, string joiningDate, string birthdate, string maritalStatus) {
           
            OrganizationTableAdapters.EmployeesTableAdapter empAdapter = new OrganizationTableAdapters.EmployeesTableAdapter();
            Organization.EmployeesDataTable dtEmpTable = new Organization.EmployeesDataTable();

            empAdapter.Fill(dtEmpTable); 

            //new row
            Organization.EmployeesRow newEmpRow = dtEmpTable.NewEmployeesRow();
            newEmpRow.FName = fname;
            newEmpRow.LName = lname;
            newEmpRow.SSN = ssn;
            newEmpRow.DeptID = deptID;
            newEmpRow.Salary = salary;
            newEmpRow.Commission = commission;
            newEmpRow.Sales = sales;
            newEmpRow.Address1 = address1;
            newEmpRow.Address2 = address2;
            newEmpRow.City = city;
            newEmpRow.State = state;
            newEmpRow.ZipCode = zipcode;
            newEmpRow.BirthDay = birthdate;
            newEmpRow.JoiningDay = joiningDate;
            newEmpRow.MaritalStatus = maritalStatus;

            dtEmpTable.AddEmployeesRow(newEmpRow);
            empAdapter.Update(dtEmpTable);
            
        }

        public static Organization.EmployeesDataTable GetEmployeeData() {
            OrganizationTableAdapters.EmployeesTableAdapter empAdapter = new OrganizationTableAdapters.EmployeesTableAdapter();
            Organization.EmployeesDataTable dtEmpTable = new Organization.EmployeesDataTable();
            empAdapter.Fill(dtEmpTable);

            return dtEmpTable;
        }

        public static void DeleteEmployee(int empID) {
            OrganizationTableAdapters.EmployeesTableAdapter empAdapter = new OrganizationTableAdapters.EmployeesTableAdapter();
            Organization.EmployeesDataTable dtEmpTable = new Organization.EmployeesDataTable();
            empAdapter.Fill(dtEmpTable);
            Organization.EmployeesRow employeeRow = dtEmpTable.FindByEmpID(empID);

            empAdapter.Delete(employeeRow.EmpID, employeeRow.FName, employeeRow.LName, employeeRow.SSN, employeeRow.DeptID, employeeRow.Salary,
                employeeRow.Sales, employeeRow.Commission, employeeRow.BirthDay, employeeRow.JoiningDay,employeeRow.MaritalStatus,
                employeeRow.Address1,employeeRow.Address2,employeeRow.City,employeeRow.State,employeeRow.ZipCode);

        }
       
    }
}
