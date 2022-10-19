using Data.Contexts;
using Domain.Interfaces.Uow;
using Havan.Logistica.Core.Notifications;

namespace Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ItlSysContext _itlSysContext;
        private readonly WamasHavanContext _wamasHavanContext;
        private readonly INotifier _notifier;

        public UnitOfWork(ItlSysContext itlSysContext, WamasHavanContext wamasHavanContext)
        {
            _itlSysContext = itlSysContext;
            _wamasHavanContext = wamasHavanContext;
        }

        public bool CommitWamasHavan()
        {
            try
            {
                if (_notifier.HasNotifications())
                    return false;

                return _wamasHavanContext.SaveChanges() > 0;
            }
            catch (Exception e)
            {
                _notifier.Notify(new Notification(e.Message));
                return false;
            }
        }

        public bool CommitItlSys()
        {
            try
            {
                if (_notifier.HasNotifications())
                    return false;

                return _itlSysContext.SaveChanges() > 0;
            }
            catch (Exception e)
            {
                _notifier.Notify(new Notification(e.Message));
                return false;
            }
        }

        public void Dispose()
        {
            _itlSysContext?.Dispose();
            _wamasHavanContext?.Dispose();
        }
    }
}
