using BLL.Models;
using System;

namespace BLL.Interfaces
{
    public interface IEventService
    {
        bool CreateEvent(EventModel newEventModel);
    }
}
