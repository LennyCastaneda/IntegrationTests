using TechTalk.SpecFlow;
using ReloadedFramework;
using NUnit.Framework;
using ReloadedFramework.Model;

namespace IntegrationTests.Tests
{
	[Binding]
    public class OpenHomePageSteps : TestBase
	{
		[When(@"it points to '(.*)'")]
		public void WhenItPointsTo(string url)
		{
			Page.GoTo(url);
			Assert.That(Page.Url.Contains(url));
		}

		[Then(@"the title should be '(.*)'")]
        public void ThenTheTitleShouldBe(string title)
        {
			Assert.That(Page.Title == title);
		}
	}
}
