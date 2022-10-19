using Havan.Core;

namespace Domain.Models.ModelTest
{
    public class OcorrenciaLacreCargaTransporte : Entity<int>
    {
        public long LacreId { get; private set; }
        public string CodigoLacre { get; private set; }
        public short Motivo { get; private set; }
        public string Observacao { get; private set; }
        public string UrlImagem { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public long UsuarioCadastroId { get; private set; }

        public OcorrenciaLacreCargaTransporte()
        {

        }
    }
}
