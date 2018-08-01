using System.Data.Entity.ModelConfiguration;
using Vitly.DatabaseAccess.Core.Models;

namespace Vitly.DatabaseAccess.Persistence.EntityConfigurations
{
    internal class MovieConfiguration : EntityTypeConfiguration<Movie>
    {
        public MovieConfiguration()
        {
            Property(m => m.Name)
                .IsRequired()
                .HasMaxLength(255);
        }
    }
}