using System;
using System.Collections.Generic;
using BLL.Models;

namespace BLL.Interfaces
{
    public interface IReportService
    {
        List<ManagerReport> ManagersOfOrganization(Guid organization);
    }
}
