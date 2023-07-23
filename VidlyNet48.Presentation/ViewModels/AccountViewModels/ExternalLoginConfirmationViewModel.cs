using System.ComponentModel.DataAnnotations;

namespace VidlyNet48.Presentation.ViewModels.AccountViewModels
{
	public class ExternalLoginConfirmationViewModel
	{
		[Required]
		[Display(Name = "Email")]
		public string Email { get; set; }

		[Required]
		[Display(Name = "Driving License")]
		public string DrivingLicense { get; set; }

		[Required]
		[Display(Name = "Phone Number")]
		[StringLength(50)]
		public string PhoneNumber { get; set; }
	}
}