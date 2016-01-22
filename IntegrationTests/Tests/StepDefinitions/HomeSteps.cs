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
		[When(@"the SystemMessages Message number '(.*)' is clicked")]
		public static void Home_SystemMessage_Click(int index)
		{
			App.View.Home.SystemMessages.ClickMessage(index);
		}

		[When(@"the NewsFeed Message number '(.*)' is clicked")]
		public static void Home_NewsFeedItem_Click(int index)
		{
			App.View.Home.NewsFeed.ClickMessage(index);
		}

		[When(@"the NewsFeed Options is clicked")]
		public static void Home_NewsFeedFilter_Click()
		{
			App.View.Home.NewsFeed.ClickOptions();
		}

		[When(@"the NewsFeed Option: '(.*)' is clicked")]
		public static void Home_NewsFeedFilterItem_Click(string option)
		{
			App.View.Home.NewsFeed.SelectOption(option);
		}

		[Then(@"the NewsFeed Message number '(.*)' is expanded")]
		public static void Home_NewsFeedItem_Expanded(int index)
		{
			Assert.That(App.View.Home.NewsFeed.MessageExpanded(index));
		}

		[Then(@"the NewsFeed Message number '(.*)' is not expanded")]
		public static void Home_NewsFeedItem_NotExpanded(int index)
		{
			Assert.That(!App.View.Home.NewsFeed.MessageExpanded(index));
		}

		[Then(@"the SystemMessages Message number '(.*)' is expanded")]
		public static void Home_SystemMessageItem_Expanded(int index)
		{
			Assert.That(App.View.Home.SystemMessages.MessageExpanded(index));
		}

		[Then(@"the SystemMessages Message number '(.*)' is not expanded")]
		public static void Home_SystemMessageItem_NotExpanded(int index)
		{
			Assert.That(!App.View.Home.SystemMessages.MessageExpanded(index));
		}

		[Then(@"the NewsFeed is visible")]
		public static void Home_NewsFeed_IsVisible()
		{
			Assert.That(App.View.Home.NewsFeed.IsVisible);
		}

		[Then(@"the SystemMessages feed is visible")]
		public static void Home_SystemMessages_IsVisible()
		{
			Assert.That(App.View.Home.SystemMessages.IsVisible);
		}
	}
}
