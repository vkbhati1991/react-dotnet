﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DataReader
    {
        public static string GetNullableString(SqlDataReader reader, string colName)
        {
            return reader.IsDBNull(reader.GetOrdinal(colName)) ? null : Convert.ToString(reader[colName]);
        }

        public static int GetNullableInt32(SqlDataReader reader, string colName)
        {
            return reader.IsDBNull(reader.GetOrdinal(colName)) ? 0 : Convert.ToInt32(reader[colName]);
        }

        public static bool GetBoolean(SqlDataReader reader, string colName)
        {
            return reader.IsDBNull(reader.GetOrdinal(colName)) ? default(bool) : Convert.ToBoolean(reader[colName]);
        }

        public static bool IsColoumnExist(this IDataRecord dataReader, string colName)
        {
            try
            {
                return dataReader.GetOrdinal(colName) >= 0;
            }
            catch
            {
                return false;
            }
        }

        public static T GetGeneric<T>(SqlDataReader reader, string colName)
        {
            return reader.IsDBNull(reader.GetOrdinal(colName)) ? default(T) : (T)reader[colName];
        }

        public static string GetStringValue(object value)
        {
            return (value ?? "").ToString();
        }

        public static int GetIntValue(object value)
        {
            return Convert.ToInt32(value);
        }

    }
}
