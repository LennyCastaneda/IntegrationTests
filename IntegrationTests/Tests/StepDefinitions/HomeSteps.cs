using ReloadedFramework.Tests;
using TechTalk.SpecFlow;

namespace IntegrationTests.Tests.StepDefinitions
{
	[Binding]
	public sealed class HomeSteps : TestBase
	{
		[StepDefinition(@"the '(.*)' feed is visible")]
		public static void CheckFeedIsVisible(string name)
		{
			
		}
	}
}
