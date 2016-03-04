using ReloadedFramework.Tests;
using TechTalk.SpecFlow;

namespace IntegrationTests.Tests.StepDefinitions
{
	[Binding]
	public sealed class LoginSteps : TestBase
	{
		[Given("I have logged into Reloaded")]
		[When("I have logged into Reloaded")]
		public void LogIn()
		{
			//App.Login.EnterPassword("Password").EnterUsername("username").Submit();
			App.Login.EnterUsername("Bons");
			App = App.Login.Submit();
			Page.Wait();
			Page.RemoveDelay();
		}
	}
}
