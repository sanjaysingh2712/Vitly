using System.Collections.Generic;
using System.Web.Mvc;
using Vitly.Models;
using Vitly.ViewModels;
using Customer = Vitly.DatabaseAccess.Core.Model.Customer;

namespace Vitly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie {Name = "Shrek!"};
            var customers = new List<Customer>
            {
                new Customer {CustomerId = 1, Name = "John Smith"},
                new Customer {CustomerId = 2, Name = "Mary Poppins"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return this.View(viewModel);
        }

        // movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue) { pageIndex = 1; }

            if (string.IsNullOrWhiteSpace(sortBy)) { sortBy = "Name"; }

            return this.Content($"pageIndex={pageIndex}&sortBy={sortBy}");
        }

        //routes.MapRoute(
        //name: "MoviesByReleaseDate",
        //url: "movies/released/{year}/{month}",
        //defaults: new {controller = "Movies", action = "ByReleaseDate"},
        //constraints: new {year = @"2016|2018", month = @"\d{2}"});

        [Route(@"movies/released/{year:regex(^\d{4}$)}/{month:regex(\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return this.Content($"{year}/{month}");
        }
    }
}