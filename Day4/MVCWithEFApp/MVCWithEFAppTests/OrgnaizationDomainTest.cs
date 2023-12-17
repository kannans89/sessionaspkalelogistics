using MVCWithEFApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCWithEFAppTests
{
	[TestClass]
	public class OrgnaizationDomainTest
	{
		[TestMethod]

		public void ToStringShouldReturnCommaSepratedValues() { 
		
			//Object under test
			//Arrange
			Organization organization = new Organization();
			organization.Id = 101;
			organization.Name = "Koenig";
			string expectedValue = "Id=101,Name=Koenig";

			//Act
			string atctaulValue=organization.ToString();

			//Assert
			Assert.AreEqual(expectedValue, atctaulValue);
		}

	}
}
