using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL.Interfaces;
using PL.Models;

namespace PL.Controllers
{
    public class ReportController : Controller
    {
        // GET: Report
        IDataBaseCRUD dataBaseCRUD;
        IReportService reportService;
        public ReportController(IDataBaseCRUD dataBaseCRUD, IReportService reportService)
        {
            this.dataBaseCRUD = dataBaseCRUD;
            this.reportService = reportService;
        }
        [HttpGet]
        public ActionResult Index()
        {
            return View(new ExtendedReportModel() { Organizations = dataBaseCRUD.GetAllOrganizations() });
        }
        [HttpPost]
        public ActionResult Index(ExtendedReportModel report)
        {
            report.ReportData = reportService.ManagersOfOrganization(report.OrganizationID);
            report.Organizations = dataBaseCRUD.GetAllOrganizations();

            return View(report);
        }

    }
}