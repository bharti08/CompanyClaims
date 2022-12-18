using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyClaims.Entities
{
	public class Claims
	{
		public string UCR { get; set; }
		public int CompanyId { get; set; }
		public DateTime ClaimDate { get; set; }
		public DateTime LossDate { get; set; }
		public string AssuredName { get; set; }
		public decimal IncuredLoss { get; set; }
		public bool Closed { get; set; }

		public int  ClaimDays => Convert.ToInt32(( DateTime.Now - ClaimDate).TotalDays);
	
		
	}
}
