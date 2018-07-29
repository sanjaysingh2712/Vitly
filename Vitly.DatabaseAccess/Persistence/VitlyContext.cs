using System.Data.Entity;
using Vitly.DatabaseAccess.Core.Model;
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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerConfiguration());
        }
    }
}