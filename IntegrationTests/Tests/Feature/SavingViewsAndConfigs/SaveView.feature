@Chrome
Feature: SaveView
	Show that a saved view retains it's filters, columns, grouping, sorting and theme.

Background: 
	Given I open the WorkItems view

Scenario: SaveView retains Filters
	Given I open the Filter Picker
	#need to finish the model for the filter picker.

Scenario: SaveView retains Columns
	Given I open the ColumnPicker
	When the Column 'All day' is added
	And the ColumnPicker 'Apply' button is clicked
	And I save the current View
	When the Tab ContextMenu is right-clicked
	And the Tab ContextMenu 'Reload' is clicked
	Then the Column 'All day' should be visible in the GridView

Scenario: SaveView retains Grouping
	Given I open the GroupPicker
	When I group by 'Subject' in the GroupPicker
	And I click 'Apply' in the GroupPicker
	And I save the current View
	When the Tab ContextMenu is right-clicked
	And the Tab ContextMenu 'Reload' is clicked
	Then the GridView should have a subheader that starts with 'Subject'

Scenario: SaveView retains Sorting
	# Broken. Error response: "Input string was not in a correct format."
	#Given I have opened the ColumnSortPicker
	#When I add the column 'Subject' in the ColumnSortPicker
	#And I click 'Apply' in the ColumnSortPicker
	#And I save the current View
	#When the Tab ContextMenu is right-clicked
	#And the Tab ContextMenu 'Reload' is clicked
	#Then ensure the data has sorted correctly, or check cell value.


Scenario: SaveView retains Theme
	Given I have opened the ThemePicker
	When the ThemePicker colour 'Indigo' is clicked
	And the ThemePicker 'Apply to View' button is clicked
	When I save the current View
	And the Tab ContextMenu is right-clicked
	And the Tab ContextMenu 'Reload' is clicked
	Then the Background colour is 'Indigo'
