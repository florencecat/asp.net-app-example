using System;

namespace DAL.Entities
{
    public partial class Event
    {
        public Guid id { get; set; }
        public string event_name { get; set; }
        public string description { get; set; }
        public Guid authorID { get; set; }
        public DateTime date { get; set; }

        public virtual Manager Manager { get; set; }
    }
}
