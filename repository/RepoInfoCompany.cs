using System.Data;
using UkrPoshta.database;

namespace UkrPoshta.repository
{
    internal class RepoInfoCompany : IRepoInfoCompany
    {
        private readonly IDBRepository dbRepository;

        public RepoInfoCompany(IDBRepository dbRepository)
        {
            this.dbRepository = dbRepository;
        }
        public string GetInfo()
        {
            var table = dbRepository.GetData("SELECT Descriptions FROM InfoCompany");
            string result = "";
            foreach (DataRow row in table.Rows)
            {
                result += row[0].ToString();
            }
            return result;

        }

    }
}
