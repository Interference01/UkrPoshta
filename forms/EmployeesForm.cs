using UkrPoshta.database;

namespace UkrPoshta
{
    public partial class EmployeesForm : Form
    {
        FormContoler formControler;

        public EmployeesForm(FormContoler formContoler)
        {
            InitializeComponent();
            this.formControler = formContoler;
        }

        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            dgvEmployees.DataSource = Connection.Query("SELECT e.Name as [Ім'я], e.LastName as [Прізвище], e.Address as Адреса, e.PhoneNumber as Телефон," +
                "e.Salary as Оклад, e.DateBirthday as [Дата Народження], e.StartWorkDate as [Дата взяття на роботу], p.Name as [Назва Посади], d.Name as [Назва Відділу] " +
                "FROM Employees e join Positions p on e.PositionID=p.PositionID join Departments d on e.DepartmentID=d.DepartmentID");

            // settings comboBox Position
            cbPosition.DataSource = Connection.Query("SELECT * FROM Positions");
            cbPosition.ValueMember = "PositionID";
            cbPosition.DisplayMember = "Name";
            cbPosition.SelectedItem = null;


            // settings comboBox Department
            cbDepartment.DataSource = Connection.Query("SELECT * FROM Departments");
            cbDepartment.ValueMember = "DepartmentID";
            cbDepartment.DisplayMember = "Name";
            cbDepartment.SelectedItem = null;
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            string name = tbSearchName.Text;
            string lastName = tbSearchLastName.Text;
            var positionID = cbPosition.SelectedValue == null ? "" : $" and p.PositionID = {cbPosition.SelectedValue}";
            var departmentID = cbDepartment.SelectedValue == null ? "" : $" and d.DepartmentID ={cbDepartment.SelectedValue}";

            dgvEmployees.DataSource = Connection.Query("SELECT e.Name as [Ім'я], e.LastName as [Прізвище], e.Address as Адреса, e.PhoneNumber as Телефон, " +
                "e.Salary as Оклад, e.DateBirthday as [Дата Народження], e.StartWorkDate as [Дата взяття на роботу], p.Name as [Назва Посади], d.Name as [Назва Відділу] " +
                "FROM Employees e join Positions p on e.PositionID=p.PositionID join Departments d on e.DepartmentID=d.DepartmentID " +
                "WHERE e.Name LIKE '"+ name +"%'  and e.LastName LIKE '"+ lastName +"%'" + positionID + departmentID);
        }

        private void pcClear_Click(object sender, EventArgs e)
        {
            tbSearchName.Text = "";
            tbSearchLastName.Text = "";
            cbDepartment.SelectedItem = null;
            cbPosition.SelectedItem = null;

            dgvEmployees.DataSource = Connection.Query("SELECT e.Name as [Ім'я], e.LastName as [Прізвище], e.Address as Адреса, e.PhoneNumber as Телефон," +
                "e.Salary as Оклад, e.DateBirthday as [Дата Народження], e.StartWorkDate as [Дата взяття на роботу], p.Name as [Назва Посади], d.Name as [Назва Відділу] " +
                "FROM Employees e join Positions p on e.PositionID=p.PositionID join Departments d on e.DepartmentID=d.DepartmentID");
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            formControler.ShowHomeForm();
        }
    }
}
