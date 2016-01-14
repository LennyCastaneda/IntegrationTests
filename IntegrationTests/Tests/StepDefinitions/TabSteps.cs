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
		//[StepDefinition(@"the Tab '(.*)' is clicked")]
		//public static void ClickTab(string name)
		//{
		//	TabExists(name);

		//	App.View.Tab(name).Click();
		//}

		[StepDefinition(@"the Tab '(.*)' should be active")]
		public static void TabIsActive(string name)
		{
			App.View.Tabs.TabExists(name);
			Assert.That(App.View.Tabs.TabIsActive(name));
		}

		//[StepDefinition(@"the Tab '(.*)' exists")]
		//public static void TabExists(string name)
		//{
		//	Assert.NotNull((object)View);
		//	Assert.NotNull(View.Tab(name));
		//}

		//[StepDefinition(@"the Tab count should be '(.*)'")]
		//public static void NumberOfTabs(int count)
		//{
		//	Assert.That(View.TabCount == count);
		//}
	}
}
