using NUnit.Framework;
using ReloadedFramework.Tests;
using TechTalk.SpecFlow;

namespace IntegrationTests.Tests.StepDefinitions
{
	[Binding]
	public sealed class MenuSteps : TestBase
	{
		[StepDefinition(@"the Menu is opened")]
		[StepDefinition("the Menu icon is clicked")]
		public void OpenMenu()
		{
			App.Menu.Open();
		}

		[StepDefinition("the Menu is closed")]
		[StepDefinition("the Menu Back icon is clicked")]
		public void CloseMenu()
		{
			App.Menu.Close();
		}

		[StepDefinition("the Menu item '(.*)' is clicked")]
		public void ClickMenuItem(string name)
		{
			App.Menu.ClickItem(name);
		}

		[StepDefinition("the Menu SubItem '(.*)' is clicked")]
		public void ClickMenuSubItem(string name)
		{
			App.Menu.ClickSubItem(name);
		}

		[Then("the Menu should be visible")]
		public void MenuVisible()
		{
			Assert.That(App.Menu.IsVisible);
		}

		[Then("the Menu should not be visible")]
		public void MenuNotVisible()
		{
			Assert.That(!App.Menu.IsVisible);
		}

		[Then("the Menu item '(.*)' exists")]
		public void MenuItemExists(string name)
		{
			Assert.That(App.Menu.ItemExists(name));
		}

		[Then("the Menu item '(.*)' should be expanded")]
		public void MenuItemExpanded(string name)
		{
			Assert.That(App.Menu.ItemExists(name));
		}
	}
}
