@Chrome
Feature: CheckToolBar
	As a user I would like to open the toolbar.

Background: 
	Given Reloaded is open
	When Individual Clients is opened
	Then the ToolBar exists

Scenario Outline: Click each ToolBar button
	Given the ToolBar exists
	When the ToolBar '<button>' button is clicked
	Then wait

Examples: 
	| button   |
	| Help     |
	| Search   |
	| Setup    |
	| Overflow |