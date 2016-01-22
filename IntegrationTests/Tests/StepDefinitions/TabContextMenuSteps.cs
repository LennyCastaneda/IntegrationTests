using NUnit.Framework;
using ReloadedFramework;
using ReloadedFramework.Model;
using ReloadedFramework.Tests;
using TechTalk.SpecFlow;

namespace IntegrationTests.Tests.StepDefinitions
{
	[Binding]
	public sealed class TabContextMenuSteps : TestBase
	{
		[When(@"the Tab ContextMenu Reload is clicked")]
		public void TabContextMenu_Reload()
		{
			App.View.Tabs.ContextMenu.Reload();
		}

		[When(@"the Tab ContextMenu Duplicate is clicked")]
		public void TabContextMenu_Duplicate()
		{
			App.View.Tabs.ContextMenu.Duplicate();
		}

		[When(@"the Tab ContextMenu CloseTab is clicked")]
		public void TabContextMenu_CloseTab()
		{
			App.View.Tabs.ContextMenu.CloseTab();
		}

		[When(@"the Tab ContextMenu CloseTabsToRight is clicked")]
		public void TabContextMenu_CloseTabsToRight()
		{
			App.View.Tabs.ContextMenu.CloseTabsToRight();
		}

		[Then(@"the Tab ContextMenu should be visible")]
		public void TabContextMenu_IsVisible()
		{
			Assert.That(App.View.Tabs.ContextMenu.IsVisible);
		}
	}
}
