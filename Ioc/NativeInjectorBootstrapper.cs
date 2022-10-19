using Data.Contexts;
using Data.Repositories.RepositoryTest;
using Data.UnitOfWork;
using Data.Util;
using Domain.Interfaces.Test;
using Domain.Interfaces.Uow;
using Domain.Interfaces.Util;
using Havan.Persistence.ConnectionStrings;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Data;

namespace CrossCutting.Ioc
{
    public static class NativeInjectorBootstrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {

            services.AddConnectionStringProvider();
            

            services.AddDbContextPool<ItlSysContext>((sp, ob) =>
            {
                var cs = sp.GetRequiredService<IConnectionStringProvider>().GetConnectionString("ItlSys");
                ob.UseSqlServer(cs);
            });

            services.AddDbContextPool<WamasHavanContext>((cn, on) =>
            {
                var cs = cn.GetRequiredService<IConnectionStringProvider>().GetConnectionString("wamas_havan");
                on.UseSqlServer(cs);
            });

            services.AddTransient(sp =>
                new List<IDbConnection>()
                {
                    new SqlConnection(sp.GetRequiredService<IConnectionStringProvider>().GetConnectionString("itlsys")),

                    new SqlConnection(sp.GetRequiredService<IConnectionStringProvider>().GetConnectionString("wamas_havan"))
                }
            );

            services.AddHavanServices();

            services.AddScoped<IUnitOfWork, UnitOfWork>();            
            services.AddScoped<IDapperItlSys, DapperItlSys>();
            services.AddScoped<IDapperWamasHavan, DapperWamasHavan>();
            services.AddScoped<IWamasRepositoryTest, WamasRepositoryTest>();
            services.AddScoped<IItlSysRepositoryTest, ItlSysRepositoryTest>();
           
        }
    }
}
