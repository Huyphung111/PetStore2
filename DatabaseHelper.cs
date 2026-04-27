using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace PetStore2
{
    public static class DatabaseHelper
    {
        private static readonly string ConnectionString = ConfigurationManager
            .ConnectionStrings["ShopPet"].ConnectionString;

        public static DataTable ExecuteQuery(string sql, SqlParameter[] parameters = null)
        {
            using (var connection = new SqlConnection(ConnectionString))
            using (var command = new SqlCommand(sql, connection))
            {
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                var table = new DataTable();
                using (var adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(table);
                }

                return table;
            }
        }

        public static int ExecuteNonQuery(string sql, SqlParameter[] parameters = null)
        {
            using (var connection = new SqlConnection(ConnectionString))
            using (var command = new SqlCommand(sql, connection))
            {
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                connection.Open();
                return command.ExecuteNonQuery();
            }
        }

        public static DataTable ExecuteStoredProcedure(string procedureName, SqlParameter[] parameters = null)
        {
            using (var connection = new SqlConnection(ConnectionString))
            using (var command = new SqlCommand(procedureName, connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                var table = new DataTable();
                using (var adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(table);
                }

                return table;
            }
        }
    }
}
