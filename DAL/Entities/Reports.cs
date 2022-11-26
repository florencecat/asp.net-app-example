using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class ManagerReport
    {
        public string ManagerName { get; set; }
        public string Nickname { get; set; }
        public string Email { get; set; }
        public Guid Organization { get; set; }
    }
}
