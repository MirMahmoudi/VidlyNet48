﻿using System;
using System.Linq;
using System.Web.Http;
using AutoMapper;
using VidlyNet48.Presentation.Dto;
using VidlyNet48.Presentation.Models;

namespace VidlyNet48.Presentation.Controllers.Api
{
	public class MoviesController : ApiController
	{
		private readonly ApplicationDbContext _dbContext;

		public MoviesController()
		{
			_dbContext = new ApplicationDbContext();
		}

		// GET: /api/Movies
		public IHttpActionResult GetMovies()
		{
			return Ok(_dbContext.Movies.ToList().Select(Mapper.Map<Movie, MovieDto>));
		}

		// GET: /api/Movies/:id
		public IHttpActionResult GetMovie(int id)
		{
			var movieInDb = _dbContext.Movies.SingleOrDefault(x => x.Id == id);

			if (movieInDb is null) return NotFound();

			return Ok(Mapper.Map<Movie, MovieDto>(movieInDb));
		}

		// POST: /api/Movies
		[HttpPost]
		public IHttpActionResult CreateMovie(MovieDto movieDto)
		{
			if (!ModelState.IsValid) return BadRequest();

			var movie = Mapper.Map<MovieDto, Movie>(movieDto);
			movie.DateAdded = DateTime.UtcNow;

			_dbContext.Movies.Add(movie);
			_dbContext.SaveChanges();

			movieDto.Id = movie.Id;
			return Created(new Uri($"{Request.RequestUri}/{movieDto.Id}"), movieDto);
		}

		// PUT: /api/Movies/:id
		[HttpPut]
		public IHttpActionResult UpdateMovie(int id, MovieDto movieDto)
		{
			if (!ModelState.IsValid) return BadRequest();

			var movieInDb = _dbContext.Movies.SingleOrDefault(m => m.Id == id);
			if (movieInDb is null) return NotFound();

			Mapper.Map(movieDto, movieInDb);
			_dbContext.SaveChanges();

			return Ok();
		}

		// DELETE: /api/Movies/:id
		[HttpDelete]
		public IHttpActionResult DeleteMovie(int id)
		{
			var movieInDb = _dbContext.Movies.SingleOrDefault(m => m.Id == id);

			if (movieInDb is null) return NotFound();

			_dbContext.Movies.Remove(movieInDb);
			_dbContext.SaveChanges();

			return Ok();
		}
	}
}