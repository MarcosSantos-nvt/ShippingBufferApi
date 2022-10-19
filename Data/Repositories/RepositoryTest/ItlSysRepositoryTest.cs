using Data.Contexts;
using Domain.Interfaces.Test;
using Domain.Interfaces.Util;
using Domain.Models.ModelTest;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories.RepositoryTest
{
    public class ItlSysRepositoryTest : IItlSysRepositoryTest
    {
        private readonly DbSet<OcorrenciaLacreCargaTransporte> _dbSet;       
        private readonly IDapperItlSys _dapperItlSys;

        public ItlSysRepositoryTest(ItlSysContext context, IDapperItlSys dapperItlSys)
        {
            _dbSet = context.Set<OcorrenciaLacreCargaTransporte>();           
            _dapperItlSys = dapperItlSys;
        }
        public IEnumerable<OcorrenciaLacreCargaTransporte> TestaItlSysDbConn_Dapper()
        {
            string sql = @"SELECT * FROM OcorrenciaLacreCargaTransporte WHERE id = 20;";

            return _dapperItlSys.RunQueryItlSys<OcorrenciaLacreCargaTransporte>(sql);

            //int timeOut = 3600;

            //return _dapper.RunQuery<OcorrenciaLacreCargaTransporte>(sql.ToString(), _dataBaseAlias.ItlSys, DataBase.ItlSys, timeOut);
        }

        public List<OcorrenciaLacreCargaTransporte> TestaItlSysDbConn_EFCore()
        {
            return _dbSet.Where(x => x.Id == 21).ToList();
        }
    }
}
