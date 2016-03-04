@Chrome
Feature: ColumnPicker

Scenario: Adding a column
	Given I open the WorkItems view
	And the ColumnPicker is open
	When the Column 'Body' is added
	Then the Column 'Action' should be visible in the GridView
	
Scenario: Removing a column	
	Given I open the WorkItems view
	Given I open the ColumnPicker
	When the Column 'Action' is removed
	Then the Column 'Action' should not be visible in the GridView
	
Scenario: Changing the order of a column
	Given I open the WorkItems view
	Given I open the ColumnPicker	
	When I drag Column at position '1' to position '2' in the ColumnPicker
	Then the ColumnPicker Column 'Action' should be at position '2'
	And the ColumnPicker Column 'Created by' should be at position '1'
		