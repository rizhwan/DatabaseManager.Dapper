using System.Collections.Generic;

namespace DatabaseManager.Dapper
{
    public interface IDatabaseManager
    {
        void Execute(string sql, object paramameters = null);
        List<T> Query<T>(string sql, object paramameters = null);
        T QueryFirstOrDefault<T>(string sql, object paramameters = null);
    }
}