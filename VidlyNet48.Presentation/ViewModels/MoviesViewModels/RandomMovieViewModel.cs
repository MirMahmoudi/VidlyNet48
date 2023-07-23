using System.Collections.Generic;
using VidlyNet48.Presentation.Models;

namespace VidlyNet48.Presentation.ViewModels.MoviesViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}