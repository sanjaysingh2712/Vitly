using System.Data.Entity;
using DatabaseManager.Repositories;
using Vitly.DatabaseAccess.Core;
using Vitly.DatabaseAccess.Core.Models;
using Vitly.DatabaseAccess.Core.Repositories;
using Vitly.DatabaseAccess.Persistence.Repositories;

namespace Vitly.DatabaseAccess.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext context;

        public UnitOfWork(DbContext context)
        {
            this.context = context;
            this.Customers = new CustomerRepository(context);
            this.MembershipTypes = new Repository<MembershipType>(context);
            this.Movies = new Repository<Movie>(context);
        }

        public IRepository<MembershipType> MembershipTypes { get; }
        public IRepository<Movie> Movies { get; }

        public ICustomerRepository Customers { get; }

        public int Commit()
        {
            return this.context.SaveChanges();
        }

        public void Dispose()
        {
            this.context?.Dispose();
        }
    }
}