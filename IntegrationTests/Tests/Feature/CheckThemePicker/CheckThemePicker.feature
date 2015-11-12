@Chrome
Feature: ThemePicker
	The Theme Picker, accessible from the Toolbar Setup dropdown or the shortcut 'F6'
	Should change the colour scheme of the current page.

Background: 
	Given Reloaded is open
	When Individual Clients is opened
	Then the ToolBar exists
	
Scenario: Open ThemePicker by ToolBar
	Given the ToolBar 'Setup' button exists
	When the ToolBar 'Setup' button is clicked
	And the ToolBar 'Setup' DropDown button 'Choose Theme' is clicked
	Then the ThemePicker should be open

Scenario: Open ThemePicker by Shortcut
	Given the Browser is sent the keys 'F6'
	Then the ThemePicker should be open

Scenario: Close ThemePicker by Cancel
	Given ThemePicker is open
	When the ThemePicker Cancel button is clicked
	Then the ThemePicker should not be open

Scenario: Close ThemePicker by Apply
	Given ThemePicker is open
	When the ThemePicker Apply button is clicked
	Then the ThemePicker should not be open

Scenario Outline: Apply Colour Scheme
	Given ThemePicker is open
	And the ThemePicker colour '<Colour>' is clicked
	When the ThemePicker Apply button is clicked
	And the ThemePicker should not be open
	Then the Background colour is '<Colour>'

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
