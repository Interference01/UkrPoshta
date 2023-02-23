using UkrPoshta.forms;
using UkrPoshta.repository;

namespace UkrPoshta
{
    public partial class MainForm : Form
    {
        private readonly FormContoler formContoler;
        private readonly EmployeesForm employeesForm;
        private readonly SalaryForm salaryForm;
        private readonly UpdateForm updateForm;
        private readonly IRepoInfoCompany repoInfo;

        public MainForm(FormContoler formContoler, EmployeesForm employeesForm, UpdateForm updateForm, SalaryForm salaryForm, IRepoInfoCompany repoInfo)
        {
            InitializeComponent();
            this.formContoler = formContoler;
            this.employeesForm = employeesForm;
            this.updateForm = updateForm;
            this.salaryForm = salaryForm;
            this.repoInfo = repoInfo;
        }


        private void bEmployees_Click(object sender, EventArgs e)
        {
            formContoler.Show(employeesForm);
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            formContoler.Show(updateForm);
        }

        private void bSalary_Click(object sender, EventArgs e)
        {
            formContoler.Show(salaryForm);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            tbInfo.Text = repoInfo.GetInfo();
        }
    }
}