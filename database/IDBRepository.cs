using System.Data;

namespace UkrPoshta.database
{
    public interface IDBRepository
    {
        DataTable GetData(string query);

        void Update(string query, DataTable table);
    }
}
