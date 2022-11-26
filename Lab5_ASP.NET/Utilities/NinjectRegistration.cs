using Ninject.Modules;
using BLL.Interfaces;
using BLL.Services;
using BLL;

namespace PL
{
    public class NinjectRegistration : NinjectModule
    {
        public override void Load()
        {
            Bind<IDataBaseCRUD>().To<DbDataOperation>();
            Bind<IReportService>().To<ReportService>();
            Bind<IEventService>().To<EventService>();
        }
    }
}
