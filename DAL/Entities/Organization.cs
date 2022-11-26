using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public partial class Organization
    {
        public Guid id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string address { get; set; }

        public virtual ICollection<Manager> Managers { get; set; }
    }
}
