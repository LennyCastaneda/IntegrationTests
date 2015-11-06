using System;
using NUnit.Framework;
using ReloadedFramework;
using ReloadedFramework.Model;
using TechTalk.SpecFlow;

namespace IntegrationTests.Tests
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
		}

		[StepDefinition(@"the Browser title is '(.*)'")]
		[StepDefinition(@"the Browser title should be '(.*)'")]
		public static void ThenTheTitleShouldBe(string title)
		{

			Assert.That(Page.Title == title);
		}

		[StepDefinition(@"wait")]
		public static void Pause()
		{
			Page.Wait();
		}
	}
}
