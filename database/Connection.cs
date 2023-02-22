using Microsoft.Data.SqlClient;
using System.Data;

namespace UkrPoshta.database
{
    internal static class Connection
    {
        public static DataTable Query(string query)
        {
            try
            {
                string str1 = @"Data Source=DESKTOP-29T6DCB\SQLEXPRESS;Database=Ukrposhta;Trusted_Connection=True;TrustServerCertificate=True;";

                SqlConnection sqlConnection = new SqlConnection(str1);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sqlConnection);
                DataTable dt = new DataTable();

                sqlConnection.Open();
                dataAdapter.Fill(dt);

                sqlConnection.Close();
                return dt;
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
                return null;
            }
        }

        public static void UpdateTables( string query, DataTable table)
        {
            try
            {
                string str1 = @"Data Source=DESKTOP-29T6DCB\SQLEXPRESS;Database=Ukrposhta;Trusted_Connection=True;TrustServerCertificate=True;";

                SqlConnection sqlConnection = new SqlConnection(str1);

                sqlConnection.Open();

                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, sqlConnection);

                SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);

                dataAdapter.UpdateCommand = builder.GetUpdateCommand();
                dataAdapter.DeleteCommand = builder.GetDeleteCommand();
                dataAdapter.InsertCommand = builder.GetInsertCommand();

                dataAdapter.Update(table);
                sqlConnection.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

    }
}
