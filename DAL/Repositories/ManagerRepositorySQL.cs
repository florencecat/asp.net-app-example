using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DAL.Entities;
using DAL.Interfaces;

namespace DAL.Repositories
{
    class ManagerRepositorySQL : IRepository<Manager>
    {
        EventContext eventContext;
        public ManagerRepositorySQL(EventContext eventContext) { this.eventContext = eventContext; }

        public List<Manager> GetList() { return eventContext.Managers.ToList(); }

        public Manager GetItem(Guid managerID) { return eventContext.Managers.Find(managerID); }

        public void CreateItem(Manager manager) { eventContext.Managers.Add(manager); }

        public void UpdateItem(Manager manager) { eventContext.Entry(manager).State = EntityState.Modified; }

        public void DeleteItem(Guid managerID)
        {
            Manager manager = eventContext.Managers.Find(managerID);
            if (manager != null) eventContext.Managers.Remove(manager);
        }
    }
}
