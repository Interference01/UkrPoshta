using UkrPoshta.database;

namespace UkrPoshta.forms
{
    public partial class SalaryForm : Form
    {
        public SalaryForm()
        {
            InitializeComponent();
        }

        private void SalaryForm_Load(object sender, EventArgs e)
        {

            //Settings combobox departments
            cbDepartment.DataSource = Connection.Query("SELECT * FROM Departments");
            cbDepartment.ValueMember = "DepartmentID";
            cbDepartment.DisplayMember = "Name";
            cbDepartment.SelectedItem = null;
        }

        private void cbDepartment_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var departmentID = cbDepartment.SelectedValue == null ? "" : cbDepartment.SelectedValue;

            dgvSalary.DataSource = Connection.Query("SELECT e.Name as [Ім'я], e.LastName as [Прізвище], e.Address as Адреса, e.PhoneNumber as Телефон," +
                "e.Salary as Оклад, e.DateBirthday as [Дата Народження], e.StartWorkDate as [Дата взяття на роботу], p.Name as [Назва Посади], d.Name as [Назва Відділу]" +
                "  FROM Employees e join Departments d on e.DepartmentID=d.DepartmentID " +
                "join Positions p on e.PositionID=p.PositionID " +
                "WHERE d.DepartmentID = " + departmentID + "");
        }
    }
}
