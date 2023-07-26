using System;
using System.Linq;
using System.Web.Http;
using VidlyNet48.Presentation.Dto;
using VidlyNet48.Presentation.Models;
using VidlyNet48.Presentation.Models.IdentityModels;

namespace VidlyNet48.Presentation.Controllers.Api
{
	public class NewRentalsController : ApiController
	{
		private readonly ApplicationDbContext _dbContext;

		public NewRentalsController()
		{
			_dbContext = new ApplicationDbContext();
		}

		[HttpPost]
		public IHttpActionResult CreateNewRentals(NewRentalDto newRental)
		{
			if (newRental.MovieIds.Count is 0)
				return BadRequest("No Movie Ids have been given!");

			var customer = _dbContext.Customers.SingleOrDefault(c => c.Id == newRental.CustomerId);

			if (customer is null)
				return BadRequest("Customer Id is not valid!");

			var movies = _dbContext.Movies.Where(m => newRental.MovieIds.Contains(m.Id)).ToList();

			if (movies.Count != newRental.MovieIds.Count)
				return BadRequest("One or more Movie Ids are invalid!");

			foreach (var movie in movies)
			{
				if (movie.NumberAvailable is 0)
					return BadRequest($"{movie.Name} with id:{movie.Id} is not available!");

				movie.NumberAvailable--;
				var rental = new Rental
				{
					Customer = customer,
					Movie = movie,
					DateRented = DateTime.Now
				};

				_dbContext.Rentals.Add(rental);
			}

			_dbContext.SaveChanges();

			return Ok();
		}
	}
}
