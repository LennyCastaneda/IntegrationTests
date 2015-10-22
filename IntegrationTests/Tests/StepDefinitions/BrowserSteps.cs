using NUnit.Framework;
using ReloadedFramework;
using ReloadedFramework.Model;
using TechTalk.SpecFlow;

namespace IntegrationTests.Tests
{
	[Binding]
	public class BrowserSteps : TestBase
	{
		[StepDefinition(@"a browser")]
        public static void GivenABrowser()
		{
			Assert.NotNull(Page);
			WhenItPointsTo("http://www.bing.com/");
		}

		[StepDefinition(@"the browser points to '(.*)'")]
		public static void WhenItPointsTo(string url)
		{
			Page.GoTo(url);
			Assert.That(Page.Url.Contains(url));
		}

		[StepDefinition(@"the title should be '(.*)'")]
		public static void ThenTheTitleShouldBe(string title)
		{
			Assert.That(Page.Title == title);
		}
	}
}
