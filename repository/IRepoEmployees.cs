using System.Data;

namespace UkrPoshta.repository
{
    public interface IRepoEmployees
    {
        DataTable GetEmployeesData();

        DataTable Search(string name, string lastName, int positionID, int departmentID);

        DataTable GetEmployees();
        
        DataTable GetSalary(int departmentID);
        
        void UpdateTableEmployees(DataTable table);
    }
}
