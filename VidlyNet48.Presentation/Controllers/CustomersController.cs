using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using VidlyNet48.Presentation.Models;

namespace VidlyNet48.Presentation.Controllers
{
	public class CustomersController : Controller
	{
		// GET: Customers
		public ActionResult Index()
		{
			var customers = GetCustomers();

			return View(customers);
		}

		// GET: Customers/Details/Id
		public ActionResult Details(int id)
		{
			var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

			if (customer is null) return HttpNotFound();
			return View(customer);
		}

		private IEnumerable<Customer> GetCustomers()
		{
			return new List<Customer>
			{
				new Customer { Id = 1, Name = "John Smith" },
				new Customer { Id = 2, Name = "Mary Williams" }
			};
		}
	}
}