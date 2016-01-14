using ReloadedFramework.Tests;
using TechTalk.SpecFlow;

namespace IntegrationTests.Tests.StepDefinitions
{
	[Binding]
	public sealed class LoginSteps : TestBase
	{
		[Given("I have logged into Reloaded")]
		public void LogIntoReloaded()
		{
			App.Login.EnterPassword("Password").EnterUsername("username").Submit();
		}
	}
}
