using NUnit.Framework;
using ReloadedFramework.Tests;
using TechTalk.SpecFlow;

namespace IntegrationTests.Tests.StepDefinitions
{
	[Binding]
	public sealed class ToolBarSteps : TestBase
	{
		[Then(@"the ToolBar should be visible")]
		public static void ToolBarIsVisible()
		{
			Assert.That(App.View.ToolBar.IsVisible);
		}

		[StepDefinition(@"the ToolBar Back button is clicked")]
		public static void Back_Click()
		{
			App.View.ToolBar.Back.Click();
		}

		[StepDefinition(@"the ToolBar Settings button is clicked")]
		public static void Cog_Click()
		{
			App.View.ToolBar.Cog.Click();
		}

		[When(@"the ToolBar Settings item '(.*)' is clicked")]
		public void WhenTheToolBarDropdownItemIsClicked(string name)
		{
			App.View.ToolBar.Cog.ClickItem(name);
		}

		[Then(@"the ToolBar Settings should be visible")]
		public static void CogIsVisible()
		{
			Assert.That(App.View.ToolBar.Cog.IsVisible);
		}

		[Then(@"the ToolBar Back should be visible")]
		public static void BackIsVisible()
		{
			Assert.That(App.View.ToolBar.Cog.IsVisible);
		}

		[Then(@"the ToolBar Settings dropdown should be visible")]
		public void ThenTheToolBarSettingsDropdownShouldBeVisible()
		{
			Assert.That(App.View.ToolBar.Cog.DropDownIsVisible);
		}
	}
}

