@Chrome
Feature: Open Configurations
	A user should be able to open configurations, which is a specific list of Tabs that open.

Background:
	Given the Browser exists
	When the Browser is pointed to 'http://durell.co.uk:1024/#/config/1'
	And the Browser title should be 'Reloaded'
	When the Menu icon is clicked
	And the Menu is open
	Then the MenuItem 'Configurations' is clicked

Scenario: Open Configurations: Default
	Given the MenuItem 'Configurations' is currently expanded
	When the MenuItem SubItem 'Default' is clicked
	Then the Tab count should be '1'

Scenario: Open Configurations : Dumble
	Given the MenuItem 'Configurations' is currently expanded
	When the MenuItem SubItem 'Dumble' is clicked
	Then the Tab count should be '7'