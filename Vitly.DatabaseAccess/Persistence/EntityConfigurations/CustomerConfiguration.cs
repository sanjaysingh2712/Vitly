using System.Data.Entity.ModelConfiguration;
using Vitly.DatabaseAccess.Core.Models;

namespace Vitly.DatabaseAccess.Persistence.EntityConfigurations
{
    public class CustomerConfiguration : EntityTypeConfiguration<Customer>
    {
        public CustomerConfiguration()
        {
            Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(255);
        }
    }
}
