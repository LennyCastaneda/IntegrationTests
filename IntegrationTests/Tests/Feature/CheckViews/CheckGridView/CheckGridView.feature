@Chrome
Feature: Check GridView
	As a user of a table
	I would like to resize columns
	to better view the data.

Scenario: MakeColumnBigger
	Given a 'GridView' is open
	When the GridView Column 'name' is dragged right
	Then the GridView Column 'name' width should have increased

Scenario: MakeColumnSmaller
	Given a 'GridView' is open
	When the GridView Column 'name' is dragged left
	Then the GridView Column 'name' width should have decreased