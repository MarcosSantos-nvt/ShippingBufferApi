using Data.Contexts;
using Domain.Interfaces.Test;
using Domain.Interfaces.Util;
using Domain.Models.ModelTest;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories.RepositoryTest
{
    public class WamasRepositoryTest : IWamasRepositoryTest
    {
        private readonly DbSet<Permission> _dbSet;       
        private readonly IDapperWamasHavan _dapperWamasHavan;

        public WamasRepositoryTest(WamasHavanContext context, IDapperWamasHavan dapperWamasHavan)
        {
            _dbSet = context.Set<Permission>();            
            _dapperWamasHavan = dapperWamasHavan;
        }
        public IEnumerable<Permission> TestaWamas_HavanDbConn_Dapper()
        {
            string sql = @"SELECT * FROM Permission WHERE id = 54;";            

            return _dapperWamasHavan.RunQueryWamasHavan<Permission>(sql);           
        }

        public List<Permission> TestaWamas_HavanDbConn_EFCore()
        {
            return _dbSet.Where(p => p.Id == 60).ToList();
        }
    }
}
