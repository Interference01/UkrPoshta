using System.Data;

namespace UkrPoshta.repository
{
    internal class RepoDepartments : IRepoDepartaments
    {
        private readonly IDBRepository dbRepository;

        public RepoDepartments(IDBRepository dbRepository)
        {
            this.dbRepository = dbRepository;
        }

        public DataTable GetDepartments() => dbRepository.GetData("SELECT * FROM Departments");

        public void UpdateTableDepartments(DataTable table) => dbRepository.Update("SELECT * FROM Departments", table);
    }
}
