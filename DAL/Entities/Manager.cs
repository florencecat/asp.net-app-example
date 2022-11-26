namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Manager
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Manager()
        {
            Events = new HashSet<Event>();
        }

        [Key]
        public Guid userID { get; set; }

        public Guid organization { get; set; }

        public string name { get; set; }

        public string nickname { get; set; }

        public string email { get; set; }

        public string password { get; set; }

        public virtual ICollection<Event> Events { get; set; }

        public virtual Organization Organization { get; set; }
    }
}
