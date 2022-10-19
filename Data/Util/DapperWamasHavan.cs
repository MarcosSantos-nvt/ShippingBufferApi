using Dapper;
using Domain.Interfaces.Util;
using System.Data;

namespace Data.Util
{
    public class DapperWamasHavan : IDapperWamasHavan
    {
        IDbConnection _sqlConnection;

        public DapperWamasHavan(List<IDbConnection> dbConnection)
        {
            _sqlConnection = dbConnection.FirstOrDefault(d => d.Database.Contains("wamas_havan", StringComparison.OrdinalIgnoreCase));
        }
        public void InsertWamasHavan(string query, object parametros, int timeout = 30)
        {
            _sqlConnection.Execute(query, parametros, commandTimeout: timeout);
        }

        public T QueryFirstOrDefaultWamasHavan<T>(string query, object parametros = null, int timeout = 30)
        {
            return _sqlConnection.QueryFirstOrDefault<T>(query, parametros, commandTimeout: timeout);
        }

        public IEnumerable<T> RunQueryWamasHavan<T>(string query, object parametros = null, int timeout = 30)
        {
            return _sqlConnection.Query<T>(query, parametros, commandTimeout: timeout);
        }
    }
}
