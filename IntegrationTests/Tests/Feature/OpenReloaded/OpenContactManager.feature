@Chrome
Feature: OpenSpecificTabsFromMenu
	A user should be able to open specific Tabs/Modules by clicking on the respective menu items.

Background:
	Given the Browser exists
	When the Browser is pointed to 'http://durell.co.uk:1024/#/config/1'
	And the Browser title is 'Reloaded'
	Then the Menu icon is clicked

Scenario: Expand Contact Manager
	Given the Menu is open
	When the MenuItem 'Contact Manager' is clicked
	Then the MenuItem 'Contact Manager' should be expanded

Scenario: Open Home
	Given the Menu is open
	And the MenuItem 'Home' exists
	When the MenuItem 'Home' is clicked
	Then the Tab 'Home' should be active

Scenario: Open Individual Clients
	Given the Menu is open
	And the Tab 'Individual Clients' exists
	When the Tab 'Individual Clients' is clicked
	Then the Tab 'Individual Clients' should be active
