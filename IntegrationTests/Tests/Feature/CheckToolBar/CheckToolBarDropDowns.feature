@Chrome
Feature: CheckToolBarOptions
	The ToolBar has icons. Once pressed some icons show a dropdown menu.
	Each of these items should be clickable.

Background: 
	Given Reloaded is open
	When Individual Clients is opened

Scenario Outline: The Toolbar dropdown menus are clickable
	Given the ToolBar '<ToolBar>' button is clicked
	And the ToolBar '<ToolBar>' menu is visible
	When the ToolBar '<ToolBar>' DropDown button '<Options>' is clicked
	Then wait

Examples: 
	| ToolBar  | Options        |
	| Setup    | Filter         |
	| Setup    | Choose Columns |
	| Setup    | Choose Theme   |
	| Setup    | Save View      |
	| Setup    | Save View As   |
	| Setup    | Close View     |
	| Overflow | Share          |