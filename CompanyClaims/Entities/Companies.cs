using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyClaims.Entities
{
	public class Companies
	{
		
		public int ID { get; set; }
		public string Name { get; set; }
		
		public string Address1 { get; set; }
	
		public string Address2 { get; set; }
		
		public string Address3 { get; set; }
		
		public string Postcode { get; set; }
		
		public string Country { get; set; }
		public bool Active { get; set; }
		
		public DateTime InsauranceEndDate { get; set; }

		public bool ActiveInsaurance => (InsauranceEndDate > DateTime.Now);
	}
}
