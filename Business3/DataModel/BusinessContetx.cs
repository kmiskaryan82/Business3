namespace Business3.DataModel
{
	using System;
	using System.Data.Entity;
	using System.Linq;

	public class BusinessContetx : DbContext
	{

		public BusinessContetx()
			: base("name=BusinessContetx")
		{
		}

		public DbSet<Customer> Customers { get; set; }
		public DbSet<Vehicle> Vehicles { get; set; }
	}
	
}