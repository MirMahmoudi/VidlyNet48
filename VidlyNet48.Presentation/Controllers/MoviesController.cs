using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
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

		// GET: Movies/New
		public ActionResult New()
		{
			var movieForm = new MovieFormViewModel()
			{
				Genres = _context.Genres.ToList()
			};

			return View("MovieForm", movieForm);
		}

		// POST: Movies/Save
		[HttpPost]
		public ActionResult Save(Movie movie)
		{
			if (movie.Id == 0)
			{
				movie.DateAdded = DateTime.Now;
				_context.Movies.Add(movie);
			}
			else
			{
				var movieInDb = _context.Movies.Single(m => m.Id == movie.Id);
				movieInDb.Name = movie.Name;
				movieInDb.GenreId = movie.GenreId;
				movieInDb.NumberInStuck = movie.NumberInStuck;
				movieInDb.ReleaseDate = movie.ReleaseDate;
			}

			_context.SaveChanges();
			return RedirectToAction("Index" , "Movies");
		}

		// Get: Movies/Edit/:id
		public ActionResult Edit(int id)
		{
			var movie = _context.Movies.SingleOrDefault(m => m.Id == id);

			if(movie is null) return HttpNotFound();

			var movieForm = new MovieFormViewModel()
			{
				Movie = movie,
				Genres = _context.Genres.ToList()
			};
			return View("MovieForm", movieForm);
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