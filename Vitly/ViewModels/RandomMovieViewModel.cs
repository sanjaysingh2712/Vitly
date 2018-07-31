using System.Collections.Generic;
using Vitly.DatabaseAccess.Core.Model;

namespace Vitly.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}