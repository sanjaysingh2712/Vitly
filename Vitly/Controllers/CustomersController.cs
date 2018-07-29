using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vitly.DatabaseAccess.Core.Model;

namespace Vitly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = this.GetCustomers();
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customers = this.GetCustomers();
            var customer = customers.FirstOrDefault(c => c.CustomerId == id);
            return customer != null ? View(customer) : null;
        }

        private List<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer {CustomerId = 1, Name = "John Smith", IsSubscribedToNewletter = true, MembershipType = new MembershipType{MembershipTypeId = 1}},
                new Customer {CustomerId = 2, Name = "Mary Poppins", IsSubscribedToNewletter = false, MembershipType = new MembershipType{MembershipTypeId = 2}}
            };
        }
    }
}