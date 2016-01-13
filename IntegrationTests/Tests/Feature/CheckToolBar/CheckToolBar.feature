@Chrome
Feature: CheckToolBar
	As a user I would like to open the toolbar.

Background: 
	Given a 'GridView' is open
	Then the ToolBar exists

Scenario Outline: Click each ToolBar button
	Given the ToolBar '<button>' button exists
	When the ToolBar '<button>' button is clicked
	Then wait

Examples: 
	| button   |
	| Settings |
	| Back     |