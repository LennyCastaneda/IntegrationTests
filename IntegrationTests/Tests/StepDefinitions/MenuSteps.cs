using NUnit.Framework;
using ReloadedFramework.Tests;
using TechTalk.SpecFlow;

namespace IntegrationTests.Tests.StepDefinitions
{
	[Binding]
	public sealed class MenuSteps : TestBase
	{
		[When("I open the '(.*)' view from the '(.*)' module")]
		public static void Menu_Open_View(string view, string module)
		{
			MenuSteps.Menu_Open();
			MenuSteps.Menu_Item_Click(module);
			MenuSteps.Menu_SubItem_Click(view);
		}

		[Then("the view '(.*)' should be visible in the '(.*)' module")]
		public static void Menu_Item_Exists(string view, string module)
		{
			MenuSteps.Menu_Open();
			MenuSteps.Menu_Item_Click(module);
			MenuSteps.Menu_Item_IsVisible(view);
		}

		[When("the Menu icon is clicked")]
		public static void Menu_Open()
		{
			App.Menu.Open();
		}

		[When("the Menu Back icon is clicked")]
		public static void Menu_Close()
		{
			App.Menu.Close();
		}

		[When("the Menu item '(.*)' is clicked")]
		public static void Menu_Item_Click(string name)
		{
			App.Menu.ClickItem(name);
		}

		[When("the Menu SubItem '(.*)' is clicked")]
		public static void Menu_SubItem_Click(string name)
		{
			App.Menu.ClickSubItem(name);
		}

		[Then("the Menu should be visible")]
		public static void Menu_Visible()
		{
			Assert.That(App.Menu.IsVisible);
		}

		[Then("the Menu should not be visible")]
		public static void Menu_NotVisible()
		{
			Assert.That(!App.Menu.IsVisible);
		}

		[Then("the Menu item '(.*)' is visible")]
		public static void Menu_Item_IsVisible(string name)
		{
			Assert.That(App.Menu.ItemIsVisible(name));
		}

		[Then("the Menu item '(.*)' should be expanded")]
		public static void Menu_Item_Expanded(string name)
		{
			Assert.That(App.Menu.ItemIsVisible(name));
		}
	}
}
