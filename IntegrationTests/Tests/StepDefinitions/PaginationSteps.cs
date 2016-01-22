using NUnit.Framework;
using ReloadedFramework.Tests;
using TechTalk.SpecFlow;

namespace IntegrationTests.Tests.StepDefinitions
{
	[Binding]
	public sealed class PaginationSteps : TestBase
	{
		[When(@"the Pagination dropdown '(.*)' is selected")]
		public static void Pagination_DropDown(string itemCount)
		{
			App.View.Home.NewsFeed.Paginator.SelectItemsPerPage(itemCount);
		}

		[When(@"the Pagination Next Page button is clicked")]
		public static void Pagination_NextPage()
		{
			App.View.Home.NewsFeed.Paginator.NextPage();
		}

		[When(@"the Pagination Previous Page button is clicked")]
		public static void Pagination_PreviousPage()
		{
			App.View.Home.NewsFeed.Paginator.PreviousPage();
		}

		[Then(@"the Pagination Status should read '(.*)'")]
		public static void Pagination_Status(string status)
		{
			Assert.That(App.View.Home.NewsFeed.Paginator.PageStatus.Contains(status));
		}
	}
}
