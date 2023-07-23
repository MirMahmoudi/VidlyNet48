using System.ComponentModel.DataAnnotations;

namespace VidlyNet48.Presentation.ViewModels.AccountViewModels
{
	public class ForgotViewModel
	{
		[Required]
		[Display(Name = "Email")]
		public string Email { get; set; }
	}
}