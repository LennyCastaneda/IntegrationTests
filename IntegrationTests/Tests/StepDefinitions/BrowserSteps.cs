using NUnit.Framework;
using ReloadedFramework.Tests;
using TechTalk.SpecFlow;

namespace IntegrationTests.Tests.StepDefinitions
{
	[Binding]
	public class BrowserSteps : TestBase
	{
		[Given(@"the Browser '(.*)'")]
		public static void Browser_Init(string browser)
		{
			Init(browser);
			Browser_GoTo("http://www.bing.com/");
		}

		[Given(@"the Browser exists")]
		public static void Browser_Check()
		{
			Browser_GoTo("http://www.bing.com/");
		}

		[When(@"the Browser is pointed to '(.*)'")]
		public static void Browser_GoTo(string url)
		{
			Page.GoTo(url);
			Page.RemoveDelay();
		}

		[When(@"the keyboard key '(.*)' is pressed")]
		[When(@"the Browser is sent the keys '(.*)'")]
		public static void Browser_PressKeys(string keys)
		{
			Page.SendKeys(keys);
		}

		[StepDefinition(@"wait")]
		public static void Browser_Wait()
		{
			Page.Wait();
		}

		[Then(@"the Browser title is '(.*)'")]
		[Then(@"the Browser title should be '(.*)'")]
		public static void Browser_Title(string title)
		{
			Assert.That(Page.Title == title);
		}
	}
}
