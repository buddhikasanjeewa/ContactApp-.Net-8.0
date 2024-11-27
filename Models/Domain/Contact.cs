namespace Angaular17WebApi1.Models.Domain
{
	public class Contact
	{

        public Guid Id { get; set; }
		public required string ContactCode { get; set; }
		public required string Name { get; set; }
		public  string? Email { get; set; }

		public required string Phone { get; set; }

		public bool Favourite { get; set; }

	}
}
