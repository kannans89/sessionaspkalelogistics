using MVCWithEFApp.Domain;
using MVCWithEFApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCWithEFAppTests
{
	public class OrganizationMockRepository : IOrganizationRepostiory
	{
		public void AddOrganization(Organization organisation)
		{
			throw new NotImplementedException();
		}

		public Organization GetOrganizationById(int id)
		{
			throw new NotImplementedException();
		}

		public List<Organization> GetOrganizations()
		{
			return new List<Organization>() ;
		}

		public void Remove(int organizaitonId)
		{
			throw new NotImplementedException();
		}

		public void UpdateOrganization(Organization newOrg)
		{
			throw new NotImplementedException();
		}
	}
}
