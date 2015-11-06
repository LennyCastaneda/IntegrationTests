@Chrome
Feature: CheckToolBarSetup
	The ToolBar has a Setup icon. Once pressed the icon shows a dropdown menu.
	Each of these items should be clickable.

Background: 
	Given Reloaded is open
	When Individual Clients is opened

Scenario: The Setup dropdown menu is navigable
	Given the ToolBar 'Setup' button is clicked
	And the ToolBar 'Setup' menu is visible
	When the ToolBar 'Setup' DropDown button 'Filter' is clicked
	Then wait

Scenario: The Overflow dropdown menu is navigable
	Given the ToolBar 'Overflow' button is clicked
	And the ToolBar 'Overflow' menu is visible
	When the ToolBar 'Overflow' DropDown button 'Share' is clicked
	Then wait
