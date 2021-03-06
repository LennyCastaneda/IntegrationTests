﻿@Chrome
Feature: CheckThemePicker
	The Theme Picker, accessible from the Toolbar Setup dropdown or the shortcut 'F6'
	Should change the colour scheme of the current page.

Background: 
	Given a 'GridView' is open
	Then the ToolBar should be visible

Scenario: Open ThemePicker by ToolBar
	When the ToolBar 'Settings' button is clicked
	And the ToolBar Settings item 'Choose Theme' is clicked
	Then the ThemePicker should be visible

Scenario: Open ThemePicker by Shortcut
	When the Browser is sent the keys 'F6'
	Then the ThemePicker should be visible

Scenario: Close ThemePicker by Cancel
	Given the ThemePicker is open
	When the ThemePicker 'Cancel' button is clicked
	Then the ThemePicker should not be visible

Scenario: Close ThemePicker by Apply
	Given the ThemePicker is open
	When the ThemePicker 'Apply to View' button is clicked
	Then the ThemePicker should not be visible

Scenario Outline: Apply Colour Scheme
	Given the ThemePicker is open
	When the ThemePicker colour '<Colour>' is clicked
	And the ThemePicker 'Apply to View' button is clicked
	Then the ThemePicker should not be visible
	And the Background colour is '<Colour>'

Examples: 
	| Colour      |
	| Red         |
	| Pink        |
	| Purple      |
	| Deep Purple |
	| Indigo      |
	| Blue        |
	| Light Blue  |
	| Cyan        |
	| Teal        |
	| Green       |
	| Light Green |
	| Lime        |
	| Yellow      |
	| Amber       |
	| Orange      |
	| Deep Orange |
	| Brown       |
	| Grey        |
	| Blue Grey   |
