using System.Data;

namespace UkrPoshta.repository
{
    internal interface IRepository
    {
        DataTable GetTableFromDatabase(string query);

        void UpdateTables(string query, DataTable table);
    }
}
