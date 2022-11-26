using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DAL.Entities
{
    public partial class EventContext : DbContext
    {
        public EventContext()
            : base("name=EventContext")
        {
        }

        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Manager> Managers { get; set; }
        public virtual DbSet<Organization> Organizations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Manager>()
                .HasMany(e => e.Events)
                .WithRequired(e => e.Manager)
                .HasForeignKey(e => e.authorID);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.Managers)
                .WithRequired(e => e.Organization)
                .HasForeignKey(e => e.organization);
        }
    }
}
