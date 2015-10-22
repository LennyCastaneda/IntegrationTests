using NUnit.Framework;
using ReloadedFramework;
using ReloadedFramework.Model;
using TechTalk.SpecFlow;

namespace IntegrationTests.Tests
{
	[Binding]
	public class StepDefinitions : TestBase
	{
		[Given(@"a browser")]
		public void GivenScenario()
		{
			Assert.NotNull(Page);
			WhenItPointsTo("http://www.bing.com/");
		}

		[When(@"the browser points to '(.*)'")]
		public void WhenItPointsTo(string url)
		{
			Page.GoTo(url);
			Assert.That(Page.Url.Contains(url));
		}
	}
}
