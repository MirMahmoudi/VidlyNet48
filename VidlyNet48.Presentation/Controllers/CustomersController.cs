using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using VidlyNet48.Presentation.Models;
using VidlyNet48.Presentation.ViewModels;

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
			// var customers = _context.Customers
			// 	.Include(c => c.MembershipType);

			return View();
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

		// GET: Cutomers/New
		public ActionResult New()
		{
			var membershipTypes = _context.MembershipTypes.ToList();
			var viewModel = new CustomerFormViewModel()
			{
				Customer = new Customer(),
				MembershipTypes = membershipTypes
			};
			return View("CustomerForm", viewModel);
		}

		// POST: Customer/Save
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Save(Customer customer)
		{
			if (ModelState.IsValid)
			{
				if (customer.Id == 0)
					_context.Customers.Add(customer);
				else
				{
					var customerInDb = _context.Customers.Single(c => c.Id == customer.Id);
					customerInDb.Name = customer.Name;
					customerInDb.Birthdate = customer.Birthdate;
					customerInDb.MembershipTypeId = customer.MembershipTypeId;
					customerInDb.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;
				}

				_context.SaveChanges();
				return RedirectToAction("Index", "Customers");
			}

			var viewModel = new CustomerFormViewModel
			{
				Customer = customer,
				MembershipTypes = _context.MembershipTypes.ToList()
			};
			return View("CustomerForm", viewModel);
		}

		// GET: Customer/Edit/:id
		public ActionResult Edit(int id)
		{
			var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
			if (customer is null) return HttpNotFound();

			var viewModel = new CustomerFormViewModel()
			{
				Customer = customer,
				MembershipTypes = _context.MembershipTypes.ToList()
			};

			return View("CustomerForm", viewModel);
		}
	}
}