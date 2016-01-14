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
			Assert.That(View.SystemMessages != null);
		}

		[StepDefinition(@"the SystemMessages Message number '(.*)' is clicked")]
		public static void ClickSystemMessagesItem(int index)
		{
			Feed.ClickMessage(View.SystemMessages, index);
		}

		[StepDefinition(@"the SystemMessages Message number '(.*)' is expanded")]
		public static void SystemMessagesItemExpanded(int index)
		{
			Assert.That(Feed.MessageExpanded(View.SystemMessages, index));
		}

		[StepDefinition(@"the SystemMessages Message number '(.*)' is not expanded")]
		public static void SystemMessagesItemNotExpanded(int index)
		{
			Assert.That(!Feed.MessageExpanded(View.SystemMessages, index));
		}

		[StepDefinition(@"the NewsFeed is visible")]
		public static void CheckNewsFeedExists()
		{
			Assert.That(View.NewsFeed != null);
		}

		[StepDefinition(@"the NewsFeed Message number '(.*)' is clicked")]
		public static void ClickNewsFeedItem(int index)
		{
			Feed.ClickMessage(View.NewsFeed, index);
		}

		[StepDefinition(@"the NewsFeed Message number '(.*)' is expanded")]
		public static void NewsFeedItemExpanded(int index)
		{
			Assert.That(Feed.MessageExpanded(View.NewsFeed, index));
		}

		[StepDefinition(@"the NewsFeed Message number '(.*)' is not expanded")]
		public static void NewsFeedItemNotExpanded(int index)
		{
			Assert.That(!Feed.MessageExpanded(View.NewsFeed, index));
		}

		[StepDefinition(@"the NewsFeed Options is clicked")]
		public static void NewsFeedOptionsClicked()
		{
			Feed.ClickOptions(View.NewsFeed);
		}

		[StepDefinition(@"the NewsFeed Option: '(.*)' is clicked")]
		public static void NewsFeedOptionsItemClicked(string param)
		{
			Feed.SelectOption(View.NewsFeed, param);
		}
	}
}
