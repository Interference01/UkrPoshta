using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;
using UkrPoshta.repository;

namespace UkrPoshta.database
{
    internal class Connection : IRepository
    {
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["LocalConnectionString"].ConnectionString);

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
