using System.Data;
using UkrPoshta.database;

namespace UkrPoshta.repository
{
    internal class RepoEmployees : IRepoEmployees
    {
        private readonly IDBRepository dbRepository;

        public RepoEmployees(IDBRepository dbRepository)
        {
            this.dbRepository = dbRepository;
        }

        public DataTable GetEmployeesData() => dbRepository.GetData("SELECT e.Name as [Ім'я], e.LastName as [Прізвище], e.Address as Адреса, e.PhoneNumber as Телефон," +
               "e.Salary as Оклад, e.DateBirthday as [Дата Народження], e.StartWorkDate as [Дата взяття на роботу], p.Name as [Назва Посади], d.Name as [Назва Відділу] " +
               "FROM Employees e join Positions p on e.PositionID=p.PositionID join Departments d on e.DepartmentID=d.DepartmentID ");

        public DataTable GetEmployees() => dbRepository.GetData("SELECT * FROM Employees");

        public DataTable Search(string name, string lastName, int positionID, int departmentID)
        {
            var queryPos = positionID == 0 ? "" : $" and p.PositionID = {positionID}";
            var queryDep = departmentID == 0 ? "" : $" and d.DepartmentID ={departmentID}";

            return dbRepository.GetData("SELECT e.Name as [Ім'я], e.LastName as [Прізвище], e.Address as Адреса, e.PhoneNumber as Телефон," +
               "e.Salary as Оклад, e.DateBirthday as [Дата Народження], e.StartWorkDate as [Дата взяття на роботу], p.Name as [Назва Посади], d.Name as [Назва Відділу] " +
               "FROM Employees e join Positions p on e.PositionID=p.PositionID join Departments d on e.DepartmentID=d.DepartmentID " +
               "WHERE e.Name LIKE '" + name + "%'  and e.LastName LIKE '" + lastName + "%'" + queryPos + queryDep);
        }

        public void UpdateTableEmployees(DataTable table) => dbRepository.Update("SELECT * FROM Employees", table);

        public DataTable GetSalary(int departmentID) => dbRepository.GetData("SELECT e.Name as [Ім'я], e.LastName as Прізвище, p.Name as Посада," +
                " d.Name as Відділ, e.Salary as Оклад FROM Employees e " +
                "join Departments d on e.DepartmentID=d.DepartmentID " +
                "join Positions p on e.PositionID=p.PositionID " + "WHERE d.DepartmentID =" + departmentID +
                " UNION ALL " +
                "SELECT NULL, NULL, NULL, 'Всього', SUM(e.Salary) FROM Employees e " +
                "join Departments d on e.DepartmentID=d.DepartmentID WHERE d.DepartmentID =" + departmentID);
    }
}
