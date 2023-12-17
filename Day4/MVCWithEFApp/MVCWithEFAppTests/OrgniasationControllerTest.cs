using Microsoft.AspNetCore.Mvc;
using MVCWithEFApp.Controllers;
using MVCWithEFApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCWithEFAppTests
{
	[TestClass]
	public class OrgniasationControllerTest
	{
		[TestMethod]
		public void IndexActionShouldNotReturnNullValue() {

			//Arrange
			OrganisationController controller = new OrganisationController(new OrganizationMockRepository());
			ViewResult actual = controller.Index() as ViewResult;
			Assert.IsNotNull(actual);
			Assert.IsNotNull(actual.Model);
			 var model =(List<Organization>)actual.Model;
			Assert.IsInstanceOfType(model,typeof(List<Organization>));
		}
		[TestMethod]
		public void IndexActionModelShouldBeAList()
		{

			//Arrange
			OrganisationController controller = new OrganisationController(new OrganizationMockRepository());
			ViewResult actual = controller.Index() as ViewResult;
			Assert.IsNotNull(actual);
			Assert.IsNotNull(actual.Model);
			var model = (List<Organization>)actual.Model;
			Assert.IsInstanceOfType(model, typeof(List<Organization>));
		}


	}
}
