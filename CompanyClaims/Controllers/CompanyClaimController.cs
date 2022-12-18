using CompanyClaims.Dto;
using CompanyClaims.Entities;
using CompanyClaims.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyClaims.Controllers
{
	[Route("api/CompanyClaim")]
	[ApiController]
	public class CompanyClaimController :ControllerBase
	{
		private readonly ICompanyData compData;
		
		

		public CompanyClaimController(ICompanyData comp)
		{
			this.compData = comp;
			
			
		}
		[Route("[action]/{id}")]
		[HttpGet("{id }")]
		public ActionResult<Companies> GetCompany(int id)
		{

			try
			{
				var cData = compData.GetCompany(id);
				return cData;
			}
			catch(Exception e)
			{
				return BadRequest();
			}
		}

		[Route("[action]/{id}")]
		[HttpGet("{id}")]
		public IEnumerable<ClaimsInfo> GetClaim(int id)
		{
			var cData = compData.GetClaim(id);
			return cData;
		}

		[Route("[action]/{ucr}")]
		[HttpGet("{ucr}")]
		public ActionResult<Claims> GetClaimData(string ucr)
		{
			try
			{
				var claim = compData.GetClaimData(ucr);
				return claim;
			}
			catch(Exception e)
			{
				return BadRequest();
			}
		}

		[HttpPut("{ucr}")]
		public ActionResult UpdateClaim(string ucr, Claims claim)
		{
			try
			{
				var data = compData.GetClaimData(ucr);
				if (data == null)
					return NotFound();

				Claims updatedClaim = new Claims
				{
					UCR = claim.UCR,
					ClaimDate = claim.ClaimDate,
					Closed = claim.Closed,
					CompanyId = claim.CompanyId,
					IncuredLoss = claim.IncuredLoss,
					LossDate = claim.LossDate,
					AssuredName = claim.AssuredName
				};
				compData.UpdateClaim(updatedClaim);
				return Ok();
			}
			catch(Exception e)
			{
				return BadRequest();
			}
	}

	}
}
