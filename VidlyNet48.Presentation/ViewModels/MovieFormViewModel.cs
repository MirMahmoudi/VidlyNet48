using System.Collections.Generic;
using VidlyNet48.Presentation.Models;

namespace VidlyNet48.Presentation.ViewModels
{
	public class MovieFormViewModel
	{
		public IEnumerable<Genre> Genres { get; set; }
		public Movie Movie { get; set; }

		public string Title
		{
			get
			{
				if (Movie != null && Movie.Id != 0)
					return "Edit Movie";
				return "New Movie";
			}
		}
	}
}