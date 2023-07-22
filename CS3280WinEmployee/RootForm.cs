using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS3280WinEmployee
{
    public partial class RootForm : Form
    {

        EmployeeForm empForm = new EmployeeForm();
        DepartmentForm deptForm = new DepartmentForm();

        public RootForm()
        {
            InitializeComponent();
            empForm = new EmployeeForm();
            empForm.MdiParent = this;
            deptForm = new DepartmentForm();
            deptForm.MdiParent = this;
        }

        private void employeesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            empForm.Show();
            deptForm.Hide();
        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deptForm.Show();
            empForm.Hide();
        }
    }
}
