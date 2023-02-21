
using System.Windows.Forms;
using UkrPoshta.database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UkrPoshta
{
    public partial class EmployeesForm : Form
    {
        public EmployeesForm()
        {
            InitializeComponent();
        }

        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            dgvEmployees.DataSource = Connection.Query("SELECT e.Name as [Ім'я], e.LastName as [Прізвище], e.Address as Адреса, e.PhoneNumber as Телефон," +
                "e.Salary as Оклад, e.DateBirthday as [Дата Народження], e.StartWorkDate as [Дата взяття на роботу], p.Name as [Назва Посади], d.Name as [Назва Відділу] " +
                "FROM Employees e join Positions p on e.PositionID=p.PositionID join Departments d on e.DepartmentID=d.DepartmentID");
            var tablePosition = Connection.Query("SELECT * FROM Positions");
            for (int i = 0; i < tablePosition.Columns.Count; i++)
            {
                cbPosition.Items.Add(tablePosition.Columns[1].Container.ToString());
            }
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            var name = tbSearchName.Text;
            var lastName = tbSearchLastName.Text;
            // var position = tbSearchPosition.Text;
            // var department = tbSearchDepartment.Text;
            dgvEmployees.DataSource = Connection.Query("SELECT e.Name as [Ім'я], e.LastName as [Прізвище], e.Address as Адреса, e.PhoneNumber as Телефон, " +
                "e.Salary as Оклад, e.DateBirthday as [Дата Народження], e.StartWorkDate as [Дата взяття на роботу], p.Name as [Назва Посади], d.Name as [Назва Відділу] " +
                "FROM Employees e join Positions p on e.PositionID=p.PositionID join Departments d on e.DepartmentID=d.DepartmentID " +
                "WHERE e.Name LIKE '"+name+"%'  and e.LastName LIKE '"+lastName+ "%' and p.Name LIKE '%' and d.Name LIKE '%';");
        }

        private void pcClear_Click(object sender, EventArgs e)
        {
            tbSearchName.Text = "";
            tbSearchLastName.Text = "";
            //tbSearchPosition.Text = "";
            //tbSearchDepartment.Text = "";
            dgvEmployees.DataSource = Connection.Query("SELECT e.Name as [Ім'я], e.LastName as [Прізвище], e.Address as Адреса, e.PhoneNumber as Телефон," +
                "e.Salary as Оклад, e.DateBirthday as [Дата Народження], e.StartWorkDate as [Дата взяття на роботу], p.Name as [Назва Посади], d.Name as [Назва Відділу] " +
                "FROM Employees e join Positions p on e.PositionID=p.PositionID join Departments d on e.DepartmentID=d.DepartmentID");
        }
    }
}
