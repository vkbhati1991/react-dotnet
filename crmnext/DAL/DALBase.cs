using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public static class DALBase
    {
        public static string ExecuteProcedureReturnString(string connectionstring, string storedProcedure, params SqlParameter[] parameters)
        {
            string result = "";
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                using (SqlCommand command = conn.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = storedProcedure;

                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    conn.Open();
                    var returnResult = command.ExecuteScalar();

                    if (returnResult != null)
                    {
                        result = Convert.ToString(returnResult);
                    }
                }
            }

            return result;
        }

        public static TData ExtecuteProcedureReturnData<TData>(string connectionstring, string storedProcedure, Func<SqlDataReader, TData> translater, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                using (SqlCommand command = conn.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = storedProcedure;
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    conn.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        TData elements;
                        try
                        {
                            elements = translater(reader);
                        }
                        finally
                        {
                            while (reader.NextResult())
                            { }
                        }

                        return elements;
                    }
                }
            }
        }


    }
}
