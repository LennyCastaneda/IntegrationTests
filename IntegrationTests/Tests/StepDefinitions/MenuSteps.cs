using NUnit.Framework;
using ReloadedFramework;
using ReloadedFramework.Model;
using TechTalk.SpecFlow;

namespace IntegrationTests.Tests.StepDefinitions
{
	[Binding]
	public sealed class MenuSteps : TestBase
	{
		[StepDefinition(@"the Menu icon is clicked")]
		[StepDefinition(@"the Menu is opened")]
		public static void OpenMenu()
		{
			Assert.IsNotNull(Menu);
			Menu.Open();
		}

		[StepDefinition(@"the Menu is closed")]
		[StepDefinition(@"the Menu close icon is clicked")]
		[StepDefinition(@"the Menu back icon is clicked")]
		public static void CloseMenuBar()
		{
			Menu.Close();
			//Menu.CloseByClickingOffMenuBar();
		}

		[StepDefinition(@"the Menu is open")]
		public static void MenuIsOpen()
		{
			Assert.IsNotNull(Menu);
			Assert.That(Menu.IsOpen);
		}

		[StepDefinition(@"the Menu is not open")]
		public static void MenuIsClosed()
		{
			Assert.IsNotNull(Menu);
			Assert.That(!Menu.IsOpen);
		}

		[StepDefinition(@"the MenuItem '(.*)' exists")]
		[StepDefinition(@"the Menu option '(.*)' exists")]
		public static void SelectMenuItem(string name)
		{
			Assert.NotNull(Menu.SubItem(name));
		}

		[StepDefinition(@"the MenuItem '(.*)' is clicked")]
		public static void ClickMenuItem(string name)
		{ 
			Assert.True(Menu.SubItemExists(name));
			Assert.NotNull(Menu.SubItem(name));
			Menu.SubItem(name).Click();
		}

		[StepDefinition(@"the MenuItem '(.*)' is currently expanded")]
		[StepDefinition(@"the MenuItem '(.*)' should be expanded")]
		public static void MenuItemExpanded(string name)
		{
			Assert.That(Menu.SubItem(name).Expanded);
		}

		[StepDefinition(@"the MenuItem SubItem '(.*)' is clicked")]
		public static void ClickSubItem(string name)
		{
			Assert.NotNull(Menu.SelectedItem.SubItem(name));
			Menu.SelectedItem.SubItem(name).Click();	
		}
	}
}
