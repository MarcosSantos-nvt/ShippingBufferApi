namespace Domain.Interfaces.Util
{
    public interface IDapperItlSys
    {
        IEnumerable<T> RunQueryItlSys<T>(string query, object parametros = null, int timeout = 30);
        T QueryFirstOrDefaultItlSys<T>(string query, object parametros = null, int timeout = 30);
    }
}
