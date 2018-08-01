using System.Data.Entity;
using DatabaseManager.Repositories;
using Vitly.DatabaseAccess.Core.Models;
using Vitly.DatabaseAccess.Core.Repositories;

namespace Vitly.DatabaseAccess.Persistence.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository {
        public CustomerRepository(DbContext context) : base(context) { }

        public VitlyContext VitlyContext => this.Context as VitlyContext;
    }
}
