using NUnit.Framework;
using ReloadedFramework.Tests;
using TechTalk.SpecFlow;

namespace IntegrationTests.Tests.StepDefinitions
{
	[Binding]
	public sealed class ToolBarSteps : TestBase
	{
		[When(@"I save the current View")]
		public static void ToolBar_SaveView()
		{
			ToolBarSteps.Cog_Click();
			ToolBarSteps.Cog_DropDownItem_Click("Save View");
		}

		[When(@"I save the current View as '(.*)'")]
		public static void ToolBar_SaveViewAs(string name)
		{
			ToolBarSteps.Cog_Click();
			ToolBarSteps.Cog_DropDownItem_Click("Save view as");
			SaveAsSteps.SaveAs_EnterName(name);
			SaveAsSteps.SaveAs_Save();
		}

		[When(@"the ToolBar 'Back' button is clicked")]
		public static void Back_Click()
		{
			App.View.ToolBar.Back.Click();
		}

		[When(@"the ToolBar 'Settings' button is clicked")]
		public static void Cog_Click()
		{
			App.View.ToolBar.Cog.Click();
		}

		[When(@"the ToolBar Settings item '(.*)' is clicked")]
		public static void Cog_DropDownItem_Click(string name)
		{
			App.View.ToolBar.Cog.ClickItem(name);
		}

		[Then(@"the ToolBar 'Settings' should be visible")]
		public static void CogIsVisible()
		{
			Assert.That(App.View.ToolBar.Cog.IsVisible);
		}

		[Then(@"the ToolBar 'Back' should be visible")]
		public static void BackIsVisible()
		{
			Assert.That(App.View.ToolBar.Cog.IsVisible);
		}

		[Then(@"the ToolBar Settings dropdown should be visible")]
		public static void ThenTheToolBarSettingsDropdownShouldBeVisible()
		{
			Assert.That(App.View.ToolBar.Cog.DropDownIsVisible);
		}

		[Then(@"the ToolBar should be visible")]
		public static void ToolBarIsVisible()
		{
			Assert.That(App.View.ToolBar.IsVisible);
		}
	}
}

