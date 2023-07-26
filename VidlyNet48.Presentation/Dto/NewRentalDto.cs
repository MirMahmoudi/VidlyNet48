using System.Collections.Generic;

namespace VidlyNet48.Presentation.Dto
{
	public class NewRentalDto
	{
		public int CustomerId { get; set; }
		public List<int> MovieIds { get; set; }
	}
}