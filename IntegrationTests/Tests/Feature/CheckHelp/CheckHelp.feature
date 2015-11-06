@Chrome
Feature: CheckHelp
	Open Help from the ToolBar, check the Back button and Close button work.

Background: 
	Given Reloaded is open
	When Individual Clients is opened
	Then the ToolBar exists

Scenario: Open help
	Given the ToolBar 'Help' button is clicked
	And the Help window is open
	And the Help window Back button is clicked
	When the Help window Close button is clicked
	Then the Help window is not open