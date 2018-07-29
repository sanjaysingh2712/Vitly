using System.Data.Entity;
using Vitly.DatabaseAccess.Core.Model;
using Vitly.DatabaseAccess.Core.Repositories;

namespace Vitly.DatabaseAccess.Persistence.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository {
        public CustomerRepository(DbContext context) : base(context) { }

        public VitlyContext VitlyContext => this.Context as VitlyContext;
    }
}
