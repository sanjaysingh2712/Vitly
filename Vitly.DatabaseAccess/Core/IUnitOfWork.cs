using System;
using Vitly.DatabaseAccess.Core.Repositories;

namespace Vitly.DatabaseAccess.Core {
    public interface IUnitOfWork : IDisposable
    {
        ICustomerRepository Customers { get; }
        int Commit();
    }
}