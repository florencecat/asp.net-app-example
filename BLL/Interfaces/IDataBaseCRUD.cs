using System;
using System.Collections.Generic;
using BLL.Models;

namespace BLL.Interfaces
{
    public interface IDataBaseCRUD
    {
        List<EventModel> GetAllEvents();
        List<ManagerModel> GetAllManagers();
        List<OrganizationModel> GetAllOrganizations();
        EventModel GetEvent(Guid id);
        void CreateEvent(EventModel e);
        void UpdateEvent(EventModel @event);
        void DeleteEvent(Guid id);
    }
}
