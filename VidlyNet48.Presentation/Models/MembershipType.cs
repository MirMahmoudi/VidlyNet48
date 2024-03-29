﻿using System.ComponentModel.DataAnnotations;

namespace VidlyNet48.Presentation.Models
{
	public class MembershipType
	{
		public int Id { get; set; }

		[Required]
		public string Name { get; set; }
		public short SignUpFee { get; set; }
		public byte DurationInMonth { get; set; }
		public byte DiscountRate { get; set; }

		public static readonly byte Unknown = 0;
		public static readonly byte PayAsYouGo = 1;
	}
}