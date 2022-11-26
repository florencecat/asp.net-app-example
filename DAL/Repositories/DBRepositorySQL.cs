using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using DAL.Entities;

namespace DAL.Repositories
{
    public class DBRepositorySQL : IDBRepository
    {
        EventContext eventContext;

        EventRepositorySQL eventRepository;
        ManagerRepositorySQL managerRepository;
        OrganizationRepositorySQL organizationRepository;
        ReportRepositorySQL reportRepository;

        public DBRepositorySQL()
        {
            eventContext = new EventContext();
        }

        public IRepository<Event> Events
        {
            get
            {
                if (eventRepository == null)
                    eventRepository = new EventRepositorySQL(eventContext);

                return eventRepository;
            }
        }

        public IRepository<Manager> Managers
        {
            get
            {
                if (managerRepository == null)
                    managerRepository = new ManagerRepositorySQL(eventContext);

                return managerRepository;
            }
        }

        public IRepository<Organization> Organizations
        {
            get
            {
                if (organizationRepository == null)
                    organizationRepository = new OrganizationRepositorySQL(eventContext);

                return organizationRepository;
            }
        }

        public IReportsRepository Reports
        {
            get
            {
                if (reportRepository == null)
                    reportRepository = new ReportRepositorySQL(eventContext);

                return reportRepository;
            }
        }

        public int Save()
        {
            return eventContext.SaveChanges();
        }
    }
}
