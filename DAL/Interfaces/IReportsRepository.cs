using System;
using System.Collections.Generic;
using DAL.Entities;

namespace DAL.Interfaces
{
    public interface IReportsRepository
    {
        List<ManagerReport> ManagersOfOrganization(Guid organization);
    }
}
