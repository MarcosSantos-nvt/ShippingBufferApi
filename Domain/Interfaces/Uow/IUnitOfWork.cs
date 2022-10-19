namespace Domain.Interfaces.Uow
{
    public interface IUnitOfWork : IDisposable
    {
        bool CommitItlSys();
        bool CommitWamasHavan();
    }
}
