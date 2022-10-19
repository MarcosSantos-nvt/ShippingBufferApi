using Domain.Models.ModelTest;
using Microsoft.EntityFrameworkCore;

namespace Data.Contexts
{
    public class ItlSysContext : DbContext
    {
        public DbSet<OcorrenciaLacreCargaTransporte> OcorrenciaLacreCargaTransportes { get; set; } // Utilizado somente para o teste de integracao
        public ItlSysContext(DbContextOptions<ItlSysContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(ItlSysContext).Assembly);

            base.OnModelCreating(builder);
        }
    }
}
