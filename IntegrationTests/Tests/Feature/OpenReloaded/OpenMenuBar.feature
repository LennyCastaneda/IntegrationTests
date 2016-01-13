@Chrome
Feature: Open and close Menu bar
	As a user I would like to open the menu bar.

Background: 
	Given Reloaded is open

Scenario: Open Menu Bar
	When the Menu icon is clicked
	Then the Menu is currently open

Scenario: Close Menu Bar
	Given the Menu icon is clicked
	And the Menu is open
	When the Menu close icon is clicked
	Then the Menu is closed