using System.Data;
using UkrPoshta.repository;

namespace UkrPoshta.database
{
    internal class DecoratorExeptionHandler : IRepository
    {
        IRepository repository;
        public DecoratorExeptionHandler(IRepository repository)
        {
            this.repository = repository;
        }
        public DataTable GetTableFromDatabase(string query)
        {
            try
            {
                return this.repository.GetTableFromDatabase(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public void UpdateTables(string query, DataTable table)
        {
            try
            {
                this.repository.UpdateTables(query, table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
