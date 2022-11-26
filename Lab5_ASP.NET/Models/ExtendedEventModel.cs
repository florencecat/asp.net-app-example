using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PL.Models
{
    public class ExtendedEventModel : EventModel
    {
        public List<ManagerModel> Managers { get; set; }
        public ExtendedEventModel() { }
        public ExtendedEventModel(List<ManagerModel> Managers)
        {
            this.Managers = Managers;
        }
        public ExtendedEventModel(EventModel @event, List<ManagerModel> Managers)
        {
            this.id = @event.id;
            this.name = @event.name;
            this.description = @event.description;
            this.date = @event.date;
            this.authorID = @event.authorID;
            this.Managers = Managers;
        }
    }
}