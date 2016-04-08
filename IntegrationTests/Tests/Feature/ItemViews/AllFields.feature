@Chrome
Feature: AllFields
	Show that in a GridView, when a user double clicks a row, it opens an Item View.

Scenario: Double Click GridView row
	Given I open the WorkItems view
	When I double-click row '2' in the GridView
	Then the active view should be an ItemView
 