using CompanyClaims.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyClaims.Services
{
	public class CompanyData
	{
		public static List<Companies> companyList = new List<Companies>
		{
			new Companies{ID=1, Name="Bharti Pvt Ltd", Address1="Charlswille", Address2="Isleworth", Address3="",
				Postcode="TW7 7UC", Country="London", Active=true, InsauranceEndDate=new DateTime(2022,12,16)},
			new Companies{ID=2, Name="Bharti Insaurance", Address1="Leo Yard", Address2="Greater London", Address3="",
				Postcode="TW7 7UV", Country="London", Active=false, InsauranceEndDate=new DateTime(2022,12,10)},
			new Companies{ID=3, Name="MarkleInsuarance", Address1="32B", Address2="Stanford", Address3="",
				Postcode="TW7 6TY", Country="London", Active=true, InsauranceEndDate=new DateTime(2022,12,22)},

		};

		public static List<Claims> claimList = new List<Claims>
		{
			new Claims{UCR="wer", CompanyId=1, AssuredName="Bharti Pvt Ltd Claims", ClaimDate=new DateTime(2022,11,10),
				IncuredLoss=20, LossDate=new DateTime(2022,11,21), Closed=false},
			new Claims{UCR="qas", CompanyId=1, AssuredName="Bharti Pvt Ltd Claims Reissued", ClaimDate=new DateTime(2022,11,20),
				IncuredLoss=200, LossDate=new DateTime(2022,11,25), Closed=false},
			new Claims{UCR="rty", CompanyId=2, AssuredName="Bharti Insaurance Claims", ClaimDate=new DateTime(2022,11,21),
				IncuredLoss=0, LossDate=new DateTime(), Closed=true},

		};

	}
}
