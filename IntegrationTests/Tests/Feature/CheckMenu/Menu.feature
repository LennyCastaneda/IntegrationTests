@Chrome
Feature: Menu

Background: 
	Given Reloaded is open

Scenario: Check Menu UI
	Given I have logged into Reloaded
	When the Menu icon is clicked
	Then the Menu should be visible
