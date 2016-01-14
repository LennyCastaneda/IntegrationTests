using NUnit.Framework;
using ReloadedFramework.Model.ViewObjects;
using ReloadedFramework.Model.ViewObjects.ViewTypes;
using ReloadedFramework.Tests;
using TechTalk.SpecFlow;

namespace IntegrationTests.Tests.StepDefinitions
{
	[Binding]
	public sealed class HomeSteps : TestBase
	{
		[StepDefinition(@"the SystemMessages feed is visible")]
		public static void CheckSystemMessagesExists()
		{
			Assert.That(App.View.Home.SystemMessages.IsVisible);
		}

		[StepDefinition(@"the SystemMessages Message number '(.*)' is clicked")]
		public static void ClickSystemMessagesItem(int index)
		{
			App.View.Home.SystemMessages.ClickMessage(index);
		}

		[StepDefinition(@"the SystemMessages Message number '(.*)' is expanded")]
		public static void SystemMessagesItemExpanded(int index)
		{
			Assert.That(App.View.Home.SystemMessages.MessageExpanded(index));
		}

		[StepDefinition(@"the SystemMessages Message number '(.*)' is not expanded")]
		public static void SystemMessagesItemNotExpanded(int index)
		{
			Assert.That(!App.View.Home.SystemMessages.MessageExpanded(index));
		}

		[StepDefinition(@"the NewsFeed is visible")]
		public static void CheckNewsFeedExists()
		{
			Assert.That(App.View.Home.NewsFeed.IsVisible);
		}

		[StepDefinition(@"the NewsFeed Message number '(.*)' is clicked")]
		public static void ClickNewsFeedItem(int index)
		{
			App.View.Home.NewsFeed.ClickMessage(index);
		}

		[StepDefinition(@"the NewsFeed Message number '(.*)' is expanded")]
		public static void NewsFeedItemExpanded(int index)
		{
			Assert.That(App.View.Home.NewsFeed.MessageExpanded(index));
		}

		[StepDefinition(@"the NewsFeed Message number '(.*)' is not expanded")]
		public static void NewsFeedItemNotExpanded(int index)
		{
			Assert.That(!App.View.Home.NewsFeed.MessageExpanded(index));
		}

		[StepDefinition(@"the NewsFeed Options is clicked")]
		public static void NewsFeedOptionsClicked()
		{
			App.View.Home.NewsFeed.ClickOptions();
		}

		[StepDefinition(@"the NewsFeed Option: '(.*)' is clicked")]
		public static void NewsFeedOptionsItemClicked(string option)
		{
			App.View.Home.NewsFeed.SelectOption(option);
		}
	}
}
