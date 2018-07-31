using System.Data.Entity;
using Vitly.DatabaseAccess.Core;
using Vitly.DatabaseAccess.Core.Model;
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
            Customers = new CustomerRepository(context);
            MembershipTypes = new Repository<MembershipType>(context);
            Movies = new Repository<Movie>(context);
        }

        public ICustomerRepository Customers { get; }
        public IRepository<MembershipType> MembershipTypes { get; }
        public IRepository<Movie> Movies { get; }

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