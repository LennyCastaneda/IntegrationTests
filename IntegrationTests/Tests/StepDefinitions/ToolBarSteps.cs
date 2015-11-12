using NUnit.Framework;
using ReloadedFramework.Tests;
using TechTalk.SpecFlow;

namespace IntegrationTests.Tests.StepDefinitions
{
	[Binding]
	public sealed class ToolBarSteps : TestBase
	{
		[StepDefinition(@"the ToolBar exists")]
		public static void ToolBarExists()
		{
			Assert.NotNull(View.ToolBar);
		}

		[StepDefinition(@"the ToolBar '(.*)' button exists")]
		public static void ToolBarItem_Exists(string name)
		{
			Assert.NotNull(View.ToolBar.SubItem(name));
		}

		[StepDefinition(@"the ToolBar '(.*)' button is clicked")]
		public static void ToolBarItem_Click(string name)
		{
			Assert.DoesNotThrow(() =>
			{
				View.ToolBar.SubItem(name).Click();
			});
		}

		[StepDefinition(@"the ToolBar '(.*)' DropDown button '(.*)' is clicked")]
		public static void ToolBarSubItem_Click(string name, string subname)
		{
			Assert.DoesNotThrow(() =>
			{
				View.ToolBar.SubItem(name).DropDown.SubItem(subname).Click();
			});
		}

		[StepDefinition(@"the ToolBar '(.*)' menu is visible")]
		public static void SubItemMenuIsVisible(string item)
		{
			Assert.That(View.ToolBar.SubItem(item).IsOpen);
		}
	}
}

