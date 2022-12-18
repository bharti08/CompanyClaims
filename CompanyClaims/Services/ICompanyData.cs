using CompanyClaims.Dto;
using CompanyClaims.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyClaims.Services
{
	public interface ICompanyData
	{
		Companies GetCompany(int id);

		IEnumerable<ClaimsInfo> GetClaim(int id);
		Claims GetClaimData(string ucr);

		void UpdateClaim(Claims claim);

	}

	

	
}
