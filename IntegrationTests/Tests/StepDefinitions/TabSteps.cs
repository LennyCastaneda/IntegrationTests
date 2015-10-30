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
			View.SubItem(name).Click();
		}

		[StepDefinition(@"the Tab '(.*)' should be active")]
		public static void TabIsActive(string name)
		{
			TabExists(name);
			Assert.That(View.SubItem(name).Active);
		}

		[StepDefinition(@"the Tab '(.*)' exists")]
		public static void TabExists(string name)
		{
			Assert.NotNull(View);
			Assert.True(View.SubItemExists(name));
			Assert.NotNull(View.SubItem(name));
		}

		[StepDefinition(@"the Tab count should be '(.*)'")]
		public static void NumberOfTabs(int count)
		{
			View.GetSubItems();
			Assert.That(View.SubItemCount == count);
		}
	}
}
