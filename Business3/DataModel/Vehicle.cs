using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Business3.DataModel
{
	public class Vehicle
	{
		[Key][Required]
		public int VehicleId { get; set; }
		[MaxLength(50)]
		public string ModelName { get; set; }
		[MaxLength(50)]
		public string V_color { get; set; }
		public long VIN { get; set; }

		[DataType(DataType.Date)]
		public DateTime? DoM { get; set; }
		[DataType(DataType.DateTime)]
		public DateTime? RegDate { get; set; }
		public double Price { get; set; }

	}
}
