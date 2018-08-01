using System.Data.Entity;
using Vitly.DatabaseAccess.Core.Models;
using Vitly.DatabaseAccess.Persistence.EntityConfigurations;

namespace Vitly.DatabaseAccess.Persistence
{
    public class VitlyContext : DbContext
    {
        public VitlyContext()
            : base("name=VitlyContext")
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<MembershipType> MempershipTypes { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerConfiguration());
            modelBuilder.Configurations.Add(new MovieConfiguration());
        }
    }
}