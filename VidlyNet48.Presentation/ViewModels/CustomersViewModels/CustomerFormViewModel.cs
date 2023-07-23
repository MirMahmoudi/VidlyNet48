using System.Collections.Generic;
using VidlyNet48.Presentation.Models;

namespace VidlyNet48.Presentation.ViewModels.CustomersViewModels
{
	public class CustomerFormViewModel
	{
		public IEnumerable<MembershipType> MembershipTypes { get; set; }
		public Customer Customer { get; set; }

		public string Title
		{
			get
			{
				if(Customer !=  null && Customer.Id != 0)
					return "Edit Customer";
				return "New Customer";
			}
		}
	}
}