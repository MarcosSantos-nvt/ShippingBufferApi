using Domain.Models.ModelTest;
using Microsoft.EntityFrameworkCore;

namespace Data.Contexts
{
    public class WamasHavanContext : DbContext
    {
        public DbSet<Permission> Permissions{ get; set; }
        public WamasHavanContext(DbContextOptions<WamasHavanContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(WamasHavanContext).Assembly);

            base.OnModelCreating(builder);
        }
    }
}
