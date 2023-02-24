using System.Data;

namespace UkrPoshta.report
{
    public interface IReport
    {
        void WriteTable(DataGridViewColumnCollection columns, DataGridViewRowCollection rows);
    }
}
