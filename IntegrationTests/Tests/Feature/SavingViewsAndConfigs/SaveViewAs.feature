@Chrome
Feature: SaveViewAs
	Show that a new view can be created with a user defined name.

Scenario: Save new View As
	Given I open the WorkItems view
	When I save the current View as 'New View'
	Then the Tab 'New View' should be active
	And the view 'New View' should be visible in the 'Workflow Tool' module
	