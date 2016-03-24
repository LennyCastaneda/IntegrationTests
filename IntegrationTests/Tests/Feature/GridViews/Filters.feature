@Chrome
Feature: Filters
	Show that through the Filter Picker a user can change the data visible in the gridview.

Background:
	Given I open the WorkItems view
	Given the ColumnPicker is open
	When I add the column 'Action' in the ColumnSortPicker
	And I add the column 'Body' in the ColumnSortPicker
	And I add the column 'Created date' in the ColumnSortPicker
	And I click 'Apply' in the Filter Picker

Scenario: Click Cancel
	Given I open the Filter Picker
	When I click 'Cancel' in the Filter Picker
	Then the Filter Picker should not be visible

Scenario: Click Add New Group
	Given I open the Filter Picker
	When I click 'Add New Group' in the Filter Picker
	Then the Filter Picker should be visible

Scenario: Filter by Checklist
	Given I open the Filter Picker
	When in Filter Picker group number '1' filter number '1' I select the Field 'Action'
	And in Filter Picker group number '1' filter number '1' I click the filter
	And in Filter Picker group '1' filter number '1' in the CheckedList I search for 'Purchase'
	And the Filter Picker group '1' filter number '1' checkbox item 'Purchase' is clicked
	And I click 'Apply' in the Filter Picker
	Then the Filter Picker should not be visible

Scenario: Filter by Date Filter
	Given I open the Filter Picker
	When in Filter Picker group number '1' filter number '1' I select the Field 'Created date'
	And in Filter Picker group number '1' filter number '1' I click the filter
	And I check the 'Between' radio button in the DateSelectFilter
	And I enter the start date '26/04/2015' into the DateSelectFilter
	And I enter the end date '03/08/2015' into the DateSelectFilter
	# does not yet work due to backend (Ed) issues.

Scenario: Filter by String Comparison
	Given I open the Filter Picker
	When in Filter Picker group number '1' filter number '1' I select the Field 'Body'
	And in Filter Picker group number '1' filter number '1' I click the filter
	And I enter 'Odio' into 'Starts With' in the StringSelectFilter
	And I click 'Apply' in the Filter Picker
	Then the GridView cell at row '1' column 'Body' should start with 'Odio'