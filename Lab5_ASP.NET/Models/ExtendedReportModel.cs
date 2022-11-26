using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PL.Models
{
    public class ExtendedReportModel
    {
        public List<ManagerReport> ReportData { get; set; }
        public List<OrganizationModel> Organizations { get; set; }
        public Guid OrganizationID { get; set; }
    }
}