using System.Web.Mvc;
using Vitly.Models;

namespace Vitly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie {Name = "Shrek!"};
            return this.View(movie);
        }

        public ActionResult Edit(int id)
        {
            return this.Content("id = " + id);
        }

        // movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue) { pageIndex = 1; }

            if (string.IsNullOrWhiteSpace(sortBy)) { sortBy = "Name"; }

            return Content($"pageIndex={pageIndex}&sortBy={sortBy}");
        }

        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content($"{year}/{month}");
        }
    }
}