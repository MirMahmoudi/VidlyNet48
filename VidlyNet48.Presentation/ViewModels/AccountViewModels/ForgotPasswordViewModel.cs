using System.ComponentModel.DataAnnotations;

namespace VidlyNet48.Presentation.ViewModels.AccountViewModels
{
	public class ForgotPasswordViewModel
	{
		[Required]
		[EmailAddress]
		[Display(Name = "Email")]
		public string Email { get; set; }
	}
}
