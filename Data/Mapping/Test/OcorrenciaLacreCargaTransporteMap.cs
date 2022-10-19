using Domain.Models.ModelTest;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mapping.Test
{
    public class OcorrenciaLacreCargaTransporteMap : IEntityTypeConfiguration<OcorrenciaLacreCargaTransporte>
    {
        public void Configure(EntityTypeBuilder<OcorrenciaLacreCargaTransporte> builder)
        {
            builder.ToTable("OcorrenciaLacreCargaTransporte");
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Motivo);
            builder.Property(t => t.CodigoLacre);
            builder.Property(t => t.UsuarioCadastroId).HasColumnName("IdUsuarioCadastro");
            builder.Property(t => t.Observacao);
            builder.Property(t => t.DataCadastro);
            builder.Property(t => t.UrlImagem);
            builder.Property(t => t.LacreId).HasColumnName("IdLacre");
        }
    }
}
