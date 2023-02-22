namespace UkrPoshta.database
{
    public static class GetString
    {
        public static string SelectAllFromEmployees() => "SELECT * FROM Employees";

        public static string SelectAllFromPositions() => "SELECT * FROM Positions";

        public static string SelectAllFromDepartments() => "SELECT * FROM Departments";

        public static string SelectFromEmployeesAs() => "SELECT e.Name as [Ім'я], e.LastName as [Прізвище], e.Address as Адреса, e.PhoneNumber as Телефон," +
               "e.Salary as Оклад, e.DateBirthday as [Дата Народження], e.StartWorkDate as [Дата взяття на роботу], p.Name as [Назва Посади], d.Name as [Назва Відділу] " +
               "FROM Employees e join Positions p on e.PositionID=p.PositionID join Departments d on e.DepartmentID=d.DepartmentID ";

        public static string SelectFromEmployeesSalary() => "SELECT e.Name as [Ім'я], e.LastName as Прізвище, p.Name as Посада," +
                " d.Name as Відділ, e.Salary as Оклад FROM Employees e " +
                "join Departments d on e.DepartmentID=d.DepartmentID " +
                "join Positions p on e.PositionID=p.PositionID ";

    }
}
