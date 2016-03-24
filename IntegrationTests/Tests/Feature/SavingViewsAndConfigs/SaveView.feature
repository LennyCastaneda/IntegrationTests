@Chrome
Feature: SaveView
	Show that a saved view retains it's filters, columns, grouping and sorting.

Background: 
	Given I open the WorkItems view

Scenario: SaveView retains Filters
	Given I open the Filter Picker
	#need to finish the model for the filter picker.

Scenario: SaveView retains Columns
	Given I open the ColumnPicker
	When the Column '{name}' is added
	And the ColumnPicker 'Apply' button is clicked
	And I save the current View
	When the Tab ContextMenu 'Reload' is clicked
	Then the Column '{name}' should be visible in the GridView

Scenario: SaveView retains Grouping
	Given I open the GroupPicker
	When I group by '{name}' in the GroupPicker
	And I click 'Apply' in the GroupPicker
	And I save the current View
	When the Tab ContextMenu 'Reload' is clicked
	Then the GridView should have a subheader that starts with '{name}'

Scenario: SaveView retains Sorting
	Given I have opened the ColumnSortPicker
	When I add the column '{name}' in the ColumnSortPicker
	And I click 'Apply' in the ColumnSortPicker
	And I save the current View
	When the Tab ContextMenu 'Reload' is clicked
	#Then ensure the data has sorted correctly, or check cell value.
