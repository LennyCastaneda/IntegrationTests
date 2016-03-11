@Chrome
Feature: Filters

Background:
	Given I open the WorkItems view

Scenario: #Test# Click Apply
	Given I open the Filter Picker
	When I click 'Apply' in the Filter Picker
	Then the Filter Picker should not be visible

Scenario: #Test# Click Cancel
	Given I open the Filter Picker
	When I click 'Cancel' in the Filter Picker
	Then the Filter Picker should not be visible

Scenario: #Test# Click Add New Group
	Given I open the Filter Picker
	When I click 'Add New Group' in the Filter Picker
	Then the Filter Picker should be visible

Scenario: #Test# Apply a filter
	Given I open the Filter Picker
	When I click 'Add New Group' in the Filter Picker
	And in Filter Picker group number '1' filter number '1' I select the Field 'Action'
	And in Filter Picker group number '1' filter number '1' I click the filter
	And in Filter Picker group '1' filter number '1' in the ListFilter I search for 'Aliquet'
	And in Filter Picker group '1' filter number '1' in the StringFilter I check 'Aliquet'
	When I click 'Apply' in the Filter Picker
	Then the Filter Picker should not be visible