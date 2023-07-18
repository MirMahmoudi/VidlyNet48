using System.ComponentModel.DataAnnotations;

namespace VidlyNet48.Presentation.Dto
{
	public class MembershipTypeDto
	{
		public int Id { get; set; }

		[Required]
		public string Name { get; set; }
		public byte DiscountRate { get; set; }
	}
}