using System;
using System.Linq;
using System.Data.Entity;
using System.Web.Http;
using AutoMapper;
using VidlyNet48.Presentation.Dto;
using VidlyNet48.Presentation.Models;
using VidlyNet48.Presentation.Models.IdentityModels;

namespace VidlyNet48.Presentation.Controllers.Api
{
	public class CustomersController : ApiController
	{
		private readonly ApplicationDbContext _dbContext;

		public CustomersController()
		{
			_dbContext = new ApplicationDbContext();
		}

		// GET: /api/Customers
		public IHttpActionResult GetCustomers()
		{
			return Ok( _dbContext.Customers
				.Include(c => c.MembershipType)
				.ToList()
				.Select(Mapper.Map<Customer, CustomerDto>) );
		}

		// GET: /api/Customers/:id
		public IHttpActionResult GetCustomer(int id)
		{
			var customerInDb = _dbContext.Customers.SingleOrDefault(c => c.Id == id);

			if (customerInDb is null) return NotFound();

			return Ok(Mapper.Map<Customer, CustomerDto>(customerInDb));
		}

		// POST: /api/Customers
		[HttpPost]
		public IHttpActionResult CreateCustomer(CustomerDto customerDto)
		{
			if ( !ModelState.IsValid || customerDto.MembershipTypeId <= 0 ) return BadRequest();

			var customer = Mapper.Map<CustomerDto, Customer>(customerDto);
			_dbContext.Customers.Add(customer);
			_dbContext.SaveChanges();

			customerDto.Id = customer.Id;
			return Created(new Uri($"{Request.RequestUri}/{customer.Id}"), customerDto);
		}

		// PUT: /api/Customers/:id
		[HttpPut]
		public IHttpActionResult PutCustomer(int id, CustomerDto customerDto)
		{
			if (!ModelState.IsValid) return BadRequest();

			var customerInDb = _dbContext.Customers.SingleOrDefault(c => c.Id == id);
			if (customerInDb is null) return NotFound();

			Mapper.Map(customerDto, customerInDb);
			_dbContext.SaveChanges();

			return Ok();
		}

		// DELETE: /api/Customers/:id
		[HttpDelete]
		public IHttpActionResult DeleteCustomer(int id)
		{
			var customerInDb = _dbContext.Customers.SingleOrDefault(c => c.Id == id);

			if (customerInDb is null) return NotFound();

			_dbContext.Customers.Remove(customerInDb);
			_dbContext.SaveChanges();
			return Ok();
		}
	}
}
