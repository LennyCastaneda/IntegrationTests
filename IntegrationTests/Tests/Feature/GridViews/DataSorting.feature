@Chrome
Feature: DataSorting

Background: 
	Given I open the WorkItems view

Scenario: Add a Sort Order
	Given I have opened the ColumnSortPicker
	When I add the column 'Action' in the ColumnSortPicker
	Then the GridView Table first row column 'Action' text should be 'Purchase'

Scenario: Change the Sort Order
	Given I have opened the ColumnSortPicker
	When I add the column 'Action' in the ColumnSortPicker
	And I click the arrow on column 'Action' in the ColumnSortPicker
	Then the GridView Table first row column 'Action' text should be 'Chase Up'

Scenario: Add multiple sorting columns
	Given I have opened the ColumnSortPicker
	When I add the column 'Action' in the ColumnSortPicker
	And I add the column 'Subject' in the ColumnSortPicker
	Then the GridView cell at row '1' column 'Action' should equal 'Chase Up'
	And the GridView cell at row '1' column 'Subject' should equal '<insert value here>'

Scenario: Change the Column Order for Sorting
	Given I have opened the ColumnSortPicker
	When I add the column 'Action' in the ColumnSortPicker
	And I add the column 'Subject' in the ColumnSortPicker
	And I drag column at position '1' to position '2' in the ColumnSortPicker
	Then the GridView cell at row '1' column 'Action' should equal 'Chase Up'