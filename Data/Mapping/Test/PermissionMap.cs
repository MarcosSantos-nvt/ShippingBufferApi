using Domain.Models.ModelTest;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mapping.Test
{
    public class PermissionMap : IEntityTypeConfiguration<Permission>
    {
        public void Configure(EntityTypeBuilder<Permission> builder)
        {
            builder.ToTable("Permission");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name);
            builder.Property(x => x.Description);
            builder.Property(x => x.Ai_Created);
            builder.Property(x => x.Version);
        }
    }
}
