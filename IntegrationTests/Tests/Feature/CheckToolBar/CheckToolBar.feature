@Chrome
Feature: Check ToolBar
	As a user I would like to open the toolbar.

Background: 
	Given a 'GridView' is open
	Then the ToolBar should be visible

Scenario: Click Back
	When the ToolBar 'Back' button is clicked
	
Scenario: Click Settings
	When the ToolBar 'Settings' button is clicked
	Then the ToolBar Settings dropdown should be visible