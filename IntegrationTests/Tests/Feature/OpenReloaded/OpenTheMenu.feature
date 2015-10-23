@Chrome
Feature: OpenTheMenu
	In order to navigate the application
	As a user
	I want to be able to open the menu

Scenario: Open the Menu
	Given I have opened Reloaded
	And I click the Menu Icon
	When I click a tab called 'individual clients'
	Then the Menu opens
	And menu option 'Home' exists
	When I click menu item 'Home'
	Then I click expandable menu item 'Configurations'
	And I click subitem 'Dumble'
