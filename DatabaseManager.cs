using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace DatabaseManager.Dapper
{
    public class DatabaseManager : IDatabaseManager
    {
        private readonly string _connectionString;

        public DatabaseManager(string connectionString)
        {
            _connectionString = connectionString;
        }

        private IDbConnection Connection
        {
            get
            {
                return new SqlConnection(_connectionString);
            }
        }

        public List<T> Query<T>(string sql, object paramameters = null)
        {
            using (IDbConnection conn = Connection)
            {
                var result = conn.Query<T>(sql, paramameters);
                return result.AsList();
            }
        }

        public T QueryFirstOrDefault<T>(string sql, object paramameters = null)
        {
            using (IDbConnection conn = Connection)
            {
                return conn.QueryFirstOrDefault<T>(sql, paramameters);
            }
        }

        public void Execute(string sql, object paramameters = null)
        {
            using (IDbConnection conn = Connection)
            {
                conn.Execute(sql, paramameters);
            }
        }
    }
}
