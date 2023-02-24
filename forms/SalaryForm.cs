using System.Data;
using System.Diagnostics;
using UkrPoshta.database;
using UkrPoshta.report;
using UkrPoshta.repository;

namespace UkrPoshta.forms
{
    public partial class SalaryForm : Form
    {
        private readonly FormContoler formControler;
        private readonly IRepoEmployees repoEmployees;
        private readonly IRepoDepartaments repoDepartments;
        private readonly IReport report;

        public SalaryForm(FormContoler formControler, IRepoEmployees repoEmployees, IRepoDepartaments repoDepartments)
        {
            InitializeComponent();
            this.formControler = formControler;
            this.repoEmployees = repoEmployees;
            this.repoDepartments = repoDepartments;
        }

        private void SalaryForm_Load(object sender, EventArgs e)
        {
            //Settings combobox departments
            cbDepartment.DataSource = repoDepartments.GetDepartments();
            cbDepartment.ValueMember = "DepartmentID";
            cbDepartment.DisplayMember = "Name";
            cbDepartment.SelectedItem = null;
        }

        private void cbDepartment_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var departmentID = cbDepartment.SelectedValue;

            dgvSalary.DataSource = repoEmployees.GetSalary((int)departmentID);
        }

        private void bSaveTXT_Click(object sender, EventArgs e)
        {
            report.WriteTable(dgvSalary.Columns, dgvSalary.Rows);
        }

        private void bOpenFolder_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("explorer.exe", $"{Environment.CurrentDirectory}\\Звіт");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            formControler.ShowHomeForm();
        }
    }
}
