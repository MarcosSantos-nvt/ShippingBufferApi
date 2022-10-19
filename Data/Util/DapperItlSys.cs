using Dapper;
using Domain.Interfaces.Util;
using System.Data;

namespace Data.Util
{
    public class DapperItlSys : IDapperItlSys
    {
        IDbConnection _sqlConnection;

        public DapperItlSys(List<IDbConnection> dbConnection)
        {
            _sqlConnection = dbConnection.FirstOrDefault(d => d.Database.Contains("itlsys", StringComparison.OrdinalIgnoreCase));
        }
        public T QueryFirstOrDefaultItlSys<T>(string query, object parametros = null, int timeout = 30)
        {
            return _sqlConnection.QueryFirstOrDefault<T>(query, parametros, commandTimeout: timeout);
        }

        public IEnumerable<T> RunQueryItlSys<T>(string query, object parametros = null, int timeout = 30)
        {
            return _sqlConnection.Query<T>(query, parametros, commandTimeout: timeout);
        }
    }
}
