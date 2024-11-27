using Angaular17WebApi1.Data;
using Angaular17WebApi1.Models;
using Angaular17WebApi1.Models.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Angaular17WebApi1.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ContactsController : ControllerBase
	{
		private readonly ContactlyDbContext dbContext;

		public ContactsController(ContactlyDbContext dbContext)
        {
			this.dbContext = dbContext;
		}
		[Authorize]
		[HttpGet]
		public IActionResult GetAllContacts()
		{
			var contacts = dbContext.Contacts.ToList();
			return Ok(contacts);
		}
		[HttpPost]
		public IActionResult AddContacts(AddContactRequestDTO  request)
		{
			var domainModelContact = new Contact
			{
				Id = Guid.NewGuid(),
			 ContactCode =request.ContactCode,
				Name = request.Name,
				Email = request.Email,
				Phone = request.Phone,
				Favourite = request.Favourite
			};
			dbContext.Contacts.Add(domainModelContact);
			dbContext.SaveChanges();
			return Ok(domainModelContact);
		}

		[HttpDelete]
		[Route("{id:guid}")]
		public IActionResult DeleteContacts(Guid id)
		{
			var contact=dbContext.Contacts.Find(id);
			if (contact is not null)
			{
				dbContext.Contacts.Remove(contact);
				dbContext.SaveChanges();
			}
			return Ok();
		}
	
	}
}
