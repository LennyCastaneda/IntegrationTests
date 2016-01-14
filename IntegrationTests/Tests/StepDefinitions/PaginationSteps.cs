using NUnit.Framework;
using ReloadedFramework.Model.ViewObjects;
using ReloadedFramework.Tests;
using TechTalk.SpecFlow;

namespace IntegrationTests.Tests.StepDefinitions
{
	[Binding]
	public sealed class PaginationSteps : TestBase
	{
		[StepDefinition(@"the Pagination dropdown '(.*)' is selected")]
		public static void PaginationDropDown(string param)
		{
			Paginator.SelectItemsPerPage(_driver, param);
		}

		[StepDefinition(@"the Pagination Next Page button is clicked")]
		public static void PaginationNextPage()
		{
			Paginator.SelectNextPage(_driver);
		}

		[StepDefinition(@"the Pagination Previous Page button is clicked")]
		public static void PaginationPreviousPage()
		{
			Paginator.SelectPreviousPage(_driver);
		}

		[StepDefinition(@"the Pagination Status should read '(.*)'")]
		public static void PaginationStatus(string param)
		{
			Assert.That(Paginator.GetPageStatus(_driver).Contains(param));
		}
	}
}
