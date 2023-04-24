using System.Collections.Generic;
using System.Web.Mvc;
using VidlyNet48.Presentation.Models;
using VidlyNet48.Presentation.ViewModels;

namespace VidlyNet48.Presentation.Controllers
{
	public class MoviesController : Controller
	{
		// GET: Movies
		public ActionResult Index()
		{
			var movies = GetMovies();

			return View(movies);
		}

		// GET: Movies/Random
		public ActionResult Random()
		{
			var movie = new Movie { Name = "Shrek" };
			var customers = new List<Customer>
			{
				new Customer{Name = "Customer1"},
				new Customer{Name = "Customer2"}
			};

			var viewModel = new RandomMovieViewModel
			{
				Movie = movie,
				Customers = customers
			};

			return View(viewModel);
		}

		private IEnumerable<Movie> GetMovies()
		{
			return new List<Movie>
			{
				new Movie {Name = "Shrek"},
				new Movie {Name = "Wall-e"}
			};
		}
	}
}