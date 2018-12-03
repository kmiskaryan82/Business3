using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business3.DataModel
{
	public class Customer
	{
		[Required][Key]
		public int Id { get; set; }
		[MaxLength(50)]
		public string FirstName { get; set; }
		[MaxLength(50)]
		public string LastName { get; set; }
		
		public string DoB { get; set; }

		public string RegDate { get; set; }
		[Required]
		public long Phone { get; set; }
		[MaxLength(20)]
		public string Email { get; set; }
		[MaxLength(50)]
		public string Vehicle { get; set; }


	}
}
