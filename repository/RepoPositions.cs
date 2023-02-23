using System.Data;

namespace UkrPoshta.repository
{
    internal class RepoPositions : IRepoPositions
    {
        private readonly IDBRepository dbRepository;

        public RepoPositions(IDBRepository dbRepository)
        {
            this.dbRepository = dbRepository;
        }

        public DataTable GetPositions() => dbRepository.GetData("SELECT * FROM Positions");

        public void UpdateTablePositions(DataTable table) => dbRepository.Update("SELECT * FROM Positions", table);
    }
}
