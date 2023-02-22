using System.Data;

namespace UkrPoshta.repository
{
    public interface IRepository
    {
        DataTable GetTableFromDatabase(string query);

        void UpdateTables(string query, DataTable table);
    }
}
