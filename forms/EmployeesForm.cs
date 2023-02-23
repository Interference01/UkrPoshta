using UkrPoshta.database;
using UkrPoshta.repository;

namespace UkrPoshta
{
    public partial class EmployeesForm : Form
    {
        FormContoler formControler;
        IRepository repository;

        public EmployeesForm(FormContoler formContoler, IRepository repository)
        {
            InitializeComponent();
            this.formControler = formContoler;
            this.repository = repository;
        }


        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            dgvEmployees.DataSource = repository.GetTableFromDatabase(GetString.SelectFromEmployeesAs());

            SettingsComboBox();
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            string name = tbSearchName.Text;
            string lastName = tbSearchLastName.Text;
            var positionID = cbPosition.SelectedValue == null ? "" : $" and p.PositionID = {cbPosition.SelectedValue}";
            var departmentID = cbDepartment.SelectedValue == null ? "" : $" and d.DepartmentID ={cbDepartment.SelectedValue}";

            dgvEmployees.DataSource = repository.GetTableFromDatabase(GetString.SelectFromEmployeesAs() +
                "WHERE e.Name LIKE '"+ name +"%'  and e.LastName LIKE '"+ lastName +"%'" + positionID + departmentID);
        }

        private void pcClear_Click(object sender, EventArgs e)
        {
            SettingsComboBox();

            dgvEmployees.DataSource = repository.GetTableFromDatabase(GetString.SelectFromEmployeesAs());
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            formControler.ShowHomeForm();
        }

        private void SettingsComboBox()
        {
            // settings comboBox Positions
            cbPosition.DataSource = repository.GetTableFromDatabase(GetString.SelectAllFromPositions());
            cbPosition.ValueMember = "PositionID";
            cbPosition.DisplayMember = "Name";
            cbPosition.SelectedItem = null;


            // settings comboBox Departments
            cbDepartment.DataSource = repository.GetTableFromDatabase(GetString.SelectAllFromDepartments());
            cbDepartment.ValueMember = "DepartmentID";
            cbDepartment.DisplayMember = "Name";
            cbDepartment.SelectedItem = null;
        }
    }
}
