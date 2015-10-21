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
			Page.GoTo("http://www.bing.com/");
		}
	}
}
