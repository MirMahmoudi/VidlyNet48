using System.ComponentModel.DataAnnotations;

namespace VidlyNet48.Presentation.ViewModels.ManageViewModels
{
	public class AddPhoneNumberViewModel
	{
		[Required]
		[Phone]
		[Display(Name = "Phone Number")]
		public string Number { get; set; }
	}
}