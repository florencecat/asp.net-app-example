using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL.Repositories
{
    public class ReportRepositorySQL : IReportsRepository
    {
        EventContext eventContext;

        public ReportRepositorySQL(EventContext eventContext) { this.eventContext = eventContext; }

        public List<ManagerReport> ManagersOfOrganization(Guid organization)
        {
            return eventContext.Managers
                .Select(m => new ManagerReport() { ManagerName = m.name, Email = m.email, Nickname = m.nickname, Organization = m.organization })
                .Where(m => m.Organization == organization)
                .ToList();
        }
    }
}
