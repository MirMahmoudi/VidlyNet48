using System.ComponentModel.DataAnnotations;
using System;

namespace VidlyNet48.Presentation.Dto
{
	public class CustomerDto
	{
		public int Id { get; set; }

		[Required, StringLength(255)]
		public string Name { get; set; }

		public bool IsSubscribedToNewsletter { get; set; }

		public int MembershipTypeId { get; set; }

		public MembershipTypeDto MembershipType { get; set; }

		// [Min18YearsIfMember]
		public DateTime? Birthdate { get; set; }
	}
}