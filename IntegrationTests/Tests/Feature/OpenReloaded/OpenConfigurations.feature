@Chrome
Feature: Open Configurations
	A user should be able to expand the 'Configurations' option in the Menu 
	When a user clicks a subitem, a corresponding list of Tabs should open.

Background:
	Given Reloaded is open
	When the Menu icon is clicked
	And the Menu is open
	Then the MenuItem 'Configurations' is clicked

Scenario Outline: Open Configurations
	Given the MenuItem 'Configurations' is currently expanded
	When the MenuItem SubItem '<Config>' is clicked
	Then the Tab count should be '<TabCount>'
	
Examples: 
	| Config  | TabCount |
	| Default | 1        |
	| Dumble  | 2        |