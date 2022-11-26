using BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL.Controllers
{
    public class ManagersController : Controller
    {
        // GET: Managers
        IDataBaseCRUD dataBaseCRUD;
        public ManagersController(IDataBaseCRUD dataBaseCRUD)
        {
            this.dataBaseCRUD = dataBaseCRUD;
        }
        public ActionResult Index()
        {
            return View("Index", dataBaseCRUD.GetAllManagers());
        }
    }
}