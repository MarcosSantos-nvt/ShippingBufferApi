using Domain.Models.ModelTest;

namespace Domain.Interfaces.Test
{
    public interface IWamasRepositoryTest
    {
        List<Permission> TestaWamas_HavanDbConn_EFCore();

        IEnumerable<Permission> TestaWamas_HavanDbConn_Dapper();
    }
}
