@Chrome
Feature: Open Configurations
	A user should be able to expand the 'Configurations' option in the Menu 
	When a user clicks a subitem, a corresponding list of Tabs should open.

Background:
	Given Reloaded is open
	When the Menu icon is clicked
	Then the Menu should be visible

Scenario Outline: Open Configurations
	Given the Menu item 'Configurations' is clicked
	When the Menu SubItem '<Config>' is clicked
	Then the Tab count should be '<TabCount>'
	
Examples: 
	| Config  | TabCount |
	| Default | 1        |