using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Vitly.DatabaseAccess.Core.Models;

namespace Vitly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            List<Customer> customers = this.GetCustomers();
            return this.View(customers);
        }

        public ActionResult Details(int id)
        {
            List<Customer> customers = this.GetCustomers();
            Customer customer = customers.FirstOrDefault(c => c.CustomerId == id);
            return customer != null ? this.View(customer) : null;
        }

        private List<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer
                {
                    CustomerId = 1,
                    Name = "John Smith",
                    IsSubscribedToNewletter = true,
                    MembershipType = new MembershipType {MembershipTypeId = 1}
                },
                new Customer
                {
                    CustomerId = 2,
                    Name = "Mary Poppins",
                    IsSubscribedToNewletter = false,
                    MembershipType = new MembershipType {MembershipTypeId = 2}
                }
            };
        }
    }
}