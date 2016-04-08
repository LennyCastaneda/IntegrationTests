using NUnit.Framework;
using ReloadedFramework.Model;
using ReloadedFramework.Tests;
using TechTalk.SpecFlow;

namespace IntegrationTests.Tests.StepDefinitions
{
	[Binding]
	public sealed class TabContextMenuSteps : TestBase
	{
		[When(@"the Tab ContextMenu 'Reload' is clicked")]
		public static void TabContextMenu_Reload()
		{
			App.View.Tabs.ContextMenu.Reload();
		}

		[When(@"the Tab ContextMenu 'Duplicate' is clicked")]
		public static void TabContextMenu_Duplicate()
		{
			App.View.Tabs.ContextMenu.Duplicate();
		}

		[When(@"the Tab ContextMenu 'Close tab' is clicked")]
		public static void TabContextMenu_CloseTab()
		{
			App.View.Tabs.ContextMenu.CloseTab();
		}

		[When(@"the Tab ContextMenu 'Close tabs to right' is clicked")]
		public static void TabContextMenu_CloseTabsToRight()
		{
			App.View.Tabs.ContextMenu.CloseTabsToRight();
		}

		[Then(@"the Tab ContextMenu should be visible")]
		public static void TabContextMenu_IsVisible()
		{
			Assert.That(App.View.Tabs.ContextMenu.IsVisible);
		}
	}
}
