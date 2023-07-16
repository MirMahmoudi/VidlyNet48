using System;
using System.ComponentModel.DataAnnotations;

namespace VidlyNet48.Presentation.Dto
{
	public class MovieDto
	{
		public int Id { get; set; }

		[Required, StringLength(255)]
		public string Name { get; set; }

		[Required]
		public int GenreId { get; set; }

		public DateTime? DateAdded { get; set; }

		public DateTime ReleaseDate { get; set; }

		[Range(1, 20)]
		public int NumberInStuck { get; set; }
	}
}