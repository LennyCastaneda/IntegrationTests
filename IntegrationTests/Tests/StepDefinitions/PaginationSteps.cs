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
			App.View.Home.NewsFeed.Paginator.SelectItemsPerPage(param);
		}

		[StepDefinition(@"the Pagination Next Page button is clicked")]
		public static void PaginationNextPage()
		{
			App.View.Home.NewsFeed.Paginator.NextPage();
		}

		[StepDefinition(@"the Pagination Previous Page button is clicked")]
		public static void PaginationPreviousPage()
		{
			App.View.Home.NewsFeed.Paginator.PreviousPage();
		}

		[StepDefinition(@"the Pagination Status should read '(.*)'")]
		public static void PaginationStatus(string param)
		{
			Assert.That(App.View.Home.NewsFeed.Paginator.PageStatus.Contains(param));
		}
	}
}
