@Chrome
Feature: Check Workflow
	Check each workflow performs the desired operation

Scenario: Reloaded is open
	Given Reloaded is open

Scenario: the Menu is open
	Given the Menu is open

Scenario: the 'Configurations' SubMenu is expanded
	Given the 'Configurations' SubMenu is expanded

Scenario: the 'Ungrouped views' SubMenu is open
	Given the 'Ungrouped views' SubMenu is open

Scenario: the 'Home' Tab is open
	Given the 'Home' Tab is open

Scenario: the 'Settings' Tab is open
	Given the 'Settings' Tab is open

Scenario: a 'GridView' is open
	Given a 'GridView' is open

Scenario: a 'ItemView' is open
	Given a 'ItemView' is open

Scenario: the ThemePicker is open
	Given the ThemePicker is open

Scenario: the Tab ContextMenu is visible
	Given a 'GridView' is open
	When the Tab 'Work Items' is right-clicked
	Then the Tab ContextMenu should be visible