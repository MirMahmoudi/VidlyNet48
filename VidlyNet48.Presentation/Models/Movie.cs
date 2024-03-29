﻿using System;
using System.ComponentModel.DataAnnotations;

namespace VidlyNet48.Presentation.Models
{
	public class Movie
	{
		public int Id { get; set; }
		
		[Required, StringLength(255)]
		public string Name { get; set; }

		public Genre Genre { get; set; }

		[Required, Display(Name = "Genre")]
		public int GenreId { get; set; }

		public DateTime DateAdded { get; set; }


		[Display(Name = "Release Date")]
		public DateTime ReleaseDate { get; set; }

		[Display(Name = "Number in stock")]
		[Range(1, 20, ErrorMessage = "Should be between 1 and 20!")]
		public int NumberInStuck { get; set; }

		public int NumberAvailable { get; set; }
	}
}