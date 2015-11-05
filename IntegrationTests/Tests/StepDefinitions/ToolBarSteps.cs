using NUnit.Framework;
using ReloadedFramework;
using ReloadedFramework.Model;
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

		[StepDefinition(@"the ToolBar '(.*)' button is clicked")]
		public static void ToolBarItem_Click(string name)
		{
			Assert.NotNull(View.ToolBar);
			View.ToolBar.SubItem(name).Click();
		}

	}
}

