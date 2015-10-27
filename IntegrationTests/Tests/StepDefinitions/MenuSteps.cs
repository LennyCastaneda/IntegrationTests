using NUnit.Framework;
using ReloadedFramework;
using ReloadedFramework.Model;
using TechTalk.SpecFlow;

namespace IntegrationTests.Tests.StepDefinitions
{
	[Binding]
	public sealed class MenuSteps : TestBase
	{
		[StepDefinition(@"I click the Menu Icon")]
		[StepDefinition(@"I open the Menu")]
		public static void OpenMenu()
		{
			Assert.IsNotNull(Menu);
			Menu.OpenMenu();
		}

		[StepDefinition(@"the Menu opens")]
		public static void MenuIsOpen()
		{
			Assert.IsNotNull(Menu);
			Assert.That(Menu.IsOpen);
		}

		[StepDefinition(@"I click a tab called '(.*)'")]
		public static void MenuIsOpen(string tabname)
		{
			
			Assert.That(tabname == "individual clients");
		}

		[StepDefinition(@"menu option '(.*)' exists")]
		public static void SelectMenuItem(string name)
		{
			Menu.GetSubItems();
			Assert.NotNull(Menu.SubItem(name));
		}

		[StepDefinition(@"I click menu item '(.*)'")]
		public static void ClickMenuItem(string name)
		{
			Assert.NotNull(Menu.SubItem(name));
			Menu.SubItem(name).Click();
		}

		[StepDefinition(@"I click expandable menu item '(.*)'")]
		public static void ClickExpandableMenuItem(string name)
		{
			Assert.NotNull(Menu.SubItem(name));
			Menu.SubItem(name).Click();
			Assert.That(Menu.SubItem(name).Expanded);
		}

		[StepDefinition(@"I click subitem '(.*)'")]
		public static void ClickSubItem(string name)
		{
			Assert.NotNull(Menu.SelectedItem);
			Assert.NotNull(Menu.SelectedItem.SubItem(name));
			Menu.SelectedItem.SubItem(name).Click();
		}
	}
}
