@Chrome
Feature: Open Configurations
	A user should be able to expand the 'Configurations' option in the Menu 
	When a user clicks a subitem, a corresponding list of Tabs should open.

Background:
	Given Reloaded is open
	When the Menu icon is clicked
	And the Menu is open
	Then the MenuItem 'Configurations' is clicked

Scenario: Open Config: Default
	Given the MenuItem 'Configurations' is currently expanded
	When the MenuItem SubItem 'Default' is clicked
	Then the Tab count should be '1'

Scenario: Open Config: Dumble
	Given the MenuItem 'Configurations' is currently expanded
	When the MenuItem SubItem 'Dumble' is clicked
	Then the Tab count should be '7'