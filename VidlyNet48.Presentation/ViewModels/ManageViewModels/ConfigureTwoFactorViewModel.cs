using System.Collections.Generic;

namespace VidlyNet48.Presentation.ViewModels.ManageViewModels
{
	public class ConfigureTwoFactorViewModel
	{
		public string SelectedProvider { get; set; }
		public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
	}
}