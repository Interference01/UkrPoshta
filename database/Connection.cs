﻿
using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.Common;

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
    }
}