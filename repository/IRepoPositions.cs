using System.Data;

namespace UkrPoshta.repository
{
    public interface IRepoPositions
    {
        DataTable GetPositions();

        void UpdateTablePositions(DataTable table);
    }
}
