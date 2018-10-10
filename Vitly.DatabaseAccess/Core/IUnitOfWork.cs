using System;
using DatabaseManager.Repositories;
using Vitly.DatabaseAccess.Core.Models;
using Vitly.DatabaseAccess.Core.Repositories;

namespace Vitly.DatabaseAccess.Core {
    public interface IUnitOfWork : IDisposable
    {
        ICustomerRepository Customers { get; }
        IRepository<MembershipType> MembershipTypes { get; }
        int Commit();
    }
}