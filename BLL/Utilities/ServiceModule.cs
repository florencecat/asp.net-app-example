using DAL.Interfaces;
using DAL.Repositories;
using Ninject.Modules;

namespace BLL
{
    public class ServiceModule : NinjectModule
    {
        public ServiceModule() { }
        public override void Load()
        {
            Bind<IDBRepository>().To<DBRepositorySQL>().InSingletonScope();
        }
    }
}
