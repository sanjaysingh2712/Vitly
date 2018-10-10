using System.Collections.Generic;
using Vitly.DatabaseAccess.Core.Models;

namespace Vitly.ViewModels
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}