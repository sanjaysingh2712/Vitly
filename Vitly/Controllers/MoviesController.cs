using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Vitly.DatabaseAccess.Core.Models;
using Vitly.ViewModels;


namespace Vitly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            IEnumerable<Movie> movies = GetMovies();
            List<Customer> customers = GetCustomers();
            

            var viewModel = new RandomMovieViewModel
            {
                Movie = movies.First(),
                Customers = customers
            };

            return this.View(viewModel);
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

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie {MovieId = 1, Name = "Shrek!"},
                new Movie {MovieId = 2, Name = "Mickey Mouse"}
            };
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