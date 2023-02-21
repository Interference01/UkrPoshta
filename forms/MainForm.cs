using UkrPoshta.forms;

namespace UkrPoshta
{
    public partial class MainForm : Form
    {
        private readonly FormContoler formContoler;
        private readonly EmployeesForm employeesForm;
        private readonly UpdateForm updateForm;

        public MainForm(FormContoler formContoler, EmployeesForm employeesForm, UpdateForm updateForm)
        {
            InitializeComponent();
            this.formContoler = formContoler;
            this.employeesForm = employeesForm;
            this.updateForm = updateForm;
        }


        private void bEmployees_Click(object sender, EventArgs e)
        {
            formContoler.Show(employeesForm);
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            formContoler.Show(updateForm);
        }
    }
}