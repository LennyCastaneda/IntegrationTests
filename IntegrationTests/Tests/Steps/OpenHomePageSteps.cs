using NUnit.Framework;
using ReloadedFramework;
using ReloadedFramework.Model;
using TechTalk.SpecFlow;

namespace IntegrationTests.Tests
{
	[Binding]
    public class OpenHomePageSteps : TestBase
	{
		[Then(@"the title should be '(.*)'")]
        public void ThenTheTitleShouldBe(string title)
        {
			Assert.That(Page.Title == title);
		}
	}
}
