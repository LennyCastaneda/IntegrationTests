@Chrome
Feature: ColumnPicker

Background: 
	Given I open the WorkItems view

Scenario: Adding a column
	Given the ColumnPicker is open
	When the Column 'Body' is added
	Then the Column 'Body' should be visible in the GridView
	
Scenario: Removing a column	
	Given I open the ColumnPicker
	When the Column 'Action' is removed
	Then the Column 'Action' should not be visible in the GridView
	
Scenario: Changing the order of a column
	Given I open the ColumnPicker	
	When I drag the Column 'Action' to position '1' in the ColumnPicker
	Then the ColumnPicker Column 'Action' should be at position '1'
		