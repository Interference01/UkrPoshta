namespace UkrPoshta
{
    public partial class MainForm : Form
    {
        private readonly FormContoler formContoler;
        private readonly EmployeesForm employeesForm;

        public MainForm(FormContoler formContoler, EmployeesForm employeesForm)
        {
            InitializeComponent();
            this.formContoler = formContoler;
            this.employeesForm = employeesForm;
        }


        private void bEmployees_Click(object sender, EventArgs e)
        {
            formContoler.Show(employeesForm);
        }
    }
}