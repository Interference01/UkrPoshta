using Microsoft.Data.SqlClient;
using System.Data;
using UkrPoshta.repository;

namespace UkrPoshta.database
{
    internal class Connection_ : IRepository
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-29T6DCB\SQLEXPRESS;Database=Ukrposhta;Trusted_Connection=True;TrustServerCertificate=True;");

        public DataTable GetTableFromDatabase(string query)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sqlConnection);
            DataTable dataTable = new DataTable();

            sqlConnection.Open();
            dataAdapter.Fill(dataTable);

            sqlConnection.Close();
            return dataTable;
        }

        public void UpdateTables(string query, DataTable table)
        {
            sqlConnection.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sqlConnection);

            SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);

            dataAdapter.UpdateCommand = builder.GetUpdateCommand();
            dataAdapter.DeleteCommand = builder.GetDeleteCommand();
            dataAdapter.InsertCommand = builder.GetInsertCommand();

            dataAdapter.Update(table);
            sqlConnection.Close();
        }
    }
}
