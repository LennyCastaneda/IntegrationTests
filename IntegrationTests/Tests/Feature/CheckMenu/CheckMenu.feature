@Chrome
Feature: Check Menu
	A user should see a fully loaded Menu with specific items shown. 
	The expandable options should expand when clicked.
	The non-expandable root-options should open tabs. 

Background:
	Given the Menu is open

Scenario Outline: Open Tabs from Menu main
	Given the MenuItem '<MenuItem>' exists
	When the MenuItem '<MenuItem>' is clicked
	Then the Tab '<MenuItem>' should be active

Examples: 
	| MenuItem |
	| Home     |
	| Settings |

Scenario Outline: Expand MenuItems
	Given the MenuItem '<Expandable>' exists
	When the MenuItem '<Expandable>' is clicked
	Then the MenuItem '<Expandable>' should be expanded

Examples: 
	| Expandable     |
	| Configurations |
	| Ungrouped views  | 