using System.Collections.Generic;
using Vitly.DatabaseAccess.Core.Models;

namespace Vitly.DatabaseAccess.Manager.Interfaces {
    public interface ICustomerManager
    {
        IEnumerable<MembershipType> GetMembershipTypes();
    }
}