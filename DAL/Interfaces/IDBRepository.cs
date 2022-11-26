using DAL.Entities;

namespace DAL.Interfaces
{
    public interface IDBRepository
    {
        IRepository<Event> Events { get; }
        IRepository<Manager> Managers { get; }
        IRepository<Organization> Organizations { get; }
        IReportsRepository Reports { get; }
        
        int Save();
    }
}
