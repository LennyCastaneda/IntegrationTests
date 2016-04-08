@Chrome
Feature: ColumnPicker
	Show that the Column Picker modal can be used to add, remove and reorder the visible columns in a grid view.

Background: 
	Given I open the WorkItems view

Scenario: Adding a column
	Given the ColumnPicker is open
	When the Column 'Body' is added
	And the ColumnPicker 'Apply' button is clicked
	Then the Column 'Body' should be visible in the GridView
	
Scenario: Removing a column	
	Given I open the ColumnPicker
	When the Column 'Action' is removed
	And the ColumnPicker 'Apply' button is clicked
	Then the Column 'Action' should not be visible in the GridView
	
Scenario: Changing the order of a column
	Given I open the ColumnPicker	
	When I drag the Column 'Action' to position '1' in the ColumnPicker
	Then the ColumnPicker Column 'Action' should be at position '1'

Scenario: Changing the order of a column in the gridview
	Given I open the ColumnPicker	
	When I drag the Column 'Action' to position '1' in the ColumnPicker
	And the ColumnPicker 'Apply' button is clicked
	Then the GridView Header at position '1' shoud be 'Action'
		