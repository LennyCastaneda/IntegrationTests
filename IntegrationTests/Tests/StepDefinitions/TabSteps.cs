using NUnit.Framework;
using ReloadedFramework;
using ReloadedFramework.Model;
using ReloadedFramework.Tests;
using TechTalk.SpecFlow;

namespace IntegrationTests.Tests.StepDefinitions
{
	[Binding]
	public sealed class TabSteps : TestBase
	{
		[StepDefinition(@"the Tab '(.*)' is clicked")]
		public static void ClickTab(string name)
		{
			App.View.Tabs.ClickTab(name);
		}

		[Then(@"the Tab '(.*)' should be active")]
		public static void TabIsActive(string name)
		{
			Assert.That(App.View.Tabs.TabIsActive(name));
		}

		[Then(@"the Tab '(.*)' should be visible")]
		public static void TabExists(string name)
		{
			Assert.That(App.View.Tabs.TabExists(name));
		}

		[Then(@"the Tab '(.*)' should not be visible")]
		public void ThenTheTabShouldNotBeVisible(string name)
		{
			Assert.That(!App.View.Tabs.TabExists(name));
		}

		[Then(@"the Tab count should be '(.*)'")]
		public static void NumberOfTabs(int count)
		{
			Assert.That(App.View.Tabs.Count() == count);
		}
	}
}
