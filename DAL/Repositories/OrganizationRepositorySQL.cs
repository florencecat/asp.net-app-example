using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DAL.Entities;
using DAL.Interfaces;

namespace DAL.Repositories
{
    class OrganizationRepositorySQL : IRepository<Organization>
    {
        EventContext eventContext;

        public OrganizationRepositorySQL(EventContext eventContext) { this.eventContext = eventContext; }

        public List<Organization> GetList() { return eventContext.Organizations.ToList(); }

        public Organization GetItem(Guid organizationID) { return eventContext.Organizations.Find(organizationID); }

        public void CreateItem(Organization organization) { eventContext.Organizations.Add(organization); }

        public void UpdateItem(Organization organization) { eventContext.Entry(organization).State = EntityState.Modified; }

        public void DeleteItem(Guid organizationID)
        {
            Organization organization = eventContext.Organizations.Find(organizationID);
            if (organization != null) eventContext.Organizations.Remove(organization);
        }
    }
}
