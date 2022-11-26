using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DAL.Entities;
using DAL.Interfaces;

namespace DAL.Repositories
{
    class EventRepositorySQL : IRepository<Event>
    {
        EventContext eventContext;

        public EventRepositorySQL(EventContext eventContext) { this.eventContext = eventContext; }

        public List<Event> GetList() { return eventContext.Events.ToList(); }

        public Event GetItem(Guid eventID) { return eventContext.Events.Find(eventID); }

        public void CreateItem(Event @event) { eventContext.Events.Add(@event); }

        public void UpdateItem(Event @event) { eventContext.Entry(@event).State = EntityState.Modified; }

        public void DeleteItem(Guid eventID)
        {
            Event @event = eventContext.Events.Find(eventID);
            if (@event != null) eventContext.Events.Remove(@event);
        }
    }
}
