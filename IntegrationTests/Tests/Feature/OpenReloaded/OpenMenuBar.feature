@Chrome
Feature: Check Open and close Menu bar
	As a user I would like to open the menu bar.

Scenario: Open and Close the Menu using the icons
	Given Reloaded is open
	When the Menu icon is clicked
	And the Menu Back icon is clicked
	Then the Menu should not be visible