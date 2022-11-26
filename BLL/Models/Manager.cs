using DAL.Entities;
using System;
using System.ComponentModel;

namespace BLL.Models
{
    public class ManagerModel
    {
        public Guid userID { get; set; }
        [DisplayName("Организация")]
        public Guid organization { get; set; }
        [DisplayName("Имя")]
        public string name { get; set; }
        [DisplayName("Логин")]
        public string nickname { get; set; }
        [DisplayName("Почта")]
        public string email { get; set; }
        public string password { get; set; }

        public ManagerModel() { }
        public ManagerModel(Manager m)
        {
            this.userID = m.userID;
            this.organization = m.organization;
            this.name = m.name;
            this.nickname = m.nickname;
            this.email = m.email;
            this.password = m.password;
        }
    }
}
