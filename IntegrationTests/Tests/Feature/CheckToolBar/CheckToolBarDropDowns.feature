@Chrome
Feature: Check GridView ToolBar Options
	The ToolBar has icons. Once pressed some icons show a dropdown menu.
	Each of these items should be clickable.

Background: 
	Given a 'GridView' is open

Scenario: Click 'Column Picker' from Settings
	When the ToolBar 'Settings' button is clicked
	And the ToolBar Settings item 'Column Picker' is clicked
	Then the ColumnPicker should be visible

Scenario: Click 'Sort Order' from Settings
	When the ToolBar 'Settings' button is clicked
	And the ToolBar Settings item 'Sort Order' is clicked
	#Then the SortOrderPicker should be open

Scenario: Click 'Choose Theme' from Settings
	When the ToolBar 'Settings' button is clicked
	And the ToolBar Settings item 'Choose Theme' is clicked
	Then the ThemePicker should be visible

Scenario: Click Close from Settings
	When the ToolBar 'Settings' button is clicked
	And the ToolBar Settings item 'Close Tab' is clicked
	Then the Tab 'Grid Views' should not be visible