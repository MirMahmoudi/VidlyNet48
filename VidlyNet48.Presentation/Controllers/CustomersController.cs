using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using VidlyNet48.Presentation.Models;

namespace VidlyNet48.Presentation.Controllers
{
	public class CustomersController : Controller
	{
		private readonly ApplicationDbContext _context;

		public CustomersController()
		{
			_context = new ApplicationDbContext();
		}

		protected override void Dispose(bool disposing)
		{
			_context.Dispose();
		}

		// GET: Customers
		public ActionResult Index()
		{
			var customers = _context.Customers
				.Include(c => c.MembershipType);

			return View(customers);
		}

		// GET: Customers/Details/Id
		public ActionResult Details(int id)
		{
			var customer = _context.Customers
				.Include(c => c.MembershipType)
				.SingleOrDefault(c => c.Id == id);

			if (customer is null) return HttpNotFound();
			return View(customer);
		}
	}
}