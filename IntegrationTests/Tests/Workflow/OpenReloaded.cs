using ReloadedFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace IntegrationTests.Tests.Workflow
{
	[Binding]
	public sealed class OpenReloaded : TestBase
	{
		[StepDefinition(@"I have opened Reloaded")]
		public static void ReloadedIsOpen()
		{
			BrowserSteps.GivenABrowser("Chrome");
			BrowserSteps.WhenItPointsTo("http://durell.co.uk:1024/#/config/1");
			BrowserSteps.ThenTheTitleShouldBe("Reloaded");
        }
	}
}
