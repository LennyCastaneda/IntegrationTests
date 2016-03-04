@Chrome
Feature: InteractiveGrid

Scenario: Changing the width of columns 
	Given I open the WorkItems view
	When the GridView Column 'name' is dragged right
	Then the GridView Column 'name' width should have increased

Scenario: Sorting column items 
	Given I open the WorkItems view
	When i click a column header
	Then the column items should be alphabetically sorted 