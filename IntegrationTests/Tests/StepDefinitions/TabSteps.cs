using NUnit.Framework;
using ReloadedFramework;
using ReloadedFramework.Model;
using TechTalk.SpecFlow;

namespace IntegrationTests.Tests.StepDefinitions
{
	[Binding]
	public sealed class TabSteps : TestBase
	{
		[StepDefinition(@"the Tab '(.*)' is clicked")]
		public static void ClickTab(string name)
		{
			TabExists(name);
			View.Tab(name).Click();
		}

		[StepDefinition(@"the Tab '(.*)' is active")]
		[StepDefinition(@"the Tab '(.*)' should be active")]
		public static void TabIsActive(string name)
		{
			View.Tab(name).Click();
			Assert.That(View.Tab(name).Active);
		}

		[StepDefinition(@"the Tab '(.*)' exists")]
		public static void TabExists(string name)
		{
			Assert.NotNull(View);
			Assert.NotNull(View.Tab(name));
		}

		[StepDefinition(@"the Tab count should be '(.*)'")]
		public static void NumberOfTabs(int count)
		{
			Assert.That(View.TabCount == count);
		}
	}
}
