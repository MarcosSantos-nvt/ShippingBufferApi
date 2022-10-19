namespace Domain.Interfaces.Util
{
    public interface IDapperWamasHavan
    {
        IEnumerable<T> RunQueryWamasHavan<T>(string query, object parametros = null, int timeout = 30);
        T QueryFirstOrDefaultWamasHavan<T>(string query, object parametros = null, int timeout = 30);
        void InsertWamasHavan(string query, object parametros, int timeout = 30);
    }
}
