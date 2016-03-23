@Chrome
Feature: SaveConfig
	Show that a saved configuration retains the current theme and tabs.

Scenario: Save Configuration with different theme
	Given Reloaded is open
	When I change the Configuration theme to 'Red'
	And I save the current Configuration
	And I open the Configuration 'Diary'
	And I open the Configuration 'Default'	
	Then the Background colour is 'Red'

Scenario: Save Configuration with different tabs
	Given Reloaded is open
	When I open the 'Tasks' view from the 'Workflow Tool' module
	And I save the current Configuration
	And I open the Configuration 'Diary'
	And I open the Configuration 'Default'	
	Then the Tab 'Tasks' should be open
