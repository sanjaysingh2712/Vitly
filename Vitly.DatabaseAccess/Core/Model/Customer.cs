using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vitly.DatabaseAccess.Core.Model
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public bool IsSubscribedToNewletter { get; set; }
        //public MempershipType MempershipType { get; set; }
        //public int MembersipTypeId { get; set; }
    }
}
