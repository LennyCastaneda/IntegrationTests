using NUnit.Framework;
using ReloadedFramework.Tests;
using TechTalk.SpecFlow;

namespace IntegrationTests.Tests.StepDefinitions
{
	[Binding]
	public sealed class MenuSteps : TestBase
	{
		[StepDefinition("the Menu icon is clicked")]
		public void OpenMenu()
		{
			App.Menu.Open();
		}

		[Then("the Menu should be visible")]
		public void MenuVisible()
		{
			Assert.That(App.Menu.IsVisible);
		}

		[When("the Menu item '(.*)' is clicked")]
		public void ClickMenuItem(string name)
		{
			App.Menu.ClickItem(name);
		}

		[Given("the Menu item '(.*)' exists")]
		public void MenuItemExists(string name)
		{
			App.Menu.ItemExists(name);
		}

		[Then("the Menu item '(.*)' should be expanded")]
		public void MenuItemExpanded(string name)
		{
			App.Menu.ItemExists(name);
		}
	}
}
