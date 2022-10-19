using Domain.Models.ModelTest;

namespace Domain.Interfaces.Test
{
    public interface IItlSysRepositoryTest
    {
        List<OcorrenciaLacreCargaTransporte> TestaItlSysDbConn_EFCore();

        IEnumerable<OcorrenciaLacreCargaTransporte> TestaItlSysDbConn_Dapper();
    }
}
