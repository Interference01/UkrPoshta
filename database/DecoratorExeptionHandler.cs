using System.Data;
using UkrPoshta.repository;

namespace UkrPoshta.database
{
    internal class DecoratorExeptionHandler : IDBRepository
    {
        IDBRepository repository;
        public DecoratorExeptionHandler(IDBRepository repository)
        {
            this.repository = repository;
        }
        public DataTable GetData(string query)
        {
            try
            {
                return this.repository.GetData(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public void Update(string query, DataTable table)
        {
            try
            {
                this.repository.Update(query, table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
