using System.Data;

namespace UkrPoshta.repository
{
    public interface IRepoDepartaments
    {
        DataTable GetDepartments();

        void UpdateTableDepartments(DataTable table);
    }
}
