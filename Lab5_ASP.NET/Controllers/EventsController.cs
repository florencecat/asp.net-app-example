using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL.Interfaces;
using BLL.Models;
using PL.Models;  

namespace PL.Controllers
{
    public class EventsController : Controller
    {
        // GET: Events
        IDataBaseCRUD dataBaseCRUD;
        
        public EventsController(IDataBaseCRUD dataBaseCRUD)
        {
            this.dataBaseCRUD = dataBaseCRUD;
        }
        public ActionResult Index()
        {
            return View("Index", dataBaseCRUD.GetAllEvents());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View(new ExtendedEventModel(dataBaseCRUD.GetAllManagers()));
        }
        [HttpPost]
        public ActionResult Create(ExtendedEventModel @event)
        {
            EventModel newEvent = new EventModel();
            newEvent.name = @event.name;
            newEvent.date = @event.date;
            newEvent.description = @event.description;
            newEvent.authorID = @event.authorID;

            dataBaseCRUD.CreateEvent(newEvent);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Update(Guid id)
        {
            ExtendedEventModel @event = new ExtendedEventModel(dataBaseCRUD.GetEvent(id), dataBaseCRUD.GetAllManagers());

            return View(@event);
        }
        [HttpPost]
        public ActionResult Update(ExtendedEventModel @event)
        {
            EventModel newEvent = new EventModel();
            newEvent.id = @event.id;
            newEvent.name = @event.name;
            newEvent.description = @event.description;
            newEvent.date = @event.date;
            newEvent.authorID = @event.authorID;

            dataBaseCRUD.UpdateEvent(newEvent);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(Guid id)
        {
            dataBaseCRUD.DeleteEvent(id);

            return RedirectToAction("Index");
        }
    }
}