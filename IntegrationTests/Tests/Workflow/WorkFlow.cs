﻿using TechTalk.SpecFlow;

namespace IntegrationTests.Tests.Workflow
{
	[Binding]
	public class WorkFlow : Steps
	{
		[Given(@"Reloaded is open")]
		public void OpenReloaded()
		{
			Given("the Browser exists");
			When("the Browser is pointed to 'http://localhost:52755/index.html#/config/1'");
			Then("the Browser title is 'Reloaded'");
		}

		[Given(@"the Menu is open")]
		public void OpenMenu()
		{
			Given("Reloaded is open");
			And("the Menu icon is clicked");
			Then("the Menu should be visible");
		}

		[Given(@"the SubMenu 'Configurations' is expanded")]
		[Given(@"the 'Configurations' SubMenu is expanded")]
		public void OpenConfigMenu()
		{
			Given("the Menu is open");
			When("the Menu item 'Configurations' is clicked");
			Then("the Menu item 'Configurations' should be expanded");
		}

		[Given(@"the 'Ungrouped views' SubMenu is open")]
		[Given(@"the SubMenu 'Ungrouped views' is open")]
		public void OpenUngroupedViews()
		{
			Given("the Menu is open");
			When("the Menu item 'Ungrouped views' is clicked");
			Then("the Menu item 'Ungrouped views' should be expanded");
		}

		[Given(@"the 'Home' Tab is open")]
		public void OpenHome()
		{
			Given("the Menu is open");
			When("the Menu item 'Home' is clicked");
			Then("the Tab 'Home' should be active");
		}

		[Given(@"the 'Settings' Tab is open")]
		public void OpenSettings()
		{
			Given("the Menu is open");
			And("the Menu item 'Settings' exists");
			Then("the Menu item 'Settings' is clicked");
		}

		[Given(@"a 'GridView' is open")]
		public void OpenAGridView()
		{
			Given("the Menu is open");
			And("the Menu item 'Ungrouped views' is clicked");
			//And("the Menu item 'Workflow Tool' is clicked");
			When("the Menu SubItem 'Grid Views' is clicked");
			//When("the Menu SubItem 'Work Items' is clicked");
			Then("the Tab 'Grid Views' should be active");
		}

		[Given(@"a 'ItemView' is open")]
		public void OpenAnItemView()
		{
			Given("the Menu is open");
			And("the Menu item 'Ungrouped views' is clicked");
			When("the Menu SubItem 'Item View' is clicked");
			Then("the Tab 'Item View' should be visible");
		}

		[Given(@"the ThemePicker is open")]
		public void OpenThemePicker()
		{
			Given("a 'GridView' is open");
			And("the Browser is sent the keys 'F6'");
			Then("the ThemePicker should be visible");
		}

		[Given(@"the ColumnPicker is visible")]
		public void Open_ColumnPicker()
		{
			Given("a 'GridView' is open");
			And("the ToolBar 'Settings' button is clicked");
			When("the ToolBar Settings item 'Column Picker' is clicked");
			Then("the ColumnPicker should be visible");
		}

		[Given(@"the Column '(.*)' is removed")]
		public void RemoveColumn(string name)
		{
			Given("the ColumnPicker is visible");
			When("the ColumnPicker DropDown is clicked");
			And("the ColumnPicker Column '" + name + "' is removed");
		}

		[Given(@"the Column '(.*)' is added")]
		public void AddColumn(string name)
		{
			Given("the Column '" + name + "' is removed");
			When("the ColumnPicker DropDown is clicked");
			And("the ColumnPicker DropDown item '" + name + "' is clicked");
			Then("the ColumnPicker Column '" + name + "' should be visible");
		}
	}
}
