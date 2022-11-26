using DAL.Entities;
using DAL.Interfaces;
using BLL.Models;
using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class EventService : IEventService
    {
        IDBRepository database;

        public EventService(IDBRepository repository)
        {
            database = repository;
        }

        public bool CreateEvent(EventModel newEventModel)
        {
            Event newEvent = new Event();

            newEvent.id = newEventModel.id;
            newEvent.event_name = newEventModel.name;
            newEvent.description = newEventModel.description;
            newEvent.date = newEventModel.date;
            newEvent.authorID = newEventModel.authorID;

            database.Events.CreateItem(newEvent);

            if (database.Save() > 0)
                return true;
            else
                return false;
        }
    }
}
