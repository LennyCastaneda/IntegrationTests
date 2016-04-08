@Chrome
Feature: InteractiveGrid
	Show that the gridview columns can be resized
	And the column sort order can be changed from ascending to descending by clicking on the column header arrow.

Scenario: Changing the width of columns 
	Given I open the WorkItems view
	When the GridView Column 'Created by' is dragged right
	Then the GridView Column 'Created by' width should have increased