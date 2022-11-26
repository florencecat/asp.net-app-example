using DAL.Entities;
using System;
using System.ComponentModel;

namespace BLL.Models
{
    public class EventModel
    {
        public Guid id { get; set; }
        [DisplayName("Название")]
        public string name { get; set; }
        [DisplayName("Описание")]
        public string description { get; set; }
        [DisplayName("Автор")]
        public Guid authorID { get; set; }
        [DisplayName("Дата")]
        public DateTime date { get; set; }

        public EventModel() { }
        public EventModel(Event e)
        {
            this.id = e.id;
            this.name = e.event_name;
            this.description = e.description;
            this.authorID = e.authorID;
            this.date = e.date;
        }
    }
}
