﻿using ReloadedFramework;
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

		[When(@"Individual Clients is opened")]
		public void OpenIndividualClients()
		{
			Given("the Menu is opened");
			And("the MenuItem 'Contact Manager' is clicked");
			When("the MenuItem SubItem 'Individual Clients' is clicked");
			And("the Tab 'Individual Clients' exists");
			When("the Tab 'Individual Clients' is active");
		}
	}
}
