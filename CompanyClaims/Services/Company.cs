using CompanyClaims.Dto;
using CompanyClaims.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyClaims.Services
{
	public class Company : ICompanyData
	{
		public Companies GetCompany(int id)
		{
			return CompanyData.companyList.Where(x => x.ID == id).FirstOrDefault();
		}

		public IEnumerable<ClaimsInfo> GetClaim(int id)
		{
			return CompanyData.claimList.Where(y => y.CompanyId == id).Select(x => new ClaimsInfo(){
				UCR = x.UCR,
				 Name = CompanyData.companyList.Where(y => y.ID == id).Select(y => y.Name).First(),
				  ClaimDate = x.ClaimDate,
				   CompanyId = x.CompanyId
			});
		}

		public Claims GetClaimData(string ucr)
		{
			return CompanyData.claimList.FirstOrDefault(x => x.UCR == ucr);
		}

		public void UpdateClaim(Claims claim)
		{
			var idx = CompanyData.claimList.FindIndex(x => x.UCR == claim.UCR);
			CompanyData.claimList[idx] = claim;
		}
	}
}
