using NUnit.Framework;
using ReloadedFramework.Tests;
using TechTalk.SpecFlow;

namespace IntegrationTests.Tests.StepDefinitions
{
	[Binding]
	public class BrowserSteps : TestBase
	{
		[StepDefinition(@"the Browser '(.*)'")]
		public static void GivenABrowser(string browser)
		{
			Init(browser);
			Assert.NotNull(Page);
			WhenItPointsTo("http://www.bing.com/");
		}

		[StepDefinition(@"the Browser exists")]
		public static void GivenABrowser()
		{
			Assert.NotNull(Page);
			WhenItPointsTo("http://www.bing.com/");
		}

		[StepDefinition(@"the Browser is pointed to '(.*)'")]
		public static void WhenItPointsTo(string url)
		{
			Page.GoTo(url);
			Assert.That(Page.Url.Contains(url));
			Page.RemoveDelay();
		}

		[StepDefinition(@"the Browser title is '(.*)'")]
		[StepDefinition(@"the Browser title should be '(.*)'")]
		public static void ThenTheTitleShouldBe(string title)
		{
			Assert.That(Page.Title == title);
		}

		[StepDefinition(@"the keyboard key '(.*)' is pressed")]
		[StepDefinition(@"the Browser is sent the keys '(.*)'")]
		public static void PressKeys(string keys)
		{
			Assert.DoesNotThrow(() =>
			{
				Page.SendKeys(keys);
			});
		}

		[StepDefinition(@"wait")]
		public static void Pause()
		{
			Page.Wait();
		}
	}
}
