﻿@Chrome
Feature: Check Menu
	A user should see a fully loaded Menu with specific items shown. 
	The expandable options should expand when clicked.
	The non-expandable root-options should open tabs. 

Background:
	Given the Menu is open

Scenario Outline: Open Tabs from Menu
	Given the Menu item '<MenuItem>' exists
	When the Menu item '<MenuItem>' is clicked	
	Then the Tab '<MenuItem>' should be active

Examples: 
	| MenuItem |
	| Home     |
	| Settings |

Scenario Outline: Expand MenuItems
	Given the Menu item '<Expandable>' exists
	When the Menu item '<Expandable>' is clicked
	Then the Menu item '<Expandable>' should be expanded

Examples: 
	| Expandable      |
	| Configurations  |
	| Ungrouped views |