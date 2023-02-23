using System.Data;

namespace UkrPoshta.repository
{
    public interface IDBRepository
    {
        DataTable GetData(string query);

        void Update(string query, DataTable table);
    }
}
