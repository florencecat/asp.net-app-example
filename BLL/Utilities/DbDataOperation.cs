using DAL.Entities;
using DAL.Interfaces;
using BLL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using BLL.Interfaces;

namespace BLL
{
    public class DbDataOperation : IDataBaseCRUD
    {
        IDBRepository database;

        public DbDataOperation(IDBRepository repository)
        {
            database = repository;
        }

        public List<EventModel> GetAllEvents() { return database.Events.GetList().Select(e => new EventModel(e)).ToList(); }
        public List<ManagerModel> GetAllManagers() { return database.Managers.GetList().Select(m => new ManagerModel(m)).ToList(); }
        public List<OrganizationModel> GetAllOrganizations() { return database.Organizations.GetList().Select(m => new OrganizationModel(m)).ToList(); }
        public EventModel GetEvent(Guid id) { return new EventModel(database.Events.GetItem(id)); }
        public void CreateEvent(EventModel e)
        {
            database.Events.CreateItem(new Event() { id = Guid.NewGuid(), event_name = e.name, description = e.description, authorID = e.authorID });
            Save();
        }
        public void UpdateEvent(EventModel @event)
        {
            Event newEvent = database.Events.GetItem(@event.id);

            newEvent.event_name = @event.name;
            newEvent.description = @event.description;
            newEvent.date = @event.date;
            newEvent.authorID = @event.authorID;

            Save();
        }
        public bool Save()
        {
            if (database.Save() > 0) 
                return true;
            else
                return false;
        }
        public void DeleteEvent(Guid id)
        {
            Event selectedEvent = database.Events.GetItem(id);
            if (selectedEvent != null)
            {
                database.Events.DeleteItem(selectedEvent.id);
                Save();
            }
        }
    }
}
