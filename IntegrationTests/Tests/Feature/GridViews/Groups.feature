@Chrome 
Feature: Groups
	Show that the data in a grid view can be "Grouped" by the available columns.

Background: 
	Given I open the WorkItems view

Scenario: Open Group Picker
	Given I open the GroupPicker
	When I group by 'Action' in the GroupPicker
	And I click 'Apply' in the GroupPicker
	Then the GridView should have a subheader that starts with 'Action'
