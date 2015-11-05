@Chrome
Feature: CheckToolBar
	As a user I would like to open the toolbar.

Background: 
	Given Reloaded is open
	When the Menu is opened
	And the MenuItem 'Contact Manager' is clicked
	When the MenuItem SubItem 'Individual Clients' is clicked
	And the Tab 'Individual Clients' exists
	Then the Tab 'Individual Clients' is active

Scenario Outline: Help opens Help Window
	Given the ToolBar exists
	When the ToolBar '<button>' button is clicked
	Then wait

Examples: 
	| button   |
	| Help     |
	| Search   |
	| Setup    |
	| Overflow |