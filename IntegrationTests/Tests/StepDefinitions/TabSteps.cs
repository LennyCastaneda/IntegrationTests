﻿using NUnit.Framework;
using ReloadedFramework.Model;
using ReloadedFramework.Tests;
using TechTalk.SpecFlow;

namespace IntegrationTests.Tests.StepDefinitions
{
	[Binding]
	public sealed class TabSteps : TestBase
	{
		[When(@"the Tab '(.*)' is clicked")]
		public static void Tab_Click(string name)
		{
			App.View.Tabs.ClickTab(name);
		}

		[When(@"the Tab ContextMenu is right-clicked")]
		public static void Tab_Current_RightClicked()
		{
			App.View.Tabs.RightClickActiveTab();
		}

		[When(@"the Tab '(.*)' is right-clicked")]
		public static void Tab_RightClick(string name)
		{
			App.View.Tabs.RightClickTab(name);
		}

		[Then(@"the Tab '(.*)' should be active")]
		public static void Tab_IsActive(string name)
		{
			Assert.That(App.View.Tabs.TabIsActive(name));
		}

		[Then(@"the Tab '(.*)' should be visible")]
		[Then(@"the Tab '(.*)' should be open")]
		public static void Tab_IsVisible(string name)
		{
			Assert.That(App.View.Tabs.TabExists(name));
		}

		[Then(@"the Tab '(.*)' should not be visible")]
		public static void Tab_IsNotVisible(string name)
		{
			Assert.That(!App.View.Tabs.TabExists(name));
		}

		[Then(@"the Tab count should be '(.*)'")]
		public static void Tab_Count(int count)
		{
			Assert.That(App.View.Tabs.Count() == count);
		}
	}
}
