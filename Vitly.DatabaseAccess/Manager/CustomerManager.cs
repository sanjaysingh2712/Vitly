using System.Collections.Generic;
using Vitly.DatabaseAccess.Core;
using Vitly.DatabaseAccess.Core.Models;
using Vitly.DatabaseAccess.Manager.Interfaces;

namespace Vitly.DatabaseAccess.Manager
{
    public class CustomerManager : ICustomerManager
    {
        private readonly IUnitOfWork uow;

        public CustomerManager(IUnitOfWork uow)
        {
            this.uow = uow;
        }

        public IEnumerable<MembershipType> GetMembershipTypes()
        {
            return this.uow.MembershipTypes.GetAll();
        }
    }
}