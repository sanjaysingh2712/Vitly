using System;
using System.ComponentModel.DataAnnotations;

namespace Vitly.DatabaseAccess.Core.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public bool IsSubscribedToNewletter { get; set; }
        public MembershipType MembershipType { get; set; }
        public int MembershipTypeId { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
