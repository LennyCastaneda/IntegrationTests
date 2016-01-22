@Chrome
Feature: CheckColumnPicker
	Ensure the ColumnPicker has all the functionality desired.

Scenario: the ColumnPicker is visible
	Given a 'GridView' is open
	When the ToolBar 'Settings' button is clicked
	And the ToolBar Settings item 'Column Picker' is clicked
	Then the ColumnPicker should be visible

Scenario: Click Close
	Given the ColumnPicker is visible
	When the ColumnPicker 'Close' button is clicked
	Then the ColumnPicker should not be visible

Scenario: Click Cancel
	Given the ColumnPicker is visible
	When the ColumnPicker 'Cancel' button is clicked
	Then the ColumnPicker should not be visible

Scenario: Click Apply
	Given the ColumnPicker is visible
	When the ColumnPicker 'Apply' button is clicked
	Then the ColumnPicker should not be visible

Scenario: the Column '(.*)' is removed
	Given the ColumnPicker is visible
	When the ColumnPicker DropDown is clicked
	And the ColumnPicker Column 'singleton' is removed
	Then the ColumnPicker Column 'singleton' should not be visible

Scenario: the Column '(.*)' is added
	Given the Column 'singleton' is removed
	When the ColumnPicker DropDown is clicked
	And the ColumnPicker DropDown item 'singleton' is clicked
	Then the ColumnPicker Column 'singleton' should be visible

Scenario: Remove a column
	Given the Column 'singleton' is removed
	When the ColumnPicker 'Apply' button is clicked
	Then the GridView Column 'singleton' should not be visible

Scenario: DragAndDrop a Column
	Given the ColumnPicker is visible
	When the ColumnPicker Column at position '1' is moved to position '2'
	Then the ColumnPicker Column 'name' should be at position '2'
	And the ColumnPicker Column 'singleton' should be at position '1'