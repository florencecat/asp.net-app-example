using System;
using System.Collections.Generic;
using System.Linq;
using BLL.Interfaces;
using BLL.Models;
using DAL.Interfaces;

namespace BLL.Services
{
    public class ReportService : IReportService
    {
        IDBRepository repository;
        public ReportService(IDBRepository repository) { this.repository = repository; }
        public List<ManagerReport> ManagersOfOrganization(Guid organization)
        {
            return repository.Reports.ManagersOfOrganization(organization)
                .Select(m => new ManagerReport() { ManagerName = m.ManagerName, Email = m.Email, Nickname = m.Nickname, Organization = m.Organization })
                .ToList();
        }
    }
}
