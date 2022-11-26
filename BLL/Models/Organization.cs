using System;
using DAL.Entities;

namespace BLL.Models
{
    public class OrganizationModel
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string address { get; set; }

        public OrganizationModel() { }

        public OrganizationModel(Organization o) 
        {
            this.id = o.id;
            this.name = o.name;
            this.address = o.address;
        }
    }
}
