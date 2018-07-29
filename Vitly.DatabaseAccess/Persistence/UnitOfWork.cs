using System.Data.Entity;
using Vitly.DatabaseAccess.Core;
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
        }

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