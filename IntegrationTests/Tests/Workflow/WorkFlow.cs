using ReloadedFramework;
using TechTalk.SpecFlow;

namespace IntegrationTests.Tests.Workflow
{
	[Binding]
	public class WorkFlow : Steps
	{
		[Given(@"Reloaded is open")]
		public void OpenReloaded()
		{
			Given("the Browser exists");
			When("the Browser is pointed to 'http://durell.co.uk:1024/#/config/1'");
			Then("the Browser title is 'Reloaded'");
		}
	}
}
