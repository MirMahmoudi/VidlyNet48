using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using VidlyNet48.Presentation.Models;
using VidlyNet48.Presentation.ViewModels;

namespace VidlyNet48.Presentation.Controllers
{
	public class MoviesController : Controller
	{
		private readonly ApplicationDbContext _context;

		public MoviesController()
		{
			_context = new ApplicationDbContext();
		}

		protected override void Dispose(bool disposing)
		{
			_context.Dispose();
		}

		// GET: Movies
		public ActionResult Index()
		{
			var movies = _context.Movies
				.Include(m => m.Genre);

			return View(movies);
		}

		// GET: Movies/Details/Id
		public ActionResult Details(int id)
		{
			var movie = _context.Movies
				.Include(m => m.Genre)
				.SingleOrDefault(m => m.Id == id);

			if (movie is null) return HttpNotFound();
			return View(movie);
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
	}
}