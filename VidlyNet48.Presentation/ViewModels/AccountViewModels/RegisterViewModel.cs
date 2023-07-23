using System.ComponentModel.DataAnnotations;

namespace VidlyNet48.Presentation.ViewModels.AccountViewModels
{
	public class RegisterViewModel
	{
		[Required]
		[EmailAddress]
		[Display(Name = "Email")]
		public string Email { get; set; }

		[Required]
		[StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
		[DataType(DataType.Password)]
		[Display(Name = "Password")]
		public string Password { get; set; }

		[DataType(DataType.Password)]
		[Display(Name = "Confirm password")]
		[Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
		public string ConfirmPassword { get; set; }

		[Required]
		[Display(Name = "Driving License")]
		[StringLength(255)]
		public string DrivingLicense { get; set; }

		[Required]
		[Display(Name = "Phone Number")]
		[StringLength(50)]
		public string PhoneNumber { get; set; }
	}
}