using NUnit.Framework;
using ReloadedFramework.Tests;
using TechTalk.SpecFlow;

namespace IntegrationTests.Tests.StepDefinitions
{
	[Binding]
	public sealed class PaginationSteps : TestBase
	{
		[When(@"the NewsFeed Pagination dropdown '(.*)' is selected")]
		public static void Pagination_DropDown(string itemCount)
		{
			App.View.Home.NewsFeed.Paginator.SelectItemsPerPage(itemCount);
		}

		[When(@"the NewsFeed Pagination Next Page button is clicked")]
		public static void Pagination_NextPage()
		{
			App.View.Home.NewsFeed.Paginator.NextPage();
		}

		[When(@"the NewsFeed Pagination Previous Page button is clicked")]
		public static void Pagination_PreviousPage()
		{
			App.View.Home.NewsFeed.Paginator.PreviousPage();
		}

		[Then(@"the NewsFeed Pagination Status should read '(.*)'")]
		public static void Pagination_Status(string status)
		{
			Assert.That(App.View.Home.NewsFeed.Paginator.PageStatus.Contains(status));
		}
	}
}
