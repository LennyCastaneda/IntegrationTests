@Chrome
Feature: DataSorting
	Show that through the Column Sort Order Picker a user can change the ordering of a gridview.
	Also show the ability to add multiple concatenated sorting and change their order.

Background: 
	Given I open the WorkItems view

Scenario: Add a Sort Order
	Given I have opened the ColumnSortPicker
	When I add the column 'Action' in the ColumnSortPicker
	And I click 'Apply' in the ColumnSortPicker
	Then the GridView Table first row column 'Action' text should be 'Purchase'

Scenario: Change the Sort Order
	Given I have opened the ColumnSortPicker
	When I add the column 'Subject' in the ColumnSortPicker
	And I click the arrow on column 'Subject' in the ColumnSortPicker
	And I click 'Apply' in the ColumnSortPicker
	Then the GridView Table first row column 'Subject' text should be 'Porta placerat'

Scenario: Add multiple sorting columns
	Given I have opened the ColumnSortPicker
	When I add the column 'Action' in the ColumnSortPicker
	And I add the column 'Subject' in the ColumnSortPicker
	And I click 'Apply' in the ColumnSortPicker
	Then the GridView cell at row '1' column 'Action' should equal 'Purchase'
	And the GridView cell at row '1' column 'Subject' should equal 'Suspendisse ipsum risus,'

Scenario: Change the Column Order for Sorting
	Given I have opened the ColumnSortPicker
	When I add the column 'Action' in the ColumnSortPicker
	And I add the column 'Subject' in the ColumnSortPicker
	And I drag column at position '1' to position '2' in the ColumnSortPicker
	And I click 'Apply' in the ColumnSortPicker
	Then the GridView cell at row '1' column 'Subject' should equal 'Suspendisse ipsum risus,'

Scenario: Remove a sort order
	Given I have opened the ColumnSortPicker
	When I add the column 'Action' in the ColumnSortPicker
	And I remove the column 'Action' in the ColumnSortPicker
	And I click 'Apply' in the ColumnSortPicker
	Then the GridView cell at row '1' column 'Subject' should equal 'Porta placerat'