using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vitly.DatabaseAccess.Core.Model;
using Vitly.DatabaseAccess.Core.Repositories;

namespace Vitly.DatabaseAccess.Persistence.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository {
        public CustomerRepository(DbContext context) : base(context) { }

        public VitlyContext VitlyContext => this.Context as VitlyContext;
    }
}
