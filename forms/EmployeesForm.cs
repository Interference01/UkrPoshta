using UkrPoshta.repository;

namespace UkrPoshta
{
    public partial class EmployeesForm : Form
    {
        private readonly FormContoler formControler;
        private readonly IRepoEmployees repoEmployees;
        private readonly IRepoDepartaments repoDepartaments;
        private readonly IRepoPositions repoPositions;

        public EmployeesForm(FormContoler formControler, IRepoEmployees repoEmployees, IRepoPositions repoPositions, IRepoDepartaments repoDepartaments) 
        {
            InitializeComponent();
            this.formControler = formControler;
            this.repoEmployees = repoEmployees;            this.repoDepartaments = repoDepartaments;
            this.repoPositions = repoPositions;
        }


        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            dgvEmployees.DataSource = repoEmployees.GetEmployeesData();

            SettingsComboBox();
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            string name = tbSearchName.Text;
            string lastName = tbSearchLastName.Text;
            var positionID = cbPosition.SelectedValue == null ? 0 : (int)cbPosition.SelectedValue;
            var departmentID = cbDepartment.SelectedValue == null ? 0 : (int)cbDepartment.SelectedValue;

            dgvEmployees.DataSource = repoEmployees.Search(name, lastName, positionID, departmentID);
        }

        private void pcClear_Click(object sender, EventArgs e)
        {
            SettingsComboBox();

            tbSearchName.Text = "";
            tbSearchLastName.Text = "";

            dgvEmployees.DataSource = repoEmployees.GetEmployeesData();
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            formControler.ShowHomeForm();
        }

        private void SettingsComboBox()
        {
            // settings comboBox Positions
            cbPosition.DataSource = repoPositions.GetPositions();
            cbPosition.ValueMember = "PositionID";
            cbPosition.DisplayMember = "Name";
            cbPosition.SelectedItem = null;


            // settings comboBox Departments
            cbDepartment.DataSource = repoDepartaments.GetDepartments();
            cbDepartment.ValueMember = "DepartmentID";
            cbDepartment.DisplayMember = "Name";
            cbDepartment.SelectedItem = null;
        }
    }
}
